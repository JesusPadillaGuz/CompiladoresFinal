using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadLexico
{
   public class Token
    {
        public String lexema;
        public String idToken;
        public int linea;
        public int columna;
        public int indice;
        public Token(String lexema, String idToken, int linea, int columna, int indice)
        {

            this.lexema = lexema;
            this.idToken = idToken;
            this.linea = linea;
            this.columna = columna;
            this.indice = indice;
        }
        public Token()
        {
            idToken = "";
            lexema = "";
            linea = 0;
            columna = 0;
            indice = 0;
        }

        public Token(string value = "", string type = "", int l = 0, int c = 0)
        {
            idToken = type;
            lexema = value;
            linea = l;
            columna = c;
        }

        public int getIndice()
        {
            return this.indice;
        }
        public String getLexema()
        {
            return this.lexema;
        }
        public String getIdToken()
        {
            return this.idToken;
        }
        public int getLinea()
        {
            return this.linea;
        }
        public int getColumna()
        {
            return this.columna;
        }
    }
}
