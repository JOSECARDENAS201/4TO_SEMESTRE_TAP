
namespace TAPU1_A4_PIDETEC_
{
    partial class InicioSesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpcInvitado = new System.Windows.Forms.CheckBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.TextBoxUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OpcInvitado
            // 
            this.OpcInvitado.AutoSize = true;
            this.OpcInvitado.Location = new System.Drawing.Point(103, 86);
            this.OpcInvitado.Name = "OpcInvitado";
            this.OpcInvitado.Size = new System.Drawing.Size(77, 17);
            this.OpcInvitado.TabIndex = 11;
            this.OpcInvitado.Text = "INVITADO";
            this.OpcInvitado.UseVisualStyleBackColor = true;
            this.OpcInvitado.CheckedChanged += new System.EventHandler(this.OpcInvitado_CheckedChanged);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(210, 82);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 10;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(291, 82);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 9;
            this.BtnAceptar.Text = "ACEPTAR";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(23, 32);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(56, 13);
            this.LblUsuario.TabIndex = 8;
            this.LblUsuario.Text = "USUARIO";
            // 
            // TextBoxUsuario
            // 
            this.TextBoxUsuario.ForeColor = System.Drawing.Color.Gray;
            this.TextBoxUsuario.Location = new System.Drawing.Point(103, 29);
            this.TextBoxUsuario.Name = "TextBoxUsuario";
            this.TextBoxUsuario.Size = new System.Drawing.Size(263, 20);
            this.TextBoxUsuario.TabIndex = 7;
            this.TextBoxUsuario.Text = "Ingrese su número de empleado o control";
            this.TextBoxUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxUsuario_KeyPress);
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 132);
            this.ControlBox = false;
            this.Controls.Add(this.OpcInvitado);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.TextBoxUsuario);
            this.Name = "InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INICIAR SESIÓN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox OpcInvitado;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.TextBox TextBoxUsuario;
    }
}

