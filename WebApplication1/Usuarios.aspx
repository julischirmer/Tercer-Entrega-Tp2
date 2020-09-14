<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style2 {
            height: 27px;
            text-align: center;
        }
        .auto-style4 {
            height: 33px;
            text-align: center;
        }
        .auto-style5 {
            text-align: center;
            height: 38px;
        }
        .auto-style6 {
            margin-left: 0px;
        }
        .auto-style7 {
            height: 38px;
        }
        .auto-style8 {
            height: 27px;
            text-align: left;
        }
        .auto-style9 {
            height: 33px;
        }
        .auto-style10 {
            text-align: center;
        }
        .auto-style11 {
            width: 57%;
            height: 342px;
        }
        .auto-style12 {
            text-align: right;
        }
        .auto-style13 {
            width: 165px;
        }
        .auto-style14 {
            width: 160px;
        }
        .auto-style15 {
            width: 42%;
        }
        .auto-style16 {
            margin-left: 0px;
            margin-top: 15px;
        }
        .auto-style17 {
            width: 697px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>           
                
                <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" CssClass="auto-style16" DataKeyNames="ID" DataSourceID="ods_Usuarios" ForeColor="Black" GridLines="Horizontal" OnSelectedIndexChanged="gridView_SelectedIndexChanged" Width="537px">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                        <asp:BoundField DataField="NombreUsuario" HeaderText="NombreUsuario" SortExpression="NombreUsuario" />
                        <asp:BoundField DataField="Clave" HeaderText="Clave" SortExpression="Clave" />
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                        <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
                        <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                        <asp:CheckBoxField DataField="Habilitado" HeaderText="Habilitado" SortExpression="Habilitado" />
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
                    
            <table class="auto-style15">
                    <tr>
                        <td class="auto-style13">
                            <asp:Button ID="btn_nuevo" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" Text="Nuevo" Width="175px" OnClick="btn_nuevo_Click" />
                        </td>
                        <td class="auto-style14">
                            <asp:Button ID="btn_editar" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" OnClick="btn_editar_Click" Text="Editar" Width="175px" />
                        </td>
                        <td>
                            <asp:Button ID="btn_eliminar" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" Text="Eliminar" Width="175px" OnClick="btn_eliminar_Click" />
                        </td>
                    </tr>
                </table>
                    
        </div>
        <asp:Panel ID="formPanel" Visible="false" runat="server" >
        <table class="auto-style11">
            <caption class="auto-style17">
                USUARIOS</caption>
            <tr>
                <td class="auto-style8">ID</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txt_ID" runat="server" BackColor="#CCCCCC" Height="20px" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;Usuario:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txt_Usuario" runat="server" Height="20px" TabIndex="1" Width="300px" MaxLength="20"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Nombre:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txt_nombre" runat="server" CssClass="auto-style6" Height="20px" TabIndex="2" Width="300px" AutoCompleteType="FirstName" MaxLength="20"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Apellido:</td>
                <td class="auto-style10">
                    <asp:TextBox ID="txt_apellido" runat="server" CssClass="auto-style6" Height="20px" TabIndex="3" Width="300px" AutoCompleteType="LastName"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Email:</td>
                <td class="auto-style10">
                    <asp:TextBox ID="txt_email" runat="server" CssClass="auto-style6" Height="20px" TabIndex="4" Width="300px" AutoCompleteType="Email"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Clave</td>
                <td class="auto-style10">
                    <asp:TextBox ID="txt_clave" runat="server" CssClass="auto-style6" Height="20px" TabIndex="5" Width="300px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Confirmar Clave</td>
                <td class="auto-style10">
                    <asp:TextBox ID="txt_confClave" runat="server" CssClass="auto-style6" Height="20px" TabIndex="6" Width="300px" SkinID="*"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:CheckBox ID="chb_habilitado" runat="server" TabIndex="7" Text="Habilitado" />
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

        <asp:ObjectDataSource ID="ods_Usuarios" runat="server" DataObjectTypeName="Business.Entities.Usuario" DeleteMethod="Delete" InsertMethod="Delete" SelectMethod="GetAll" TypeName="Business.Logic.UsuarioLogic" UpdateMethod="Save">
            <DeleteParameters>
                <asp:Parameter Name="ID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="ID" Type="Int32" />
            </InsertParameters>
        </asp:ObjectDataSource>
    </form>
</body>
</html>
