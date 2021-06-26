using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pantallas_proyecto
{
    public partial class frmPuestosTrabajo : Form
    {
        public frmPuestosTrabajo()
        {
            InitializeComponent();
        }

        ClsConexionBD connect = new ClsConexionBD();
        int Record_Id;

        public void MostrarDatos()
        {
            string consulta = "SELECT codigo_puesto as Código, descripcion_puesto as Puesto FROM Empleados_Puestos";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, connect.conexion);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);

            DgvPuesto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPuesto.DataSource = tabla;
        }

        private void frmPuestosTrabajo_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void DgvPuesto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Record_Id = Convert.ToInt32(DgvPuesto.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtCodigo.Text = (DgvPuesto.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtPosicion.Text = (DgvPuesto.Rows[e.RowIndex].Cells[1].Value.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmMenuCRUD cRUD = new FrmMenuCRUD();
            cRUD.Show();
            cRUD.Hide();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Empleados_Puestos (descripcion_puesto) VALUES (@puesto)";
            connect.abrir();
            SqlCommand comando = new SqlCommand(query, connect.conexion);
            comando.Parameters.AddWithValue("@puesto", txtPosicion.Text);
            comando.ExecuteNonQuery();
            connect.abrir();
            MessageBox.Show("Nuevo Puesto Insertado");
            txtCodigo.Clear();
            txtPosicion.Clear();
            MostrarDatos();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Update Empleados_Puestos set descripcion_puesto= '" + txtPosicion.Text + "' where codigo_puesto='" + Record_Id + "'";
                connect.abrir();
                SqlCommand comando = new SqlCommand(query, connect.conexion);
                comando.ExecuteNonQuery();
                connect.abrir();
                MessageBox.Show("Se Modificó Correctamente");
                txtCodigo.Clear();
                txtPosicion.Clear();
                MostrarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string query = "Delete from Empleados_Puestos WHERE codigo_puesto=@ID";
            connect.abrir();
            SqlCommand comando = new SqlCommand(query, connect.conexion);
            comando.Parameters.AddWithValue("@ID", txtCodigo.Text);
            comando.ExecuteNonQuery();
            connect.cerrar();
            MessageBox.Show("Puesto de Trabajo Eliminado");
            txtCodigo.Clear();
            txtPosicion.Clear();
            MostrarDatos();
        }
    }
}
