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
            this.btnMat = new System.Windows.Forms.Button();
            this.btnProf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMat
            // 
            this.btnMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMat.Location = new System.Drawing.Point(104, 75);
            this.btnMat.Name = "btnMat";
            this.btnMat.Size = new System.Drawing.Size(129, 81);
            this.btnMat.TabIndex = 0;
            this.btnMat.Text = "Materias";
            this.btnMat.UseVisualStyleBackColor = true;
            this.btnMat.Click += new System.EventHandler(this.btnMat_Click);
            // 
            // btnProf
            // 
            this.btnProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProf.Location = new System.Drawing.Point(104, 258);
            this.btnProf.Name = "btnProf";
            this.btnProf.Size = new System.Drawing.Size(129, 83);
            this.btnProf.TabIndex = 1;
            this.btnProf.Text = " Profesores";
            this.btnProf.UseVisualStyleBackColor = true;
            this.btnProf.Click += new System.EventHandler(this.btnProf_Click);
            // 
            // FormInstituto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(334, 418);
            this.Controls.Add(this.btnProf);
            this.Controls.Add(this.btnMat);
            this.Name = "FormInstituto";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnMat;
        private Button btnProf;
    }
}