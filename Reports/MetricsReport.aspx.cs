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
    int months = 0;
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
    decimal EnvironmentalAlarms = 0;

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

        e.Row.Cells[0].Visible = false;

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
                    monthCnt = monthCnt + 1;

                    // display dollar format for month detail amounts
                    switch (e.Row.Cells[0].Text)
                    {
                        case "110200":
                        case "111000":
                        case "111100":
                        case "111200":
                        case "111300":
                        case "111400":
                            e.Row.Cells[i].Text = string.Format("{0:C2}", Convert.ToDecimal(e.Row.Cells[i].Text));
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (((System.Web.UI.WebControls.BoundField)((DataControlFieldCell)e.Row.Cells[51]).ContainingField).DataField == "TOTAL")
            {
                e.Row.Cells[51].Text = tot.ToString();

                // display dollar format for total detail amounts 
                switch (e.Row.Cells[0].Text)
                {
                    case "110200":
                    case "111000":
                    case "111100":
                    case "111200":
                    case "111300":
                    case "111400":
                        e.Row.Cells[51].Text = string.Format("{0:C2}", Convert.ToDecimal(e.Row.Cells[51].Text));
                        break;
                    default:
                        break;
                }
            }

            if (((System.Web.UI.WebControls.BoundField)((DataControlFieldCell)e.Row.Cells[52]).ContainingField).DataField == "AVE")
            {
                if (monthCnt > 0)
                {
                    switch (e.Row.Cells[0].Text)
                    {
                        case "104200":
                        case "104500":
                        case "104800":
                        case "105100":
                        case "109100":
                        case "109200":
                        case "109600":
                        case "109700":
                            if (monthCnt > 0)
                            {
                                calAve = Math.Round((tot / monthCnt), 3);
                                e.Row.Cells[52].Text = calAve.ToString();
                            }
                            break;
                        case "105400":
                        case "109000":
                        case "109500":
                        case "110100":
                            if (monthCnt > 0)
                            {
                                calAve = Math.Round((tot / monthCnt), 2);
                                e.Row.Cells[52].Text = calAve.ToString();
                            }
                            break;
                        // display dollar format for average detail amounts
                        case "110200":
                        case "111000":
                        case "111100":
                        case "111200":
                        case "111300":
                        case "111400":
                            if (monthCnt > 0)
                            {
                                calAve = Math.Round((tot / monthCnt), 2);
                                e.Row.Cells[52].Text = calAve.ToString("C2");
                            }
                            break;
                        case "111900":
                        case "112000":
                            if (monthCnt > 0)
                            {
                                calAve = (decimal)Math.Round((decimal)tot / (decimal)monthCnt, MidpointRounding.AwayFromZero);
                                e.Row.Cells[52].Text = calAve.ToString();
                                EnvironmentalAlarms = EnvironmentalAlarms + Math.Round((tot / monthCnt), 2);
                            }
                            break;
                        case "112100":
                            if (monthCnt > 0)
                            {
                                EnvironmentalAlarms = Math.Round(EnvironmentalAlarms);
                                e.Row.Cells[52].Text = EnvironmentalAlarms.ToString();
                            }
                            break;
                        default:
                            if (monthCnt > 0)
                            {
                                calAve = (decimal)Math.Round((decimal)tot / (decimal)monthCnt, MidpointRounding.AwayFromZero);
                                e.Row.Cells[52].Text = calAve.ToString();
                            }
                            break;
                    }
                    tot = 0;
                    monthCnt = 0;
                }
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

            DateTime firstDate = new DateTime(startYear, startMonth, 01);
            DateTime secondDate = new DateTime(endYear, endMonth, 01);
            int m1 = (secondDate.Month - firstDate.Month);
            int m2 = (secondDate.Year - firstDate.Year) * 12;
            months = m1 + m2;

            if (startDt > endDt)
            {
                errors = "End Date must be after Start Date";
                AgileUtils.ShowAlert(errors);
            }
            else
            {
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

        DateTime firstDate = new DateTime(startYear, startMonth, 01);
        DateTime secondDate = new DateTime(endYear, endMonth, 01);
        int m1 = (secondDate.Month - firstDate.Month);
        int m2 = (secondDate.Year - firstDate.Year) * 12;
        months = m1 + m2;

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
                if (!String.IsNullOrEmpty(dt.Rows[i][c].ToString()))
                {
                    tot = tot + Convert.ToDecimal(dt.Rows[i][c]);
                    monthCnt = monthCnt + 1;

                    // display dollar format for month detail amounts
                    switch (dt.Rows[i][0].ToString())
                    {
                        case "110200":
                        case "111000":
                        case "111100":
                        case "111200":
                        case "111300":
                        case "111400":
                            dt.Rows[i][c] = string.Format("{0:C2}", Convert.ToDecimal(dt.Rows[i][c]));
                            break;
                        default:
                            break;
                    }

                }

                string colName = dt.Columns[c].ColumnName;
                if (colName == "TOTAL")
                {
                    dt.Rows[i][c] = tot;

                    // display dollar format for total detail amounts
                    switch (dt.Rows[i][0].ToString())
                    {
                        case "110200":
                        case "111000":
                        case "111100":
                        case "111200":
                        case "111300":
                        case "111400":
                            dt.Rows[i][c] = string.Format("{0:C2}", Convert.ToDecimal(dt.Rows[i][c]));
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    if (colName == "AVE")
                    {
                        switch (dt.Rows[i][0].ToString())
                        {
                            case "104200":
                            case "104500":
                            case "104800":
                            case "105100":
                            case "109100":
                            case "109200":
                            case "109600":
                            case "109700":
                                if (monthCnt > 0)
                                {
                                    calAve = Math.Round((tot / monthCnt), 3);
                                    dt.Rows[i][c] = calAve.ToString();
                                }
                                break;
                            case "105400":
                            case "109000":
                            case "109500":
                            case "110100":
                                if (monthCnt > 0)
                                {
                                    calAve = Math.Round((tot / monthCnt), 2);
                                    dt.Rows[i][c] = calAve.ToString();
                                }
                                break;
                            // display dollar format for average detail amounts
                            case "110200":
                            case "111000":
                            case "111100":
                            case "111200":
                            case "111300":
                            case "111400":
                                if (monthCnt > 0)
                                {
                                    calAve = Math.Round((tot / monthCnt), 2);
                                    dt.Rows[i][c] = calAve.ToString("C2");
                                }
                                break;
                            case "111900":
                            case "112000":
                                if (monthCnt > 0)
                                {
                                    calAve = (decimal)Math.Round((decimal)tot / (decimal)monthCnt, MidpointRounding.AwayFromZero);
                                    dt.Rows[i][c] = calAve.ToString();
                                    EnvironmentalAlarms = EnvironmentalAlarms + Math.Round((tot / monthCnt), 2);
                                }
                                break;
                            case "112100":
                                if (monthCnt > 0)
                                {
                                    EnvironmentalAlarms = Math.Round(EnvironmentalAlarms);
                                    dt.Rows[i][c] = EnvironmentalAlarms.ToString();
                                }
                                break;
                            default:
                                if (monthCnt > 0)
                                {
                                    calAve = (decimal)Math.Round((decimal)tot / (decimal)monthCnt, MidpointRounding.AwayFromZero);
                                    dt.Rows[i][c] = calAve.ToString();
                                }
                                break;
                        }

                        tot = 0;
                        monthCnt = 0;
                    }
                }
            }
        }
        dt.Columns.Remove("METRICS_ID");
        Excel.ExportToExcelCenter(dt, "Metrics Report");
    }
}
