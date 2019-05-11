namespace c_sahrp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtremitente = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtpara = new System.Windows.Forms.TextBox();
            this.txtcc = new System.Windows.Forms.TextBox();
            this.txtasunto = new System.Windows.Forms.TextBox();
            this.txtadjuntos = new System.Windows.Forms.TextBox();
            this.rtbmensaje = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnabrir = new System.Windows.Forms.Button();
            this.btnenviar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtremitente
            // 
            this.txtremitente.Location = new System.Drawing.Point(29, 31);
            this.txtremitente.Name = "txtremitente";
            this.txtremitente.Size = new System.Drawing.Size(339, 26);
            this.txtremitente.TabIndex = 0;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(443, 31);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(339, 26);
            this.txtpassword.TabIndex = 1;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // txtpara
            // 
            this.txtpara.Location = new System.Drawing.Point(29, 83);
            this.txtpara.Name = "txtpara";
            this.txtpara.Size = new System.Drawing.Size(510, 26);
            this.txtpara.TabIndex = 2;
            // 
            // txtcc
            // 
            this.txtcc.Location = new System.Drawing.Point(558, 83);
            this.txtcc.Name = "txtcc";
            this.txtcc.Size = new System.Drawing.Size(587, 26);
            this.txtcc.TabIndex = 3;
            // 
            // txtasunto
            // 
            this.txtasunto.Location = new System.Drawing.Point(29, 141);
            this.txtasunto.Name = "txtasunto";
            this.txtasunto.Size = new System.Drawing.Size(1116, 26);
            this.txtasunto.TabIndex = 4;
            // 
            // txtadjuntos
            // 
            this.txtadjuntos.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtadjuntos.Location = new System.Drawing.Point(29, 197);
            this.txtadjuntos.Name = "txtadjuntos";
            this.txtadjuntos.ReadOnly = true;
            this.txtadjuntos.Size = new System.Drawing.Size(1055, 26);
            this.txtadjuntos.TabIndex = 5;
            // 
            // rtbmensaje
            // 
            this.rtbmensaje.Location = new System.Drawing.Point(311, 249);
            this.rtbmensaje.Name = "rtbmensaje";
            this.rtbmensaje.Size = new System.Drawing.Size(835, 333);
            this.rtbmensaje.TabIndex = 6;
            this.rtbmensaje.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tu correo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tu contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Destinatarios (separados por \', \'):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(554, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "CC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Asunto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(288, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Archivos adjuntos (separados por \'|\'):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mensaje:";
            // 
            // btnabrir
            // 
            this.btnabrir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnabrir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btnabrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnabrir.Location = new System.Drawing.Point(1090, 197);
            this.btnabrir.Name = "btnabrir";
            this.btnabrir.Size = new System.Drawing.Size(55, 26);
            this.btnabrir.TabIndex = 14;
            this.btnabrir.Text = "...";
            this.btnabrir.UseVisualStyleBackColor = true;
            this.btnabrir.Click += new System.EventHandler(this.btnabrir_Click);
            // 
            // btnenviar
            // 
            this.btnenviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnenviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btnenviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnenviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenviar.Location = new System.Drawing.Point(29, 249);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(256, 125);
            this.btnenviar.TabIndex = 15;
            this.btnenviar.Text = "Enviar";
            this.btnenviar.UseVisualStyleBackColor = true;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btncancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.DarkRed;
            this.btncancelar.Location = new System.Drawing.Point(29, 380);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(256, 134);
            this.btncancelar.TabIndex = 16;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(802, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tu nombre:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(806, 31);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(339, 26);
            this.txtnombre.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1158, 594);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnenviar);
            this.Controls.Add(this.btnabrir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbmensaje);
            this.Controls.Add(this.txtadjuntos);
            this.Controls.Add(this.txtasunto);
            this.Controls.Add(this.txtcc);
            this.Controls.Add(this.txtpara);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtremitente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enviar correo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtremitente;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtpara;
        private System.Windows.Forms.TextBox txtcc;
        private System.Windows.Forms.TextBox txtasunto;
        private System.Windows.Forms.TextBox txtadjuntos;
        private System.Windows.Forms.RichTextBox rtbmensaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnabrir;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnombre;


    }
}
