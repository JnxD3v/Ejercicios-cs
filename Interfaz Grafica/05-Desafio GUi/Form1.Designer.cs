namespace _05_Desafio_GUi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbcInformacion = new TabControl();
            tabPage1 = new TabPage();
            lbl_incentivo = new Label();
            txt_incentivo = new TextBox();
            btn_Calcular = new Button();
            label3 = new Label();
            label2 = new Label();
            btn_Limpiar = new Button();
            btn_Eliminar = new Button();
            btn_Guardar = new Button();
            txt_Sueldoneto = new TextBox();
            txt_Totaldesc = new TextBox();
            txt_Otro = new TextBox();
            txt_ISR = new TextBox();
            txt_SFS = new TextBox();
            txt_AFP = new TextBox();
            label12 = new Label();
            label1 = new Label();
            txt_SueldoIncentivo = new TextBox();
            txt_NHijos = new TextBox();
            txt_Sueldo = new TextBox();
            txt_Cargo = new TextBox();
            lblSueldoNeto = new Label();
            lbl_TotalDesc = new Label();
            lbl_Otro = new Label();
            lbl_ISR = new Label();
            lbl_SFS = new Label();
            lbl_AFP = new Label();
            lbl_Sueldoincentivos = new Label();
            lbl_Nhijos = new Label();
            lbl_Sueldo = new Label();
            lbl_Cargo = new Label();
            btn_Salir = new Button();
            txt_Nombre = new TextBox();
            lblNombre = new Label();
            tabPage2 = new TabPage();
            btn_edit = new Button();
            btnGenerar = new Button();
            dtgw_Info = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Sueldo = new DataGridViewTextBoxColumn();
            Incentivo = new DataGridViewTextBoxColumn();
            sueldoIncentivo = new DataGridViewTextBoxColumn();
            AFP = new DataGridViewTextBoxColumn();
            SFS = new DataGridViewTextBoxColumn();
            ISR = new DataGridViewTextBoxColumn();
            OTROS = new DataGridViewTextBoxColumn();
            Total_descuento = new DataGridViewTextBoxColumn();
            Sueldo_Neto = new DataGridViewTextBoxColumn();
            tbcInformacion.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgw_Info).BeginInit();
            SuspendLayout();
            // 
            // tbcInformacion
            // 
            tbcInformacion.Controls.Add(tabPage1);
            tbcInformacion.Controls.Add(tabPage2);
            tbcInformacion.Location = new Point(-4, 1);
            tbcInformacion.Name = "tbcInformacion";
            tbcInformacion.SelectedIndex = 0;
            tbcInformacion.Size = new Size(841, 447);
            tbcInformacion.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(51, 51, 51);
            tabPage1.Controls.Add(lbl_incentivo);
            tabPage1.Controls.Add(txt_incentivo);
            tabPage1.Controls.Add(btn_Calcular);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(btn_Limpiar);
            tabPage1.Controls.Add(btn_Eliminar);
            tabPage1.Controls.Add(btn_Guardar);
            tabPage1.Controls.Add(txt_Sueldoneto);
            tabPage1.Controls.Add(txt_Totaldesc);
            tabPage1.Controls.Add(txt_Otro);
            tabPage1.Controls.Add(txt_ISR);
            tabPage1.Controls.Add(txt_SFS);
            tabPage1.Controls.Add(txt_AFP);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txt_SueldoIncentivo);
            tabPage1.Controls.Add(txt_NHijos);
            tabPage1.Controls.Add(txt_Sueldo);
            tabPage1.Controls.Add(txt_Cargo);
            tabPage1.Controls.Add(lblSueldoNeto);
            tabPage1.Controls.Add(lbl_TotalDesc);
            tabPage1.Controls.Add(lbl_Otro);
            tabPage1.Controls.Add(lbl_ISR);
            tabPage1.Controls.Add(lbl_SFS);
            tabPage1.Controls.Add(lbl_AFP);
            tabPage1.Controls.Add(lbl_Sueldoincentivos);
            tabPage1.Controls.Add(lbl_Nhijos);
            tabPage1.Controls.Add(lbl_Sueldo);
            tabPage1.Controls.Add(lbl_Cargo);
            tabPage1.Controls.Add(btn_Salir);
            tabPage1.Controls.Add(txt_Nombre);
            tabPage1.Controls.Add(lblNombre);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(833, 419);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Empleado";
            // 
            // lbl_incentivo
            // 
            lbl_incentivo.AutoSize = true;
            lbl_incentivo.BackColor = Color.Transparent;
            lbl_incentivo.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_incentivo.ForeColor = Color.White;
            lbl_incentivo.Location = new Point(6, 260);
            lbl_incentivo.Name = "lbl_incentivo";
            lbl_incentivo.Size = new Size(110, 27);
            lbl_incentivo.TabIndex = 33;
            lbl_incentivo.Text = "Incentivo";
            // 
            // txt_incentivo
            // 
            txt_incentivo.Location = new Point(225, 264);
            txt_incentivo.Name = "txt_incentivo";
            txt_incentivo.ReadOnly = true;
            txt_incentivo.Size = new Size(100, 23);
            txt_incentivo.TabIndex = 32;
            // 
            // btn_Calcular
            // 
            btn_Calcular.FlatStyle = FlatStyle.Flat;
            btn_Calcular.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Calcular.ForeColor = Color.White;
            btn_Calcular.Location = new Point(441, 357);
            btn_Calcular.Name = "btn_Calcular";
            btn_Calcular.Size = new Size(102, 34);
            btn_Calcular.TabIndex = 31;
            btn_Calcular.Text = "Calcular";
            btn_Calcular.UseVisualStyleBackColor = true;
            btn_Calcular.Click += btn_Calcular_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(635, 195);
            label3.Name = "label3";
            label3.Size = new Size(10, 225);
            label3.TabIndex = 30;
            label3.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(635, 0);
            label2.Name = "label2";
            label2.Size = new Size(10, 195);
            label2.TabIndex = 29;
            label2.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.FlatStyle = FlatStyle.Flat;
            btn_Limpiar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Limpiar.ForeColor = Color.White;
            btn_Limpiar.Location = new Point(717, 84);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(75, 37);
            btn_Limpiar.TabIndex = 27;
            btn_Limpiar.Text = "Limpiar";
            btn_Limpiar.UseVisualStyleBackColor = true;
            btn_Limpiar.Click += btn_Limpiar_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.FlatStyle = FlatStyle.Flat;
            btn_Eliminar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Eliminar.ForeColor = Color.White;
            btn_Eliminar.Location = new Point(717, 140);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(90, 35);
            btn_Eliminar.TabIndex = 26;
            btn_Eliminar.Text = "Eliminar";
            btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Guardar
            // 
            btn_Guardar.FlatStyle = FlatStyle.Flat;
            btn_Guardar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Guardar.ForeColor = Color.White;
            btn_Guardar.Location = new Point(717, 195);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(90, 34);
            btn_Guardar.TabIndex = 25;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // txt_Sueldoneto
            // 
            txt_Sueldoneto.Location = new Point(529, 308);
            txt_Sueldoneto.Name = "txt_Sueldoneto";
            txt_Sueldoneto.ReadOnly = true;
            txt_Sueldoneto.Size = new Size(100, 23);
            txt_Sueldoneto.TabIndex = 24;
            // 
            // txt_Totaldesc
            // 
            txt_Totaldesc.Location = new Point(529, 253);
            txt_Totaldesc.Name = "txt_Totaldesc";
            txt_Totaldesc.ReadOnly = true;
            txt_Totaldesc.Size = new Size(100, 23);
            txt_Totaldesc.TabIndex = 23;
            // 
            // txt_Otro
            // 
            txt_Otro.Location = new Point(529, 201);
            txt_Otro.Name = "txt_Otro";
            txt_Otro.ReadOnly = true;
            txt_Otro.Size = new Size(100, 23);
            txt_Otro.TabIndex = 22;
            // 
            // txt_ISR
            // 
            txt_ISR.Location = new Point(529, 152);
            txt_ISR.Name = "txt_ISR";
            txt_ISR.ReadOnly = true;
            txt_ISR.Size = new Size(100, 23);
            txt_ISR.TabIndex = 21;
            // 
            // txt_SFS
            // 
            txt_SFS.Location = new Point(529, 97);
            txt_SFS.Name = "txt_SFS";
            txt_SFS.ReadOnly = true;
            txt_SFS.Size = new Size(100, 23);
            txt_SFS.TabIndex = 20;
            // 
            // txt_AFP
            // 
            txt_AFP.Location = new Point(529, 43);
            txt_AFP.Name = "txt_AFP";
            txt_AFP.ReadOnly = true;
            txt_AFP.Size = new Size(100, 23);
            txt_AFP.TabIndex = 19;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Gray;
            label12.Location = new Point(331, 201);
            label12.Name = "label12";
            label12.Size = new Size(10, 225);
            label12.TabIndex = 18;
            label12.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(331, 3);
            label1.Name = "label1";
            label1.Size = new Size(10, 195);
            label1.TabIndex = 17;
            label1.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            // 
            // txt_SueldoIncentivo
            // 
            txt_SueldoIncentivo.Location = new Point(225, 312);
            txt_SueldoIncentivo.Name = "txt_SueldoIncentivo";
            txt_SueldoIncentivo.ReadOnly = true;
            txt_SueldoIncentivo.Size = new Size(100, 23);
            txt_SueldoIncentivo.TabIndex = 16;
            // 
            // txt_NHijos
            // 
            txt_NHijos.Location = new Point(225, 209);
            txt_NHijos.Name = "txt_NHijos";
            txt_NHijos.Size = new Size(100, 23);
            txt_NHijos.TabIndex = 15;
            // 
            // txt_Sueldo
            // 
            txt_Sueldo.Location = new Point(225, 154);
            txt_Sueldo.Name = "txt_Sueldo";
            txt_Sueldo.Size = new Size(100, 23);
            txt_Sueldo.TabIndex = 14;
            // 
            // txt_Cargo
            // 
            txt_Cargo.Location = new Point(225, 96);
            txt_Cargo.Name = "txt_Cargo";
            txt_Cargo.Size = new Size(100, 23);
            txt_Cargo.TabIndex = 13;
            // 
            // lblSueldoNeto
            // 
            lblSueldoNeto.AutoSize = true;
            lblSueldoNeto.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSueldoNeto.ForeColor = Color.White;
            lblSueldoNeto.Location = new Point(358, 308);
            lblSueldoNeto.Name = "lblSueldoNeto";
            lblSueldoNeto.Size = new Size(140, 27);
            lblSueldoNeto.TabIndex = 12;
            lblSueldoNeto.Text = "Sueldo Neto";
            // 
            // lbl_TotalDesc
            // 
            lbl_TotalDesc.AutoSize = true;
            lbl_TotalDesc.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_TotalDesc.ForeColor = Color.White;
            lbl_TotalDesc.Location = new Point(358, 249);
            lbl_TotalDesc.Name = "lbl_TotalDesc";
            lbl_TotalDesc.Size = new Size(124, 27);
            lbl_TotalDesc.TabIndex = 11;
            lbl_TotalDesc.Text = "Total Desc";
            // 
            // lbl_Otro
            // 
            lbl_Otro.AutoSize = true;
            lbl_Otro.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Otro.ForeColor = Color.White;
            lbl_Otro.Location = new Point(358, 203);
            lbl_Otro.Name = "lbl_Otro";
            lbl_Otro.Size = new Size(57, 27);
            lbl_Otro.TabIndex = 10;
            lbl_Otro.Text = "Otro";
            // 
            // lbl_ISR
            // 
            lbl_ISR.AutoSize = true;
            lbl_ISR.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ISR.ForeColor = Color.White;
            lbl_ISR.Location = new Point(358, 152);
            lbl_ISR.Name = "lbl_ISR";
            lbl_ISR.Size = new Size(48, 27);
            lbl_ISR.TabIndex = 9;
            lbl_ISR.Text = "ISR";
            // 
            // lbl_SFS
            // 
            lbl_SFS.AutoSize = true;
            lbl_SFS.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_SFS.ForeColor = Color.White;
            lbl_SFS.Location = new Point(358, 94);
            lbl_SFS.Name = "lbl_SFS";
            lbl_SFS.Size = new Size(53, 27);
            lbl_SFS.TabIndex = 8;
            lbl_SFS.Text = "SFS";
            // 
            // lbl_AFP
            // 
            lbl_AFP.AutoSize = true;
            lbl_AFP.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_AFP.ForeColor = Color.White;
            lbl_AFP.Location = new Point(358, 37);
            lbl_AFP.Name = "lbl_AFP";
            lbl_AFP.Size = new Size(54, 27);
            lbl_AFP.TabIndex = 7;
            lbl_AFP.Text = "AFP";
            lbl_AFP.Click += label6_Click;
            // 
            // lbl_Sueldoincentivos
            // 
            lbl_Sueldoincentivos.AutoSize = true;
            lbl_Sueldoincentivos.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Sueldoincentivos.ForeColor = Color.White;
            lbl_Sueldoincentivos.Location = new Point(6, 312);
            lbl_Sueldoincentivos.Name = "lbl_Sueldoincentivos";
            lbl_Sueldoincentivos.Size = new Size(207, 27);
            lbl_Sueldoincentivos.TabIndex = 6;
            lbl_Sueldoincentivos.Text = "Sueldo+Incentivos";
            // 
            // lbl_Nhijos
            // 
            lbl_Nhijos.AutoSize = true;
            lbl_Nhijos.BackColor = Color.Transparent;
            lbl_Nhijos.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Nhijos.ForeColor = Color.White;
            lbl_Nhijos.Location = new Point(6, 209);
            lbl_Nhijos.Name = "lbl_Nhijos";
            lbl_Nhijos.Size = new Size(87, 27);
            lbl_Nhijos.TabIndex = 5;
            lbl_Nhijos.Text = "N Hijos";
            lbl_Nhijos.Click += label4_Click;
            // 
            // lbl_Sueldo
            // 
            lbl_Sueldo.AutoSize = true;
            lbl_Sueldo.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Sueldo.ForeColor = SystemColors.Control;
            lbl_Sueldo.Location = new Point(6, 157);
            lbl_Sueldo.Name = "lbl_Sueldo";
            lbl_Sueldo.Size = new Size(84, 27);
            lbl_Sueldo.TabIndex = 4;
            lbl_Sueldo.Text = "Sueldo";
            // 
            // lbl_Cargo
            // 
            lbl_Cargo.AutoSize = true;
            lbl_Cargo.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Cargo.ForeColor = SystemColors.Control;
            lbl_Cargo.Location = new Point(6, 97);
            lbl_Cargo.Name = "lbl_Cargo";
            lbl_Cargo.Size = new Size(74, 27);
            lbl_Cargo.TabIndex = 3;
            lbl_Cargo.Text = "Cargo";
            lbl_Cargo.Click += label2_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.FlatStyle = FlatStyle.Flat;
            btn_Salir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Salir.ForeColor = Color.White;
            btn_Salir.Location = new Point(717, 33);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(75, 31);
            btn_Salir.TabIndex = 2;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = true;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(225, 47);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(100, 23);
            txt_Nombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = SystemColors.ButtonHighlight;
            lblNombre.Location = new Point(6, 47);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(94, 27);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(51, 51, 51);
            tabPage2.Controls.Add(btn_edit);
            tabPage2.Controls.Add(btnGenerar);
            tabPage2.Controls.Add(dtgw_Info);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(833, 419);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "info";
            tabPage2.Click += tabPage2_Click;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.MistyRose;
            btn_edit.FlatStyle = FlatStyle.Flat;
            btn_edit.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_edit.ForeColor = SystemColors.InfoText;
            btn_edit.Location = new Point(456, 280);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(105, 47);
            btn_edit.TabIndex = 2;
            btn_edit.Text = "Editar";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.MistyRose;
            btnGenerar.FlatStyle = FlatStyle.Flat;
            btnGenerar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerar.ForeColor = SystemColors.InfoText;
            btnGenerar.Location = new Point(620, 280);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(105, 47);
            btnGenerar.TabIndex = 1;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += button1_Click;
            // 
            // dtgw_Info
            // 
            dtgw_Info.BackgroundColor = Color.FromArgb(51, 51, 51);
            dtgw_Info.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgw_Info.Columns.AddRange(new DataGridViewColumn[] { Nombre, Sueldo, Incentivo, sueldoIncentivo, AFP, SFS, ISR, OTROS, Total_descuento, Sueldo_Neto });
            dtgw_Info.Location = new Point(23, 28);
            dtgw_Info.Name = "dtgw_Info";
            dtgw_Info.ReadOnly = true;
            dtgw_Info.Size = new Size(761, 222);
            dtgw_Info.TabIndex = 0;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Sueldo
            // 
            Sueldo.HeaderText = "Sueldo";
            Sueldo.Name = "Sueldo";
            Sueldo.ReadOnly = true;
            Sueldo.Width = 70;
            // 
            // Incentivo
            // 
            Incentivo.HeaderText = "Incentivo";
            Incentivo.Name = "Incentivo";
            Incentivo.ReadOnly = true;
            Incentivo.Width = 70;
            // 
            // sueldoIncentivo
            // 
            sueldoIncentivo.HeaderText = "Sueldo_+_Incentivo";
            sueldoIncentivo.Name = "sueldoIncentivo";
            sueldoIncentivo.ReadOnly = true;
            sueldoIncentivo.Width = 90;
            // 
            // AFP
            // 
            AFP.HeaderText = "AFP";
            AFP.Name = "AFP";
            AFP.ReadOnly = true;
            AFP.Width = 60;
            // 
            // SFS
            // 
            SFS.HeaderText = "SFS";
            SFS.Name = "SFS";
            SFS.ReadOnly = true;
            SFS.Width = 60;
            // 
            // ISR
            // 
            ISR.HeaderText = "ISR";
            ISR.Name = "ISR";
            ISR.ReadOnly = true;
            ISR.Width = 70;
            // 
            // OTROS
            // 
            OTROS.HeaderText = "OTROS";
            OTROS.Name = "OTROS";
            OTROS.ReadOnly = true;
            OTROS.Width = 50;
            // 
            // Total_descuento
            // 
            Total_descuento.HeaderText = "Total descuento";
            Total_descuento.Name = "Total_descuento";
            Total_descuento.ReadOnly = true;
            Total_descuento.Width = 70;
            // 
            // Sueldo_Neto
            // 
            Sueldo_Neto.HeaderText = "Sueldo Neto";
            Sueldo_Neto.Name = "Sueldo_Neto";
            Sueldo_Neto.ReadOnly = true;
            Sueldo_Neto.Width = 75;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 435);
            Controls.Add(tbcInformacion);
            Name = "Form1";
            Text = "Form1";
            tbcInformacion.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgw_Info).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbcInformacion;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dtgw_Info;
        private Button btn_Salir;
        private TextBox txt_Nombre;
        private Label lblNombre;
        private Button btnGenerar;
        private Label lblSueldoNeto;
        private Label lbl_TotalDesc;
        private Label lbl_Otro;
        private Label lbl_ISR;
        private Label lbl_SFS;
        private Label lbl_AFP;
        private Label lbl_Sueldoincentivos;
        private Label lbl_Nhijos;
        private Label lbl_Sueldo;
        private Label lbl_Cargo;
        private TextBox txt_SueldoIncentivo;
        private TextBox txt_NHijos;
        private TextBox txt_Sueldo;
        private TextBox txt_Cargo;
        private TextBox txt_Sueldoneto;
        private TextBox txt_Totaldesc;
        private TextBox txt_Otro;
        private TextBox txt_ISR;
        private TextBox txt_SFS;
        private TextBox txt_AFP;
        private Button btn_Limpiar;
        private Button btn_Eliminar;
        private Button btn_Guardar;
        private Label label3;
        private Label label2;
        private Button btn_Calcular;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Sueldo;
        private DataGridViewTextBoxColumn Incentivo;
        private DataGridViewTextBoxColumn sueldoIncentivo;
        private DataGridViewTextBoxColumn AFP;
        private DataGridViewTextBoxColumn SFS;
        private DataGridViewTextBoxColumn ISR;
        private DataGridViewTextBoxColumn OTROS;
        private DataGridViewTextBoxColumn Total_descuento;
        private DataGridViewTextBoxColumn Sueldo_Neto;
        private Label label12;
        private Label label1;
        private Label lbl_incentivo;
        private TextBox txt_incentivo;
        private Button btn_edit;
    }
}
