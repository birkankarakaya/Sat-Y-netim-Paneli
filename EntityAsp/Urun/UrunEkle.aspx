<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="UrunEkle.aspx.cs" Inherits="EntityAsp.Urun.UrunEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form runat="server" class="form-group">
        <div>
            <asp:TextBox ID="txtUrunAd" runat="server" placeholder="Ürün adını giriniz..." CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:TextBox ID="txtUrunMarka" runat="server" placeholder="Ürün markası giriniz..." CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:DropDownList ID="drpKategori" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <br />
        <div>
            <asp:TextBox ID="txtUrunFiyat" runat="server" placeholder="Ürün fiyatını giriniz..." CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:TextBox ID="txtUrunStok" runat="server" placeholder="Ürün stok bilgisi giriniz..." CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Button ID="Button1" runat="server" Text="Ürün Ekle" CssClass="btn btn-primary" OnClick="Button1_Click"/>
        </div>
    </form>

</asp:Content>
