using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.ToplamaFonk
{
    class third : IToplama
    {
        double[] weight;
        List<double> hostList = new List<double>();
        public third(double[] weight, List<double> hostList)
        {
            this.weight = weight;
            this.hostList = hostList;

        }
        public List<double> top(int data,int count,int neuron) {
            List<double> toplam = new List<double>();
            double value = 0.0;
            //for (int i = 0; i < data; i++)
            //{
            //    for (int j = 0; j < count; j++)
            //    {
            //        value = hostList[j] * weight[j];
            //        toplam.Add(value);
            //    }
            //}
            for (int i = 0; i < hostList.Count / weight.Length; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    value = hostList[i] * weight[j];
                    toplam.Add(value);
                }
            }
            double cell = 0.0, big = 0.0;
            List<double> deneme = new List<double>();
            for (int i = 1; i <= toplam.Count; i++)
            {
                if (i % data == 0)
                {
                    deneme.Add(big);
                    big = 0.0;
                }
                else
                {
                    cell = toplam[i-1];
                    if (big < cell)
                    {
                        big = cell;
                    }
                }
               
            }
            return deneme;
        }
    }
}
