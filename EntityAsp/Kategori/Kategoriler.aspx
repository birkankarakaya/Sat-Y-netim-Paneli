<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Kategoriler.aspx.cs" Inherits="EntityAsp.Kategoriler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <table class="table table-bordered">
        <tr>
            <th>KATEGORİ ID</th>
            <th>KATEGORİ AD</th>
            <th>SİL</th>
            <th>GÜNCELLE</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("ID") %></td>
                    <td><%#Eval("KategoriAd") %></td>
                    <td>
                        <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#"~/KategoriSil.aspx?ID=" + Eval("ID") %>' CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                    </td>
                    <td>
                        <asp:HyperLink ID="HyperLink2" NavigateUrl='<%#"~/KategoriGuncelle.aspx?ID=" + Eval("ID") %>' cssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>

    </table>
    <a href="KategoriEkle.aspx" class="btn btn-info">Yeni Kategori Ekle</a>



</asp:Content>
