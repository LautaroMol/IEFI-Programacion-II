namespace IEFI_Programación_II.FormProfesor
{
    partial class FormProfe
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            label3 = new Label();
            label7 = new Label();
            txtleg = new TextBox();
            txtDni = new TextBox();
            txtNom = new TextBox();
            txtAp = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            checkBox1 = new CheckBox();
            dataGridView1 = new DataGridView();
            btnGuardar = new Button();
            btnCargar = new Button();
            btnllenar = new Button();
            btnborrar = new Button();
            txtMod = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 73);
            label1.Name = "label1";
            label1.Size = new Size(67, 19);
            label1.TabIndex = 0;
            label1.Text = "Legajo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1100, -1);
            label2.Name = "label2";
            label2.Size = new Size(32, 32);
            label2.TabIndex = 1;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(33, 123);
            label4.Name = "label4";
            label4.Size = new Size(41, 19);
            label4.TabIndex = 3;
            label4.Text = "Dni:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(33, 179);
            label5.Name = "label5";
            label5.Size = new Size(85, 19);
            label5.TabIndex = 4;
            label5.Text = "Nombres:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(33, 234);
            label6.Name = "label6";
            label6.Size = new Size(86, 19);
            label6.TabIndex = 5;
            label6.Text = "Apellidos:";
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(984, -1);
            button1.Name = "button1";
            button1.Size = new Size(86, 32);
            button1.TabIndex = 6;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(32, 281);
            label3.Name = "label3";
            label3.Size = new Size(67, 19);
            label3.TabIndex = 7;
            label3.Text = "Activo?";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(33, 335);
            label7.Name = "label7";
            label7.Size = new Size(175, 19);
            label7.TabIndex = 8;
            label7.Text = "Fecha de Nacimiento:";
            // 
            // txtleg
            // 
            txtleg.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtleg.Location = new Point(270, 69);
            txtleg.Name = "txtleg";
            txtleg.Size = new Size(100, 26);
            txtleg.TabIndex = 9;
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtDni.Location = new Point(270, 120);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(100, 26);
            txtDni.TabIndex = 10;
            // 
            // txtNom
            // 
            txtNom.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtNom.Location = new Point(270, 176);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(263, 26);
            txtNom.TabIndex = 11;
            // 
            // txtAp
            // 
            txtAp.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtAp.Location = new Point(270, 231);
            txtAp.Name = "txtAp";
            txtAp.Size = new Size(263, 26);
            txtAp.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(255, 335);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(260, 23);
            dateTimePicker1.TabIndex = 13;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(270, 283);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 14;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(566, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(549, 339);
            dataGridView1.TabIndex = 15;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(44, 444);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(322, 444);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(75, 23);
            btnCargar.TabIndex = 17;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnllenar
            // 
            btnllenar.Location = new Point(413, 444);
            btnllenar.Name = "btnllenar";
            btnllenar.Size = new Size(75, 23);
            btnllenar.TabIndex = 18;
            btnllenar.Text = "Llenar";
            btnllenar.UseVisualStyleBackColor = true;
            btnllenar.Click += btnllenar_Click;
            // 
            // btnborrar
            // 
            btnborrar.Location = new Point(508, 444);
            btnborrar.Name = "btnborrar";
            btnborrar.Size = new Size(75, 23);
            btnborrar.TabIndex = 19;
            btnborrar.Text = "Borrar";
            btnborrar.UseVisualStyleBackColor = true;
            btnborrar.Click += btnborrar_Click;
            // 
            // txtMod
            // 
            txtMod.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtMod.Location = new Point(255, 479);
            txtMod.Name = "txtMod";
            txtMod.Size = new Size(142, 26);
            txtMod.TabIndex = 20;
            // 
            // button2
            // 
            button2.Location = new Point(413, 479);
            button2.Name = "button2";
            button2.Size = new Size(132, 23);
            button2.TabIndex = 21;
            button2.Text = "Actualizar legajo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormProfe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1127, 517);
            ControlBox = false;
            Controls.Add(button2);
            Controls.Add(txtMod);
            Controls.Add(btnborrar);
            Controls.Add(btnllenar);
            Controls.Add(btnCargar);
            Controls.Add(btnGuardar);
            Controls.Add(dataGridView1);
            Controls.Add(checkBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtAp);
            Controls.Add(txtNom);
            Controls.Add(txtDni);
            Controls.Add(txtleg);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormProfe";
            Text = "FormProfesor";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Label label3;
        private Label label7;
        private TextBox txtleg;
        private TextBox txtDni;
        private TextBox txtNom;
        private TextBox txtAp;
        private DateTimePicker dateTimePicker1;
        private CheckBox checkBox1;
        private DataGridView dataGridView1;
        private Button btnGuardar;
        private Button btnCargar;
        private Button btnllenar;
        private Button btnborrar;
        private TextBox txtMod;
        private Button button2;
    }
}