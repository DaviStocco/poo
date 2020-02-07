using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Aula01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Hello World!");
        }
    }
}
