using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Pantallas_proyecto
{
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        ClsConexionBD conect = new ClsConexionBD();
        SqlCommand cmd;

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMenuCRUD cRUD = new FrmMenuCRUD();
            cRUD.Show();
            this.Close();
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            conect.abrir();
            conect.cargarDatosEmpleados(dgvEmpleados);
        }

        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == "  " || txtApellido.Text == "  " || txtPuesto.Text == "  " || txtIdentidad.Text == "  " || txtNumeroTel.Text == "  ")
                {
                    MessageBox.Show("No se pueden Insertar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd = new SqlCommand("Insert into Empleados(codigo_puesto, nombre_empleado, apellido_empleado, numero_identidad_empleado, fecha_nacimiento, fecha_ingreso, num_telefono) Values(" + txtPuesto.Text + ",'" + txtNombre.Text + "', '" + txtApellido.Text + "', '" + txtIdentidad.Text + "', '" + dtpFechaNacimiento.Text + "','" + dtpFechaIngreso.Text + "','" + txtNumeroTel.Text + "')", conect.conexion);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Se han ingresado los Datos con Exito ", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conect.cargarDatosEmpleados(dgvEmpleados);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message.ToString());
                MessageBox.Show("ERROR AL INSERTAR LOS DATOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNombre.Clear();
                txtApellido.Clear();
                txtIdentidad.Clear();
                txtPuesto.Clear();
                txtNumeroTel.Clear();
                txtNombre.Focus();
            }

        }

        private void txtBuscarEmpleado_TextChanged(object sender, EventArgs e)
        {
            var aux = new MetodoBuscarEmpleado();
            aux.filtrar(dgvEmpleados, this.txtBuscarEmpleado.Text.Trim());
        }
    }
}
