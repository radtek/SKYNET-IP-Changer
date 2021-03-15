namespace lol
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lblip = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flatButton1 = new FlatButton();
            this.Change = new FlatButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtIPColor = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMaskColor = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtMask = new System.Windows.Forms.TextBox();
            this.txtGatewayColor = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtGateway = new System.Windows.Forms.TextBox();
            this.txtDNSColor = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtDNS = new System.Windows.Forms.TextBox();
            this.txtIPColor.SuspendLayout();
            this.panel2.SuspendLayout();
            this.txtMaskColor.SuspendLayout();
            this.panel4.SuspendLayout();
            this.txtGatewayColor.SuspendLayout();
            this.panel6.SuspendLayout();
            this.txtDNSColor.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIP
            // 
            this.txtIP.BackColor = System.Drawing.Color.White;
            this.txtIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtIP.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtIP.Location = new System.Drawing.Point(3, 3);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(97, 16);
            this.txtIP.TabIndex = 6;
            this.txtIP.TextChanged += new System.EventHandler(this.TxtIP_TextChanged);
            this.txtIP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxT_KeyDown);
            // 
            // lblip
            // 
            this.lblip.AutoSize = true;
            this.lblip.BackColor = System.Drawing.Color.Transparent;
            this.lblip.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblip.Location = new System.Drawing.Point(7, 7);
            this.lblip.Name = "lblip";
            this.lblip.Size = new System.Drawing.Size(65, 13);
            this.lblip.TabIndex = 9;
            this.lblip.Text = "Dirección IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(113, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Máscara de subred";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(221, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Puerta de enlace";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(328, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Servidor DNS";
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.flatButton1.BackColorMouseOver = System.Drawing.Color.Empty;
            this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.flatButton1.ForeColor = System.Drawing.Color.White;
            this.flatButton1.ForeColorMouseOver = System.Drawing.Color.Empty;
            this.flatButton1.ImageAlignment = FlatButton._ImgAlign.Left;
            this.flatButton1.ImageIcon = null;
            this.flatButton1.Location = new System.Drawing.Point(440, 52);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Rounded = false;
            this.flatButton1.Size = new System.Drawing.Size(100, 26);
            this.flatButton1.Style = FlatButton._Style.TextOnly;
            this.flatButton1.TabIndex = 17;
            this.flatButton1.Text = "DHCP";
            this.flatButton1.Click += new System.EventHandler(this.FlatButton1_Click);
            // 
            // Change
            // 
            this.Change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.Change.BackColorMouseOver = System.Drawing.Color.Empty;
            this.Change.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Change.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change.ForeColor = System.Drawing.Color.White;
            this.Change.ForeColorMouseOver = System.Drawing.Color.Empty;
            this.Change.ImageAlignment = FlatButton._ImgAlign.Left;
            this.Change.ImageIcon = null;
            this.Change.Location = new System.Drawing.Point(440, 20);
            this.Change.Name = "Change";
            this.Change.Rounded = false;
            this.Change.Size = new System.Drawing.Size(100, 26);
            this.Change.Style = FlatButton._Style.TextOnly;
            this.Change.TabIndex = 16;
            this.Change.Text = "Cambiar";
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(223, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // txtIPColor
            // 
            this.txtIPColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.txtIPColor.Controls.Add(this.panel2);
            this.txtIPColor.Location = new System.Drawing.Point(9, 21);
            this.txtIPColor.Name = "txtIPColor";
            this.txtIPColor.Padding = new System.Windows.Forms.Padding(1);
            this.txtIPColor.Size = new System.Drawing.Size(104, 24);
            this.txtIPColor.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtIP);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(102, 22);
            this.panel2.TabIndex = 21;
            // 
            // txtMaskColor
            // 
            this.txtMaskColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.txtMaskColor.Controls.Add(this.panel4);
            this.txtMaskColor.Location = new System.Drawing.Point(116, 21);
            this.txtMaskColor.Name = "txtMaskColor";
            this.txtMaskColor.Padding = new System.Windows.Forms.Padding(1);
            this.txtMaskColor.Size = new System.Drawing.Size(104, 24);
            this.txtMaskColor.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.txtMask);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(1, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(102, 22);
            this.panel4.TabIndex = 21;
            // 
            // txtMask
            // 
            this.txtMask.BackColor = System.Drawing.Color.White;
            this.txtMask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMask.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtMask.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtMask.Location = new System.Drawing.Point(3, 3);
            this.txtMask.Name = "txtMask";
            this.txtMask.Size = new System.Drawing.Size(97, 16);
            this.txtMask.TabIndex = 6;
            this.txtMask.TextChanged += new System.EventHandler(this.TxtMask_TextChanged);
            this.txtMask.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxT_KeyDown);
            // 
            // txtGatewayColor
            // 
            this.txtGatewayColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.txtGatewayColor.Controls.Add(this.panel6);
            this.txtGatewayColor.Location = new System.Drawing.Point(223, 21);
            this.txtGatewayColor.Name = "txtGatewayColor";
            this.txtGatewayColor.Padding = new System.Windows.Forms.Padding(1);
            this.txtGatewayColor.Size = new System.Drawing.Size(104, 24);
            this.txtGatewayColor.TabIndex = 22;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.txtGateway);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(1, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(102, 22);
            this.panel6.TabIndex = 21;
            // 
            // txtGateway
            // 
            this.txtGateway.BackColor = System.Drawing.Color.White;
            this.txtGateway.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGateway.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtGateway.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtGateway.Location = new System.Drawing.Point(3, 3);
            this.txtGateway.Name = "txtGateway";
            this.txtGateway.Size = new System.Drawing.Size(97, 16);
            this.txtGateway.TabIndex = 6;
            this.txtGateway.TextChanged += new System.EventHandler(this.TxtGateway_TextChanged);
            this.txtGateway.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxT_KeyDown);
            // 
            // txtDNSColor
            // 
            this.txtDNSColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.txtDNSColor.Controls.Add(this.panel8);
            this.txtDNSColor.Location = new System.Drawing.Point(330, 21);
            this.txtDNSColor.Name = "txtDNSColor";
            this.txtDNSColor.Padding = new System.Windows.Forms.Padding(1);
            this.txtDNSColor.Size = new System.Drawing.Size(104, 24);
            this.txtDNSColor.TabIndex = 23;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.txtDNS);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(1, 1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(102, 22);
            this.panel8.TabIndex = 21;
            // 
            // txtDNS
            // 
            this.txtDNS.BackColor = System.Drawing.Color.White;
            this.txtDNS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDNS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtDNS.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDNS.Location = new System.Drawing.Point(3, 3);
            this.txtDNS.Name = "txtDNS";
            this.txtDNS.Size = new System.Drawing.Size(97, 16);
            this.txtDNS.TabIndex = 6;
            this.txtDNS.TextChanged += new System.EventHandler(this.TxtDNS_TextChanged);
            this.txtDNS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxT_KeyDown);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(555, 89);
            this.Controls.Add(this.txtDNSColor);
            this.Controls.Add(this.txtGatewayColor);
            this.Controls.Add(this.txtMaskColor);
            this.Controls.Add(this.txtIPColor);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flatButton1);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.txtIPColor.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.txtMaskColor.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.txtGatewayColor.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.txtDNSColor.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private FlatButton Change;
        private FlatButton flatButton1;
        public System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel txtIPColor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel txtMaskColor;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TextBox txtMask;
        private System.Windows.Forms.Panel txtGatewayColor;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.TextBox txtGateway;
        private System.Windows.Forms.Panel txtDNSColor;
        private System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.TextBox txtDNS;
    }
}

