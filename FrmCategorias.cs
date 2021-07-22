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
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
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

        public void MostrarDatos() {
            try {
                string consulta = "SELECT codigo_categoria as Codigo, descripcion_categoria as Descripcion FROM Categoria_Producto";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, ConnectionState.conexion);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                DgvCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DgvCategoria.DataSource = tabla;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tslFecha.Text = DateTime.Now.ToLongDateString();
            tslHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            FrmMenuCRUD menuCRUD = new FrmMenuCRUD();
            menuCRUD.Show();
            this.Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try {
                
            }
            catch { }
        }

        private void DgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Record_Id = Convert.ToInt32(DgvCategoria.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtCodigo.Text = (DgvCategoria.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtPosicion.Text = (DgvCategoria.Rows[e.RowIndex].Cells[1].Value.ToString());
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
