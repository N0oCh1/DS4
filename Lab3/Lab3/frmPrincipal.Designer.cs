namespace Lab3
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
            this.mnsPrincipal = new System.Windows.Forms.MenuStrip();
            this.cuentaDeAhorroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enunciado2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enunciado3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsPrincipal
            // 
            this.mnsPrincipal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsPrincipal.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnsPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentaDeAhorroToolStripMenuItem,
            this.enunciado2ToolStripMenuItem,
            this.enunciado3ToolStripMenuItem});
            this.mnsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnsPrincipal.Name = "mnsPrincipal";
            this.mnsPrincipal.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mnsPrincipal.Size = new System.Drawing.Size(1228, 40);
            this.mnsPrincipal.TabIndex = 0;
            this.mnsPrincipal.Text = "menuStrip1";
            // 
            // cuentaDeAhorroToolStripMenuItem
            // 
            this.cuentaDeAhorroToolStripMenuItem.Name = "cuentaDeAhorroToolStripMenuItem";
            this.cuentaDeAhorroToolStripMenuItem.Size = new System.Drawing.Size(161, 36);
            this.cuentaDeAhorroToolStripMenuItem.Text = "Enunciado 1";
            this.cuentaDeAhorroToolStripMenuItem.Click += new System.EventHandler(this.cuentaDeAhorroToolStripMenuItem_Click);
            // 
            // enunciado2ToolStripMenuItem
            // 
            this.enunciado2ToolStripMenuItem.Name = "enunciado2ToolStripMenuItem";
            this.enunciado2ToolStripMenuItem.Size = new System.Drawing.Size(161, 36);
            this.enunciado2ToolStripMenuItem.Text = "Enunciado 2";
            // 
            // enunciado3ToolStripMenuItem
            // 
            this.enunciado3ToolStripMenuItem.Name = "enunciado3ToolStripMenuItem";
            this.enunciado3ToolStripMenuItem.Size = new System.Drawing.Size(161, 36);
            this.enunciado3ToolStripMenuItem.Text = "Enunciado 3";
            this.enunciado3ToolStripMenuItem.Click += new System.EventHandler(this.enunciado3ToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 775);
            this.Controls.Add(this.mnsPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsPrincipal;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulari principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mnsPrincipal.ResumeLayout(false);
            this.mnsPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsPrincipal;
        private System.Windows.Forms.ToolStripMenuItem cuentaDeAhorroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enunciado2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enunciado3ToolStripMenuItem;
    }
}

