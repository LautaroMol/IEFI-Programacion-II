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
            Btn_Cargar = new Button();
            Dgv_Materias = new DataGridView();
            Checkbox_Estado = new CheckBox();
            Txt_Codigo = new TextBox();
            Txt_Legajo = new TextBox();
            Txt_Nombre = new TextBox();
            Lbl_Estado = new Label();
            Lbl_Codigo = new Label();
            Lbl_Legajo = new Label();
            label4 = new Label();
            Lbl_Nombre = new Label();
            Btn_Atras = new Button();
            Lbl_Cruz = new Label();
            Btn_Alegajo = new Button();
            Txt_Alegajo = new TextBox();
            Btn_Borrar = new Button();
            ((System.ComponentModel.ISupportInitialize)Dgv_Materias).BeginInit();
            SuspendLayout();
            // 
            // Btn_Cargar
            // 
            Btn_Cargar.Location = new Point(363, 331);
            Btn_Cargar.Name = "Btn_Cargar";
            Btn_Cargar.Size = new Size(75, 32);
            Btn_Cargar.TabIndex = 34;
            Btn_Cargar.Text = "Cargar";
            Btn_Cargar.UseVisualStyleBackColor = true;
            Btn_Cargar.Click += Btn_Cargar_Click;
            // 
            // Dgv_Materias
            // 
            Dgv_Materias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Materias.Location = new Point(353, 54);
            Dgv_Materias.Name = "Dgv_Materias";
            Dgv_Materias.RowTemplate.Height = 25;
            Dgv_Materias.Size = new Size(413, 271);
            Dgv_Materias.TabIndex = 32;
            // 
            // Checkbox_Estado
            // 
            Checkbox_Estado.AutoSize = true;
            Checkbox_Estado.Location = new Point(206, 179);
            Checkbox_Estado.Name = "Checkbox_Estado";
            Checkbox_Estado.Size = new Size(15, 14);
            Checkbox_Estado.TabIndex = 31;
            Checkbox_Estado.UseVisualStyleBackColor = true;
            // 
            // Txt_Codigo
            // 
            Txt_Codigo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Txt_Codigo.Location = new Point(204, 83);
            Txt_Codigo.Name = "Txt_Codigo";
            Txt_Codigo.Size = new Size(100, 26);
            Txt_Codigo.TabIndex = 28;
            // 
            // Txt_Legajo
            // 
            Txt_Legajo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Txt_Legajo.Location = new Point(206, 130);
            Txt_Legajo.Name = "Txt_Legajo";
            Txt_Legajo.Size = new Size(100, 26);
            Txt_Legajo.TabIndex = 27;
            // 
            // Txt_Nombre
            // 
            Txt_Nombre.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Txt_Nombre.Location = new Point(204, 212);
            Txt_Nombre.Name = "Txt_Nombre";
            Txt_Nombre.Size = new Size(100, 26);
            Txt_Nombre.TabIndex = 26;
            // 
            // Lbl_Estado
            // 
            Lbl_Estado.AutoSize = true;
            Lbl_Estado.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Estado.Location = new Point(113, 173);
            Lbl_Estado.Name = "Lbl_Estado";
            Lbl_Estado.Size = new Size(73, 20);
            Lbl_Estado.TabIndex = 24;
            Lbl_Estado.Text = "Estado:";
            // 
            // Lbl_Codigo
            // 
            Lbl_Codigo.AutoSize = true;
            Lbl_Codigo.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Codigo.Location = new Point(113, 85);
            Lbl_Codigo.Name = "Lbl_Codigo";
            Lbl_Codigo.Size = new Size(73, 20);
            Lbl_Codigo.TabIndex = 22;
            Lbl_Codigo.Text = "Codigo:";
            // 
            // Lbl_Legajo
            // 
            Lbl_Legajo.AutoSize = true;
            Lbl_Legajo.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Legajo.Location = new Point(37, 136);
            Lbl_Legajo.Name = "Lbl_Legajo";
            Lbl_Legajo.Size = new Size(149, 20);
            Lbl_Legajo.TabIndex = 21;
            Lbl_Legajo.Text = "Legajo Profesor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(-92, 116);
            label4.Name = "label4";
            label4.Size = new Size(41, 19);
            label4.TabIndex = 20;
            label4.Text = "Dni:";
            // 
            // Lbl_Nombre
            // 
            Lbl_Nombre.AutoSize = true;
            Lbl_Nombre.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Nombre.Location = new Point(106, 212);
            Lbl_Nombre.Name = "Lbl_Nombre";
            Lbl_Nombre.Size = new Size(80, 20);
            Lbl_Nombre.TabIndex = 18;
            Lbl_Nombre.Text = "Nombre:";
            // 
            // Btn_Atras
            // 
            Btn_Atras.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Atras.Location = new Point(632, 12);
            Btn_Atras.Name = "Btn_Atras";
            Btn_Atras.Size = new Size(86, 32);
            Btn_Atras.TabIndex = 35;
            Btn_Atras.Text = "Atras";
            Btn_Atras.UseVisualStyleBackColor = true;
            Btn_Atras.Click += Btn_Atras_Click;
            // 
            // Lbl_Cruz
            // 
            Lbl_Cruz.AutoSize = true;
            Lbl_Cruz.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Cruz.Location = new Point(733, 12);
            Lbl_Cruz.Name = "Lbl_Cruz";
            Lbl_Cruz.Size = new Size(32, 32);
            Lbl_Cruz.TabIndex = 36;
            Lbl_Cruz.Text = "X";
            Lbl_Cruz.Click += Lbl_Cruz_Click;
            // 
            // Btn_Alegajo
            // 
            Btn_Alegajo.Location = new Point(582, 412);
            Btn_Alegajo.Name = "Btn_Alegajo";
            Btn_Alegajo.Size = new Size(111, 26);
            Btn_Alegajo.TabIndex = 38;
            Btn_Alegajo.Text = "Actualizar legajo";
            Btn_Alegajo.UseVisualStyleBackColor = true;
            Btn_Alegajo.Click += Btn_Alegajo_Click;
            // 
            // Txt_Alegajo
            // 
            Txt_Alegajo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Txt_Alegajo.Location = new Point(424, 412);
            Txt_Alegajo.Name = "Txt_Alegajo";
            Txt_Alegajo.Size = new Size(142, 26);
            Txt_Alegajo.TabIndex = 39;
            // 
            // Btn_Borrar
            // 
            Btn_Borrar.Location = new Point(690, 331);
            Btn_Borrar.Name = "Btn_Borrar";
            Btn_Borrar.Size = new Size(75, 32);
            Btn_Borrar.TabIndex = 40;
            Btn_Borrar.Text = "Borrar";
            Btn_Borrar.UseVisualStyleBackColor = true;
            Btn_Borrar.Click += Btn_Borrar_Click;
            // 
            // FormMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(801, 464);
            ControlBox = false;
            Controls.Add(Btn_Borrar);
            Controls.Add(Txt_Alegajo);
            Controls.Add(Btn_Alegajo);
            Controls.Add(Lbl_Cruz);
            Controls.Add(Btn_Atras);
            Controls.Add(Btn_Cargar);
            Controls.Add(Dgv_Materias);
            Controls.Add(Checkbox_Estado);
            Controls.Add(Txt_Codigo);
            Controls.Add(Txt_Legajo);
            Controls.Add(Txt_Nombre);
            Controls.Add(Lbl_Estado);
            Controls.Add(Lbl_Codigo);
            Controls.Add(Lbl_Legajo);
            Controls.Add(label4);
            Controls.Add(Lbl_Nombre);
            Name = "FormMateria";
            Text = "Materias";
            ((System.ComponentModel.ISupportInitialize)Dgv_Materias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Cargar;
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
        private Button Btn_Alegajo;
        private TextBox Txt_Alegajo;
        private Button Btn_Borrar;

    }
}