using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRecursiveAppInCSharp
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            int nb = 1, result = 1;

            if(int.TryParse(txtInput.Text, out nb)&&nb<20&&nb>0)
            {
                
                if (nb != 1)
                {
                    result = factorial(nb, result);
                }
                else
                {
                    nb = 1;
                }
                lblResult.Text = "Resultat" + ": " + result;
            }
            else if(int.TryParse(txtInput.Text, out nb)&&(nb>19||nb<0))
            {
                if(nb>19)
                {
                    lblResult.Text = "Le nombre est trop grand";
                }
                else if(nb<0)
                {
                    lblResult.Text = "Le nombre doit être positif";
                }
            }  
        }

        int factorial(int nb, int result)
        {
            if (nb > 0)
            {
                result = nb * result;
                nb -= 1;
                if (nb > 0)
                {
                    result = factorial(nb, result);
                }
            }
            else if (nb == 0)
            {
                result = 1;
            }
            return result;
        }
    }
}
