using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adicionar_e_remover
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length ==0)
                MessageBox.Show ("Por favor digite algo !!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBox1.Focus();

            {
                comboBox1.Items.Add(textBox1.Text); 
                textBox1.Clear();
                textBox1.Focus();
            }
        }
    }
}
