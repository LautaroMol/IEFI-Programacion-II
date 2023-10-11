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
            SuspendLayout();
            // 
            // btnMat
            // 
            btnMat.Location = new Point(104, 75);
            btnMat.Name = "btnMat";
            btnMat.Size = new Size(129, 81);
            btnMat.TabIndex = 0;
            btnMat.Text = "Abm Materias";
            btnMat.UseVisualStyleBackColor = true;
            // 
            // btnProf
            // 
            btnProf.Location = new Point(104, 258);
            btnProf.Name = "btnProf";
            btnProf.Size = new Size(129, 83);
            btnProf.TabIndex = 1;
            btnProf.Text = "Abm Profesores";
            btnProf.UseVisualStyleBackColor = true;
            btnProf.Click += btnProf_Click;
            // 
            // FormInstituto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 450);
            Controls.Add(btnProf);
            Controls.Add(btnMat);
            Name = "FormInstituto";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMat;
        private Button btnProf;
    }
}