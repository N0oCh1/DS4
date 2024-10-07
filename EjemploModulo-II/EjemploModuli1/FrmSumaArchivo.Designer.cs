namespace EjemploModuli1
{
    partial class FrmSumaArchivo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtRestM1 = new System.Windows.Forms.TextBox();
            this.TxtRestM2 = new System.Windows.Forms.TextBox();
            this.BtnEje1 = new System.Windows.Forms.Button();
            this.BtnEje2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suma de numeros desde un archivo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnEje2);
            this.panel1.Controls.Add(this.BtnEje1);
            this.panel1.Controls.Add(this.TxtRestM2);
            this.panel1.Controls.Add(this.TxtRestM1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(186, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 335);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resultado M1:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Resultado M2:";
            // 
            // TxtRestM1
            // 
            this.TxtRestM1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRestM1.Location = new System.Drawing.Point(249, 74);
            this.TxtRestM1.Name = "TxtRestM1";
            this.TxtRestM1.ReadOnly = true;
            this.TxtRestM1.Size = new System.Drawing.Size(271, 30);
            this.TxtRestM1.TabIndex = 4;
            this.TxtRestM1.TextChanged += new System.EventHandler(this.TxtRestM1_TextChanged);
            // 
            // TxtRestM2
            // 
            this.TxtRestM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRestM2.Location = new System.Drawing.Point(249, 116);
            this.TxtRestM2.Name = "TxtRestM2";
            this.TxtRestM2.ReadOnly = true;
            this.TxtRestM2.Size = new System.Drawing.Size(271, 30);
            this.TxtRestM2.TabIndex = 5;
            this.TxtRestM2.TextChanged += new System.EventHandler(this.TxtRestM2_TextChanged);
            // 
            // BtnEje1
            // 
            this.BtnEje1.AutoSize = true;
            this.BtnEje1.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnEje1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEje1.Location = new System.Drawing.Point(146, 219);
            this.BtnEje1.Name = "BtnEje1";
            this.BtnEje1.Padding = new System.Windows.Forms.Padding(6);
            this.BtnEje1.Size = new System.Drawing.Size(149, 47);
            this.BtnEje1.TabIndex = 6;
            this.BtnEje1.Text = "Ejecutar M1";
            this.BtnEje1.UseVisualStyleBackColor = false;
            this.BtnEje1.Click += new System.EventHandler(this.BtnEje1_Click);
            // 
            // BtnEje2
            // 
            this.BtnEje2.AutoSize = true;
            this.BtnEje2.BackColor = System.Drawing.Color.Chartreuse;
            this.BtnEje2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEje2.Location = new System.Drawing.Point(371, 219);
            this.BtnEje2.Name = "BtnEje2";
            this.BtnEje2.Padding = new System.Windows.Forms.Padding(6);
            this.BtnEje2.Size = new System.Drawing.Size(155, 47);
            this.BtnEje2.TabIndex = 7;
            this.BtnEje2.Text = "Ejecutar  M2";
            this.BtnEje2.UseVisualStyleBackColor = false;
            this.BtnEje2.Click += new System.EventHandler(this.BtnEje2_Click);
            // 
            // FrmSumaArchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1011, 608);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSumaArchivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtRestM2;
        private System.Windows.Forms.TextBox TxtRestM1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnEje2;
        private System.Windows.Forms.Button BtnEje1;
    }
}