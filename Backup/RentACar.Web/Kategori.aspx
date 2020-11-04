<%@ Page Title="" Language="C#" MasterPageFile="~/RentACar.Master" AutoEventWireup="true" CodeBehind="Kategori.aspx.cs" Inherits="RentACar.Web.Kategori" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server" DataSourceID="ObjectDataSource1" 
        RepeatColumns="3">
        <ItemTemplate>
            <div style="width:193px; height:175px; background-image:url('Content/images/kategoribg.png');">
                <div style="width:100%; height:25px; text-align:center; font-family:Trebuchet MS; font-size:10pt; font-weight:bold; color:#333333">
                    <asp:HyperLink ID="HyperLink1" runat="server" 
                        NavigateUrl="Arac.aspx?aracid=<%# Eval('UrunId') %>"
                        Text='<%# Eval("UrunAd") %>' Font-Bold="True" Font-Underline="False" 
                        ForeColor="#333333"></asp:HyperLink>
                </div>
                <div style="width:140px; height:168px; padding-left:5px; padding-right:5px; vertical-align:middle; text-align:right;">
                    <br />
                    <br />
                    <a href="Arac.aspx?aracid=<%# Eval("UrunId")%>">
                    <img alt="<%# Eval("UrunAd")%>" style="width:170px; height:85px; vertical-align:middle;" src="<%# Eval("UrunResimPath") %>" />
                    </a>
                </div>
            </div>
            <hr />
        </ItemTemplate>
    </asp:DataList>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        SelectMethod="KategorininUrunleri" TypeName="RentACar.Web.Data.DataSource">
        <SelectParameters>
            <asp:QueryStringParameter DefaultValue="0" Name="kategoriId" 
                QueryStringField="kategoriid" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>
