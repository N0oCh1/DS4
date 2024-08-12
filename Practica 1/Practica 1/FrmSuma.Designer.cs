namespace Practica_1
{
    partial class FrmSuma
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
            this.Num1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Num1TB = new System.Windows.Forms.TextBox();
            this.Num2TB = new System.Windows.Forms.TextBox();
            this.Num2 = new System.Windows.Forms.Label();
            this.Rest = new System.Windows.Forms.Label();
            this.RestTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(336, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suma";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Num1
            // 
            this.Num1.AutoSize = true;
            this.Num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Num1.Location = new System.Drawing.Point(26, 20);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(63, 20);
            this.Num1.TabIndex = 2;
            this.Num1.Text = "Num 1:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.RestTB);
            this.panel1.Controls.Add(this.Rest);
            this.panel1.Controls.Add(this.Num2TB);
            this.panel1.Controls.Add(this.Num2);
            this.panel1.Controls.Add(this.Num1TB);
            this.panel1.Controls.Add(this.Num1);
            this.panel1.Location = new System.Drawing.Point(179, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 344);
            this.panel1.TabIndex = 1;
            // 
            // Num1TB
            // 
            this.Num1TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Num1TB.Location = new System.Drawing.Point(30, 52);
            this.Num1TB.Name = "Num1TB";
            this.Num1TB.Size = new System.Drawing.Size(386, 26);
            this.Num1TB.TabIndex = 3;
            this.Num1TB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Num2TB
            // 
            this.Num2TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Num2TB.Location = new System.Drawing.Point(30, 147);
            this.Num2TB.Name = "Num2TB";
            this.Num2TB.Size = new System.Drawing.Size(386, 26);
            this.Num2TB.TabIndex = 5;
            this.Num2TB.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Num2
            // 
            this.Num2.AutoSize = true;
            this.Num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Num2.Location = new System.Drawing.Point(26, 115);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(63, 20);
            this.Num2.TabIndex = 4;
            this.Num2.Text = "Num 2:";
            this.Num2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Rest
            // 
            this.Rest.AutoSize = true;
            this.Rest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Rest.Location = new System.Drawing.Point(26, 209);
            this.Rest.Name = "Rest";
            this.Rest.Size = new System.Drawing.Size(84, 20);
            this.Rest.TabIndex = 6;
            this.Rest.Text = "Response";
            // 
            // RestTB
            // 
            this.RestTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RestTB.Location = new System.Drawing.Point(30, 232);
            this.RestTB.Name = "RestTB";
            this.RestTB.ReadOnly = true;
            this.RestTB.Size = new System.Drawing.Size(386, 26);
            this.RestTB.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(30, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmSuma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FrmSuma";
            this.Text = "Suma";
            this.Load += new System.EventHandler(this.FrmSuma_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Num1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Num1TB;
        private System.Windows.Forms.TextBox Num2TB;
        private System.Windows.Forms.Label Num2;
        private System.Windows.Forms.Label Rest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox RestTB;
    }
}