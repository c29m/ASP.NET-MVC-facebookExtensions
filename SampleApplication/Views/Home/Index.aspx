<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="FacebookExtensions" %>
<%@ Import Namespace="FacebookExtensions.Markup" %>
<%@ Import Namespace="FacebookExtensions.Markup.SocialPlugin.Like" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="Head" ContentPlaceHolderID="Head" runat="server">
    <%Html.Facebook().OpenGraph.Initilise("Demo Site2", "355645108863");%>
    <%=Html.Facebook().OpenGraph.OpenGraphTags("PageTitle", "http://www.g.com/qwe.jpg", "http://www.google.com", OpenGraphType.Website)%>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: ViewData["Message"] %></h2>
    <p>
        To learn more about ASP.NET MVC visit <a href="http://asp.net/mvc" title="ASP.NET MVC Website">http://asp.net/mvc</a>.
    </p>
    <h2>Facebook Like</h2>
    <div><%=Html.Facebook().SocialPlugins.Like() %></div>

    <h2>Activity Feed</h2>
    <div><%=Html.Facebook().SocialPlugins.ActivityFeed() %></div>

    <h2>Comments</h2>
    <div><%=Html.Facebook().SocialPlugins.Comments() %></div>

    <h2>Facepile</h2>
    <div><%=Html.Facebook().SocialPlugins.Facepile() %></div>

    <h2>LikeBox</h2>
    <div><%=Html.Facebook().SocialPlugins.LikeBox("http://www.facebook.com/justgiving") %></div>

    <h2>LiveStream</h2>
    <div><%=Html.Facebook().SocialPlugins.LiveStream("355645108863") %></div>

    <h2>LoginButton</h2>
    <div><%=Html.Facebook().SocialPlugins.LoginButton() %></div>

    <h2>Recommendations</h2>
    <div><%=Html.Facebook().SocialPlugins.Recommendations() %></div>
</asp:Content>
