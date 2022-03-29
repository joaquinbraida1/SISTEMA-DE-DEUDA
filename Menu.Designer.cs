
namespace SISTEMA_DE_DEUDA
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cargaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargaToolStripMenuItem,
            this.visualizacionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cargaToolStripMenuItem
            // 
            this.cargaToolStripMenuItem.Name = "cargaToolStripMenuItem";
            this.cargaToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.cargaToolStripMenuItem.Text = "Carga";
            this.cargaToolStripMenuItem.Click += new System.EventHandler(this.cargaToolStripMenuItem_Click);
            // 
            // visualizacionToolStripMenuItem
            // 
            this.visualizacionToolStripMenuItem.Name = "visualizacionToolStripMenuItem";
            this.visualizacionToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.visualizacionToolStripMenuItem.Text = "Salir del Programa";
            this.visualizacionToolStripMenuItem.Click += new System.EventHandler(this.visualizacionToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cargaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizacionToolStripMenuItem;
    }
}

