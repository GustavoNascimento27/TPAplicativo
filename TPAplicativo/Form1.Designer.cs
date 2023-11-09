
namespace TPAplicativo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aplicativosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercício11AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercíciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercício13ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aplicativosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aplicativosToolStripMenuItem
            // 
            this.aplicativosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercício11AToolStripMenuItem,
            this.exercíciToolStripMenuItem,
            this.exercício13ToolStripMenuItem});
            this.aplicativosToolStripMenuItem.Name = "aplicativosToolStripMenuItem";
            this.aplicativosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.aplicativosToolStripMenuItem.Text = "Aplicativos";
            // 
            // exercício11AToolStripMenuItem
            // 
            this.exercício11AToolStripMenuItem.Name = "exercício11AToolStripMenuItem";
            this.exercício11AToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.exercício11AToolStripMenuItem.Text = "Exercício 11 ";
            this.exercício11AToolStripMenuItem.Click += new System.EventHandler(this.exercício11AToolStripMenuItem_Click);
            // 
            // exercíciToolStripMenuItem
            // 
            this.exercíciToolStripMenuItem.Name = "exercíciToolStripMenuItem";
            this.exercíciToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.exercíciToolStripMenuItem.Text = "Exercício 12";
            this.exercíciToolStripMenuItem.Click += new System.EventHandler(this.exercíciToolStripMenuItem_Click);
            // 
            // exercício13ToolStripMenuItem
            // 
            this.exercício13ToolStripMenuItem.Name = "exercício13ToolStripMenuItem";
            this.exercício13ToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.exercício13ToolStripMenuItem.Text = "Exercício 13";
            this.exercício13ToolStripMenuItem.Click += new System.EventHandler(this.exercício13ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TPAplicativo.Properties.Resources.xj;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tpaplicativo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aplicativosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercício11AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercíciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercício13ToolStripMenuItem;
    }
}

