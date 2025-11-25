using System;
using System.Data;
using System.Windows.Forms;
using PROYECTO_FINAL.modelo;

namespace PROYECTO_FINAL
{
    public partial class ListaAlimentos : Form
    {
        ModeloAlimentoLista modelo = new ModeloAlimentoLista();

        public ListaAlimentos()
        {
            InitializeComponent();
        }

        private void ListaAlimentos_Load(object sender, EventArgs e)
        {
            CargarAlimentos();
        }

        private void CargarAlimentos(string nombre = "", string sabor = "", string tipo = "", string precioFiltro = "")
        {
            DataTable dt = modelo.ObtenerAlimentosConFiltros(nombre, sabor, tipo, precioFiltro);

            dataGridView1.DataSource = dt;

            // Evitar duplicar botones
            if (!dataGridView1.Columns.Contains("Editar"))
            {
                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn
                {
                    HeaderText = "Editar",
                    Name = "Editar",
                    Text = "Editar",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(btnEditar);
            }

            if (!dataGridView1.Columns.Contains("Eliminar"))
            {
                DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn
                {
                    HeaderText = "Eliminar",
                    Name = "Eliminar",
                    Text = "Eliminar",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(btnEliminar);
            }

            // Ocultar columnas internas
            if (dataGridView1.Columns.Contains("Id_alimento"))
                dataGridView1.Columns["Id_alimento"].Visible = false;
            if (dataGridView1.Columns.Contains("idmarca"))
                dataGridView1.Columns["idmarca"].Visible = false;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string precioFiltro = "";
            if (rbtnPrecioMayor.Checked) precioFiltro = "Mayor";
            else if (rbtnPrecioMenor.Checked) precioFiltro = "Menor";
            else if (rbtnPrecioMayorBolsa.Checked) precioFiltro = "BolsaMayor";
            else if (rbtnPrecioMenorBolsa.Checked) precioFiltro = "BolsaMenor";

            CargarAlimentos(txtBuscar.Text.Trim(), txtSabor.Text.Trim(), cmbTipo.Text, precioFiltro);
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            txtSabor.Clear();
            cmbTipo.SelectedIndex = -1;
            rbtnPrecioMayor.Checked = false;
            rbtnPrecioMenor.Checked = false;
            rbtnPrecioMayorBolsa.Checked = false;
            rbtnPrecioMenorBolsa.Checked = false;
            CargarAlimentos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id_alimento"].Value);
                MessageBox.Show($"Editar alimento ID: {id}");
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id_alimento"].Value);
                if (MessageBox.Show("¿Seguro que quieres eliminar este alimento?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    modelo.BorrarAlimento(id);
                    CargarAlimentos();
                }
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            try
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id_alimento"].Value);
                string nombre = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                string tipo = dataGridView1.CurrentRow.Cells["tipo_alimento"].Value.ToString();
                decimal precioKilo = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["Precio_kilo"].Value);
                decimal precioBolsa = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["Precio_bolsa"].Value);
                decimal peso = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["peso"].Value);
                string sabor = dataGridView1.CurrentRow.Cells["Sabor"].Value.ToString();
                int stock = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Stock"].Value);
                int stockMin = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Stock_minimo"].Value);
                int stockMax = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Stock_maximo"].Value);
                int idMarca = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idmarca"].Value);

                modelo.ActualizarAlimento(id, nombre, tipo, precioKilo, precioBolsa, peso, sabor, stock, stockMin, stockMax, idMarca);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
             Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
            
        }

        private void rbtnPrecioMayor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }
    }
}
