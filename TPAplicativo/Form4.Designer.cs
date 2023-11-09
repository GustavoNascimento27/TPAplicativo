
namespace TPAplicativo
{
    partial class Form4
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
            this.txtcom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnc1 = new System.Windows.Forms.Button();
            this.txtl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcomp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtr = new System.Windows.Forms.TextBox();
            this.lblc_r = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtcom
            // 
            this.txtcom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcom.Location = new System.Drawing.Point(401, 49);
            this.txtcom.Name = "txtcom";
            this.txtcom.Size = new System.Drawing.Size(253, 44);
            this.txtcom.TabIndex = 4;
            this.txtcom.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtcom_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite o nome do comôdo";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.voltarToolStripMenuItem.Text = "Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // btnc1
            // 
            this.btnc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnc1.Location = new System.Drawing.Point(19, 209);
            this.btnc1.Name = "btnc1";
            this.btnc1.Size = new System.Drawing.Size(148, 39);
            this.btnc1.TabIndex = 11;
            this.btnc1.Text = "CALCULAR";
            this.btnc1.UseVisualStyleBackColor = true;
            this.btnc1.Click += new System.EventHandler(this.btnc1_Click);
            // 
            // txtl
            // 
            this.txtl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtl.Location = new System.Drawing.Point(253, 102);
            this.txtl.Name = "txtl";
            this.txtl.Size = new System.Drawing.Size(253, 44);
            this.txtl.TabIndex = 15;
            this.txtl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtl_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 37);
            this.label2.TabIndex = 14;
            this.label2.Text = "Digite a largura";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtcomp
            // 
            this.txtcomp.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomp.Location = new System.Drawing.Point(338, 159);
            this.txtcomp.Name = "txtcomp";
            this.txtcomp.Size = new System.Drawing.Size(253, 44);
            this.txtcomp.TabIndex = 17;
            this.txtcomp.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtcomp_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 37);
            this.label3.TabIndex = 16;
            this.label3.Text = "Digite o comprimento";
            // 
            // txtr
            // 
            this.txtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtr.Location = new System.Drawing.Point(36, 329);
            this.txtr.Name = "txtr";
            this.txtr.Size = new System.Drawing.Size(263, 40);
            this.txtr.TabIndex = 19;
            this.txtr.Visible = false;
            this.txtr.Leave += new System.EventHandler(this.txtr_Leave);
            // 
            // lblc_r
            // 
            this.lblc_r.AutoSize = true;
            this.lblc_r.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblc_r.Location = new System.Drawing.Point(29, 289);
            this.lblc_r.Name = "lblc_r";
            this.lblc_r.Size = new System.Drawing.Size(174, 37);
            this.lblc_r.TabIndex = 18;
            this.lblc_r.Text = "Continuar?";
            this.lblc_r.Visible = false;
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(184, 209);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(148, 39);
            this.btnclear.TabIndex = 20;
            this.btnclear.Text = "LIMPAR";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.txtr);
            this.Controls.Add(this.lblc_r);
            this.Controls.Add(this.txtcomp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnc1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtcom);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio 13";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.Button btnc1;
        private System.Windows.Forms.TextBox txtl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcomp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtr;
        private System.Windows.Forms.Label lblc_r;
        private System.Windows.Forms.Button btnclear;
    }
}