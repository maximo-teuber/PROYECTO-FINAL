using System;
using System.Windows.Forms;
using PROYECTO_FINAL.entidades;

namespace PROYECTO_FINAL
{
    public partial class Nuevo_usuario : Form
    {
        public Nuevo_usuario()
        {
            InitializeComponent();
        }

        Usuario usuario = new Usuario();

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text.Trim();
            string nombreUsuario = txtnombreusuario.Text.Trim();
            string contraseña = txtcontraseña.Text.Trim();

            if (nombre == "" || nombreUsuario == "" || contraseña == "")
            {
                MessageBox.Show("⚠️ Por favor completá todos los campos.");
                return;
            }

            Usuario nuevoUsuario = new Usuario();
            bool registrado = nuevoUsuario.registrar(nombre, nombreUsuario, contraseña);

            if (registrado)
            {
             

                login loginForm = new login();  // Ajustá el nombre si tu formulario se llama distinto
                loginForm.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("❌ Error al registrar el usuario.");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            // Botón VOLVER, abre login y cierra este formulario
            login loginForm = new login();
            loginForm.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Evento vacío para el label (puede quedar vacío)
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Evento vacío para el textbox contraseña (puede quedar vacío)
        }

        private void txtnombreusuario_TextChanged(object sender, EventArgs e)
        {
            // Evento vacío para el textbox usuario (puede quedar vacío)
        }
    }
}
