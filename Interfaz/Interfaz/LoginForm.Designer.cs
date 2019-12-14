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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usuarioTxt = new System.Windows.Forms.TextBox();
            this.contraseñaTxt = new System.Windows.Forms.TextBox();
            this.aceptarBtn = new System.Windows.Forms.Button();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.LoginErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.LoginErrorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.LoginErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginErrorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // usuarioTxt
            // 
            this.usuarioTxt.Location = new System.Drawing.Point(91, 22);
            this.usuarioTxt.Name = "usuarioTxt";
            this.usuarioTxt.Size = new System.Drawing.Size(249, 20);
            this.usuarioTxt.TabIndex = 2;
            this.usuarioTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BorrarUsuario);
            // 
            // contraseñaTxt
            // 
            this.contraseñaTxt.Location = new System.Drawing.Point(91, 63);
            this.contraseñaTxt.Name = "contraseñaTxt";
            this.contraseñaTxt.PasswordChar = '*';
            this.contraseñaTxt.Size = new System.Drawing.Size(249, 20);
            this.contraseñaTxt.TabIndex = 3;
            this.contraseñaTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BorrarContraseña);
            // 
            // aceptarBtn
            // 
            this.aceptarBtn.Location = new System.Drawing.Point(253, 120);
            this.aceptarBtn.Name = "aceptarBtn";
            this.aceptarBtn.Size = new System.Drawing.Size(87, 37);
            this.aceptarBtn.TabIndex = 4;
            this.aceptarBtn.Text = "Aceptar";
            this.aceptarBtn.UseVisualStyleBackColor = true;
            this.aceptarBtn.Click += new System.EventHandler(this.aceptarBtn_Click);
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelarBtn.Location = new System.Drawing.Point(24, 120);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(87, 37);
            this.cancelarBtn.TabIndex = 5;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // LoginErrorProvider1
            // 
            this.LoginErrorProvider1.ContainerControl = this;
            // 
            // LoginErrorProvider2
            // 
            this.LoginErrorProvider2.ContainerControl = this;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(221, 95);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(119, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Olvidó su contraseña?";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 166);
            this.Controls.Add(this.linkLabel1);
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
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BorrarUsuario);
            ((System.ComponentModel.ISupportInitialize)(this.LoginErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginErrorProvider2)).EndInit();
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
        private System.Windows.Forms.ErrorProvider LoginErrorProvider1;
        private System.Windows.Forms.ErrorProvider LoginErrorProvider2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

