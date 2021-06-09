using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadLexico
{
    public class ImprimirResultado
    {
        String expresion;
        double resultado;

        public ImprimirResultado(String expresion, double resultado)
        {

            this.expresion = expresion;
            this.resultado = resultado;

        }

        public String getExpresion()
        {
            return this.expresion;
        }

        public double getResultado()
        {
            return this.resultado;
        }
    }
}
