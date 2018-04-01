<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style3 {
            width: 794px;
        }
    .auto-style4 {
        text-align: center;
    }
    .auto-style5 {
            width: 794px;
            text-align: center;
            height: 26px;
        }
    .auto-style6 {
        margin-top: 0px;
    }
        .auto-style12 {
            text-align: center;
            width: 1528px;
            margin-left: 0px;
        }
        .auto-style13 {
            width: 1528px;
        }
        .auto-style14 {
            width: 308px;
            text-align: center;
        }
        .auto-style15 {
            width: 203px;
        }
        .auto-style16 {
            text-align: center;
            width: 203px;
            margin-left: 0px;
        }
        .auto-style17 {
            text-align: center;
            width: 147px;
            margin-left: 0px;
        }
        .auto-style18 {
            text-align: left;
        }
        .auto-style19 {
            text-align: left;
            width: 1528px;
            margin-left: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p class="auto-style6">
        <br />
    <table class="auto-style1">
        <tr>
            <td class="auto-style14">&nbsp;</td>
            <td class="auto-style5">
                <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Login.aspx">SignUp</asp:LinkButton>
            </td>
            <td class="auto-style19">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Register With Us</td>
        </tr>
        <tr>
            <td class="auto-style14">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
            <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
            <td class="auto-style12">
                <br />
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style15">
                            <asp:Label ID="Ui_lbl" runat="server" Text="UserId"></asp:Label>
                        </td>
                        <td class="auto-style17">&nbsp;</td>
                        <td class="auto-style18">
                            <asp:TextBox ID="ui_tb" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style15">
                            <asp:Label ID="Name_lbl" runat="server" Text="Name"></asp:Label>
                        </td>
                        <td class="auto-style17">&nbsp;</td>
                        <td class="auto-style18">
                            <asp:TextBox ID="name_tb" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style15">
                            <asp:Label ID="pwd_lbl" runat="server" Text="Password"></asp:Label>
                        </td>
                        <td class="auto-style17">&nbsp;</td>
                        <td class="auto-style18">
                            <asp:TextBox ID="pwd_tb" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style15">
                            <asp:Label ID="age_lbl" runat="server" Text="Age"></asp:Label>
                        </td>
                        <td class="auto-style17">&nbsp;</td>
                        <td class="auto-style18">
                            <asp:TextBox ID="age_tb" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style15">
                            <asp:Label ID="ccn_lbl" runat="server" Text="CreditCardNo"></asp:Label>
                        </td>
                        <td class="auto-style17">&nbsp;</td>
                        <td class="auto-style18">
                            <asp:TextBox ID="ccn_tb" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style15">
                            <asp:Label ID="cct_lbl" runat="server" Text="CreditCardType"></asp:Label>
                        </td>
                        <td class="auto-style17">&nbsp;</td>
                        <td class="auto-style18">
                            <asp:TextBox ID="cct_tb" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style15">
                            <asp:Label ID="ccem_lbl" runat="server" Text="CcExpiryMonth"></asp:Label>
                        </td>
                        <td class="auto-style17">&nbsp;</td>
                        <td class="auto-style18">
                            <asp:TextBox ID="cem_tb" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style15">
                            <asp:Label ID="cey_lbl" runat="server" Text="CcExpiryYear"></asp:Label>
                        </td>
                        <td class="auto-style17">&nbsp;</td>
                        <td class="auto-style18">
                            <asp:TextBox ID="cey_tb" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style16">&nbsp;</td>
                        <td class="auto-style17">
                            <asp:Button ID="register_bttn" runat="server" Text="Register" OnClick="register_bttn_Click" />
                        </td>
                        <td class="auto-style4">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style16">&nbsp;</td>
                        <td class="auto-style17">&nbsp;</td>
                        <td class="auto-style4">&nbsp;</td>
                    </tr>
                </table>
                <br />
            </td>
        </tr>
        <tr>
            <td class="auto-style14">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style13">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
        </tr>
    </table>
</p>
</asp:Content>

