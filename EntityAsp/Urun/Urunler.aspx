<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Urunler.aspx.cs" Inherits="EntityAsp.Urun.Urunler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <table class="table table-bordered">
        <tr>
            <th>ID</th>
            <th>ÜRÜN AD</th>
            <th>MARKA</th>
            <th>KATEGORİ</th>
            <th>FİYAT</th>
            <th>STOK</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("ID") %></td>
                    <td><%#Eval("UrunAd") %></td>
                    <td><%#Eval("UrunMarka") %></td>
                    <td><%#Eval("KategoriAd") %></td>
                    <td><%#Eval("UrunFiyat") %></td>
                    <td><%#Eval("UrunStok") %></td>
                    <td>
                        <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#"~/Urun/UrunSil.aspx?ID=" + Eval("ID") %>' CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                    </td>
                    <td>
                        <asp:HyperLink ID="HyperLink2" NavigateUrl='<%#"~/Urun/UrunGuncelle.aspx?ID=" + Eval("ID") %>' CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>

    </table>
    <a href="#" class="btn btn-info">Yeni Ürün Ekle</a>

</asp:Content>
