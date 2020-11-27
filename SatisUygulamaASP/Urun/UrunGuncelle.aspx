<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="UrunGuncelle.aspx.cs" Inherits="SatisUygulamaASP.Urun.UrunGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form runat="server">
        <div class="form-group">
            Ürün Ad
            <asp:TextBox ID="txtUrunAd" runat="server" placeholder="Ürün Adını Girin ..." CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            Marka
            <asp:TextBox ID="txtMarka" runat="server" placeholder="Markayı Girin ..." CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            Kategori
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <br />
        <div>
            Fiyat
            <asp:TextBox ID="txtFiyat" runat="server" placeholder="Fiyatı Girin ..." CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            Stok
            <asp:TextBox ID="txtStok" runat="server" placeholder="Stok Sayısı ..." CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Button ID="btnGuncelle" runat="server" Text="Ürün Güncelle" CssClass="btn bg-primary" OnClick="btnGuncelle_Click" />
        </div>
    </form>

</asp:Content>
