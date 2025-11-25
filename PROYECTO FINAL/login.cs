using System;
using System.Windows.Forms;
using PROYECTO_FINAL.entidades;

namespace PROYECTO_FINAL
{
    public partial class login : Form
    {
        Usuario usuario = new Usuario();

        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            lblerror.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validar usuario y contraseña
            var validate = usuario.login(txtusuario.Text, txtcontraseña.Text);

            if (txtusuario.Text != "" && txtcontraseña.Text != "")
            {
                if (validate)
                {
                    MessageBox.Show("Bienvenido, " + txtusuario.Text + "!", "Acceso Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 form = new Form1();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    lblerror.Visible = true;
                }
            }
            else
            {
                lblerror.Visible = true;
            }
        }

        private void cerrarform(object sender, FormClosedEventArgs e)
        {
            this.Show();
            lblerror.Visible = false;
            txtusuario.Text = "";
            txtcontraseña.Text = "";
            txtusuario.Focus();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Nuevo_usuario form = new Nuevo_usuario();
            form.Show();
            this.Hide();
        }
    }
}
