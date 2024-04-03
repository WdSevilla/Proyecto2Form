namespace Proyecto2Form.Formularios
{
    partial class PlatosForm
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
            this.lblPlateName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPlate = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnSavePlate = new System.Windows.Forms.Button();
            this.dataGridViewPlatos = new System.Windows.Forms.DataGridView();
            this.btnShowPlates = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlateName
            // 
            this.lblPlateName.AutoSize = true;
            this.lblPlateName.Location = new System.Drawing.Point(348, 26);
            this.lblPlateName.Name = "lblPlateName";
            this.lblPlateName.Size = new System.Drawing.Size(38, 16);
            this.lblPlateName.TabIndex = 0;
            this.lblPlateName.Text = "Plato";
            this.lblPlateName.Click += new System.EventHandler(this.lblPlateName_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(348, 79);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 16);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Descripcion";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(348, 199);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(46, 16);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Precio";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // txtPlate
            // 
            this.txtPlate.Location = new System.Drawing.Point(351, 45);
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.Size = new System.Drawing.Size(100, 22);
            this.txtPlate.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(351, 98);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(188, 98);
            this.txtDescription.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(351, 233);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(188, 22);
            this.txtPrice.TabIndex = 5;
            // 
            // btnSavePlate
            // 
            this.btnSavePlate.Location = new System.Drawing.Point(579, 138);
            this.btnSavePlate.Name = "btnSavePlate";
            this.btnSavePlate.Size = new System.Drawing.Size(75, 23);
            this.btnSavePlate.TabIndex = 6;
            this.btnSavePlate.Text = "Guardar";
            this.btnSavePlate.UseVisualStyleBackColor = true;
            this.btnSavePlate.Click += new System.EventHandler(this.btnSavePlate_Click);
            // 
            // dataGridViewPlatos
            // 
            this.dataGridViewPlatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlatos.Location = new System.Drawing.Point(12, 288);
            this.dataGridViewPlatos.Name = "dataGridViewPlatos";
            this.dataGridViewPlatos.RowHeadersWidth = 51;
            this.dataGridViewPlatos.RowTemplate.Height = 24;
            this.dataGridViewPlatos.Size = new System.Drawing.Size(776, 150);
            this.dataGridViewPlatos.TabIndex = 7;
            // 
            // btnShowPlates
            // 
            this.btnShowPlates.Location = new System.Drawing.Point(376, 474);
            this.btnShowPlates.Name = "btnShowPlates";
            this.btnShowPlates.Size = new System.Drawing.Size(101, 23);
            this.btnShowPlates.TabIndex = 8;
            this.btnShowPlates.Text = "Mostrar Platos";
            this.btnShowPlates.UseVisualStyleBackColor = true;
            // 
            // PlatosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.btnShowPlates);
            this.Controls.Add(this.dataGridViewPlatos);
            this.Controls.Add(this.btnSavePlate);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtPlate);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPlateName);
            this.Name = "PlatosForm";
            this.Text = "PlatosForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlateName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPlate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnSavePlate;
        private System.Windows.Forms.DataGridView dataGridViewPlatos;
        private System.Windows.Forms.Button btnShowPlates;
    }
}