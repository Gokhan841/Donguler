using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int toplam = 0;
        string[] isimler = new string[5];
        int sayac=0;

        private void button1_Click(object sender, EventArgs e)
        {  //dizilerin gösterimi ve kullanımı;

            string[] gunler = new string[7];
            gunler[0] = "pzt";
            gunler[1] = "Salı";
            gunler[2]="Çarşamba";
            gunler[3] = "Perşambe";
            gunler[4]="Cuma";
            gunler[5] = "Cmts";
            gunler[6] = "Pzar";
            label1.Text = gunler[4];

            int[] sayilar = new int[4];
            sayilar[0] = 1;
            sayilar[1] = 10;
            sayilar[2] = 20;
            sayilar[3] = 30;
            label2.Text = sayilar[2].ToString();

            char[] harfler= {'a','b','c','d'};
            label3.Text = harfler[0].ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { //Dizinin sayılarını toplamını labele yazdıran programı yaz
            int[] sayilar = new int[4];
            sayilar[0] = 1;
            sayilar[1] = 10;
            sayilar[2] = 20;
            sayilar[3] = 30;
            
            int i;
            for (i = 0; i <sayilar.Length; i++) //Burada index 0'dan başladığı için <= ifadesi deği < ifades kullanıldı.
            {                                   // for(i=0, i<=3,i++) kodu da kullanılailirdi.
                toplam = toplam + sayilar[i];
                label1.Text = toplam.ToString();
            }
              
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Dizinin eleman sayısını hesaplayan kodu yaz
            int[] numaralar = { 0, 1, 5, 8, 4, 6, 9, 7, 8, 3, 45, 8, 2, 56 };
            int elemansay = numaralar.Length;
            label1.Text = elemansay.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // for each döngüsü kullanarak sayıları toplat
            int[] kume = { 2, 5, 6, 4, 8, 2 };
            foreach (int sayi in kume) 
            {
                toplam = toplam + sayi;
                label1.Text = toplam.ToString();
            }
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Dizi içersinde yer alan çift sayıları listbox'a ekle
            int[] dizi = { 2, 6, 8, 1, 7, 5, 9, 4, 3, 6, 2, 5, 1 };
            foreach(int sayi in dizi)
            {
                if(sayi%2==0)
                {
                    listBox1.Items.Add(sayi);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Text Boaxtan girilen 5 ismi Listbox'a ekleyen kodu yaz.

        private void button6_Click(object sender, EventArgs e)
        {
            isimler[sayac] = textBox1.Text;
            sayac++;
            label4.Text = (sayac + 1).ToString() + ". ci ismi giriniz";
            textBox1.Clear();
            textBox1.Focus(); // imleç tekrardan yanıp sönsün
            if (sayac>=5)
            {
                textBox1.Enabled = false;
            } // 5'ten sonra textbox pasif duruma geçiyor.
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < isimler.Length; i++)
            {
                listBox1.Items.Add(isimler[i]);
            }
        }
    }
}
