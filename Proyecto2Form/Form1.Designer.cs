namespace Proyecto2Form
{
    partial class Form1
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
            this.salasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.asToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxSalas = new System.Windows.Forms.ListBox();
            this.lblSalasDisplay = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salasToolStripMenuItem,
            this.pedidosToolStripMenuItem1,
            this.asToolStripMenuItem2,
            this.usuariosToolStripMenuItem,
            this.mesasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1304, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salasToolStripMenuItem
            // 
            this.salasToolStripMenuItem.Name = "salasToolStripMenuItem";
            this.salasToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.salasToolStripMenuItem.Text = "Salas";
            this.salasToolStripMenuItem.Click += new System.EventHandler(this.salasToolStripMenuItem_Click);
            // 
            // pedidosToolStripMenuItem1
            // 
            this.pedidosToolStripMenuItem1.Name = "pedidosToolStripMenuItem1";
            this.pedidosToolStripMenuItem1.Size = new System.Drawing.Size(75, 24);
            this.pedidosToolStripMenuItem1.Text = "Pedidos";
            this.pedidosToolStripMenuItem1.Click += new System.EventHandler(this.pedidosToolStripMenuItem1_Click);
            // 
            // asToolStripMenuItem2
            // 
            this.asToolStripMenuItem2.Name = "asToolStripMenuItem2";
            this.asToolStripMenuItem2.Size = new System.Drawing.Size(63, 24);
            this.asToolStripMenuItem2.Text = "Platos";
            this.asToolStripMenuItem2.Click += new System.EventHandler(this.asToolStripMenuItem2_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // mesasToolStripMenuItem
            // 
            this.mesasToolStripMenuItem.Name = "mesasToolStripMenuItem";
            this.mesasToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.mesasToolStripMenuItem.Text = "Mesas";
            this.mesasToolStripMenuItem.Click += new System.EventHandler(this.mesasToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.listBoxSalas);
            this.panel1.Controls.Add(this.lblSalasDisplay);
            this.panel1.Location = new System.Drawing.Point(1092, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 591);
            this.panel1.TabIndex = 4;
            // 
            // listBoxSalas
            // 
            this.listBoxSalas.FormattingEnabled = true;
            this.listBoxSalas.ItemHeight = 16;
            this.listBoxSalas.Location = new System.Drawing.Point(46, 69);
            this.listBoxSalas.Name = "listBoxSalas";
            this.listBoxSalas.Size = new System.Drawing.Size(120, 84);
            this.listBoxSalas.TabIndex = 1;
            this.listBoxSalas.SelectedIndexChanged += new System.EventHandler(this.listBoxSalas_SelectedIndexChanged);
            // 
            // lblSalasDisplay
            // 
            this.lblSalasDisplay.AutoSize = true;
            this.lblSalasDisplay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSalasDisplay.Location = new System.Drawing.Point(78, 11);
            this.lblSalasDisplay.Name = "lblSalasDisplay";
            this.lblSalasDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSalasDisplay.Size = new System.Drawing.Size(42, 16);
            this.lblSalasDisplay.TabIndex = 0;
            this.lblSalasDisplay.Text = "Salas";
            this.lblSalasDisplay.Click += new System.EventHandler(this.lblSalasDisplay_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1074, 330);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 624);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem asToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSalasDisplay;
        private System.Windows.Forms.ListBox listBoxSalas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem mesasToolStripMenuItem;
    }
}

