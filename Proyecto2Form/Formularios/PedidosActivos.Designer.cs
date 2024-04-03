namespace Proyecto2Form.Formularios
{
    partial class PedidosActivos
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
            this.dataGridViewPedidosActivos = new System.Windows.Forms.DataGridView();
            this.btnFinalizarPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidosActivos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPedidosActivos
            // 
            this.dataGridViewPedidosActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidosActivos.Location = new System.Drawing.Point(12, 24);
            this.dataGridViewPedidosActivos.Name = "dataGridViewPedidosActivos";
            this.dataGridViewPedidosActivos.RowHeadersWidth = 51;
            this.dataGridViewPedidosActivos.RowTemplate.Height = 24;
            this.dataGridViewPedidosActivos.Size = new System.Drawing.Size(776, 261);
            this.dataGridViewPedidosActivos.TabIndex = 0;
            // 
            // btnFinalizarPedido
            // 
            this.btnFinalizarPedido.Location = new System.Drawing.Point(383, 333);
            this.btnFinalizarPedido.Name = "btnFinalizarPedido";
            this.btnFinalizarPedido.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizarPedido.TabIndex = 1;
            this.btnFinalizarPedido.Text = "Finalizar Pedido";
            this.btnFinalizarPedido.UseVisualStyleBackColor = true;
            this.btnFinalizarPedido.Click += new System.EventHandler(this.btnFinalizarPedido_Click);
            // 
            // PedidosActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFinalizarPedido);
            this.Controls.Add(this.dataGridViewPedidosActivos);
            this.Name = "PedidosActivos";
            this.Text = "PedidosActivos";
            this.Load += new System.EventHandler(this.PedidosActivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidosActivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPedidosActivos;
        private System.Windows.Forms.Button btnFinalizarPedido;
    }
}