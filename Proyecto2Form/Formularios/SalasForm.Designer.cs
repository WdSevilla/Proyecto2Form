namespace Proyecto2Form.Formularios
{
    partial class SalasForm
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
            this.txtNombreSala = new System.Windows.Forms.TextBox();
            this.lblNombreSala = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.dataGridViewSalas = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreSala
            // 
            this.txtNombreSala.Location = new System.Drawing.Point(354, 66);
            this.txtNombreSala.Name = "txtNombreSala";
            this.txtNombreSala.Size = new System.Drawing.Size(100, 22);
            this.txtNombreSala.TabIndex = 0;
            // 
            // lblNombreSala
            // 
            this.lblNombreSala.AutoSize = true;
            this.lblNombreSala.Location = new System.Drawing.Point(351, 47);
            this.lblNombreSala.Name = "lblNombreSala";
            this.lblNombreSala.Size = new System.Drawing.Size(56, 16);
            this.lblNombreSala.TabIndex = 1;
            this.lblNombreSala.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Capacidad";
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(357, 130);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(100, 22);
            this.txtCapacidad.TabIndex = 3;
            // 
            // dataGridViewSalas
            // 
            this.dataGridViewSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalas.Location = new System.Drawing.Point(221, 248);
            this.dataGridViewSalas.Name = "dataGridViewSalas";
            this.dataGridViewSalas.RowHeadersWidth = 51;
            this.dataGridViewSalas.RowTemplate.Height = 24;
            this.dataGridViewSalas.Size = new System.Drawing.Size(401, 150);
            this.dataGridViewSalas.TabIndex = 4;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(563, 102);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // SalasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dataGridViewSalas);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombreSala);
            this.Controls.Add(this.txtNombreSala);
            this.Name = "SalasForm";
            this.Text = "SalasForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreSala;
        private System.Windows.Forms.Label lblNombreSala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.DataGridView dataGridViewSalas;
        private System.Windows.Forms.Button btnGuardar;
    }
}