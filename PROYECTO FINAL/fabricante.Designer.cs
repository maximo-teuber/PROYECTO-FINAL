namespace PROYECTO_FINAL
{
    partial class fabricante
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dataGridFabricante = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFabricante)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(291, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(291, 58);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(200, 20);
            this.txtOrigen.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::PROYECTO_FINAL.Properties.Resources.Diseño_sin_título;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Location = new System.Drawing.Point(500, 58);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(143, 38);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackgroundImage = global::PROYECTO_FINAL.Properties.Resources.Diseño_sin_título;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.Location = new System.Drawing.Point(500, 14);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(167, 37);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dataGridFabricante
            // 
            this.dataGridFabricante.AllowUserToAddRows = false;
            this.dataGridFabricante.AllowUserToDeleteRows = false;
            this.dataGridFabricante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFabricante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNombre,
            this.colOrigen,
            this.colEditar,
            this.colBorrar});
            this.dataGridFabricante.Location = new System.Drawing.Point(25, 161);
            this.dataGridFabricante.Name = "dataGridFabricante";
            this.dataGridFabricante.ReadOnly = true;
            this.dataGridFabricante.RowHeadersVisible = false;
            this.dataGridFabricante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridFabricante.Size = new System.Drawing.Size(618, 265);
            this.dataGridFabricante.TabIndex = 0;
            this.dataGridFabricante.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFabricante_CellClick);
            this.dataGridFabricante.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFabricante_CellContentClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 50;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 200;
            // 
            // colOrigen
            // 
            this.colOrigen.HeaderText = "Origen";
            this.colOrigen.Name = "colOrigen";
            this.colOrigen.ReadOnly = true;
            this.colOrigen.Width = 200;
            // 
            // colEditar
            // 
            this.colEditar.HeaderText = "Editar";
            this.colEditar.Name = "colEditar";
            this.colEditar.ReadOnly = true;
            this.colEditar.Text = "Editar";
            this.colEditar.UseColumnTextForButtonValue = true;
            this.colEditar.Width = 80;
            // 
            // colBorrar
            // 
            this.colBorrar.HeaderText = "Borrar";
            this.colBorrar.Name = "colBorrar";
            this.colBorrar.ReadOnly = true;
            this.colBorrar.Text = "Borrar";
            this.colBorrar.UseColumnTextForButtonValue = true;
            this.colBorrar.Width = 80;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(673, 32);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(50, 20);
            this.txtId.TabIndex = 8;
            this.txtId.Visible = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(673, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID";
            this.label3.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(186, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(186, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 33;
            this.label2.Text = "ORIGEN";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.BackgroundImage = global::PROYECTO_FINAL.Properties.Resources.Diseño_sin_título;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Image = global::PROYECTO_FINAL.Properties.Resources.Diseño_sin_título;
            this.button2.Location = new System.Drawing.Point(500, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 42);
            this.button2.TabIndex = 34;
            this.button2.Text = "SALIR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // fabricante
            // 
            this.BackgroundImage = global::PROYECTO_FINAL.Properties.Resources.cat_dog1;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridFabricante);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtId);
            this.Name = "fabricante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Fabricantes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFabricante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dataGridFabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrigen;
        private System.Windows.Forms.DataGridViewButtonColumn colEditar;
        private System.Windows.Forms.DataGridViewButtonColumn colBorrar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}
