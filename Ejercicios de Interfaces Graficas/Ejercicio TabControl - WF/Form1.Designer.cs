namespace Prueba_Ardiente_xd
{
    partial class Formulario
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
            this.tcPadre = new System.Windows.Forms.TabControl();
            this.tabCalculoEmpleado = new System.Windows.Forms.TabPage();
            this.cbx_Cargos = new System.Windows.Forms.ComboBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_TotalDesc = new System.Windows.Forms.TextBox();
            this.txt_Otro = new System.Windows.Forms.TextBox();
            this.txt_NumeroHijos = new System.Windows.Forms.TextBox();
            this.txt_ISR = new System.Windows.Forms.TextBox();
            this.txt_SueldoBruto = new System.Windows.Forms.TextBox();
            this.txt_SFS = new System.Windows.Forms.TextBox();
            this.txt_AFP = new System.Windows.Forms.TextBox();
            this.lbl_SueldoTotalResultado = new System.Windows.Forms.Label();
            this.lbl_SueldoNetoResultado = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_TotalSueldo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_NumeroHijos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Sueldo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Titulo1 = new System.Windows.Forms.Label();
            this.lbl_Linea1 = new System.Windows.Forms.Label();
            this.tabVisualizacion = new System.Windows.Forms.TabPage();
            this.btn_GuardarTXT = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dgw_VerInfo = new System.Windows.Forms.DataGridView();
            this.NombreEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hijos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bonos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDescuentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CampoSueldoNeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.tcPadre.SuspendLayout();
            this.tabCalculoEmpleado.SuspendLayout();
            this.tabVisualizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_VerInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // tcPadre
            // 
            this.tcPadre.Controls.Add(this.tabCalculoEmpleado);
            this.tcPadre.Controls.Add(this.tabVisualizacion);
            this.tcPadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcPadre.Location = new System.Drawing.Point(0, -1);
            this.tcPadre.Name = "tcPadre";
            this.tcPadre.SelectedIndex = 0;
            this.tcPadre.Size = new System.Drawing.Size(592, 466);
            this.tcPadre.TabIndex = 0;
            // 
            // tabCalculoEmpleado
            // 
            this.tabCalculoEmpleado.Controls.Add(this.cbx_Cargos);
            this.tabCalculoEmpleado.Controls.Add(this.btn_Close);
            this.tabCalculoEmpleado.Controls.Add(this.btn_Limpiar);
            this.tabCalculoEmpleado.Controls.Add(this.btn_Editar);
            this.tabCalculoEmpleado.Controls.Add(this.btn_Save);
            this.tabCalculoEmpleado.Controls.Add(this.txt_TotalDesc);
            this.tabCalculoEmpleado.Controls.Add(this.txt_Otro);
            this.tabCalculoEmpleado.Controls.Add(this.txt_NumeroHijos);
            this.tabCalculoEmpleado.Controls.Add(this.txt_ISR);
            this.tabCalculoEmpleado.Controls.Add(this.txt_SueldoBruto);
            this.tabCalculoEmpleado.Controls.Add(this.txt_SFS);
            this.tabCalculoEmpleado.Controls.Add(this.txt_AFP);
            this.tabCalculoEmpleado.Controls.Add(this.lbl_SueldoTotalResultado);
            this.tabCalculoEmpleado.Controls.Add(this.lbl_SueldoNetoResultado);
            this.tabCalculoEmpleado.Controls.Add(this.label6);
            this.tabCalculoEmpleado.Controls.Add(this.label5);
            this.tabCalculoEmpleado.Controls.Add(this.txt_Nombre);
            this.tabCalculoEmpleado.Controls.Add(this.label4);
            this.tabCalculoEmpleado.Controls.Add(this.lbl_TotalSueldo);
            this.tabCalculoEmpleado.Controls.Add(this.label3);
            this.tabCalculoEmpleado.Controls.Add(this.lbl_NumeroHijos);
            this.tabCalculoEmpleado.Controls.Add(this.label2);
            this.tabCalculoEmpleado.Controls.Add(this.lbl_Sueldo);
            this.tabCalculoEmpleado.Controls.Add(this.label1);
            this.tabCalculoEmpleado.Controls.Add(this.lbl_Apellido);
            this.tabCalculoEmpleado.Controls.Add(this.lbl_Nombre);
            this.tabCalculoEmpleado.Controls.Add(this.lbl_Titulo1);
            this.tabCalculoEmpleado.Controls.Add(this.lbl_Linea1);
            this.tabCalculoEmpleado.Location = new System.Drawing.Point(4, 25);
            this.tabCalculoEmpleado.Name = "tabCalculoEmpleado";
            this.tabCalculoEmpleado.Padding = new System.Windows.Forms.Padding(3);
            this.tabCalculoEmpleado.Size = new System.Drawing.Size(584, 437);
            this.tabCalculoEmpleado.TabIndex = 0;
            this.tabCalculoEmpleado.Text = "Calculos del Empleado";
            this.tabCalculoEmpleado.UseVisualStyleBackColor = true;
            this.tabCalculoEmpleado.Click += new System.EventHandler(this.tabCalculoEmpleado_Click);
            // 
            // cbx_Cargos
            // 
            this.cbx_Cargos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Cargos.FormattingEnabled = true;
            this.cbx_Cargos.Items.AddRange(new object[] {
            "Doctor",
            "Enfermero",
            "Ingeniero Civil",
            "Inversionista",
            "Admin. de Datos"});
            this.cbx_Cargos.Location = new System.Drawing.Point(139, 142);
            this.cbx_Cargos.MaximumSize = new System.Drawing.Size(150, 0);
            this.cbx_Cargos.Name = "cbx_Cargos";
            this.cbx_Cargos.Size = new System.Drawing.Size(121, 24);
            this.cbx_Cargos.TabIndex = 5;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(441, 355);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(84, 31);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.Text = "Exit";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(323, 355);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(84, 31);
            this.btn_Limpiar.TabIndex = 4;
            this.btn_Limpiar.Text = "Clear";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(200, 355);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(84, 31);
            this.btn_Editar.TabIndex = 4;
            this.btn_Editar.Text = "Edit";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(78, 355);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(84, 31);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_TotalDesc
            // 
            this.txt_TotalDesc.Location = new System.Drawing.Point(445, 259);
            this.txt_TotalDesc.Name = "txt_TotalDesc";
            this.txt_TotalDesc.ReadOnly = true;
            this.txt_TotalDesc.Size = new System.Drawing.Size(100, 23);
            this.txt_TotalDesc.TabIndex = 3;
            // 
            // txt_Otro
            // 
            this.txt_Otro.Location = new System.Drawing.Point(445, 219);
            this.txt_Otro.Name = "txt_Otro";
            this.txt_Otro.ReadOnly = true;
            this.txt_Otro.Size = new System.Drawing.Size(100, 23);
            this.txt_Otro.TabIndex = 3;
            // 
            // txt_NumeroHijos
            // 
            this.txt_NumeroHijos.Location = new System.Drawing.Point(139, 224);
            this.txt_NumeroHijos.Name = "txt_NumeroHijos";
            this.txt_NumeroHijos.Size = new System.Drawing.Size(121, 23);
            this.txt_NumeroHijos.TabIndex = 3;
            // 
            // txt_ISR
            // 
            this.txt_ISR.Location = new System.Drawing.Point(445, 179);
            this.txt_ISR.Name = "txt_ISR";
            this.txt_ISR.ReadOnly = true;
            this.txt_ISR.Size = new System.Drawing.Size(100, 23);
            this.txt_ISR.TabIndex = 3;
            // 
            // txt_SueldoBruto
            // 
            this.txt_SueldoBruto.Location = new System.Drawing.Point(139, 184);
            this.txt_SueldoBruto.Name = "txt_SueldoBruto";
            this.txt_SueldoBruto.Size = new System.Drawing.Size(121, 23);
            this.txt_SueldoBruto.TabIndex = 3;
            // 
            // txt_SFS
            // 
            this.txt_SFS.Location = new System.Drawing.Point(445, 139);
            this.txt_SFS.Name = "txt_SFS";
            this.txt_SFS.ReadOnly = true;
            this.txt_SFS.Size = new System.Drawing.Size(100, 23);
            this.txt_SFS.TabIndex = 3;
            // 
            // txt_AFP
            // 
            this.txt_AFP.Location = new System.Drawing.Point(445, 101);
            this.txt_AFP.Name = "txt_AFP";
            this.txt_AFP.ReadOnly = true;
            this.txt_AFP.Size = new System.Drawing.Size(100, 23);
            this.txt_AFP.TabIndex = 3;
            // 
            // lbl_SueldoTotalResultado
            // 
            this.lbl_SueldoTotalResultado.AutoSize = true;
            this.lbl_SueldoTotalResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SueldoTotalResultado.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_SueldoTotalResultado.Location = new System.Drawing.Point(136, 273);
            this.lbl_SueldoTotalResultado.Name = "lbl_SueldoTotalResultado";
            this.lbl_SueldoTotalResultado.Size = new System.Drawing.Size(16, 18);
            this.lbl_SueldoTotalResultado.TabIndex = 2;
            this.lbl_SueldoTotalResultado.Text = "  ";
            // 
            // lbl_SueldoNetoResultado
            // 
            this.lbl_SueldoNetoResultado.AutoSize = true;
            this.lbl_SueldoNetoResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SueldoNetoResultado.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_SueldoNetoResultado.Location = new System.Drawing.Point(137, 300);
            this.lbl_SueldoNetoResultado.Name = "lbl_SueldoNetoResultado";
            this.lbl_SueldoNetoResultado.Size = new System.Drawing.Size(16, 18);
            this.lbl_SueldoNetoResultado.TabIndex = 2;
            this.lbl_SueldoNetoResultado.Text = "  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Sueldo Neto: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(345, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total Desc.";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(139, 106);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(121, 23);
            this.txt_Nombre.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(345, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Otro";
            // 
            // lbl_TotalSueldo
            // 
            this.lbl_TotalSueldo.AutoSize = true;
            this.lbl_TotalSueldo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalSueldo.Location = new System.Drawing.Point(39, 273);
            this.lbl_TotalSueldo.Name = "lbl_TotalSueldo";
            this.lbl_TotalSueldo.Size = new System.Drawing.Size(87, 16);
            this.lbl_TotalSueldo.TabIndex = 2;
            this.lbl_TotalSueldo.Text = "Sueldo Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(345, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "ISR";
            // 
            // lbl_NumeroHijos
            // 
            this.lbl_NumeroHijos.AutoSize = true;
            this.lbl_NumeroHijos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumeroHijos.Location = new System.Drawing.Point(39, 226);
            this.lbl_NumeroHijos.Name = "lbl_NumeroHijos";
            this.lbl_NumeroHijos.Size = new System.Drawing.Size(61, 18);
            this.lbl_NumeroHijos.TabIndex = 2;
            this.lbl_NumeroHijos.Text = "N. Hijos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "SFS";
            // 
            // lbl_Sueldo
            // 
            this.lbl_Sueldo.AutoSize = true;
            this.lbl_Sueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sueldo.Location = new System.Drawing.Point(39, 186);
            this.lbl_Sueldo.Name = "lbl_Sueldo";
            this.lbl_Sueldo.Size = new System.Drawing.Size(54, 18);
            this.lbl_Sueldo.TabIndex = 2;
            this.lbl_Sueldo.Text = "Sueldo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "AFP";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apellido.Location = new System.Drawing.Point(39, 146);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(59, 18);
            this.lbl_Apellido.TabIndex = 2;
            this.lbl_Apellido.Text = "Apellido";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.Location = new System.Drawing.Point(39, 106);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(62, 18);
            this.lbl_Nombre.TabIndex = 2;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Titulo1
            // 
            this.lbl_Titulo1.AutoSize = true;
            this.lbl_Titulo1.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo1.Location = new System.Drawing.Point(36, 32);
            this.lbl_Titulo1.Name = "lbl_Titulo1";
            this.lbl_Titulo1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_Titulo1.Size = new System.Drawing.Size(314, 28);
            this.lbl_Titulo1.TabIndex = 0;
            this.lbl_Titulo1.Text = "CALCULOS DEL EMPLEADO";
            // 
            // lbl_Linea1
            // 
            this.lbl_Linea1.AutoSize = true;
            this.lbl_Linea1.Font = new System.Drawing.Font("Arial Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Linea1.Location = new System.Drawing.Point(39, 66);
            this.lbl_Linea1.Name = "lbl_Linea1";
            this.lbl_Linea1.Size = new System.Drawing.Size(88, 18);
            this.lbl_Linea1.TabIndex = 1;
            this.lbl_Linea1.Text = "--------------------";
            // 
            // tabVisualizacion
            // 
            this.tabVisualizacion.Controls.Add(this.btn_Delete);
            this.tabVisualizacion.Controls.Add(this.btn_GuardarTXT);
            this.tabVisualizacion.Controls.Add(this.label7);
            this.tabVisualizacion.Controls.Add(this.dgw_VerInfo);
            this.tabVisualizacion.Location = new System.Drawing.Point(4, 25);
            this.tabVisualizacion.Name = "tabVisualizacion";
            this.tabVisualizacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabVisualizacion.Size = new System.Drawing.Size(584, 437);
            this.tabVisualizacion.TabIndex = 1;
            this.tabVisualizacion.Text = "Visualización";
            this.tabVisualizacion.UseVisualStyleBackColor = true;
            // 
            // btn_GuardarTXT
            // 
            this.btn_GuardarTXT.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GuardarTXT.Location = new System.Drawing.Point(98, 385);
            this.btn_GuardarTXT.Name = "btn_GuardarTXT";
            this.btn_GuardarTXT.Size = new System.Drawing.Size(88, 49);
            this.btn_GuardarTXT.TabIndex = 2;
            this.btn_GuardarTXT.Text = "Guardar (.txt)";
            this.btn_GuardarTXT.UseVisualStyleBackColor = true;
            this.btn_GuardarTXT.Click += new System.EventHandler(this.btn_GuardarTXT_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(145, 27);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(318, 28);
            this.label7.TabIndex = 1;
            this.label7.Text = "EMPLEADOS REGISTRADOS";
            // 
            // dgw_VerInfo
            // 
            this.dgw_VerInfo.AllowUserToAddRows = false;
            this.dgw_VerInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_VerInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreEmpleado,
            this.ApellidoEmpleado,
            this.Hijos,
            this.Sueldo,
            this.Bonos,
            this.totalDescuentos,
            this.CampoSueldoNeto});
            this.dgw_VerInfo.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgw_VerInfo.Location = new System.Drawing.Point(8, 87);
            this.dgw_VerInfo.Name = "dgw_VerInfo";
            this.dgw_VerInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_VerInfo.Size = new System.Drawing.Size(575, 295);
            this.dgw_VerInfo.TabIndex = 0;
            this.dgw_VerInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_VerInfo_CellContentClick);
            // 
            // NombreEmpleado
            // 
            this.NombreEmpleado.HeaderText = "Nombre";
            this.NombreEmpleado.Name = "NombreEmpleado";
            this.NombreEmpleado.ReadOnly = true;
            this.NombreEmpleado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NombreEmpleado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NombreEmpleado.Width = 83;
            // 
            // ApellidoEmpleado
            // 
            this.ApellidoEmpleado.HeaderText = "Apellido";
            this.ApellidoEmpleado.Name = "ApellidoEmpleado";
            this.ApellidoEmpleado.ReadOnly = true;
            this.ApellidoEmpleado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ApellidoEmpleado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Hijos
            // 
            this.Hijos.HeaderText = "Hijos";
            this.Hijos.Name = "Hijos";
            this.Hijos.ReadOnly = true;
            this.Hijos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Hijos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Hijos.Width = 60;
            // 
            // Sueldo
            // 
            this.Sueldo.HeaderText = "Sueldo";
            this.Sueldo.Name = "Sueldo";
            this.Sueldo.ReadOnly = true;
            this.Sueldo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Sueldo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Bonos
            // 
            this.Bonos.HeaderText = "Bono por Hijos";
            this.Bonos.Name = "Bonos";
            this.Bonos.ReadOnly = true;
            this.Bonos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Bonos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // totalDescuentos
            // 
            this.totalDescuentos.HeaderText = "Impuestos";
            this.totalDescuentos.Name = "totalDescuentos";
            this.totalDescuentos.ReadOnly = true;
            this.totalDescuentos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.totalDescuentos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CampoSueldoNeto
            // 
            this.CampoSueldoNeto.HeaderText = "Sueldo Neto";
            this.CampoSueldoNeto.MinimumWidth = 100;
            this.CampoSueldoNeto.Name = "CampoSueldoNeto";
            this.CampoSueldoNeto.ReadOnly = true;
            this.CampoSueldoNeto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CampoSueldoNeto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(8, 385);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(84, 49);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 464);
            this.Controls.Add(this.tcPadre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Formulario";
            this.Text = "Formulario";
            this.tcPadre.ResumeLayout(false);
            this.tabCalculoEmpleado.ResumeLayout(false);
            this.tabCalculoEmpleado.PerformLayout();
            this.tabVisualizacion.ResumeLayout(false);
            this.tabVisualizacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_VerInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcPadre;
        private System.Windows.Forms.TabPage tabCalculoEmpleado;
        private System.Windows.Forms.TabPage tabVisualizacion;
        private System.Windows.Forms.Label lbl_Titulo1;
        private System.Windows.Forms.Label lbl_Linea1;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_TotalSueldo;
        private System.Windows.Forms.Label lbl_NumeroHijos;
        private System.Windows.Forms.Label lbl_Sueldo;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.TextBox txt_TotalDesc;
        private System.Windows.Forms.TextBox txt_Otro;
        private System.Windows.Forms.TextBox txt_NumeroHijos;
        private System.Windows.Forms.TextBox txt_ISR;
        private System.Windows.Forms.TextBox txt_SueldoBruto;
        private System.Windows.Forms.TextBox txt_SFS;
        private System.Windows.Forms.TextBox txt_AFP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_SueldoNetoResultado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_SueldoTotalResultado;
        private System.Windows.Forms.DataGridView dgw_VerInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_GuardarTXT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hijos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sueldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bonos;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDescuentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CampoSueldoNeto;
        private System.Windows.Forms.ComboBox cbx_Cargos;
        private System.Windows.Forms.Button btn_Delete;
    }
}

