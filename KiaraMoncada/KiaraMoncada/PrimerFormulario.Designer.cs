namespace KiaraMoncada
{
    partial class PrimerFormulario
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
            this.InteresesListBox = new System.Windows.Forms.ListBox();
            this.EjecutarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InteresesListBox
            // 
            this.InteresesListBox.FormattingEnabled = true;
            this.InteresesListBox.ItemHeight = 16;
            this.InteresesListBox.Location = new System.Drawing.Point(24, 21);
            this.InteresesListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InteresesListBox.Name = "InteresesListBox";
            this.InteresesListBox.Size = new System.Drawing.Size(224, 276);
            this.InteresesListBox.TabIndex = 0;
            // 
            // EjecutarButton
            // 
            this.EjecutarButton.Location = new System.Drawing.Point(265, 21);
            this.EjecutarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EjecutarButton.Name = "EjecutarButton";
            this.EjecutarButton.Size = new System.Drawing.Size(95, 30);
            this.EjecutarButton.TabIndex = 1;
            this.EjecutarButton.Text = "Ejecutar";
            this.EjecutarButton.UseVisualStyleBackColor = true;
            this.EjecutarButton.Click += new System.EventHandler(this.EjecutarButton_Click);
            // 
            // PrimerFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(372, 310);
            this.Controls.Add(this.EjecutarButton);
            this.Controls.Add(this.InteresesListBox);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PrimerFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Primer Formulario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox InteresesListBox;
        private System.Windows.Forms.Button EjecutarButton;
    }
}

