<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style12 {
            width: 80px;
            text-align: center;
        }
        .auto-style13 {
            width: 383px;
        }
        .auto-style15 {
            width: 186px;
            text-align: center;
        }
        .auto-style16 {
            width: 155px;
            text-align: center;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
        <table class="auto-style1">
            <tr>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style16">&nbsp;</td>
                <td class="auto-style15">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style12">
                    <asp:Label ID="Name_lbl" runat="server" Text="UserId"></asp:Label>
                </td>
                <td class="auto-style16">&nbsp;</td>
                <td class="auto-style15">
                    <asp:TextBox ID="name_tb" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style12">
                    <asp:Label ID="pwd_lbl" runat="server" Text="Password"></asp:Label>
                </td>
                <td class="auto-style16">&nbsp;</td>
                <td class="auto-style15">
                    <asp:TextBox ID="pwd_tb" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style16">
                    <asp:Button ID="login_bbtn" runat="server" OnClick="login_bbtn_Click" Text="Login" />
                </td>
                <td class="auto-style15">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style16">
                    &nbsp;</td>
                <td class="auto-style15">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
</asp:Content>



