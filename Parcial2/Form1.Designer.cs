
namespace Parcial2
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
            this.button1Abrir = new System.Windows.Forms.Button();
            this.IngresarDoc = new System.Windows.Forms.ListBox();
            this.ListaordenAlumnos = new System.Windows.Forms.ListBox();
            this.btnOrdenNombre = new System.Windows.Forms.Button();
            this.btnOrdenP1 = new System.Windows.Forms.Button();
            this.btnOrdenP2 = new System.Windows.Forms.Button();
            this.btnOrdenP3 = new System.Windows.Forms.Button();
            this.prompar1 = new System.Windows.Forms.Button();
            this.btnPromedioP3 = new System.Windows.Forms.Button();
            this.btnPromedioP2 = new System.Windows.Forms.Button();
            this.btnPromediosSeccion = new System.Windows.Forms.Button();
            this.SEleccion = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.PromedioporParcial = new System.Windows.Forms.ListBox();
            this.PromediGeneralPorSeccion = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1Abrir
            // 
            this.button1Abrir.Location = new System.Drawing.Point(7, 12);
            this.button1Abrir.Name = "button1Abrir";
            this.button1Abrir.Size = new System.Drawing.Size(75, 23);
            this.button1Abrir.TabIndex = 0;
            this.button1Abrir.Text = "AbrirDoc";
            this.button1Abrir.UseVisualStyleBackColor = true;
            this.button1Abrir.Click += new System.EventHandler(this.button1_Click);
            // 
            // IngresarDoc
            // 
            this.IngresarDoc.FormattingEnabled = true;
            this.IngresarDoc.Location = new System.Drawing.Point(88, 12);
            this.IngresarDoc.Name = "IngresarDoc";
            this.IngresarDoc.ScrollAlwaysVisible = true;
            this.IngresarDoc.Size = new System.Drawing.Size(335, 147);
            this.IngresarDoc.TabIndex = 2;
            // 
            // ListaordenAlumnos
            // 
            this.ListaordenAlumnos.FormattingEnabled = true;
            this.ListaordenAlumnos.Location = new System.Drawing.Point(552, 12);
            this.ListaordenAlumnos.Name = "ListaordenAlumnos";
            this.ListaordenAlumnos.ScrollAlwaysVisible = true;
            this.ListaordenAlumnos.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListaordenAlumnos.Size = new System.Drawing.Size(386, 160);
            this.ListaordenAlumnos.TabIndex = 3;
            // 
            // btnOrdenNombre
            // 
            this.btnOrdenNombre.Location = new System.Drawing.Point(461, 5);
            this.btnOrdenNombre.Name = "btnOrdenNombre";
            this.btnOrdenNombre.Size = new System.Drawing.Size(70, 37);
            this.btnOrdenNombre.TabIndex = 4;
            this.btnOrdenNombre.Text = "OrdenarporNombre";
            this.btnOrdenNombre.UseVisualStyleBackColor = true;
            this.btnOrdenNombre.Click += new System.EventHandler(this.btnOrdenNombre_Click);
            // 
            // btnOrdenP1
            // 
            this.btnOrdenP1.Location = new System.Drawing.Point(447, 48);
            this.btnOrdenP1.Name = "btnOrdenP1";
            this.btnOrdenP1.Size = new System.Drawing.Size(84, 23);
            this.btnOrdenP1.TabIndex = 13;
            this.btnOrdenP1.Text = "ordenPar1";
            this.btnOrdenP1.UseVisualStyleBackColor = true;
            this.btnOrdenP1.Click += new System.EventHandler(this.btnOrdenP1_Click);
            // 
            // btnOrdenP2
            // 
            this.btnOrdenP2.Location = new System.Drawing.Point(447, 77);
            this.btnOrdenP2.Name = "btnOrdenP2";
            this.btnOrdenP2.Size = new System.Drawing.Size(84, 23);
            this.btnOrdenP2.TabIndex = 14;
            this.btnOrdenP2.Text = "ordenpar2";
            this.btnOrdenP2.UseVisualStyleBackColor = true;
            this.btnOrdenP2.Click += new System.EventHandler(this.btnOrdenP2_Click);
            // 
            // btnOrdenP3
            // 
            this.btnOrdenP3.Location = new System.Drawing.Point(447, 106);
            this.btnOrdenP3.Name = "btnOrdenP3";
            this.btnOrdenP3.Size = new System.Drawing.Size(84, 23);
            this.btnOrdenP3.TabIndex = 15;
            this.btnOrdenP3.Text = "ordenpar3";
            this.btnOrdenP3.UseVisualStyleBackColor = true;
            this.btnOrdenP3.Click += new System.EventHandler(this.btnOrdenP3_Click);
            // 
            // prompar1
            // 
            this.prompar1.Location = new System.Drawing.Point(14, 206);
            this.prompar1.Name = "prompar1";
            this.prompar1.Size = new System.Drawing.Size(72, 23);
            this.prompar1.TabIndex = 17;
            this.prompar1.Text = "Prompar1";
            this.prompar1.UseVisualStyleBackColor = true;
            this.prompar1.Click += new System.EventHandler(this.btnPromedioP1_Click);
            // 
            // btnPromedioP3
            // 
            this.btnPromedioP3.Location = new System.Drawing.Point(12, 290);
            this.btnPromedioP3.Name = "btnPromedioP3";
            this.btnPromedioP3.Size = new System.Drawing.Size(70, 23);
            this.btnPromedioP3.TabIndex = 18;
            this.btnPromedioP3.Text = "Prompar3";
            this.btnPromedioP3.UseVisualStyleBackColor = true;
            this.btnPromedioP3.Click += new System.EventHandler(this.btnPromedioP3_Click);
            // 
            // btnPromedioP2
            // 
            this.btnPromedioP2.Location = new System.Drawing.Point(12, 244);
            this.btnPromedioP2.Name = "btnPromedioP2";
            this.btnPromedioP2.Size = new System.Drawing.Size(75, 23);
            this.btnPromedioP2.TabIndex = 19;
            this.btnPromedioP2.Text = "Prompa2";
            this.btnPromedioP2.UseVisualStyleBackColor = true;
            this.btnPromedioP2.Click += new System.EventHandler(this.btnPromedioP2_Click);
            // 
            // btnPromediosSeccion
            // 
            this.btnPromediosSeccion.Location = new System.Drawing.Point(461, 212);
            this.btnPromediosSeccion.Name = "btnPromediosSeccion";
            this.btnPromediosSeccion.Size = new System.Drawing.Size(84, 23);
            this.btnPromediosSeccion.TabIndex = 22;
            this.btnPromediosSeccion.Text = "promedioGeneral";
            this.btnPromediosSeccion.UseVisualStyleBackColor = true;
            this.btnPromediosSeccion.Click += new System.EventHandler(this.btnPromediosSeccion_Click);
            // 
            // SEleccion
            // 
            this.SEleccion.Location = new System.Drawing.Point(483, 186);
            this.SEleccion.Name = "SEleccion";
            this.SEleccion.Size = new System.Drawing.Size(48, 20);
            this.SEleccion.TabIndex = 23;
            this.SEleccion.Text = "A";
            this.SEleccion.TextChanged += new System.EventHandler(this.SEleccion_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(461, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "prompar2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(459, 315);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "prompar3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(461, 270);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "prompar1";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(7, 344);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(135, 28);
            this.button8.TabIndex = 29;
            this.button8.Text = "SumatoriaPorAlumno";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(421, 479);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(176, 23);
            this.button5.TabIndex = 30;
            this.button5.Text = "Clasificar Alumnos Por Sección";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // PromedioporParcial
            // 
            this.PromedioporParcial.FormattingEnabled = true;
            this.PromedioporParcial.Location = new System.Drawing.Point(92, 165);
            this.PromedioporParcial.Name = "PromedioporParcial";
            this.PromedioporParcial.ScrollAlwaysVisible = true;
            this.PromedioporParcial.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.PromedioporParcial.Size = new System.Drawing.Size(331, 173);
            this.PromedioporParcial.TabIndex = 31;
            // 
            // PromediGeneralPorSeccion
            // 
            this.PromediGeneralPorSeccion.FormattingEnabled = true;
            this.PromediGeneralPorSeccion.Location = new System.Drawing.Point(552, 186);
            this.PromediGeneralPorSeccion.Name = "PromediGeneralPorSeccion";
            this.PromediGeneralPorSeccion.ScrollAlwaysVisible = true;
            this.PromediGeneralPorSeccion.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.PromediGeneralPorSeccion.Size = new System.Drawing.Size(386, 186);
            this.PromediGeneralPorSeccion.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 708);
            this.Controls.Add(this.PromediGeneralPorSeccion);
            this.Controls.Add(this.PromedioporParcial);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.SEleccion);
            this.Controls.Add(this.btnPromediosSeccion);
            this.Controls.Add(this.btnPromedioP2);
            this.Controls.Add(this.btnPromedioP3);
            this.Controls.Add(this.prompar1);
            this.Controls.Add(this.btnOrdenP3);
            this.Controls.Add(this.btnOrdenP2);
            this.Controls.Add(this.btnOrdenP1);
            this.Controls.Add(this.btnOrdenNombre);
            this.Controls.Add(this.ListaordenAlumnos);
            this.Controls.Add(this.IngresarDoc);
            this.Controls.Add(this.button1Abrir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1Abrir;
        private System.Windows.Forms.ListBox IngresarDoc;
        private System.Windows.Forms.ListBox ListaordenAlumnos;
        private System.Windows.Forms.Button btnOrdenNombre;
        private System.Windows.Forms.Button btnOrdenP1;
        private System.Windows.Forms.Button btnOrdenP2;
        private System.Windows.Forms.Button btnOrdenP3;
        private System.Windows.Forms.Button prompar1;
        private System.Windows.Forms.Button btnPromedioP3;
        private System.Windows.Forms.Button btnPromedioP2;
        private System.Windows.Forms.Button btnPromediosSeccion;
        private System.Windows.Forms.TextBox SEleccion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox PromedioporParcial;
        private System.Windows.Forms.ListBox PromediGeneralPorSeccion;
    }
}

