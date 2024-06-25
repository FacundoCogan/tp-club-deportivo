<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <div class="row">
            <div class="col-xs-4">
                <p style="margin-bottom: 0px">Actividades para inscribirse</p>
                <asp:ListBox
                    ID="ListBoxActividades"
                    Rows="20"
                    Width="450px"
                    SelectionMode="Single"
                    runat="server"></asp:ListBox>
                <br />
                <asp:Button
                    ID="ButtonInscribirse"
                    Text="Inscribir"
                    CssClass="btn btn-primary mt-2"
                    OnClick="ButtonInscribirse_Click"
                    runat="server" />
                <br />
                <asp:Label
                    ID="LabelMensaje"
                    CssClass="mt-2"
                    EnableViewState="false"
                    runat="server" />
            </div>
        </div>
    </div>

</asp:Content>
