<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="KategoriGuncelle.aspx.cs" Inherits="SatisUygulamaASP.KategoriGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form runat="server">
        <div>
            <asp:TextBox ID="txtKategoriID" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:TextBox ID="txtKategoriAd" runat="server" placeholder="Kategori Adını Girin ..." CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Button ID="btnGuncelle" runat="server" Text="Kategori Güncelle" CssClass="btn btn-success" OnClick="btnGuncelle_Click"/>
        </div>
    </form>

</asp:Content>
