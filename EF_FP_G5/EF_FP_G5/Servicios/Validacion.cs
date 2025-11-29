using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_FP_G5.Servicios
{
    public class Validacion
    {
        public static string ValidarDNI(string G5_DNIC)
        {
            if (G5_DNIC.Length == 8)
                return G5_DNIC;

            string G5_nuevo = Microsoft.VisualBasic.Interaction.InputBox(
                "DNI inválido. Ingrese un DNI válido de 8 dígitos:", "Validación de DNI");
            return ValidarDNI(G5_nuevo);
        }
        public static string ValidarCelular(string G5_celularC)
        {
            if (G5_celularC.Length == 9)
                return G5_celularC;

            string G5_nuevo1 = Microsoft.VisualBasic.Interaction.InputBox(
                "Celular inválido. Ingrese un número de celular válido de 9 dígitos:" +
                "", "Validación de Celular");
            return ValidarCelular(G5_nuevo1);
        }
    }
}
