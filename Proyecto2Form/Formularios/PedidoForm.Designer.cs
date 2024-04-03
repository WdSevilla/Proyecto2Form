namespace Proyecto2Form.Formularios
{
    partial class PedidoForm
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
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.btnGuardarPedido = new System.Windows.Forms.Button();
            this.dataGridViewPlatoPedido = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewPlatos = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnTerminarPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlatoPedido)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlatos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(449, 35);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(394, 77);
            this.txtComentario.TabIndex = 0;
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Location = new System.Drawing.Point(360, 38);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(83, 16);
            this.lblComentarios.TabIndex = 1;
            this.lblComentarios.Text = "Comentarios";
            // 
            // btnGuardarPedido
            // 
            this.btnGuardarPedido.Location = new System.Drawing.Point(861, 38);
            this.btnGuardarPedido.Name = "btnGuardarPedido";
            this.btnGuardarPedido.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarPedido.TabIndex = 2;
            this.btnGuardarPedido.Text = "Guardar";
            this.btnGuardarPedido.UseVisualStyleBackColor = true;
            this.btnGuardarPedido.Click += new System.EventHandler(this.btnAgregarComentario_Click);
            // 
            // dataGridViewPlatoPedido
            // 
            this.dataGridViewPlatoPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlatoPedido.Location = new System.Drawing.Point(82, 143);
            this.dataGridViewPlatoPedido.Name = "dataGridViewPlatoPedido";
            this.dataGridViewPlatoPedido.RowHeadersWidth = 51;
            this.dataGridViewPlatoPedido.RowTemplate.Height = 24;
            this.dataGridViewPlatoPedido.Size = new System.Drawing.Size(534, 232);
            this.dataGridViewPlatoPedido.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.dataGridViewPlatos);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Location = new System.Drawing.Point(842, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 423);
            this.panel1.TabIndex = 4;
            // 
            // dataGridViewPlatos
            // 
            this.dataGridViewPlatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlatos.Location = new System.Drawing.Point(6, 57);
            this.dataGridViewPlatos.Name = "dataGridViewPlatos";
            this.dataGridViewPlatos.RowHeadersWidth = 51;
            this.dataGridViewPlatos.RowTemplate.Height = 24;
            this.dataGridViewPlatos.Size = new System.Drawing.Size(331, 351);
            this.dataGridViewPlatos.TabIndex = 2;
            this.dataGridViewPlatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPlatos_CellClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(293, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBuscar.Size = new System.Drawing.Size(44, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "+";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(6, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(281, 22);
            this.txtBuscar.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(505, 402);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 16);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(297, 499);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(516, 434);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 7;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(73, 35);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(54, 16);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "Usuario";
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Location = new System.Drawing.Point(133, 35);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(121, 24);
            this.comboBoxUsers.TabIndex = 9;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(76, 95);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(48, 16);
            this.lblCliente.TabIndex = 10;
            this.lblCliente.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(130, 92);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(124, 22);
            this.txtCliente.TabIndex = 11;
            // 
            // btnTerminarPedido
            // 
            this.btnTerminarPedido.Location = new System.Drawing.Point(508, 498);
            this.btnTerminarPedido.Name = "btnTerminarPedido";
            this.btnTerminarPedido.Size = new System.Drawing.Size(98, 23);
            this.btnTerminarPedido.TabIndex = 12;
            this.btnTerminarPedido.Text = "Cerrar Mesa";
            this.btnTerminarPedido.UseVisualStyleBackColor = true;
            this.btnTerminarPedido.Click += new System.EventHandler(this.btnTerminarPedido_Click);
            // 
            // PedidoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 563);
            this.Controls.Add(this.btnTerminarPedido);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.comboBoxUsers);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewPlatoPedido);
            this.Controls.Add(this.btnGuardarPedido);
            this.Controls.Add(this.lblComentarios);
            this.Controls.Add(this.txtComentario);
            this.Name = "PedidoForm";
            this.Text = "PedidoForm";
            this.Load += new System.EventHandler(this.PedidoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlatoPedido)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.Button btnGuardarPedido;
        private System.Windows.Forms.DataGridView dataGridViewPlatoPedido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewPlatos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ComboBox comboBoxUsers;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnTerminarPedido;
    }
}