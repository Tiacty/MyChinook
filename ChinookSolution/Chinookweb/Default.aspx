<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>Chinook Music Store</h1>
        <p class="lead">
            The Chinook Music Store Provides Customers to Create Playlists from a wide selection
            of Music titles. Titles can be selected by Artist, Genre, Album, or Media Type
            
        </p>
         <p>
        Future features will include movies and other video types, and the ability to request media
                for other users to add to their custom playlists.
       
            </p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                
                To be able to create your playlist you must register as a customer
            </p>
            
        </div>
        <div class="col-md-4">
            <h1>More Info</h1>
            <p>
                You can always send us a message.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>     
    </div>
</asp:Content>
