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
            this.labCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.butsend = new System.Windows.Forms.Button();
            this.txtmessage = new System.Windows.Forms.TextBox();
            this.btnKeyPrivada = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server-UDP";
            // 
            // labCode
            // 
            this.labCode.AutoSize = true;
            this.labCode.Location = new System.Drawing.Point(68, 33);
            this.labCode.Name = "labCode";
            this.labCode.Size = new System.Drawing.Size(103, 13);
            this.labCode.TabIndex = 2;
            this.labCode.Text = "                                ";
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
            this.groupBox2.Controls.Add(this.btnKeyPrivada);
            this.groupBox2.Controls.Add(this.butsend);
            this.groupBox2.Controls.Add(this.txtmessage);
            this.groupBox2.Location = new System.Drawing.Point(26, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente-UDP";
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
            this.txtmessage.Size = new System.Drawing.Size(367, 20);
            this.txtmessage.TabIndex = 4;
            // 
            // btnKeyPrivada
            // 
            this.btnKeyPrivada.Location = new System.Drawing.Point(112, 45);
            this.btnKeyPrivada.Name = "btnKeyPrivada";
            this.btnKeyPrivada.Size = new System.Drawing.Size(128, 23);
            this.btnKeyPrivada.TabIndex = 9;
            this.btnKeyPrivada.Text = "Generar clau";
            this.btnKeyPrivada.UseVisualStyleBackColor = true;
            this.btnKeyPrivada.Click += new System.EventHandler(this.btnKeyPrivada_Click);
            // 
            // UDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 300);
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
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button butsend;
        public System.Windows.Forms.TextBox txtmessage;
        public System.Windows.Forms.Label labCode;
        private System.Windows.Forms.Button btnKeyPrivada;
    }
}

