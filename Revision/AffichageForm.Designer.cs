namespace Revision
{
    partial class AffichageForm
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
            this.DGV = new System.Windows.Forms.DataGridView();
            this.CB_Etudiants = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lab_Resultat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(21, 107);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(467, 150);
            this.DGV.TabIndex = 0;
            // 
            // CB_Etudiants
            // 
            this.CB_Etudiants.FormattingEnabled = true;
            this.CB_Etudiants.Location = new System.Drawing.Point(198, 35);
            this.CB_Etudiants.Name = "CB_Etudiants";
            this.CB_Etudiants.Size = new System.Drawing.Size(137, 21);
            this.CB_Etudiants.TabIndex = 20;
            this.CB_Etudiants.SelectedIndexChanged += new System.EventHandler(this.CB_Etudiants_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID Etudiant :";
            // 
            // Lab_Resultat
            // 
            this.Lab_Resultat.AutoSize = true;
            this.Lab_Resultat.Location = new System.Drawing.Point(198, 81);
            this.Lab_Resultat.Name = "Lab_Resultat";
            this.Lab_Resultat.Size = new System.Drawing.Size(46, 13);
            this.Lab_Resultat.TabIndex = 21;
            this.Lab_Resultat.Text = "Resultat";
            // 
            // AffichageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 288);
            this.Controls.Add(this.Lab_Resultat);
            this.Controls.Add(this.CB_Etudiants);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV);
            this.Name = "AffichageForm";
            this.Text = "AffichageForm";
            this.Load += new System.EventHandler(this.AffichageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.ComboBox CB_Etudiants;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lab_Resultat;
    }
}