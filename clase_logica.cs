using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activitat11
{
    internal class clase_logica
    {
        Form2 form2 = new Form2();
        public void Afegir_Butons()
        {
            int posX = 0;       // posicio X
            int posY = 0;       // posicio Y
            int altura = 20;    // Altura buto
            int amplada = 20;   // ampldada buto

            System.Windows.Forms.Button[] buttons = new System.Windows.Forms.Button[26];  // cream array

            for (int i = 0; i < 26; i++)
            {
                buttons[i] = new System.Windows.Forms.Button(); // en el espai del array cream els botons
            }

            int c = 0;          // contador

            while (c < 26)
            {
                buttons[c].Tag = c + 1;
                buttons[c].Width = amplada;
                buttons[c].Height = altura;
                if (c == 13)
                {
                    posX = 0;
                    posY = altura;
                }
                buttons[c].Left = posX;
                buttons[c].Top = posY;
                form2.panel.Controls.Add(buttons[c]);
                posX = posX + buttons[c].Width;
                buttons[c].Text = ((char)(c + 65)).ToString();
                buttons[c].Click += new System.EventHandler(Click_Boto);
                c++;
            }
        }

        public void Click_Boto(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            string lletra = button.Text;
            form2.textBox.Text += lletra;
        }



    }
}
