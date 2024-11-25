namespace ejercicioTelegrama
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
            this.label_Texto = new System.Windows.Forms.Label();
            this.txtTelegrama = new System.Windows.Forms.TextBox();
            this.chkUrgente = new System.Windows.Forms.CheckBox();
            this.label_Coste = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.boton_Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Texto
            // 
            this.label_Texto.AutoSize = true;
            this.label_Texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Texto.Location = new System.Drawing.Point(12, 9);
            this.label_Texto.Name = "label_Texto";
            this.label_Texto.Size = new System.Drawing.Size(39, 13);
            this.label_Texto.TabIndex = 0;
            this.label_Texto.Text = "Texto";
            // 
            // txtTelegrama
            // 
            this.txtTelegrama.Location = new System.Drawing.Point(12, 25);
            this.txtTelegrama.Multiline = true;
            this.txtTelegrama.Name = "txtTelegrama";
            this.txtTelegrama.Size = new System.Drawing.Size(449, 135);
            this.txtTelegrama.TabIndex = 1;
            // 
            // chkUrgente
            // 
            this.chkUrgente.AutoSize = true;
            this.chkUrgente.Location = new System.Drawing.Point(15, 166);
            this.chkUrgente.Name = "chkUrgente";
            this.chkUrgente.Size = new System.Drawing.Size(70, 17);
            this.chkUrgente.TabIndex = 2;
            this.chkUrgente.Text = "Urgente?";
            this.chkUrgente.UseVisualStyleBackColor = true;
            // 
            // label_Coste
            // 
            this.label_Coste.AutoSize = true;
            this.label_Coste.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Coste.Location = new System.Drawing.Point(12, 227);
            this.label_Coste.Name = "label_Coste";
            this.label_Coste.Size = new System.Drawing.Size(43, 13);
            this.label_Coste.TabIndex = 3;
            this.label_Coste.Text = "Coste:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(61, 224);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 4;
            // 
            // boton_Calcular
            // 
            this.boton_Calcular.Location = new System.Drawing.Point(339, 192);
            this.boton_Calcular.Name = "boton_Calcular";
            this.boton_Calcular.Size = new System.Drawing.Size(122, 52);
            this.boton_Calcular.TabIndex = 5;
            this.boton_Calcular.Text = "Calcular";
            this.boton_Calcular.UseVisualStyleBackColor = true;
            this.boton_Calcular.Click += new System.EventHandler(this.boton_Calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 274);
            this.Controls.Add(this.boton_Calcular);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label_Coste);
            this.Controls.Add(this.chkUrgente);
            this.Controls.Add(this.txtTelegrama);
            this.Controls.Add(this.label_Texto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Texto;
        private System.Windows.Forms.TextBox txtTelegrama;
        private System.Windows.Forms.CheckBox chkUrgente;
        private System.Windows.Forms.Label label_Coste;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button boton_Calcular;
    }
}

