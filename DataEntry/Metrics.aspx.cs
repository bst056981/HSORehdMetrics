using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Agile.DAO;
using Agile.Domain;
//using Agile.Services.decimalerface;
using Agile.Services.Impl;
using System.Drawing;
using Agile.Helper;

public partial class DataEntry_Metrics : System.Web.UI.Page
{
    decimal months = 12;
    decimal ytd = 0;
    decimal ave = 0;
    decimal ave1 = 0;
    decimal ave2 = 0;
    decimal ytd1 = 0;
    decimal ytd2 = 0;
    decimal ytd3 = 0;
    decimal calcDecimal = 0;
    decimal cntJan = 0;
    decimal cntFeb = 0;
    decimal cntMar = 0;
    decimal cntApr = 0;
    decimal cntMay = 0;
    decimal cntJun = 0;
    decimal cntJul = 0;
    decimal cntAug = 0;
    decimal cntSep = 0;
    decimal cntOct = 0;
    decimal cntNov = 0;
    decimal cntDec = 0;
    decimal cntYtd = 0;
    decimal cntAve = 0;
    decimal cntJan1 = 0;
    decimal cntFeb1 = 0;
    decimal cntMar1 = 0;
    decimal cntApr1 = 0;
    decimal cntMay1 = 0;
    decimal cntJun1 = 0;
    decimal cntJul1 = 0;
    decimal cntAug1 = 0;
    decimal cntSep1 = 0;
    decimal cntOct1 = 0;
    decimal cntNov1 = 0;
    decimal cntDec1 = 0;
    decimal cntYtd1 = 0;
    decimal cntJan2 = 0;
    decimal cntFeb2 = 0;
    decimal cntMar2 = 0;
    decimal cntApr2 = 0;
    decimal cntMay2 = 0;
    decimal cntJun2 = 0;
    decimal cntJul2 = 0;
    decimal cntAug2 = 0;
    decimal cntSep2 = 0;
    decimal cntOct2 = 0;
    decimal cntNov2 = 0;
    decimal cntDec2 = 0;
    decimal cntYtd2 = 0;
    decimal cntJan3 = 0;
    decimal cntFeb3 = 0;
    decimal cntMar3 = 0;
    decimal cntApr3 = 0;
    decimal cntMay3 = 0;
    decimal cntJun3 = 0;
    decimal cntJul3 = 0;
    decimal cntAug3 = 0;
    decimal cntSep3 = 0;
    decimal cntOct3 = 0;
    decimal cntNov3 = 0;
    decimal cntDec3 = 0;
    decimal cntYtd3 = 0;
    decimal cntJan4 = 0;
    decimal cntFeb4 = 0;
    decimal cntMar4 = 0;
    decimal cntApr4 = 0;
    decimal cntMay4 = 0;
    decimal cntJun4 = 0;
    decimal cntJul4 = 0;
    decimal cntAug4 = 0;
    decimal cntSep4 = 0;
    decimal cntOct4 = 0;
    decimal cntNov4 = 0;
    decimal cntDec4 = 0;
    decimal cntYtd4 = 0;
    decimal cntJan5 = 0;
    decimal cntFeb5 = 0;
    decimal cntMar5 = 0;
    decimal cntApr5 = 0;
    decimal cntMay5 = 0;
    decimal cntJun5 = 0;
    decimal cntJul5 = 0;
    decimal cntAug5 = 0;
    decimal cntSep5 = 0;
    decimal cntOct5 = 0;
    decimal cntNov5 = 0;
    decimal cntDec5 = 0;
    decimal cntYtd5 = 0;
    decimal cntJan6 = 0;
    decimal cntFeb6 = 0;
    decimal cntMar6 = 0;
    decimal cntApr6 = 0;
    decimal cntMay6 = 0;
    decimal cntJun6 = 0;
    decimal cntJul6 = 0;
    decimal cntAug6 = 0;
    decimal cntSep6 = 0;
    decimal cntOct6 = 0;
    decimal cntNov6 = 0;
    decimal cntDec6 = 0;
    decimal cntYtd6 = 0;
    decimal cntJan7 = 0;
    decimal cntFeb7 = 0;
    decimal cntMar7 = 0;
    decimal cntApr7 = 0;
    decimal cntMay7 = 0;
    decimal cntJun7 = 0;
    decimal cntJul7 = 0;
    decimal cntAug7 = 0;
    decimal cntSep7 = 0;
    decimal cntOct7 = 0;
    decimal cntNov7 = 0;
    decimal cntDec7 = 0;
    decimal cntYtd7 = 0;
    decimal cntJanTotal = 0;
    decimal cntFebTotal = 0;
    decimal cntMarTotal = 0;
    decimal cntAprTotal = 0;
    decimal cntMayTotal = 0;
    decimal cntJunTotal = 0;
    decimal cntJulTotal = 0;
    decimal cntAugTotal = 0;
    decimal cntSepTotal = 0;
    decimal cntOctTotal = 0;
    decimal cntNovTotal = 0;
    decimal cntDecTotal = 0;
    decimal cntYtdTotal = 0;
    decimal cntJanTotalDecimal = 0;
    decimal cntFebTotalDecimal = 0;
    decimal cntMarTotalDecimal = 0;
    decimal cntAprTotalDecimal = 0;
    decimal cntMayTotalDecimal = 0;
    decimal cntJunTotalDecimal = 0;
    decimal cntJulTotalDecimal = 0;
    decimal cntAugTotalDecimal = 0;
    decimal cntSepTotalDecimal = 0;
    decimal cntOctTotalDecimal = 0;
    decimal cntNovTotalDecimal = 0;
    decimal cntDecTotalDecimal = 0;
    decimal cntYtdTotalDecimal = 0;
    decimal cntAveTotalDecimal = 0;
    decimal cntJanGrandTotal = 0;
    decimal cntFebGrandTotal = 0;
    decimal cntMarGrandTotal = 0;
    decimal cntAprGrandTotal = 0;
    decimal cntMayGrandTotal = 0;
    decimal cntJunGrandTotal = 0;
    decimal cntJulGrandTotal = 0;
    decimal cntAugGrandTotal = 0;
    decimal cntSepGrandTotal = 0;
    decimal cntOctGrandTotal = 0;
    decimal cntNovGrandTotal = 0;
    decimal cntDecGrandTotal = 0;
    decimal cntYtdGrandTotal = 0;
    decimal cntJan100800 = 0;
    decimal cntFeb100800 = 0;
    decimal cntMar100800 = 0;
    decimal cntApr100800 = 0;
    decimal cntMay100800 = 0;
    decimal cntJun100800 = 0;
    decimal cntJul100800 = 0;
    decimal cntAug100800 = 0;
    decimal cntSep100800 = 0;
    decimal cntOct100800 = 0;
    decimal cntNov100800 = 0;
    decimal cntDec100800 = 0;
    decimal cntYtd100800 = 0;
    decimal cntJan100900 = 0;
    decimal cntFeb100900 = 0;
    decimal cntMar100900 = 0;
    decimal cntApr100900 = 0;
    decimal cntMay100900 = 0;
    decimal cntJun100900 = 0;
    decimal cntJul100900 = 0;
    decimal cntAug100900 = 0;
    decimal cntSep100900 = 0;
    decimal cntOct100900 = 0;
    decimal cntNov100900 = 0;
    decimal cntDec100900 = 0;
    decimal cntYtd100900 = 0;
    decimal cntJan101000 = 0;
    decimal cntFeb101000 = 0;
    decimal cntMar101000 = 0;
    decimal cntApr101000 = 0;
    decimal cntMay101000 = 0;
    decimal cntJun101000 = 0;
    decimal cntJul101000 = 0;
    decimal cntAug101000 = 0;
    decimal cntSep101000 = 0;
    decimal cntOct101000 = 0;
    decimal cntNov101000 = 0;
    decimal cntDec101000 = 0;
    decimal cntYtd101000 = 0;
    decimal cntJan101100 = 0;
    decimal cntFeb101100 = 0;
    decimal cntMar101100 = 0;
    decimal cntApr101100 = 0;
    decimal cntMay101100 = 0;
    decimal cntJun101100 = 0;
    decimal cntJul101100 = 0;
    decimal cntAug101100 = 0;
    decimal cntSep101100 = 0;
    decimal cntOct101100 = 0;
    decimal cntNov101100 = 0;
    decimal cntDec101100 = 0;
    decimal cntYtd101100 = 0;
    decimal cntJan101800 = 0;
    decimal cntFeb101800 = 0;
    decimal cntMar101800 = 0;
    decimal cntApr101800 = 0;
    decimal cntMay101800 = 0;
    decimal cntJun101800 = 0;
    decimal cntJul101800 = 0;
    decimal cntAug101800 = 0;
    decimal cntSep101800 = 0;
    decimal cntOct101800 = 0;
    decimal cntNov101800 = 0;
    decimal cntDec101800 = 0;
    decimal cntYtd101800 = 0;
    decimal cntJan101900 = 0;
    decimal cntFeb101900 = 0;
    decimal cntMar101900 = 0;
    decimal cntApr101900 = 0;
    decimal cntMay101900 = 0;
    decimal cntJun101900 = 0;
    decimal cntJul101900 = 0;
    decimal cntAug101900 = 0;
    decimal cntSep101900 = 0;
    decimal cntOct101900 = 0;
    decimal cntNov101900 = 0;
    decimal cntDec101900 = 0;
    decimal cntYtd101900 = 0;
    decimal cntJan102000 = 0;
    decimal cntFeb102000 = 0;
    decimal cntMar102000 = 0;
    decimal cntApr102000 = 0;
    decimal cntMay102000 = 0;
    decimal cntJun102000 = 0;
    decimal cntJul102000 = 0;
    decimal cntAug102000 = 0;
    decimal cntSep102000 = 0;
    decimal cntOct102000 = 0;
    decimal cntNov102000 = 0;
    decimal cntDec102000 = 0;
    decimal cntYtd102000 = 0;
    decimal cntJan102100 = 0;
    decimal cntFeb102100 = 0;
    decimal cntMar102100 = 0;
    decimal cntApr102100 = 0;
    decimal cntMay102100 = 0;
    decimal cntJun102100 = 0;
    decimal cntJul102100 = 0;
    decimal cntAug102100 = 0;
    decimal cntSep102100 = 0;
    decimal cntOct102100 = 0;
    decimal cntNov102100 = 0;
    decimal cntDec102100 = 0;
    decimal cntYtd102100 = 0;
    decimal cntJan106500 = 0;
    decimal cntFeb106500 = 0;
    decimal cntMar106500 = 0;
    decimal cntApr106500 = 0;
    decimal cntMay106500 = 0;
    decimal cntJun106500 = 0;
    decimal cntJul106500 = 0;
    decimal cntAug106500 = 0;
    decimal cntSep106500 = 0;
    decimal cntOct106500 = 0;
    decimal cntNov106500 = 0;
    decimal cntDec106500 = 0;
    decimal cntYtd106500 = 0;
    decimal cntJan106600 = 0;
    decimal cntFeb106600 = 0;
    decimal cntMar106600 = 0;
    decimal cntApr106600 = 0;
    decimal cntMay106600 = 0;
    decimal cntJun106600 = 0;
    decimal cntJul106600 = 0;
    decimal cntAug106600 = 0;
    decimal cntSep106600 = 0;
    decimal cntOct106600 = 0;
    decimal cntNov106600 = 0;
    decimal cntDec106600 = 0;
    decimal cntYtd106600 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            hfYear.Value = ddlYear.SelectedItem.Value;
        }
        else
        {
            ddlYear.SelectedValue = hfYear.Value = DateTime.Now.Year.ToString();
        }
    }

    protected void ddlYear_OnTextChanged(object sender, EventArgs e)
    {
        hfYear.Value = ddlYear.SelectedItem.Value;
    }

    protected void Gridview_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            ((TextBox)e.Row.FindControl("txtCalc")).Text = DataBinder.Eval(e.Row.DataItem, "CALC").ToString();
            ((TextBox)e.Row.FindControl("txtJan")).Text = DataBinder.Eval(e.Row.DataItem, "JAN").ToString();
            ((TextBox)e.Row.FindControl("txtFeb")).Text = DataBinder.Eval(e.Row.DataItem, "FEB").ToString();
            ((TextBox)e.Row.FindControl("txtMar")).Text = DataBinder.Eval(e.Row.DataItem, "MAR").ToString();
            ((TextBox)e.Row.FindControl("txtApr")).Text = DataBinder.Eval(e.Row.DataItem, "APR").ToString();
            ((TextBox)e.Row.FindControl("txtMay")).Text = DataBinder.Eval(e.Row.DataItem, "MAY").ToString();
            ((TextBox)e.Row.FindControl("txtJun")).Text = DataBinder.Eval(e.Row.DataItem, "JUN").ToString();
            ((TextBox)e.Row.FindControl("txtJul")).Text = DataBinder.Eval(e.Row.DataItem, "JUL").ToString();
            ((TextBox)e.Row.FindControl("txtAug")).Text = DataBinder.Eval(e.Row.DataItem, "AUG").ToString();
            ((TextBox)e.Row.FindControl("txtSep")).Text = DataBinder.Eval(e.Row.DataItem, "SEP").ToString();
            ((TextBox)e.Row.FindControl("txtOct")).Text = DataBinder.Eval(e.Row.DataItem, "OCT").ToString();
            ((TextBox)e.Row.FindControl("txtNov")).Text = DataBinder.Eval(e.Row.DataItem, "NOV").ToString();
            ((TextBox)e.Row.FindControl("txtDec")).Text = DataBinder.Eval(e.Row.DataItem, "DEC").ToString();
            ((TextBox)e.Row.FindControl("txtYTD")).Text = DataBinder.Eval(e.Row.DataItem, "YTD").ToString();
            ((TextBox)e.Row.FindControl("txtAVE")).Text = DataBinder.Eval(e.Row.DataItem, "AVE").ToString();

            ((TextBox)e.Row.FindControl("txtYTD")).BackColor = Color.Orange;
            ((TextBox)e.Row.FindControl("txtAVE")).BackColor = Color.Orange;

            if (((TextBox)e.Row.FindControl("txtCalc")).Text == "Y")
            {
                ((TextBox)e.Row.FindControl("txtJan")).BackColor = Color.Orange;
                ((TextBox)e.Row.FindControl("txtFeb")).BackColor = Color.Orange;
                ((TextBox)e.Row.FindControl("txtMar")).BackColor = Color.Orange;
                ((TextBox)e.Row.FindControl("txtApr")).BackColor = Color.Orange;
                ((TextBox)e.Row.FindControl("txtMay")).BackColor = Color.Orange;
                ((TextBox)e.Row.FindControl("txtJun")).BackColor = Color.Orange;
                ((TextBox)e.Row.FindControl("txtJul")).BackColor = Color.Orange;
                ((TextBox)e.Row.FindControl("txtAug")).BackColor = Color.Orange;
                ((TextBox)e.Row.FindControl("txtSep")).BackColor = Color.Orange;
                ((TextBox)e.Row.FindControl("txtOct")).BackColor = Color.Orange;
                ((TextBox)e.Row.FindControl("txtNov")).BackColor = Color.Orange;
                ((TextBox)e.Row.FindControl("txtDec")).BackColor = Color.Orange;
                ((TextBox)e.Row.FindControl("txtJan")).Enabled = false;
                ((TextBox)e.Row.FindControl("txtFeb")).Enabled = false;
                ((TextBox)e.Row.FindControl("txtMar")).Enabled = false;
                ((TextBox)e.Row.FindControl("txtApr")).Enabled = false;
                ((TextBox)e.Row.FindControl("txtMay")).Enabled = false;
                ((TextBox)e.Row.FindControl("txtJun")).Enabled = false;
                ((TextBox)e.Row.FindControl("txtJul")).Enabled = false;
                ((TextBox)e.Row.FindControl("txtAug")).Enabled = false;
                ((TextBox)e.Row.FindControl("txtSep")).Enabled = false;
                ((TextBox)e.Row.FindControl("txtOct")).Enabled = false;
                ((TextBox)e.Row.FindControl("txtNov")).Enabled = false;
                ((TextBox)e.Row.FindControl("txtDec")).Enabled = false;
            }
        }
    }
    protected void OnUpdate(object sender, EventArgs e)
    {
        int i = 0;
        MetricsImpl mvi = new MetricsImpl();
        //var lastrow = GridView.Rows[GridView.Rows.Count - 1];

        var calc = "";
        foreach (GridViewRow row in GridView.Rows)
        {
            if (i <= GridView.Rows.Count)
            {
                Metrics mv = mvi.Select(GridView.DataKeys[i].Values[0].ToString());
                TextBox CalcBox = row.FindControl("txtCalc") as TextBox;
                calc = CalcBox.Text;

                if (calc == "N")
                {
                    TextBox janBox = row.FindControl("txtJan") as TextBox;
                    mv.Jan = janBox.Text;
                    TextBox febBox = row.FindControl("txtFeb") as TextBox;
                    mv.Feb = febBox.Text;
                    TextBox marBox = row.FindControl("txtMar") as TextBox;
                    mv.Mar = marBox.Text;
                    TextBox aprBox = row.FindControl("txtApr") as TextBox;
                    mv.Apr = aprBox.Text;
                    TextBox mayBox = row.FindControl("txtMay") as TextBox;
                    mv.May = mayBox.Text;
                    TextBox junBox = row.FindControl("txtJun") as TextBox;
                    mv.Jun = junBox.Text;
                    TextBox julBox = row.FindControl("txtJul") as TextBox;
                    mv.Jul = julBox.Text;
                    TextBox augBox = row.FindControl("txtAug") as TextBox;
                    mv.Aug = augBox.Text;
                    TextBox sepBox = row.FindControl("txtSep") as TextBox;
                    mv.Sep = sepBox.Text;
                    TextBox octBox = row.FindControl("txtOct") as TextBox;
                    mv.Oct = octBox.Text;
                    TextBox novBox = row.FindControl("txtNov") as TextBox;
                    mv.Nov = novBox.Text;
                    TextBox decBox = row.FindControl("txtDec") as TextBox;
                    mv.Dec = decBox.Text;

                    if (String.IsNullOrEmpty(decBox.Text)) { months = 11; }
                    if (String.IsNullOrEmpty(novBox.Text)) { months = 10; }
                    if (String.IsNullOrEmpty(octBox.Text)) { months = 9; }
                    if (String.IsNullOrEmpty(sepBox.Text)) { months = 8; }
                    if (String.IsNullOrEmpty(augBox.Text)) { months = 7; }
                    if (String.IsNullOrEmpty(julBox.Text)) { months = 6; }
                    if (String.IsNullOrEmpty(junBox.Text)) { months = 5; }
                    if (String.IsNullOrEmpty(mayBox.Text)) { months = 4; }
                    if (String.IsNullOrEmpty(aprBox.Text)) { months = 3; }
                    if (String.IsNullOrEmpty(marBox.Text)) { months = 2; }
                    if (String.IsNullOrEmpty(febBox.Text)) { months = 1; }

                    cntJan = String.IsNullOrEmpty(janBox.Text) ? 0 : Convert.ToDecimal(janBox.Text);
                    cntFeb = String.IsNullOrEmpty(febBox.Text) ? 0 : Convert.ToDecimal(febBox.Text);
                    cntMar = String.IsNullOrEmpty(marBox.Text) ? 0 : Convert.ToDecimal(marBox.Text);
                    cntApr = String.IsNullOrEmpty(aprBox.Text) ? 0 : Convert.ToDecimal(aprBox.Text);
                    cntMay = String.IsNullOrEmpty(mayBox.Text) ? 0 : Convert.ToDecimal(mayBox.Text);
                    cntJun = String.IsNullOrEmpty(junBox.Text) ? 0 : Convert.ToDecimal(junBox.Text);
                    cntJul = String.IsNullOrEmpty(julBox.Text) ? 0 : Convert.ToDecimal(julBox.Text);
                    cntAug = String.IsNullOrEmpty(augBox.Text) ? 0 : Convert.ToDecimal(augBox.Text);
                    cntSep = String.IsNullOrEmpty(sepBox.Text) ? 0 : Convert.ToDecimal(sepBox.Text);
                    cntOct = String.IsNullOrEmpty(octBox.Text) ? 0 : Convert.ToDecimal(octBox.Text);
                    cntNov = String.IsNullOrEmpty(novBox.Text) ? 0 : Convert.ToDecimal(novBox.Text);
                    cntDec = String.IsNullOrEmpty(decBox.Text) ? 0 : Convert.ToDecimal(decBox.Text);

                    ytd = cntJan + cntFeb + cntMar + cntApr + cntMay + cntJun + cntJul + cntAug + cntSep + cntOct + cntNov + cntDec;
                    mv.Ytd = ytd.ToString();
                    if (!String.IsNullOrEmpty(ytd.ToString()))
                    {
                        if (GridView.DataKeys[i].Values[1].ToString() == "109100")
                        {
                            ave = (decimal)Math.Round(((decimal)ytd / (decimal)months), 2);
                            mv.Ytd = "";
                        }
                        else
                        {
                            ave = (decimal)Math.Round((decimal)ytd / (decimal)months);
                        }
                        mv.Ave = ave.ToString();
                    }
                    else { mv.Ave = "0"; }

                    string sql = "UPDATE METRICS SET JAN = '" + mv.Jan + "', FEB = '" + mv.Feb + "', MAR = '" + mv.Mar + "', APR = '" + mv.Apr + "', MAY = '" + mv.May + "', Jun = '" + mv.Jun + "', JUL = '" + mv.Jul + "', AUG = '" + mv.Aug + "', SEP = '" + mv.Sep + "', OCT = '" + mv.Oct + "', NOV = '" + mv.Nov + "', DEC = '" + mv.Dec + "', YTD = '" + mv.Ytd + "', AVE = '" + mv.Ave + "' WHERE ID = '" + GridView.DataKeys[i].Values[0].ToString() + "'";
                    DBHelper.Execute(sql);

                    switch (GridView.DataKeys[i].Values[1].ToString())
                    {
                        case "100000":
                        case "101200":
                        case "101800":
                        case "102200":
                        case "106000":
                        case "106500":
                        case "107100":
                        case "107300":
                        case "107500":
                        case "107800":
                        case "108400":
                        case "108800":
                        case "109100":
                        case "109300":
                        case "110200":
                            cntJan1 = cntJan;
                            cntFeb1 = cntFeb;
                            cntMar1 = cntMar;
                            cntApr1 = cntApr;
                            cntMay1 = cntMay;
                            cntJun1 = cntJun;
                            cntJul1 = cntJul;
                            cntAug1 = cntAug;
                            cntSep1 = cntSep;
                            cntOct1 = cntOct;
                            cntNov1 = cntNov;
                            cntDec1 = cntDec;
                            cntYtd1 = cntYtd + cntJan + cntFeb + cntMar + cntApr + cntMay + cntJun + cntJul + cntAug + cntSep + cntOct + cntNov + cntDec;
                            if (GridView.DataKeys[i].Values[1].ToString() == "101800")
                            {
                                cntJan101800 = cntJan;
                                cntFeb101800 = cntFeb;
                                cntMar101800 = cntMar;
                                cntApr101800 = cntApr;
                                cntMay101800 = cntMay;
                                cntJun101800 = cntJun;
                                cntJul101800 = cntJul;
                                cntAug101800 = cntAug;
                                cntSep101800 = cntSep;
                                cntOct101800 = cntOct;
                                cntNov101800 = cntNov;
                                cntDec101800 = cntDec;
                                cntYtd101800 = cntJan + cntFeb + cntMar + cntApr + cntMay + cntJun + cntJul + cntAug + cntSep + cntOct + cntNov + cntDec;
                            }
                            if (GridView.DataKeys[i].Values[1].ToString() == "106500")
                            {
                                cntJan106500 = cntJan;
                                cntFeb106500 = cntFeb;
                                cntMar106500 = cntMar;
                                cntApr106500 = cntApr;
                                cntMay106500 = cntMay;
                                cntJun106500 = cntJun;
                                cntJul106500 = cntJul;
                                cntAug106500 = cntAug;
                                cntSep106500 = cntSep;
                                cntOct106500 = cntOct;
                                cntNov106500 = cntNov;
                                cntDec106500 = cntDec;
                                cntYtd106500 = cntJan + cntFeb + cntMar + cntApr + cntMay + cntJun + cntJul + cntAug + cntSep + cntOct + cntNov + cntDec;
                            }
                            break;
                        case "100100":
                        case "101300":
                        case "101900":
                        case "102300":
                        case "106100":
                        case "106600":
                        case "107600":
                        case "107900":
                        case "108500":
                        case "108900":
                        case "109400":
                        case "109700":
                        case "110300":
                            cntJan2 = cntJan;
                            cntFeb2 = cntFeb;
                            cntMar2 = cntMar;
                            cntApr2 = cntApr;
                            cntMay2 = cntMay;
                            cntJun2 = cntJun;
                            cntJul2 = cntJul;
                            cntAug2 = cntAug;
                            cntSep2 = cntSep;
                            cntOct2 = cntOct;
                            cntNov2 = cntNov;
                            cntDec2 = cntDec;
                            cntYtd2 = cntYtd + cntJan + cntFeb + cntMar + cntApr + cntMay + cntJun + cntJul + cntAug + cntSep + cntOct + cntNov + cntDec;
                            if (GridView.DataKeys[i].Values[1].ToString() == "101900")
                            {
                                cntJan101900 = cntJan;
                                cntFeb101900 = cntFeb;
                                cntMar101900 = cntMar;
                                cntApr101900 = cntApr;
                                cntMay101900 = cntMay;
                                cntJun101900 = cntJun;
                                cntJul101900 = cntJul;
                                cntAug101900 = cntAug;
                                cntSep101900 = cntSep;
                                cntOct101900 = cntOct;
                                cntNov101900 = cntNov;
                                cntDec101900 = cntDec;
                                cntYtd101900 = cntJan + cntFeb + cntMar + cntApr + cntMay + cntJun + cntJul + cntAug + cntSep + cntOct + cntNov + cntDec;
                            }
                            if (GridView.DataKeys[i].Values[1].ToString() == "106600")
                            {
                                cntJan106600 = cntJan;
                                cntFeb106600 = cntFeb;
                                cntMar106600 = cntMar;
                                cntApr106600 = cntApr;
                                cntMay106600 = cntMay;
                                cntJun106600 = cntJun;
                                cntJul106600 = cntJul;
                                cntAug106600 = cntAug;
                                cntSep106600 = cntSep;
                                cntOct106600 = cntOct;
                                cntNov106600 = cntNov;
                                cntDec106600 = cntDec;
                                cntYtd106600 = cntJan + cntFeb + cntMar + cntApr + cntMay + cntJun + cntJul + cntAug + cntSep + cntOct + cntNov + cntDec;
                            }
                            break;
                        case "100200":
                        case "101400":
                        case "102000":
                        case "102400":
                        case "106200":
                        case "106700":
                        case "108000":
                        case "108600":
                        case "109800":
                            cntJan3 = cntJan;
                            cntFeb3 = cntFeb;
                            cntMar3 = cntMar;
                            cntApr3 = cntApr;
                            cntMay3 = cntMay;
                            cntJun3 = cntJun;
                            cntJul3 = cntJul;
                            cntAug3 = cntAug;
                            cntSep3 = cntSep;
                            cntOct3 = cntOct;
                            cntNov3 = cntNov;
                            cntDec3 = cntDec;
                            cntYtd3 = cntYtd + cntJan + cntFeb + cntMar + cntApr + cntMay + cntJun + cntJul + cntAug + cntSep + cntOct + cntNov + cntDec;
                            if (GridView.DataKeys[i].Values[1].ToString() == "102000")
                            {
                                cntJan102000 = cntJan;
                                cntFeb102000 = cntFeb;
                                cntMar102000 = cntMar;
                                cntApr102000 = cntApr;
                                cntMay102000 = cntMay;
                                cntJun102000 = cntJun;
                                cntJul102000 = cntJul;
                                cntAug102000 = cntAug;
                                cntSep102000 = cntSep;
                                cntOct102000 = cntOct;
                                cntNov102000 = cntNov;
                                cntDec102000 = cntDec;
                                cntYtd102000 = cntJan + cntFeb + cntMar + cntApr + cntMay + cntJun + cntJul + cntAug + cntSep + cntOct + cntNov + cntDec;
                            }
                            break;
                        case "100400":
                        case "102500":
                        case "106300":
                        case "106800":
                        case "108100":
                        case "109900":
                            cntJan4 = cntJan;
                            cntFeb4 = cntFeb;
                            cntMar4 = cntMar;
                            cntApr4 = cntApr;
                            cntMay4 = cntMay;
                            cntJun4 = cntJun;
                            cntJul4 = cntJul;
                            cntAug4 = cntAug;
                            cntSep4 = cntSep;
                            cntOct4 = cntOct;
                            cntNov4 = cntNov;
                            cntDec4 = cntDec;
                            cntYtd4 = cntYtd + cntJan + cntFeb + cntMar + cntApr + cntMay + cntJun + cntJul + cntAug + cntSep + cntOct + cntNov + cntDec;
                            break;
                        case "100500":
                        case "102600":
                        case "106900":
                            cntJan5 = cntJan;
                            cntFeb5 = cntFeb;
                            cntMar5 = cntMar;
                            cntApr5 = cntApr;
                            cntMay5 = cntMay;
                            cntJun5 = cntJun;
                            cntJul5 = cntJul;
                            cntAug5 = cntAug;
                            cntSep5 = cntSep;
                            cntOct5 = cntOct;
                            cntNov5 = cntNov;
                            cntDec5 = cntDec;
                            cntYtd5 = cntYtd + cntJan + cntFeb + cntMar + cntApr + cntMay + cntJun + cntJul + cntAug + cntSep + cntOct + cntNov + cntDec;
                            break;
                        case "100600":
                        case "102700":
                            cntJan6 = cntJan;
                            cntFeb6 = cntFeb;
                            cntMar6 = cntMar;
                            cntApr6 = cntApr;
                            cntMay6 = cntMay;
                            cntJun6 = cntJun;
                            cntJul6 = cntJul;
                            cntAug6 = cntAug;
                            cntSep6 = cntSep;
                            cntOct6 = cntOct;
                            cntNov6 = cntNov;
                            cntDec6 = cntDec;
                            cntYtd6 = cntYtd + cntJan + cntFeb + cntMar + cntApr + cntMay + cntJun + cntJul + cntAug + cntSep + cntOct + cntNov + cntDec;
                            break;
                        case "102800":
                            cntJan7 = cntJan;
                            cntFeb7 = cntFeb;
                            cntMar7 = cntMar;
                            cntApr7 = cntApr;
                            cntMay7 = cntMay;
                            cntJun7 = cntJun;
                            cntJul7 = cntJul;
                            cntAug7 = cntAug;
                            cntSep7 = cntSep;
                            cntOct7 = cntOct;
                            cntNov7 = cntNov;
                            cntDec7 = cntDec;
                            cntYtd7 = cntYtd + cntJan + cntFeb + cntMar + cntApr + cntMay + cntJun + cntJul + cntAug + cntSep + cntOct + cntNov + cntDec;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (GridView.DataKeys[i].Values[1].ToString())
                    {
                        case "100300":
                        case "101500":
                        case "102100":
                        case "107700":
                        case "108700":
                            cntJanTotal = cntJan1 + cntJan2 + cntJan3;
                            cntFebTotal = cntFeb1 + cntFeb2 + cntFeb3;
                            cntMarTotal = cntMar1 + cntMar2 + cntMar3;
                            cntAprTotal = cntApr1 + cntApr2 + cntApr3;
                            cntMayTotal = cntMay1 + cntMay2 + cntMay3;
                            cntJunTotal = cntJun1 + cntJun2 + cntJun3;
                            cntJulTotal = cntJul1 + cntJul2 + cntJul3;
                            cntAugTotal = cntAug1 + cntAug2 + cntAug3;
                            cntSepTotal = cntSep1 + cntSep2 + cntSep3;
                            cntOctTotal = cntOct1 + cntOct2 + cntOct3;
                            cntNovTotal = cntNov1 + cntNov2 + cntNov3;
                            cntDecTotal = cntDec1 + cntDec2 + cntDec3;
                            cntYtdTotal = cntJanTotal + cntFebTotal + cntMarTotal + cntAprTotal + cntMayTotal + cntJunTotal + cntJulTotal + cntAugTotal + cntSepTotal + cntOctTotal + cntNovTotal + cntDecTotal;

                            if (!String.IsNullOrEmpty(cntYtdTotal.ToString()))
                            {
                                ave = (decimal)Math.Round((decimal)cntYtdTotal / (decimal)months);
                                mv.Ave = ave.ToString();
                            }
                            else { mv.Ave = "0"; }
                            string sql = "UPDATE METRICS SET JAN = '" + cntJanTotal + "', FEB = '" + cntFebTotal + "', MAR = '" + cntMarTotal + "', APR = '" + cntAprTotal + "', MAY = '" + cntMayTotal + "', Jun = '" + cntJunTotal + "', JUL = '" + cntJulTotal + "', AUG = '" + cntAugTotal + "', SEP = '" + cntSepTotal + "', OCT = '" + cntOctTotal + "', NOV = '" + cntNovTotal + "', DEC = '" + cntDecTotal + "', YTD = '" + cntYtdTotal + "', AVE = '" + mv.Ave + "' WHERE ID = '" + GridView.DataKeys[i].Values[0].ToString() + "'";
                            DBHelper.Execute(sql);

                            if (GridView.DataKeys[i].Values[1].ToString() == "102100")
                            {
                                cntJan102100 = cntJanTotal;
                                cntFeb102100 = cntFebTotal;
                                cntMar102100 = cntMarTotal;
                                cntApr102100 = cntAprTotal;
                                cntMay102100 = cntMayTotal;
                                cntJun102100 = cntJunTotal;
                                cntJul102100 = cntJulTotal;
                                cntAug102100 = cntAugTotal;
                                cntSep102100 = cntSepTotal;
                                cntOct102100 = cntOctTotal;
                                cntNov102100 = cntNovTotal;
                                cntDec102100 = cntDecTotal;
                                cntYtd102100 = cntJanTotal + cntFebTotal + cntMarTotal + cntAprTotal + cntMayTotal + cntJunTotal + cntJulTotal + cntAugTotal + cntSepTotal + cntOctTotal + cntNovTotal + cntDecTotal;
                            }
                            break;
                        case "100700":
                            cntJanTotal = cntJan4 + cntJan5 + cntJan6;
                            cntFebTotal = cntFeb4 + cntFeb5 + cntFeb6;
                            cntMarTotal = cntMar4 + cntMar5 + cntMar6;
                            cntAprTotal = cntApr4 + cntApr5 + cntApr6;
                            cntMayTotal = cntMay4 + cntMay5 + cntMay6;
                            cntJunTotal = cntJun4 + cntJun5 + cntJun6;
                            cntJulTotal = cntJul4 + cntJul5 + cntJul6;
                            cntAugTotal = cntAug4 + cntAug5 + cntAug6;
                            cntSepTotal = cntSep4 + cntSep5 + cntSep6;
                            cntOctTotal = cntOct4 + cntOct5 + cntOct6;
                            cntNovTotal = cntNov4 + cntNov5 + cntNov6;
                            cntDecTotal = cntDec4 + cntDec5 + cntDec6;
                            cntYtdTotal = cntJanTotal + cntFebTotal + cntMarTotal + cntAprTotal + cntMayTotal + cntJunTotal + cntJulTotal + cntAugTotal + cntSepTotal + cntOctTotal + cntNovTotal + cntDecTotal;
                            if (!String.IsNullOrEmpty(cntYtdTotal.ToString()))
                            {
                                ave = (decimal)Math.Round((decimal)cntYtdTotal / (decimal)months);
                                mv.Ave = ave.ToString();
                            }
                            else { mv.Ave = "0"; }
                            sql = "UPDATE METRICS SET JAN = '" + cntJanTotal + "', FEB = '" + cntFebTotal + "', MAR = '" + cntMarTotal + "', APR = '" + cntAprTotal + "', MAY = '" + cntMayTotal + "', Jun = '" + cntJunTotal + "', JUL = '" + cntJulTotal + "', AUG = '" + cntAugTotal + "', SEP = '" + cntSepTotal + "', OCT = '" + cntOctTotal + "', NOV = '" + cntNovTotal + "', DEC = '" + cntDecTotal + "', YTD = '" + cntYtdTotal + "', AVE = '" + mv.Ave + "' WHERE ID = '" + GridView.DataKeys[i].Values[0].ToString() + "'";
                            DBHelper.Execute(sql);
                            cntJanTotal = cntFebTotal = cntMarTotal = cntAprTotal = cntMayTotal = cntJunTotal = cntJulTotal = cntAugTotal = cntSepTotal = cntOctTotal = cntNovTotal = cntDecTotal = cntDecTotal = cntYtd = 0;
                            break;
                        case "100800":
                            cntJanGrandTotal = cntJanTotal = cntJan100800 = cntJan1 - cntJan4;
                            cntFebGrandTotal = cntFebTotal = cntFeb100800 = cntFeb1 - cntFeb4;
                            cntMarGrandTotal = cntMarTotal = cntMar100800 = cntMar1 - cntMar4;
                            cntAprGrandTotal = cntAprTotal = cntApr100800 = cntApr1 - cntApr4;
                            cntMayGrandTotal = cntMayTotal = cntMay100800 = cntMay1 - cntMay4;
                            cntJunGrandTotal = cntJunTotal = cntJun100800 = cntJun1 - cntJun4;
                            cntJulGrandTotal = cntJulTotal = cntJul100800 = cntJul1 - cntJul4;
                            cntAugGrandTotal = cntAugTotal = cntAug100800 = cntAug1 - cntAug4;
                            cntSepGrandTotal = cntSepTotal = cntSep100800 = cntSep1 - cntSep4;
                            cntOctGrandTotal = cntOctTotal = cntOct100800 = cntOct1 - cntOct4;
                            cntNovGrandTotal = cntNovTotal = cntNov100800 = cntNov1 - cntNov4;
                            cntDecGrandTotal = cntDecTotal = cntDec100800 = cntDec1 - cntDec4;
                            cntYtdGrandTotal = cntYtdTotal = cntYtd100800 = cntJanTotal + cntFebTotal + cntMarTotal + cntAprTotal + cntMayTotal + cntJunTotal + cntJulTotal + cntAugTotal + cntSepTotal + cntOctTotal + cntNovTotal + cntDecTotal;
                            if (!String.IsNullOrEmpty(cntYtdTotal.ToString()))
                            {
                                ave = (decimal)Math.Round((decimal)cntYtdTotal / (decimal)months);
                                mv.Ave = ave.ToString();
                            }
                            else { mv.Ave = "0"; }
                            sql = "UPDATE METRICS SET JAN = '" + cntJanTotal + "', FEB = '" + cntFebTotal + "', MAR = '" + cntMarTotal + "', APR = '" + cntAprTotal + "', MAY = '" + cntMayTotal + "', Jun = '" + cntJunTotal + "', JUL = '" + cntJulTotal + "', AUG = '" + cntAugTotal + "', SEP = '" + cntSepTotal + "', OCT = '" + cntOctTotal + "', NOV = '" + cntNovTotal + "', DEC = '" + cntDecTotal + "', YTD = '" + cntYtdTotal + "', AVE = '" + mv.Ave + "' WHERE ID = '" + GridView.DataKeys[i].Values[0].ToString() + "'";
                            DBHelper.Execute(sql);
                            cntJanTotal = cntFebTotal = cntMarTotal = cntAprTotal = cntMayTotal = cntJunTotal = cntJulTotal = cntAugTotal = cntSepTotal = cntOctTotal = cntNovTotal = cntDecTotal = cntDecTotal = cntYtd = 0;
                            break;
                        case "100900":
                            cntJanTotal = cntJan100900 = cntJan2 - cntJan5;
                            cntFebTotal = cntFeb100900 = cntFeb2 - cntFeb5;
                            cntMarTotal = cntMar100900 = cntMar2 - cntMar5;
                            cntAprTotal = cntApr100900 = cntApr2 - cntApr5;
                            cntMayTotal = cntMay100900 = cntMay2 - cntMay5;
                            cntJunTotal = cntJun100900 = cntJun2 - cntJun5;
                            cntJulTotal = cntJul100900 = cntJul2 - cntJul5;
                            cntAugTotal = cntAug100900 = cntAug2 - cntAug5;
                            cntSepTotal = cntSep100900 = cntSep2 - cntSep5;
                            cntOctTotal = cntOct100900 = cntOct2 - cntOct5;
                            cntNovTotal = cntNov100900 = cntNov2 - cntNov5;
                            cntDecTotal = cntDec100900 = cntDec2 - cntDec5;
                            cntYtdTotal = cntYtd100900 = cntJanTotal + cntFebTotal + cntMarTotal + cntAprTotal + cntMayTotal + cntJunTotal + cntJulTotal + cntAugTotal + cntSepTotal + cntOctTotal + cntNovTotal + cntDecTotal;
                            if (!String.IsNullOrEmpty(cntYtdTotal.ToString()))
                            {
                                ave = (decimal)Math.Round((decimal)cntYtdTotal / (decimal)months);
                                mv.Ave = ave.ToString();
                            }
                            else { mv.Ave = "0"; }
                            cntJanGrandTotal = cntJanGrandTotal + cntJanTotal;
                            cntFebGrandTotal = cntFebGrandTotal + cntFebTotal;
                            cntMarGrandTotal = cntMarGrandTotal + cntMarTotal;
                            cntAprGrandTotal = cntAprGrandTotal + cntAprTotal;
                            cntMayGrandTotal = cntMayGrandTotal + cntMayTotal;
                            cntJunGrandTotal = cntJunGrandTotal + cntJunTotal;
                            cntJulGrandTotal = cntJulGrandTotal + cntJulTotal;
                            cntAugGrandTotal = cntAugGrandTotal + cntAugTotal;
                            cntSepGrandTotal = cntSepGrandTotal + cntSepTotal;
                            cntOctGrandTotal = cntOctGrandTotal + cntOctTotal;
                            cntNovGrandTotal = cntNovGrandTotal + cntNovTotal;
                            cntDecGrandTotal = cntDecGrandTotal + cntDecTotal;
                            cntYtdGrandTotal = cntYtdGrandTotal + cntYtdTotal;

                            sql = "UPDATE METRICS SET JAN = '" + cntJanTotal + "', FEB = '" + cntFebTotal + "', MAR = '" + cntMarTotal + "', APR = '" + cntAprTotal + "', MAY = '" + cntMayTotal + "', Jun = '" + cntJunTotal + "', JUL = '" + cntJulTotal + "', AUG = '" + cntAugTotal + "', SEP = '" + cntSepTotal + "', OCT = '" + cntOctTotal + "', NOV = '" + cntNovTotal + "', DEC = '" + cntDecTotal + "', YTD = '" + cntYtdTotal + "', AVE = '" + mv.Ave + "' WHERE ID = '" + GridView.DataKeys[i].Values[0].ToString() + "'";
                            DBHelper.Execute(sql);
                            cntJanTotal = cntFebTotal = cntMarTotal = cntAprTotal = cntMayTotal = cntJunTotal = cntJulTotal = cntAugTotal = cntSepTotal = cntOctTotal = cntNovTotal = cntDecTotal = cntDecTotal = cntYtd = 0;
                            break;
                        case "101000":
                            cntJanTotal = cntJan101000 = cntJan3 - cntJan6;
                            cntFebTotal = cntFeb101000 = cntFeb3 - cntFeb6;
                            cntMarTotal = cntMar101000 = cntMar3 - cntMar6;
                            cntAprTotal = cntApr101000 = cntApr3 - cntApr6;
                            cntMayTotal = cntMay101000 = cntMay3 - cntMay6;
                            cntJunTotal = cntJun101000 = cntJun3 - cntJun6;
                            cntJulTotal = cntJul101000 = cntJul3 - cntJul6;
                            cntAugTotal = cntAug101000 = cntAug3 - cntAug6;
                            cntSepTotal = cntSep101000 = cntSep3 - cntSep6;
                            cntOctTotal = cntOct101000 = cntOct3 - cntOct6;
                            cntNovTotal = cntNov101000 = cntNov3 - cntNov6;
                            cntDecTotal = cntDec101000 = cntDec3 + cntDec6;
                            cntYtdTotal = cntYtd101000 = cntJanTotal + cntFebTotal + cntMarTotal + cntAprTotal + cntMayTotal + cntJunTotal + cntJulTotal + cntAugTotal + cntSepTotal + cntOctTotal + cntNovTotal + cntDecTotal;
                            if (!String.IsNullOrEmpty(cntYtdTotal.ToString()))
                            {
                                ave = (decimal)Math.Round((decimal)cntYtdTotal / (decimal)months);
                                mv.Ave = ave.ToString();
                            }
                            else { mv.Ave = "0"; }
                            cntJanGrandTotal = cntJan101100 = cntJanGrandTotal + cntJanTotal;
                            cntFebGrandTotal = cntFeb101100 = cntFebGrandTotal + cntFebTotal;
                            cntMarGrandTotal = cntMar101100 = cntMarGrandTotal + cntMarTotal;
                            cntAprGrandTotal = cntApr101100 = cntAprGrandTotal + cntAprTotal;
                            cntMayGrandTotal = cntMay101100 = cntMayGrandTotal + cntMayTotal;
                            cntJunGrandTotal = cntJun101100 = cntJunGrandTotal + cntJunTotal;
                            cntJulGrandTotal = cntJul101100 = cntJulGrandTotal + cntJulTotal;
                            cntAugGrandTotal = cntAug101100 = cntAugGrandTotal + cntAugTotal;
                            cntSepGrandTotal = cntSep101100 = cntSepGrandTotal + cntSepTotal;
                            cntOctGrandTotal = cntOct101100 = cntOctGrandTotal + cntOctTotal;
                            cntNovGrandTotal = cntNov101100 = cntNovGrandTotal + cntNovTotal;
                            cntDecGrandTotal = cntDec101100 = cntDecGrandTotal + cntDecTotal;
                            cntYtdGrandTotal = cntYtd101100 = cntYtdGrandTotal + cntYtdTotal;
                            sql = "UPDATE METRICS SET JAN = '" + cntJanTotal + "', FEB = '" + cntFebTotal + "', MAR = '" + cntMarTotal + "', APR = '" + cntAprTotal + "', MAY = '" + cntMayTotal + "', Jun = '" + cntJunTotal + "', JUL = '" + cntJulTotal + "', AUG = '" + cntAugTotal + "', SEP = '" + cntSepTotal + "', OCT = '" + cntOctTotal + "', NOV = '" + cntNovTotal + "', DEC = '" + cntDecTotal + "', YTD = '" + cntYtdTotal + "', AVE = '" + mv.Ave + "' WHERE ID = '" + GridView.DataKeys[i].Values[0].ToString() + "'";
                            DBHelper.Execute(sql);
                            cntJanTotal = cntFebTotal = cntMarTotal = cntAprTotal = cntMayTotal = cntJunTotal = cntJulTotal = cntAugTotal = cntSepTotal = cntOctTotal = cntNovTotal = cntDecTotal = cntDecTotal = cntYtd = 0;
                            break;
                        case "101100":
                            if (!String.IsNullOrEmpty(cntYtdTotal.ToString()))
                            {
                                ave = (decimal)Math.Round((decimal)cntYtdGrandTotal / (decimal)months);
                                mv.Ave = ave.ToString();
                            }
                            else { mv.Ave = "0"; }
                            sql = "UPDATE METRICS SET JAN = '" + cntJanGrandTotal + "', FEB = '" + cntFebGrandTotal + "', MAR = '" + cntMarGrandTotal + "', APR = '" + cntAprGrandTotal + "', MAY = '" + cntMayGrandTotal + "', Jun = '" + cntJunGrandTotal + "', JUL = '" + cntJulGrandTotal + "', AUG = '" + cntAugGrandTotal + "', SEP = '" + cntSepGrandTotal + "', OCT = '" + cntOctGrandTotal + "', NOV = '" + cntNovGrandTotal + "', DEC = '" + cntDecGrandTotal + "', YTD = '" + cntYtdGrandTotal + "', AVE = '" + mv.Ave + "' WHERE ID = '" + GridView.DataKeys[i].Values[0].ToString() + "'";
                            DBHelper.Execute(sql);
                            cntJanTotal = cntFebTotal = cntMarTotal = cntAprTotal = cntMayTotal = cntJunTotal = cntJulTotal = cntAugTotal = cntSepTotal = cntOctTotal = cntNovTotal = cntDecTotal = cntDecTotal = cntYtd = cntJan1 = cntJan2 = cntJan3 = cntJan4 = cntJan5 = cntJan6 = cntJan7 = cntFeb1 = cntFeb2 = cntFeb3 = cntFeb4 = cntFeb5 = cntFeb6 = cntFeb7 =
                            cntMar1 = cntMar2 = cntMar3 = cntMar4 = cntMar5 = cntMar6 = cntMar7 = cntApr1 = cntApr2 = cntApr3 = cntApr4 = cntApr5 = cntApr6 = cntApr7 = cntMay1 = cntMay2 = cntMay3 = cntMay4 = cntMay5 = cntMay6 = cntMay7 = cntJun1 = cntJun2 = cntJun3 = cntJun4 = cntJun5 = cntJun6 = cntJun7 = cntJul1 = cntJul2 = cntJul3 = cntJul4 = cntJul5 = cntJul6 = cntJul7 =
                            cntAug1 = cntAug2 = cntAug3 = cntAug4 = cntAug5 = cntAug6 = cntAug7 = cntSep1 = cntSep2 = cntSep3 = cntSep4 = cntSep5 = cntSep6 = cntSep7 = cntOct1 = cntOct2 = cntOct3 = cntOct4 = cntOct5 = cntOct6 = cntOct7 = cntNov1 = cntNov2 = cntNov3 = cntNov4 = cntNov5 = cntNov6 = cntNov7 = cntDec1 = cntDec2 = cntDec3 = cntDec4 = cntDec5 = cntDec = cntDec7 = 0;
                            break;
                        case "102900":
                        case "106400":
                        case "107000":
                        case "110500":
                            cntJanTotal = cntJan1 + cntJan2 + cntJan3 + cntJan4 + cntJan5 + cntJan6 + cntJan7;
                            cntFebTotal = cntFeb1 + cntFeb2 + cntFeb3 + cntFeb4 + cntFeb5 + cntFeb6 + cntFeb7;
                            cntMarTotal = cntMar1 + cntMar2 + cntMar3 + cntMar4 + cntMar5 + cntMar6 + cntMar7;
                            cntAprTotal = cntApr1 + cntApr2 + cntApr3 + cntApr4 + cntApr5 + cntApr6 + cntApr7;
                            cntMayTotal = cntMay1 + cntMay2 + cntMay3 + cntMay4 + cntMay5 + cntMay6 + cntMay7;
                            cntJunTotal = cntJun1 + cntJun2 + cntJun3 + cntJun4 + cntJun5 + cntJun6 + cntJun7;
                            cntJulTotal = cntJul1 + cntJul2 + cntJul3 + cntJul4 + cntJul5 + cntJul6 + cntJul7;
                            cntAugTotal = cntAug1 + cntAug2 + cntAug3 + cntAug4 + cntAug5 + cntAug6 + cntAug7;
                            cntSepTotal = cntSep1 + cntSep2 + cntSep3 + cntSep4 + cntSep5 + cntSep6 + cntSep7;
                            cntOctTotal = cntOct1 + cntOct2 + cntOct3 + cntOct4 + cntOct5 + cntOct6 + cntOct7;
                            cntNovTotal = cntNov1 + cntNov2 + cntNov3 + cntNov4 + cntNov5 + cntNov6 + cntNov7;
                            cntDecTotal = cntDec1 + cntDec2 + cntDec3 + cntDec4 + cntDec5 + cntDec6 + cntDec7;
                            cntYtdTotal = cntJanTotal + cntFebTotal + cntMarTotal + cntAprTotal + cntMayTotal + cntJunTotal + cntJulTotal + cntAugTotal + cntSepTotal + cntOctTotal + cntNovTotal + cntDecTotal;

                            if (!String.IsNullOrEmpty(cntYtdTotal.ToString()))
                            {
                                ave = (decimal)Math.Round((decimal)cntYtdTotal / (decimal)months);
                                mv.Ave = ave.ToString();
                            }
                            else { mv.Ave = "0"; }
                            sql = "UPDATE METRICS SET JAN = '" + cntJanTotal + "', FEB = '" + cntFebTotal + "', MAR = '" + cntMarTotal + "', APR = '" + cntAprTotal + "', MAY = '" + cntMayTotal + "', Jun = '" + cntJunTotal + "', JUL = '" + cntJulTotal + "', AUG = '" + cntAugTotal + "', SEP = '" + cntSepTotal + "', OCT = '" + cntOctTotal + "', NOV = '" + cntNovTotal + "', DEC = '" + cntDecTotal + "', YTD = '" + cntYtdTotal + "', AVE = '" + mv.Ave + "' WHERE ID = '" + GridView.DataKeys[i].Values[0].ToString() + "'";
                            DBHelper.Execute(sql);
                            cntJanTotal = cntFebTotal = cntMarTotal = cntAprTotal = cntMayTotal = cntJunTotal = cntJulTotal = cntAugTotal = cntSepTotal = cntOctTotal = cntNovTotal = cntDecTotal = cntDecTotal = cntYtd = cntJan1 = cntJan2 = cntJan3 = cntJan4 = cntJan5 = cntJan6 = cntJan7 = cntFeb1 = cntFeb2 = cntFeb3 = cntFeb4 = cntFeb5 = cntFeb6 = cntFeb7 =
                            cntMar1 = cntMar2 = cntMar3 = cntMar4 = cntMar5 = cntMar6 = cntMar7 = cntApr1 = cntApr2 = cntApr3 = cntApr4 = cntApr5 = cntApr6 = cntApr7 = cntMay1 = cntMay2 = cntMay3 = cntMay4 = cntMay5 = cntMay6 = cntMay7 = cntJun1 = cntJun2 = cntJun3 = cntJun4 = cntJun5 = cntJun6 = cntJun7 = cntJul1 = cntJul2 = cntJul3 = cntJul4 = cntJul5 = cntJul6 = cntJul7 =
                            cntAug1 = cntAug2 = cntAug3 = cntAug4 = cntAug5 = cntAug6 = cntAug7 = cntSep1 = cntSep2 = cntSep3 = cntSep4 = cntSep5 = cntSep6 = cntSep7 = cntOct1 = cntOct2 = cntOct3 = cntOct4 = cntOct5 = cntOct6 = cntOct7 = cntNov1 = cntNov2 = cntNov3 = cntNov4 = cntNov5 = cntNov6 = cntNov7 = cntDec1 = cntDec2 = cntDec3 = cntDec4 = cntDec5 = cntDec = cntDec7 = 0;
                            break;
                        case "104000":
                            if (!String.IsNullOrEmpty(cntYtd101800.ToString()))
                            {
                                ave = (decimal)Math.Round((decimal)cntYtd101800 / (decimal)months);
                                mv.Ave = ave.ToString();
                            }
                            else { mv.Ave = "0"; }
                            sql = "UPDATE METRICS SET JAN = '" + cntJan101800 + "', FEB = '" + cntFeb101800 + "', MAR = '" + cntMar101800 + "', APR = '" + cntApr101800 + "', MAY = '" + cntMay101800 + "', Jun = '" + cntJun101800 + "', JUL = '" + cntJul101800 + "', AUG = '" + cntAug101800 + "', SEP = '" + cntSep101800 + "', OCT = '" + cntOct101800 + "', NOV = '" + cntNov101800 + "', DEC = '" + cntDec101800 + "', YTD = '" + cntYtd101800 + "', AVE = '" + mv.Ave + "' WHERE ID = '" + GridView.DataKeys[i].Values[0].ToString() + "'";
                            DBHelper.Execute(sql);
                            break;
                        case "104100":
                            if (!String.IsNullOrEmpty(cntYtd100800.ToString()))
                            {
                                ave = (decimal)Math.Round((decimal)cntYtd100800 / (decimal)months);
                                mv.Ave = ave.ToString();
                            }
                            else { mv.Ave = "0"; }
                            sql = "UPDATE METRICS SET JAN = '" + cntJan100800 + "', FEB = '" + cntFeb100800 + "', MAR = '" + cntMar100800 + "', APR = '" + cntApr100800 + "', MAY = '" + cntMay100800 + "', Jun = '" + cntJun100800 + "', JUL = '" + cntJul100800 + "', AUG = '" + cntAug100800 + "', SEP = '" + cntSep100800 + "', OCT = '" + cntOct100800 + "', NOV = '" + cntNov100800 + "', DEC = '" + cntDec100800 + "', YTD = '" + cntYtd100800 + "', AVE = '" + mv.Ave + "' WHERE ID = '" + GridView.DataKeys[i].Values[0].ToString() + "'";
                            DBHelper.Execute(sql);
                            break;
                        case "104200":
                            cntJanTotalDecimal = cntFebTotalDecimal = cntMarTotalDecimal = cntAprTotalDecimal = cntMayTotalDecimal = cntJunTotalDecimal = cntJulTotalDecimal = cntAugTotalDecimal = cntSepTotalDecimal = cntOctTotalDecimal = cntNovTotalDecimal = cntDecTotalDecimal = 0;
                            if (cntJan100800.ToString() != "0" && (cntJan101800.ToString() != "0"))
                            {
                                calcDecimal = cntJan100800 / cntJan101800;
                                cntJanTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntFeb100800.ToString() != "0" && (cntFeb101800.ToString() != "0"))
                            {
                                calcDecimal = (decimal)cntFeb100800 / cntFeb101800;
                                cntFebTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntMar100800.ToString() != "0" && (cntMar101800.ToString() != "0"))
                            {
                                calcDecimal = (decimal)cntMar100800 / cntMar101800;
                                cntMarTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntApr100800.ToString() != "0" && (cntApr101800.ToString() != "0"))
                            {
                                calcDecimal = (decimal)cntApr100800 / cntApr101800;
                                cntAprTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntMay100800.ToString() != "0" && (cntMay101800.ToString() != "0"))
                            {
                                calcDecimal = (decimal)cntMay100800 / cntMay101800;
                                cntMayTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntJun100800.ToString() != "0" && (cntJun101800.ToString() != "0"))
                            {
                                calcDecimal = (decimal)cntJun100800 / cntJun101800;
                                cntJunTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntJul100800.ToString() != "0" && (cntJul101800.ToString() != "0"))
                            {
                                calcDecimal = (decimal)cntJul100800 / cntJul101800;
                                cntJulTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntAug100800.ToString() != "0" && (cntAug101800.ToString() != "0"))
                            {
                                calcDecimal = (decimal)cntAug100800 / cntAug101800;
                                cntAugTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntSep100800.ToString() != "0" && (cntSep101800.ToString() != "0"))
                            {
                                calcDecimal = (decimal)cntSep100800 / cntSep101800;
                                cntSepTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntOct100800.ToString() != "0" && (cntOct101800.ToString() != "0"))
                            {
                                calcDecimal = (decimal)cntOct100800 / cntOct101800;
                                cntOctTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntNov100800.ToString() != "0" && (cntNov101800.ToString() != "0"))
                            {
                                calcDecimal = (decimal)cntNov100800 / cntNov101800;
                                cntNovTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntDec100800.ToString() != "0" && (cntDec101800.ToString() != "0"))
                            {
                                calcDecimal = (decimal)cntDec100800 / cntDec101800;
                                cntDecTotalDecimal = Math.Round(calcDecimal, 1);
                            }

                            ytd1 = cntJan100800 + cntFeb100800 + cntMar100800 + cntApr100800 + cntMay100800 + cntJun100800 + cntJul100800 + cntAug100800 + cntSep100800 + cntOct100800 + cntNov100800 + cntDec100800;
                            ytd2 = cntJan101800 + cntFeb101800 + cntMar101800 + cntApr101800 + cntMay101800 + cntJun101800 + cntJul101800 + cntAug101800 + cntSep101800 + cntOct101800 + cntNov101800 + cntDec101800;

                            cntYtdTotalDecimal = cntAveTotalDecimal = 0;
                            if (ytd1.ToString() != "0" && ytd2.ToString() != "0")
                            {
                                calcDecimal = (decimal)ytd1 / ytd2;
                                cntYtdTotalDecimal = Math.Round(calcDecimal, 1);
                                if (!String.IsNullOrEmpty(ytd1.ToString()) && !String.IsNullOrEmpty(ytd2.ToString()))
                                {
                                    ave1 = (decimal)Math.Round((decimal)ytd1 / (decimal)months);
                                    ave2 = (decimal)Math.Round((decimal)ytd2 / (decimal)months);
                                    calcDecimal = (decimal)ave1 / ave2;
                                    cntAveTotalDecimal = Math.Round(calcDecimal, 1);
                                }
                            }

                            sql = "UPDATE METRICS SET JAN = '" + cntJanTotalDecimal + "', FEB = '" + cntFebTotalDecimal + "', MAR = '" + cntMarTotalDecimal + "', APR = '" + cntAprTotalDecimal + "', MAY = '" + cntMayTotalDecimal + "', Jun = '" + cntJunTotalDecimal + "', JUL = '" + cntJulTotalDecimal + "', AUG = '" + cntAugTotalDecimal + "', SEP = '" + cntSepTotalDecimal + "', OCT = '" + cntOctTotalDecimal + "', NOV = '" + cntNovTotalDecimal + "', DEC = '" + cntDecTotalDecimal + "', YTD = '" + cntYtdTotalDecimal + "', AVE = '" + cntAveTotalDecimal + "' WHERE ID = '" + GridView.DataKeys[i].Values[0].ToString() + "'";
                            DBHelper.Execute(sql);
                            break;
                        case "104300":
                            if (!String.IsNullOrEmpty(cntYtd101900.ToString()))
                            {
                                ave = (decimal)Math.Round((decimal)cntYtd101900 / (decimal)months);
                                mv.Ave = ave.ToString();
                            }
                            else { mv.Ave = "0"; }
                            sql = "UPDATE METRICS SET JAN = '" + cntJan101900 + "', FEB = '" + cntFeb101900 + "', MAR = '" + cntMar101900 + "', APR = '" + cntApr101900 + "', MAY = '" + cntMay101900 + "', Jun = '" + cntJun101900 + "', JUL = '" + cntJul101900 + "', AUG = '" + cntAug101900 + "', SEP = '" + cntSep101900 + "', OCT = '" + cntOct101900 + "', NOV = '" + cntNov101900 + "', DEC = '" + cntDec101900 + "', YTD = '" + cntYtd101900 + "', AVE = '" + mv.Ave + "' WHERE ID = '" + GridView.DataKeys[i].Values[0].ToString() + "'";
                            DBHelper.Execute(sql);
                            break;
                        case "104400":
                            if (!String.IsNullOrEmpty(cntYtd100900.ToString()))
                            {
                                ave = (decimal)Math.Round((decimal)cntYtd100900 / (decimal)months);
                                mv.Ave = ave.ToString();
                            }
                            else { mv.Ave = "0"; }
                            sql = "UPDATE METRICS SET JAN = '" + cntJan100900 + "', FEB = '" + cntFeb100900 + "', MAR = '" + cntMar100900 + "', APR = '" + cntApr100900 + "', MAY = '" + cntMay100900 + "', Jun = '" + cntJun100900 + "', JUL = '" + cntJul100900 + "', AUG = '" + cntAug100900 + "', SEP = '" + cntSep100900 + "', OCT = '" + cntOct100900 + "', NOV = '" + cntNov100900 + "', DEC = '" + cntDec100900 + "', YTD = '" + cntYtd100900 + "', AVE = '" + mv.Ave + "' WHERE ID = '" + GridView.DataKeys[i].Values[0].ToString() + "'";
                            DBHelper.Execute(sql);
                            break;
                        case "104500":
                            cntJanTotalDecimal = cntFebTotalDecimal = cntMarTotalDecimal = cntAprTotalDecimal = cntMayTotalDecimal = cntJunTotalDecimal = cntJulTotalDecimal = cntAugTotalDecimal = cntSepTotalDecimal = cntOctTotalDecimal = cntNovTotalDecimal = cntDecTotalDecimal = 0;
                            if (cntJan100900.ToString() != "0" && cntJan101900.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntJan100900 / cntJan101900;
                                cntJanTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntFeb100900.ToString() != "0" && cntFeb101900.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntFeb100900 / cntFeb101900;
                                cntFebTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntMar100900.ToString() != "0" && cntMar101900.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntMar100900 / cntMar101900;
                                cntMarTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntApr100900.ToString() != "0" && cntApr101900.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntApr100900 / cntApr101900;
                                cntAprTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntMay100900.ToString() != "0" && cntMay101900.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntMay100900 / cntMay101900;
                                cntMayTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntJun100900.ToString() != "0" && cntJun101900.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntJun100900 / cntJun101900;
                                cntJunTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntJul100900.ToString() != "0" && cntJul101900.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntJul100900 / cntJul101900;
                                cntJulTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntAug100900.ToString() != "0" && cntAug101900.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntAug100900 / cntAug101900;
                                cntAugTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntSep100900.ToString() != "0" && cntSep101900.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntSep100900 / cntSep101900;
                                cntSepTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntOct100900.ToString() != "0" && cntOct101900.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntOct100900 / cntOct101900;
                                cntOctTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntNov100900.ToString() != "0" && cntNov101900.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntNov100900 / cntNov101900;
                                cntNovTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntDec100900.ToString() != "0" && cntDec101900.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntDec100900 / cntDec101900;
                                cntDecTotalDecimal = Math.Round(calcDecimal, 1);
                            }

                            ytd1 = cntJan100900 + cntFeb100900 + cntMar100900 + cntApr100900 + cntMay100900 + cntJun100900 + cntJul100900 + cntAug100900 + cntSep100900 + cntOct100900 + cntNov100900 + cntDec100900;
                            ytd2 = cntJan101900 + cntFeb101900 + cntMar101900 + cntApr101900 + cntMay101900 + cntJun101900 + cntJul101900 + cntAug101900 + cntSep101900 + cntOct101900 + cntNov101900 + cntDec101900;

                            cntYtdTotalDecimal = cntAveTotalDecimal = 0;
                            if (ytd1.ToString() != "0" && ytd2.ToString() != "0")
                            {
                                calcDecimal = (decimal)ytd1 / ytd2;
                                cntYtdTotalDecimal = Math.Round(calcDecimal, 1);
                                if (!String.IsNullOrEmpty(ytd1.ToString()) && !String.IsNullOrEmpty(ytd2.ToString()))
                                {
                                    ave1 = (decimal)Math.Round((decimal)ytd1 / (decimal)months);
                                    ave2 = (decimal)Math.Round((decimal)ytd2 / (decimal)months);
                                    calcDecimal = (decimal)ave1 / ave2;
                                    cntAveTotalDecimal = Math.Round(calcDecimal, 1);
                                }
                            }

                            sql = "UPDATE METRICS SET JAN = '" + cntJanTotalDecimal + "', FEB = '" + cntFebTotalDecimal + "', MAR = '" + cntMarTotalDecimal + "', APR = '" + cntAprTotalDecimal + "', MAY = '" + cntMayTotalDecimal + "', Jun = '" + cntJunTotalDecimal + "', JUL = '" + cntJulTotalDecimal + "', AUG = '" + cntAugTotalDecimal + "', SEP = '" + cntSepTotalDecimal + "', OCT = '" + cntOctTotalDecimal + "', NOV = '" + cntNovTotalDecimal + "', DEC = '" + cntDecTotalDecimal + "', YTD = '" + cntYtdTotalDecimal + "', AVE = '" + cntAveTotalDecimal + "' WHERE ID = '" + GridView.DataKeys[i].Values[0].ToString() + "'";
                            DBHelper.Execute(sql);
                            break;
                        case "104600":
                            if (!String.IsNullOrEmpty(cntYtd102000.ToString()))
                            {
                                ave = (decimal)Math.Round((decimal)cntYtd102000 / (decimal)months);
                                mv.Ave = ave.ToString();
                            }
                            else { mv.Ave = "0"; }
                            sql = "UPDATE METRICS SET JAN = '" + cntJan102000 + "', FEB = '" + cntFeb102000 + "', MAR = '" + cntMar102000 + "', APR = '" + cntApr102000 + "', MAY = '" + cntMay102000 + "', Jun = '" + cntJun102000 + "', JUL = '" + cntJul102000 + "', AUG = '" + cntAug102000 + "', SEP = '" + cntSep102000 + "', OCT = '" + cntOct102000 + "', NOV = '" + cntNov102000 + "', DEC = '" + cntDec102000 + "', YTD = '" + cntYtd102000 + "', AVE = '" + mv.Ave + "' WHERE ID = '" + GridView.DataKeys[i].Values[0].ToString() + "'";
                            DBHelper.Execute(sql);
                            break;
                        case "104700":
                            if (!String.IsNullOrEmpty(cntYtd101000.ToString()))
                            {
                                ave = (decimal)Math.Round((decimal)cntYtd101000 / (decimal)months);
                                mv.Ave = ave.ToString();
                            }
                            else { mv.Ave = "0"; }
                            sql = "UPDATE METRICS SET JAN = '" + cntJan101000 + "', FEB = '" + cntFeb101000 + "', MAR = '" + cntMar101000 + "', APR = '" + cntApr101000 + "', MAY = '" + cntMay101000 + "', Jun = '" + cntJun101000 + "', JUL = '" + cntJul101000 + "', AUG = '" + cntAug101000 + "', SEP = '" + cntSep101000 + "', OCT = '" + cntOct101000 + "', NOV = '" + cntNov101000 + "', DEC = '" + cntDec101000 + "', YTD = '" + cntYtd101000 + "', AVE = '" + mv.Ave + "' WHERE ID = '" + GridView.DataKeys[i].Values[0].ToString() + "'";
                            DBHelper.Execute(sql);
                            break;
                        case "104800":
                            cntJanTotalDecimal = cntFebTotalDecimal = cntMarTotalDecimal = cntAprTotalDecimal = cntMayTotalDecimal = cntJunTotalDecimal = cntJulTotalDecimal = cntAugTotalDecimal = cntSepTotalDecimal = cntOctTotalDecimal = cntNovTotalDecimal = cntDecTotalDecimal = 0;
                            if (cntJan101000.ToString() != "0" && cntJan102000.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntJan101000 / cntJan102000;
                                cntJanTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntFeb101000.ToString() != "0" && cntFeb102000.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntFeb101000 / cntFeb102000;
                                cntFebTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntMar101000.ToString() != "0" && cntMar102000.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntMar101000 / cntMar102000;
                                cntMarTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntApr101000.ToString() != "0" && cntApr102000.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntApr101000 / cntApr102000;
                                cntAprTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntMay101000.ToString() != "0" && cntMay102000.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntMay101000 / cntMay102000;
                                cntMayTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntJun101000.ToString() != "0" && cntJun102000.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntJun101000 / cntJun102000;
                                cntJunTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntJul101000.ToString() != "0" && cntJul102000.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntJul101000 / cntJul102000;
                                cntJulTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntAug101000.ToString() != "0" && cntAug102000.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntAug101000 / cntAug102000;
                                cntAugTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntSep101000.ToString() != "0" && cntSep102000.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntSep101000 / cntSep102000;
                                cntSepTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntOct101000.ToString() != "0" && cntOct102000.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntOct101000 / cntOct102000;
                                cntOctTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntNov101000.ToString() != "0" && cntNov102000.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntNov101000 / cntNov102000;
                                cntNovTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntDec101000.ToString() != "0" && cntDec102000.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntDec101000 / cntDec102000;
                                cntDecTotalDecimal = Math.Round(calcDecimal, 1);
                            }

                            ytd1 = cntJan101000 + cntFeb101000 + cntMar101000 + cntApr101000 + cntMay101000 + cntJun101000 + cntJul101000 + cntAug101000 + cntSep101000 + cntOct101000 + cntNov101000 + cntDec101000;
                            ytd2 = cntJan102000 + cntFeb102000 + cntMar102000 + cntApr102000 + cntMay102000 + cntJun102000 + cntJul102000 + cntAug102000 + cntSep102000 + cntOct102000 + cntNov102000 + cntDec102000;

                            cntYtdTotalDecimal = cntAveTotalDecimal = 0;
                            if (ytd1.ToString() != "0" && ytd2.ToString() != "0")
                            {
                                calcDecimal = (decimal)ytd1 / ytd2;
                                cntYtdTotalDecimal = Math.Round(calcDecimal, 1);
                                if (!String.IsNullOrEmpty(ytd1.ToString()) && !String.IsNullOrEmpty(ytd2.ToString()))
                                {
                                    ave1 = (decimal)Math.Round((decimal)ytd1 / (decimal)months);
                                    ave2 = (decimal)Math.Round((decimal)ytd2 / (decimal)months);
                                    calcDecimal = (decimal)ave1 / ave2;
                                    cntAveTotalDecimal = Math.Round(calcDecimal, 1);
                                }
                            }

                            sql = "UPDATE METRICS SET JAN = '" + cntJanTotalDecimal + "', FEB = '" + cntFebTotalDecimal + "', MAR = '" + cntMarTotalDecimal + "', APR = '" + cntAprTotalDecimal + "', MAY = '" + cntMayTotalDecimal + "', Jun = '" + cntJunTotalDecimal + "', JUL = '" + cntJulTotalDecimal + "', AUG = '" + cntAugTotalDecimal + "', SEP = '" + cntSepTotalDecimal + "', OCT = '" + cntOctTotalDecimal + "', NOV = '" + cntNovTotalDecimal + "', DEC = '" + cntDecTotalDecimal + "', YTD = '" + cntYtdTotalDecimal + "', AVE = '" + cntAveTotalDecimal + "' WHERE ID = '" + GridView.DataKeys[i].Values[0].ToString() + "'";
                            DBHelper.Execute(sql);
                            break;
                        case "104900":
                            if (!String.IsNullOrEmpty(cntYtd102100.ToString()))
                            {
                                ave = (decimal)Math.Round((decimal)cntYtd102100 / (decimal)months);
                                mv.Ave = ave.ToString();
                            }
                            else { mv.Ave = "0"; }
                            sql = "UPDATE METRICS SET JAN = '" + cntJan102100 + "', FEB = '" + cntFeb102100 + "', MAR = '" + cntMar102100 + "', APR = '" + cntApr102100 + "', MAY = '" + cntMay102100 + "', Jun = '" + cntJun102100 + "', JUL = '" + cntJul102100 + "', AUG = '" + cntAug102100 + "', SEP = '" + cntSep102100 + "', OCT = '" + cntOct102100 + "', NOV = '" + cntNov102100 + "', DEC = '" + cntDec102100 + "', YTD = '" + cntYtd102100 + "', AVE = '" + mv.Ave + "' WHERE ID = '" + GridView.DataKeys[i].Values[0].ToString() + "'";
                            DBHelper.Execute(sql);
                            break;
                        case "105000":
                            if (!String.IsNullOrEmpty(cntYtd101100.ToString()))
                            {
                                ave = (decimal)Math.Round((decimal)cntYtd101100 / (decimal)months);
                                mv.Ave = ave.ToString();
                            }
                            else { mv.Ave = "0"; }
                            sql = "UPDATE METRICS SET JAN = '" + cntJan101100 + "', FEB = '" + cntFeb101100 + "', MAR = '" + cntMar101100 + "', APR = '" + cntApr101100 + "', MAY = '" + cntMay101100 + "', Jun = '" + cntJun101100 + "', JUL = '" + cntJul101100 + "', AUG = '" + cntAug101100 + "', SEP = '" + cntSep101100 + "', OCT = '" + cntOct101100 + "', NOV = '" + cntNov101100 + "', DEC = '" + cntDec101100 + "', YTD = '" + cntYtd101100 + "', AVE = '" + mv.Ave + "' WHERE ID = '" + GridView.DataKeys[i].Values[0].ToString() + "'";
                            DBHelper.Execute(sql);
                            break;
                        case "105100":
                            cntJanTotalDecimal = cntFebTotalDecimal = cntMarTotalDecimal = cntAprTotalDecimal = cntMayTotalDecimal = cntJunTotalDecimal = cntJulTotalDecimal = cntAugTotalDecimal = cntSepTotalDecimal = cntOctTotalDecimal = cntNovTotalDecimal = cntDecTotalDecimal = 0;
                            if (cntJan101100.ToString() != "0" && cntJan102100.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntJan101100 / cntJan102100;
                                cntJanTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntFeb101100.ToString() != "0" && cntFeb102100.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntFeb101100 / cntFeb102100;
                                cntFebTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntMar101100.ToString() != "0" && cntMar102100.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntMar101100 / cntMar102100;
                                cntMarTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntApr101100.ToString() != "0" && cntApr102100.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntApr101100 / cntApr102100;
                                cntAprTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntMay101100.ToString() != "0" && cntMay102100.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntMay101100 / cntMay102100;
                                cntMayTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntJun101100.ToString() != "0" && cntJun102100.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntJun101100 / cntJun102100;
                                cntJunTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntJul101100.ToString() != "0" && cntJul102100.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntJul101100 / cntJul102100;
                                cntJulTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntAug101100.ToString() != "0" && cntAug102100.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntAug101100 / cntAug102100;
                                cntAugTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntSep101100.ToString() != "0" && cntSep102100.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntSep101100 / cntSep102100;
                                cntSepTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntOct101100.ToString() != "0" && cntOct102100.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntOct101100 / cntOct102100;
                                cntOctTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntNov101100.ToString() != "0" && cntNov102100.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntNov101100 / cntNov102100;
                                cntNovTotalDecimal = Math.Round(calcDecimal, 1);
                            }
                            if (cntDec101100.ToString() != "0" && cntDec102100.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntDec101100 / cntDec102100;
                                cntDecTotalDecimal = Math.Round(calcDecimal, 1);
                            }

                            ytd1 = cntJan101100 + cntFeb101100 + cntMar101100 + cntApr101100 + cntMay101100 + cntJun101100 + cntJul101100 + cntAug101100 + cntSep101100 + cntOct101100 + cntNov101100 + cntDec101100;
                            ytd2 = cntJan102100 + cntFeb102100 + cntMar102100 + cntApr102100 + cntMay102100 + cntJun102100 + cntJul102100 + cntAug102100 + cntSep102100 + cntOct102100 + cntNov102100 + cntDec102100;

                            cntYtdTotalDecimal = cntAveTotalDecimal = 0;
                            if (ytd1.ToString() != "0" && ytd2.ToString() != "0")
                            {
                                calcDecimal = (decimal)ytd1 / ytd2;
                                cntYtdTotalDecimal = Math.Round(calcDecimal, 1);
                                if (!String.IsNullOrEmpty(ytd1.ToString()) && !String.IsNullOrEmpty(ytd2.ToString()))
                                {
                                    ave1 = (decimal)Math.Round((decimal)ytd1 / (decimal)months);
                                    ave2 = (decimal)Math.Round((decimal)ytd2 / (decimal)months);
                                    calcDecimal = (decimal)ave1 / ave2;
                                    cntAveTotalDecimal = Math.Round(calcDecimal, 1);
                                }
                            }

                            sql = "UPDATE METRICS SET JAN = '" + cntJanTotalDecimal + "', FEB = '" + cntFebTotalDecimal + "', MAR = '" + cntMarTotalDecimal + "', APR = '" + cntAprTotalDecimal + "', MAY = '" + cntMayTotalDecimal + "', Jun = '" + cntJunTotalDecimal + "', JUL = '" + cntJulTotalDecimal + "', AUG = '" + cntAugTotalDecimal + "', SEP = '" + cntSepTotalDecimal + "', OCT = '" + cntOctTotalDecimal + "', NOV = '" + cntNovTotalDecimal + "', DEC = '" + cntDecTotalDecimal + "', YTD = '" + cntYtdTotalDecimal + "', AVE = '" + cntAveTotalDecimal + "' WHERE ID = '" + GridView.DataKeys[i].Values[0].ToString() + "'";
                            DBHelper.Execute(sql);
                            break;
                        case "107200":
                            cntJanTotalDecimal = cntFebTotalDecimal = cntMarTotalDecimal = cntAprTotalDecimal = cntMayTotalDecimal = cntJunTotalDecimal = cntJulTotalDecimal = cntAugTotalDecimal = cntSepTotalDecimal = cntOctTotalDecimal = cntNovTotalDecimal = cntDecTotalDecimal = 0;
                            if (cntJan1.ToString() != "0" && cntJan106500.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntJan1 / cntJan106500;
                                cntJanTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntFeb1.ToString() != "0" && cntFeb106500.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntFeb1 / cntFeb106500;
                                cntFebTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntMar1.ToString() != "0" && cntMar106500.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntMar1 / cntMar106500;
                                cntMarTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntApr1.ToString() != "0" && cntApr106500.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntApr1 / cntApr106500;
                                cntAprTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntMay1.ToString() != "0" && cntMay106500.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntMay1 / cntMay106500;
                                cntMayTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntJun1.ToString() != "0" && cntJun106500.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntJun1 / cntJun106500;
                                cntJunTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntJul1.ToString() != "0" && cntJul106500.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntJul1 / cntJul106500;
                                cntJulTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntAug1.ToString() != "0" && cntAug106500.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntAug1 / cntAug106500;
                                cntAugTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntSep1.ToString() != "0" && cntSep106500.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntSep1 / cntSep106500;
                                cntSepTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntOct1.ToString() != "0" && cntOct106500.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntOct1 / cntOct106500;
                                cntOctTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntNov1.ToString() != "0" && cntNov106500.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntNov1 / cntNov106500;
                                cntNovTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntDec1.ToString() != "0" && cntDec106500.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntDec1 / cntDec106500;
                                cntDecTotalDecimal = Math.Round(calcDecimal, 2);
                            }

                            ytd1 = cntJan1 + cntFeb1 + cntMar1 + cntApr1 + cntMay1 + cntJun1 + cntJul1 + cntAug1 + cntSep1 + cntOct1 + cntNov1 + cntDec1;
                            ytd2 = cntJan106500 + cntFeb106500 + cntMar106500 + cntApr106500 + cntMay106500 + cntJun106500 + cntJul106500 + cntAug106500 + cntSep106500 + cntOct106500 + cntNov106500 + cntDec106500;

                            cntYtdTotalDecimal = cntAveTotalDecimal = 0;
                            if (ytd1.ToString() != "0" && ytd2.ToString() != "0")
                            {
                                calcDecimal = (decimal)ytd1 / ytd2;
                                cntYtdTotalDecimal = Math.Round(calcDecimal, 2);
                                if (!String.IsNullOrEmpty(ytd1.ToString()) && !String.IsNullOrEmpty(ytd2.ToString()))
                                {
                                    ave1 = (decimal)Math.Round((decimal)ytd1 / (decimal)months);
                                    ave2 = (decimal)Math.Round((decimal)ytd2 / (decimal)months);
                                    calcDecimal = (decimal)ave1 / ave2;
                                    cntAveTotalDecimal = Math.Round(calcDecimal, 2);
                                }
                            }

                            sql = "UPDATE METRICS SET JAN = '" + cntJanTotalDecimal + "', FEB = '" + cntFebTotalDecimal + "', MAR = '" + cntMarTotalDecimal + "', APR = '" + cntAprTotalDecimal + "', MAY = '" + cntMayTotalDecimal + "', Jun = '" + cntJunTotalDecimal + "', JUL = '" + cntJulTotalDecimal + "', AUG = '" + cntAugTotalDecimal + "', SEP = '" + cntSepTotalDecimal + "', OCT = '" + cntOctTotalDecimal + "', NOV = '" + cntNovTotalDecimal + "', DEC = '" + cntDecTotalDecimal + "', YTD = '" + cntYtdTotalDecimal + "', AVE = '" + cntAveTotalDecimal + "' WHERE ID = '" + GridView.DataKeys[i].Values[0].ToString() + "'";
                            DBHelper.Execute(sql);
                            break;
                        case "107400":
                            cntJanTotalDecimal = cntFebTotalDecimal = cntMarTotalDecimal = cntAprTotalDecimal = cntMayTotalDecimal = cntJunTotalDecimal = cntJulTotalDecimal = cntAugTotalDecimal = cntSepTotalDecimal = cntOctTotalDecimal = cntNovTotalDecimal = cntDecTotalDecimal = 0;
                            if (cntJan1.ToString() != "0" && cntJan106600.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntJan1 / cntJan106600;
                                cntJanTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntFeb1.ToString() != "0" && cntFeb106600.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntFeb1 / cntFeb106600;
                                cntFebTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntMar1.ToString() != "0" && cntMar106600.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntMar1 / cntMar106600;
                                cntMarTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntApr1.ToString() != "0" && cntApr106600.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntApr1 / cntApr106600;
                                cntAprTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntMay1.ToString() != "0" && cntMay106600.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntMay1 / cntMay106600;
                                cntMayTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntJun1.ToString() != "0" && cntJun106600.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntJun1 / cntJun106600;
                                cntJunTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntJul1.ToString() != "0" && cntJul106600.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntJul1 / cntJul106600;
                                cntJulTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntAug1.ToString() != "0" && cntAug106600.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntAug1 / cntAug106600;
                                cntAugTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntSep1.ToString() != "0" && cntSep106600.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntSep1 / cntSep106600;
                                cntSepTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntOct1.ToString() != "0" && cntOct106600.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntOct1 / cntOct106600;
                                cntOctTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntNov1.ToString() != "0" && cntNov106600.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntNov1 / cntNov106600;
                                cntNovTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntDec1.ToString() != "0" && cntDec106600.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntDec1 / cntDec106600;
                                cntDecTotalDecimal = Math.Round(calcDecimal, 2);
                            }

                            ytd1 = cntJan1 + cntFeb1 + cntMar1 + cntApr1 + cntMay1 + cntJun1 + cntJul1 + cntAug1 + cntSep1 + cntOct1 + cntNov1 + cntDec1;
                            ytd2 = cntJan106600 + cntFeb106600 + cntMar106600 + cntApr106600 + cntMay106600 + cntJun106600 + cntJul106600 + cntAug106600 + cntSep106600 + cntOct106600 + cntNov106600 + cntDec106600;

                            cntYtdTotalDecimal = cntAveTotalDecimal = 0;
                            if (ytd1.ToString() != "0" && ytd2.ToString() != "0")
                            {
                                calcDecimal = (decimal)ytd1 / ytd2;
                                cntYtdTotalDecimal = Math.Round(calcDecimal, 2);
                                if (!String.IsNullOrEmpty(ytd1.ToString()) && !String.IsNullOrEmpty(ytd2.ToString()))
                                {
                                    ave1 = (decimal)Math.Round((decimal)ytd1 / (decimal)months);
                                    ave2 = (decimal)Math.Round((decimal)ytd2 / (decimal)months);
                                    calcDecimal = (decimal)ave1 / ave2;
                                    cntAveTotalDecimal = Math.Round(calcDecimal, 2);
                                }
                            }

                            sql = "UPDATE METRICS SET JAN = '" + cntJanTotalDecimal + "', FEB = '" + cntFebTotalDecimal + "', MAR = '" + cntMarTotalDecimal + "', APR = '" + cntAprTotalDecimal + "', MAY = '" + cntMayTotalDecimal + "', Jun = '" + cntJunTotalDecimal + "', JUL = '" + cntJulTotalDecimal + "', AUG = '" + cntAugTotalDecimal + "', SEP = '" + cntSepTotalDecimal + "', OCT = '" + cntOctTotalDecimal + "', NOV = '" + cntNovTotalDecimal + "', DEC = '" + cntDecTotalDecimal + "', YTD = '" + cntYtdTotalDecimal + "', AVE = '" + cntAveTotalDecimal + "' WHERE ID = '" + GridView.DataKeys[i].Values[0].ToString() + "'";
                            DBHelper.Execute(sql);
                            break;
                        case "108200":
                            cntJanTotalDecimal = cntFebTotalDecimal = cntMarTotalDecimal = cntAprTotalDecimal = cntMayTotalDecimal = cntJunTotalDecimal = cntJulTotalDecimal = cntAugTotalDecimal = cntSepTotalDecimal = cntOctTotalDecimal = cntNovTotalDecimal = cntDecTotalDecimal = 0;
                            if (cntJan3.ToString() != "0" && cntJanTotal.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntJan3 / cntJanTotal;
                                cntJanTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntFeb3.ToString() != "0" && cntFebTotal.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntFeb3 / cntFebTotal;
                                cntFebTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntMar3.ToString() != "0" && cntMarTotal.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntMar3 / cntMarTotal;
                                cntMarTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntApr3.ToString() != "0" && cntAprTotal.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntApr3 / cntAprTotal;
                                cntAprTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntMay3.ToString() != "0" && cntMayTotal.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntMay3 / cntMayTotal;
                                cntMayTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntJun3.ToString() != "0" && cntJunTotal.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntJun3 / cntJunTotal;
                                cntJunTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntJul3.ToString() != "0" && cntJulTotal.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntJul3 / cntJulTotal;
                                cntJulTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntAug3.ToString() != "0" && cntAugTotal.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntAug3 / cntAugTotal;
                                cntAugTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntSep3.ToString() != "0" && cntSepTotal.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntSep3 / cntSep1;
                                cntSepTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntOct3.ToString() != "0" && cntOctTotal.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntOct3 / cntOctTotal;
                                cntOctTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntNov3.ToString() != "0" && cntNovTotal.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntNov3 / cntNovTotal;
                                cntNovTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntDec3.ToString() != "0" && cntDecTotal.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntDec3 / cntDecTotal;
                                cntDecTotalDecimal = Math.Round(calcDecimal, 2);
                            }

                            ytd1 = cntJanTotal + cntFebTotal + cntMarTotal + cntAprTotal + cntMayTotal + cntJunTotal + cntJulTotal + cntAugTotal + cntSepTotal + cntOctTotal + cntNovTotal + cntDecTotal;
                            ytd3 = cntJan3 + cntFeb3 + cntMar3 + cntApr3 + cntMay3 + cntJun3 + cntJul3 + cntAug3 + cntSep3 + cntOct3 + cntNov3 + cntDec3;

                            cntYtdTotalDecimal = cntAveTotalDecimal = 0;
                            if (ytd1.ToString() != "0" && ytd3.ToString() != "0")
                            {
                                calcDecimal = (decimal)ytd3 / ytd1;
                                cntYtdTotalDecimal = Math.Round(calcDecimal, 2);
                                if (!String.IsNullOrEmpty(ytd1.ToString()) && !String.IsNullOrEmpty(ytd3.ToString()))
                                {
                                    ave1 = (decimal)Math.Round((decimal)ytd1 / (decimal)months);
                                    ave2 = (decimal)Math.Round((decimal)ytd3 / (decimal)months);
                                    calcDecimal = (decimal)ave2 / ave1;
                                    cntAveTotalDecimal = Math.Round(calcDecimal, 2);
                                }
                            }

                            sql = "UPDATE METRICS SET JAN = '" + cntJanTotalDecimal + "', FEB = '" + cntFebTotalDecimal + "', MAR = '" + cntMarTotalDecimal + "', APR = '" + cntAprTotalDecimal + "', MAY = '" + cntMayTotalDecimal + "', Jun = '" + cntJunTotalDecimal + "', JUL = '" + cntJulTotalDecimal + "', AUG = '" + cntAugTotalDecimal + "', SEP = '" + cntSepTotalDecimal + "', OCT = '" + cntOctTotalDecimal + "', NOV = '" + cntNovTotalDecimal + "', DEC = '" + cntDecTotalDecimal + "', YTD = '" + cntYtdTotalDecimal + "', AVE = '" + cntAveTotalDecimal + "' WHERE ID = '" + GridView.DataKeys[i].Values[0].ToString() + "'";
                            DBHelper.Execute(sql);
                            cntJanTotal = cntFebTotal = cntMarTotal = cntAprTotal = cntMayTotal = cntJunTotal = cntJulTotal = cntAugTotal = cntSepTotal = cntOctTotal = cntNovTotal = cntDecTotal = cntDecTotal = cntYtd = 0;
                            break;
                        case "109000":
                        case "109500":
                            cntJanTotalDecimal = cntFebTotalDecimal = cntMarTotalDecimal = cntAprTotalDecimal = cntMayTotalDecimal = cntJunTotalDecimal = cntJulTotalDecimal = cntAugTotalDecimal = cntSepTotalDecimal = cntOctTotalDecimal = cntNovTotalDecimal = cntDecTotalDecimal = 0;
                            if (cntJan1.ToString() != "0" && cntJan2.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntJan2 / cntJan1;
                                cntJanTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntFeb1.ToString() != "0" && cntFeb2.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntFeb2 / cntFeb1;
                                cntFebTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntMar1.ToString() != "0" && cntMar2.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntMar2 / cntMar1;
                                cntMarTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntApr1.ToString() != "0" && cntApr2.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntApr2 / cntApr1;
                                cntAprTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntMay1.ToString() != "0" && cntMay2.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntMay2 / cntMay1;
                                cntMayTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntJun1.ToString() != "0" && cntJun2.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntJun2 / cntJun1;
                                cntJunTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntJul1.ToString() != "0" && cntJul2.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntJul2 / cntJul1;
                                cntJulTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntAug1.ToString() != "0" && cntAug2.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntAug2 / cntAug1;
                                cntAugTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntSep1.ToString() != "0" && cntSep2.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntSep2 / cntSep1;
                                cntSepTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntOct1.ToString() != "0" && cntOct2.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntOct2 / cntOct1;
                                cntOctTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntNov1.ToString() != "0" && cntNov2.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntNov2 / cntNov1;
                                cntNovTotalDecimal = Math.Round(calcDecimal, 2);
                            }
                            if (cntDec1.ToString() != "0" && cntDec2.ToString() != "0")
                            {
                                calcDecimal = (decimal)cntDec2 / cntDec1;
                                cntDecTotalDecimal = Math.Round(calcDecimal, 2);
                            }

                            ytd1 = cntJan1 + cntFeb1 + cntMar1 + cntApr1 + cntMay1 + cntJun1 + cntJul1 + cntAug1 + cntSep1 + cntOct1 + cntNov1 + cntDec1;
                            ytd2 = cntJan2 + cntFeb2 + cntMar2 + cntApr2 + cntMay2 + cntJun2 + cntJul2 + cntAug2 + cntSep2 + cntOct2 + cntNov2 + cntDec2;

                            cntYtdTotalDecimal = cntAveTotalDecimal = 0;
                            if (ytd1.ToString() != "0" && ytd2.ToString() != "0")
                            {
                                calcDecimal = (decimal)ytd2 / ytd1;
                                cntYtdTotalDecimal = Math.Round(calcDecimal, 2);
                                if (!String.IsNullOrEmpty(ytd1.ToString()) && !String.IsNullOrEmpty(ytd2.ToString()))
                                {
                                    ave1 = (decimal)Math.Round((decimal)ytd1 / (decimal)months);
                                    ave2 = (decimal)Math.Round((decimal)ytd2 / (decimal)months);
                                    calcDecimal = (decimal)ave2 / ave1;
                                    cntAveTotalDecimal = Math.Round(calcDecimal, 2);
                                }
                            }

                            sql = "UPDATE METRICS SET JAN = '" + cntJanTotalDecimal + "', FEB = '" + cntFebTotalDecimal + "', MAR = '" + cntMarTotalDecimal + "', APR = '" + cntAprTotalDecimal + "', MAY = '" + cntMayTotalDecimal + "', Jun = '" + cntJunTotalDecimal + "', JUL = '" + cntJulTotalDecimal + "', AUG = '" + cntAugTotalDecimal + "', SEP = '" + cntSepTotalDecimal + "', OCT = '" + cntOctTotalDecimal + "', NOV = '" + cntNovTotalDecimal + "', DEC = '" + cntDecTotalDecimal + "', YTD = '" + cntYtdTotalDecimal + "', AVE = '" + cntAveTotalDecimal + "' WHERE ID = '" + GridView.DataKeys[i].Values[0].ToString() + "'";
                            DBHelper.Execute(sql);
                            cntJanTotal = cntFebTotal = cntMarTotal = cntAprTotal = cntMayTotal = cntJunTotal = cntJulTotal = cntAugTotal = cntSepTotal = cntOctTotal = cntNovTotal = cntDecTotal = cntDecTotal = cntYtd = 0;
                            break;
                        case "110000":
                            cntJanTotal = cntJan3 + cntJan4;
                            cntFebTotal = cntFeb3 + cntFeb4;
                            cntMarTotal = cntMar3 + cntMar4;
                            cntAprTotal = cntApr3 + cntApr4;
                            cntMayTotal = cntMay3 + cntMay4;
                            cntJunTotal = cntJun3 + cntJun4;
                            cntJulTotal = cntJul3 + cntJul4;
                            cntAugTotal = cntAug3 + cntAug4;
                            cntSepTotal = cntSep3 + cntSep4;
                            cntOctTotal = cntOct3 + cntOct4;
                            cntNovTotal = cntNov3 + cntNov4;
                            cntDecTotal = cntDec3 + cntDec4;
                            cntYtdTotal = cntJanTotal + cntFebTotal + cntMarTotal + cntAprTotal + cntMayTotal + cntJunTotal + cntJulTotal + cntAugTotal + cntSepTotal + cntOctTotal + cntNovTotal + cntDecTotal;

                            if (!String.IsNullOrEmpty(cntYtdTotal.ToString()))
                            {
                                ave = (decimal)Math.Round((decimal)cntYtdTotal / (decimal)months);
                                mv.Ave = ave.ToString();
                            }
                            else { mv.Ave = "0"; }
                            sql = "UPDATE METRICS SET JAN = '" + cntJanTotal + "', FEB = '" + cntFebTotal + "', MAR = '" + cntMarTotal + "', APR = '" + cntAprTotal + "', MAY = '" + cntMayTotal + "', Jun = '" + cntJunTotal + "', JUL = '" + cntJulTotal + "', AUG = '" + cntAugTotal + "', SEP = '" + cntSepTotal + "', OCT = '" + cntOctTotal + "', NOV = '" + cntNovTotal + "', DEC = '" + cntDecTotal + "', YTD = '" + cntYtdTotal + "', AVE = '" + mv.Ave + "' WHERE ID = '" + GridView.DataKeys[i].Values[0].ToString() + "'";
                            DBHelper.Execute(sql);
                            cntJanTotal = cntFebTotal = cntMarTotal = cntAprTotal = cntMayTotal = cntJunTotal = cntJulTotal = cntAugTotal = cntSepTotal = cntOctTotal = cntNovTotal = cntDecTotal = cntDecTotal = cntYtd = cntJan1 = cntJan2 = cntJan3 = cntJan4 = cntJan5 = cntJan6 = cntJan7 = cntFeb1 = cntFeb2 = cntFeb3 = cntFeb4 = cntFeb5 = cntFeb6 = cntFeb7 =
                            cntMar1 = cntMar2 = cntMar3 = cntMar4 = cntMar5 = cntMar6 = cntMar7 = cntApr1 = cntApr2 = cntApr3 = cntApr4 = cntApr5 = cntApr6 = cntApr7 = cntMay1 = cntMay2 = cntMay3 = cntMay4 = cntMay5 = cntMay6 = cntMay7 = cntJun1 = cntJun2 = cntJun3 = cntJun4 = cntJun5 = cntJun6 = cntJun7 = cntJul1 = cntJul2 = cntJul3 = cntJul4 = cntJul5 = cntJul6 = cntJul7 =
                            cntAug1 = cntAug2 = cntAug3 = cntAug4 = cntAug5 = cntAug6 = cntAug7 = cntSep1 = cntSep2 = cntSep3 = cntSep4 = cntSep5 = cntSep6 = cntSep7 = cntOct1 = cntOct2 = cntOct3 = cntOct4 = cntOct5 = cntOct6 = cntOct7 = cntNov1 = cntNov2 = cntNov3 = cntNov4 = cntNov5 = cntNov6 = cntNov7 = cntDec1 = cntDec2 = cntDec3 = cntDec4 = cntDec5 = cntDec = cntDec7 = 0;
                            break;
                        default:
                            break;
                    }
                }
                i = i + 1;
            }
        }
        GridView.DataBind();
    }
    protected void btnCreate_Click(object sender, EventArgs e)
    {
        DataView dv = (DataView)dsCountExportAll.Select(DataSourceSelectArguments.Empty);
        DataTable dt = (DataTable)dv.ToTable();
        Excel.ExportToExcelCenter(dt, "Metrics Report");
    }
}