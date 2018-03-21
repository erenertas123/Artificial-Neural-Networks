using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        toplamafonk nesne1;
        excelClass nesne;
        activation aktif;
        int index,deger;
        public Form1()
        {
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = comboBox1.SelectedIndex;
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            deger = comboBox2.SelectedIndex;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value1, value2;
            value1 = textBox1.Text;
            value2 = textBox2.Text;
            int data, count;
            data = Convert.ToInt16(value1);//Parametre sayısı
            count = Convert.ToInt16(value2);//Veri sayısı

            nesne.Create();
            nesne.basliklar(data);
            nesne.veriSeti(data, count);
            nesne.show();
            aktif.activated(data, count, index, deger);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            nesne = new excelClass();
            nesne1 = new toplamafonk(nesne);
            aktif = new activation(nesne1,nesne);
            comboBox1.Items.Add("Ağırlık");
            comboBox1.Items.Add("Çarpım");
            comboBox1.Items.Add("Maksimum");
            comboBox1.SelectedIndex = 0;
            comboBox2.Items.Add("Sigmoid");
            comboBox2.Items.Add("Hiperbolik Tanjant");
            comboBox2.Items.Add("Adım Basamak");
            comboBox2.SelectedIndex = 0;
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            nesne.kapatma();
        }

      
    }
}
