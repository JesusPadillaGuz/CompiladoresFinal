using System.Windows.Forms;

namespace Compilador
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.abrir = new System.Windows.Forms.ToolStripMenuItem();
            this.guardar = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.editar = new System.Windows.Forms.ToolStripMenuItem();
            this.atras = new System.Windows.Forms.ToolStripMenuItem();
            this.adelante = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copiar = new System.Windows.Forms.ToolStripMenuItem();
            this.cortar = new System.Windows.Forms.ToolStripMenuItem();
            this.pegar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.seleccionarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.formato = new System.Windows.Forms.ToolStripMenuItem();
            this.color = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDelFondo = new System.Windows.Forms.ToolStripMenuItem();
            this.fuente = new System.Windows.Forms.ToolStripMenuItem();
            this.compilar = new System.Windows.Forms.ToolStripMenuItem();
            this.ayuda = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBoxLexico = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBoxSintactico = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBoxSemantico = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.richTextBoxIntermedio = new System.Windows.Forms.RichTextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.richTextBoxErrores = new System.Windows.Forms.RichTextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.richTextBoxRes = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivo,
            this.editar,
            this.formato,
            this.compilar,
            this.ayuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1059, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivo
            // 
            this.archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevo,
            this.abrir,
            this.guardar,
            this.guardarComo,
            this.toolStripSeparator3,
            this.cerrar});
            this.archivo.Name = "archivo";
            this.archivo.Size = new System.Drawing.Size(73, 24);
            this.archivo.Text = "Archivo";
            this.archivo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // nuevo
            // 
            this.nuevo.Name = "nuevo";
            this.nuevo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevo.Size = new System.Drawing.Size(239, 26);
            this.nuevo.Text = "Nuevo";
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // abrir
            // 
            this.abrir.Name = "abrir";
            this.abrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.abrir.Size = new System.Drawing.Size(239, 26);
            this.abrir.Text = "Abrir";
            this.abrir.Click += new System.EventHandler(this.abrir_Click);
            // 
            // guardar
            // 
            this.guardar.Name = "guardar";
            this.guardar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.guardar.Size = new System.Drawing.Size(239, 26);
            this.guardar.Text = "Guardar";
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // guardarComo
            // 
            this.guardarComo.Name = "guardarComo";
            this.guardarComo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.guardarComo.Size = new System.Drawing.Size(239, 26);
            this.guardarComo.Text = "Guardar como";
            this.guardarComo.Click += new System.EventHandler(this.guardarComo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(236, 6);
            // 
            // cerrar
            // 
            this.cerrar.Name = "cerrar";
            this.cerrar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.cerrar.Size = new System.Drawing.Size(239, 26);
            this.cerrar.Text = "Salir";
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // editar
            // 
            this.editar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atras,
            this.adelante,
            this.toolStripSeparator1,
            this.copiar,
            this.cortar,
            this.pegar,
            this.toolStripSeparator2,
            this.seleccionarTodo,
            this.eliminarTodo});
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(62, 24);
            this.editar.Text = "Editar";
            // 
            // atras
            // 
            this.atras.Name = "atras";
            this.atras.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.atras.Size = new System.Drawing.Size(264, 26);
            this.atras.Text = "Atrás ";
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // adelante
            // 
            this.adelante.Name = "adelante";
            this.adelante.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.adelante.Size = new System.Drawing.Size(264, 26);
            this.adelante.Text = "Adelante";
            this.adelante.Click += new System.EventHandler(this.adelante_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(261, 6);
            // 
            // copiar
            // 
            this.copiar.Name = "copiar";
            this.copiar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiar.Size = new System.Drawing.Size(264, 26);
            this.copiar.Text = "Copiar";
            this.copiar.Click += new System.EventHandler(this.copiar_Click);
            // 
            // cortar
            // 
            this.cortar.Name = "cortar";
            this.cortar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cortar.Size = new System.Drawing.Size(264, 26);
            this.cortar.Text = "Cortar";
            this.cortar.Click += new System.EventHandler(this.cortar_Click);
            // 
            // pegar
            // 
            this.pegar.Name = "pegar";
            this.pegar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pegar.Size = new System.Drawing.Size(264, 26);
            this.pegar.Text = "Pegar";
            this.pegar.Click += new System.EventHandler(this.pegar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(261, 6);
            // 
            // seleccionarTodo
            // 
            this.seleccionarTodo.Name = "seleccionarTodo";
            this.seleccionarTodo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.seleccionarTodo.Size = new System.Drawing.Size(264, 26);
            this.seleccionarTodo.Text = "Seleccionar Todo";
            this.seleccionarTodo.Click += new System.EventHandler(this.seleccionarTodo_Click);
            // 
            // eliminarTodo
            // 
            this.eliminarTodo.Name = "eliminarTodo";
            this.eliminarTodo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.X)));
            this.eliminarTodo.Size = new System.Drawing.Size(264, 26);
            this.eliminarTodo.Text = "Eliminar Todo";
            this.eliminarTodo.Click += new System.EventHandler(this.eliminarTodo_Click);
            // 
            // formato
            // 
            this.formato.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.color,
            this.colorDelFondo,
            this.fuente});
            this.formato.Name = "formato";
            this.formato.Size = new System.Drawing.Size(79, 24);
            this.formato.Text = "Formato";
            // 
            // color
            // 
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(199, 26);
            this.color.Text = "Color del Texto";
            this.color.Click += new System.EventHandler(this.color_Click);
            // 
            // colorDelFondo
            // 
            this.colorDelFondo.Name = "colorDelFondo";
            this.colorDelFondo.Size = new System.Drawing.Size(199, 26);
            this.colorDelFondo.Text = "Color del Fondo";
            this.colorDelFondo.Click += new System.EventHandler(this.colorDelFondo_Click);
            // 
            // fuente
            // 
            this.fuente.Name = "fuente";
            this.fuente.Size = new System.Drawing.Size(199, 26);
            this.fuente.Text = "Fuente";
            this.fuente.Click += new System.EventHandler(this.fuente_Click);
            // 
            // compilar
            // 
            this.compilar.Name = "compilar";
            this.compilar.Size = new System.Drawing.Size(84, 24);
            this.compilar.Text = "Compilar";
            this.compilar.Click += new System.EventHandler(this.compilar_Click);
            // 
            // ayuda
            // 
            this.ayuda.Name = "ayuda";
            this.ayuda.Size = new System.Drawing.Size(65, 24);
            this.ayuda.Text = "Ayuda";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 47);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(636, 358);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.KeyPress += new KeyPressEventHandler(richTextBox1_KeyPress);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(680, 47);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(361, 359);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBoxLexico);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(353, 330);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lexico";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBoxLexico
            // 
            this.richTextBoxLexico.Location = new System.Drawing.Point(0, 4);
            this.richTextBoxLexico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBoxLexico.Name = "richTextBoxLexico";
            this.richTextBoxLexico.Size = new System.Drawing.Size(345, 319);
            this.richTextBoxLexico.TabIndex = 0;
            this.richTextBoxLexico.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBoxSintactico);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(353, 330);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sintactico";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBoxSintactico
            // 
            this.richTextBoxSintactico.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxSintactico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBoxSintactico.Name = "richTextBoxSintactico";
            this.richTextBoxSintactico.Size = new System.Drawing.Size(345, 326);
            this.richTextBoxSintactico.TabIndex = 0;
            this.richTextBoxSintactico.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.richTextBoxSemantico);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(353, 330);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Semantico";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBoxSemantico
            // 
            this.richTextBoxSemantico.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxSemantico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBoxSemantico.Name = "richTextBoxSemantico";
            this.richTextBoxSemantico.Size = new System.Drawing.Size(344, 326);
            this.richTextBoxSemantico.TabIndex = 0;
            this.richTextBoxSemantico.Text = "";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.richTextBoxIntermedio);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Size = new System.Drawing.Size(353, 330);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Codigo Intermedio";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // richTextBoxIntermedio
            // 
            this.richTextBoxIntermedio.Location = new System.Drawing.Point(0, 4);
            this.richTextBoxIntermedio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBoxIntermedio.Name = "richTextBoxIntermedio";
            this.richTextBoxIntermedio.Size = new System.Drawing.Size(345, 319);
            this.richTextBoxIntermedio.TabIndex = 0;
            this.richTextBoxIntermedio.Text = "";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Location = new System.Drawing.Point(16, 414);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1020, 145);
            this.tabControl2.TabIndex = 3;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.richTextBoxErrores);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage5.Size = new System.Drawing.Size(1012, 116);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Errores";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // richTextBoxErrores
            // 
            this.richTextBoxErrores.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxErrores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBoxErrores.Name = "richTextBoxErrores";
            this.richTextBoxErrores.Size = new System.Drawing.Size(1008, 109);
            this.richTextBoxErrores.TabIndex = 0;
            this.richTextBoxErrores.Text = "";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.richTextBoxRes);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage6.Size = new System.Drawing.Size(1012, 116);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Resultados";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // richTextBoxRes
            // 
            this.richTextBoxRes.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxRes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBoxRes.Name = "richTextBoxRes";
            this.richTextBoxRes.Size = new System.Drawing.Size(1004, 109);
            this.richTextBoxRes.TabIndex = 0;
            this.richTextBoxRes.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 574);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Compilador";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivo;
        private System.Windows.Forms.ToolStripMenuItem nuevo;
        private System.Windows.Forms.ToolStripMenuItem abrir;
        private System.Windows.Forms.ToolStripMenuItem cerrar;
        private System.Windows.Forms.ToolStripMenuItem guardar;
        private System.Windows.Forms.ToolStripMenuItem guardarComo;
        private System.Windows.Forms.ToolStripMenuItem editar;
        private System.Windows.Forms.ToolStripMenuItem atras;
        private System.Windows.Forms.ToolStripMenuItem adelante;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem copiar;
        private System.Windows.Forms.ToolStripMenuItem cortar;
        private System.Windows.Forms.ToolStripMenuItem pegar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem seleccionarTodo;
        private System.Windows.Forms.ToolStripMenuItem eliminarTodo;
        private System.Windows.Forms.ToolStripMenuItem formato;
        private System.Windows.Forms.ToolStripMenuItem compilar;
        private System.Windows.Forms.ToolStripMenuItem ayuda;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem color;
        private System.Windows.Forms.ToolStripMenuItem fuente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem colorDelFondo;
        private System.Windows.Forms.RichTextBox richTextBoxLexico;
        private System.Windows.Forms.RichTextBox richTextBoxErrores;
        private System.Windows.Forms.RichTextBox richTextBoxSintactico;
        private System.Windows.Forms.RichTextBox richTextBoxSemantico;
        private System.Windows.Forms.RichTextBox richTextBoxIntermedio;
        private System.Windows.Forms.RichTextBox richTextBoxRes;
    }
}

