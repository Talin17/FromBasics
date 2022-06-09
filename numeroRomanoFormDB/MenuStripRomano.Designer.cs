namespace numeroRomanoFormDB
{
    partial class MenuStripRomano
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
            this.convertirARomanoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoRomanoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertirARomanoToolStripMenuItem,
            this.mantenimientoRomanoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(316, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // convertirARomanoToolStripMenuItem
            // 
            this.convertirARomanoToolStripMenuItem.Name = "convertirARomanoToolStripMenuItem";
            this.convertirARomanoToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.convertirARomanoToolStripMenuItem.Text = "Convertir a Romano";
            this.convertirARomanoToolStripMenuItem.Click += new System.EventHandler(this.convertirARomanoToolStripMenuItem_Click);
            // 
            // mantenimientoRomanoToolStripMenuItem
            // 
            this.mantenimientoRomanoToolStripMenuItem.Name = "mantenimientoRomanoToolStripMenuItem";
            this.mantenimientoRomanoToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.mantenimientoRomanoToolStripMenuItem.Text = "Mantenimiento Romano";
            this.mantenimientoRomanoToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoRomanoToolStripMenuItem_Click);
            // 
            // MenuStripRomano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 84);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuStripRomano";
            this.Text = "MenuStripRomano";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem convertirARomanoToolStripMenuItem;
        private ToolStripMenuItem mantenimientoRomanoToolStripMenuItem;
    }
}