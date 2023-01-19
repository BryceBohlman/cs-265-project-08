<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Calcs.aspx.cs" Inherits="csis265proj08.Calcs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    <br />
</p>
<p>
    <asp:Label ID="lblRectangleLength" runat="server" Text="Rectangle Length:  "></asp:Label>
    <asp:TextBox ID="txtRectangleLength" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Label ID="lblRectangleWidth" runat="server" Text="Rectangle Width:  "></asp:Label>
    <asp:TextBox ID="txtRectangleWidth" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="btnAddRectangle" runat="server" OnClick="btnAddRectangle_Click" Text="Add Rectangle" />
    <asp:Button ID="btnDisplayOutput" runat="server" OnClick="btnDisplayOutput_Click" Text="Display Output" />
</p>
<p>
    <asp:Label ID="lblOutputDisplay" runat="server"></asp:Label>
</p>
</asp:Content>
