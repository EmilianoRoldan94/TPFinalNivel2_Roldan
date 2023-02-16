namespace presentacion
{
    partial class frmPrincipal
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
            this.lblFiltroR = new System.Windows.Forms.Label();
            this.dgvVistaPrincipal = new System.Windows.Forms.DataGridView();
            this.tbxFiltroRapido = new System.Windows.Forms.TextBox();
            this.btnEliminarSeleccion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.btnAlta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFiltroR
            // 
            this.lblFiltroR.AutoSize = true;
            this.lblFiltroR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroR.Location = new System.Drawing.Point(298, 9);
            this.lblFiltroR.Name = "lblFiltroR";
            this.lblFiltroR.Size = new System.Drawing.Size(60, 25);
            this.lblFiltroR.TabIndex = 0;
            this.lblFiltroR.Text = "Filtro:";
            // 
            // dgvVistaPrincipal
            // 
            this.dgvVistaPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVistaPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVistaPrincipal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVistaPrincipal.Location = new System.Drawing.Point(12, 55);
            this.dgvVistaPrincipal.Name = "dgvVistaPrincipal";
            this.dgvVistaPrincipal.RowHeadersWidth = 51;
            this.dgvVistaPrincipal.RowTemplate.Height = 24;
            this.dgvVistaPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVistaPrincipal.Size = new System.Drawing.Size(1028, 549);
            this.dgvVistaPrincipal.TabIndex = 1;
            this.dgvVistaPrincipal.SelectionChanged += new System.EventHandler(this.dgvVistaPrincipal_SelectionChanged_1);
            // 
            // tbxFiltroRapido
            // 
            this.tbxFiltroRapido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFiltroRapido.Location = new System.Drawing.Point(364, 6);
            this.tbxFiltroRapido.Name = "tbxFiltroRapido";
            this.tbxFiltroRapido.Size = new System.Drawing.Size(288, 30);
            this.tbxFiltroRapido.TabIndex = 3;
            // 
            // btnEliminarSeleccion
            // 
            this.btnEliminarSeleccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarSeleccion.Location = new System.Drawing.Point(1084, 572);
            this.btnEliminarSeleccion.Name = "btnEliminarSeleccion";
            this.btnEliminarSeleccion.Size = new System.Drawing.Size(244, 32);
            this.btnEliminarSeleccion.TabIndex = 6;
            this.btnEliminarSeleccion.Text = "Eliminar Selección";
            this.btnEliminarSeleccion.UseVisualStyleBackColor = true;
            this.btnEliminarSeleccion.Click += new System.EventHandler(this.btnEliminarSeleccion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Logo";
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.AccessibleDescription = "";
            this.pbxArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxArticulo.Location = new System.Drawing.Point(1084, 55);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(244, 228);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 8;
            this.pbxArticulo.TabStop = false;
            this.pbxArticulo.WaitOnLoad = true;
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(1084, 302);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(244, 35);
            this.btnAlta.TabIndex = 9;
            this.btnAlta.Text = "Alta de Artículo";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 616);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminarSeleccion);
            this.Controls.Add(this.tbxFiltroRapido);
            this.Controls.Add(this.dgvVistaPrincipal);
            this.Controls.Add(this.lblFiltroR);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogus";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFiltroR;
        private System.Windows.Forms.DataGridView dgvVistaPrincipal;
        private System.Windows.Forms.TextBox tbxFiltroRapido;
        private System.Windows.Forms.Button btnEliminarSeleccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Button btnAlta;
    }
}

