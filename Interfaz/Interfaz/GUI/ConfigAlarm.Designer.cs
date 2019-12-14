namespace Interfaz.GUI
{
    partial class ConfigAlarm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.activeAlarm = new System.Windows.Forms.TextBox();
            this.agregarBtn = new System.Windows.Forms.Button();
            this.borrarBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mailRbtn = new System.Windows.Forms.RadioButton();
            this.textRbtn = new System.Windows.Forms.RadioButton();
            this.lunesChk = new System.Windows.Forms.CheckBox();
            this.martesChk = new System.Windows.Forms.CheckBox();
            this.miercolesChk = new System.Windows.Forms.CheckBox();
            this.viernesChk = new System.Windows.Forms.CheckBox();
            this.sabadoChk = new System.Windows.Forms.CheckBox();
            this.domingoChk = new System.Windows.Forms.CheckBox();
            this.juevesChk = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.activoRdo = new System.Windows.Forms.RadioButton();
            this.inactivoRdo = new System.Windows.Forms.RadioButton();
            this.limpiarBtn = new System.Windows.Forms.Button();
            this.establecerBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.borrarBtn);
            this.panel1.Controls.Add(this.agregarBtn);
            this.panel1.Controls.Add(this.activeAlarm);
            this.panel1.Location = new System.Drawing.Point(25, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 397);
            this.panel1.TabIndex = 0;
            // 
            // activeAlarm
            // 
            this.activeAlarm.Location = new System.Drawing.Point(20, 36);
            this.activeAlarm.Multiline = true;
            this.activeAlarm.Name = "activeAlarm";
            this.activeAlarm.Size = new System.Drawing.Size(157, 335);
            this.activeAlarm.TabIndex = 0;
            // 
            // agregarBtn
            // 
            this.agregarBtn.Location = new System.Drawing.Point(239, 36);
            this.agregarBtn.Name = "agregarBtn";
            this.agregarBtn.Size = new System.Drawing.Size(75, 23);
            this.agregarBtn.TabIndex = 1;
            this.agregarBtn.Text = "Agregar";
            this.agregarBtn.UseVisualStyleBackColor = true;
            // 
            // borrarBtn
            // 
            this.borrarBtn.Location = new System.Drawing.Point(239, 359);
            this.borrarBtn.Name = "borrarBtn";
            this.borrarBtn.Size = new System.Drawing.Size(75, 23);
            this.borrarBtn.TabIndex = 2;
            this.borrarBtn.Text = "Borrar";
            this.borrarBtn.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.establecerBtn);
            this.panel2.Controls.Add(this.limpiarBtn);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.juevesChk);
            this.panel2.Controls.Add(this.domingoChk);
            this.panel2.Controls.Add(this.sabadoChk);
            this.panel2.Controls.Add(this.viernesChk);
            this.panel2.Controls.Add(this.miercolesChk);
            this.panel2.Controls.Add(this.martesChk);
            this.panel2.Controls.Add(this.lunesChk);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(392, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 397);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Días:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(110, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textRbtn);
            this.panel3.Controls.Add(this.mailRbtn);
            this.panel3.Location = new System.Drawing.Point(110, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 70);
            this.panel3.TabIndex = 3;
            // 
            // mailRbtn
            // 
            this.mailRbtn.AutoSize = true;
            this.mailRbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mailRbtn.Location = new System.Drawing.Point(19, 14);
            this.mailRbtn.Name = "mailRbtn";
            this.mailRbtn.Size = new System.Drawing.Size(108, 17);
            this.mailRbtn.TabIndex = 0;
            this.mailRbtn.TabStop = true;
            this.mailRbtn.Text = "Avisar con correo";
            this.mailRbtn.UseVisualStyleBackColor = true;
            // 
            // textRbtn
            // 
            this.textRbtn.AutoSize = true;
            this.textRbtn.Location = new System.Drawing.Point(19, 38);
            this.textRbtn.Name = "textRbtn";
            this.textRbtn.Size = new System.Drawing.Size(158, 17);
            this.textRbtn.TabIndex = 1;
            this.textRbtn.TabStop = true;
            this.textRbtn.Text = "Avisar con mensaje de texto";
            this.textRbtn.UseVisualStyleBackColor = true;
            // 
            // lunesChk
            // 
            this.lunesChk.AutoSize = true;
            this.lunesChk.Location = new System.Drawing.Point(110, 183);
            this.lunesChk.Name = "lunesChk";
            this.lunesChk.Size = new System.Drawing.Size(61, 17);
            this.lunesChk.TabIndex = 4;
            this.lunesChk.Text = "Lunues";
            this.lunesChk.UseVisualStyleBackColor = true;
            // 
            // martesChk
            // 
            this.martesChk.AutoSize = true;
            this.martesChk.Location = new System.Drawing.Point(110, 206);
            this.martesChk.Name = "martesChk";
            this.martesChk.Size = new System.Drawing.Size(58, 17);
            this.martesChk.TabIndex = 5;
            this.martesChk.Text = "Martes";
            this.martesChk.UseVisualStyleBackColor = true;
            // 
            // miercolesChk
            // 
            this.miercolesChk.AutoSize = true;
            this.miercolesChk.Location = new System.Drawing.Point(110, 230);
            this.miercolesChk.Name = "miercolesChk";
            this.miercolesChk.Size = new System.Drawing.Size(71, 17);
            this.miercolesChk.TabIndex = 6;
            this.miercolesChk.Text = "Miércoles";
            this.miercolesChk.UseVisualStyleBackColor = true;
            // 
            // viernesChk
            // 
            this.viernesChk.AutoSize = true;
            this.viernesChk.Location = new System.Drawing.Point(208, 183);
            this.viernesChk.Name = "viernesChk";
            this.viernesChk.Size = new System.Drawing.Size(61, 17);
            this.viernesChk.TabIndex = 7;
            this.viernesChk.Text = "Viernes";
            this.viernesChk.UseVisualStyleBackColor = true;
            // 
            // sabadoChk
            // 
            this.sabadoChk.AutoSize = true;
            this.sabadoChk.Location = new System.Drawing.Point(208, 207);
            this.sabadoChk.Name = "sabadoChk";
            this.sabadoChk.Size = new System.Drawing.Size(63, 17);
            this.sabadoChk.TabIndex = 8;
            this.sabadoChk.Text = "Sábado";
            this.sabadoChk.UseVisualStyleBackColor = true;
            // 
            // domingoChk
            // 
            this.domingoChk.AutoSize = true;
            this.domingoChk.Location = new System.Drawing.Point(208, 231);
            this.domingoChk.Name = "domingoChk";
            this.domingoChk.Size = new System.Drawing.Size(68, 17);
            this.domingoChk.TabIndex = 9;
            this.domingoChk.Text = "Domingo";
            this.domingoChk.UseVisualStyleBackColor = true;
            this.domingoChk.CheckedChanged += new System.EventHandler(this.domingoChk_CheckedChanged);
            // 
            // juevesChk
            // 
            this.juevesChk.AutoSize = true;
            this.juevesChk.Location = new System.Drawing.Point(110, 254);
            this.juevesChk.Name = "juevesChk";
            this.juevesChk.Size = new System.Drawing.Size(60, 17);
            this.juevesChk.TabIndex = 10;
            this.juevesChk.Text = "Jueves";
            this.juevesChk.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.inactivoRdo);
            this.panel4.Controls.Add(this.activoRdo);
            this.panel4.Location = new System.Drawing.Point(101, 288);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(209, 56);
            this.panel4.TabIndex = 11;
            // 
            // activoRdo
            // 
            this.activoRdo.AutoSize = true;
            this.activoRdo.Location = new System.Drawing.Point(28, 5);
            this.activoRdo.Name = "activoRdo";
            this.activoRdo.Size = new System.Drawing.Size(55, 17);
            this.activoRdo.TabIndex = 0;
            this.activoRdo.TabStop = true;
            this.activoRdo.Text = "Activa";
            this.activoRdo.UseVisualStyleBackColor = true;
            // 
            // inactivoRdo
            // 
            this.inactivoRdo.AutoSize = true;
            this.inactivoRdo.Location = new System.Drawing.Point(28, 28);
            this.inactivoRdo.Name = "inactivoRdo";
            this.inactivoRdo.Size = new System.Drawing.Size(63, 17);
            this.inactivoRdo.TabIndex = 1;
            this.inactivoRdo.TabStop = true;
            this.inactivoRdo.Text = "Inactiva";
            this.inactivoRdo.UseVisualStyleBackColor = true;
            // 
            // limpiarBtn
            // 
            this.limpiarBtn.Location = new System.Drawing.Point(57, 359);
            this.limpiarBtn.Name = "limpiarBtn";
            this.limpiarBtn.Size = new System.Drawing.Size(75, 23);
            this.limpiarBtn.TabIndex = 12;
            this.limpiarBtn.Text = "Limpiar";
            this.limpiarBtn.UseVisualStyleBackColor = true;
            // 
            // establecerBtn
            // 
            this.establecerBtn.Location = new System.Drawing.Point(255, 359);
            this.establecerBtn.Name = "establecerBtn";
            this.establecerBtn.Size = new System.Drawing.Size(75, 23);
            this.establecerBtn.TabIndex = 13;
            this.establecerBtn.Text = "Establecer";
            this.establecerBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Alarmas activas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Información de alarma";
            // 
            // ConfigAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ConfigAlarm";
            this.ShowIcon = false;
            this.Text = "Configuración de alarmas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button borrarBtn;
        private System.Windows.Forms.Button agregarBtn;
        private System.Windows.Forms.TextBox activeAlarm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton textRbtn;
        private System.Windows.Forms.RadioButton mailRbtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button establecerBtn;
        private System.Windows.Forms.Button limpiarBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton inactivoRdo;
        private System.Windows.Forms.RadioButton activoRdo;
        private System.Windows.Forms.CheckBox juevesChk;
        private System.Windows.Forms.CheckBox domingoChk;
        private System.Windows.Forms.CheckBox sabadoChk;
        private System.Windows.Forms.CheckBox viernesChk;
        private System.Windows.Forms.CheckBox miercolesChk;
        private System.Windows.Forms.CheckBox martesChk;
        private System.Windows.Forms.CheckBox lunesChk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}