namespace Proyecto2Form.Formularios
{
    partial class UsuariosForm
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
            this.lblUsersWelcome = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnGuardarUsuario = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsersWelcome
            // 
            this.lblUsersWelcome.AutoSize = true;
            this.lblUsersWelcome.Location = new System.Drawing.Point(270, 21);
            this.lblUsersWelcome.Name = "lblUsersWelcome";
            this.lblUsersWelcome.Size = new System.Drawing.Size(331, 16);
            this.lblUsersWelcome.TabIndex = 0;
            this.lblUsersWelcome.Text = "RELLENE LOS CAMPOS PARA LE NUEVO USUARIO";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(97, 14);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(97, 77);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(76, 16);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Contraseña";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(97, 138);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(36, 16);
            this.lblRole.TabIndex = 4;
            this.lblRole.Text = "Role";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txtRole);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.btnGuardarUsuario);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.lblRole);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Location = new System.Drawing.Point(252, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 267);
            this.panel1.TabIndex = 5;
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(100, 167);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(162, 22);
            this.txtRole.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(100, 97);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(162, 22);
            this.txtPassword.TabIndex = 7;
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.Location = new System.Drawing.Point(140, 213);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarUsuario.TabIndex = 6;
            this.btnGuardarUsuario.Text = "Guardar";
            this.btnGuardarUsuario.UseVisualStyleBackColor = true;
            this.btnGuardarUsuario.Click += new System.EventHandler(this.btnGuardarUsuario_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(100, 34);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(162, 22);
            this.txtUsername.TabIndex = 6;
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(12, 392);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.RowHeadersWidth = 51;
            this.dataGridViewUsuarios.RowTemplate.Height = 24;
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(880, 101);
            this.dataGridViewUsuarios.TabIndex = 7;
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Location = new System.Drawing.Point(392, 510);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarUsuario.TabIndex = 8;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // UsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 570);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.dataGridViewUsuarios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUsersWelcome);
            this.Name = "UsuariosForm";
            this.Text = "UsuariosForm";
            this.Load += new System.EventHandler(this.FormularioUsuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsersWelcome;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnGuardarUsuario;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.Button btnEliminarUsuario;
    }
}