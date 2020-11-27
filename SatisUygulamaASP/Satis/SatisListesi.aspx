﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="SatisListesi.aspx.cs" Inherits="SatisUygulamaASP.Satis.SatisListesi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

        <table class="table table-bordered">
        <tr>
            <th>SATIŞ ID</th>
            <th>ÜRÜN</th>
            <th>PERSONEL</th>
            <th>MÜŞTERİ</th>
            <th>FİYAT</th>
        </tr>

        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("SatisID") %></td>
                    <td><%#Eval("UrunAd") %></td>
                    <td><%#Eval("personel") %></td>
                    <td><%#Eval("musteri") %></td>
                    <td><%#Eval("Fiyat") %></td>              
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>

    <a href="YeniSatis.aspx" class="btn btn-success">Yeni Satış</a>

</asp:Content>
