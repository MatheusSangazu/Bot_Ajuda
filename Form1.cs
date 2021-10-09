using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButDeConversa
{
    public partial class Form1 : Form
    {

        public bool Resolvido;
        public bool Gostou;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void BtnExecutar_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Ajudei no seu problema?", "IA do Matheus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }


    }
}
