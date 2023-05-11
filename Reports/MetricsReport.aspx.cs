using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Agile.Domain;
using Agile.Helper;
using Agile.Services.Interface;
using Agile.Services.Impl;
using System.Drawing;

public partial class Reports_MetricsReport : System.Web.UI.Page
{
    string errors = "";
    string startyy = "";
    string endyy = "";
    string firstTime = "Y";
    int monthCnt = 0;
    int yearCnt = 0;
    int startDt = 0;
    int endDt = 0;
    int startMonth = 0;
    int endMonth = 0;
    int nextMonth = 0;
    int nextYear = 0;
    int startYear = 0;
    int endYear = 0;
    int cnt = 0;
    int i = 3;
    decimal tot = 0;
    decimal totSurveyRound = 0;
    decimal calAve = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        string user = Session["userId"].ToString();
    }
    protected void ddlAddSelect(object sender, EventArgs e)
    {
        DropDownList ddl = (DropDownList)sender;
        ddl.Items.Insert(0, new ListItem("-- Select --", ""));
    }
    protected void Gridview1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        GridView1.Visible = true;

        startyy = ddlStartDate.SelectedValue.Substring(0, 4);
        endyy = ddlEndDate.SelectedValue.Substring(0, 4);

        e.Row.Cells[0].BackColor = Color.Orange;
        e.Row.Cells[1].BackColor = Color.Orange;
        e.Row.Cells[2].BackColor = Color.Orange;

        for (int i = 3; i < 51; i++)
        {
            string colName = ((System.Web.UI.WebControls.BoundField)((DataControlFieldCell)e.Row.Cells[i]).ContainingField).DataField;
            int yr = int.Parse(colName.Substring(3, 4));
            string col = "";
            switch (colName.Substring(0, 3))
            {
                case "JAN":
                    col = yr.ToString() + "01";
                    break;
                case "FEB":
                    col = yr.ToString() + "02";
                    break;
                case "MAR":
                    col = yr.ToString() + "03";
                    break;
                case "APR":
                    col = yr.ToString() + "04";
                    break;
                case "MAY":
                    col = yr.ToString() + "05";
                    break;
                case "JUN":
                    col = yr.ToString() + "06";
                    break;
                case "JUL":
                    col = yr.ToString() + "07";
                    break;
                case "AUG":
                    col = yr.ToString() + "08";
                    break;
                case "SEP":
                    col = yr.ToString() + "09";
                    break;
                case "OCT":
                    col = yr.ToString() + "10";
                    break;
                case "NOV":
                    col = yr.ToString() + "11";
                    break;
                case "DEC":
                    col = yr.ToString() + "12";
                    break;
                default:
                    break;
            }

            if (Convert.ToInt32(col) < Convert.ToInt32(ddlStartDate.SelectedValue) || Convert.ToInt32(col) > Convert.ToInt32(ddlEndDate.SelectedValue))
            {
                e.Row.Cells[i].Visible = false;
            }
            else
            {
                if (!String.IsNullOrEmpty(e.Row.Cells[i].Text) && e.Row.Cells[i].Text != "&nbsp;")
                {
                    tot = tot + Convert.ToDecimal(e.Row.Cells[i].Text);
                    if (e.Row.Cells[2].Text == "Likeliness to Recommend")
                    {
                        tot = 0;
                        totSurveyRound = totSurveyRound + Convert.ToDecimal(e.Row.Cells[i].Text);
                    }
                }
            }
        }

        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (((System.Web.UI.WebControls.BoundField)((DataControlFieldCell)e.Row.Cells[51]).ContainingField).DataField == "TOTAL")
            {               
                if (e.Row.Cells[2].Text == "Likeliness to Recommend")
                {
                    e.Row.Cells[51].Text = "";
                }
                else
                {
                    e.Row.Cells[51].Text = tot.ToString();
                }
            }

            if (((System.Web.UI.WebControls.BoundField)((DataControlFieldCell)e.Row.Cells[52]).ContainingField).DataField == "AVE")
            {
                if (e.Row.Cells[2].Text == "Likeliness to Recommend" || e.Row.Cells[2].Text == "REHD likeliness to Recommend")
                {
                    calAve = Math.Round((totSurveyRound / monthCnt), 2);
                }
                else
                {
                    if (e.Row.Cells[2].Text.Contains("Attrition %"))
                    {
                        calAve = Math.Round((tot / monthCnt), 1);
                    }
                    else
                    {
                        if (e.Row.Cells[2].Text == "Critical Alarm Close Time" || e.Row.Cells[2].Text == "CLEC Call Back Average" || e.Row.Cells[2].Text == "Percentage of surveys completed" || e.Row.Cells[2].Text == "REHD percentage of surveys completed")
                        {
                            calAve = Math.Round((tot / monthCnt), 2);
                        }
                        else
                        {
                            calAve = (decimal)Math.Round((decimal)tot / (decimal)monthCnt);
                        }
                    }
                }
                e.Row.Cells[52].Text = calAve.ToString();
                tot = 0;
            }
        }
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {

        if (ddlStartDate.SelectedIndex == 0 || ddlEndDate.SelectedIndex == 0)
        {
            errors = "Start Date and End Date must be entered";
            AgileUtils.ShowAlert(errors);
        }
        else
        {
            btnExport.Visible = true;
            startDt = Convert.ToInt32(ddlStartDate.Text);
            endDt = Convert.ToInt32(ddlEndDate.Text);
            startMonth = Convert.ToInt32(startDt.ToString().Substring(4, 2));
            endMonth = Convert.ToInt32(endDt.ToString().Substring(4, 2));
            startYear = Convert.ToInt32(startDt.ToString().Substring(0, 4));
            endYear = Convert.ToInt32(endDt.ToString().Substring(0, 4));

            if (startDt > endDt)
            {
                errors = "End Date must be after Start Date";
                AgileUtils.ShowAlert(errors);
            }
            else
            {
                yearCnt = endYear - startYear + 1;
                if (yearCnt == 1)
                {
                    monthCnt = endMonth - startMonth + 1;
                }
                else
                {
                    monthCnt = endMonth - startMonth + 13;
                }
                GridView1.DataBind();
            }
        }
    }
    protected void btnExport_Click(object sender, EventArgs e)
    {
        startDt = Convert.ToInt32(ddlStartDate.Text);
        endDt = Convert.ToInt32(ddlEndDate.Text);
        startMonth = Convert.ToInt32(startDt.ToString().Substring(4, 2));
        endMonth = Convert.ToInt32(endDt.ToString().Substring(4, 2));
        startYear = Convert.ToInt32(startDt.ToString().Substring(0, 4));
        endYear = Convert.ToInt32(endDt.ToString().Substring(0, 4));
        yearCnt = endYear - startYear + 1;
        if (yearCnt == 1)
        {
            monthCnt = endMonth - startMonth + 1;
        }
        else
        {
            monthCnt = endMonth - startMonth + 13;
        }

        DataView dv = (DataView)dsExport.Select(DataSourceSelectArguments.Empty);
        DataTable dt = (DataTable)dv.ToTable();

        for (int i = 3; i < dt.Columns.Count; i++)
        {
            string colName = dt.Columns[i].ColumnName;
            if (colName != "TOTAL" && colName != "AVE")
            {
                int yr = int.Parse(colName.Substring(3, 4));
                string col = "";
                switch (colName.Substring(0, 3))
                {
                    case "JAN":
                        col = yr.ToString() + "01";
                        break;
                    case "FEB":
                        col = yr.ToString() + "02";
                        break;
                    case "MAR":
                        col = yr.ToString() + "03";
                        break;
                    case "APR":
                        col = yr.ToString() + "04";
                        break;
                    case "MAY":
                        col = yr.ToString() + "05";
                        break;
                    case "JUN":
                        col = yr.ToString() + "06";
                        break;
                    case "JUL":
                        col = yr.ToString() + "07";
                        break;
                    case "AUG":
                        col = yr.ToString() + "08";
                        break;
                    case "SEP":
                        col = yr.ToString() + "09";
                        break;
                    case "OCT":
                        col = yr.ToString() + "10";
                        break;
                    case "NOV":
                        col = yr.ToString() + "11";
                        break;
                    case "DEC":
                        col = yr.ToString() + "12";
                        break;
                    default:
                        break;
                }
                if (Convert.ToInt32(col) < Convert.ToInt32(ddlStartDate.SelectedValue) || Convert.ToInt32(col) > Convert.ToInt32(ddlEndDate.SelectedValue))
                {
                    dt.Columns.Remove(colName);
                    i = i - 1;
                }
            }
        }

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            for (int c = 3; c < dt.Columns.Count; c++)
            {
                string colName = dt.Columns[c].ColumnName;
                if (colName == "TOTAL")
                {
                    if (dt.Rows[i][2].ToString() == "Likeliness to Recommend")
                    {
                        dt.Rows[i][c] = "";
                    }
                    else
                    {
                        dt.Rows[i][c] = tot;
                    }
                    
                }
                else
                {
                    if (colName == "AVE")
                    {
                        if (dt.Rows[i][2].ToString() == "Critical Alarm Close Time" || dt.Rows[i][2].ToString() == "CLEC Call Back Average" || dt.Rows[i][2].ToString() == "Percentage of surveys completed" || dt.Rows[i][2].ToString() == "Likeliness to Recommend")
                        {
                            calAve = (decimal)Math.Round(((decimal)tot / (decimal)monthCnt), 2);
                        }
                        else
                        {
                            if (dt.Rows[i][2].ToString().Contains("Attrition %"))
                            {
                                calAve = Math.Round((tot / monthCnt), 1);
                            }
                            else
                            {
                                calAve = (decimal)Math.Round((decimal)tot / (decimal)monthCnt);
                            }
                        }
                        dt.Rows[i][c] = calAve.ToString();
                        tot = 0;
                    }
                    else
                    {                        
                        if (!String.IsNullOrEmpty(dt.Rows[i][c].ToString()) )
                        {
                            tot = tot + Convert.ToDecimal(dt.Rows[i][c]);
                        }
                    }
                }          
            }
        }
        Excel.ExportToExcelCenter(dt, "Metrics Report");
    }
}
