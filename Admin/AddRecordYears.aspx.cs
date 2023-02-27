using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Agile.DAO;
using Agile.Domain;
using Agile.Services.Interface;
using Agile.Services.Impl;
using System.Drawing;
using Agile.Helper;

public partial class Admin_AddRecordYears : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (IsPostBack)
        {
            hfCopyYear.Value = ddlCopyYear.SelectedItem.Value;
            hfCreateYear.Value = ddlCreateYear.SelectedItem.Value;
        }
        else
        {
            ddlCopyYear.SelectedValue = hfCopyYear.Value = DateTime.Now.Year.ToString();
            ddlCreateYear.SelectedValue = hfCreateYear.Value = DateTime.Now.Year.ToString();
        }
    }
    protected void ddlCopyYear_OnTextChanged(object sender, EventArgs e)
    {
        hfCopyYear.Value = ddlCopyYear.SelectedItem.Value;
    }
    protected void ddlCreateYear_OnTextChanged(object sender, EventArgs e)
    {
        hfCreateYear.Value = ddlCreateYear.SelectedItem.Value;
    }
    protected void OnUpdate(object sender, EventArgs e)
    {
        LBLerror.Visible = false;
        LBLerror.Text = "";
        if (ddlCopyYear.SelectedValue == ddlCreateYear.SelectedValue)
        {
            LBLerror.Visible = true;
            LBLerror.Text = "Years can not be the same";
        }
        else
        {
            MetricsImpl mvi = new MetricsImpl();
            Metrics mv = mvi.SELECT_METRICS_BY_YEAR(ddlCopyYear.SelectedValue);
            if (String.IsNullOrEmpty(mv.Id))
            {
                LBLerror.Visible = true;
                LBLerror.Text = "Copy Year does not exist";
            }
            else
            {
                mv = mvi.SELECT_METRICS_BY_YEAR(ddlCreateYear.SelectedValue);
                if (!String.IsNullOrEmpty(mv.Id))
                {
                    LBLerror.Visible = true;
                    LBLerror.Text = "Create Year already exist";
                }
                else
                {
                    int copyYr = Convert.ToInt32(ddlCopyYear.SelectedValue);
                    int createYr = Convert.ToInt32(ddlCreateYear.SelectedValue);
                    string sql = "SELECT * FROM METRICS WHERE YEAR = " + copyYr + " ORDER BY ID";
                    DataTable dt = DBHelper.SelectDataTable(sql);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        mv.Id = DBHelper.SelectDecimal(Metrics.GET_METRICS_ID).ToString();
                        mv.Year = ddlCreateYear.SelectedValue;
                        mv.MetricsId = (((DataRow)(dt.Rows[i]))["METRICS_ID"]).ToString();
                        mv.Category = (((DataRow)(dt.Rows[i]))["CATEGORY"]).ToString();
                        mv.Field = (((DataRow)(dt.Rows[i]))["FIELD"]).ToString();
                        mv.Jan = mv.Feb = mv.Mar = mv.Apr = mv.May = mv.Jun = mv.Jul = mv.Aug = mv.Sep = mv.Oct = mv.Nov = mv.Dec = mv.Ytd = mv.Ave = "";
                        mv.Calc = (((DataRow)(dt.Rows[i]))["CALC"]).ToString();
                        mvi.Insert(mv);
                    }
                    LBLerror.Visible = true;
                    LBLerror.Text = "Records have been added";
                }
            }

        }

    }
}
