<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Especialidades.aspx.cs" Inherits="WebApplication1.Especialidades" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 682px;
        }
        .auto-style2 {
            width: 164px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" CssClass="auto-style16" DataKeyNames="ID" DataSourceID="ods_especialidades" ForeColor="Black" OnSelectedIndexChanged="gridView_SelectedIndexChanged" GridLines="Horizontal" Width="394px" Height="188px">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                        <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion" />
                    </Columns>
                  <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                    <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                    <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                    <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                    <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
        </div>
        <table class="auto-style15">
                    <tr>
                        <td class="auto-style13">
                            <asp:Button ID="btn_nuevo" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" Text="Nuevo" Width="175px" OnClick="btn_nuevo_Click"/>
                        </td>
                        <td class="auto-style14">
                            <asp:Button ID="btn_editar" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" Text="Editar" Width="175px" OnClick="btn_editar_Click" />
                        </td>
                        <td>
                            <asp:Button ID="btn_eliminar" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" Text="Eliminar" Width="175px" OnClick="btn_eliminar_Click" />
                        </td>
                    </tr>
                </table>
        <asp:Panel ID="formPanel" Visible="false" runat="server" Width="852px" >
        <table class="auto-style11">
            <caption class="auto-style17">
                ESPECIALIDADES</caption>
            <tr>
                <td class="auto-style2">ID</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txt_ID" runat="server" BackColor="#CCCCCC" Height="20px" ReadOnly="True" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;Descripcion:</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txt_descripcion" runat="server" Height="20px" TabIndex="1" Width="487px" MaxLength="20"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style12">
                    <asp:Button ID="btn_Aceptar" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" TabIndex="8" Text="Aceptar" Width="100px" OnClick="btn_Aceptar_Click" />
                    <asp:Button ID="btn_Cancelar" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" ForeColor="Black" OnClick="btn_Cancelar_Click" TabIndex="9" Text="Cancelar" Width="100px" />
                </td>
            </tr>
            </table>
            </asp:Panel>
        <asp:ObjectDataSource ID="ods_especialidades" runat="server" SelectMethod="GetAll" TypeName="Business.Logic.EspecialidadLogic"></asp:ObjectDataSource>
    </form>
</body>
</html>
