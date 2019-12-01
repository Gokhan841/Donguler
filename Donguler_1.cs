using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fordonusu_Orn2
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

        private void button1_Click(object sender, EventArgs e)
        {
            //10 dan geriye doğru sayıların birer birer yazdırılması
            int i;
            for (i=10;i>=0;i--)
            {
                listBox1.Items.Add(i);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //sayıların ikişer ikişer yazdılırlması
            /*int i;
            for (i=0;i<=20;i++)
            {
                if (i %2==00)
                {
                    listBox1.Items.Add(i);
                }
            }*/

            int i;
            for (i = 0; i <= 20; i *= 2) ;
            {
                listBox1.Items.Add(i);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // a ile z harfi arasında kalan karaktelerin listbox'a eklenmesi
            char i;
            for (i = 'a'; i <='z'; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int ctop = 0;
            int ttop = 0;
            int i;
            
           for(i=0; i<=100; i++)
            {
                if(i%2==0)
                {
                    ctop = ctop + i;
                }
                else
                {
                   ttop = ttop + i;
                }
            }
            int farkkare;
            farkkare = (ctop - ttop) * (ctop - ttop);
            MessageBox.Show(farkkare.ToString());

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // while döngüsü Örn: 0 ile 11 arasındaki sayıları listboxa ekle
            int i = 0;
            while (i<11)
            {
                listBox1.Items.Add(i);
                i++;

            }
        }
    }
}
