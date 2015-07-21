namespace N3_TiendaLibros.GUI
{
    partial class ControlCarrito
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbxDetalleCarrito = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.tbcIsbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxDetalleCarrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxDetalleCarrito
            // 
            this.gbxDetalleCarrito.Controls.Add(this.txtTotal);
            this.gbxDetalleCarrito.Controls.Add(this.lblTotal);
            this.gbxDetalleCarrito.Controls.Add(this.btnBorrar);
            this.gbxDetalleCarrito.Controls.Add(this.dgvCarrito);
            this.gbxDetalleCarrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxDetalleCarrito.Location = new System.Drawing.Point(0, 0);
            this.gbxDetalleCarrito.Name = "gbxDetalleCarrito";
            this.gbxDetalleCarrito.Size = new System.Drawing.Size(496, 251);
            this.gbxDetalleCarrito.TabIndex = 0;
            this.gbxDetalleCarrito.TabStop = false;
            this.gbxDetalleCarrito.Text = "Detalle del Carrito de Compras";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(348, 214);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(145, 20);
            this.txtTotal.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(310, 216);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(32, 16);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(3, 211);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(145, 27);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.AllowDrop = true;
            this.dgvCarrito.AllowUserToAddRows = false;
            this.dgvCarrito.AllowUserToDeleteRows = false;
            this.dgvCarrito.AllowUserToOrderColumns = true;
            this.dgvCarrito.AllowUserToResizeColumns = false;
            this.dgvCarrito.AllowUserToResizeRows = false;
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbcIsbn,
            this.tbcTitulo,
            this.tbcCantidad,
            this.tbcSubtotal});
            this.dgvCarrito.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCarrito.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCarrito.Location = new System.Drawing.Point(3, 16);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.RowHeadersVisible = false;
            this.dgvCarrito.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCarrito.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarrito.Size = new System.Drawing.Size(490, 186);
            this.dgvCarrito.TabIndex = 0;
            // 
            // tbcIsbn
            // 
            this.tbcIsbn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tbcIsbn.HeaderText = "ISBN";
            this.tbcIsbn.Name = "tbcIsbn";
            // 
            // tbcTitulo
            // 
            this.tbcTitulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tbcTitulo.HeaderText = "Título";
            this.tbcTitulo.Name = "tbcTitulo";
            // 
            // tbcCantidad
            // 
            this.tbcCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tbcCantidad.HeaderText = "Cantidad";
            this.tbcCantidad.Name = "tbcCantidad";
            // 
            // tbcSubtotal
            // 
            this.tbcSubtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.tbcSubtotal.DefaultCellStyle = dataGridViewCellStyle1;
            this.tbcSubtotal.HeaderText = "Subtotal";
            this.tbcSubtotal.Name = "tbcSubtotal";
            // 
            // ControlCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxDetalleCarrito);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ControlCarrito";
            this.Size = new System.Drawing.Size(496, 251);
            this.gbxDetalleCarrito.ResumeLayout(false);
            this.gbxDetalleCarrito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDetalleCarrito;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcIsbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcSubtotal;
    }
}
