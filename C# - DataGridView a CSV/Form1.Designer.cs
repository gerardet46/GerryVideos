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
            this.dgvflores = new System.Windows.Forms.DataGridView();
            this.btnabrir = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtsep = new System.Windows.Forms.TextBox();
            this.dgvcolnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcolcolor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcolprecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvflores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvflores
            // 
            this.dgvflores.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgvflores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvflores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcolnombre,
            this.Column1,
            this.dgvcolcolor,
            this.dgvcolprecio});
            this.dgvflores.Location = new System.Drawing.Point(0, 0);
            this.dgvflores.Name = "dgvflores";
            this.dgvflores.RowHeadersWidth = 51;
            this.dgvflores.RowTemplate.Height = 24;
            this.dgvflores.Size = new System.Drawing.Size(782, 330);
            this.dgvflores.TabIndex = 0;
            // 
            // btnabrir
            // 
            this.btnabrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnabrir.ForeColor = System.Drawing.Color.White;
            this.btnabrir.Location = new System.Drawing.Point(13, 348);
            this.btnabrir.Name = "btnabrir";
            this.btnabrir.Size = new System.Drawing.Size(368, 64);
            this.btnabrir.TabIndex = 1;
            this.btnabrir.Text = "Abrir";
            this.btnabrir.UseVisualStyleBackColor = true;
            this.btnabrir.Click += new System.EventHandler(this.btnabrir_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.Location = new System.Drawing.Point(387, 348);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(325, 64);
            this.btnguardar.TabIndex = 2;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtsep
            // 
            this.txtsep.Location = new System.Drawing.Point(718, 362);
            this.txtsep.Name = "txtsep";
            this.txtsep.Size = new System.Drawing.Size(52, 39);
            this.txtsep.TabIndex = 3;
            this.txtsep.Text = ",";
            this.txtsep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvcolnombre
            // 
            this.dgvcolnombre.HeaderText = "Nombre";
            this.dgvcolnombre.MinimumWidth = 6;
            this.dgvcolnombre.Name = "dgvcolnombre";
            this.dgvcolnombre.Width = 325;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // dgvcolcolor
            // 
            this.dgvcolcolor.HeaderText = "Color";
            this.dgvcolcolor.MinimumWidth = 6;
            this.dgvcolcolor.Name = "dgvcolcolor";
            this.dgvcolcolor.Width = 225;
            // 
            // dgvcolprecio
            // 
            this.dgvcolprecio.HeaderText = "Precio";
            this.dgvcolprecio.MinimumWidth = 6;
            this.dgvcolprecio.Name = "dgvcolprecio";
            this.dgvcolprecio.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(782, 438);
            this.Controls.Add(this.txtsep);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnabrir);
            this.Controls.Add(this.dgvflores);
            this.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "DGV <-> CSV";
            ((System.ComponentModel.ISupportInitialize)(this.dgvflores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvflores;
        private System.Windows.Forms.Button btnabrir;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txtsep;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcolnombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcolcolor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcolprecio;
    }
}

