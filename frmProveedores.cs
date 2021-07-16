using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pantallas_proyecto
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
            
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        ClsConexionBD conect = new ClsConexionBD();
        SqlCommand cmd;



        private void button7_Click(object sender, EventArgs e)
        {
            FrmMenuCRUD menuCRUD = new FrmMenuCRUD();
            menuCRUD.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             dgvProovedores.ForeColor = Color.Black;
            try
            {
                if (txtNombreProovedor.Text == "  " || txtTelefono.Text == "  " || txtDescripcion.Text == "  ")
                {

                    MessageBox.Show("No se pueden dejar los campos vacios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    cmd = new SqlCommand("Insert into Proveedores(nombre_proveedor, numero_contacto, direccion_proveedor) values('"+ txtNombreProovedor.Text +"','"+ txtTelefono.Text +"','" + txtDescripcion.Text +"')", conect.conexion);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Se han ingresado los Datos con Exito ", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conect.cargarProveedores(dgvProovedores);
                    dgvProovedores.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message.ToString());
                MessageBox.Show("ERROR AL INSERTAR LOS DATOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

               
                txtNombreProovedor.Clear();
                txtTelefono.Clear();
                txtDescripcion.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvProovedores.ForeColor = Color.Black;
            SqlDataAdapter da;
            DataTable dt;
            DataSet DS;
            da = new SqlDataAdapter("Select * From Proveedores", conect.conexion);
            dt = new DataTable();
            da.Fill(dt);
            dgvProovedores.DataSource = dt;
        }

        private void dgvProovedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripLabel1.Text = DateTime.Now.ToLongDateString();
            toolStripLabel2.Text = DateTime.Now.ToLongTimeString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int indice;
            int codigo;
            indice = dgvProovedores.CurrentRow.Index;

            try
            {
                codigo = Convert.ToInt32(dgvProovedores[0, indice].Value);


                dgvProovedores[1, indice].Value = txtNombreProovedor.Text;
                dgvProovedores[2, indice].Value = txtTelefono.Text;
                dgvProovedores[3, indice].Value = txtDescripcion.Text;
               

                cmd = new SqlCommand("UPDATE Proveedores SET nombre_proveedor = '" + txtNombreProovedor.Text + "',  numero_contacto = '" + txtTelefono.Text + "', direccion_proveedor = '" + txtDescripcion.Text + "'  where codigo_proveedor = " + codigo, conect.conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("El registro fue actualizado exitosamente");
                conect.cargarProveedores(dgvProovedores);
               
               
                txtNombreProovedor.Clear();
                txtTelefono.Clear();
                txtDescripcion.Clear();
                txtNombreProovedor.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("El registro no pudo ser actualizado" + ex, "INFO", MessageBoxButtons.OK);
            }
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            conect.abrir();
            conect.cargarProveedores(dgvProovedores);
            dgvProovedores.ForeColor = Color.Black;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int indice = dgvProovedores.CurrentRow.Index;
                int codigo = Convert.ToInt32(dgvProovedores[0, indice].Value);

                if (indice == -1)
                {
                    MessageBox.Show("Seleccione los datos que desea eliminar");
                }
                else
                {
                    cmd = new SqlCommand("DELETE FROM Proveedores Where codigo_proveedor = " + codigo, conect.conexion);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Se han eliminado los datos correctamente", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conect.cargarMetodosPago(dgvProovedores);
                    txtDescripcion.Clear();

                    indice = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar los datos" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombreProovedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreProovedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
    }

