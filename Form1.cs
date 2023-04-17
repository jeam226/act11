namespace activitat11
{
    public partial class Form1 : Form
    {
        private string paraula_a_trobar;

        public Form1()
        {
            InitializeComponent();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (textBox31.Text.Length != 5)
            {
                MessageBox.Show("La paraula té que tenir 5 lletres!", "Ajuda");
            }
            else
            {
                paraula_a_trobar = textBox31.Text;
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
        }

    }
}