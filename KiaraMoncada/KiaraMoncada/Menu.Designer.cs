namespace KiaraMoncada
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.primerFormularioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segundoFormularioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tercerFormularioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.primerFormularioToolStripMenuItem,
            this.segundoFormularioToolStripMenuItem,
            this.tercerFormularioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(447, 245);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // primerFormularioToolStripMenuItem
            // 
            this.primerFormularioToolStripMenuItem.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primerFormularioToolStripMenuItem.Name = "primerFormularioToolStripMenuItem";
            this.primerFormularioToolStripMenuItem.Size = new System.Drawing.Size(135, 241);
            this.primerFormularioToolStripMenuItem.Text = "Primer Formulario";
            this.primerFormularioToolStripMenuItem.Click += new System.EventHandler(this.primerFormularioToolStripMenuItem_Click);
            // 
            // segundoFormularioToolStripMenuItem
            // 
            this.segundoFormularioToolStripMenuItem.BackColor = System.Drawing.Color.Lavender;
            this.segundoFormularioToolStripMenuItem.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segundoFormularioToolStripMenuItem.Name = "segundoFormularioToolStripMenuItem";
            this.segundoFormularioToolStripMenuItem.Size = new System.Drawing.Size(149, 241);
            this.segundoFormularioToolStripMenuItem.Text = "Segundo Formulario";
            this.segundoFormularioToolStripMenuItem.Click += new System.EventHandler(this.segundoFormularioToolStripMenuItem_Click);
            // 
            // tercerFormularioToolStripMenuItem
            // 
            this.tercerFormularioToolStripMenuItem.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tercerFormularioToolStripMenuItem.Name = "tercerFormularioToolStripMenuItem";
            this.tercerFormularioToolStripMenuItem.Size = new System.Drawing.Size(134, 241);
            this.tercerFormularioToolStripMenuItem.Text = "Tercer Formulario";
            this.tercerFormularioToolStripMenuItem.Click += new System.EventHandler(this.tercerFormularioToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(447, 245);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem primerFormularioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segundoFormularioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tercerFormularioToolStripMenuItem;
    }
}