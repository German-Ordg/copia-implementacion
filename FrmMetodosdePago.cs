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
                if(txtDescripcion.Text == " ")
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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dgvMetodosPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = dgvMetodosPago.CurrentRow.Index;
            codigo = dgvMetodosPago[0, poc].Value.ToString();
            txtDescripcion.Text = dgvMetodosPago[1, poc].Value.ToString();
        }
    }
}
