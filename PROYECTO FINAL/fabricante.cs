using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PROYECTO_FINAL.clases;

namespace PROYECTO_FINAL
{
    public partial class fabricante : Form
    {
        private Conexion conexion = new Conexion();

        public fabricante()
        {
            InitializeComponent();
            CargarFabricantes();

            btnActualizar.Enabled = false;
        }

        private void CargarFabricantes()
        {
            try
            {
                conexion.abrir();

                string query = "SELECT Idfabricante AS ID, Nombre AS NOMBRE, Origen AS ORIGEN FROM fabricante";
                DataTable dt = new DataTable();
                using (MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion()))
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }

                // Evitar que el DataGrid genere columnas automáticamente (esto evita duplicados)
                dataGridFabricante.AutoGenerateColumns = false;

                // Asegurarse no tener DataSource previo que interfiera
                dataGridFabricante.DataSource = null;

                // Asignar DataPropertyName para que las columnas del Designer muestren los datos correctos
                colId.DataPropertyName = "ID";
                colNombre.DataPropertyName = "NOMBRE";
                colOrigen.DataPropertyName = "ORIGEN";

                // Finalmente asignar el DataTable como origen
                dataGridFabricante.DataSource = dt;

                // Configuración visual / comportamiento
                dataGridFabricante.ReadOnly = true;
                dataGridFabricante.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridFabricante.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar fabricantes: " + ex.Message);
            }
            finally
            {
                conexion.cerrar();
            }
        }





        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string origen = txtOrigen.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(origen))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            try
            {
                conexion.abrir();
                string sql = "INSERT INTO fabricante (Nombre, Origen) VALUES (@n, @o)";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.getConexion());
                cmd.Parameters.AddWithValue("@n", nombre);
                cmd.Parameters.AddWithValue("@o", origen);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Fabricante guardado.");

                LimpiarCampos();
                CargarFabricantes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
            finally
            {
                conexion.cerrar();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Seleccione un fabricante para actualizar.");
                return;
            }

            try
            {
                conexion.abrir();
                string sql = "UPDATE fabricante SET Nombre = @n, Origen = @o WHERE Idfabricante = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.getConexion());
                cmd.Parameters.AddWithValue("@id", txtId.Text);
                cmd.Parameters.AddWithValue("@n", txtNombre.Text.Trim());
                cmd.Parameters.AddWithValue("@o", txtOrigen.Text.Trim());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Fabricante actualizado.");

                LimpiarCampos();
                CargarFabricantes();
                btnGuardar.Enabled = true;
                btnActualizar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
            finally
            {
                conexion.cerrar();
            }
        }

        private void BorrarFabricante(int id)
        {
            try
            {
                conexion.abrir();
                string sql = "DELETE FROM fabricante WHERE Idfabricante = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.getConexion());
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar: " + ex.Message);
            }
            finally
            {
                conexion.cerrar();
            }
        }

        private void dataGridFabricante_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int id = Convert.ToInt32(dataGridFabricante.Rows[e.RowIndex].Cells["colId"].Value);

            // Editar
            if (e.ColumnIndex == dataGridFabricante.Columns["colEditar"].Index)
            {
                txtId.Text = id.ToString();
                txtNombre.Text = dataGridFabricante.Rows[e.RowIndex].Cells["colNombre"].Value.ToString();
                txtOrigen.Text = dataGridFabricante.Rows[e.RowIndex].Cells["colOrigen"].Value.ToString();

                btnGuardar.Enabled = false;
                btnActualizar.Enabled = true;
            }

            // Borrar
            if (e.ColumnIndex == dataGridFabricante.Columns["colBorrar"].Index)
            {
                if (MessageBox.Show("¿Seguro que desea borrar este fabricante?", "Confirmar",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    BorrarFabricante(id);
                    CargarFabricantes();
                }
            }
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtOrigen.Clear();
            txtNombre.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridFabricante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            
            this.Close();

        }
    }
}
