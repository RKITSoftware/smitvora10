<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormsProject._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="row">
        <div class="col-md">
            Username :
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        </div>

        <br />

        <div class="col-md">
            Password :
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        </div>

        <div class="col-md">
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </div>
        <br />
        <div class="col-md">
            <asp:Label ID="lblSuccess" runat="server" ></asp:Label>
        </div>

    </div>

</asp:Content>
