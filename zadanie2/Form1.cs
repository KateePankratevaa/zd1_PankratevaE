using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie2
{
    public partial class Form1 :Form
    {
        Shop pyaterochka = new Shop();

        PlayList cool = new PlayList();
        public Form1 ()
        {
            InitializeComponent();
            listBox1.Items.Clear();
            pyaterochka.CreateProduct("Сок \"Добрый\"", 100, 50);
            pyaterochka.CreateProduct("Кола", 85, 200);          
            pyaterochka.CreateProduct("Шоколад \"Alpen Gold\"", 70, 100);
            pyaterochka.CreateProduct("Морковь по-корейски ", 120, 2);
            pyaterochka.WriteAllProducts(listBox1);

            //listBox2.Items.Clear();
            //cool.CreateSong("Df", "Happy", "Happy.txt", 1);
            //cool.CreateSong("GH", "Sad", "Sad.txt", 8);
            //cool.CreateSong("OP", "Happy", "Happy.txt", 20);
            //cool.CreateSong("LK", "Loud", "Loud.txt", 4);
            //cool.WriteAllSongs(listBox2);
        }

       
        private void Form1_Load (object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged (object sender, EventArgs e)
        {

        }
        public bool Check (string input)
        {
            char spase = ' ';
            foreach (char c in input)
            {
                if (c == spase)
                {
                    continue;
                }
                if (c >= 'A' && c <= 'z' || c >= 'А' && c <= 'я')
                    return true;
                else
                    break;
            }
            return false;
        }

        private void button1_Click (object sender, EventArgs e)
        {
           
                string product = textBox1.Text;
                int countProduct = Convert.ToInt32(numericUpDown1.Value);
                if (Check(product))
                {
                    pyaterochka.Sell(product, countProduct);
                    listBox1.Items.Clear();
                    pyaterochka.WriteAllProducts(listBox1);
                    label3.Text = pyaterochka.Profit.ToString();
            } else
                    MessageBox.Show("Введите название и количество товара из ассортимента магазина!");
           
        }

        private void numericUpDown1_ValueChanged (object sender, EventArgs e)
        {

        }

        private void button2_Click (object sender, EventArgs e)
        {
            string product = textBox2.Text;
            if (Check(product))
            {
                pyaterochka.CreateProduct(product, Convert.ToInt32(numericUpDown3.Value), Convert.ToInt32(numericUpDown2.Value));
            }
            else
                MessageBox.Show("Введите цену,количество,навзание товара, который хотите добавить в ассортимент магазина!");
            listBox1.Items.Clear();
            pyaterochka.WriteAllProducts(listBox1);
            
        }

        private void textBox1_TextChanged (object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged (object sender, EventArgs e)
        {

        }

        private void button3_Click (object sender, EventArgs e)
        {
            //    string name = textBox3.Text;
            //    string autor = textBox4.Text;
            //    string filename = textBox4.Text;
            //    int count = Convert.ToInt32(numericUpDown4.Value);

            //    if (Check(name) && Check(autor) && Check(filename))
            //    {
            //        cool.CreateSong(autor, name, filename, count);
            //    } else
            //        MessageBox.Show("Введите название и автора аудиозаписи!");
        }
    }
}
