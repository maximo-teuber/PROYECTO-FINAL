namespace PROYECTO_FINAL
{
    partial class ListaAlimentos
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtSabor;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.RadioButton rbtnPrecioMayor;
        private System.Windows.Forms.RadioButton rbtnPrecioMenor;
        private System.Windows.Forms.RadioButton rbtnPrecioMayorBolsa;
        private System.Windows.Forms.RadioButton rbtnPrecioMenorBolsa;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnRefrescar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtSabor = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.rbtnPrecioMayor = new System.Windows.Forms.RadioButton();
            this.rbtnPrecioMenor = new System.Windows.Forms.RadioButton();
            this.rbtnPrecioMayorBolsa = new System.Windows.Forms.RadioButton();
            this.rbtnPrecioMenorBolsa = new System.Windows.Forms.RadioButton();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.Location = new System.Drawing.Point(12, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1023, 282);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(394, 22);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(180, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // txtSabor
            // 
            this.txtSabor.Location = new System.Drawing.Point(394, 62);
            this.txtSabor.Name = "txtSabor";
            this.txtSabor.Size = new System.Drawing.Size(150, 20);
            this.txtSabor.TabIndex = 2;
            // 
            // cmbTipo
            // 
            this.cmbTipo.Items.AddRange(new object[] {
            "Gato",
            "Gatito",
            "Gato Castrado",
            "Gato Alergia",
            "Perro Mordida Grande",
            "Perro Mordida Chica",
            "Puppy",
            "Perro Alérgico"});
            this.cmbTipo.Location = new System.Drawing.Point(394, 98);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(180, 21);
            this.cmbTipo.TabIndex = 3;
            // 
            // rbtnPrecioMayor
            // 
            this.rbtnPrecioMayor.BackColor = System.Drawing.Color.Transparent;
            this.rbtnPrecioMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Bold);
            this.rbtnPrecioMayor.Location = new System.Drawing.Point(650, 3);
            this.rbtnPrecioMayor.Name = "rbtnPrecioMayor";
            this.rbtnPrecioMayor.Size = new System.Drawing.Size(155, 28);
            this.rbtnPrecioMayor.TabIndex = 4;
            this.rbtnPrecioMayor.Text = "Precio Mayor";
            this.rbtnPrecioMayor.UseVisualStyleBackColor = false;
            this.rbtnPrecioMayor.CheckedChanged += new System.EventHandler(this.rbtnPrecioMayor_CheckedChanged);
            // 
            // rbtnPrecioMenor
            // 
            this.rbtnPrecioMenor.BackColor = System.Drawing.Color.Transparent;
            this.rbtnPrecioMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Bold);
            this.rbtnPrecioMenor.Location = new System.Drawing.Point(650, 40);
            this.rbtnPrecioMenor.Name = "rbtnPrecioMenor";
            this.rbtnPrecioMenor.Size = new System.Drawing.Size(155, 24);
            this.rbtnPrecioMenor.TabIndex = 5;
            this.rbtnPrecioMenor.Text = "Precio Menor";
            this.rbtnPrecioMenor.UseVisualStyleBackColor = false;
            // 
            // rbtnPrecioMayorBolsa
            // 
            this.rbtnPrecioMayorBolsa.BackColor = System.Drawing.Color.Transparent;
            this.rbtnPrecioMayorBolsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Bold);
            this.rbtnPrecioMayorBolsa.Location = new System.Drawing.Point(650, 77);
            this.rbtnPrecioMayorBolsa.Name = "rbtnPrecioMayorBolsa";
            this.rbtnPrecioMayorBolsa.Size = new System.Drawing.Size(214, 24);
            this.rbtnPrecioMayorBolsa.TabIndex = 6;
            this.rbtnPrecioMayorBolsa.Text = "Precio Bolsa Mayor";
            this.rbtnPrecioMayorBolsa.UseVisualStyleBackColor = false;
            // 
            // rbtnPrecioMenorBolsa
            // 
            this.rbtnPrecioMenorBolsa.BackColor = System.Drawing.Color.Transparent;
            this.rbtnPrecioMenorBolsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Bold);
            this.rbtnPrecioMenorBolsa.Location = new System.Drawing.Point(650, 116);
            this.rbtnPrecioMenorBolsa.Name = "rbtnPrecioMenorBolsa";
            this.rbtnPrecioMenorBolsa.Size = new System.Drawing.Size(214, 24);
            this.rbtnPrecioMenorBolsa.TabIndex = 7;
            this.rbtnPrecioMenorBolsa.Text = "Precio Bolsa Menor";
            this.rbtnPrecioMenorBolsa.UseVisualStyleBackColor = false;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.Black;
            this.btnFiltrar.BackgroundImage = global::PROYECTO_FINAL.Properties.Resources.Diseño_sin_título;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Bold);
            this.btnFiltrar.Location = new System.Drawing.Point(882, 51);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(92, 37);
            this.btnFiltrar.TabIndex = 8;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.Black;
            this.btnRefrescar.BackgroundImage = global::PROYECTO_FINAL.Properties.Resources.Diseño_sin_título;
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Bold);
            this.btnRefrescar.Location = new System.Drawing.Point(882, 98);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(104, 36);
            this.btnRefrescar.TabIndex = 9;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(289, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "NOMBRE";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(289, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "SABOR";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(211, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 24);
            this.label3.TabIndex = 34;
            this.label3.Text = "TIPO ALIMENTO";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.BackgroundImage = global::PROYECTO_FINAL.Properties.Resources.Diseño_sin_título;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Image = global::PROYECTO_FINAL.Properties.Resources.Diseño_sin_título;
            this.button2.Location = new System.Drawing.Point(882, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 42);
            this.button2.TabIndex = 35;
            this.button2.Text = "SALIR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // ListaAlimentos
            // 
            this.BackgroundImage = global::PROYECTO_FINAL.Properties.Resources.cat_dog1;
            this.ClientSize = new System.Drawing.Size(1160, 520);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtSabor);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.rbtnPrecioMayor);
            this.Controls.Add(this.rbtnPrecioMenor);
            this.Controls.Add(this.rbtnPrecioMayorBolsa);
            this.Controls.Add(this.rbtnPrecioMenorBolsa);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnRefrescar);
            this.Name = "ListaAlimentos";
            this.Text = "Lista de Alimentos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}
