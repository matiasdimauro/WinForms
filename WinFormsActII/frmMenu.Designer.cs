namespace WinFormsActII
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblFiltroxnombre = new System.Windows.Forms.Label();
            this.txtFlitrarNombre = new System.Windows.Forms.TextBox();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.dgvArticulo = new System.Windows.Forms.DataGridView();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.lblCampo = new System.Windows.Forms.Label();
            this.btnCriterio = new System.Windows.Forms.Label();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMarcas = new System.Windows.Forms.ToolStripButton();
            this.btnCategorias = new System.Windows.Forms.ToolStripButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(125, 383);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(206, 383);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblFiltroxnombre
            // 
            this.lblFiltroxnombre.AutoSize = true;
            this.lblFiltroxnombre.Location = new System.Drawing.Point(41, 66);
            this.lblFiltroxnombre.Name = "lblFiltroxnombre";
            this.lblFiltroxnombre.Size = new System.Drawing.Size(91, 13);
            this.lblFiltroxnombre.TabIndex = 4;
            this.lblFiltroxnombre.Text = "Filtrar por nombre:";
            this.lblFiltroxnombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFlitrarNombre
            // 
            this.txtFlitrarNombre.Location = new System.Drawing.Point(138, 63);
            this.txtFlitrarNombre.Name = "txtFlitrarNombre";
            this.txtFlitrarNombre.Size = new System.Drawing.Size(172, 20);
            this.txtFlitrarNombre.TabIndex = 5;
            this.txtFlitrarNombre.TextChanged += new System.EventHandler(this.txtFlitrarNombre_TextChanged);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(640, 105);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(276, 272);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 7;
            this.pbxArticulo.TabStop = false;
            this.pbxArticulo.Click += new System.EventHandler(this.pbxArticulo_Click);
            // 
            // dgvArticulo
            // 
            this.dgvArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulo.Location = new System.Drawing.Point(44, 105);
            this.dgvArticulo.MultiSelect = false;
            this.dgvArticulo.Name = "dgvArticulo";
            this.dgvArticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulo.Size = new System.Drawing.Size(590, 272);
            this.dgvArticulo.TabIndex = 0;
            this.dgvArticulo.SelectionChanged += new System.EventHandler(this.dgvArticulo_SelectionChanged);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(287, 383);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnDetalle.TabIndex = 9;
            this.btnDetalle.Text = "Ver detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(41, 446);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(43, 13);
            this.lblCampo.TabIndex = 10;
            this.lblCampo.Text = "Campo:";
            this.lblCampo.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCriterio
            // 
            this.btnCriterio.AutoSize = true;
            this.btnCriterio.Location = new System.Drawing.Point(268, 446);
            this.btnCriterio.Name = "btnCriterio";
            this.btnCriterio.Size = new System.Drawing.Size(42, 13);
            this.btnCriterio.TabIndex = 11;
            this.btnCriterio.Text = "Criterio:";
            this.btnCriterio.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(467, 446);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(32, 13);
            this.lblFiltro.TabIndex = 12;
            this.lblFiltro.Text = "Filtro:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(505, 444);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(172, 20);
            this.txtFiltro.TabIndex = 14;
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(90, 442);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(143, 21);
            this.cboCampo.TabIndex = 15;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged_1);
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(316, 443);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(121, 21);
            this.cboCriterio.TabIndex = 16;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(722, 444);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMarcas,
            this.btnCategorias});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(959, 25);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnMarcas
            // 
            this.btnMarcas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMarcas.Image = ((System.Drawing.Image)(resources.GetObject("btnMarcas.Image")));
            this.btnMarcas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(49, 22);
            this.btnMarcas.Text = "Marcas";
            this.btnMarcas.Click += new System.EventHandler(this.btnMarcas_Click_1);
            // 
            // btnCategorias
            // 
            this.btnCategorias.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCategorias.Image = ((System.Drawing.Image)(resources.GetObject("btnCategorias.Image")));
            this.btnCategorias.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(67, 22);
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(44, 383);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 514);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.btnCriterio);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.dgvArticulo);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.txtFlitrarNombre);
            this.Controls.Add(this.lblFiltroxnombre);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(975, 553);
            this.MinimumSize = new System.Drawing.Size(975, 553);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comercio App";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblFiltroxnombre;
        private System.Windows.Forms.TextBox txtFlitrarNombre;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.DataGridView dgvArticulo;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label btnCriterio;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ToolStripButton btnMarcas;
        private System.Windows.Forms.ToolStripButton btnCategorias;
    }
}

