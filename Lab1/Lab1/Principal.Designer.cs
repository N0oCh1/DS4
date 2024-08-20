namespace Lab1
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEnun1 = new System.Windows.Forms.Button();
            this.btnEnun2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel1.Controls.Add(this.btnEnun1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnEnun2, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(45, 157);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(770, 268);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnEnun1
            // 
            this.btnEnun1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEnun1.AutoSize = true;
            this.btnEnun1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnEnun1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnun1.Location = new System.Drawing.Point(207, 97);
            this.btnEnun1.Name = "btnEnun1";
            this.btnEnun1.Size = new System.Drawing.Size(158, 72);
            this.btnEnun1.TabIndex = 0;
            this.btnEnun1.Text = "Enunciado #1";
            this.btnEnun1.UseVisualStyleBackColor = true;
            this.btnEnun1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEnun2
            // 
            this.btnEnun2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEnun2.AutoSize = true;
            this.btnEnun2.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEnun2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEnun2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnun2.Location = new System.Drawing.Point(403, 97);
            this.btnEnun2.Name = "btnEnun2";
            this.btnEnun2.Size = new System.Drawing.Size(154, 72);
            this.btnEnun2.TabIndex = 1;
            this.btnEnun2.Text = "Enunciado #2";
            this.btnEnun2.UseVisualStyleBackColor = true;
            this.btnEnun2.Click += new System.EventHandler(this.btnEnun2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(308, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Laboratorio #1";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(858, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Princial";
            //this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnEnun1;
        private System.Windows.Forms.Button btnEnun2;
        private System.Windows.Forms.Label label1;
    }
}

