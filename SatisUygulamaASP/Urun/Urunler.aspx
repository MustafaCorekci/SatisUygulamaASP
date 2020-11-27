<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Urunler.aspx.cs" Inherits="SatisUygulamaASP.Urun.Urunler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <table class="table table-bordered">
        <tr>
            <th>ÜRÜN ID</th>
            <th>ÜRÜN ADI</th>
            <th>MARKA</th>
            <th>KATEGORİ</th>
            <th>FİYAT</th>
            <th>STOK</th>
            <th>SİL</th>
            <th>GÜNCELLE</th>
        </tr>

        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("UrunID") %></td>
                    <td><%#Eval("UrunAd") %></td>
                    <td><%#Eval("UrunMarka") %></td>
                    <td><%#Eval("KategoriAd") %></td>
                    <td><%#Eval("UrunFiyat") %></td>
                    <td><%#Eval("UrunStok") %></td>
                    
                    <td><asp:HyperLink NavigateUrl='<%# "~/Urun/UrunSil.aspx?UrunID="+ Eval("UrunID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">SİL</asp:HyperLink></td>

                    <td><asp:HyperLink NavigateUrl='<%# "~/Urun/UrunGuncelle.aspx?UrunID="+ Eval("UrunID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">GÜNCELLE</asp:HyperLink></td>
                
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>

    <a href="UrunEkle.aspx" class="btn btn-success">Yeni Kategori</a>

</asp:Content>
