<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="AddRecordYears.aspx.cs" EnableEventValidation="false" Inherits="Admin_AddRecordYears"
    Theme="SkinFile" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div style="text-align: center;">
        <asp:Label runat="server" Font-Size="X-Large" ForeColor="Black">Add New Year Records</asp:Label>
    </div>

    <table>
        <tr>
            <td>
                <asp:Label ID="LBLerror" runat="server" Text="" Font-Bold="true" Font-Size="Small" ForeColor="Red" Visible="false" />
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <th>Create Year
            </th>
            <td width="200px">
                <asp:DropDownList ID="ddlCreateYear" runat="server" DataSourceID="dsCreateYear" DataTextField="DESCR"
                    DataValueField="KEY" OnTextChanged="ddlCreateYear_OnTextChanged" AutoPostBack="true">
                </asp:DropDownList>
                <asp:SqlDataSource ID="dsCreateYear" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                    ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT KEY, DESCR FROM STATIC_INFO WHERE TYPE = :YEARS ORDER BY ID DESC">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="YEARS" Name="TYPE" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
            <th>Copy Year
            </th>
            <td width="300px">
                <asp:DropDownList ID="ddlCopyYear" runat="server" DataSourceID="dsCopyYear" DataTextField="DESCR"
                    DataValueField="KEY" OnTextChanged="ddlCopyYear_OnTextChanged" AutoPostBack="true">
                </asp:DropDownList>
                <asp:SqlDataSource ID="dsCopyYear" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                    ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT KEY, DESCR FROM STATIC_INFO WHERE TYPE = :YEARS ORDER BY ID DESC">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="YEARS" Name="TYPE" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
            <td>
                <asp:Button Text="Update" OnClick="OnUpdate" BackColor="Orange" runat="server" />
            </td>
        </tr>
    </table>
    <asp:HiddenField ID="hfCopyYear" runat="server" Value="" />
    <asp:HiddenField ID="hfCreateYear" runat="server" Value="" />
</asp:Content>
