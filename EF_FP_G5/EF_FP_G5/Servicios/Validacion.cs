using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_FP_G5.Servicios
{
    public class Validacion
    {
        public static string ValidarDNI(string G5_dni)
        {
            if (G5_dni.Length == 8)
                return G5_dni;

            string G5_nuevo = Microsoft.VisualBasic.Interaction.InputBox(
                "DNI inválido. Ingrese un DNI válido de 8 dígitos:", "Validación de DNI");
            return ValidarDNI(G5_nuevo);
        }
        public static string ValidarCelular(string G5_cel)
        {
            if (G5_cel.Length == 9)
                return G5_cel;

            string G5_nuevo1 = Microsoft.VisualBasic.Interaction.InputBox(
                "Celular inválido. Ingrese un número de celular válido de 9 dígitos:" +
                "", "Validación de Celular");
            return ValidarCelular(G5_nuevo1);
        }
    }
}
