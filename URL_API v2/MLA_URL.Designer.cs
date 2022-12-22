namespace URL_API_v2
{
    partial class MLA_URL
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
            this.components = new System.ComponentModel.Container();
            this.MLA = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tablaMLABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uRLIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uRLQUERYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDIT = new System.Windows.Forms.DataGridViewLinkColumn();
            this.DELETE = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MLA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMLABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MLA
            // 
            this.MLA.AutoGenerateColumns = false;
            this.MLA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MLA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uRLIDDataGridViewTextBoxColumn,
            this.uRLQUERYDataGridViewTextBoxColumn,
            this.EDIT,
            this.DELETE});
            this.MLA.DataSource = this.tablaMLABindingSource;
            this.MLA.Location = new System.Drawing.Point(25, 30);
            this.MLA.Name = "MLA";
            this.MLA.RowHeadersWidth = 51;
            this.MLA.RowTemplate.Height = 24;
            this.MLA.Size = new System.Drawing.Size(741, 372);
            this.MLA.TabIndex = 0;
            this.MLA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MLA_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(467, 408);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 30);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(343, 409);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(102, 30);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(25, 409);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(290, 29);
            this.txtSearch.TabIndex = 5;
            // 
            // tablaMLABindingSource
            // 
            this.tablaMLABindingSource.DataSource = typeof(URL_API_v2.tablaMLA);
            // 
            // uRLIDDataGridViewTextBoxColumn
            // 
            this.uRLIDDataGridViewTextBoxColumn.DataPropertyName = "URL_ID";
            this.uRLIDDataGridViewTextBoxColumn.HeaderText = "URL_ID";
            this.uRLIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uRLIDDataGridViewTextBoxColumn.Name = "uRLIDDataGridViewTextBoxColumn";
            this.uRLIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.uRLIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // uRLQUERYDataGridViewTextBoxColumn
            // 
            this.uRLQUERYDataGridViewTextBoxColumn.DataPropertyName = "URL_QUERY";
            this.uRLQUERYDataGridViewTextBoxColumn.HeaderText = "URL_QUERY";
            this.uRLQUERYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uRLQUERYDataGridViewTextBoxColumn.Name = "uRLQUERYDataGridViewTextBoxColumn";
            this.uRLQUERYDataGridViewTextBoxColumn.ReadOnly = true;
            this.uRLQUERYDataGridViewTextBoxColumn.Width = 125;
            // 
            // EDIT
            // 
            this.EDIT.HeaderText = "EDIT";
            this.EDIT.MinimumWidth = 6;
            this.EDIT.Name = "EDIT";
            this.EDIT.ReadOnly = true;
            this.EDIT.Text = "EDITAR";
            this.EDIT.UseColumnTextForLinkValue = true;
            this.EDIT.Width = 125;
            // 
            // DELETE
            // 
            this.DELETE.HeaderText = "DELETE";
            this.DELETE.MinimumWidth = 6;
            this.DELETE.Name = "DELETE";
            this.DELETE.ReadOnly = true;
            this.DELETE.Text = "BORRAR";
            this.DELETE.UseColumnTextForLinkValue = true;
            this.DELETE.Width = 125;
            // 
            // MLA_URL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.MLA);
            this.Name = "MLA_URL";
            this.Text = "Seguimiento MLA";
            this.Load += new System.EventHandler(this.MLA_URL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MLA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMLABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MLA;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.BindingSource tablaMLABindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn uRLIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uRLQUERYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn EDIT;
        private System.Windows.Forms.DataGridViewLinkColumn DELETE;
    }
}

