using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    public class Artimetica
    {
        public int Sumar(int numero1, int numero2)
        {
            Console.WriteLine("Esta realizando la operación");
            return numero1 + numero2;
        }

        public DividirResponse Dividir(int numero1, int numero2)
        {
            if (numero2 == 0) return new DividirResponse(true, "Error Dvisión no válida.");
            float resultado = ((float)numero1 / (float)numero2);
            return new DividirResponse(resultado);
        }
    }

    public class DividirResponse {
        public DividirResponse(bool error = false, string mensajeError = "")
        {
            Error = error;
            MensajeError = mensajeError;
        }
        public DividirResponse(float resultado, bool error=false, string mensajeError="")
        {
            Resultado = resultado;
            Error = error;
            MensajeError = mensajeError;
        }

        public float Resultado { get; set; }
        public bool Error { get; set; }
        public string  MensajeError { get; set; }
    }
}
