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

        private void Afegir_Butons()
        {
            int posX = 0;
            int posY = 0;
            int c = 0;
            int altura = 20;
            int amplada = 20;

            System.Windows.Forms.Button[] buttons = new System.Windows.Forms.Button[28];

            for (int i = 0; i < (buttons.Length); i++)
            {
                buttons[i] = new System.Windows.Forms.Button();
            }

            while (c < (buttons.Length -2))
            {
                buttons[c].Tag = c + 1;
                buttons[c].Width = amplada;
                buttons[c].Height = altura;
                if (c == (buttons.Length -2) / 2)
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
            
        }



    }
}
