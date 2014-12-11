namespace ApsMelhorada.View
{
    partial class frmMenu
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
            this.btnCadProf = new System.Windows.Forms.Button();
            this.btnCadAlunos = new System.Windows.Forms.Button();
            this.btnAulas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadProf
            // 
            this.btnCadProf.Location = new System.Drawing.Point(10, 72);
            this.btnCadProf.Name = "btnCadProf";
            this.btnCadProf.Size = new System.Drawing.Size(116, 94);
            this.btnCadProf.TabIndex = 0;
            this.btnCadProf.Text = "Professores";
            this.btnCadProf.UseVisualStyleBackColor = true;
            this.btnCadProf.Click += new System.EventHandler(this.btnCadProf_Click);
            // 
            // btnCadAlunos
            // 
            this.btnCadAlunos.Location = new System.Drawing.Point(147, 72);
            this.btnCadAlunos.Name = "btnCadAlunos";
            this.btnCadAlunos.Size = new System.Drawing.Size(122, 94);
            this.btnCadAlunos.TabIndex = 1;
            this.btnCadAlunos.Text = "Alunos";
            this.btnCadAlunos.UseVisualStyleBackColor = true;
            // 
            // btnAulas
            // 
            this.btnAulas.Location = new System.Drawing.Point(275, 72);
            this.btnAulas.Name = "btnAulas";
            this.btnAulas.Size = new System.Drawing.Size(133, 94);
            this.btnAulas.TabIndex = 2;
            this.btnAulas.Text = "Aulas";
            this.btnAulas.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 262);
            this.Controls.Add(this.btnAulas);
            this.Controls.Add(this.btnCadAlunos);
            this.Controls.Add(this.btnCadProf);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadProf;
        private System.Windows.Forms.Button btnCadAlunos;
        private System.Windows.Forms.Button btnAulas;
    }
}