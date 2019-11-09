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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvver = new System.Windows.Forms.DataGridView();
            this.cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnelimartabla = new System.Windows.Forms.Button();
            this.btncrear = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcolumna = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcreartabla = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbuscartabla = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvusuarios = new System.Windows.Forms.DataGridView();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbuscarusuario = new System.Windows.Forms.TextBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btninsertar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvver)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvver
            // 
            this.dgvver.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Railway", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvver.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Railway", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvver.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvver.GridColor = System.Drawing.Color.Silver;
            this.dgvver.Location = new System.Drawing.Point(28, 125);
            this.dgvver.Name = "dgvver";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Railway", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvver.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvver.RowTemplate.Height = 24;
            this.dgvver.Size = new System.Drawing.Size(855, 383);
            this.dgvver.TabIndex = 2;
            // 
            // cb
            // 
            this.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb.FormattingEnabled = true;
            this.cb.Location = new System.Drawing.Point(116, 22);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(387, 37);
            this.cb.TabIndex = 0;
            this.cb.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tabla:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1258, 575);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnelimartabla);
            this.tabPage1.Controls.Add(this.btncrear);
            this.tabPage1.Controls.Add(this.lb);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtcolumna);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtcreartabla);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtbuscartabla);
            this.tabPage1.Controls.Add(this.btnguardar);
            this.tabPage1.Controls.Add(this.dgvver);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cb);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1250, 533);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ver Tablas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnelimartabla
            // 
            this.btnelimartabla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnelimartabla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnelimartabla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnelimartabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnelimartabla.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnelimartabla.Location = new System.Drawing.Point(686, 22);
            this.btnelimartabla.Name = "btnelimartabla";
            this.btnelimartabla.Size = new System.Drawing.Size(197, 89);
            this.btnelimartabla.TabIndex = 12;
            this.btnelimartabla.Text = "Eliminar tabla";
            this.btnelimartabla.UseVisualStyleBackColor = true;
            this.btnelimartabla.Click += new System.EventHandler(this.btnelimartabla_Click);
            // 
            // btncrear
            // 
            this.btncrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncrear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btncrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btncrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncrear.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btncrear.Location = new System.Drawing.Point(909, 460);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(333, 48);
            this.btncrear.TabIndex = 11;
            this.btncrear.Text = "Crear";
            this.btncrear.UseVisualStyleBackColor = true;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // lb
            // 
            this.lb.FormattingEnabled = true;
            this.lb.IntegralHeight = false;
            this.lb.ItemHeight = 29;
            this.lb.Location = new System.Drawing.Point(909, 204);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(333, 250);
            this.lb.TabIndex = 6;
            this.lb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lb_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(903, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 31);
            this.label8.TabIndex = 10;
            this.label8.Text = "Columnas:";
            // 
            // txtcolumna
            // 
            this.txtcolumna.Location = new System.Drawing.Point(909, 159);
            this.txtcolumna.Name = "txtcolumna";
            this.txtcolumna.Size = new System.Drawing.Size(333, 38);
            this.txtcolumna.TabIndex = 5;
            this.txtcolumna.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcolumna_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(903, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 31);
            this.label7.TabIndex = 9;
            this.label7.Text = "Nombre:";
            // 
            // txtcreartabla
            // 
            this.txtcreartabla.Location = new System.Drawing.Point(909, 56);
            this.txtcreartabla.Name = "txtcreartabla";
            this.txtcreartabla.Size = new System.Drawing.Size(333, 38);
            this.txtcreartabla.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Buscar:";
            // 
            // txtbuscartabla
            // 
            this.txtbuscartabla.Enabled = false;
            this.txtbuscartabla.Location = new System.Drawing.Point(116, 73);
            this.txtbuscartabla.Name = "txtbuscartabla";
            this.txtbuscartabla.Size = new System.Drawing.Size(387, 38);
            this.txtbuscartabla.TabIndex = 1;
            this.txtbuscartabla.TextChanged += new System.EventHandler(this.txtbuscartabla_TextChanged);
            // 
            // btnguardar
            // 
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnguardar.Location = new System.Drawing.Point(523, 22);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(157, 89);
            this.btnguardar.TabIndex = 3;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvusuarios);
            this.tabPage2.Controls.Add(this.txtcontraseña);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtbuscarusuario);
            this.tabPage2.Controls.Add(this.btneliminar);
            this.tabPage2.Controls.Add(this.btnactualizar);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtusuario);
            this.tabPage2.Controls.Add(this.txtid);
            this.tabPage2.Controls.Add(this.btninsertar);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1250, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Administración de usuarios";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvusuarios
            // 
            this.dgvusuarios.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Railway", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvusuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Railway", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvusuarios.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvusuarios.GridColor = System.Drawing.Color.Silver;
            this.dgvusuarios.Location = new System.Drawing.Point(14, 176);
            this.dgvusuarios.Name = "dgvusuarios";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Railway", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvusuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvusuarios.RowTemplate.Height = 24;
            this.dgvusuarios.Size = new System.Drawing.Size(1228, 350);
            this.dgvusuarios.TabIndex = 7;
            this.dgvusuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvusuarios_CellClick);
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(531, 50);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(385, 38);
            this.txtcontraseña.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(920, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "Buscar usuario:";
            // 
            // txtbuscarusuario
            // 
            this.txtbuscarusuario.Location = new System.Drawing.Point(926, 50);
            this.txtbuscarusuario.Name = "txtbuscarusuario";
            this.txtbuscarusuario.Size = new System.Drawing.Size(316, 38);
            this.txtbuscarusuario.TabIndex = 3;
            this.txtbuscarusuario.TextChanged += new System.EventHandler(this.txtbuscarusuario_TextChanged);
            // 
            // btneliminar
            // 
            this.btneliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btneliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btneliminar.Location = new System.Drawing.Point(760, 103);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(482, 53);
            this.btneliminar.TabIndex = 6;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnactualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactualizar.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnactualizar.Location = new System.Drawing.Point(370, 103);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(384, 53);
            this.btnactualizar.TabIndex = 5;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre de usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID:";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(195, 50);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(327, 38);
            this.txtusuario.TabIndex = 1;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(14, 50);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(169, 38);
            this.txtid.TabIndex = 0;
            // 
            // btninsertar
            // 
            this.btninsertar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btninsertar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btninsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninsertar.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btninsertar.Location = new System.Drawing.Point(14, 103);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(350, 53);
            this.btninsertar.TabIndex = 4;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // frmprincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1258, 575);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Railway", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de datos sin SQL";
            ((System.ComponentModel.ISupportInitialize)(this.dgvver)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.DataGridView dgvver;
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbuscartabla;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbuscarusuario;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcreartabla;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.ListBox lb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcolumna;
        private System.Windows.Forms.DataGridView dgvusuarios;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.Button btnelimartabla;
    }
}
