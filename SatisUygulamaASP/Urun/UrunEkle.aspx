<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="UrunEkle.aspx.cs" Inherits="SatisUygulamaASP.Urun.UrunEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form runat="server">
        <div>
            <asp:TextBox ID="txtUrunAd" runat="server" placeholder="Ürün Adını Girin ..." CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:TextBox ID="txtMarka" runat="server" placeholder="Markayı Girin ..." CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <br />
        <div>
            <asp:TextBox ID="txtFiyat" runat="server" placeholder="Fiyatı Girin ..." CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:TextBox ID="txtStok" runat="server" placeholder="Stok Sayısı ..." CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Button ID="btnEkle" runat="server" Text="Ürün Ekle" CssClass="btn bg-primary" OnClick="btnEkle_Click" />
        </div>
    </form>

</asp:Content>
