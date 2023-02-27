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
                <asp:DropDownList ID="ddlStartDate" runat="server" DataSourceID="dsStartDate" DataTextField="MONTHYEAR" 
                    DataValueField="MMYY" OnDataBound="ddlAddSelect">
                </asp:DropDownList>
                <asp:SqlDataSource ID="dsStartDate" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                    ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT DISTINCT MONTHYEAR, MMYY, MM, YY FROM METRICS_DATE_VW ORDER BY YY DESC, MM DESC"></asp:SqlDataSource>
            </td>
            <th>End Date:
            </th>
            <td>
                <asp:DropDownList ID="ddlEndDate" runat="server" DataSourceID="dsEndDate" DataTextField="MONTHYEAR"
                    DataValueField="MMYY" OnDataBound="ddlAddSelect">
                </asp:DropDownList>
                <asp:SqlDataSource ID="dsEndDate" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                    ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT DISTINCT MONTHYEAR, MMYY, MM, YY FROM METRICS_DATE_VW ORDER BY YY DESC, MM DESC"> </asp:SqlDataSource>

            </td>
            <td>
                <asp:Button ID="btnSearch" runat="server" Text="Filter" OnClick="btnSearch_Click" />
            </td>
            <td>
                <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />
            </td>
            <%--<td>
                <asp:Button ID="btnExport" runat="server" Text="Export" OnClick="btnExport_Click" />
            </td>--%>
        </tr>
    </table>
    <table>
        <tr>
            <td valign="top">
                <asp:UpdatePanel runat="server" ID="UpdatePanel1">
                    <ContentTemplate>
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="True" DataKeyNames="METRICS_ID" Width="969px" Visible="false"
                            DataSourceID="maintDS" AllowSorting="False" OnRowDataBound="Gridview1_RowDataBound" SkinID="igoogle-summer">
                         <%--   <Columns>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Label ID="lblCategory" runat="server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Label ID="lblField" runat="server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Label ID="lblMonthCnt1" runat="server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Label ID="lblMonthCnt2" Visible="false" runat="server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Label ID="lblMonthCnt3" Visible="false" runat="server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Label ID="lblMonthCnt4" Visible="false" runat="server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Label ID="lblMonthCnt5" Visible="false" runat="server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Label ID="lblMonthCnt6" Visible="false" runat="server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Label ID="lblMonthCnt7" Visible="false" runat="server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Label ID="lblMonthCnt8" Visible="false" runat="server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Label ID="lblMonthCnt9" Visible="false" runat="server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Label ID="lblMonthCnt10" Visible="false" runat="server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Label ID="lblMonthCnt11" Visible="false" runat="server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Label ID="lblMonthCnt12" Visible="false" runat="server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Label ID="lblMonthCnt13" Visible="false" runat="server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Label ID="lblMonthCnt14" Visible="false" runat="server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Label ID="lblMonthCnt15" Visible="false" runat="server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Label ID="lblMonthCnt16" Visible="false" runat="server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Label ID="lblMonthCnt17" Visible="false" runat="server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Label ID="lblMonthCnt18" Visible="false" runat="server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Label ID="lblMonthCnt19" Visible="false" runat="server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Label ID="lblMonthCnt20" Visible="false" runat="server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Label ID="lblMonthCnt21" Visible="false" runat="server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Label ID="lblMonthCnt22" Visible="false" runat="server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Label ID="lblMonthCnt23" Visible="false" runat="server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Label ID="lblMonthCnt24" Visible="false" runat="server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Label ID="lblMonthCnt25" Visible="false" runat="server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Label ID="lblMonthCnt26" Visible="false" runat="server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Label ID="lblMonthCnt27" Visible="false" runat="server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Label ID="lblMonthCnt28" Visible="false" runat="server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Label ID="lblMonthCnt29" Visible="false" runat="server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Label ID="lblMonthCnt30" Visible="false" runat="server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>--%>
                        </asp:GridView>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
    </table>
    <asp:SqlDataSource ID="maintDS" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString%>"
        ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>"
        SelectCommand="SELECT  * FROM METRICS_VW ORDER BY METRICS_ID">
      <%--  <SelectParameters>
            <asp:ControlParameter ControlID="ddlStartDate" PropertyName="SelectedValue" Name="startDate" />
            <asp:ControlParameter ControlID="ddlEndDate" PropertyName="SelectedValue" Name="endDate" />
        </SelectParameters>--%>
    </asp:SqlDataSource>
    <%--   <asp:SqlDataSource ID="dsExport" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
        ProviderName="<%$ ConnectionStrings:HsocConnectionString.ProviderName %>"
        SelectCommand="SELECT SCHEDULE_DATE AS &quot;Scheduled Date&quot;, TECH_NAME AS &quot;Tech&quot;, JOB_TYPE AS &quot;Job Type&quot;, CUSTOMER_NAME AS &quot;Customer&quot;, BAN, JOB_NO AS &quot;Job #&quot;, TICKET_NO AS &quot;Ticket #&quot;, HOURS AS &quot;Hours&quot; FROM (SELECT TO_CHAR(SCHEDULE_DATE, 'MM/DD/YYYY') SCHEDULE_DATE, TECH_NAME, JOB_TYPE, CUSTOMER_NAME, BAN, JOB_NO, TICKET_NO, HOURS, SEQ FROM TIME_SHEET WHERE TECH_NAME IN (SELECT  FNAME || ' ' ||  LNAME as FULLNAME FROM USERS WHERE ACTIVE = 'T' AND DEPARTMENT = 'Technicians') AND((TRUNC(SCHEDULE_DATE) >= TO_DATE(:startDate, 'MM/DD/YYYY') AND TRUNC(SCHEDULE_DATE)  <= TO_DATE(:endDate, 'MM/DD/YYYY') OR SCHEDULE_DATE IS NULL) AND (LOWER(TECH_NAME) LIKE LOWER('%' || :TECH_NAME  || '%')  || '%' OR TECH_NAME IS NULL)) UNION ALL SELECT  '' AS SCHEDULE_DATE, TECH_NAME, 'Total' AS JOB_TYPE, '' AS CUSTOMER_NAME, '' AS BAN, '' AS JOB_NO, '' AS TICKET_NO, to_number((SUM(TRUNC(HOURS)) + TRUNC(SUM(mod(HOURS,1) * 100) / 60)) || '.' || lpad(mod(SUM(mod(HOURS,1) * 100) ,60),2,'0')) AS HOURS, 99 AS SEQ FROM TIME_SHEET WHERE TECH_NAME IN (SELECT  FNAME || ' ' ||  LNAME as FULLNAME FROM USERS WHERE ACTIVE = 'T' AND DEPARTMENT = 'Technicians') AND JOB_TYPE <> 'Lunch' AND JOB_TYPE <> 'On Call' AND ((SCHEDULE_DATE >= TO_DATE(:startDate, 'MM/DD/YYYY') AND SCHEDULE_DATE  <= TO_DATE(:endDate, 'MM/DD/YYYY') OR SCHEDULE_DATE IS NULL) AND (LOWER(TECH_NAME) LIKE LOWER('%' || :TECH_NAME  || '%')  || '%' OR TECH_NAME IS NULL)) GROUP BY TECH_NAME) ORDER BY TECH_NAME, SCHEDULE_DATE,SEQ">
        <SelectParameters>
            <asp:ControlParameter ControlID="txtStartDate" PropertyName="text" Name="startDate" DefaultValue="01/01/0001" />
            <asp:ControlParameter ControlID="txtEndDate" PropertyName="text" Name="endDate" DefaultValue="12/31/9999" />
            <asp:ControlParameter ControlID="ddlTech" PropertyName="text" Name="TECH_NAME" DefaultValue="%" />
        </SelectParameters>
    </asp:SqlDataSource>--%>
</asp:Content>
