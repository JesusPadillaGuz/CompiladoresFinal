using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AnalizadLexico;

namespace Compilador
{
    public partial class Form1 : Form
    {
        string archivoOp;
        static private List<Tokens> lis_toks;

        public Form1()
        {
            InitializeComponent();
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            archivoOp = null;
            //Form1.ActiveForm.Text = archivoOp + "Compilador";
        }

        private void abrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Texto|*.txt";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                archivoOp = openFile.FileName;


                using (StreamReader sr = new StreamReader(archivoOp))
                {
                    richTextBox1.Text = sr.ReadToEnd();
                }
                //Form1.ActiveForm.Text = archivoOp + " | Compilador";
                /*KeyPressEventArgs key = new KeyPressEventArgs(keyChar: (char)Keys.Space);
                key.KeyChar = (char)Keys.Space;*/
                richTextBox1_OpenAnalize(sender);
            }
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Texto|*.txt";
            

            if (archivoOp != null)
            {
                using(StreamWriter sw = new StreamWriter(archivoOp))
                {
                    sw.Write(richTextBox1.Text);
                }
            }
            else
            {
                saveFile.FileName = "Sin titulo";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    archivoOp = saveFile.FileName;
                    
                    using (StreamWriter sw = new StreamWriter(saveFile.FileName))
                    {
                        sw.Write(richTextBox1.Text);
                    }
                }
            }
        }

        private void guardarComo_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileAs = new SaveFileDialog();
            saveFileAs.Filter = "Texto|*.txt";
            string nombreActual = archivoOp;
            saveFileAs.FileName = Path.GetFileName(archivoOp);

            if (saveFileAs.ShowDialog() == DialogResult.OK)
            {
                
                using (StreamWriter sw = new StreamWriter(saveFileAs.FileName))
                {
                    sw.Write(richTextBox1.Text);
                }
            }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void atras_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void adelante_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void copiar_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void cortar_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pegar_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void seleccionarTodo_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void eliminarTodo_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void color_Click(object sender, EventArgs e)
        {
            var cl = colorDialog1.ShowDialog();
            if(cl == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }
        private void colorDelFondo_Click(object sender, EventArgs e)
        {
            ColorDialog cl2 = new ColorDialog();
            
            if (cl2.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = cl2.Color;
            }
        }

        private void fuente_Click(object sender, EventArgs e)
        {
            var frmt = fontDialog1.ShowDialog();
            if(frmt == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void compilar_Click(object sender, EventArgs e)
        {
            String texto;
            texto = richTextBox1.Text;
            AnalizadorLexico analiz = new AnalizadorLexico();
            analiz.Analizador_cadena(texto);
            analiz.Html_Errores();
            analiz.Html_Tokens();


            //Genera lista del análisis léxico
            analiz.generarLista();
            richTextBoxLexico.Text = analiz.getRetorno();

            //Genera lista de los errores
            analiz.generaListaErrores();
            richTextBoxErrores.Text = analiz.getRetornoErrores();


            lis_toks = new List<Tokens>();
            lis_toks = analiz.getListaTokens();

            for (int i = 0; i < lis_toks.Count; i++)
            {
                Tokens actual = lis_toks.ElementAt(i);
                //MessageBox.Show("[Lexema:" + actual.getLexema() + ",IdToken: " + actual.getIdToken() + ",Linea: " + actual.getLinea() + "]", "des");
            }
        }
        private void richTextBox1_OpenAnalize(object sender)
        {
            string comparar = "";
            int indice = 0;
           

                comparar = richTextBox1.Text;
                char[] arreglo = richTextBox1.Text.ToCharArray();
                for (int i = 0; i < richTextBox1.TextLength; i++)
                {
                    if (arreglo[i] == ' ')
                    {
                        indice = i;
                    comparar = null;
                        for (int j = indice; j < richTextBox1.Text.Length; j++)
                        {
                            comparar += arreglo[j];
                            if ((j + 1) < richTextBox1.Text.Length)
                            {
                                if (arreglo[j + 1] == ' ')
                                {
                                    break;
                                }
                            }
                        }
                           compararTextoalInicio(comparar, indice);
                    }
                }
                comparar = null;
                if (indice != 0)
                {
                    indice++;
                }
                for (int i = indice; i < richTextBox1.Text.Length; i++)
                {
                    comparar += arreglo[i];
                }

                compararTexto(comparar, indice);
            
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string comparar = "";
            int indice = 0;
            if (Convert.ToInt32(e.KeyChar) == Convert.ToInt32(Keys.Space))
            {

                comparar = richTextBox1.Text;
                char[] arreglo = richTextBox1.Text.ToCharArray();
                for (int i = 0; i < richTextBox1.TextLength; i++)
                {
                    if (arreglo[i] == ' ')
                    {
                        indice = i;
                    }
                }
                comparar = null;
                if (indice != 0)
                {
                    indice++;
                }
                for (int i = indice; i < richTextBox1.Text.Length; i++)
                {
                    comparar += arreglo[i];
                }
                
                compararTextoalInicio(comparar, indice);
            }
        }
        private void compararTexto(string comparar, int indice)
        {

            if (comparar == "if" || comparar == "else" || comparar == "for" || comparar == "foreach" || comparar == "break")
            {
                richTextBox1.Select(indice, richTextBox1.Text.Length);
                richTextBox1.SelectionColor = Color.Red;
                richTextBox1.SelectionStart = this.richTextBox1.Text.Length;
            }
            else if (comparar == "{" || comparar == "}")
            {
                richTextBox1.Select(indice, richTextBox1.Text.Length);
                richTextBox1.SelectionColor = Color.Gray;
                richTextBox1.SelectionStart = this.richTextBox1.Text.Length;
            }
            else if (comparar == "read" || comparar == "write" || comparar == "int" || comparar == "double" || comparar == "float" || comparar == "string" || comparar == "char" || comparar == "char[]")
            {
                richTextBox1.Select(indice, richTextBox1.Text.Length);
                richTextBox1.SelectionColor = Color.DarkBlue;
                richTextBox1.SelectionStart = this.richTextBox1.Text.Length;
            }
            else if (comparar == "program")
            {
                richTextBox1.Select(indice, richTextBox1.Text.Length);
                richTextBox1.SelectionColor = Color.Green;
                richTextBox1.SelectionStart = this.richTextBox1.Text.Length;
            }
            else
            {
                richTextBox1.Select(indice, richTextBox1.Text.Length);
                richTextBox1.SelectionColor = Color.Black;
                richTextBox1.SelectionStart = this.richTextBox1.Text.Length;
            }
        }

        private void compararTextoalInicio(string comparar, int indice)
        {
            char[] arreglo = comparar.ToCharArray();
            string palabra= null;
            foreach(var chars in arreglo)
            {
                if (chars == '\n' || chars == ';')
                {
                    break;
                }
                palabra += chars;
            }


            if (palabra == "if" || palabra == "else" || palabra=="for"|| palabra == "foreach" || palabra == "break")
            {
                richTextBox1.Select(indice, richTextBox1.Text.Length);
                richTextBox1.SelectionColor = Color.Red;
                richTextBox1.SelectionStart = this.richTextBox1.Text.Length;
            }
            else if (palabra == "{" || palabra == "}")
            {
                richTextBox1.Select(indice, richTextBox1.Text.Length);
                richTextBox1.SelectionColor = Color.Gray;
                richTextBox1.SelectionStart = this.richTextBox1.Text.Length;
            }
            else if (palabra == "read" || palabra == "write" || palabra == "int" || palabra == "double"|| palabra == "float" || palabra == "string" || palabra == "char" || palabra == "char[]")
            {
                richTextBox1.Select(indice, richTextBox1.Text.Length);
                richTextBox1.SelectionColor = Color.DarkBlue;
                richTextBox1.SelectionStart = this.richTextBox1.Text.Length;
            }
            else if (palabra == "program")
            {
                richTextBox1.Select(indice, richTextBox1.Text.Length);
                richTextBox1.SelectionColor = Color.Green;
                richTextBox1.SelectionStart = this.richTextBox1.Text.Length;
            }
            else
            {
                richTextBox1.Select(indice, richTextBox1.Text.Length);
                richTextBox1.SelectionColor = Color.Black;
                richTextBox1.SelectionStart = this.richTextBox1.Text.Length;
            }
            char[] cadena;
            if (palabra != null)
            {
                cadena = palabra.ToCharArray();
                foreach (var caracter in cadena)
                {
                    int indexToRemove = 0;
                    arreglo = arreglo.Where((source, index) => index != indexToRemove).ToArray();
                    indice++;
                }
                if (arreglo.Length > 0)
                {
                    palabra = null;
                    foreach (var arr in arreglo)
                    {
                        palabra += arr;
                    }
                    compararTextoalInicio(palabra, indice);
                }
                arreglo = null;
            }
            else
            {
                int indexToRemove = 0;
                arreglo = arreglo.Where((source, index) => index != indexToRemove).ToArray();
                indice++;
                if (arreglo.Length > 0)
                {
                    palabra = null;
                    foreach (var arr in arreglo)
                    {
                        palabra += arr;
                    }
                    compararTextoalInicio(palabra, indice);
                }
                arreglo = null;
            }

        }
    }
}
