namespace c_sahrp
{
    partial class frmprograma
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
            this.label1 = new System.Windows.Forms.Label();
            this.btndesactivar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 69F);
            this.label1.Location = new System.Drawing.Point(161, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 130);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hola";
            // 
            // btndesactivar
            // 
            this.btndesactivar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btndesactivar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btndesactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndesactivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btndesactivar.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btndesactivar.Location = new System.Drawing.Point(78, 218);
            this.btndesactivar.Name = "btndesactivar";
            this.btndesactivar.Size = new System.Drawing.Size(460, 62);
            this.btndesactivar.TabIndex = 4;
            this.btndesactivar.Text = "&Desactivar licencia";
            this.btndesactivar.UseVisualStyleBackColor = true;
            this.btndesactivar.Click += new System.EventHandler(this.btndesactivar_Click);
            // 
            // frmprograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(621, 303);
            this.Controls.Add(this.btndesactivar);
            this.Controls.Add(this.label1);
            this.Name = "frmprograma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndesactivar;
    }
}