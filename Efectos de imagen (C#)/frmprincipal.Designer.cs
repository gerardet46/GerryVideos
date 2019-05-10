namespace c_sahrp
{
    partial class frmprincipal
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
            this.pb = new System.Windows.Forms.PictureBox();
            this.pbblanconegro = new System.Windows.Forms.PictureBox();
            this.btnabrir = new System.Windows.Forms.Button();
            this.btnconvbl = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progres = new System.Windows.Forms.ProgressBar();
            this.btnguardarbl = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnconvneg = new System.Windows.Forms.Button();
            this.pbneg = new System.Windows.Forms.PictureBox();
            this.btnguardarneg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbblanconegro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbneg)).BeginInit();
            this.SuspendLayout();
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(12, 169);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(561, 365);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb.TabIndex = 0;
            this.pb.TabStop = false;
            // 
            // pbblanconegro
            // 
            this.pbblanconegro.Location = new System.Drawing.Point(603, 169);
            this.pbblanconegro.Name = "pbblanconegro";
            this.pbblanconegro.Size = new System.Drawing.Size(561, 365);
            this.pbblanconegro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbblanconegro.TabIndex = 1;
            this.pbblanconegro.TabStop = false;
            // 
            // btnabrir
            // 
            this.btnabrir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnabrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnabrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnabrir.ForeColor = System.Drawing.Color.White;
            this.btnabrir.Location = new System.Drawing.Point(12, 74);
            this.btnabrir.Name = "btnabrir";
            this.btnabrir.Size = new System.Drawing.Size(561, 68);
            this.btnabrir.TabIndex = 2;
            this.btnabrir.Text = "Abrir";
            this.btnabrir.UseVisualStyleBackColor = true;
            // 
            // btnconvbl
            // 
            this.btnconvbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconvbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnconvbl.ForeColor = System.Drawing.Color.White;
            this.btnconvbl.Location = new System.Drawing.Point(603, 74);
            this.btnconvbl.Name = "btnconvbl";
            this.btnconvbl.Size = new System.Drawing.Size(561, 68);
            this.btnconvbl.TabIndex = 3;
            this.btnconvbl.Text = "Convertir (blanco y negro)";
            this.btnconvbl.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(585, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 480);
            this.panel1.TabIndex = 4;
            // 
            // progres
            // 
            this.progres.Dock = System.Windows.Forms.DockStyle.Top;
            this.progres.Location = new System.Drawing.Point(0, 0);
            this.progres.Name = "progres";
            this.progres.Size = new System.Drawing.Size(1774, 50);
            this.progres.TabIndex = 5;
            // 
            // btnguardarbl
            // 
            this.btnguardarbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardarbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnguardarbl.ForeColor = System.Drawing.Color.White;
            this.btnguardarbl.Location = new System.Drawing.Point(12, 542);
            this.btnguardarbl.Name = "btnguardarbl";
            this.btnguardarbl.Size = new System.Drawing.Size(876, 68);
            this.btnguardarbl.TabIndex = 6;
            this.btnguardarbl.Text = "Guardar blanco y negro";
            this.btnguardarbl.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(1177, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 480);
            this.panel2.TabIndex = 9;
            // 
            // btnconvneg
            // 
            this.btnconvneg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconvneg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnconvneg.ForeColor = System.Drawing.Color.White;
            this.btnconvneg.Location = new System.Drawing.Point(1195, 74);
            this.btnconvneg.Name = "btnconvneg";
            this.btnconvneg.Size = new System.Drawing.Size(561, 68);
            this.btnconvneg.TabIndex = 8;
            this.btnconvneg.Text = "Convertir (negativo)";
            this.btnconvneg.UseVisualStyleBackColor = true;
            // 
            // pbneg
            // 
            this.pbneg.Location = new System.Drawing.Point(1195, 169);
            this.pbneg.Name = "pbneg";
            this.pbneg.Size = new System.Drawing.Size(561, 365);
            this.pbneg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbneg.TabIndex = 7;
            this.pbneg.TabStop = false;
            // 
            // btnguardarneg
            // 
            this.btnguardarneg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardarneg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnguardarneg.ForeColor = System.Drawing.Color.White;
            this.btnguardarneg.Location = new System.Drawing.Point(894, 542);
            this.btnguardarneg.Name = "btnguardarneg";
            this.btnguardarneg.Size = new System.Drawing.Size(862, 68);
            this.btnguardarneg.TabIndex = 10;
            this.btnguardarneg.Text = "Guardar negativo";
            this.btnguardarneg.UseVisualStyleBackColor = true;
            // 
            // frmprincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1774, 622);
            this.Controls.Add(this.btnguardarneg);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnconvneg);
            this.Controls.Add(this.pbneg);
            this.Controls.Add(this.btnguardarbl);
            this.Controls.Add(this.progres);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnconvbl);
            this.Controls.Add(this.btnabrir);
            this.Controls.Add(this.pbblanconegro);
            this.Controls.Add(this.pb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.Name = "frmprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blanco y negro";
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbblanconegro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbneg)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TextBox txtexpr;
        private System.Windows.Forms.Label lbresultado;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.PictureBox pbblanconegro;
        private System.Windows.Forms.Button btnabrir;
        private System.Windows.Forms.Button btnconvbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progres;
        private System.Windows.Forms.Button btnguardarbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnconvneg;
        private System.Windows.Forms.PictureBox pbneg;
        private System.Windows.Forms.Button btnguardarneg;
    }
}
