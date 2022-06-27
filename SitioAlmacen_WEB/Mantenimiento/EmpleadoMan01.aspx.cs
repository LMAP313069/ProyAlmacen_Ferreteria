using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyAlmacen_BE;
using ProyAlmacen_BL;
using ProyAlmacen_ADO;
using System.Windows;

public partial class Mantenimiento_EmpleadoMan01 : System.Web.UI.Page
{
    EmpleadoBE objBE = new EmpleadoBE();
    EmpleadoBL objBL = new EmpleadoBL();
    

    protected void Page_Load(object sender, EventArgs e)
    {

        if (Page.IsPostBack == false)
        {



            try
            {
                Enlazar();
                Limpiar();
                cboCargo.DataSource = objBL.ListarCargo();
                cboCargo.DataValueField = "id_Cargo";
                cboCargo.DataTextField = "Cargo_nom";
                cboCargo.DataBind();


            }
            catch (Exception ex)
            {

                lblMensaje.Text = "Error : " + ex.Message;
            }
        }


    }

    private void Enlazar()
    {
        grvDatos.DataSource = objBL.ListarEmpleadoActivo();
        grvDatos.DataBind();
    }


    private void Limpiar()
    {

        txtNombre.Text = "";
        txtAP.Text = "";
        txtAM.Text = "";
        txtTelefono.Text = "";
        txtDni.Text = "";
        txtDireccion.Text = "";
        txtFechaNacimiento.Text = "";
        cboCargo.ClearSelection();
        txtNombre.Focus();

    }




    protected void btnNuevo_Click(object sender, EventArgs e)
    {



        Limpiar();
        btnEliminar.Enabled = false;

        hdfAccion.Value = "A";
        mdpEmpleado.Show();

    }

    protected void btnGrabar_Click(object sender, EventArgs e)
    {

    }

    protected void btnGrabar_Click1(object sender, EventArgs e)
    {

        try
        {

            objBE.Emp_Nom = txtNombre.Text.Trim();
            objBE.Emp_ApeP = txtAP.Text.Trim();
            objBE.Emp_ApeM = txtAM.Text.Trim();
            objBE.Emp_Telef = txtTelefono.Text.Trim();
            objBE.Emp_Dni = txtDni.Text.Trim();
            objBE.Emp_Direc = txtDireccion.Text.Trim();
            objBE.Emp_fechaNac = Convert.ToDateTime(txtFechaNacimiento.Text);
            objBE.id_Cargo = cboCargo.SelectedValue;

          

            if (hdfAccion.Value == "A")
            {
                if (objBL.InsertarEmpleado(objBE) == true)
                {
                    Enlazar();
                    mdpEmpleado.Hide();
                }
                else
                {
                    lblMensaje2.Text = "Datos no insertados, verifique";
                }
            }
            else if (hdfAccion.Value == "M")
            {
                //Solo si es modificar manejo el codigo

                objBE.id_Empleado = lblID.Text;
                if (objBL.ActualizarEmpleado(objBE) == true)
                {
                    Enlazar();
                    mdpEmpleado.Hide();
                }
                else
                {
                    lblMensaje2.Text = "Datos no Actualizados, verifique";
                }
            }
        }
        catch (Exception ex)
        {

            lblMensaje2.Text = "Error : " + ex.Message;

        }


    }

    protected void grvDatos_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            int fila = Convert.ToInt16(e.CommandArgument);

            if (e.CommandName == "Editar")
            {
                hdfAccion.Value = "M";
                String vcod = grvDatos.Rows[fila].Cells[1].Text;
                objBE = objBL.ConsultarEmpleado(vcod);

                btnEliminar.Enabled = true;

                lblID.Text = objBE.id_Empleado;
                txtNombre.Text = objBE.Emp_Nom;
                txtAP.Text = objBE.Emp_ApeP;
                txtAM.Text = objBE.Emp_ApeM;
                txtTelefono.Text = objBE.Emp_Telef;
                txtDni.Text = objBE.Emp_Dni;
                txtDireccion.Text = objBE.Emp_Direc;
                txtFechaNacimiento.Text = objBE.Emp_fechaNac.ToString();
                cboCargo.SelectedValue = objBE.id_Cargo;


                mdpEmpleado.Show();

            }

        }
        catch (Exception ex)
        {

        }
    }

    protected void btnEliminar_Click(object sender, EventArgs e)
    {

        try
        {

       
            if (objBL.EliminarEmpleado(lblID.Text) == true)
                {
                Enlazar();

                //mdpEmpleado.Hide();
            }
             
         

        }
        catch (Exception ex)
        {
            lblMensaje2.Text = "Error : " + ex.Message;
        }


    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Enlazar();
        mdpEmpleado.Hide();
    }
}