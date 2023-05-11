<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Metrics.aspx.cs" Inherits="DataEntry_Metrics" Theme="SkinFile" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div style="text-align: center;">
        <asp:Label runat="server" Font-Size="X-Large" ForeColor="Black">Metrics - Entry</asp:Label>
    </div>

    <table>
        <tr>
            <th>Year
            </th>
            <td width="700px">
                <asp:DropDownList ID="ddlYear" runat="server" DataSourceID="dsYear" DataTextField="DESCR"
                    DataValueField="KEY" OnTextChanged="ddlYear_OnTextChanged" AutoPostBack="true">
                </asp:DropDownList>
                <asp:SqlDataSource ID="dsYear" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                    ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT KEY, DESCR FROM STATIC_INFO WHERE TYPE = :YEARS ORDER BY ID DESC">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="YEARS" Name="TYPE" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
            <td   width="100px">
                <asp:Button Text="Update" OnClick="OnUpdate" BackColor="Orange" runat="server" />
            </td>
            <td>
                <asp:Button ID="btnCreate" runat="server" Text="Create Report" OnClick="btnCreate_Click" />
            </td>
        </tr>
    </table>

    <br />

    <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="False" DataKeyNames="ID, METRICS_ID" DataSourceID="dsMetrics" Style="margin-left: -200px"
        AllowSorting="False" SkinID="igoogle-summer" OnRowDataBound="Gridview_RowDataBound" Width="1369px">
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" Visible="False" />
            <asp:BoundField DataField="Category" HeaderText="Category" ReadOnly="True" ItemStyle-BackColor="#F57E20" ItemStyle-HorizontalAlign="Center" />
            <asp:BoundField HeaderText="Field" ReadOnly="true" DataField="Field" ItemStyle-BackColor="#F57E20" ItemStyle-HorizontalAlign="Center" />
            <asp:TemplateField HeaderText="CALC" Visible="false">
                <ItemTemplate>
                    <asp:TextBox ID="txtCalc" runat="server" Visible="false" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Jan">
                <ItemTemplate>
                    <asp:TextBox ID="txtJan" MaxLength="6" runat="server" Width="50px" Style="text-align: right;" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Feb">
                <ItemTemplate>
                    <asp:TextBox ID="txtFeb" MaxLength="6" runat="server" Width="50px" Style="text-align: right;" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Mar">
                <ItemTemplate>
                    <asp:TextBox ID="txtMar" MaxLength="6" runat="server" Width="50px" Style="text-align: right;" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Apr">
                <ItemTemplate>
                    <asp:TextBox ID="txtApr" MaxLength="6" runat="server" Width="50px" Style="text-align: right;" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="May">
                <ItemTemplate>
                    <asp:TextBox ID="txtMay" MaxLength="6" runat="server" Width="50px" Style="text-align: right;" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Jun">
                <ItemTemplate>
                    <asp:TextBox ID="txtJun" MaxLength="6" runat="server" Width="50px" Style="text-align: right;" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Jul">
                <ItemTemplate>
                    <asp:TextBox ID="txtJul" MaxLength="6" runat="server" Width="50px" Style="text-align: right;" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Aug">
                <ItemTemplate>
                    <asp:TextBox ID="txtAug" MaxLength="6" runat="server" Width="50px" Style="text-align: right;" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Sep">
                <ItemTemplate>
                    <asp:TextBox ID="txtSep" MaxLength="6" runat="server" Width="50px" Style="text-align: right;" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Oct">
                <ItemTemplate>
                    <asp:TextBox ID="txtOct" MaxLength="6" runat="server" Width="50px" Style="text-align: right;" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Nov">
                <ItemTemplate>
                    <asp:TextBox ID="txtNov" MaxLength="6" runat="server" Width="50px" Style="text-align: right;" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Dec">
                <ItemTemplate>
                    <asp:TextBox ID="txtDec" MaxLength="6" runat="server" Width="50px" Style="text-align: right;" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="YTD">
                <ItemTemplate>
                    <asp:TextBox ID="txtYTD" runat="server" ReadOnly="true" Width="50px" Style="text-align: right;" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Average">
                <ItemTemplate>
                    <asp:TextBox ID="txtAVE" runat="server" ReadOnly="true" Width="50px" Style="text-align: right;" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

    <br />

    <div style="text-align: center;">
        <asp:Button Text="Update" OnClick="OnUpdate" runat="server" BackColor="Orange" />
    </div>

    <asp:HiddenField ID="hfYear" runat="server" Value="" />
    <asp:SqlDataSource ID="dsMetrics" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
        ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>"
        SelectCommand="SELECT ID, METRICS_ID, CATEGORY, FIELD, JAN, FEB, MAR, APR, MAY, JUN, JUL, AUG, SEP, OCT, NOV, DEC, YTD, AVE, CALC FROM METRICS WHERE YEAR = :year ORDER BY METRICS_ID">
        <SelectParameters>
            <asp:ControlParameter ControlID="hfYear" Name="year" PropertyName="Value" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="dsCountExportAll" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
        ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>"
        SelectCommand="SELECT CATEGORY, FIELD, JAN, FEB, MAR, APR, MAY, JUN, JUL, AUG, SEP, OCT, NOV, DEC, YTD, AVE FROM METRICS WHERE YEAR = :year ORDER BY METRICS_ID">
        <SelectParameters>
            <asp:ControlParameter ControlID="hfYear" Name="year" PropertyName="Value" />
        </SelectParameters>
    </asp:SqlDataSource>

</asp:Content>
