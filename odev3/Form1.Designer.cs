namespace odev3
{
    partial class Form1
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
            this.lblSayi1 = new System.Windows.Forms.Label();
            this.lblSayi2 = new System.Windows.Forms.Label();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.btnKarsilastir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSayi1
            // 
            this.lblSayi1.AutoSize = true;
            this.lblSayi1.Location = new System.Drawing.Point(74, 45);
            this.lblSayi1.Name = "lblSayi1";
            this.lblSayi1.Size = new System.Drawing.Size(73, 13);
            this.lblSayi1.TabIndex = 0;
            this.lblSayi1.Text = "1. sayıyı giriniz";
            // 
            // lblSayi2
            // 
            this.lblSayi2.AutoSize = true;
            this.lblSayi2.Location = new System.Drawing.Point(74, 85);
            this.lblSayi2.Name = "lblSayi2";
            this.lblSayi2.Size = new System.Drawing.Size(73, 13);
            this.lblSayi2.TabIndex = 1;
            this.lblSayi2.Text = "2. sayıyı giriniz";
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(168, 42);
            this.txtSayi1.Multiline = true;
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(110, 20);
            this.txtSayi1.TabIndex = 2;
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(168, 82);
            this.txtSayi2.Multiline = true;
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(110, 20);
            this.txtSayi2.TabIndex = 3;
            // 
            // btnKarsilastir
            // 
            this.btnKarsilastir.Location = new System.Drawing.Point(106, 158);
            this.btnKarsilastir.Name = "btnKarsilastir";
            this.btnKarsilastir.Size = new System.Drawing.Size(122, 44);
            this.btnKarsilastir.TabIndex = 4;
            this.btnKarsilastir.Text = "karşılaştır";
            this.btnKarsilastir.UseVisualStyleBackColor = true;
            this.btnKarsilastir.Click += new System.EventHandler(this.btnKarsilastir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 278);
            this.Controls.Add(this.btnKarsilastir);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.lblSayi2);
            this.Controls.Add(this.lblSayi1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSayi1;
        private System.Windows.Forms.Label lblSayi2;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.Button btnKarsilastir;
    }
}

