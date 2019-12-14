namespace Interfaz
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usuarioTxt = new System.Windows.Forms.TextBox();
            this.contraseñaTxt = new System.Windows.Forms.TextBox();
            this.aceptarBtn = new System.Windows.Forms.Button();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // usuarioTxt
            // 
            this.usuarioTxt.Location = new System.Drawing.Point(91, 37);
            this.usuarioTxt.Name = "usuarioTxt";
            this.usuarioTxt.Size = new System.Drawing.Size(207, 20);
            this.usuarioTxt.TabIndex = 2;
            // 
            // contraseñaTxt
            // 
            this.contraseñaTxt.Location = new System.Drawing.Point(91, 77);
            this.contraseñaTxt.Name = "contraseñaTxt";
            this.contraseñaTxt.PasswordChar = '*';
            this.contraseñaTxt.Size = new System.Drawing.Size(207, 20);
            this.contraseñaTxt.TabIndex = 3;
            this.contraseñaTxt.TextChanged += new System.EventHandler(this.contraseñaTxt_TextChanged);
            // 
            // aceptarBtn
            // 
            this.aceptarBtn.Location = new System.Drawing.Point(211, 151);
            this.aceptarBtn.Name = "aceptarBtn";
            this.aceptarBtn.Size = new System.Drawing.Size(87, 37);
            this.aceptarBtn.TabIndex = 4;
            this.aceptarBtn.Text = "Aceptar";
            this.aceptarBtn.UseVisualStyleBackColor = true;
            this.aceptarBtn.MouseEnter += new System.EventHandler(this.Form1_Load);
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(24, 151);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(87, 37);
            this.cancelarBtn.TabIndex = 5;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Olvidó su contraseña?";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 206);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.aceptarBtn);
            this.Controls.Add(this.contraseñaTxt);
            this.Controls.Add(this.usuarioTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.Text = "Bienvenido al sistema";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usuarioTxt;
        private System.Windows.Forms.TextBox contraseñaTxt;
        private System.Windows.Forms.Button aceptarBtn;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Label label3;
    }
}

