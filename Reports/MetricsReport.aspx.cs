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
    int tot = 0;

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
                if (!String.IsNullOrEmpty(e.Row.Cells[i].Text))
                {
                    tot = tot = Convert.ToInt32(e.Row.Cells[i].Text);
                }
            }

            string colName2 = ((System.Web.UI.WebControls.BoundField)((DataControlFieldCell)e.Row.Cells[i]).ContainingField).DataField;
            string tes = "";


        }

        string colName1 = ((System.Web.UI.WebControls.BoundField)((DataControlFieldCell)e.Row.Cells[51]).ContainingField).DataField;
        string tes11 = "";
        colName1 = ((System.Web.UI.WebControls.BoundField)((DataControlFieldCell)e.Row.Cells[52]).ContainingField).DataField;
        string tes22 = "";

        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            string tes51 = e.Row.Cells[51].ToString();
            string tes52 = e.Row.Cells[52].ToString();

        }
        //e.Row.Cells[0].Text.Remove;
        //t.Columns.Remove("columnName");

        //if (e.Row.RowType == DataControlRowType.Header)
        //{
        //    string sql1 = "SELECT YEAR, METRICS_ID, CATEGORY, FIELD, JAN, FEB, MAR, APR, MAY, JUN, JUL, AUG, SEP, OCT, NOV, DEC FROM METRICS WHERE YEAR >= '" + startyy + "' AND  YEAR <= '" + endyy + "' ORDER BY METRICS_ID";
        //    DataTable dt1 = DBHelper.SelectDataTable(sql1);

        //    if (dt1.Columns.Count > 0)
        //    {
        //        int n = 0;
        //        for (int i = 2; i < monthCnt + 4; i++)
        //        {
        //            if (i < 4)
        //            {
        //                e.Row.Cells[n].Text = dt1.Columns[i].ToString();
        //            }
        //            else
        //            {
        //                e.Row.Cells[n].Text = ddlStartDate.SelectedItem.ToString();
        //                if (monthCnt > 1)
        //                {
        //                    if (startMonth == 12)
        //                    {

        //                    }


        //                }


        //            }
        //            n = n + 1;
        //        }
        //    }
        //}
        //string sql = "SELECT YEAR, METRICS_ID, CATEGORY, FIELD, JAN, FEB, MAR, APR, MAY, JUN, JUL, AUG, SEP, OCT, NOV, DEC FROM METRICS WHERE YEAR = '" + startyy + "' ORDER BY METRICS_ID";
        //DataTable dt = DBHelper.SelectDataTable(sql);

        //if (e.Row.RowType == DataControlRowType.DataRow)
        //{

        //    if (dt.Rows.Count > cnt)
        //    {
        //        e.Row.Cells[0].Text = (((DataRow)(dt.Rows[cnt]))["CATEGORY"]).ToString();
        //        e.Row.Cells[1].Text = (((DataRow)(dt.Rows[cnt]))["FIELD"]).ToString();
        //        e.Row.Cells[2].Text = (((DataRow)(dt.Rows[cnt]))["JAN"]).ToString();
        //        e.Row.Cells[3].Text = (((DataRow)(dt.Rows[cnt]))["FEB"]).ToString();
        //        e.Row.Cells[4].Text = (((DataRow)(dt.Rows[cnt]))["MAR"]).ToString();
        //        e.Row.Cells[5].Text = (((DataRow)(dt.Rows[cnt]))["APR"]).ToString();
        //        cnt = cnt + 1;
        //    }
        //}
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
            }
            GridView1.DataBind();
        }


    }
   
    protected void btnClear_Click(object sender, EventArgs e)
    {
        //txtStartDate.Text = String.Empty;
        //txtEndDate.Text = String.Empty;
    }
    //protected void btnExport_Click(object sender, EventArgs e)
    //{
    //    DataView dv = (DataView)dsExport.Select(DataSourceSelectArguments.Empty);
    //    DataTable dt = (DataTable)dv.ToTable();
    //    Excel.ExportToExcelCenter(dt, "Tech Time Sheet Report");
    //}
}
