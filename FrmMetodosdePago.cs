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
    public partial class FrmMetodosdePago : Form
    {
        public FrmMetodosdePago()
        {
            InitializeComponent();
        }

        ClsConexionBD conect = new ClsConexionBD();
        SqlCommand cmd;

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMenuCRUD cRUD = new FrmMenuCRUD();
            cRUD.Show();
            this.Hide();
        }

        private void FrmMetodosdePago_Load(object sender, EventArgs e)
        {
            conect.abrir();
            conect.cargarMetodosPago(dgvMetodosPago);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtDescripcion.Text == "")
                {
                    MessageBox.Show("No se pueden Insertar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd = new SqlCommand("INSERT INTO Metodo_Pago (descripcion_pago) VALUES ('"+txtDescripcion.Text+"')", conect.conexion);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Los Datos han sido insertados con Exitos", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conect.cargarMetodosPago(dgvMetodosPago);

                    txtDescripcion.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar los datos" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripcion.Clear();
            }
        }

        int poc;
        string codigo;

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                poc = dgvMetodosPago.CurrentRow.Index;
                codigo = dgvMetodosPago[0, poc].Value.ToString();

                if (poc == -1)
                {
                    MessageBox.Show("Seleccione los datos que desea eliminar");
                }
                else
                {
                    cmd = new SqlCommand("DELETE FROM Metodo_Pago Where codigo_pago = " + codigo , conect.conexion);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Se han eliminado los datos correctamente", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conect.cargarMetodosPago(dgvMetodosPago);
                    txtDescripcion.Clear();

                    poc = -1;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo eliminar los datos" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int codigo1;

        private void button3_Click(object sender, EventArgs e)
        {

            poc = dgvMetodosPago.CurrentRow.Index;
            
            try
            {
                if(txtDescripcion.Text=="")
                {
                    MessageBox.Show("Seleccione la descripción del método de Pago que desea modificar haciendo clic sobre la descripción que desea cambiar o modificar. Recuerde que Tampoco es permitido dejar sin descripción algún método de pago.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    codigo1 = Convert.ToInt32(dgvMetodosPago[0, poc].Value);
                    dgvMetodosPago[1, poc].Value = txtDescripcion.Text;
                      
                    cmd = new SqlCommand("UPDATE Metodo_Pago SET descripcion_pago = '" + txtDescripcion.Text +"' WHERE codigo_pago = "+codigo1, conect.conexion);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("El Registro fue actualizado exitosamente.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conect.cargarMetodosPago(dgvMetodosPago);
                    codigo1 = 0;
                    txtDescripcion.Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo modificar los datos" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMetodosPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = dgvMetodosPago.CurrentRow.Index;
            codigo = dgvMetodosPago[0, poc].Value.ToString();
            txtDescripcion.Text = dgvMetodosPago[1, poc].Value.ToString();
        }

        private void FrmMetodosdePago_Click(object sender, EventArgs e)
        {
            txtDescripcion.Clear();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripLabel1.Text = DateTime.Now.ToLongDateString();
            toolStripLabel2.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
