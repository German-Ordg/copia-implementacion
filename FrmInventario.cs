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
using System.Data.Sql;

namespace Pantallas_proyecto
{
    public partial class FrmInventario : Form
    {
        private bool numero1 = false;
        
        public FrmInventario()
        {
            InitializeComponent();
        }
        ClsConexionBD conect = new ClsConexionBD();
        SqlCommand cmd;
        validaciones validacion = new validaciones();

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

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal menu = new FrmMenuPrincipal();
            menu.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int poc;

            poc = dataGridView1.CurrentRow.Index;

            textBox1.Text = dataGridView1[0, poc].Value.ToString();
            textBox2.Text = dataGridView1[1, poc].Value.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripLabel1.Text = DateTime.Now.ToLongDateString();
            toolStripLabel2.Text = DateTime.Now.ToLongTimeString();
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            conect.cargarDatosProductos(dataGridView1);
            timer1.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            {
                if (validacion.Espacio_Blanco(ErrorProvider, textBox1) || validacion.Solo_Numeros(ErrorProvider, textBox1))
                {
                    if (validacion.Espacio_Blanco(ErrorProvider, textBox1)) ;
                    //ErrorProvider.SetError(textBox1, "no se puede dejar en blanco");
                    else
                    if (validacion.Solo_Letras(ErrorProvider, textBox1))
                        ErrorProvider.SetError(textBox1, "Solo se permite numeros");
                }
                else
                {
                    numero1 = true;
                }
                var aux = new MetodoBuscarCodigo();
                aux.filtrar1(dataGridView1, this.textBox1.Text.Trim());
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            {
                if (validacion.Espacio_Blanco(ErrorProvider, textBox2) || validacion.Solo_Numeros(ErrorProvider, textBox2))
                {
                    if (validacion.Espacio_Blanco(ErrorProvider, textBox2)) ;
                    //ErrorProvider.SetError(textBox1, "no se puede dejar en blanco");
                    else
                    if (validacion.Solo_Letras(ErrorProvider, textBox2))
                        ErrorProvider.SetError(textBox2, "Solo se permite numeros");
                }
                else
                {
                    numero1 = true;
                    
                }

                var aux = new MetodoBucasrProducto();
                aux.filtrar(dataGridView1, this.textBox2.Text.Trim());
            }
        }
    }
}
