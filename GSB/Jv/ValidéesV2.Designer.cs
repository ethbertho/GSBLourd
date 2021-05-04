namespace Jv
{
    partial class ValidéesV2
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxV = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(251, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fiche de frais validées";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxV
            // 
            this.listBoxV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listBoxV.FormattingEnabled = true;
            this.listBoxV.ItemHeight = 16;
            this.listBoxV.Location = new System.Drawing.Point(191, 89);
            this.listBoxV.Name = "listBoxV";
            this.listBoxV.Size = new System.Drawing.Size(394, 324);
            this.listBoxV.TabIndex = 6;
            this.listBoxV.Click += new System.EventHandler(this.listBoxV_SelectedIndexChanged);
            this.listBoxV.SelectedIndexChanged += new System.EventHandler(this.listBoxV_SelectedIndexChanged_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(688, 330);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(619, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Montant";
            // 
            // ValidéesV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBoxV);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "ValidéesV2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ValidéesV2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
              
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        
              
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxV;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}