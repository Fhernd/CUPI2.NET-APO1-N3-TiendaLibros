namespace N3_TiendaLibros.GUI
{
    partial class ControlCatalogo
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
            this.gbxDetalleCatalogo = new System.Windows.Forms.GroupBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.dgvCatalogo = new System.Windows.Forms.DataGridView();
            this.tbcIsbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxDetalleCatalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxDetalleCatalogo
            // 
            this.gbxDetalleCatalogo.Controls.Add(this.btnComprar);
            this.gbxDetalleCatalogo.Controls.Add(this.txtCantidad);
            this.gbxDetalleCatalogo.Controls.Add(this.lblCantidad);
            this.gbxDetalleCatalogo.Controls.Add(this.dgvCatalogo);
            this.gbxDetalleCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxDetalleCatalogo.Location = new System.Drawing.Point(0, 0);
            this.gbxDetalleCatalogo.Name = "gbxDetalleCatalogo";
            this.gbxDetalleCatalogo.Size = new System.Drawing.Size(496, 210);
            this.gbxDetalleCatalogo.TabIndex = 0;
            this.gbxDetalleCatalogo.TabStop = false;
            this.gbxDetalleCatalogo.Text = "Detalle del Catálogo";
            // 
            // btnComprar
            // 
            this.btnComprar.Enabled = false;
            this.btnComprar.Location = new System.Drawing.Point(322, 173);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(78, 24);
            this.btnComprar.TabIndex = 3;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Location = new System.Drawing.Point(147, 175);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(169, 20);
            this.txtCantidad.TabIndex = 2;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(92, 177);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(53, 16);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "Cantidad";
            // 
            // dgvCatalogo
            // 
            this.dgvCatalogo.AllowUserToAddRows = false;
            this.dgvCatalogo.AllowUserToDeleteRows = false;
            this.dgvCatalogo.AllowUserToOrderColumns = true;
            this.dgvCatalogo.AllowUserToResizeColumns = false;
            this.dgvCatalogo.AllowUserToResizeRows = false;
            this.dgvCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalogo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbcIsbn,
            this.tbcTitulo,
            this.tbcPrecio});
            this.dgvCatalogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCatalogo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCatalogo.Location = new System.Drawing.Point(3, 16);
            this.dgvCatalogo.MultiSelect = false;
            this.dgvCatalogo.Name = "dgvCatalogo";
            this.dgvCatalogo.RowHeadersVisible = false;
            this.dgvCatalogo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCatalogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatalogo.Size = new System.Drawing.Size(490, 146);
            this.dgvCatalogo.TabIndex = 0;
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
            // tbcPrecio
            // 
            this.tbcPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.tbcPrecio.DefaultCellStyle = dataGridViewCellStyle1;
            this.tbcPrecio.HeaderText = "Precio";
            this.tbcPrecio.Name = "tbcPrecio";
            // 
            // ControlCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxDetalleCatalogo);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ControlCatalogo";
            this.Size = new System.Drawing.Size(496, 210);
            this.gbxDetalleCatalogo.ResumeLayout(false);
            this.gbxDetalleCatalogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCatalogo;
        private System.Windows.Forms.GroupBox gbxDetalleCatalogo;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcIsbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcPrecio;
    }
}
