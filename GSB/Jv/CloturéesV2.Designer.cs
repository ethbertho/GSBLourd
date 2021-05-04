namespace Jv
{
    partial class CloturéesV2
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.listBoxC = new System.Windows.Forms.ListBox();
            this.ListeBoxFrais = new System.Windows.Forms.ComboBox();
            this.btn_modif = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHF = new System.Windows.Forms.TextBox();
            this.cmbBoxHF = new System.Windows.Forms.ComboBox();
            this.btnValidHF = new System.Windows.Forms.Button();
            this.btnModifHF = new System.Windows.Forms.Button();
            this.btnSuprHF = new System.Windows.Forms.Button();
            this.txtBoxLibelle = new System.Windows.Forms.TextBox();
            this.txtBoxLibHF = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(155, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fiche de frais cloturées";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(534, 472);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "Retour";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxC
            // 
            this.listBoxC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxC.FormattingEnabled = true;
            this.listBoxC.ItemHeight = 16;
            this.listBoxC.Location = new System.Drawing.Point(21, 121);
            this.listBoxC.Name = "listBoxC";
            this.listBoxC.Size = new System.Drawing.Size(252, 324);
            this.listBoxC.TabIndex = 4;
            this.listBoxC.SelectedIndexChanged += new System.EventHandler(this.listBoxC_SelectedIndexChanged);
            // 
            // ListeBoxFrais
            // 
            this.ListeBoxFrais.FormattingEnabled = true;
            this.ListeBoxFrais.Location = new System.Drawing.Point(406, 121);
            this.ListeBoxFrais.Name = "ListeBoxFrais";
            this.ListeBoxFrais.Size = new System.Drawing.Size(44, 21);
            this.ListeBoxFrais.TabIndex = 5;
            this.ListeBoxFrais.SelectedIndexChanged += new System.EventHandler(this.ListeBoxFrais_SelectedIndexChanged);
            // 
            // btn_modif
            // 
            this.btn_modif.Location = new System.Drawing.Point(462, 222);
            this.btn_modif.Name = "btn_modif";
            this.btn_modif.Size = new System.Drawing.Size(75, 23);
            this.btn_modif.TabIndex = 6;
            this.btn_modif.Text = "Modifier";
            this.btn_modif.UseVisualStyleBackColor = true;
            this.btn_modif.Click += new System.EventHandler(this.btn_modif_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(108, 472);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 7;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(406, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Numéro Forfait :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Quantité :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Numéro Hors-Forfait :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Montant Hors-Forfait :";
            // 
            // txtHF
            // 
            this.txtHF.Location = new System.Drawing.Point(406, 333);
            this.txtHF.Name = "txtHF";
            this.txtHF.Size = new System.Drawing.Size(185, 20);
            this.txtHF.TabIndex = 13;
            // 
            // cmbBoxHF
            // 
            this.cmbBoxHF.FormattingEnabled = true;
            this.cmbBoxHF.Location = new System.Drawing.Point(406, 289);
            this.cmbBoxHF.Name = "cmbBoxHF";
            this.cmbBoxHF.Size = new System.Drawing.Size(44, 21);
            this.cmbBoxHF.TabIndex = 14;
            this.cmbBoxHF.SelectedIndexChanged += new System.EventHandler(this.cmbBoxHF_SelectedIndexChanged);
            // 
            // btnValidHF
            // 
            this.btnValidHF.Location = new System.Drawing.Point(354, 376);
            this.btnValidHF.Name = "btnValidHF";
            this.btnValidHF.Size = new System.Drawing.Size(75, 23);
            this.btnValidHF.TabIndex = 15;
            this.btnValidHF.Text = "Valider";
            this.btnValidHF.UseVisualStyleBackColor = true;
            this.btnValidHF.Click += new System.EventHandler(this.btnValidHF_Click);
            // 
            // btnModifHF
            // 
            this.btnModifHF.Location = new System.Drawing.Point(435, 376);
            this.btnModifHF.Name = "btnModifHF";
            this.btnModifHF.Size = new System.Drawing.Size(75, 23);
            this.btnModifHF.TabIndex = 16;
            this.btnModifHF.Text = "Modifier";
            this.btnModifHF.UseVisualStyleBackColor = true;
            this.btnModifHF.Click += new System.EventHandler(this.btnModifHF_Click);
            // 
            // btnSuprHF
            // 
            this.btnSuprHF.Location = new System.Drawing.Point(516, 376);
            this.btnSuprHF.Name = "btnSuprHF";
            this.btnSuprHF.Size = new System.Drawing.Size(75, 23);
            this.btnSuprHF.TabIndex = 17;
            this.btnSuprHF.Text = "Supprimer";
            this.btnSuprHF.UseVisualStyleBackColor = true;
            this.btnSuprHF.Click += new System.EventHandler(this.btnSuprHF_Click);
            // 
            // txtBoxLibelle
            // 
            this.txtBoxLibelle.Location = new System.Drawing.Point(462, 122);
            this.txtBoxLibelle.Name = "txtBoxLibelle";
            this.txtBoxLibelle.ReadOnly = true;
            this.txtBoxLibelle.Size = new System.Drawing.Size(127, 20);
            this.txtBoxLibelle.TabIndex = 18;
            // 
            // txtBoxLibHF
            // 
            this.txtBoxLibHF.Location = new System.Drawing.Point(462, 290);
            this.txtBoxLibHF.Name = "txtBoxLibHF";
            this.txtBoxLibHF.ReadOnly = true;
            this.txtBoxLibHF.Size = new System.Drawing.Size(127, 20);
            this.txtBoxLibHF.TabIndex = 19;
            this.txtBoxLibHF.TextChanged += new System.EventHandler(this.txtBoxLibHF_TextChanged);
            // 
            // CloturéesV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(621, 507);
            this.Controls.Add(this.txtBoxLibHF);
            this.Controls.Add(this.txtBoxLibelle);
            this.Controls.Add(this.btnSuprHF);
            this.Controls.Add(this.btnModifHF);
            this.Controls.Add(this.btnValidHF);
            this.Controls.Add(this.cmbBoxHF);
            this.Controls.Add(this.txtHF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btn_modif);
            this.Controls.Add(this.ListeBoxFrais);
            this.Controls.Add(this.listBoxC);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label1);
            this.Name = "CloturéesV2";
            this.Text = "Cloturées";
            this.Load += new System.EventHandler(this.CloturéesV2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       
       
        private System.Windows.Forms.Label label1;
        
                
        private System.Windows.Forms.Button btn_back;        
        private System.Windows.Forms.ListBox listBoxC;
        private System.Windows.Forms.ComboBox ListeBoxFrais;
        private System.Windows.Forms.Button btn_modif;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHF;
        private System.Windows.Forms.ComboBox cmbBoxHF;
        private System.Windows.Forms.Button btnValidHF;
        private System.Windows.Forms.Button btnModifHF;
        private System.Windows.Forms.Button btnSuprHF;
        private System.Windows.Forms.TextBox txtBoxLibelle;
        private System.Windows.Forms.TextBox txtBoxLibHF;
    }
}