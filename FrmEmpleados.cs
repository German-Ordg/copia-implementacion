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
                    cmd = new SqlCommand("Insert into Empleados(codigo_puesto, nombre_empleado, apellido_empleado, numero_identidad_empleado, fecha_nacimiento, fecha_ingreso, num_telefono, Genero) Values(" + txtPuesto.Text + ",'" + txtNombre.Text + "', '" + txtApellido.Text + "', '" + txtIdentidad.Text + "', '" + dtpFechaNacimiento.Text + "','" + dtpFechaIngreso.Text + "','" + txtNumeroTel.Text + "','"+cmbGenero.Text+"')", conect.conexion);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Se han ingresado los Datos con Exito ", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conect.cargarDatosEmpleados(dgvEmpleados);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message.ToString());
                MessageBox.Show("ERROR AL INSERTAR LOS DATOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNombre.Text = " ";
                txtApellido.Text = " ";
                txtIdentidad.Text = " ";
                txtPuesto.Text = " ";
                txtNumeroTel.Text = " ";
                dtpFechaNacimiento.Text = DateTime.Now.ToShortDateString();
                dtpFechaIngreso.Text = DateTime.Now.ToShortDateString();
                cmbGenero.SelectedIndex = -1;
                txtNombre.Focus();
            }

        }

        private void txtBuscarEmpleado_TextChanged(object sender, EventArgs e)
        {
            var aux = new MetodoBuscarEmpleado();
            aux.filtrar(dgvEmpleados, this.txtBuscarEmpleado.Text.Trim());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice;
            int codigo;
            indice = dgvEmpleados.CurrentRow.Index;

            try
            {
                codigo = Convert.ToInt32(dgvEmpleados[0, indice].Value);

              
                dgvEmpleados[1, indice].Value = txtPuesto.Text;
                dgvEmpleados[2, indice].Value = txtNombre.Text;
                dgvEmpleados[3, indice].Value = txtApellido.Text;
                dgvEmpleados[4, indice].Value = txtIdentidad.Text;
                dgvEmpleados[5, indice].Value = dtpFechaNacimiento.Text;
                dgvEmpleados[6, indice].Value = dtpFechaIngreso.Text;
                dgvEmpleados[7, indice].Value = txtNumeroTel.Text;
                dgvEmpleados[8, indice].Value = cmbGenero.Text;

                cmd = new SqlCommand("update Empleados set codigo_puesto = " +txtPuesto.Text+ ", nombre_empleado ='"+txtNombre.Text+"', apellido_empleado = '"+txtApellido.Text+"', numero_identidad_empleado= '"+txtIdentidad.Text+"', fecha_nacimiento = '"+dtpFechaNacimiento.Text+"', fecha_ingreso= '"+dtpFechaIngreso.Text+"', num_telefono = '"+txtNumeroTel.Text+ "',Genero='" + cmbGenero.Text+ "'  where codigo_empelado = " + codigo, conect.conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("El registro fue actualizado exitosamente");
                conect.cargarDatosEmpleados(dgvEmpleados);

                txtNombre.Text = " ";
                txtApellido.Text = " ";
                txtIdentidad.Text= " ";
                txtPuesto.Text= " ";
                txtNumeroTel.Text= " ";
                dtpFechaNacimiento.Text = DateTime.Now.ToShortDateString();
                dtpFechaIngreso.Text = DateTime.Now.ToShortDateString();
                cmbGenero.SelectedIndex = -1;
                txtNombre.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("El registro no pudo ser actualizado" + ex);
            }
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int poc;

            poc = dgvEmpleados.CurrentRow.Index;

            txtPuesto.Text = dgvEmpleados[1, poc].Value.ToString();
            txtNombre.Text = dgvEmpleados[2, poc].Value.ToString();
            txtApellido.Text = dgvEmpleados[3, poc].Value.ToString();
            txtIdentidad.Text = dgvEmpleados[4, poc].Value.ToString();
            dtpFechaNacimiento.Text = dgvEmpleados[5, poc].Value.ToString();
            dtpFechaIngreso.Text = dgvEmpleados[6, poc].Value.ToString();
            txtNumeroTel.Text = dgvEmpleados[7, poc].Value.ToString();
            cmbGenero.Text = dgvEmpleados[8, poc].Value.ToString();


        }
    }
    }

