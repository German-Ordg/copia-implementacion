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
            timer1.Enabled = true;
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

        ClsConexionBD connect = new ClsConexionBD();
        int Record_Id;
        private bool letra = false;
        private bool letra2 = false;

        public void MostrarDatos()
        {
            try
            {
                string consulta = "SELECT codigo_puesto as Código, descripcion_puesto as Puesto FROM Empleados_Puestos";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, connect.conexion);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                DgvPuesto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DgvPuesto.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Limpiar()
        {
            txtCodigo.Clear();
            txtPosicion.Clear();
            txtPosicion.Select();
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
            this.Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            letra2 = false;
            letra = false;

            if (validacion.Espacio_Blanco_CB(ErrorProvider, CBtipo))
            {
                if (validacion.Espacio_Blanco_CB(ErrorProvider, CBtipo))
                    ErrorProvider.SetError(CBtipo, "no se puede dejar en blanco");
            }
            else
            {
                letra2 = true;
            }

            if (letra2)
            {
                try
                {                    
                        string query = "INSERT INTO Empleados_Puestos (descripcion_puesto) VALUES (@puesto)";
                        connect.abrir();
                        SqlCommand comando = new SqlCommand(query, connect.conexion);
                        comando.Parameters.AddWithValue("@puesto", txtPosicion.Text);
                        comando.ExecuteNonQuery();
                        connect.abrir();
                        MessageBox.Show("Nuevo Puesto Insertado");
                        Limpiar();
                        MostrarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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
                Limpiar();
                MostrarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tslFecha.Text = DateTime.Now.ToLongDateString();
            tslHora.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
