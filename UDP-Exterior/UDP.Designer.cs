namespace UDP_Exterior
{
    partial class UDP
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labhost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDesencrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnListen = new System.Windows.Forms.Button();
            this.butsend = new System.Windows.Forms.Button();
            this.txtmessage = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labhost);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server-UDP";
            // 
            // labhost
            // 
            this.labhost.AutoSize = true;
            this.labhost.Location = new System.Drawing.Point(68, 33);
            this.labhost.Name = "labhost";
            this.labhost.Size = new System.Drawing.Size(0, 13);
            this.labhost.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Message: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDesencrypt);
            this.groupBox2.Controls.Add(this.btnEncrypt);
            this.groupBox2.Controls.Add(this.btnListen);
            this.groupBox2.Controls.Add(this.butsend);
            this.groupBox2.Controls.Add(this.txtmessage);
            this.groupBox2.Location = new System.Drawing.Point(254, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente-UDP";
            // 
            // btnDesencrypt
            // 
            this.btnDesencrypt.Location = new System.Drawing.Point(112, 74);
            this.btnDesencrypt.Name = "btnDesencrypt";
            this.btnDesencrypt.Size = new System.Drawing.Size(82, 23);
            this.btnDesencrypt.TabIndex = 7;
            this.btnDesencrypt.Text = "DesEncriptar";
            this.btnDesencrypt.UseVisualStyleBackColor = true;
            this.btnDesencrypt.Click += new System.EventHandler(this.btnDesencrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(112, 45);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 6;
            this.btnEncrypt.Text = "Encriptar";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(6, 74);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(100, 23);
            this.btnListen.TabIndex = 5;
            this.btnListen.Text = "Escoltar Nau";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // butsend
            // 
            this.butsend.Location = new System.Drawing.Point(6, 45);
            this.butsend.Name = "butsend";
            this.butsend.Size = new System.Drawing.Size(100, 23);
            this.butsend.TabIndex = 3;
            this.butsend.Text = "Enviar dades";
            this.butsend.UseVisualStyleBackColor = true;
            this.butsend.Click += new System.EventHandler(this.butsend_Click);
            // 
            // txtmessage
            // 
            this.txtmessage.Location = new System.Drawing.Point(6, 19);
            this.txtmessage.Name = "txtmessage";
            this.txtmessage.Size = new System.Drawing.Size(188, 20);
            this.txtmessage.TabIndex = 4;
            // 
            // UDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 175);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UDP";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UDP_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label labhost;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button butsend;
        public System.Windows.Forms.TextBox txtmessage;
        public System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDesencrypt;
    }
}

