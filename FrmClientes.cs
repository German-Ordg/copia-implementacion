using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_proyecto
{
    public partial class FrmClientes : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;

        ClsConexionBD con = new ClsConexionBD();



        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmPantallaFacturacion fac = new frmPantallaFacturacion();
            fac.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (TxtNombre.TextLength != 0)
            {
                if (TxtApellido.TextLength != 0)
                {
                    if (txtRTN.TextLength != 0)
                    {
                        if (txtID.TextLength != 0)
                        {
                            String insertarCliente = "INSERT INTO [dbo].[Clientes] ([nombre_cliente],[apellido_cliente],[correo_electronico],[numero_identidad_cliente],[rtn]) " +
                                "VALUES('" + TxtNombre.Text + "','" + TxtApellido.Text + "','" + TxtCorreo.Text + "','" + txtID.Text + "','" + txtRTN.Text + "')";

                            try
                            {
                                con.abrir();
                                cmd = new SqlCommand(insertarCliente, con.conexion);
                                dr = cmd.ExecuteReader();
                                MessageBox.Show("Registro ingresado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("No se ha podido ingresar el cliente" + ex.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese la identidad del cliente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese el RTN del cliente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el apellido del cliente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ingrese el nombre del cliente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.cerrar();

        }
    }
}
