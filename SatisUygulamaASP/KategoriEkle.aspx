<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="KategoriEkle.aspx.cs" Inherits="SatisUygulamaASP.KategoriEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form runat="server">
        <div>
            <asp:TextBox ID="txtKategoriAd" runat="server" placeholder="Kategori Adını Girin ..." CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Button ID="btnEkle" runat="server" Text="Kategori Ekle" CssClass="btn bg-primary" OnClick="btnEkle_Click" />
        </div>
    </form>

</asp:Content>
