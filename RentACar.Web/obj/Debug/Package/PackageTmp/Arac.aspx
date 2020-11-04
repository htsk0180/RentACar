<%@ Page Title="" Language="C#" MasterPageFile="~/RentACar.Master" AutoEventWireup="true" CodeBehind="Arac.aspx.cs" Inherits="RentACar.Web.Arac" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width:710px; padding-left:10px; padding-right:10px; font-family:Trebuchet MS; font-size:10pt">
        <div style="width:710px; height:25px; font-weight:bold; font-size:12pt; text-align:center">
            <asp:Label ID="lbBaslik" runat="server" Text="Araç Başlık"></asp:Label>
        </div>
        <hr />
        <div style="width:710px; height:300px;">
            <div style="width:300px; height:100%; float:left; padding-right:10px;">
                <asp:Image ID="imgArac" runat="server" Width="300px" Height="300px" />
            </div>
            <div style="width:400px; height:100%; float:left;">
                <div style="width:100%; height:25px; font-weight:bold; text-align:center;">
                    TEKNİK ÖZELLİKLER
                </div>
                <div style="width:100%; height:385px; text-align:left; vertical-align:top;">
                    <asp:Label ID="lbTeknikOzellikler" runat="server" Text=""></asp:Label>
                </div>
            </div>
        </div>
        <hr />
        <div style="width:710px; height:25px; font-weight:bold; font-size:10pt; text-align:center">
            KİRALAMA FİYATLARI
        </div>
        <hr />
        <div style="width:710px; height:175px;">
            <div style="width:100%; height:25px;">
                <div style="width:50%; height:100%; float:left;">
                    <div style="width:47%; height:100%; float:left; font-weight: bold;">
                        1 - 3 GÜN
                    </div>
                    <div style="width:3%; height:100%; float:left; font-weight:bold;">
                        :
                    </div>
                    <div style="width:50%; height:100%; float:left;">
                        <asp:Label ID="lbFiyat_1_3" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                <div style="width:50%; height:100%; float:left;">
                    <div style="width:47%; height:100%; float:left; font-weight: bold;">
                        AYLIK KİRALAMA
                    </div>
                    <div style="width:3%; height:100%; float:left; font-weight:bold;">
                        :
                    </div>
                    <div style="width:50%; height:100%; float:left;">
                        <asp:Label ID="lbFiyat_Aylik" runat="server" Text=""></asp:Label>
                    </div>
                </div>
            </div>
            <div style="width:100%; height:25px;">
                <div style="width:50%; height:100%; float:left;">
                    <div style="width:47%; height:100%; float:left; font-weight: bold;">
                        3 - 7 GÜN
                    </div>
                    <div style="width:3%; height:100%; float:left; font-weight:bold;">
                        :
                    </div>
                    <div style="width:50%; height:100%; float:left;">
                        <asp:Label ID="lbFiyat_3_7" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                <div style="width:50%; height:100%; float:left;">
                    <div style="width:47%; height:100%; float:left; font-weight: bold;">
                        YILLIK KİRALAMA
                    </div>
                    <div style="width:3%; height:100%; float:left; font-weight:bold;">
                        :
                    </div>
                    <div style="width:50%; height:100%; float:left;">
                        <asp:Label ID="lbFiyat_Yillik" runat="server" Text=""></asp:Label>
                    </div>
                </div>
            </div>
            <div style="width:100%; height:25px;">
                <div style="width:50%; height:100%; float:left;">
                    <div style="width:47%; height:100%; float:left; font-weight: bold;">
                        7 - 10 GÜN
                    </div>
                    <div style="width:3%; height:100%; float:left; font-weight:bold;">
                        :
                    </div>
                    <div style="width:50%; height:100%; float:left;">
                        <asp:Label ID="lbFiyat_7_10" runat="server" Text=""></asp:Label>
                    </div>
                </div>
            </div>
            <div style="width:100%; height:25px;">
                <div style="width:50%; height:100%; float:left;">
                    <div style="width:47%; height:100%; float:left; font-weight: bold;">
                        10 - 15 GÜN
                    </div>
                    <div style="width:3%; height:100%; float:left; font-weight:bold;">
                        :
                    </div>
                    <div style="width:50%; height:100%; float:left;">
                        <asp:Label ID="lbFiyat_10_15" runat="server" Text=""></asp:Label>
                    </div>
                </div>
            </div>
            <div style="width:100%; height:25px;">
                <div style="width:50%; height:100%; float:left;">
                    <div style="width:47%; height:100%; float:left; font-weight: bold;">
                        15 - 20 GÜN
                    </div>
                    <div style="width:3%; height:100%; float:left; font-weight:bold;">
                        :
                    </div>
                    <div style="width:50%; height:100%; float:left;">
                        <asp:Label ID="lbFiyat_15_20" runat="server" Text=""></asp:Label>
                    </div>
                </div>
            </div>
            <div style="width:100%; height:25px;">
                <div style="width:50%; height:100%; float:left;">
                    <div style="width:47%; height:100%; float:left; font-weight: bold;">
                        20 - 30 GÜN
                    </div>
                    <div style="width:3%; height:100%; float:left; font-weight:bold;">
                        :
                    </div>
                    <div style="width:50%; height:100%; float:left;">
                        <asp:Label ID="lbFiyat_20_30" runat="server" Text=""></asp:Label>
                    </div>
                </div>
            </div>
        </div>
        <hr />
        <div style="width:710px;">
            
            <asp:DataList ID="DataList1" runat="server" DataSourceID="ObjectDataSource1" 
                RepeatColumns="6">
                <ItemTemplate>
                    <div style="width:100px; height:100px;">
                        <asp:Image ID="Image1" runat="server" Height="100px" 
                            ImageUrl='<%# Eval("UrunResimPath") %>' Width="100px" />
                    </div>
                </ItemTemplate>
            </asp:DataList>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
                SelectMethod="UrunResimleri" TypeName="RentACar.Web.Data.DataSource">
                <SelectParameters>
                    <asp:QueryStringParameter DefaultValue="0" Name="urunId" 
                        QueryStringField="aracid" Type="Int32" />
                </SelectParameters>
            </asp:ObjectDataSource>
            
        </div>
    </div>
</asp:Content>
