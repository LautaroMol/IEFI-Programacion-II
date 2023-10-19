namespace IEFI_Programación_II
{
    partial class FormMateria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Cargar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Dgv_Materias = new System.Windows.Forms.DataGridView();
            this.Checkbox_Estado = new System.Windows.Forms.CheckBox();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.Txt_Legajo = new System.Windows.Forms.TextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Lbl_Codigo = new System.Windows.Forms.Label();
            this.Lbl_Legajo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.Btn_Atras = new System.Windows.Forms.Button();
            this.Lbl_Cruz = new System.Windows.Forms.Label();
            this.Btn_Llenar = new System.Windows.Forms.Button();
            this.Btn_Alegajo = new System.Windows.Forms.Button();
            this.Txt_Alegajo = new System.Windows.Forms.TextBox();
            this.Btn_Borrar = new System.Windows.Forms.Button();
            this.Lbl_Apellido = new System.Windows.Forms.Label();
            this.Txt_Apellido = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Materias)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Cargar
            // 
            this.Btn_Cargar.Location = new System.Drawing.Point(508, 356);
            this.Btn_Cargar.Name = "Btn_Cargar";
            this.Btn_Cargar.Size = new System.Drawing.Size(75, 32);
            this.Btn_Cargar.TabIndex = 34;
            this.Btn_Cargar.Text = "Cargar";
            this.Btn_Cargar.UseVisualStyleBackColor = true;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(206, 293);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(75, 32);
            this.Btn_Guardar.TabIndex = 33;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // Dgv_Materias
            // 
            this.Dgv_Materias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Materias.Location = new System.Drawing.Point(395, 54);
            this.Dgv_Materias.Name = "Dgv_Materias";
            this.Dgv_Materias.RowTemplate.Height = 25;
            this.Dgv_Materias.Size = new System.Drawing.Size(557, 271);
            this.Dgv_Materias.TabIndex = 32;
            // 
            // Checkbox_Estado
            // 
            this.Checkbox_Estado.AutoSize = true;
            this.Checkbox_Estado.Location = new System.Drawing.Point(206, 260);
            this.Checkbox_Estado.Name = "Checkbox_Estado";
            this.Checkbox_Estado.Size = new System.Drawing.Size(15, 14);
            this.Checkbox_Estado.TabIndex = 31;
            this.Checkbox_Estado.UseVisualStyleBackColor = true;
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Txt_Codigo.Location = new System.Drawing.Point(206, 207);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(100, 26);
            this.Txt_Codigo.TabIndex = 28;
            // 
            // Txt_Legajo
            // 
            this.Txt_Legajo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Txt_Legajo.Location = new System.Drawing.Point(206, 159);
            this.Txt_Legajo.Name = "Txt_Legajo";
            this.Txt_Legajo.Size = new System.Drawing.Size(100, 26);
            this.Txt_Legajo.TabIndex = 27;
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Txt_Nombre.Location = new System.Drawing.Point(206, 58);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(100, 26);
            this.Txt_Nombre.TabIndex = 26;
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Estado.Location = new System.Drawing.Point(115, 254);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(73, 20);
            this.Lbl_Estado.TabIndex = 24;
            this.Lbl_Estado.Text = "Estado:";
            // 
            // Lbl_Codigo
            // 
            this.Lbl_Codigo.AutoSize = true;
            this.Lbl_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Codigo.Location = new System.Drawing.Point(115, 209);
            this.Lbl_Codigo.Name = "Lbl_Codigo";
            this.Lbl_Codigo.Size = new System.Drawing.Size(73, 20);
            this.Lbl_Codigo.TabIndex = 22;
            this.Lbl_Codigo.Text = "Codigo:";
            // 
            // Lbl_Legajo
            // 
            this.Lbl_Legajo.AutoSize = true;
            this.Lbl_Legajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Legajo.Location = new System.Drawing.Point(41, 159);
            this.Lbl_Legajo.Name = "Lbl_Legajo";
            this.Lbl_Legajo.Size = new System.Drawing.Size(149, 20);
            this.Lbl_Legajo.TabIndex = 21;
            this.Lbl_Legajo.Text = "Legajo Profesor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(-92, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Dni:";
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Nombre.Location = new System.Drawing.Point(108, 60);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(80, 20);
            this.Lbl_Nombre.TabIndex = 18;
            this.Lbl_Nombre.Text = "Nombre:";
            // 
            // Btn_Atras
            // 
            this.Btn_Atras.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Atras.Location = new System.Drawing.Point(813, 12);
            this.Btn_Atras.Name = "Btn_Atras";
            this.Btn_Atras.Size = new System.Drawing.Size(86, 32);
            this.Btn_Atras.TabIndex = 35;
            this.Btn_Atras.Text = "Atras";
            this.Btn_Atras.UseVisualStyleBackColor = true;
            // 
            // Lbl_Cruz
            // 
            this.Lbl_Cruz.AutoSize = true;
            this.Lbl_Cruz.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Cruz.Location = new System.Drawing.Point(920, 12);
            this.Lbl_Cruz.Name = "Lbl_Cruz";
            this.Lbl_Cruz.Size = new System.Drawing.Size(32, 32);
            this.Lbl_Cruz.TabIndex = 36;
            this.Lbl_Cruz.Text = "X";
            // 
            // Btn_Llenar
            // 
            this.Btn_Llenar.Location = new System.Drawing.Point(628, 356);
            this.Btn_Llenar.Name = "Btn_Llenar";
            this.Btn_Llenar.Size = new System.Drawing.Size(75, 32);
            this.Btn_Llenar.TabIndex = 37;
            this.Btn_Llenar.Text = "Llenar";
            this.Btn_Llenar.UseVisualStyleBackColor = true;
            // 
            // Btn_Alegajo
            // 
            this.Btn_Alegajo.Location = new System.Drawing.Point(673, 418);
            this.Btn_Alegajo.Name = "Btn_Alegajo";
            this.Btn_Alegajo.Size = new System.Drawing.Size(111, 26);
            this.Btn_Alegajo.TabIndex = 38;
            this.Btn_Alegajo.Text = "Actualizar legajo";
            this.Btn_Alegajo.UseVisualStyleBackColor = true;
            // 
            // Txt_Alegajo
            // 
            this.Txt_Alegajo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Txt_Alegajo.Location = new System.Drawing.Point(508, 418);
            this.Txt_Alegajo.Name = "Txt_Alegajo";
            this.Txt_Alegajo.Size = new System.Drawing.Size(142, 26);
            this.Txt_Alegajo.TabIndex = 39;
            // 
            // Btn_Borrar
            // 
            this.Btn_Borrar.Location = new System.Drawing.Point(733, 356);
            this.Btn_Borrar.Name = "Btn_Borrar";
            this.Btn_Borrar.Size = new System.Drawing.Size(75, 32);
            this.Btn_Borrar.TabIndex = 40;
            this.Btn_Borrar.Text = "Borrar";
            this.Btn_Borrar.UseVisualStyleBackColor = true;
            // 
            // Lbl_Apellido
            // 
            this.Lbl_Apellido.AutoSize = true;
            this.Lbl_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Apellido.Location = new System.Drawing.Point(108, 112);
            this.Lbl_Apellido.Name = "Lbl_Apellido";
            this.Lbl_Apellido.Size = new System.Drawing.Size(82, 20);
            this.Lbl_Apellido.TabIndex = 41;
            this.Lbl_Apellido.Text = "Apellido:";
            // 
            // Txt_Apellido
            // 
            this.Txt_Apellido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Txt_Apellido.Location = new System.Drawing.Point(206, 110);
            this.Txt_Apellido.Name = "Txt_Apellido";
            this.Txt_Apellido.Size = new System.Drawing.Size(100, 26);
            this.Txt_Apellido.TabIndex = 42;
            // 
            // FormMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(997, 464);
            this.Controls.Add(this.Txt_Apellido);
            this.Controls.Add(this.Lbl_Apellido);
            this.Controls.Add(this.Btn_Borrar);
            this.Controls.Add(this.Txt_Alegajo);
            this.Controls.Add(this.Btn_Alegajo);
            this.Controls.Add(this.Btn_Llenar);
            this.Controls.Add(this.Lbl_Cruz);
            this.Controls.Add(this.Btn_Atras);
            this.Controls.Add(this.Btn_Cargar);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Dgv_Materias);
            this.Controls.Add(this.Checkbox_Estado);
            this.Controls.Add(this.Txt_Codigo);
            this.Controls.Add(this.Txt_Legajo);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.Lbl_Estado);
            this.Controls.Add(this.Lbl_Codigo);
            this.Controls.Add(this.Lbl_Legajo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lbl_Nombre);
            this.Name = "FormMateria";
            this.Text = "Materias";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Materias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Btn_Cargar;
        private Button Btn_Guardar;
        private DataGridView Dgv_Materias;
        private CheckBox Checkbox_Estado;
        private TextBox Txt_Codigo;
        private TextBox Txt_Legajo;
        private TextBox Txt_Nombre;
        private Label Lbl_Estado;
        private Label Lbl_Codigo;
        private Label Lbl_Legajo;
        private Label label4;
        private Label Lbl_Nombre;
        private Button Btn_Atras;
        private Label Lbl_Cruz;
        private Button Btn_Llenar;
        private Button Btn_Alegajo;
        private TextBox Txt_Alegajo;
        private Button Btn_Borrar;
        private Label Lbl_Apellido;
        private TextBox Txt_Apellido;
    }
}