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

        public static Boolean ValidarFormulario(Control Objeto, ErrorProvider ErrorProvider) {
            
            Boolean HayErrores = false; //variable booleana 

            foreach  (Control Item in Objeto.Controls) //creamos un foreach para comprobar los if
            {
                if (Item is ErrorTxtBox) //errortxtbox  es el item que validamos los textbox
                {
                    ErrorTxtBox Obj = (ErrorTxtBox)Item;
                    if (Obj.Validar == true)
                    {
                        if (string.IsNullOrEmpty(Obj.Text.Trim()))
                        {
                            ErrorProvider.SetError(Obj, "Necesita llenar todos los elementos");
                            HayErrores = true;
                        }
                    }
                    else {
                        ErrorProvider.SetError(Obj, "");
                    }
                }
            }
            return HayErrores;
        }

        /*Validaciones Numeros
         * public static Boolean ValidarNumeros(Control Objeto, ErrorProvider ErrorProvider){
         *  
         * }
         * 
         */
    }
}
