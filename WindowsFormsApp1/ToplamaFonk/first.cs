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
        public List<double> top(int data,int count)
        {
            List<double> toplam = new List<double>();
            double value = 0.0;

            for (int i = 0; i < data; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    value = hostList[i] * weight[j];
                    toplam.Add(value);
                }
            }
            //for (int i = 0; i < toplam.Count; i++)
            //{
            //    MessageBox.Show("Hostlist "+hostList[i].ToString()+" Toplam "+toplam[i].ToString());
            //}

            double cell = 0.0;
            List<double> deneme = new List<double>();
            for (int i = 0; i <= toplam.Count; i++)
            {
                if (i % data == 0 && i != 0)
                {
                    deneme.Add(cell);
                    if (i!=toplam.Count)
                    {
                        cell = toplam[i];
                    }
                    else
                    {
                        cell = 0.0;
                    }
                }
                if(i%data!=0 || i==0)
                {
                    cell += toplam[i];
                }
            }
            //foreach (var item in deneme)
            //{
            //    MessageBox.Show(item.ToString() );
            //}
            return deneme;
        }

    }
}
