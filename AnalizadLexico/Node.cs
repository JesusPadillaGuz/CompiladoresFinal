using System;
using System.Collections.Generic;
using System.Text;

namespace AnalizadLexico
{
    public class Node
    {
        public List<Node> children = new List<Node>();

        public int tokenLine;
        public int tokenColumn;

        public string tokenType;
        public string value;

        public string atributoTipo;
        public double atributoValor;

        public Node() { }

        public Node(Token tok)
        {
            this.tokenType = tok.idToken;
            this.value = tok.lexema;
            this.tokenLine = tok.linea;
        }
    }
}
