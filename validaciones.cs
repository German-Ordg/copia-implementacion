using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Pantallas_proyecto
{
    public partial class validaciones
    {
        //Aqui validamos la negacion al encontrarse espacios en Blanco
        public bool Espacio_Vacio(ErrorProvider ubicacionError, TextBox txt){

            bool Espacio_Vacio = true;
            foreach (char caracter in txt.Text)
            {
                if (!Char.IsWhiteSpace(caracter))
                {
                    Espacio_Vacio = false;
                    ubicacionError.SetError(txt, "");
                    break;
                }
                else {
                    Espacio_Vacio = true;
                }

                if (caracter.ToString() = null)
                {

                }
                else {
                    ubicacionError.SetError();
                }
            }
            return Espacio_Vacio;

        }
       


    }
}
