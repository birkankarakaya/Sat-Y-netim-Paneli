<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="UrunGuncelle.aspx.cs" Inherits="EntityAsp.Urun.UrunGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form runat="server" class="form-group">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Ürün Adı" Font-Italic="True" Font-Bold="True"></asp:Label>
            <asp:TextBox ID="txtUrunAd" runat="server" placeholder="Ürün adını giriniz..." CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="Label2" runat="server" Text="Ürün Markası" Font-Italic="True" Font-Bold="True"></asp:Label>
            <asp:TextBox ID="txtUrunMarka" runat="server" placeholder="Ürün markası giriniz..." CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="Label3" runat="server" Text="Ürün Kategorisi" Font-Italic="True" Font-Bold="True"></asp:Label>
            <asp:DropDownList ID="drpKategori" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <br />
        <div>
            <asp:Label ID="Label4" runat="server" Text="Ürün Fiyatı" Font-Italic="True" Font-Bold="True"></asp:Label>
            <asp:TextBox ID="txtUrunFiyat" runat="server" placeholder="Ürün fiyatını giriniz..." CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="Label5" runat="server" Text="Ürün Stok Bilgisi" Font-Italic="True" Font-Bold="True"></asp:Label>
            <asp:TextBox ID="txtUrunStok" runat="server" placeholder="Ürün stok bilgisi giriniz..." CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Button ID="Button1" runat="server" Text="Ürün Güncelle" CssClass="btn btn-success" OnClick="Button1_Click"/>
        </div>
    </form>

</asp:Content>
