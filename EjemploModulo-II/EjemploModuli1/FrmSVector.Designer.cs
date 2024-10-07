namespace EjemploModuli1
{
    partial class FrmSumaVec
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
            this.btnCalcu = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcu
            // 
            this.btnCalcu.AutoSize = true;
            this.btnCalcu.Location = new System.Drawing.Point(351, 362);
            this.btnCalcu.Name = "btnCalcu";
            this.btnCalcu.Padding = new System.Windows.Forms.Padding(10);
            this.btnCalcu.Size = new System.Drawing.Size(86, 46);
            this.btnCalcu.TabIndex = 13;
            this.btnCalcu.Text = "Calcular";
            this.btnCalcu.UseVisualStyleBackColor = true;
            this.btnCalcu.Click += new System.EventHandler(this.btnCalcu_Click);
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(395, 115);
            this.txtNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(136, 41);
            this.txtNum.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cantidad de numero a ingresar: ";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(241, 175);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(318, 164);
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "Suma vector";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmSumaVec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcu);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmSumaVec";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcu;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}