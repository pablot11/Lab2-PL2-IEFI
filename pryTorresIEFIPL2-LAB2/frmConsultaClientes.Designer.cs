﻿namespace pryTorresIEFIPL2_LAB2
{
    partial class frmConsultaClientes
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
            this.dgvConsultaClientes = new System.Windows.Forms.DataGridView();
            this.columnaUno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaDos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaTres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCuatro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListar = new System.Windows.Forms.Button();
            this.mrcListarClientes = new System.Windows.Forms.GroupBox();
            this.lblTotalSaldos = new System.Windows.Forms.Label();
            this.lblCantidadClientes = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblPromedioSaldos = new System.Windows.Forms.Label();
            this.txtTotalSaldos = new System.Windows.Forms.TextBox();
            this.txtPromedioSaldos = new System.Windows.Forms.TextBox();
            this.txtCantidadClientes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaClientes)).BeginInit();
            this.mrcListarClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConsultaClientes
            // 
            this.dgvConsultaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaUno,
            this.columnaDos,
            this.columnaTres,
            this.columnaCuatro});
            this.dgvConsultaClientes.Location = new System.Drawing.Point(6, 22);
            this.dgvConsultaClientes.Name = "dgvConsultaClientes";
            this.dgvConsultaClientes.Size = new System.Drawing.Size(436, 150);
            this.dgvConsultaClientes.TabIndex = 0;
            // 
            // columnaUno
            // 
            this.columnaUno.HeaderText = "DNI";
            this.columnaUno.Name = "columnaUno";
            this.columnaUno.ReadOnly = true;
            // 
            // columnaDos
            // 
            this.columnaDos.HeaderText = "Nombre";
            this.columnaDos.Name = "columnaDos";
            this.columnaDos.ReadOnly = true;
            // 
            // columnaTres
            // 
            this.columnaTres.HeaderText = "Apellido";
            this.columnaTres.Name = "columnaTres";
            this.columnaTres.ReadOnly = true;
            // 
            // columnaCuatro
            // 
            this.columnaCuatro.HeaderText = "Saldo";
            this.columnaCuatro.Name = "columnaCuatro";
            this.columnaCuatro.ReadOnly = true;
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(237, 175);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(205, 23);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // mrcListarClientes
            // 
            this.mrcListarClientes.Controls.Add(this.lblTotalSaldos);
            this.mrcListarClientes.Controls.Add(this.lblCantidadClientes);
            this.mrcListarClientes.Controls.Add(this.btnSalir);
            this.mrcListarClientes.Controls.Add(this.lblPromedioSaldos);
            this.mrcListarClientes.Controls.Add(this.dgvConsultaClientes);
            this.mrcListarClientes.Controls.Add(this.txtTotalSaldos);
            this.mrcListarClientes.Controls.Add(this.btnListar);
            this.mrcListarClientes.Controls.Add(this.txtPromedioSaldos);
            this.mrcListarClientes.Controls.Add(this.txtCantidadClientes);
            this.mrcListarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcListarClientes.Location = new System.Drawing.Point(12, 12);
            this.mrcListarClientes.Name = "mrcListarClientes";
            this.mrcListarClientes.Size = new System.Drawing.Size(454, 311);
            this.mrcListarClientes.TabIndex = 3;
            this.mrcListarClientes.TabStop = false;
            this.mrcListarClientes.Text = "Clientes:";
            this.mrcListarClientes.Enter += new System.EventHandler(this.mrcListarClientes_Enter);
            // 
            // lblTotalSaldos
            // 
            this.lblTotalSaldos.AutoSize = true;
            this.lblTotalSaldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSaldos.Location = new System.Drawing.Point(180, 219);
            this.lblTotalSaldos.Name = "lblTotalSaldos";
            this.lblTotalSaldos.Size = new System.Drawing.Size(87, 16);
            this.lblTotalSaldos.TabIndex = 0;
            this.lblTotalSaldos.Text = "Total Saldos:";
            // 
            // lblCantidadClientes
            // 
            this.lblCantidadClientes.AutoSize = true;
            this.lblCantidadClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadClientes.Location = new System.Drawing.Point(180, 248);
            this.lblCantidadClientes.Name = "lblCantidadClientes";
            this.lblCantidadClientes.Size = new System.Drawing.Size(134, 16);
            this.lblCantidadClientes.TabIndex = 1;
            this.lblCantidadClientes.Text = "Cantidad de Clientes:";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(6, 175);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(205, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblPromedioSaldos
            // 
            this.lblPromedioSaldos.AutoSize = true;
            this.lblPromedioSaldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioSaldos.Location = new System.Drawing.Point(180, 277);
            this.lblPromedioSaldos.Name = "lblPromedioSaldos";
            this.lblPromedioSaldos.Size = new System.Drawing.Size(134, 16);
            this.lblPromedioSaldos.TabIndex = 2;
            this.lblPromedioSaldos.Text = "Promedio de Saldos:";
            // 
            // txtTotalSaldos
            // 
            this.txtTotalSaldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSaldos.Location = new System.Drawing.Point(327, 219);
            this.txtTotalSaldos.Name = "txtTotalSaldos";
            this.txtTotalSaldos.ReadOnly = true;
            this.txtTotalSaldos.Size = new System.Drawing.Size(115, 21);
            this.txtTotalSaldos.TabIndex = 3;
            // 
            // txtPromedioSaldos
            // 
            this.txtPromedioSaldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromedioSaldos.Location = new System.Drawing.Point(327, 277);
            this.txtPromedioSaldos.Name = "txtPromedioSaldos";
            this.txtPromedioSaldos.ReadOnly = true;
            this.txtPromedioSaldos.Size = new System.Drawing.Size(115, 21);
            this.txtPromedioSaldos.TabIndex = 5;
            // 
            // txtCantidadClientes
            // 
            this.txtCantidadClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadClientes.Location = new System.Drawing.Point(327, 248);
            this.txtCantidadClientes.Name = "txtCantidadClientes";
            this.txtCantidadClientes.ReadOnly = true;
            this.txtCantidadClientes.Size = new System.Drawing.Size(115, 21);
            this.txtCantidadClientes.TabIndex = 4;
            // 
            // frmConsultaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 334);
            this.Controls.Add(this.mrcListarClientes);
            this.Name = "frmConsultaClientes";
            this.Text = "Consulta Clientes";
            this.Load += new System.EventHandler(this.frmConsultaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaClientes)).EndInit();
            this.mrcListarClientes.ResumeLayout(false);
            this.mrcListarClientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaClientes;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.GroupBox mrcListarClientes;
        private System.Windows.Forms.TextBox txtPromedioSaldos;
        private System.Windows.Forms.TextBox txtCantidadClientes;
        private System.Windows.Forms.TextBox txtTotalSaldos;
        private System.Windows.Forms.Label lblPromedioSaldos;
        private System.Windows.Forms.Label lblTotalSaldos;
        private System.Windows.Forms.Label lblCantidadClientes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaUno;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDos;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaTres;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCuatro;
    }
}