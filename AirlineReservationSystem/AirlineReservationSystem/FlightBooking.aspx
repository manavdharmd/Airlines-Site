<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="FlightBooking.aspx.cs" Inherits="FlightBooking" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style12 {
            width: 174px;
        }
        .auto-style13 {
            height: 26px;
            width: 174px;
        }
        .auto-style14 {
            width: 486px;
        }
        .auto-style15 {
            height: 26px;
            width: 486px;
        }
        .auto-style16 {
            width: 484px;
        }
        .auto-style17 {
            width: 179px;
        }
        .auto-style18 {
            width: 484px;
            height: 29px;
        }
        .auto-style19 {
            width: 179px;
            height: 29px;
        }
        .auto-style20 {
            height: 29px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="View1" runat="server">
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style14">
                            <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                        </td>
                        <td class="auto-style12">&nbsp;</td>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style14">
                            <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                        </td>
                        <td class="auto-style12">&nbsp;</td>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style14">
                            <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
                        </td>
                        <td class="auto-style12">&nbsp;</td>
                        <td>
                            <asp:DropDownList ID="bs_ddl" runat="server" OnSelectedIndexChanged="bs_ddl_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style14">
                            <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
                        </td>
                        <td class="auto-style12">&nbsp;</td>
                        <td>
                            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style15">&nbsp;</td>
                        <td class="auto-style13"></td>
                        <td class="auto-style7">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style14">&nbsp;</td>
                        <td class="auto-style12">
                            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style14">&nbsp;</td>
                        <td class="auto-style12">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </asp:View>
            <asp:View ID="View2" runat="server">
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style16">&nbsp;</td>
                        <td class="auto-style17">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style16">
                            <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
                        </td>
                        <td class="auto-style17">&nbsp;</td>
                        <td>
                            <asp:TextBox ID="pn_txt" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style18">
                            <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label>
                        </td>
                        <td class="auto-style19"></td>
                        <td class="auto-style20">
                            <asp:TextBox ID="age_txt" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style16">&nbsp;</td>
                        <td class="auto-style17">
                            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style16">&nbsp;</td>
                        <td class="auto-style17">
                            <asp:Label ID="Label12" runat="server"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </asp:View>
        </asp:MultiView>
        <br />
    </p>
    <p>
        &nbsp;</p>
    </asp:Content>

