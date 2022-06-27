<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="EmpleadoMan01.aspx.cs" Inherits="Mantenimiento_EmpleadoMan01" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">

        <ContentTemplate>
             <h1  style="margin-left:180px; font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif">MANTENIMIENTO DE EMPLEADOS</h1>
             <br/>
            <table class="auto-style8">
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="grvDatos" runat="server" CellPadding="3" Width="950px" OnRowCommand="grvDatos_RowCommand" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" Font-Bold="False" Font-Italic="True" GridLines="Horizontal" Height="137px">
                            <AlternatingRowStyle BackColor="#F7F7F7" />
                            <Columns>
                                <asp:ButtonField CommandName="Editar" Text="Botón" ButtonType="Image" ImageUrl="~/Images/Editar.png" />
                                <asp:BoundField DataField="id_Empleado" HeaderText="ID" />
                                <asp:BoundField DataField="Emp_Nom" HeaderText="Nombres" />
                                <asp:BoundField DataField="Emp_ApeP" HeaderText="Apellido P." />
                                <asp:BoundField DataField="Emp_ApeM" HeaderText="Apellido M." />
                                <asp:BoundField DataField="Emp_Telef" HeaderText="Telefono" />
                                <asp:BoundField DataField="Emp_Dni" HeaderText="Dni" />
                                <asp:BoundField DataField="Emp_Direc" HeaderText="Dirección " />
                                <asp:BoundField DataField="Estado" HeaderText="Estado" />
                                <asp:BoundField DataField="Emp_fechaNac" DataFormatString="{0:d}" HeaderText="Fecha Nac." />
                                <asp:BoundField DataField="contraseña" HeaderText="Contraseña" Visible="False" />
                                <asp:BoundField DataField="Cargo" HeaderText="Cargo" />
                            </Columns>
                            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                            <RowStyle ForeColor="#4A3C8C" BackColor="#E7E7FF" />
                            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                            <SortedAscendingCellStyle BackColor="#F4F4FD" />
                            <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                            <SortedDescendingCellStyle BackColor="#D8D8F0" />
                            <SortedDescendingHeaderStyle BackColor="#3E3277" />
                        </asp:GridView>
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnNuevo" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Arial Black" Font-Size="12pt" OnClick="btnNuevo_Click" Text="Nuevo" Width="107px" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblMensaje" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Arial" Font-Size="11pt" ForeColor="Red"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <br />

         <asp:LinkButton Text="" ID = "btnPopup" runat="server" />

            <cc1:ModalPopupExtender ID="mdpEmpleado" runat="server" BackgroundCssClass="FondoAplicacion"  
        TargetControlID="btnPopup" PopupControlID="Panel1">

            </cc1:ModalPopupExtender>

            <asp:Panel ID="Panel1" runat="server"  CssClass="CajaDialogo" align="center" Style="display:table" Width="939px">


                      <table style="border: Solid 3px #D55500;" id="tabla"
                cellpadding="0" cellspacing="0" >
                <tr style="background-color: darkred">
                    <td colspan="2" style="color: White; font-weight: bold; font-size: larger"
                        align="center" class="auto-style1">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Datos del Empleado
                    </td>
                    <td align="center" class="auto-style1" style="color: White; font-weight: bold; font-size: larger"></td>
                </tr>
                <tr>
                    <td align="right" class="auto-style3">
                        </td>
                      <td align="left" class="auto-style7">
                          </td>
                    <td align="left" class="auto-style4">&nbsp;</td>
                </tr>
                <tr>
                    <td align="right" class="auto-style3">
                        ID:</td>
                    <td align="left" class="auto-style7">
                        <asp:Label ID="lblID" runat="server"></asp:Label>
                    </td>
                    <td align="left" class="auto-style4">&nbsp;</td>
                </tr>
                <tr>
                    <td align="right" class="auto-style3">
                        Nombre :</td>
                    <td align="left" class="auto-style7">
                        <asp:TextBox ID="txtNombre" runat="server" Width="322px" Font-Bold="True" Font-Italic="True" Font-Names="Arial" Font-Size="11pt" />
                    </td>
                    <td align="left" class="auto-style4">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNombre" ErrorMessage="Ingrese Nombre" ForeColor="Red" ValidationGroup="G1"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="auto-style3">
                        Apellido P. :
                    </td>
                    <td align="left" class="auto-style7">
                        <asp:TextBox ID="txtAP" runat="server" Width="320px" Height="22px" TabIndex="1" Font-Bold="True" Font-Italic="True" Font-Names="Arial" Font-Size="11pt" />
                    </td>
                    <td align="left" class="auto-style4">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtAP" ErrorMessage="Ingrese Apellido Paterno" ForeColor="Red" ValidationGroup="G1"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                          <tr>
                              <td align="right" class="auto-style3">Apellido M. :</td>
                              <td align="left" class="auto-style7">
                                  <asp:TextBox ID="txtAM" runat="server" Width="320px" TabIndex="2" Font-Bold="True" Font-Italic="True" Font-Names="Arial" Font-Size="11pt" />
                              </td>
                              <td align="left" class="auto-style4">
                                  <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtAM" ErrorMessage="Ingrese Apellido Materno" ForeColor="Red" ValidationGroup="G1"></asp:RequiredFieldValidator>
                              </td>
                          </tr>
                <tr>
                    <td align="right" class="auto-style3">
                        Telefono :</td>
                    <td align="left" class="auto-style7">
                        <asp:TextBox ID="txtTelefono" runat="server" Width="117px" TabIndex="3" MaxLength="9" Font-Bold="True" Font-Italic="True" Font-Names="Arial" Font-Size="11pt" />
                    </td>
                    <td align="left" class="auto-style4">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtTelefono" ErrorMessage="Ingrese Telefono" ForeColor="Red" ValidationGroup="G1"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txtTelefono" ErrorMessage="Formato incorrecto" ForeColor="Red" MaximumValue="999999999" MinimumValue="011111111" Type="Integer" ValidationGroup="G1"></asp:RangeValidator>
                    </td>
                </tr>

                          <tr>
                              <td align="right" class="auto-style8">Dni :</td>
                              <td align="left" class="auto-style9">
                                  <asp:TextBox ID="txtDni" runat="server" Width="117px" TabIndex="4" MaxLength="8" Font-Bold="True" Font-Italic="True" Font-Names="Arial" Font-Size="11pt" />
                              </td>
                              <td align="left" class="auto-style10">
                                  <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtDni" ErrorMessage="Ingrese Dni" ForeColor="Red" ValidationGroup="G1"></asp:RequiredFieldValidator>
                                  <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtDni" ErrorMessage="Formato incorrecto" ForeColor="Red" MaximumValue="99999999" MinimumValue="01111111" Type="Integer" ValidationGroup="G1"></asp:RangeValidator>
                              </td>
                          </tr>
                          <tr>
                              <td align="right" class="auto-style3">Direccion :</td>
                              <td align="left" class="auto-style7">
                                  <asp:TextBox ID="txtDireccion" runat="server" Width="439px" TabIndex="5" Font-Bold="True" Font-Italic="True" Font-Names="Arial" Font-Size="11pt" />
                              </td>
                              <td align="left" class="auto-style4">
                                  <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtDireccion" ErrorMessage="Ingrese Direccion" ForeColor="Red" ValidationGroup="G1"></asp:RequiredFieldValidator>
                              </td>
                          </tr>

                 <tr>
                    <td align="right" class="auto-style3">
                        Fecha Nacimiento :</td>
                    <td align="left" class="auto-style7">
                       <%-- <asp:TextBox ID="txtFechaIngreso" runat="server" Width="487px" />--%>

         <asp:TextBox ID="txtFechaNacimiento" runat="server" TabIndex="6" Font-Bold="True" Font-Italic="True" Font-Names="Arial" Font-Size="11pt"></asp:TextBox>
        <cc1:CalendarExtender ID="txtFechaNacimiento_CalendarExtender" runat="server" BehaviorID="txtFechaNacimiento_CalendarExtender" TargetControlID="txtFechaNacimiento">
        </cc1:CalendarExtender>



                    </td>
                     <td align="left" class="auto-style4">&nbsp;</td>
                </tr>
               
                     <tr>
                         <td align="right" class="auto-style3">Cargo :</td>
                         <td align="left" class="auto-style7">
                             <asp:DropDownList ID="cboCargo" runat="server" TabIndex="7" Font-Bold="True" Font-Italic="True" Font-Names="Arial" Font-Size="11pt">
                             </asp:DropDownList>
                         </td>
                         <td align="left" class="auto-style4">&nbsp;</td>
                     </tr>
                     <tr>
                         <td colspan="2">
                             <asp:Label ID="lblMensaje2" runat="server" CssClass="labelErrores" Width="400px" ForeColor="Red" Font-Bold="True" Font-Italic="True" Font-Names="Arial" Font-Size="11pt"></asp:Label>
                         </td>
                         <td class="auto-style4">&nbsp;</td>
                     </tr>
                     <tr>
                         <td class="auto-style2">
                             <asp:HiddenField ID="hdfAccion" runat="server" />
                         </td>
                         <td class="auto-style2">

                             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                             <asp:Button ID="btnGrabar" runat="server" Text="Grabar" OnClick="btnGrabar_Click1" Width="97px" TabIndex="8" ValidationGroup="G1" BorderColor="#3399FF" Font-Bold="True" Font-Italic="True" Font-Names="Arial Black" Font-Size="12pt" />
                             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                             <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Width="104px" OnClick="btnCancelar_Click" TabIndex="9" BorderColor="#00CC99" Font-Bold="True" Font-Italic="True" Font-Names="Arial Black" Font-Size="12pt" ForeColor="Black" />

                         </td>
                         <td class="auto-style2">
                             <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" Width="86px" OnClick="btnEliminar_Click" TabIndex="10" BorderColor="#FF3300" Font-Bold="True" Font-Italic="True" Font-Names="Arial Black" Font-Size="12pt" />
                             <cc1:ConfirmButtonExtender ID="btnEliminar_ConfirmButtonExtender" runat="server" BehaviorID="btnEliminar_ConfirmButtonExtender" ConfirmText="¿Estas seguro de eliminar el registro?" TargetControlID="btnEliminar" />
                         </td>
                     </tr>
              
                          <tr>
                              <td class="auto-style3">&nbsp;</td>
                              <td class="auto-style7">&nbsp;</td>
                              <td class="auto-style4">&nbsp;</td>
                          </tr>
              
            </table>

            </asp:Panel>



<style type="text/css">
        .overlay  
        {
          position: fixed;
          z-index: 98;
          top: 0px;
          left: 0px;
          right: 0px;
          bottom: 0px;
            background-color: #aaa; 
            filter: alpha(opacity=80); 
            opacity: 0.8; 
        }

        td{

            font-family:Arial;
            font-weight:bold;
        }

        .overlayContent
        {
          z-index: 99;
          margin: 250px auto;
          width: 80px;
          height: 80px;
        }
        .overlayContent h2
        {
            font-size: 18px;
            font-weight: bold;
            color: #000;
        }
        .overlayContent img
        {
          width: 20px;
          height: 20px;
        }

        #tabla {
    background-color: #decccc;
}

        </style>  


            <style type="text/css">
        .overlay  
        {
          position: fixed;
          z-index: 98;
          top: 0px;
          left: 0px;
          right: 0px;
          bottom: 0px;
            background-color: red; 
            filter: alpha(opacity=80); 
            opacity: 0.8; 
        }
        .overlayContent
        {
          z-index: 99;
          margin: 250px auto;
          width: 80px;
          height: 80px;
        }
        .overlayContent h2
        {
            font-size: 18px;
            font-weight: bold;
            color: #000;
        }
        .overlayContent img
        {
          width: 20px;
          height: 20px;
        }

        </style>  






              <br />
              <br />
              <br />
              <br />






        </ContentTemplate>

    </asp:UpdatePanel>



            <asp:UpdateProgress ID="UpdateProgress1" runat="server" DisplayAfter="0" AssociatedUpdatePanelID="UpdatePanel1">
    <%--    <ProgressTemplate >
            <div class="overlay"  />
            <div class ="overlayContent" >
            <h2>  Procesando....</h2> 
                <p>
                    &nbsp;</p>
                <img src ="../Images/indicator.gif" alt ="Loading" border="0"/>
                </div> 
        </ProgressTemplate>--%>
    </asp:UpdateProgress>


</asp:Content>

