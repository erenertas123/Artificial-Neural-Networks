using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.ToplamaFonk
{
    class toplamafonk
    {
        excelClass obj;
        ToplamaFonk.first first;
        ToplamaFonk.second second;
        ToplamaFonk.third third;
        ToplamaFonk.weight wei=new ToplamaFonk.weight();
        int sayac = 0;
        public toplamafonk(excelClass obj)
        {
            this.obj = obj;
        }

        public List<double> ftop1(int data, int count, int index,double[]wlist,int neuron)
        {
            List<double> hostList = obj.fetch(data,count,neuron);
            List<double> toplam = new List<double>();
            List<double> deneme = new List<double>();
            second = new ToplamaFonk.second(wlist, hostList);
            first = new ToplamaFonk.first(wlist, hostList);
            third = new ToplamaFonk.third(wlist, hostList);
            if (index == 0) //AgırlıkFonksiyonu
            {
                
                deneme = first.top(data, count, neuron);
                //for (int i = 0; i < deneme.Count; i++)
                //{
                //    MessageBox.Show(deneme[i].ToString());
                //}
                for (int i = 0; i < deneme.Count; i++)
                {
                   // MessageBox.Show(deneme[i].ToString() + " sayac " + sayac);
                    obj.print((i+2+sayac), data + 1, deneme[i]);
                }
                sayac = sayac + count;
                return deneme;
            }
            else if (index == 1) //Çarpım
            {
                deneme = second.top(data, count,neuron);
                for (int i = 0; i < deneme.Count; i++)
                {
                    obj.print((i + 2 + sayac), data + 1, deneme[i]);
                }
                sayac = sayac + count;
                return deneme;
            }
            else//Maksimum
            {
                deneme = third.top(data, count,neuron);
                for (int i = 0; i < deneme.Count; i++)
                {
                    obj.print((i + 2 + sayac), data + 1, deneme[i]);
                }
                sayac = sayac + count;
                return deneme;
            }
        }

    }

}
