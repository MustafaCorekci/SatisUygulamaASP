<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YeniSatis.aspx.cs" Inherits="SatisUygulamaASP.Satis.YeniSatis" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form runat="server">
        Ürün Şeçin
        <div>
            <asp:DropDownList ID="ddlUrun" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="ddlUrun_SelectedIndexChanged"></asp:DropDownList>
        </div>
        <br />
        Müşteri Seçin
        <div>
            <asp:DropDownList ID="ddlMusteri" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <br />
        Personel Seçin
        <div>
            <asp:DropDownList ID="ddlPersonel" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <br />
        Fiyat
        <div>
            <asp:TextBox ID="txtFiyat" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />

        <asp:Button ID="btnEkle" runat="server" Text="Satış Yap" CssClass="btn bg-primary" OnClick="btnEkle_Click" />

    </form>

</asp:Content>
