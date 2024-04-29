namespace RE29A4
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
            this.LabelEntrada = new System.Windows.Forms.Label();
            this.textBoxEntrada = new System.Windows.Forms.TextBox();
            this.BotonEntrada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelEntrada
            // 
            this.LabelEntrada.AutoSize = true;
            this.LabelEntrada.Location = new System.Drawing.Point(18, 23);
            this.LabelEntrada.Name = "LabelEntrada";
            this.LabelEntrada.Size = new System.Drawing.Size(44, 13);
            this.LabelEntrada.TabIndex = 0;
            this.LabelEntrada.Text = "Número";
            // 
            // textBoxEntrada
            // 
            this.textBoxEntrada.Location = new System.Drawing.Point(86, 23);
            this.textBoxEntrada.Name = "textBoxEntrada";
            this.textBoxEntrada.Size = new System.Drawing.Size(122, 20);
            this.textBoxEntrada.TabIndex = 1;
            this.textBoxEntrada.Leave += new System.EventHandler(this.textBoxEntrada_Leave);
            // 
            // BotonEntrada
            // 
            this.BotonEntrada.Location = new System.Drawing.Point(231, 23);
            this.BotonEntrada.Name = "BotonEntrada";
            this.BotonEntrada.Size = new System.Drawing.Size(75, 23);
            this.BotonEntrada.TabIndex = 2;
            this.BotonEntrada.Text = "Evaluar";
            this.BotonEntrada.UseVisualStyleBackColor = true;
            this.BotonEntrada.Click += new System.EventHandler(this.Controlador_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 65);
            this.Controls.Add(this.BotonEntrada);
            this.Controls.Add(this.textBoxEntrada);
            this.Controls.Add(this.LabelEntrada);
            this.Name = "Form1";
            this.Text = "Positivo Negativo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelEntrada;
        private System.Windows.Forms.TextBox textBoxEntrada;
        private System.Windows.Forms.Button BotonEntrada;
    }
}

