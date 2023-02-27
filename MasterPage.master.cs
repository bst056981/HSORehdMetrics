using Agile.Helper;
using Agile.Services.Interface;
using Agile.Services.Impl;
using Agile.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Web.Security;
using System.Net;
using System.Data;

public partial class MasterPage : System.Web.UI.MasterPage {
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack)
        {
            LITsiteName.Text = (WebConfigurationManager.AppSettings["environmentLabel"]) + (WebConfigurationManager.AppSettings["siteName"]);
            lblSiteName.Text = (WebConfigurationManager.AppSettings["environmentLabel"]) + (WebConfigurationManager.AppSettings["siteName"]);
          
            lblUserInfo.Text = String.Empty;

            LOGO.Attributes.Add("title", Dns.GetHostName());
        }
        //****************************************************************//
        //********** COMMENT IF YOU DO NOT WANT A PING SERVICE ***********//
        //****************************************************************//
        ScriptManager sm = ScriptManager.GetCurrent(Page);
        if (sm.AsyncPostBackSourceElementID.Equals(""))
        {
            string script = "enablePing();";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "myPingTimer", script, true);
        }
        //****************************************************************//
        //*********************** END PING SERVICE ***********************//
        //****************************************************************//
    }

    protected void Logout_Click(object sender, EventArgs e) {
        Session.Abandon();
        FormsAuthentication.SignOut();
        Response.Redirect("~/Secure/Login.aspx?ReturnUrl=" + Request.Url.PathAndQuery.ToString());
    }

    protected void Login_Click(object sender, EventArgs e) {
        Response.Redirect("~/Secure/Login.aspx?ReturnUrl=" + Request.Url.PathAndQuery.ToString());
    }

    //protected void setUserInfoLabel(String userId)
    //{
    //    UserService usrSrv = new UserImpl();
    //    User usr = usrSrv.findUserById(userId);

    //    if (usr.LName == null)
    //    {
    //        lblUserInfo.Text = userId + ": Guest";
    //    }
    //    else
    //    {
    //        String userInfo = usr.FName + " " + usr.LName + ": ";

    //        DataTable dt = DBHelper.SelectDataTable(User.FIND_USER_ROLE_NAMES_BY_USER_ID, DBHelper.mp("userId", usr.UserId));
    //        for (int i = 0; i < dt.Rows.Count; i++)
    //        {
    //            userInfo += (((DataRow)(dt.Rows[i]))["ROLE_NME"]).ToString() + ", ";
    //        }

    //        lblUserInfo.Text = userInfo.Substring(0, userInfo.Length - 2);

    //        Session["UserInfo"] = lblUserInfo.Text;
    //    }
    //}
}