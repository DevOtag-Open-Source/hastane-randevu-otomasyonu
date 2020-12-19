using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            listBox8.Items.Add(dateTimePicker1.Text);
        }
        string[] Poliklinikler = { "Aile Hekimliği", "Beyin ve Sinir Cerrahisi", "Anestezi", "Dahiliye", "Ortopedi", "Psikiyatri", "Üroloji", "Kadın Doğum", "Kulak Burun Boğaz", "Kardiyoloji" };
        
        private void button1_Click(object sender, EventArgs e)
        {
            listBox6.Items.Add( comboBox1.Text );
            listBox7.Items.Add(  comboBox2.Text);
          
            listBox5.Items.Add(  maskedTextBox3.Text);
            listBox1.Items.Add(" Adı: " + textBox4.Text + " Soyadı: " + textBox3.Text + " Semptom: " + textBox1.Text);
            listBox2.Items.Add(  maskedTextBox1.Text);
            listBox4.Items.Add( textBox4.Text   + "    " +  textBox3.Text  );
           

        }

        
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            maskedTextBox3.Text = " ";
            textBox3.Text = " ";
            textBox1.Text = " ";
            textBox4.Text = " ";
            comboBox1.SelectedItem = null;
            comboBox2.Text = " ";
            maskedTextBox1.Text = "";
          
            textBox1.Text = "";
            textBox4.Focus();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            maskedTextBox3.Text = " ";
            textBox3.Text = " ";
            textBox1.Text = " ";
            textBox4.Text = " ";
            comboBox1.SelectedItem = null;
            comboBox2.Text = " ";
            maskedTextBox1.Text = "";
            dateTimePicker1.ResetText();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
            listBox8.Items.Clear();
            listBox9.Items.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            textBox4.Focus();
        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if(comboBox1.SelectedItem== "Aile Hekimliği")
            {
                comboBox2.Items.Add("Dr. Kahraman PEHLİVAN");
                comboBox2.Items.Add("Dr. Orhan Uşaklıgil");

            }
            else if (comboBox1.SelectedItem == "Beyin ve Sinir Cerrahisi ")
            {
                comboBox2.Items.Add("Dr. Ahmet EHLİVAN");
                comboBox2.Items.Add("Dr. Ateş Uşaklı");

            }
            if (comboBox1.SelectedItem == "Anestezi")
            {
                comboBox2.Items.Add("Dr. Ayşe LİVAN");
                comboBox2.Items.Add("Dr. Fadime Uşak");

            }
            else if (comboBox1.SelectedItem == "Dahiliye")
            {
                comboBox2.Items.Add("Dr. Fatmagül İVAN");
                comboBox2.Items.Add("Dr. Fatih Gül");

            }
            if (comboBox1.SelectedItem == "Ortopedi") 
            {
                comboBox2.Items.Add("Dr. Tarık PEKAN");
                comboBox2.Items.Add("Dr. Mustafa Uşa");

            }
            
                else if (comboBox1.SelectedItem == "Psikiyatri ")
            {
                comboBox2.Items.Add("Dr. Ayten Yılmaz");
                comboBox2.Items.Add("Dr. Aytekin Dönmez");

            }
            if (comboBox1.SelectedItem == "Üroloji")
            {
                comboBox2.Items.Add("Dr. Süleyman PEHLİVAN");
                comboBox2.Items.Add("Dr. Orhan Uşaklıgil");

            }
           else if (comboBox1.SelectedItem == "Kadın Doğum")
            {
                comboBox2.Items.Add("Dr. Kahraman PEHLİVAN");
                comboBox2.Items.Add("Dr. Mahmut Orhan");

            }
            if (comboBox1.SelectedItem == "Kulak Burun Boğaz")
            {
                comboBox2.Items.Add("Dr. Behlül Recai");
                comboBox2.Items.Add("Dr. Cem Külkek");

            }
            else if (comboBox1.SelectedItem == "Kardiyoloji")
            {
                comboBox2.Items.Add("Dr. Metin Kara");
                comboBox2.Items.Add("Dr. Mehmet Gündüz");

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listBox9.Items.Add(button2.Text); 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button9.Text);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button23.Text);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button18.Text);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button33.Text);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button28.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button5.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button10.Text);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button22.Text);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button17.Text);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button32.Text);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button27.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button6.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button11.Text);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button21.Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button16.Text);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button31.Text);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button26.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button7.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button12.Text);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button20.Text);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button15.Text);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button30.Text);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button25.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button8.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button13.Text);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button19.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button14.Text);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button29.Text);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button24.Text);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button39.Text);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button38.Text);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button37.Text);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button36.Text);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button35.Text);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button34.Text);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button51.Text);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button50.Text);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button49.Text);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button48.Text);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button47.Text);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            listBox9.Items.Add(button46.Text);
        }
    }
}
