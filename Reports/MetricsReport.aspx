<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="MetricsReport.aspx.cs" Inherits="Reports_MetricsReport"
    Theme="SkinFile" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Assembly="obout_Calendar2_Net" Namespace="OboutInc.Calendar2" TagPrefix="obout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ValidationSummary ID="ValidationSummary" runat="Server" ShowSummary="true" DisplayMode="BulletList"
        ValidationGroup="errorGroup" HeaderText="Following error occured." />
    <h4 align="center">Metrics Report</h4>
    <table class="igoogle-summer" width="969px">
        <tr>
            <th>Start Date:
            </th>
            <td>
                <asp:DropDownList ID="ddlStartDate" runat="server" DataSourceID="dsStartDate" DataTextField="MONTHYEAR" DataValueField="MMYY" OnDataBound="ddlAddSelect">
                </asp:DropDownList>
                <asp:SqlDataSource ID="dsStartDate" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                    ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT DISTINCT MONTHYEAR, MMYY, MM, YY FROM METRICS_DATE_VW ORDER BY YY DESC, MM DESC"></asp:SqlDataSource>
            </td>
            <th>End Date:
            </th>
            <td>
                <asp:DropDownList ID="ddlEndDate" runat="server" DataSourceID="dsEndDate" DataTextField="MONTHYEAR" DataValueField="MMYY" OnDataBound="ddlAddSelect">
                </asp:DropDownList>
                <asp:SqlDataSource ID="dsEndDate" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                    ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT DISTINCT MONTHYEAR, MMYY, MM, YY FROM METRICS_DATE_VW ORDER BY YY DESC, MM DESC"></asp:SqlDataSource>
            </td>
            <td>
                <asp:Button ID="btnSearch" runat="server" Text="Filter" OnClick="btnSearch_Click" />
            </td>
            <td>
                <asp:Button ID="btnExport" runat="server" Text="Export" OnClick="btnExport_Click" Visible="false" />
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td valign="top">
                <asp:UpdatePanel runat="server" ID="UpdatePanel1">
                    <ContentTemplate>
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="True" DataKeyNames="METRICS_ID" Width="1269px" Visible="false" RowStyle-HorizontalAlign="Center"  Style="margin-left: -200px"
                            DataSourceID="maintDS" AllowSorting="False" OnRowDataBound="Gridview1_RowDataBound" SkinID="igoogle-summer" HeaderStyle-HorizontalAlign="Center" > 
                        </asp:GridView>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
    </table>
    <asp:SqlDataSource ID="maintDS" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString%>"
        ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>"
        SelectCommand="SELECT * FROM METRICS_VW ORDER BY METRICS_ID"></asp:SqlDataSource>
    <asp:SqlDataSource ID="dsExport" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
        ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>"
        SelectCommand="SELECT  * FROM METRICS_VW ORDER BY METRICS_ID"></asp:SqlDataSource>
</asp:Content>
