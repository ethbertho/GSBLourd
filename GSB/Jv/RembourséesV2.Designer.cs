namespace Jv
{
    partial class RembourséesV2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
           
            this.button1 = new System.Windows.Forms.Button();
            
            this.listBoxR = new System.Windows.Forms.ListBox();
            
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(304, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fiche de frais remboursées";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(951, 510);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fICHE_FRAISTableAdapter
            // 
           
            // 
            // listBoxR
            // 
            this.listBoxR.FormattingEnabled = true;
            this.listBoxR.ItemHeight = 16;
            this.listBoxR.Location = new System.Drawing.Point(248, 98);
            this.listBoxR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxR.Name = "listBoxR";
            this.listBoxR.Size = new System.Drawing.Size(447, 388);
            this.listBoxR.TabIndex = 5;
            this.listBoxR.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // RembourséesV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.listBoxR);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RembourséesV2";
            this.Text = "RembourséesV2";
            this.Load += new System.EventHandler(this.RembourséesV2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
       
              
        private System.Windows.Forms.Button button1;
        
       
        
        private System.Windows.Forms.ListBox listBoxR;
    }
}