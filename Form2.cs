using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace activitat11
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        public Panel panel
        {
            get { return panel1; }
            set { panel1 = value; }
        }

        public TextBox textBox
        {
            get { return textBox1; }
            set { textBox1 = value; }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            clase_logica logica = new clase_logica();
            logica.Afegir_Butons();
        }

    }
}
