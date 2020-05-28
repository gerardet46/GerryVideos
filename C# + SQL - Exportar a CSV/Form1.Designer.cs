namespace tutos
{
    partial class Form1
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
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtsep = new System.Windows.Forms.TextBox();
            this.txtruta = new System.Windows.Forms.TextBox();
            this.btnabrir = new System.Windows.Forms.Button();
            this.txtconsulta = new System.Windows.Forms.TextBox();
            this.btnverarchivo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnguardar
            // 
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.Location = new System.Drawing.Point(40, 251);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(585, 64);
            this.btnguardar.TabIndex = 6;
            this.btnguardar.Text = "Exportar a CSV";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtsep
            // 
            this.txtsep.Location = new System.Drawing.Point(585, 161);
            this.txtsep.Name = "txtsep";
            this.txtsep.Size = new System.Drawing.Size(52, 39);
            this.txtsep.TabIndex = 5;
            this.txtsep.Text = ";";
            this.txtsep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtruta
            // 
            this.txtruta.Location = new System.Drawing.Point(40, 52);
            this.txtruta.Name = "txtruta";
            this.txtruta.Size = new System.Drawing.Size(539, 39);
            this.txtruta.TabIndex = 1;
            // 
            // btnabrir
            // 
            this.btnabrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnabrir.ForeColor = System.Drawing.Color.White;
            this.btnabrir.Location = new System.Drawing.Point(585, 52);
            this.btnabrir.Name = "btnabrir";
            this.btnabrir.Size = new System.Drawing.Size(52, 39);
            this.btnabrir.TabIndex = 2;
            this.btnabrir.Text = "...";
            this.btnabrir.UseVisualStyleBackColor = true;
            this.btnabrir.Click += new System.EventHandler(this.btnabrir_Click_1);
            // 
            // txtconsulta
            // 
            this.txtconsulta.Location = new System.Drawing.Point(40, 161);
            this.txtconsulta.Name = "txtconsulta";
            this.txtconsulta.Size = new System.Drawing.Size(539, 39);
            this.txtconsulta.TabIndex = 4;
            this.txtconsulta.Text = "SELECT * FROM Flores";
            // 
            // btnverarchivo
            // 
            this.btnverarchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnverarchivo.ForeColor = System.Drawing.Color.White;
            this.btnverarchivo.Location = new System.Drawing.Point(40, 321);
            this.btnverarchivo.Name = "btnverarchivo";
            this.btnverarchivo.Size = new System.Drawing.Size(585, 64);
            this.btnverarchivo.TabIndex = 7;
            this.btnverarchivo.Text = "Ver archivo";
            this.btnverarchivo.UseVisualStyleBackColor = true;
            this.btnverarchivo.Click += new System.EventHandler(this.btnverarchivo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guardar en...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Consulta SQL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(674, 425);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnverarchivo);
            this.Controls.Add(this.txtconsulta);
            this.Controls.Add(this.btnabrir);
            this.Controls.Add(this.txtruta);
            this.Controls.Add(this.txtsep);
            this.Controls.Add(this.btnguardar);
            this.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "DGV <-> CSV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txtsep;
        private System.Windows.Forms.TextBox txtruta;
        private System.Windows.Forms.Button btnabrir;
        private System.Windows.Forms.TextBox txtconsulta;
        private System.Windows.Forms.Button btnverarchivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

