namespace EjemploModuli1
{
    partial class Frmfactorial
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Factorial";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(237, 182);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(318, 164);
            this.listBox1.TabIndex = 5;
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(391, 122);
            this.txtNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(136, 41);
            this.txtNum.TabIndex = 7;
            this.txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "Numero: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCalcu
            // 
            this.btnCalcu.AutoSize = true;
            this.btnCalcu.Location = new System.Drawing.Point(347, 369);
            this.btnCalcu.Name = "btnCalcu";
            this.btnCalcu.Padding = new System.Windows.Forms.Padding(10);
            this.btnCalcu.Size = new System.Drawing.Size(86, 46);
            this.btnCalcu.TabIndex = 8;
            this.btnCalcu.Text = "Calcular";
            this.btnCalcu.UseVisualStyleBackColor = true;
            this.btnCalcu.Click += new System.EventHandler(this.btnCalcu_Click);
            // 
            // Frmfactorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcu);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "Frmfactorial";
            this.Text = "Factorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcu;
    }
}