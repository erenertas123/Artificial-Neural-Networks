using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.ToplamaFonk
{
    class first : IToplama
    {
        
        double[] weight;
        List<double> hostList = new List<double>();
        public first(double [] weight,List<double> hostList) {
            this.weight = weight;
            this.hostList = hostList;
        }
        public List<double> top(int data,int count,int neuron)
        {
            List<double> toplam = new List<double>();
            double value = 0.0;
            int sayac = 0;

            for (int i = 0; i < hostList.Count/weight.Length; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    value = hostList[i] * weight[j];
                    toplam.Add(value);
                }
                //MessageBox.Show(toplam.Count.ToString());
            }
            double cell = 0.0;
            List<double> deneme = new List<double>();
            for (int i = 0; i <= toplam.Count; i++)
            {
                if (i % data == 0 && i != 0)
                {
                    deneme.Add(cell);
                    if (i != toplam.Count)
                    {
                        cell = toplam[i];
                    }
                    else
                    {
                        cell = 0.0;
                    }
                }
                if (i % data != 0 || i == 0)
                {
                    cell += toplam[i];
                }
            }
            //for (int i = 0; i < weight.Length; i++)
            //{
            //    MessageBox.Show("HostList. " + hostList[i].ToString() + " Weight. " + weight[i].ToString() +  " deneme " + deneme[i].ToString());
            //}
            //for (int i = 0; i < deneme.Count; i++)
            //{
            //    MessageBox.Show("deneem budur canu " + deneme[i].ToString());
            //}
            return deneme;
        }

    }
}
