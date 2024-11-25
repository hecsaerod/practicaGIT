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
            this.label_Coste = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.boton_Calcular = new System.Windows.Forms.Button();
            this.rb_ordinario = new System.Windows.Forms.RadioButton();
            this.rb_urgente = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label_Texto
            // 
            this.label_Texto.AutoSize = true;
            this.label_Texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Texto.Location = new System.Drawing.Point(16, 11);
            this.label_Texto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Texto.Name = "label_Texto";
            this.label_Texto.Size = new System.Drawing.Size(39, 13);
            this.label_Texto.TabIndex = 0;
            this.label_Texto.Text = "Texto";
            // 
            // txtTelegrama
            // 
            this.txtTelegrama.Location = new System.Drawing.Point(16, 31);
            this.txtTelegrama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelegrama.Multiline = true;
            this.txtTelegrama.Name = "txtTelegrama";
            this.txtTelegrama.Size = new System.Drawing.Size(597, 165);
            this.txtTelegrama.TabIndex = 1;
            // 
            // label_Coste
            // 
            this.label_Coste.AutoSize = true;
            this.label_Coste.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Coste.Location = new System.Drawing.Point(16, 279);
            this.label_Coste.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Coste.Name = "label_Coste";
            this.label_Coste.Size = new System.Drawing.Size(43, 13);
            this.label_Coste.TabIndex = 3;
            this.label_Coste.Text = "Coste:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(81, 276);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(132, 22);
            this.txtPrecio.TabIndex = 4;
            // 
            // boton_Calcular
            // 
            this.boton_Calcular.Location = new System.Drawing.Point(452, 236);
            this.boton_Calcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boton_Calcular.Name = "boton_Calcular";
            this.boton_Calcular.Size = new System.Drawing.Size(163, 64);
            this.boton_Calcular.TabIndex = 5;
            this.boton_Calcular.Text = "Calcular";
            this.boton_Calcular.UseVisualStyleBackColor = true;
            this.boton_Calcular.Click += new System.EventHandler(this.boton_Calcular_Click);
            // 
            // rb_ordinario
            // 
            this.rb_ordinario.AutoSize = true;
            this.rb_ordinario.Location = new System.Drawing.Point(19, 203);
            this.rb_ordinario.Name = "rb_ordinario";
            this.rb_ordinario.Size = new System.Drawing.Size(80, 20);
            this.rb_ordinario.TabIndex = 6;
            this.rb_ordinario.TabStop = true;
            this.rb_ordinario.Text = "Ordinario";
            this.rb_ordinario.UseVisualStyleBackColor = true;
            // 
            // rb_urgente
            // 
            this.rb_urgente.AutoSize = true;
            this.rb_urgente.Location = new System.Drawing.Point(105, 203);
            this.rb_urgente.Name = "rb_urgente";
            this.rb_urgente.Size = new System.Drawing.Size(73, 20);
            this.rb_urgente.TabIndex = 7;
            this.rb_urgente.TabStop = true;
            this.rb_urgente.Text = "Urgente";
            this.rb_urgente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 337);
            this.Controls.Add(this.rb_urgente);
            this.Controls.Add(this.rb_ordinario);
            this.Controls.Add(this.boton_Calcular);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label_Coste);
            this.Controls.Add(this.txtTelegrama);
            this.Controls.Add(this.label_Texto);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Texto;
        private System.Windows.Forms.TextBox txtTelegrama;
        private System.Windows.Forms.Label label_Coste;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button boton_Calcular;
        private System.Windows.Forms.RadioButton rb_ordinario;
        private System.Windows.Forms.RadioButton rb_urgente;
    }
}

