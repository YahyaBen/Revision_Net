namespace Revision
{
    partial class GestionMatieres
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
            this.Btn_Matiere_Ajouter = new System.Windows.Forms.Button();
            this.Btn_Matiere_Modifier = new System.Windows.Forms.Button();
            this.Btn_Matiere_Supprimer = new System.Windows.Forms.Button();
            this.Txt_Matiere_ID = new System.Windows.Forms.TextBox();
            this.Txt_Matiere_Libelle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Ajouts = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_Matiere_Libelleaction = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Matiere_IDaction = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Ajouts.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Matiere_Ajouter
            // 
            this.Btn_Matiere_Ajouter.Location = new System.Drawing.Point(311, 19);
            this.Btn_Matiere_Ajouter.Name = "Btn_Matiere_Ajouter";
            this.Btn_Matiere_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Btn_Matiere_Ajouter.TabIndex = 0;
            this.Btn_Matiere_Ajouter.Text = "Ajouter";
            this.Btn_Matiere_Ajouter.UseVisualStyleBackColor = true;
            this.Btn_Matiere_Ajouter.Click += new System.EventHandler(this.Btn_Matiere_Ajouter_Click);
            // 
            // Btn_Matiere_Modifier
            // 
            this.Btn_Matiere_Modifier.Location = new System.Drawing.Point(311, 17);
            this.Btn_Matiere_Modifier.Name = "Btn_Matiere_Modifier";
            this.Btn_Matiere_Modifier.Size = new System.Drawing.Size(75, 23);
            this.Btn_Matiere_Modifier.TabIndex = 1;
            this.Btn_Matiere_Modifier.Text = "Modifier";
            this.Btn_Matiere_Modifier.UseVisualStyleBackColor = true;
            this.Btn_Matiere_Modifier.Click += new System.EventHandler(this.Btn_Matiere_Modifier_Click);
            // 
            // Btn_Matiere_Supprimer
            // 
            this.Btn_Matiere_Supprimer.Location = new System.Drawing.Point(311, 43);
            this.Btn_Matiere_Supprimer.Name = "Btn_Matiere_Supprimer";
            this.Btn_Matiere_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.Btn_Matiere_Supprimer.TabIndex = 2;
            this.Btn_Matiere_Supprimer.Text = "Supprimer";
            this.Btn_Matiere_Supprimer.UseVisualStyleBackColor = true;
            this.Btn_Matiere_Supprimer.Click += new System.EventHandler(this.Btn_Matiere_Supprimer_Click);
            // 
            // Txt_Matiere_ID
            // 
            this.Txt_Matiere_ID.Enabled = false;
            this.Txt_Matiere_ID.Location = new System.Drawing.Point(115, 12);
            this.Txt_Matiere_ID.Name = "Txt_Matiere_ID";
            this.Txt_Matiere_ID.Size = new System.Drawing.Size(137, 20);
            this.Txt_Matiere_ID.TabIndex = 3;
            // 
            // Txt_Matiere_Libelle
            // 
            this.Txt_Matiere_Libelle.Location = new System.Drawing.Point(115, 38);
            this.Txt_Matiere_Libelle.Name = "Txt_Matiere_Libelle";
            this.Txt_Matiere_Libelle.Size = new System.Drawing.Size(137, 20);
            this.Txt_Matiere_Libelle.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID Matiere :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Libelle :";
            // 
            // Ajouts
            // 
            this.Ajouts.Controls.Add(this.Txt_Matiere_ID);
            this.Ajouts.Controls.Add(this.label2);
            this.Ajouts.Controls.Add(this.Btn_Matiere_Ajouter);
            this.Ajouts.Controls.Add(this.label1);
            this.Ajouts.Controls.Add(this.Txt_Matiere_Libelle);
            this.Ajouts.Location = new System.Drawing.Point(12, 12);
            this.Ajouts.Name = "Ajouts";
            this.Ajouts.Size = new System.Drawing.Size(417, 74);
            this.Ajouts.TabIndex = 8;
            this.Ajouts.TabStop = false;
            this.Ajouts.Text = "Ajouts";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Txt_Matiere_IDaction);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Txt_Matiere_Libelleaction);
            this.groupBox1.Controls.Add(this.Btn_Matiere_Supprimer);
            this.groupBox1.Controls.Add(this.Btn_Matiere_Modifier);
            this.groupBox1.Location = new System.Drawing.Point(12, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 87);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // Txt_Matiere_Libelleaction
            // 
            this.Txt_Matiere_Libelleaction.Location = new System.Drawing.Point(115, 46);
            this.Txt_Matiere_Libelleaction.Name = "Txt_Matiere_Libelleaction";
            this.Txt_Matiere_Libelleaction.Size = new System.Drawing.Size(137, 20);
            this.Txt_Matiere_Libelleaction.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID :";
            // 
            // Txt_Matiere_IDaction
            // 
            this.Txt_Matiere_IDaction.Location = new System.Drawing.Point(115, 20);
            this.Txt_Matiere_IDaction.Name = "Txt_Matiere_IDaction";
            this.Txt_Matiere_IDaction.Size = new System.Drawing.Size(137, 20);
            this.Txt_Matiere_IDaction.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nouveau Libelle :";
            // 
            // GestionMatieres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 191);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Ajouts);
            this.Name = "GestionMatieres";
            this.Text = "Gestion Matieres";
            this.Ajouts.ResumeLayout(false);
            this.Ajouts.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Matiere_Ajouter;
        private System.Windows.Forms.Button Btn_Matiere_Modifier;
        private System.Windows.Forms.Button Btn_Matiere_Supprimer;
        private System.Windows.Forms.TextBox Txt_Matiere_ID;
        private System.Windows.Forms.TextBox Txt_Matiere_Libelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Ajouts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Matiere_IDaction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Matiere_Libelleaction;
    }
}

