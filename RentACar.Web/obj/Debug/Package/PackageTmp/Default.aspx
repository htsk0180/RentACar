<%@ Page Title="" Language="C#" MasterPageFile="~/RentACar.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RentACar.Web.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server" DataSourceID="ObjectDataSource1" 
        RepeatColumns="3">
        <ItemTemplate>
            <div style="width:193px; height:175px; background-image:url('Content/images/kategoribg.png');">
                <div style="width:100%; height:25px; text-align:center; font-family:Trebuchet MS; font-size:10pt; font-weight:bold; color:#333333">
                    <asp:HyperLink ID="HyperLink1" runat="server" 
                        NavigateUrl='Kategori.aspx?kategoriid=<%# Eval("KategoriId") %>' 
                        Text='<%# Eval("KategoriAd") %>' Font-Bold="True" Font-Underline="False" 
                        ForeColor="#333333"></asp:HyperLink>
                </div>
                <div style="width:140px; height:168px; padding-left:5px; padding-right:5px; vertical-align:middle; text-align:right;">
                    <br />
                    <br />
                    <a href="Kategori.aspx?kategoriid=<%# Eval("KategoriId")%>"><img alt="<%# Eval("KategoriAd")%>" style="width:170px; height:85px; vertical-align:middle;" src="<%# Eval("KategoriResimPath") %>" /></a>        
                </div>
            </div>
            <hr />
        </ItemTemplate>
    </asp:DataList>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        SelectMethod="Kategoriler" TypeName="RentACar.Web.Data.DataSource">
    </asp:ObjectDataSource>
</asp:Content>
