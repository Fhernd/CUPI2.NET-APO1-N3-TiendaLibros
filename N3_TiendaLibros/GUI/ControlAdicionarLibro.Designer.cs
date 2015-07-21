namespace N3_TiendaLibros.GUI
{
    partial class ControlAdicionarLibro
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
            this.btnAdicionarLibro = new System.Windows.Forms.Button();
            this.btnOpcion1 = new System.Windows.Forms.Button();
            this.btnOpcion2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdicionarLibro
            // 
            this.btnAdicionarLibro.Location = new System.Drawing.Point(3, 3);
            this.btnAdicionarLibro.Name = "btnAdicionarLibro";
            this.btnAdicionarLibro.Size = new System.Drawing.Size(160, 26);
            this.btnAdicionarLibro.TabIndex = 0;
            this.btnAdicionarLibro.Text = "Adicionar Libro";
            this.btnAdicionarLibro.UseVisualStyleBackColor = true;
            this.btnAdicionarLibro.Click += new System.EventHandler(this.btnAdicionarLibro_Click);
            // 
            // btnOpcion1
            // 
            this.btnOpcion1.Location = new System.Drawing.Point(170, 3);
            this.btnOpcion1.Name = "btnOpcion1";
            this.btnOpcion1.Size = new System.Drawing.Size(160, 26);
            this.btnOpcion1.TabIndex = 1;
            this.btnOpcion1.Text = "Opción 1";
            this.btnOpcion1.UseVisualStyleBackColor = true;
            this.btnOpcion1.Click += new System.EventHandler(this.btnOpcion1_Click);
            // 
            // btnOpcion2
            // 
            this.btnOpcion2.Location = new System.Drawing.Point(337, 3);
            this.btnOpcion2.Name = "btnOpcion2";
            this.btnOpcion2.Size = new System.Drawing.Size(160, 26);
            this.btnOpcion2.TabIndex = 2;
            this.btnOpcion2.Text = "Opción 2";
            this.btnOpcion2.UseVisualStyleBackColor = true;
            this.btnOpcion2.Click += new System.EventHandler(this.btnOpcion2_Click);
            // 
            // ControlAdicionarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOpcion2);
            this.Controls.Add(this.btnOpcion1);
            this.Controls.Add(this.btnAdicionarLibro);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ControlAdicionarLibro";
            this.Size = new System.Drawing.Size(500, 32);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionarLibro;
        private System.Windows.Forms.Button btnOpcion1;
        private System.Windows.Forms.Button btnOpcion2;
    }
}
