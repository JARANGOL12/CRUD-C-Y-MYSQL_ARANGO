namespace Sol_Alamcen.Presentacion
{
    partial class btnMedida
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
            this.Dvg_articulos = new System.Windows.Forms.DataGridView();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcion_um = new System.Windows.Forms.TextBox();
            this.txtDescripcion_ar = new System.Windows.Forms.TextBox();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStock_Actual = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.bntBuscar = new System.Windows.Forms.Button();
            this.BtnMedida_um = new System.Windows.Forms.Button();
            this.bntActualizar = new System.Windows.Forms.Button();
            this.bntReporte = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_articulos)).BeginInit();
            this.SuspendLayout();
            // 
            // Dvg_articulos
            // 
            this.Dvg_articulos.AllowUserToAddRows = false;
            this.Dvg_articulos.AllowUserToDeleteRows = false;
            this.Dvg_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dvg_articulos.Location = new System.Drawing.Point(12, 241);
            this.Dvg_articulos.Name = "Dvg_articulos";
            this.Dvg_articulos.ReadOnly = true;
            this.Dvg_articulos.Size = new System.Drawing.Size(722, 197);
            this.Dvg_articulos.TabIndex = 0;
            this.Dvg_articulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dvg_articulos_CellClick);
            // 
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(82, 23);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(206, 20);
            this.txtArticulo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Articulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Marca";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(494, 27);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(183, 20);
            this.txtMarca.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Medida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Categoria";
            // 
            // txtDescripcion_um
            // 
            this.txtDescripcion_um.Location = new System.Drawing.Point(82, 64);
            this.txtDescripcion_um.Name = "txtDescripcion_um";
            this.txtDescripcion_um.Size = new System.Drawing.Size(206, 20);
            this.txtDescripcion_um.TabIndex = 8;
            // 
            // txtDescripcion_ar
            // 
            this.txtDescripcion_ar.Location = new System.Drawing.Point(494, 69);
            this.txtDescripcion_ar.Name = "txtDescripcion_ar";
            this.txtDescripcion_ar.Size = new System.Drawing.Size(183, 20);
            this.txtDescripcion_ar.TabIndex = 9;
            // 
            // btnCategoria
            // 
            this.btnCategoria.Location = new System.Drawing.Point(692, 64);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(31, 23);
            this.btnCategoria.TabIndex = 11;
            this.btnCategoria.Text = ":::";
            this.btnCategoria.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(356, 212);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(459, 212);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Stock_Actual";
            // 
            // txtStock_Actual
            // 
            this.txtStock_Actual.Location = new System.Drawing.Point(304, 119);
            this.txtStock_Actual.Name = "txtStock_Actual";
            this.txtStock_Actual.Size = new System.Drawing.Size(151, 20);
            this.txtStock_Actual.TabIndex = 15;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(796, 30);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 54);
            this.btnNuevo.TabIndex = 16;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(58, 212);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(196, 20);
            this.txtBuscar.TabIndex = 19;
            // 
            // bntBuscar
            // 
            this.bntBuscar.Location = new System.Drawing.Point(260, 212);
            this.bntBuscar.Name = "bntBuscar";
            this.bntBuscar.Size = new System.Drawing.Size(33, 23);
            this.bntBuscar.TabIndex = 20;
            this.bntBuscar.Text = ":::";
            this.bntBuscar.UseVisualStyleBackColor = true;
            // 
            // BtnMedida_um
            // 
            this.BtnMedida_um.Location = new System.Drawing.Point(294, 62);
            this.BtnMedida_um.Name = "BtnMedida_um";
            this.BtnMedida_um.Size = new System.Drawing.Size(31, 23);
            this.BtnMedida_um.TabIndex = 21;
            this.BtnMedida_um.Text = ":::";
            this.BtnMedida_um.UseVisualStyleBackColor = true;
            // 
            // bntActualizar
            // 
            this.bntActualizar.Location = new System.Drawing.Point(796, 140);
            this.bntActualizar.Name = "bntActualizar";
            this.bntActualizar.Size = new System.Drawing.Size(75, 46);
            this.bntActualizar.TabIndex = 22;
            this.bntActualizar.Text = "Actualizar";
            this.bntActualizar.UseVisualStyleBackColor = true;
            this.bntActualizar.Click += new System.EventHandler(this.bntActualizar_Click);
            // 
            // bntReporte
            // 
            this.bntReporte.Location = new System.Drawing.Point(796, 299);
            this.bntReporte.Name = "bntReporte";
            this.bntReporte.Size = new System.Drawing.Size(75, 51);
            this.bntReporte.TabIndex = 23;
            this.bntReporte.Text = "Reporte";
            this.bntReporte.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(796, 385);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 53);
            this.btnSalir.TabIndex = 24;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(796, 212);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 46);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 471);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.bntReporte);
            this.Controls.Add(this.bntActualizar);
            this.Controls.Add(this.BtnMedida_um);
            this.Controls.Add(this.bntBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtStock_Actual);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCategoria);
            this.Controls.Add(this.txtDescripcion_ar);
            this.Controls.Add(this.txtDescripcion_um);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArticulo);
            this.Controls.Add(this.Dvg_articulos);
            this.Name = "btnMedida";
            this.Text = "Frm_articulos";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_Articulos_load);
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_articulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dvg_articulos;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcion_um;
        private System.Windows.Forms.TextBox txtDescripcion_ar;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStock_Actual;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button bntBuscar;
        private System.Windows.Forms.Button BtnMedida_um;
        private System.Windows.Forms.Button bntActualizar;
        private System.Windows.Forms.Button bntReporte;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
    }
}