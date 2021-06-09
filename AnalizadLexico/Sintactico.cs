using System.Collections.Generic;
using System;

using AnalizadLexico;

public class AnalizadorSintactico
{
    public static Token token = new Token("","",0,0,0);
    /*token_type = "";
            lexema = "";
            linea = 0;
            columna = 0;*/
    public static int contador = 0;

    public static List<Token> tokensito;
    public static List<Token> errores = new List<Token>();

    public static Node root;

    public static int errorLine = 0;

    public Dictionary<string, string> tokenExp = new Dictionary<string, string>()
    {
        {"<","menor" },
        {"<=","menor igual que" },
        {">","mayor que" },
        {">=","mayor o igual que" },
        {"==","doble igual" },
        {"!=","diferente" },
    };

    public AnalizadorSintactico(List<Token> tokens) => tokensito = tokens;

    public Node generateTree()
    {
        root = null;
        contador = 0;
        token = new Token();
        token = tokensito[contador];
        errores = new List<Token>();
        errorLine = 0;
        Node raiz = programa();
        return raiz;
    }

    public List<Token> getErrors()
    {
        return errores; 
    }

    private static void getToken()
    {
        if (contador < tokensito.Count - 1)
        {
            token = tokensito[++contador];
        }
        else
        {
            token.idToken = "fin";
            token.lexema = "EOF";
        }
    }
    public void error(Token c) {
        Console.WriteLine("Error de sintaxis "+ c.lexema + " en [" + c.linea.ToString() +","+ c.columna.ToString() + "]");
        Token aux = new Token();
        aux.lexema = "Error de sintaxis " + c.lexema + " en [" + c.linea.ToString() + "," + c.columna.ToString() + "]";
        aux.linea = c.linea;
        aux.columna = c.columna;
        aux.idToken = "ERROR";
        errores.Add(aux);
        
    }

    public bool match(Token expectedToken)
    {
        if (token == null)
        {
            error(expectedToken);
            return false;
        }
        else if (token.lexema.Equals(expectedToken.lexema))
        {
            getToken();
            return true;
        }
        else
        {
            errorLine = expectedToken.linea;
            error(expectedToken);
            return false;
        }
    }

    //programa → programa { lista-declaración lista-sentencias }
    public Node programa()
    {
        Node principal = new Node();

        principal.tokenType = "main"; //Para palabra reservada main
        principal.value = "main";

        match(new Token("main", "", token.linea, token.columna));
        match(new Token("{", "", token.linea, token.columna));

        //Leer lista de declaraciones
        principal.children.Add(declarations_list());

        //Leer lista de setencencias
        principal.children.Add(sentences_list());
        match(new Token("}", "", token.linea, token.columna));
        return principal;
    }

    //lista-declaración →[ declaración ;]
    public Node declarations_list()
    {
        Node decs = new Node();

        decs.value = "declaracion";
        decs.tokenType = "declaracion";

        while (token.lexema == "int" || token.lexema == "real" || token.lexema == "boolean")
        {

            Node lista = new Node();

            lista.value = token.lexema;
            lista.tokenType = token.lexema;
            string tipo = token.lexema;
            match(token);

            //Preguntar si es ID 
            Node temp = new Node(token);
            temp.atributoTipo = tipo;
            temp.tokenLine = token.linea;

            lista.children.Add(temp);
            match(token);

            Token before = new Token();

            while (token.lexema == "," && token.lexema != ";")
            {
                match(token);

                Node aux = new Node(token);
                aux.tokenLine = token.linea;
                lista.children.Add(aux);
                before = token;
                match(token);
            }
            if(token.lexema == ";")
            {
                match(new Token(";", "", token.linea, token.columna));
            }
            else
            {
                error(new Token(";", "", before.linea, before.columna + 1));
            }
            
            ///match(token);
            decs.children.Add(lista);
        }
        return decs;
    }

    public Node sentences_list()
    {
        Node sentences = new Node();

        sentences.value = "sentencias";
        sentences.tokenType = "sentencias";

        //sentences.children.add(sentence());
        while (token.lexema != "EOF" && token.lexema != "end" && token.lexema != "else" && token.lexema != "}" && token.lexema != "until")//Se genera una lista de sentencias hasta que se acaben los tokens
        {

            if (errorLine == token.linea)
            {
                match(token);
            }else
            {
                errorLine = 0;
                sentences.children.Add(sentence());
            }
        }
        return sentences;
    }

    public Node sentence()
    {
        Node s = new Node();

        //Definir tipo de sentencia, token, nombre o valor.

        switch (token.lexema)
        {
            case "if":
                s = ifPrueba();
                match(new Token(";", "", token.linea, token.columna));
                break;
            case "while":
                s = while_stmt();
                break;
            case "do":
                s = do_stmt();
                match(new Token(";", "", token.linea, token.columna));
                break;
            case "cin":
                s = read_stmt();
                match(new Token(";", "", token.linea, token.columna));
                break;
            case "cout":
                s = write_stmt();
                match(new Token(";", "", token.linea, token.columna));
                break;
            case "{":
                s = block();
                break;
            default: //Es o asignación o bloque
                if (token.idToken == "ID")//Una asignación
                {
                    Token aux = token;
                    match(token);

                    if(token.lexema == "++" || token.lexema == "--")
                    {
                        s.value = ":=";
                        s.children.Add(new Node(aux));

                        Node ope = new Node();
                        switch(token.lexema)
                        {
                            case "++":
                                ope.value = "+";
                                ope.tokenType = "simple suma";
                                ope.children.Add(new Node(aux));

                                Token plus = new Token();
                                plus.lexema = "1";
                                plus.idToken = "numero entero";
                                ope.children.Add(new Node(plus));
                                break;

                            case "--":
                                ope.value = "-";
                                ope.tokenType = "simple resta";
                                ope.children.Add(new Node(aux));

                                Token subs = new Token();
                                subs.lexema = "1";
                                subs.idToken = "numero entero";
                                ope.children.Add(new Node(subs));
                                break;
                        }
                        match(token);
                        s.children.Add(ope);

                        match(new Token(";", "", token.linea, token.columna));
                    }
                    else if(token.lexema == ":=")
                    {
                        s.tokenType = "asignacion";
                        s.children.Add(new Node(aux));
                        s.value = token.lexema;
                        match(new Token(":=", "", token.linea, token.columna));
                        s.children.Add(exp());
                        match(new Token(";", "", token.linea, token.columna));
                    }
                    else
                    {
                        error(new Token(token.lexema + " inesperado", "", token.linea, token.columna));
                        errorLine = token.linea;
                    }
                }
                else
                {
                    error(new Token(token.lexema + " inesperado", "", token.linea, token.columna));
                    getToken();

                }
               break;
        }
        return s;
    }

    public Node if_stmt()
    {
        Node conf = new Node();
        conf.tokenType = token.lexema;
        conf.value = token.lexema;
        match(new Token("if", "", token.linea, token.columna));
        
        match(new Token("(", "", token.linea, token.columna));
        conf.children.Add(exp());
        match(new Token(")", "", token.linea, token.columna));

        match(new Token("then", "", token.linea, token.columna));
        conf.children.Add(sentences_list());

        if (token.lexema == "else")
        {
            match(new Token("else", "", token.linea, token.columna));
            conf.children.Add(sentences_list());
        }

        match(new Token("end", "", token.linea, token.columna));
       
        return conf;
    }

    public Node ifPrueba()
    {
        Node conf = new Node();

        conf.value = "if";
        conf.tokenType = "if";

        match(new Token("if", "", token.linea, token.columna));

        conf.children.Add(if_condition());//if condition

        match(new Token("then", "", token.linea, token.columna));

        conf.children.Add(sentences_list());

        if(token.lexema == "else")
        {
            Node _else = new Node();
            _else.value = "else";

            match(new Token("else", "", token.linea, token.columna));
            
            _else.children.Add(sentences_list());

            conf.children.Add(_else);

        }

        match(new Token("end", "", token.linea, token.columna));
        return conf;
    }

    public Node if_condition()
    {
        Node then = new Node();

        while (true)
        {
            if (!match(new Token("(", "", token.linea, token.columna))) break;
            then = exp();
            if (!match(new Token(")", "", token.linea, token.columna))) break;
            break;
        }
        errorLine = 0;
        
        return then;
    }

    public Node while_stmt()
    {
        Node conf = new Node();
        conf.tokenType = token.lexema;
        conf.value = token.lexema;
        match(new Token("while", "", token.linea, token.columna));
        
        match(new Token("(", "", token.linea, token.columna));
        conf.children.Add(exp());
        match(new Token(")", "", token.linea, token.columna));

        conf.children.Add(block());
        
        return conf;
    }

    public Node do_stmt()
    {
        Node conf = new Node();

        conf.tokenType = token.lexema;
        conf.value = token.lexema;

        match(new Token("do", "", token.linea, token.columna));

        conf.children.Add(sentences_list());

        //Ajuste para un padre until antes de la condición
        Node until = new Node();
        until.value = "until";
        until.tokenLine = token.linea;
        until.tokenType = "until";

        match(new Token("until", "", token.linea, token.columna));
        match(new Token("(", "", token.linea, token.columna));

        until.children.Add(exp());

        conf.children.Add(until);
        match(new Token(")", "", token.linea, token.columna));

        return conf;
    }

    public Node block()//Tal vez ocupe condiciones como el del if
    {
        Node conf = new Node();
        conf.tokenType = "Bloque";
        conf.value = "Bloque";

        match(new Token("{", "", token.linea, token.columna));
        conf.children.Add(sentences_list());
        match(new Token("}", "", token.linea, token.columna));

        return conf;
    }

    public Node read_stmt()
    {
        Node conf = new Node();

        conf.tokenType = token.lexema;
        conf.value = token.lexema;

        match(new Token("cin", "", token.linea, token.columna));
        if (token.idToken == "ID")
        {
            conf.children.Add(new Node(token));
            match(token);
        }

        return conf;
    }

    public Node write_stmt()
    {
        Node conf = new Node();

        conf.tokenType = token.lexema;
        conf.value = token.lexema;

        match(new Token("cout", "", token.linea, token.columna));
        conf.children.Add(exp());

        return conf;
    }

    public Node exp()
    {
        Node temp = new Node();
        temp = expSimple();
        //exp->term {ops term}
        //ops ->+|-

        //temp.tokenType = "expresion";

        while ((token.lexema == "<=") || (token.lexema == ">") || (token.lexema == "<") || 
               (token.lexema == "!=") || (token.lexema == ">=") || (token.lexema == "==") && 
               token.lexema != "EOF" && errorLine != token.linea
        ){
            Node nuevo = new Node();

            nuevo.value = token.lexema;
            nuevo.tokenType = token.idToken;

            nuevo.children.Add(temp);

            match(token);
            nuevo.children.Add(expSimple());
            nuevo.tokenType = nuevo.value; //cambio de nuevo.tokenType = "expSimple";

            temp = nuevo;
        }

        return temp;
    }

    public Node expSimple()
    {
        Node temp = new Node();
        temp = term();
        //exp->term {ops term}
        //ops ->+|-

        while ((token.lexema == "+") || (token.lexema == "-") && token.lexema != "EOF" && errorLine != token.linea)
        {
            Node nuevo = new Node();

            nuevo.tokenType = token.idToken;
            nuevo.value = token.lexema;
            
            nuevo.children.Add(temp);

            match(token);

            nuevo.children.Add(term());
            temp = nuevo;
        }


        return temp;
    }
    public Node term()
    {
        Node temp = new Node();
        temp = factor();
        /*term->factor {opm factor}
        opm-> * | / | %*/
        // int temp = factor();
        while (token.lexema == "*" || token.lexema == "/" || token.lexema == "%" && token.lexema != "EOF" && errorLine != token.linea)
        {
            Node nuevo = new Node();

            nuevo.tokenType = token.idToken;
            nuevo.value = token.lexema;
            nuevo.children.Add(temp);

            match(token);
            nuevo.children.Add(factor());
            temp = nuevo;

        }
        return temp;
    }

    public Node factor()
    {
        Node temp = new Node();
        temp = fin();
        /*factor-> fin {opp fin}
        opp-> ^*/
        while (token.lexema == "^" && token.lexema != "EOF" && errorLine != token.linea)
        {
            Node nuevo = new Node();

            nuevo.tokenType = token.idToken;
            nuevo.value = token.lexema;
            nuevo.children.Add(temp);

            match(token);
            
            nuevo.children.Add(fin());
            temp = nuevo;
        }
        return temp;
    }
    public Node fin()
    {
        //factor->(exp)|numero
        //Console.WriteLine(token);
        Node temp = new Node();
        double y;

        if (token.lexema == "(")
        {
            match(new Token("(", "", token.linea, token.columna));
            temp = exp();
            match(new Token(")", "", token.linea, token.columna));

        }
        else if (double.TryParse(token.lexema, out y))
        {
            temp.tokenType = token.idToken;
            temp.value = token.lexema;
            temp.tokenLine = token.linea;
            match(token);

        }
        else if (token.idToken == "ID")
        {
            temp.value = token.lexema;
            temp.tokenType = "Identificador";
            temp.tokenLine = token.linea;
            match(token);
        }
        else {
            errorLine = token.linea;
            error(token); 
        }//unexpected token

        return temp;
    }
}