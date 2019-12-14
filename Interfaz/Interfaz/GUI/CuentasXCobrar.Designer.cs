namespace Interfaz.GUI
{
    partial class CuentasXCobrar
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cerrarBtn = new System.Windows.Forms.Button();
            this.imprimirBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 375);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(661, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cedula,
            this.Nombre,
            this.Monto,
            this.Telefono,
            this.Direccion});
            this.dataGridView1.Location = new System.Drawing.Point(63, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 217);
            this.dataGridView1.TabIndex = 4;
            // 
            // Cedula
            // 
            this.Cedula.Frozen = true;
            this.Cedula.HeaderText = "Cédula";
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.Frozen = true;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.Frozen = true;
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.Frozen = true;
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.Frozen = true;
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Resumen de cuentas por cobrar @año";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cerrarBtn
            // 
            this.cerrarBtn.Location = new System.Drawing.Point(63, 349);
            this.cerrarBtn.Name = "cerrarBtn";
            this.cerrarBtn.Size = new System.Drawing.Size(75, 23);
            this.cerrarBtn.TabIndex = 6;
            this.cerrarBtn.Text = "Cerrar";
            this.cerrarBtn.UseVisualStyleBackColor = true;
            // 
            // imprimirBtn
            // 
            this.imprimirBtn.Location = new System.Drawing.Point(530, 349);
            this.imprimirBtn.Name = "imprimirBtn";
            this.imprimirBtn.Size = new System.Drawing.Size(75, 23);
            this.imprimirBtn.TabIndex = 7;
            this.imprimirBtn.Text = "Imprimir";
            this.imprimirBtn.UseVisualStyleBackColor = true;
            // 
            // CuentasXCobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 397);
            this.Controls.Add(this.imprimirBtn);
            this.Controls.Add(this.cerrarBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "CuentasXCobrar";
            this.ShowIcon = false;
            this.Text = "Cuentas por cobrar";
            this.Load += new System.EventHandler(this.CuentasXCobrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cerrarBtn;
        private System.Windows.Forms.Button imprimirBtn;
    }
}