﻿namespace Lab3
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nupCantVentas = new System.Windows.Forms.NumericUpDown();
            this.lstImportesClasif = new System.Windows.Forms.ListBox();
            this.dgvMontosVentas = new System.Windows.Forms.DataGridView();
            this.dgvOrdenado = new System.Windows.Forms.DataGridView();
            this.grpVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMontosVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenado)).BeginInit();
            this.SuspendLayout();
            // 
            // grpVentas
            // 
            this.grpVentas.Controls.Add(this.dgvOrdenado);
            this.grpVentas.Controls.Add(this.dgvMontosVentas);
            this.grpVentas.Controls.Add(this.btnClasificar);
            this.grpVentas.Controls.Add(this.btnOrdenar);
            this.grpVentas.Controls.Add(this.label4);
            this.grpVentas.Controls.Add(this.label3);
            this.grpVentas.Controls.Add(this.label2);
            this.grpVentas.Controls.Add(this.label1);
            this.grpVentas.Controls.Add(this.nupCantVentas);
            this.grpVentas.Controls.Add(this.lstImportesClasif);
            this.grpVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVentas.Location = new System.Drawing.Point(12, 12);
            this.grpVentas.Name = "grpVentas";
            this.grpVentas.Size = new System.Drawing.Size(1105, 596);
            this.grpVentas.TabIndex = 0;
            this.grpVentas.TabStop = false;
            this.grpVentas.Text = "Datos de Ventas";
            // 
            // btnClasificar
            // 
            this.btnClasificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClasificar.Location = new System.Drawing.Point(20, 243);
            this.btnClasificar.Name = "btnClasificar";
            this.btnClasificar.Size = new System.Drawing.Size(238, 38);
            this.btnClasificar.TabIndex = 9;
            this.btnClasificar.Text = "Clasificar";
            this.btnClasificar.UseVisualStyleBackColor = true;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.Location = new System.Drawing.Point(20, 181);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(238, 38);
            this.btnOrdenar.TabIndex = 8;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(860, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Entre $50 y $287";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(580, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Montos ordenados";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Montos por introducir";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cantidad de Ventas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nupCantVentas
            // 
            this.nupCantVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupCantVentas.Location = new System.Drawing.Point(20, 108);
            this.nupCantVentas.Name = "nupCantVentas";
            this.nupCantVentas.Size = new System.Drawing.Size(238, 35);
            this.nupCantVentas.TabIndex = 2;
            // 
            // lstImportesClasif
            // 
            this.lstImportesClasif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstImportesClasif.FormattingEnabled = true;
            this.lstImportesClasif.ItemHeight = 29;
            this.lstImportesClasif.Location = new System.Drawing.Point(830, 111);
            this.lstImportesClasif.Name = "lstImportesClasif";
            this.lstImportesClasif.Size = new System.Drawing.Size(254, 468);
            this.lstImportesClasif.TabIndex = 0;
            // 
            // dgvMontosVentas
            // 
            this.dgvMontosVentas.AllowUserToAddRows = false;
            this.dgvMontosVentas.AllowUserToDeleteRows = false;
            this.dgvMontosVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMontosVentas.Location = new System.Drawing.Point(305, 108);
            this.dgvMontosVentas.Name = "dgvMontosVentas";
            this.dgvMontosVentas.RowHeadersWidth = 62;
            this.dgvMontosVentas.RowTemplate.Height = 28;
            this.dgvMontosVentas.Size = new System.Drawing.Size(231, 471);
            this.dgvMontosVentas.TabIndex = 10;
            // 
            // dgvOrdenado
            // 
            this.dgvOrdenado.AllowUserToAddRows = false;
            this.dgvOrdenado.AllowUserToDeleteRows = false;
            this.dgvOrdenado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenado.Location = new System.Drawing.Point(568, 108);
            this.dgvOrdenado.Name = "dgvOrdenado";
            this.dgvOrdenado.RowHeadersWidth = 62;
            this.dgvOrdenado.RowTemplate.Height = 28;
            this.dgvOrdenado.Size = new System.Drawing.Size(231, 471);
            this.dgvOrdenado.TabIndex = 11;
            // 
            // frmEnunciado3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1129, 620);
            this.Controls.Add(this.grpVentas);
            this.Name = "frmEnunciado3";
            this.Text = "frmEnunciado3";
            this.grpVentas.ResumeLayout(false);
            this.grpVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMontosVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpVentas;
        private System.Windows.Forms.ListBox lstImportesClasif;
        private System.Windows.Forms.NumericUpDown nupCantVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnClasificar;
        private System.Windows.Forms.DataGridView dgvMontosVentas;
        private System.Windows.Forms.DataGridView dgvOrdenado;
    }
}