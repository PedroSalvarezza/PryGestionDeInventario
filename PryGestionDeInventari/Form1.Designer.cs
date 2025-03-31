namespace PryGestionDeInventari
{
    partial class FrmInicio
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
            this.DgvInventario = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.LblDescricion = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.LblStock = new System.Windows.Forms.Label();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.TxtCategoria = new System.Windows.Forms.TextBox();
            this.MrcAgregar = new System.Windows.Forms.GroupBox();
            this.CmbModificar = new System.Windows.Forms.ComboBox();
            this.LblModificar = new System.Windows.Forms.Label();
            this.CmbEliminar = new System.Windows.Forms.ComboBox();
            this.LblEliminar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInventario)).BeginInit();
            this.MrcAgregar.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvInventario
            // 
            this.DgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInventario.Location = new System.Drawing.Point(23, 13);
            this.DgvInventario.Name = "DgvInventario";
            this.DgvInventario.Size = new System.Drawing.Size(597, 213);
            this.DgvInventario.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(4, 38);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(100, 20);
            this.TxtCodigo.TabIndex = 3;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(499, 311);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(75, 23);
            this.BtnModificar.TabIndex = 7;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(168, 106);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 8;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(667, 310);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 9;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Location = new System.Drawing.Point(4, 19);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(43, 13);
            this.LblCodigo.TabIndex = 10;
            this.LblCodigo.Text = "Codigo:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(4, 61);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(47, 13);
            this.LblNombre.TabIndex = 11;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Location = new System.Drawing.Point(155, 61);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(40, 13);
            this.LblPrecio.TabIndex = 15;
            this.LblPrecio.Text = "Precio:";
            // 
            // LblDescricion
            // 
            this.LblDescricion.AutoSize = true;
            this.LblDescricion.Location = new System.Drawing.Point(155, 19);
            this.LblDescricion.Name = "LblDescricion";
            this.LblDescricion.Size = new System.Drawing.Size(66, 13);
            this.LblDescricion.TabIndex = 14;
            this.LblDescricion.Text = "Descripcion:";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(155, 38);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.TxtDescripcion.TabIndex = 13;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(155, 80);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(100, 20);
            this.TxtPrecio.TabIndex = 12;
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Location = new System.Drawing.Point(317, 61);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(55, 13);
            this.LblCategoria.TabIndex = 19;
            this.LblCategoria.Text = "Categoria:";
            // 
            // LblStock
            // 
            this.LblStock.AutoSize = true;
            this.LblStock.Location = new System.Drawing.Point(317, 19);
            this.LblStock.Name = "LblStock";
            this.LblStock.Size = new System.Drawing.Size(38, 13);
            this.LblStock.TabIndex = 18;
            this.LblStock.Text = "Stock:";
            // 
            // TxtStock
            // 
            this.TxtStock.Location = new System.Drawing.Point(317, 38);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(100, 20);
            this.TxtStock.TabIndex = 17;
            // 
            // TxtCategoria
            // 
            this.TxtCategoria.Location = new System.Drawing.Point(317, 80);
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.Size = new System.Drawing.Size(100, 20);
            this.TxtCategoria.TabIndex = 16;
            // 
            // MrcAgregar
            // 
            this.MrcAgregar.Controls.Add(this.LblPrecio);
            this.MrcAgregar.Controls.Add(this.LblCategoria);
            this.MrcAgregar.Controls.Add(this.BtnAgregar);
            this.MrcAgregar.Controls.Add(this.textBox1);
            this.MrcAgregar.Controls.Add(this.LblStock);
            this.MrcAgregar.Controls.Add(this.TxtCodigo);
            this.MrcAgregar.Controls.Add(this.TxtStock);
            this.MrcAgregar.Controls.Add(this.LblCodigo);
            this.MrcAgregar.Controls.Add(this.TxtCategoria);
            this.MrcAgregar.Controls.Add(this.LblNombre);
            this.MrcAgregar.Controls.Add(this.TxtPrecio);
            this.MrcAgregar.Controls.Add(this.LblDescricion);
            this.MrcAgregar.Controls.Add(this.TxtDescripcion);
            this.MrcAgregar.Location = new System.Drawing.Point(23, 246);
            this.MrcAgregar.Name = "MrcAgregar";
            this.MrcAgregar.Size = new System.Drawing.Size(425, 149);
            this.MrcAgregar.TabIndex = 20;
            this.MrcAgregar.TabStop = false;
            this.MrcAgregar.Text = "Agregar";
            // 
            // CmbModificar
            // 
            this.CmbModificar.FormattingEnabled = true;
            this.CmbModificar.Location = new System.Drawing.Point(499, 284);
            this.CmbModificar.Name = "CmbModificar";
            this.CmbModificar.Size = new System.Drawing.Size(121, 21);
            this.CmbModificar.TabIndex = 21;
            // 
            // LblModificar
            // 
            this.LblModificar.AutoSize = true;
            this.LblModificar.Location = new System.Drawing.Point(496, 265);
            this.LblModificar.Name = "LblModificar";
            this.LblModificar.Size = new System.Drawing.Size(51, 13);
            this.LblModificar.TabIndex = 20;
            this.LblModificar.Text = "Modifcar:";
            // 
            // CmbEliminar
            // 
            this.CmbEliminar.FormattingEnabled = true;
            this.CmbEliminar.Location = new System.Drawing.Point(667, 283);
            this.CmbEliminar.Name = "CmbEliminar";
            this.CmbEliminar.Size = new System.Drawing.Size(121, 21);
            this.CmbEliminar.TabIndex = 22;
            // 
            // LblEliminar
            // 
            this.LblEliminar.AutoSize = true;
            this.LblEliminar.Location = new System.Drawing.Point(664, 265);
            this.LblEliminar.Name = "LblEliminar";
            this.LblEliminar.Size = new System.Drawing.Size(46, 13);
            this.LblEliminar.TabIndex = 23;
            this.LblEliminar.Text = "Eliminar:";
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 498);
            this.Controls.Add(this.LblEliminar);
            this.Controls.Add(this.CmbEliminar);
            this.Controls.Add(this.LblModificar);
            this.Controls.Add(this.CmbModificar);
            this.Controls.Add(this.MrcAgregar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.DgvInventario);
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion De Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.DgvInventario)).EndInit();
            this.MrcAgregar.ResumeLayout(false);
            this.MrcAgregar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvInventario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Label LblDescricion;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.Label LblStock;
        private System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.TextBox TxtCategoria;
        private System.Windows.Forms.GroupBox MrcAgregar;
        private System.Windows.Forms.ComboBox CmbModificar;
        private System.Windows.Forms.Label LblModificar;
        private System.Windows.Forms.ComboBox CmbEliminar;
        private System.Windows.Forms.Label LblEliminar;
    }
}

