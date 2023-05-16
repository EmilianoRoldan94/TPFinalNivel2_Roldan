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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvVistaPrincipal = new System.Windows.Forms.DataGridView();
            this.btnEliminarSeleccion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxFiltroNombre = new System.Windows.Forms.TextBox();
            this.tbxFiltroDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnResetearFiltros = new System.Windows.Forms.Button();
            this.tbxFiltroCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVistaPrincipal
            // 
            this.dgvVistaPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVistaPrincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVistaPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVistaPrincipal.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVistaPrincipal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVistaPrincipal.Location = new System.Drawing.Point(12, 55);
            this.dgvVistaPrincipal.Name = "dgvVistaPrincipal";
            this.dgvVistaPrincipal.RowHeadersWidth = 51;
            this.dgvVistaPrincipal.RowTemplate.Height = 24;
            this.dgvVistaPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVistaPrincipal.Size = new System.Drawing.Size(751, 548);
            this.dgvVistaPrincipal.TabIndex = 1;
            this.dgvVistaPrincipal.SelectionChanged += new System.EventHandler(this.dgvVistaPrincipal_SelectionChanged_1);
            // 
            // btnEliminarSeleccion
            // 
            this.btnEliminarSeleccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarSeleccion.Location = new System.Drawing.Point(795, 571);
            this.btnEliminarSeleccion.Name = "btnEliminarSeleccion";
            this.btnEliminarSeleccion.Size = new System.Drawing.Size(244, 32);
            this.btnEliminarSeleccion.TabIndex = 6;
            this.btnEliminarSeleccion.Text = "Eliminar Artículo";
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
            this.pbxArticulo.Location = new System.Drawing.Point(795, 55);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(244, 228);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 8;
            this.pbxArticulo.TabStop = false;
            this.pbxArticulo.WaitOnLoad = true;
            // 
            // btnAlta
            // 
            this.btnAlta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.Location = new System.Drawing.Point(795, 339);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(244, 35);
            this.btnAlta.TabIndex = 9;
            this.btnAlta.Text = "Alta de Artículo";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(795, 380);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(244, 35);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar Artículo";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalle.Location = new System.Drawing.Point(795, 421);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(244, 35);
            this.btnDetalle.TabIndex = 11;
            this.btnDetalle.Text = "Ver Detalle de Articulo";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 644);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Filtros:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 673);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nombre";
            // 
            // tbxFiltroNombre
            // 
            this.tbxFiltroNombre.Location = new System.Drawing.Point(215, 648);
            this.tbxFiltroNombre.Name = "tbxFiltroNombre";
            this.tbxFiltroNombre.Size = new System.Drawing.Size(100, 22);
            this.tbxFiltroNombre.TabIndex = 14;
            this.tbxFiltroNombre.TextChanged += new System.EventHandler(this.tbxFiltroNombre_TextChanged);
            // 
            // tbxFiltroDescripcion
            // 
            this.tbxFiltroDescripcion.Location = new System.Drawing.Point(347, 648);
            this.tbxFiltroDescripcion.Name = "tbxFiltroDescripcion";
            this.tbxFiltroDescripcion.Size = new System.Drawing.Size(100, 22);
            this.tbxFiltroDescripcion.TabIndex = 15;
            this.tbxFiltroDescripcion.TextChanged += new System.EventHandler(this.tbxFiltroDescripcion_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 673);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Descripción";
            // 
            // btnResetearFiltros
            // 
            this.btnResetearFiltros.Location = new System.Drawing.Point(476, 644);
            this.btnResetearFiltros.Name = "btnResetearFiltros";
            this.btnResetearFiltros.Size = new System.Drawing.Size(104, 44);
            this.btnResetearFiltros.TabIndex = 17;
            this.btnResetearFiltros.Text = "Resetear filtros";
            this.btnResetearFiltros.UseVisualStyleBackColor = true;
            this.btnResetearFiltros.Click += new System.EventHandler(this.btnResetearFiltros_Click);
            // 
            // tbxFiltroCodigo
            // 
            this.tbxFiltroCodigo.Location = new System.Drawing.Point(89, 648);
            this.tbxFiltroCodigo.Name = "tbxFiltroCodigo";
            this.tbxFiltroCodigo.Size = new System.Drawing.Size(100, 22);
            this.tbxFiltroCodigo.TabIndex = 19;
            this.tbxFiltroCodigo.TextChanged += new System.EventHandler(this.tbxFiltroCodigo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 673);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Código";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 727);
            this.Controls.Add(this.tbxFiltroCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnResetearFiltros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxFiltroDescripcion);
            this.Controls.Add(this.tbxFiltroNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminarSeleccion);
            this.Controls.Add(this.dgvVistaPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        private System.Windows.Forms.DataGridView dgvVistaPrincipal;
        private System.Windows.Forms.Button btnEliminarSeleccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxFiltroNombre;
        private System.Windows.Forms.TextBox tbxFiltroDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnResetearFiltros;
        private System.Windows.Forms.TextBox tbxFiltroCodigo;
        private System.Windows.Forms.Label label5;
    }
}

