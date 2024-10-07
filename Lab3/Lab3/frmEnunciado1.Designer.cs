namespace Lab3
{
    partial class frmEnunciado1
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
            this.label4 = new System.Windows.Forms.Label();
            this.pnlTransaccion = new System.Windows.Forms.Panel();
            this.rbRetiro = new System.Windows.Forms.RadioButton();
            this.rbDeposito = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlCuentaAhorro = new System.Windows.Forms.Panel();
            this.tbSaldoCuenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.tbSaldo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbDeposito = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbRetiros = new System.Windows.Forms.ListBox();
            this.errorNoBlancos = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMonto = new System.Windows.Forms.TextBox();
            this.btnAbrirCuenta = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblErrorMontobl = new System.Windows.Forms.Label();
            this.lblErrorMonto = new System.Windows.Forms.Label();
            this.lblErrorCliente = new System.Windows.Forms.Label();
            this.lblErrorSaldo = new System.Windows.Forms.Label();
            this.lblErrorTransaccion = new System.Windows.Forms.Label();
            this.pnlTransaccion.SuspendLayout();
            this.pnlCuentaAhorro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorNoBlancos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese Datos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Transaccion";
            // 
            // pnlTransaccion
            // 
            this.pnlTransaccion.BackColor = System.Drawing.Color.White;
            this.pnlTransaccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTransaccion.Controls.Add(this.lblErrorTransaccion);
            this.pnlTransaccion.Controls.Add(this.rbRetiro);
            this.pnlTransaccion.Controls.Add(this.rbDeposito);
            this.pnlTransaccion.Controls.Add(this.label4);
            this.pnlTransaccion.Location = new System.Drawing.Point(99, 329);
            this.pnlTransaccion.Name = "pnlTransaccion";
            this.pnlTransaccion.Size = new System.Drawing.Size(843, 153);
            this.pnlTransaccion.TabIndex = 3;
            this.pnlTransaccion.Visible = false;
            // 
            // rbRetiro
            // 
            this.rbRetiro.AutoSize = true;
            this.rbRetiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRetiro.Location = new System.Drawing.Point(537, 61);
            this.rbRetiro.Name = "rbRetiro";
            this.rbRetiro.Size = new System.Drawing.Size(81, 24);
            this.rbRetiro.TabIndex = 1;
            this.rbRetiro.TabStop = true;
            this.rbRetiro.Text = "Retiro";
            this.rbRetiro.UseVisualStyleBackColor = true;
            // 
            // rbDeposito
            // 
            this.rbDeposito.AutoSize = true;
            this.rbDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDeposito.Location = new System.Drawing.Point(196, 61);
            this.rbDeposito.Name = "rbDeposito";
            this.rbDeposito.Size = new System.Drawing.Size(105, 24);
            this.rbDeposito.TabIndex = 0;
            this.rbDeposito.TabStop = true;
            this.rbDeposito.Text = "Deposito";
            this.rbDeposito.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cuenta de Ahorro";
            // 
            // pnlCuentaAhorro
            // 
            this.pnlCuentaAhorro.BackColor = System.Drawing.Color.White;
            this.pnlCuentaAhorro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCuentaAhorro.Controls.Add(this.lblErrorSaldo);
            this.pnlCuentaAhorro.Controls.Add(this.label5);
            this.pnlCuentaAhorro.Controls.Add(this.tbSaldoCuenta);
            this.pnlCuentaAhorro.Controls.Add(this.label9);
            this.pnlCuentaAhorro.Controls.Add(this.btnNuevo);
            this.pnlCuentaAhorro.Controls.Add(this.tbSaldo);
            this.pnlCuentaAhorro.Controls.Add(this.label8);
            this.pnlCuentaAhorro.Controls.Add(this.label7);
            this.pnlCuentaAhorro.Controls.Add(this.lbDeposito);
            this.pnlCuentaAhorro.Controls.Add(this.label6);
            this.pnlCuentaAhorro.Controls.Add(this.lbRetiros);
            this.pnlCuentaAhorro.Location = new System.Drawing.Point(99, 528);
            this.pnlCuentaAhorro.Name = "pnlCuentaAhorro";
            this.pnlCuentaAhorro.Size = new System.Drawing.Size(843, 313);
            this.pnlCuentaAhorro.TabIndex = 4;
            this.pnlCuentaAhorro.Visible = false;
            // 
            // tbSaldoCuenta
            // 
            this.tbSaldoCuenta.BackColor = System.Drawing.Color.White;
            this.tbSaldoCuenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSaldoCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSaldoCuenta.Location = new System.Drawing.Point(576, 224);
            this.tbSaldoCuenta.Name = "tbSaldoCuenta";
            this.tbSaldoCuenta.ReadOnly = true;
            this.tbSaldoCuenta.Size = new System.Drawing.Size(151, 23);
            this.tbSaldoCuenta.TabIndex = 7;
            this.tbSaldoCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(572, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Saldo de la cuenta";
            // 
            // btnNuevo
            // 
            this.btnNuevo.AutoSize = true;
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(576, 124);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Padding = new System.Windows.Forms.Padding(8);
            this.btnNuevo.Size = new System.Drawing.Size(151, 51);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // tbSaldo
            // 
            this.tbSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSaldo.Location = new System.Drawing.Point(576, 54);
            this.tbSaldo.Name = "tbSaldo";
            this.tbSaldo.Size = new System.Drawing.Size(151, 30);
            this.tbSaldo.TabIndex = 5;
            this.tbSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSaldo_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(627, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Saldo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(304, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Deposito";
            // 
            // lbDeposito
            // 
            this.lbDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDeposito.FormattingEnabled = true;
            this.lbDeposito.ItemHeight = 20;
            this.lbDeposito.Location = new System.Drawing.Point(308, 63);
            this.lbDeposito.Name = "lbDeposito";
            this.lbDeposito.Size = new System.Drawing.Size(200, 204);
            this.lbDeposito.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Retiros";
            // 
            // lbRetiros
            // 
            this.lbRetiros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRetiros.FormattingEnabled = true;
            this.lbRetiros.ItemHeight = 20;
            this.lbRetiros.Location = new System.Drawing.Point(60, 63);
            this.lbRetiros.Name = "lbRetiros";
            this.lbRetiros.Size = new System.Drawing.Size(200, 204);
            this.lbRetiros.TabIndex = 0;
            // 
            // errorNoBlancos
            // 
            this.errorNoBlancos.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cliente: ";
            // 
            // tbCliente
            // 
            this.tbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCliente.Location = new System.Drawing.Point(280, 37);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.Size = new System.Drawing.Size(250, 30);
            this.tbCliente.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monto Inicial: ";
            // 
            // tbMonto
            // 
            this.tbMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMonto.Location = new System.Drawing.Point(280, 121);
            this.tbMonto.Name = "tbMonto";
            this.tbMonto.Size = new System.Drawing.Size(250, 30);
            this.tbMonto.TabIndex = 3;
            this.tbMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMonto_KeyPress);
            // 
            // btnAbrirCuenta
            // 
            this.btnAbrirCuenta.AutoSize = true;
            this.btnAbrirCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAbrirCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirCuenta.Location = new System.Drawing.Point(631, 100);
            this.btnAbrirCuenta.Name = "btnAbrirCuenta";
            this.btnAbrirCuenta.Padding = new System.Windows.Forms.Padding(8);
            this.btnAbrirCuenta.Size = new System.Drawing.Size(156, 51);
            this.btnAbrirCuenta.TabIndex = 4;
            this.btnAbrirCuenta.Text = "Abrir Cuenta";
            this.btnAbrirCuenta.UseVisualStyleBackColor = false;
            this.btnAbrirCuenta.Click += new System.EventHandler(this.btnAbrirCuenta_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblErrorMontobl);
            this.panel1.Controls.Add(this.lblErrorMonto);
            this.panel1.Controls.Add(this.lblErrorCliente);
            this.panel1.Controls.Add(this.btnAbrirCuenta);
            this.panel1.Controls.Add(this.tbMonto);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbCliente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(99, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 209);
            this.panel1.TabIndex = 0;
            // 
            // lblErrorMontobl
            // 
            this.lblErrorMontobl.AutoSize = true;
            this.lblErrorMontobl.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMontobl.Location = new System.Drawing.Point(277, 158);
            this.lblErrorMontobl.Name = "lblErrorMontobl";
            this.lblErrorMontobl.Size = new System.Drawing.Size(171, 16);
            this.lblErrorMontobl.TabIndex = 7;
            this.lblErrorMontobl.Text = "no puede dejarlo en blanco";
            this.lblErrorMontobl.Visible = false;
            // 
            // lblErrorMonto
            // 
            this.lblErrorMonto.AutoSize = true;
            this.lblErrorMonto.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMonto.Location = new System.Drawing.Point(277, 154);
            this.lblErrorMonto.Name = "lblErrorMonto";
            this.lblErrorMonto.Size = new System.Drawing.Size(141, 16);
            this.lblErrorMonto.TabIndex = 6;
            this.lblErrorMonto.Text = "no puede ser negativo";
            this.lblErrorMonto.Visible = false;
            // 
            // lblErrorCliente
            // 
            this.lblErrorCliente.AutoSize = true;
            this.lblErrorCliente.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCliente.Location = new System.Drawing.Point(277, 70);
            this.lblErrorCliente.Name = "lblErrorCliente";
            this.lblErrorCliente.Size = new System.Drawing.Size(171, 16);
            this.lblErrorCliente.TabIndex = 5;
            this.lblErrorCliente.Text = "no puede dejarlo en blanco";
            this.lblErrorCliente.Visible = false;
            // 
            // lblErrorSaldo
            // 
            this.lblErrorSaldo.AutoSize = true;
            this.lblErrorSaldo.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSaldo.Location = new System.Drawing.Point(573, 87);
            this.lblErrorSaldo.Name = "lblErrorSaldo";
            this.lblErrorSaldo.Size = new System.Drawing.Size(171, 16);
            this.lblErrorSaldo.TabIndex = 8;
            this.lblErrorSaldo.Text = "no puede dejarlo en blanco";
            this.lblErrorSaldo.Visible = false;
            // 
            // lblErrorTransaccion
            // 
            this.lblErrorTransaccion.AutoSize = true;
            this.lblErrorTransaccion.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTransaccion.Location = new System.Drawing.Point(295, 21);
            this.lblErrorTransaccion.Name = "lblErrorTransaccion";
            this.lblErrorTransaccion.Size = new System.Drawing.Size(272, 16);
            this.lblErrorTransaccion.TabIndex = 9;
            this.lblErrorTransaccion.Text = "Tienes que seleccionar una de las opciones";
            this.lblErrorTransaccion.Visible = false;
            // 
            // frmEnunciado1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1035, 887);
            this.Controls.Add(this.pnlCuentaAhorro);
            this.Controls.Add(this.pnlTransaccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "frmEnunciado1";
            this.Text = "frmEnunciado1";
            this.Load += new System.EventHandler(this.frmEnunciado1_Load);
            this.pnlTransaccion.ResumeLayout(false);
            this.pnlTransaccion.PerformLayout();
            this.pnlCuentaAhorro.ResumeLayout(false);
            this.pnlCuentaAhorro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorNoBlancos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlTransaccion;
        private System.Windows.Forms.RadioButton rbRetiro;
        private System.Windows.Forms.RadioButton rbDeposito;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlCuentaAhorro;
        private System.Windows.Forms.ListBox lbRetiros;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox tbSaldo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbDeposito;
        private System.Windows.Forms.TextBox tbSaldoCuenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorNoBlancos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAbrirCuenta;
        private System.Windows.Forms.TextBox tbMonto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblErrorCliente;
        private System.Windows.Forms.Label lblErrorMonto;
        private System.Windows.Forms.Label lblErrorMontobl;
        private System.Windows.Forms.Label lblErrorSaldo;
        private System.Windows.Forms.Label lblErrorTransaccion;
    }
}