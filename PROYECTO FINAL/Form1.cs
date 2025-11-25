using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO_FINAL;

namespace PROYECTO_FINAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comida form = new comida();
            form.Show();

        }

 

  

   

    

     

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
             Marca form = new Marca ();
            form.Show();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            fabricante form = new fabricante();
            form.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ListaAlimentos lista = new ListaAlimentos();
            lista.Show();
        }
    }
}
