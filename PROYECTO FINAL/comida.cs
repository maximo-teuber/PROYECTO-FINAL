using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PROYECTO_FINAL.modelo;
using PROYECTO_FINAL.clases;

namespace PROYECTO_FINAL
{
    public partial class comida : Form
    {
        private Conexion conexion = new Conexion();

        public comida()
        {
            InitializeComponent();

            // 🔹 Cargar tipos de alimento predeterminados
            comboBox1clases.Items.Clear();
            comboBox1clases.Items.AddRange(new string[]
            {
                "Gato", "Gatito", "Gato Castrado", "Gato Alergia",
                "Perro Mordida Grande", "Perro Mordida Chica", "Puppy", "Perro Alérgico"
            });
            comboBox1clases.SelectedIndex = 0;

            // 🔹 Cargar marcas dinámicamente
            CargarMarcas();

            // 🔹 Eventos
            comboBox1clases.SelectedIndexChanged += comboBox1clases_SelectedIndexChanged;
            BotnGuardar.Click += BotnGuardar_Click;
        }

        private void CargarMarcas()
        {
            try
            {
                ModeloMarca modelo = new ModeloMarca();
                DataTable marcas = modelo.ObtenerMarcas();

                comboBoxMarca.DataSource = marcas;
                comboBoxMarca.DisplayMember = "nombre";
                comboBoxMarca.ValueMember = "idmarca";
                comboBoxMarca.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las marcas: " + ex.Message);
            }
        }

        private void comboBox1clases_SelectedIndexChanged(object sender, EventArgs e) { }

        private void BotnGuardar_Click(object sender, EventArgs e)
        {
            if (comboBoxMarca.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar una marca.");
                return;
            }

            // 🔸 Validar que todos los campos numéricos sean válidos
            if (!decimal.TryParse(textBolsa.Text.Trim(), out decimal precioBolsa) ||
                !decimal.TryParse(textKilo.Text.Trim(), out decimal precioKilo))
            {
                MessageBox.Show("Ingrese precios válidos (números).");
                return;
            }

            if (!int.TryParse(textBox1.Text.Trim(), out int stockMinimo) ||
                !int.TryParse(textBoxstockmaximo.Text.Trim(), out int stockMaximo) ||
                !int.TryParse(textBoxStock.Text.Trim(), out int stockActual))
            {
                MessageBox.Show("Ingrese valores de stock válidos (números enteros).");
                return;
            }

            // 🔹 Validación 1: Precio bolsa > precio kilo
            if (precioBolsa <= precioKilo)
            {
                MessageBox.Show("El precio de la bolsa debe ser mayor que el precio por kilo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🔹 Validación 2: Stock máximo > stock mínimo
            if (stockMaximo <= stockMinimo)
            {
                MessageBox.Show("El stock máximo debe ser mayor que el stock mínimo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conexion.abrir();

                // Obtener Idfabricante de la marca seleccionada
                int idFabricante = 0;
                using (MySqlCommand cmdFabricante = new MySqlCommand(
                    "SELECT Idfabricante FROM marca WHERE idmarca = @idmarca",
                    conexion.getConexion()))
                {
                    cmdFabricante.Parameters.AddWithValue("@idmarca", comboBoxMarca.SelectedValue);
                    var result = cmdFabricante.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                        idFabricante = Convert.ToInt32(result);
                }

                // Insertar en alimento
                string query = @"INSERT INTO alimento
(Nombre, idmarca, Idfabricante, Precio_bolsa, Precio_kilo, tipo_alimento, Stock, Stock_minimo, Stock_maximo, peso, Sabor)
VALUES (@nombre, @idmarca, @idfabricante, @precio_bolsa, @precio_kilo, @tipo_alimento, @stock, @stock_minimo, @stock_maximo, @peso, @sabor)";

                MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion());
                cmd.Parameters.AddWithValue("@nombre", txtnombre.Text.Trim());
                cmd.Parameters.AddWithValue("@idmarca", comboBoxMarca.SelectedValue);
                cmd.Parameters.AddWithValue("@idfabricante", idFabricante);
                cmd.Parameters.AddWithValue("@precio_bolsa", precioBolsa);
                cmd.Parameters.AddWithValue("@precio_kilo", precioKilo);
                cmd.Parameters.AddWithValue("@tipo_alimento", comboBox1clases.Text.Trim());
                cmd.Parameters.AddWithValue("@stock", stockActual);
                cmd.Parameters.AddWithValue("@stock_minimo", stockMinimo);
                cmd.Parameters.AddWithValue("@stock_maximo", stockMaximo);
                cmd.Parameters.AddWithValue("@peso", textBoxtamaño.Text.Trim());
                cmd.Parameters.AddWithValue("@sabor", textBoxsabor.Text.Trim());

                int filas = cmd.ExecuteNonQuery();

                if (filas > 0)
                    MessageBox.Show("Alimento guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo guardar el alimento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.cerrar();
            }
        }

        private void LimpiarCampos()
        {
            txtnombre.Clear();
            textBolsa.Clear();
            textKilo.Clear();
            textBoxStock.Clear();
            textBox1.Clear();
            textBoxstockmaximo.Clear();
            textBoxtamaño.Clear();
            textBoxsabor.Clear();
            comboBox1clases.SelectedIndex = 0;
            comboBoxMarca.SelectedIndex = -1;
            txtnombre.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Métodos vacíos generados por Designer
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBoxsabor_TextChanged(object sender, EventArgs e) { }
        private void comboBoxMarca_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void labelpreciokilo_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void button1_Click_1(object sender, EventArgs e) { }
        private void labelstockmaximo_Click(object sender, EventArgs e) { }

        private void labeltamaño_Click(object sender, EventArgs e)
        {

        }
    }
}
