namespace IEFI_Programación_II
{
    partial class FormInstituto
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
            btnMat = new Button();
            btnProf = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnMat
            // 
            btnMat.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnMat.Location = new Point(104, 41);
            btnMat.Name = "btnMat";
            btnMat.Size = new Size(129, 81);
            btnMat.TabIndex = 0;
            btnMat.Text = "Materias";
            btnMat.UseVisualStyleBackColor = true;
            btnMat.Click += btnMat_Click;
            // 
            // btnProf
            // 
            btnProf.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnProf.Location = new Point(104, 169);
            btnProf.Name = "btnProf";
            btnProf.Size = new Size(129, 83);
            btnProf.TabIndex = 1;
            btnProf.Text = " Profesores";
            btnProf.UseVisualStyleBackColor = true;
            btnProf.Click += btnProf_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(104, 312);
            button1.Name = "button1";
            button1.Size = new Size(129, 83);
            button1.TabIndex = 2;
            button1.Text = "Registro Instituto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormInstituto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(334, 418);
            Controls.Add(button1);
            Controls.Add(btnProf);
            Controls.Add(btnMat);
            Name = "FormInstituto";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMat;
        private Button btnProf;
        private Button button1;
    }
}