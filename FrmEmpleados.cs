﻿using System;
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

        private bool letra1 = false;
        private bool letra2 = false;
        private bool letra3 = false;
        private bool letra4 = false;
        private bool letra5 = false;
        private bool numero1 = false;
        private bool numero2 = false;
        private bool numero3 = false;
        private bool numero4 = false;
        private bool numero5 = false;
        public FrmEmpleados()
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
        validaciones validacion = new validaciones();

        
           
        

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

            letra1 = false; letra2 = false; letra3 = false; letra4 = false; letra5 = false;
            numero1 = false; numero2 = false; numero3 = false; numero4 = false;

            if (validacion.Espacio_Blanco(ErrorProvider1, txtNombre) || validacion.Solo_Letras(ErrorProvider1, txtNombre))
            {
                if (validacion.Espacio_Blanco(ErrorProvider1, txtNombre))
                    ErrorProvider1.SetError(txtNombre, "no se puede dejar en blanco");
                else
                if (validacion.Solo_Letras(ErrorProvider1, txtNombre))
                    ErrorProvider1.SetError(txtNombre, "Solo se permite letras");
            }
            else
            {
                letra1 = true;
            }

            if (validacion.Espacio_Blanco(ErrorProvider1, txtApellido) || validacion.Solo_Letras(ErrorProvider1, txtApellido))
            {
                if (validacion.Espacio_Blanco(ErrorProvider1, txtApellido))
                    ErrorProvider1.SetError(txtApellido, "no se puede dejar en blanco");
                else
                if (validacion.Solo_Letras(ErrorProvider1, txtApellido))
                    ErrorProvider1.SetError(txtApellido, "Solo se permite letras");
            }
            else
            {
                letra2 = true;
            }

            if (validacion.Espacio_Blanco(ErrorProvider1, txtIdentidad) || validacion.Solo_Numeros(ErrorProvider1, txtIdentidad))
            {
                if (validacion.Espacio_Blanco(ErrorProvider1, txtIdentidad))
                    ErrorProvider1.SetError(txtIdentidad, "no se puede dejar en blanco");
                else
                if (validacion.Solo_Numeros(ErrorProvider1, txtIdentidad))
                    ErrorProvider1.SetError(txtIdentidad, "Solo se permite numeros");
            }
            else
            {
                if (txtIdentidad.Text.Length != 13)
                {
                    MessageBox.Show("Ingrese 13 digitos en su identidad", "Falta de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Focus();
                }
                else
                {
                    numero1 = true;
                }


                if (validacion.Espacio_Blanco(ErrorProvider1, txtNumeroTel) || validacion.Solo_Numeros(ErrorProvider1, txtNumeroTel))
                {
                    if (validacion.Espacio_Blanco(ErrorProvider1, txtNumeroTel))
                        ErrorProvider1.SetError(txtNumeroTel, "No se puede dejar en blanco");
                    else
                    if (validacion.Solo_Numeros(ErrorProvider1, txtNumeroTel))
                        ErrorProvider1.SetError(txtNumeroTel, "Solo se permite numeros");
                }

                if (txtNumeroTel.Text.Length != 8)
                {
                    MessageBox.Show("Ingrese 8 digitos en el telefono del empleado", "Falta de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNumeroTel.Focus();

                }
                else
                {
                    numero2 = true;
                }

                if (numero1 && letra1 && letra2 && numero2)
                {

                    try
                    {

                        cmd = new SqlCommand("Insert into Empleados(codigo_puesto, nombre_empleado, apellido_empleado, numero_identidad_empleado, fecha_nacimiento, fecha_ingreso, num_telefono, Genero) Values(" + txtPuesto.Text + ",'" + txtNombre.Text + "', '" + txtApellido.Text + "', '" + txtIdentidad.Text + "', '" + dtpFechaNacimiento.Text + "','" + dtpFechaIngreso.Text + "','" + txtNumeroTel.Text + "','" + cmbGenero.Text + "')", conect.conexion);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Se han ingresado los Datos con Exito ", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conect.cargarDatosEmpleados(dgvEmpleados);

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripLabel1.Text = DateTime.Now.ToLongDateString();
            toolStripLabel2.Text = DateTime.Now.ToLongTimeString();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            
        }

       /* private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras se permiten", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras se permiten", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtIdentidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros se permiten", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros se permiten", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNumeroTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros se permiten", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }*/
    }
    }

