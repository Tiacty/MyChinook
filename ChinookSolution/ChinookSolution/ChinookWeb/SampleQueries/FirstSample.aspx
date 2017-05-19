<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FirstSample.aspx.cs" Inherits="SampleQueries_FirstSample" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1>Entity vs.LINQ tO Entity Query</h1>
    <asp:ObjectDataSource ID="EntityFrameworkODS" runat="server"
        OldValuesParameterFormatString="original_{0}"
         SelectMethod="Artist_ListAll"
         TypeName="ChinookSystem.BLL.ArtistController">

    </asp:ObjectDataSource>
    <asp:ObjectDataSource ID="LinqToEntityODS" runat="server"></asp:ObjectDataSource>
    <asp:GridView ID="EntityFrameworkList" runat="server" AutoGenerateColumns="False" DataSourceID="EntityFrameworkODS" AllowPaging="True">
        <Columns>
            <asp:BoundField DataField="ArtistId" HeaderText="ArtistId" SortExpression="ArtistId"></asp:BoundField>
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name"></asp:BoundField>
        </Columns>
    </asp:GridView>

    <asp:Label ID="YearLabel" runat="server" Text="Enter Year: " /> &nbsp;
    <asp:TextBox ID="YearEntry" runat="server" Text="2015"></asp:TextBox>&nbsp;&nbsp;
    <asp:Button ID="SubmitQuery" runat="server" Text="Fetch" />
    <asp:GridView ID="LinqToEntityList" runat="server"> </asp:GridView>
</asp:Content>

