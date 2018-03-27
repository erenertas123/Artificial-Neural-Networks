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

        ToplamaFonk.toplamafonk nesne1;
        excelClass nesne;
        AktivasyonFonk.activation aktif;
        Cell cell;
        int index,deger;
        private int data, count, neuron;
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
            string value1, value2,value3;
            value1 = textBox1.Text;
            value2 = textBox2.Text;
            value3 = textBox3.Text;
            data = Convert.ToInt16(value1);//Parametre sayısı
            count = Convert.ToInt16(value2);//Veri sayısı
            neuron = Convert.ToInt16(value3);//Neuron sayısı
            nesne.Create();
            nesne.basliklar(data);
            nesne.veriSeti(data, count, neuron);
            nesne.show();
            //nesne.fetch(data,count,neuron);
            cell.Neuron(data,count,index,deger,neuron);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            nesne = new excelClass();
            //nesne1 = new ToplamaFonk.toplamafonk(nesne);
            //aktif = new AktivasyonFonk.activation(nesne1,nesne);
            cell = new Cell(nesne);
            comboBox1.Items.Add("Ağırlık");
            comboBox1.Items.Add("Çarpım");
            comboBox1.Items.Add("Maksimum");
            comboBox1.SelectedIndex = 0;
            comboBox2.Items.Add("Sigmoid");
            comboBox2.Items.Add("Hiperbolik Tanjant");
            comboBox2.Items.Add("Adım Basamak");
            comboBox2.SelectedIndex = 0;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            nesne.kapatma();
        }

      
    }
}
