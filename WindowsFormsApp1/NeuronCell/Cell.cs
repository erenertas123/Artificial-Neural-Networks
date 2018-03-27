using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.AktivasyonFonk;

namespace WindowsFormsApp1
{
    class Cell
    {
        excelClass excel = new excelClass();
        ToplamaFonk.toplamafonk toplama;
        AktivasyonFonk.activation activation;
        public Cell(excelClass excel) {
            this.excel = excel;
        }
        public void Neuron(int data, int count, int index, int deger,int neuron)
        {
            toplama = new ToplamaFonk.toplamafonk(excel);
            activation = new AktivasyonFonk.activation(toplama,excel);
            for (int i = 0; i < neuron; i++)
            {
                activation.activated(data, count, index, deger,neuron);
            }
        }
    }
}
