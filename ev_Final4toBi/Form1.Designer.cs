namespace ev_Final4toBi
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
            this.label1 = new System.Windows.Forms.Label();
            this.LBL1 = new System.Windows.Forms.Button();
            this.TextUsuario = new System.Windows.Forms.TextBox();
            this.TextContraseña = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Examen Final";
            // 
            // LBL1
            // 
            this.LBL1.Location = new System.Drawing.Point(357, 162);
            this.LBL1.Name = "LBL1";
            this.LBL1.Size = new System.Drawing.Size(75, 23);
            this.LBL1.TabIndex = 1;
            this.LBL1.Text = "ingresar";
            this.LBL1.UseVisualStyleBackColor = true;
            this.LBL1.Click += new System.EventHandler(this.LBL1_Click);
            // 
            // TextUsuario
            // 
            this.TextUsuario.Location = new System.Drawing.Point(114, 219);
            this.TextUsuario.Name = "TextUsuario";
            this.TextUsuario.Size = new System.Drawing.Size(100, 22);
            this.TextUsuario.TabIndex = 2;
            // 
            // TextContraseña
            // 
            this.TextContraseña.Location = new System.Drawing.Point(459, 219);
            this.TextContraseña.Name = "TextContraseña";
            this.TextContraseña.Size = new System.Drawing.Size(100, 22);
            this.TextContraseña.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextContraseña);
            this.Controls.Add(this.TextUsuario);
            this.Controls.Add(this.LBL1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LBL1;
        private System.Windows.Forms.TextBox TextUsuario;
        private System.Windows.Forms.TextBox TextContraseña;
    }
}

