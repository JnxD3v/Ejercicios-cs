namespace Ejercicio_2__Interfaz_Grafica_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Numero1 = new System.Windows.Forms.TextBox();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.Numero2 = new System.Windows.Forms.TextBox();
            this.lbl_Numero1 = new System.Windows.Forms.Label();
            this.lbl_Numero2 = new System.Windows.Forms.Label();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.linea1 = new System.Windows.Forms.Button();
            this.linea2 = new System.Windows.Forms.Button();
            this.lbl_SumaMSG = new System.Windows.Forms.Label();
            this.lbl_RestaMSG = new System.Windows.Forms.Label();
            this.lbl_MultiMSG = new System.Windows.Forms.Label();
            this.lbl_DivisionMSG = new System.Windows.Forms.Label();
            this.lbl_Suma = new System.Windows.Forms.Label();
            this.lbl_Resta = new System.Windows.Forms.Label();
            this.lbl_Multi = new System.Windows.Forms.Label();
            this.lbl_Division = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Numero1
            // 
            this.Numero1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.Numero1.ForeColor = System.Drawing.Color.White;
            this.Numero1.Location = new System.Drawing.Point(81, 120);
            this.Numero1.Name = "Numero1";
            this.Numero1.Size = new System.Drawing.Size(114, 20);
            this.Numero1.TabIndex = 0;
            this.Numero1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.Location = new System.Drawing.Point(148, 258);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(90, 30);
            this.btn_Limpiar.TabIndex = 2;
            this.btn_Limpiar.Text = "LIMPIAR";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Location = new System.Drawing.Point(96, 301);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(90, 30);
            this.btn_Salir.TabIndex = 3;
            this.btn_Salir.Text = "SALIR";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // Numero2
            // 
            this.Numero2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.Numero2.ForeColor = System.Drawing.Color.White;
            this.Numero2.Location = new System.Drawing.Point(81, 181);
            this.Numero2.Name = "Numero2";
            this.Numero2.Size = new System.Drawing.Size(115, 20);
            this.Numero2.TabIndex = 4;
            // 
            // lbl_Numero1
            // 
            this.lbl_Numero1.AutoSize = true;
            this.lbl_Numero1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Numero1.Location = new System.Drawing.Point(79, 98);
            this.lbl_Numero1.Name = "lbl_Numero1";
            this.lbl_Numero1.Size = new System.Drawing.Size(90, 19);
            this.lbl_Numero1.TabIndex = 5;
            this.lbl_Numero1.Text = "NÚMERO #1";
            // 
            // lbl_Numero2
            // 
            this.lbl_Numero2.AutoSize = true;
            this.lbl_Numero2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Numero2.Location = new System.Drawing.Point(79, 159);
            this.lbl_Numero2.Name = "lbl_Numero2";
            this.lbl_Numero2.Size = new System.Drawing.Size(90, 19);
            this.lbl_Numero2.TabIndex = 6;
            this.lbl_Numero2.Text = "NÚMERO #2";
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resultado.Location = new System.Drawing.Point(368, 74);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(125, 18);
            this.lbl_Resultado.TabIndex = 7;
            this.lbl_Resultado.Text = "• RESULTADOS •";
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.ForeColor = System.Drawing.Color.White;
            this.btn_Calcular.Location = new System.Drawing.Point(39, 258);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(90, 30);
            this.btn_Calcular.TabIndex = 1;
            this.btn_Calcular.Text = "CALCULAR";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(164, 19);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(213, 23);
            this.lbl_Titulo.TabIndex = 8;
            this.lbl_Titulo.Text = "CALCULADORA BASICA";
            // 
            // linea1
            // 
            this.linea1.Location = new System.Drawing.Point(-8, 57);
            this.linea1.Name = "linea1";
            this.linea1.Size = new System.Drawing.Size(1375, 1);
            this.linea1.TabIndex = 9;
            this.linea1.UseVisualStyleBackColor = true;
            // 
            // linea2
            // 
            this.linea2.Location = new System.Drawing.Point(302, 57);
            this.linea2.Name = "linea2";
            this.linea2.Size = new System.Drawing.Size(1, 1375);
            this.linea2.TabIndex = 9;
            this.linea2.UseVisualStyleBackColor = true;
            // 
            // lbl_SumaMSG
            // 
            this.lbl_SumaMSG.AutoSize = true;
            this.lbl_SumaMSG.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SumaMSG.Location = new System.Drawing.Point(324, 120);
            this.lbl_SumaMSG.Name = "lbl_SumaMSG";
            this.lbl_SumaMSG.Size = new System.Drawing.Size(49, 15);
            this.lbl_SumaMSG.TabIndex = 5;
            this.lbl_SumaMSG.Text = "SUMA: ";
            // 
            // lbl_RestaMSG
            // 
            this.lbl_RestaMSG.AutoSize = true;
            this.lbl_RestaMSG.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RestaMSG.Location = new System.Drawing.Point(324, 150);
            this.lbl_RestaMSG.Name = "lbl_RestaMSG";
            this.lbl_RestaMSG.Size = new System.Drawing.Size(56, 15);
            this.lbl_RestaMSG.TabIndex = 5;
            this.lbl_RestaMSG.Text = "RESTA: ";
            // 
            // lbl_MultiMSG
            // 
            this.lbl_MultiMSG.AutoSize = true;
            this.lbl_MultiMSG.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MultiMSG.Location = new System.Drawing.Point(324, 180);
            this.lbl_MultiMSG.Name = "lbl_MultiMSG";
            this.lbl_MultiMSG.Size = new System.Drawing.Size(63, 15);
            this.lbl_MultiMSG.TabIndex = 5;
            this.lbl_MultiMSG.Text = "MULTI. :";
            // 
            // lbl_DivisionMSG
            // 
            this.lbl_DivisionMSG.AutoSize = true;
            this.lbl_DivisionMSG.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DivisionMSG.Location = new System.Drawing.Point(324, 210);
            this.lbl_DivisionMSG.Name = "lbl_DivisionMSG";
            this.lbl_DivisionMSG.Size = new System.Drawing.Size(77, 15);
            this.lbl_DivisionMSG.TabIndex = 5;
            this.lbl_DivisionMSG.Text = "DIVISIÓN: ";
            // 
            // lbl_Suma
            // 
            this.lbl_Suma.AutoSize = true;
            this.lbl_Suma.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Suma.Location = new System.Drawing.Point(399, 120);
            this.lbl_Suma.Name = "lbl_Suma";
            this.lbl_Suma.Size = new System.Drawing.Size(14, 15);
            this.lbl_Suma.TabIndex = 5;
            this.lbl_Suma.Text = " ";
            // 
            // lbl_Resta
            // 
            this.lbl_Resta.AutoSize = true;
            this.lbl_Resta.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resta.Location = new System.Drawing.Point(399, 150);
            this.lbl_Resta.Name = "lbl_Resta";
            this.lbl_Resta.Size = new System.Drawing.Size(14, 15);
            this.lbl_Resta.TabIndex = 5;
            this.lbl_Resta.Text = " ";
            // 
            // lbl_Multi
            // 
            this.lbl_Multi.AutoSize = true;
            this.lbl_Multi.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Multi.Location = new System.Drawing.Point(399, 180);
            this.lbl_Multi.Name = "lbl_Multi";
            this.lbl_Multi.Size = new System.Drawing.Size(14, 15);
            this.lbl_Multi.TabIndex = 5;
            this.lbl_Multi.Text = " ";
            // 
            // lbl_Division
            // 
            this.lbl_Division.AutoSize = true;
            this.lbl_Division.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Division.Location = new System.Drawing.Point(399, 210);
            this.lbl_Division.Name = "lbl_Division";
            this.lbl_Division.Size = new System.Drawing.Size(14, 15);
            this.lbl_Division.TabIndex = 5;
            this.lbl_Division.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(414, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "by michael.frito";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(545, 343);
            this.Controls.Add(this.linea2);
            this.Controls.Add(this.linea1);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.lbl_Numero2);
            this.Controls.Add(this.lbl_Division);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_DivisionMSG);
            this.Controls.Add(this.lbl_Multi);
            this.Controls.Add(this.lbl_MultiMSG);
            this.Controls.Add(this.lbl_Resta);
            this.Controls.Add(this.lbl_RestaMSG);
            this.Controls.Add(this.lbl_Suma);
            this.Controls.Add(this.lbl_SumaMSG);
            this.Controls.Add(this.lbl_Numero1);
            this.Controls.Add(this.Numero2);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.Numero1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora Básica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Numero1;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.TextBox Numero2;
        private System.Windows.Forms.Label lbl_Numero1;
        private System.Windows.Forms.Label lbl_Numero2;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button linea1;
        private System.Windows.Forms.Button linea2;
        private System.Windows.Forms.Label lbl_SumaMSG;
        private System.Windows.Forms.Label lbl_RestaMSG;
        private System.Windows.Forms.Label lbl_MultiMSG;
        private System.Windows.Forms.Label lbl_DivisionMSG;
        private System.Windows.Forms.Label lbl_Suma;
        private System.Windows.Forms.Label lbl_Resta;
        private System.Windows.Forms.Label lbl_Multi;
        private System.Windows.Forms.Label lbl_Division;
        private System.Windows.Forms.Label label1;
    }
}

