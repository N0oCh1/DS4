namespace Lab3
{
    partial class frmEnunciado3
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
            this.grpVentas = new System.Windows.Forms.GroupBox();
            this.btnClasificar = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nupCantVentas = new System.Windows.Forms.NumericUpDown();
            this.dgvOrdenado = new System.Windows.Forms.DataGridView();
            this.dgvMontosVentas = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvClasif = new System.Windows.Forms.DataGridView();
            this.grpVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMontosVentas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasif)).BeginInit();
            this.SuspendLayout();
            // 
            // grpVentas
            // 
            this.grpVentas.Controls.Add(this.btnClasificar);
            this.grpVentas.Controls.Add(this.btnOrdenar);
            this.grpVentas.Controls.Add(this.label1);
            this.grpVentas.Controls.Add(this.nupCantVentas);
            this.grpVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVentas.Location = new System.Drawing.Point(24, 24);
            this.grpVentas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpVentas.Name = "grpVentas";
            this.grpVentas.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpVentas.Size = new System.Drawing.Size(186, 360);
            this.grpVentas.TabIndex = 0;
            this.grpVentas.TabStop = false;
            this.grpVentas.Text = "Datos de Ventas";
            // 
            // btnClasificar
            // 
            this.btnClasificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClasificar.Location = new System.Drawing.Point(13, 158);
            this.btnClasificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClasificar.Name = "btnClasificar";
            this.btnClasificar.Size = new System.Drawing.Size(159, 25);
            this.btnClasificar.TabIndex = 9;
            this.btnClasificar.Text = "Clasificar";
            this.btnClasificar.UseVisualStyleBackColor = true;
            this.btnClasificar.Click += new System.EventHandler(this.btnClasificar_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.Location = new System.Drawing.Point(13, 118);
            this.btnOrdenar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(159, 25);
            this.btnOrdenar.TabIndex = 8;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cantidad de Ventas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nupCantVentas
            // 
            this.nupCantVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupCantVentas.Location = new System.Drawing.Point(13, 70);
            this.nupCantVentas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nupCantVentas.Name = "nupCantVentas";
            this.nupCantVentas.Size = new System.Drawing.Size(159, 26);
            this.nupCantVentas.TabIndex = 2;
            this.nupCantVentas.ValueChanged += new System.EventHandler(this.nupCantVentas_ValueChanged_1);
            // 
            // dgvOrdenado
            // 
            this.dgvOrdenado.AllowUserToAddRows = false;
            this.dgvOrdenado.AllowUserToDeleteRows = false;
            this.dgvOrdenado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrdenado.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrdenado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenado.Location = new System.Drawing.Point(208, 45);
            this.dgvOrdenado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvOrdenado.Name = "dgvOrdenado";
            this.dgvOrdenado.ReadOnly = true;
            this.dgvOrdenado.RowHeadersWidth = 62;
            this.dgvOrdenado.RowTemplate.Height = 28;
            this.dgvOrdenado.Size = new System.Drawing.Size(170, 306);
            this.dgvOrdenado.TabIndex = 11;
            // 
            // dgvMontosVentas
            // 
            this.dgvMontosVentas.AllowUserToAddRows = false;
            this.dgvMontosVentas.AllowUserToDeleteRows = false;
            this.dgvMontosVentas.AllowUserToResizeColumns = false;
            this.dgvMontosVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMontosVentas.BackgroundColor = System.Drawing.Color.White;
            this.dgvMontosVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMontosVentas.Location = new System.Drawing.Point(16, 45);
            this.dgvMontosVentas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMontosVentas.Name = "dgvMontosVentas";
            this.dgvMontosVentas.RowHeadersWidth = 62;
            this.dgvMontosVentas.RowTemplate.Height = 28;
            this.dgvMontosVentas.Size = new System.Drawing.Size(168, 306);
            this.dgvMontosVentas.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(422, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Entre $50 y $287";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Montos ordenados";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Montos por introducir";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvClasif);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgvOrdenado);
            this.panel1.Controls.Add(this.dgvMontosVentas);
            this.panel1.Location = new System.Drawing.Point(214, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 360);
            this.panel1.TabIndex = 12;
            // 
            // dgvClasif
            // 
            this.dgvClasif.AllowUserToAddRows = false;
            this.dgvClasif.AllowUserToDeleteRows = false;
            this.dgvClasif.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClasif.BackgroundColor = System.Drawing.Color.White;
            this.dgvClasif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasif.Location = new System.Drawing.Point(401, 45);
            this.dgvClasif.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvClasif.Name = "dgvClasif";
            this.dgvClasif.ReadOnly = true;
            this.dgvClasif.RowHeadersWidth = 62;
            this.dgvClasif.RowTemplate.Height = 28;
            this.dgvClasif.Size = new System.Drawing.Size(170, 306);
            this.dgvClasif.TabIndex = 12;
            // 
            // frmEnunciado3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(826, 403);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpVentas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmEnunciado3";
            this.Text = "frmEnunciado3";
            this.grpVentas.ResumeLayout(false);
            this.grpVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMontosVentas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpVentas;
        private System.Windows.Forms.NumericUpDown nupCantVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnClasificar;
        private System.Windows.Forms.DataGridView dgvMontosVentas;
        private System.Windows.Forms.DataGridView dgvOrdenado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvClasif;
    }
}