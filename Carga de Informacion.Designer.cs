
namespace SISTEMA_DE_DEUDA
{
    partial class fmcarga
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
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.LblApellido = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtdeuda = new System.Windows.Forms.TextBox();
            this.dgvdeuda = new System.Windows.Forms.DataGridView();
            this.dtpfechapago = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpvencimiento = new System.Windows.Forms.DateTimePicker();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtdescuento = new System.Windows.Forms.TextBox();
            this.lblrecargo = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeuda)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(610, 261);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(94, 29);
            this.BtnAgregar.TabIndex = 0;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(22, 38);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(66, 20);
            this.LblApellido.TabIndex = 1;
            this.LblApellido.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de Vencimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha de Pago";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Importe de la Deuda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(610, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Recargo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(610, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total a Pagar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(414, 261);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 29);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(193, 31);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(315, 27);
            this.txtapellido.TabIndex = 8;
            // 
            // txtdeuda
            // 
            this.txtdeuda.Location = new System.Drawing.Point(193, 216);
            this.txtdeuda.Name = "txtdeuda";
            this.txtdeuda.Size = new System.Drawing.Size(315, 27);
            this.txtdeuda.TabIndex = 11;
            // 
            // dgvdeuda
            // 
            this.dgvdeuda.AllowUserToOrderColumns = true;
            this.dgvdeuda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdeuda.Location = new System.Drawing.Point(12, 296);
            this.dgvdeuda.Name = "dgvdeuda";
            this.dgvdeuda.RowHeadersWidth = 51;
            this.dgvdeuda.RowTemplate.Height = 29;
            this.dgvdeuda.Size = new System.Drawing.Size(1110, 235);
            this.dgvdeuda.TabIndex = 14;
            // 
            // dtpfechapago
            // 
            this.dtpfechapago.Location = new System.Drawing.Point(193, 173);
            this.dtpfechapago.Name = "dtpfechapago";
            this.dtpfechapago.Size = new System.Drawing.Size(315, 27);
            this.dtpfechapago.TabIndex = 15;
            this.dtpfechapago.Value = new System.DateTime(2022, 3, 27, 21, 9, 57, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(610, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Descuento";
            // 
            // dtpvencimiento
            // 
            this.dtpvencimiento.Location = new System.Drawing.Point(193, 122);
            this.dtpvencimiento.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.dtpvencimiento.Name = "dtpvencimiento";
            this.dtpvencimiento.Size = new System.Drawing.Size(315, 27);
            this.dtpvencimiento.TabIndex = 19;
            this.dtpvencimiento.Value = new System.DateTime(2022, 3, 10, 0, 0, 0, 0);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 78);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 21;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.UseWaitCursor = true;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(193, 78);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(315, 27);
            this.txtnombre.TabIndex = 22;
            // 
            // txtdescuento
            // 
            this.txtdescuento.Location = new System.Drawing.Point(741, 31);
            this.txtdescuento.Name = "txtdescuento";
            this.txtdescuento.Size = new System.Drawing.Size(167, 27);
            this.txtdescuento.TabIndex = 24;
            // 
            // lblrecargo
            // 
            this.lblrecargo.AutoSize = true;
            this.lblrecargo.Location = new System.Drawing.Point(741, 78);
            this.lblrecargo.Name = "lblrecargo";
            this.lblrecargo.Size = new System.Drawing.Size(64, 20);
            this.lblrecargo.TabIndex = 26;
            this.lblrecargo.Text = "Recargo";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(741, 127);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(40, 20);
            this.lbltotal.TabIndex = 27;
            this.lbltotal.Text = "total";
            // 
            // fmcarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 543);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblrecargo);
            this.Controls.Add(this.txtdescuento);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dtpvencimiento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpfechapago);
            this.Controls.Add(this.dgvdeuda);
            this.Controls.Add(this.txtdeuda);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.BtnAgregar);
            this.Name = "fmcarga";
            this.Text = "Carga de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeuda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtdeuda;
        private System.Windows.Forms.DataGridView dgvdeuda;
        private System.Windows.Forms.DateTimePicker dtpfechapago;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpvencimiento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtdescuento;
        private System.Windows.Forms.Label lblrecargo;
        private System.Windows.Forms.Label lbltotal;
    }
}