using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private TextFile texto = new TextFile();

        private void B_Abrir_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = texto.Abrir;
        }

        private void B_Eliminar_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = texto.Eliminar();
        }

        private void B_Gravar_Click(object sender, EventArgs e)
        {
            texto.Gravar(richTextBox1.Text);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = texto.Maiusculas(richTextBox1.Text);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = texto.Minusculas(richTextBox1.Text);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = texto.Iniciais(richTextBox1.Text);
        }
    }
}
