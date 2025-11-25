using System;
using System.Data;
using System.Windows.Forms;
using PROYECTO_FINAL.clases;
using PROYECTO_FINAL.modelo;

namespace PROYECTO_FINAL
{
    public partial class Marca : Form
    {
        MarcaModeloNueva modelo = new MarcaModeloNueva();
        int editarId = 0;

        public Marca()
        {
            InitializeComponent();
            CargarFabricantes();
            CargarMarcas();
            btnActualizar.Enabled = false;
        }

        private void CargarFabricantes()
        {
            try
            {
                DataTable dt = modelo.ObtenerFabricantes();

                comboBoxFabricantes.DataSource = dt;
                comboBoxFabricantes.DisplayMember = "Nombre";
                comboBoxFabricantes.ValueMember = "Id";
                comboBoxFabricantes.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar fabricantes: " + ex.Message);
            }
        }

        private void CargarMarcas()
        {
            DataTable dt = modelo.ObtenerMarcas();
            dataGridMarcas.AutoGenerateColumns = true;
            dataGridMarcas.DataSource = dt;

            if (dataGridMarcas.Columns.Contains("IdFabricante"))
                dataGridMarcas.Columns["IdFabricante"].Visible = false;

            if (!dataGridMarcas.Columns.Contains("Editar"))
            {
                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
                btnEditar.HeaderText = "Editar";
                btnEditar.Name = "Editar";
                btnEditar.Text = "Editar";
                btnEditar.UseColumnTextForButtonValue = true;
                dataGridMarcas.Columns.Add(btnEditar);
            }

            if (!dataGridMarcas.Columns.Contains("Borrar"))
            {
                DataGridViewButtonColumn btnBorrar = new DataGridViewButtonColumn();
                btnBorrar.HeaderText = "Borrar";
                btnBorrar.Name = "Borrar";
                btnBorrar.Text = "Borrar";
                btnBorrar.UseColumnTextForButtonValue = true;
                dataGridMarcas.Columns.Add(btnBorrar);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || comboBoxFabricantes.SelectedIndex == -1)
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            MarcaEntidadNueva marca = new MarcaEntidadNueva
            {
                Nombre = txtNombre.Text.Trim(),
                IdFabricante = Convert.ToInt32(comboBoxFabricantes.SelectedValue)
            };

            if (modelo.InsertarMarca(marca))
            {
                MessageBox.Show("Marca guardada correctamente.");
                LimpiarCampos();
                CargarMarcas();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (editarId == 0)
            {
                MessageBox.Show("Seleccione una marca para actualizar.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text) || comboBoxFabricantes.SelectedIndex == -1)
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            MarcaEntidadNueva marca = new MarcaEntidadNueva
            {
                IdMarca = editarId,
                Nombre = txtNombre.Text.Trim(),
                IdFabricante = Convert.ToInt32(comboBoxFabricantes.SelectedValue)
            };

            if (modelo.ActualizarMarca(marca))
            {
                MessageBox.Show("Marca actualizada correctamente.");
                LimpiarCampos();
                CargarMarcas();
                btnActualizar.Enabled = false;
                btnGuardar.Enabled = true;
                editarId = 0;
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            comboBoxFabricantes.SelectedIndex = -1;
        }

        private void dataGridMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int id = Convert.ToInt32(dataGridMarcas.Rows[e.RowIndex].Cells["Id"].Value);

            if (e.ColumnIndex == dataGridMarcas.Columns["Editar"].Index)
            {
                txtNombre.Text = dataGridMarcas.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                comboBoxFabricantes.SelectedValue =
                    Convert.ToInt32(dataGridMarcas.Rows[e.RowIndex].Cells["IdFabricante"].Value);

                editarId = id;
                btnActualizar.Enabled = true;
                btnGuardar.Enabled = false;
            }

            if (e.ColumnIndex == dataGridMarcas.Columns["Borrar"].Index)
            {
                if (MessageBox.Show("¿Seguro que desea borrar esta marca?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    modelo.EliminarMarca(id);
                    CargarMarcas();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
