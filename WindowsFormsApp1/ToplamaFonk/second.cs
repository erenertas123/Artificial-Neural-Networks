using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.ToplamaFonk
{
    class second : IToplama
    {
        double[] weight;
        List<double> hostList = new List<double>();
        public second(double[] weight, List<double> hostList)
        {
            this.weight = weight;
            this.hostList = hostList;
        }
        public List<double> top(int data,int count) {
            double value = 0.0;
            List<double> toplam = new List<double>();
            for (int i = 0; i < data; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    value = hostList[i] * weight[j];
                    toplam.Add(value);
                }
            }
            double cell = 1.0;
            List<double> deneme = new List<double>();
            for (int i = 1; i <= toplam.Count; i++)
            {
                if (i % data == 0)
                {
                    deneme.Add(cell);
                    cell = 1.0;
                }
                else
                {
                    cell *= toplam[i];
                } 
            }
            return deneme;
            //double[] weight;
            //List<double> hostList = new List<double>();
            //public first(double[] weight, List<double> hostList)
            //{
            //    this.weight = weight;
            //    this.hostList = hostList;
            //}
            //public List<double> top(int data, int count)
            //{
            //    List<double> toplam = new List<double>();
            //    double value = 0.0;

            //    for (int i = 0; i < data; i++)
            //    {
            //        for (int j = 0; j < count; j++)
            //        {
            //            value = hostList[i] * weight[j];
            //            toplam.Add(value);
            //        }
            //    }
            //    for (int i = 0; i < toplam.Count; i++)
            //    {
            //        MessageBox.Show(hostList[i].ToString() + " " + toplam[i].ToString());
            //    }

            //    double cell = 0.0;
            //    List<double> deneme = new List<double>();
            //    for (int i = 0; i <= toplam.Count; i++)
            //    {
            //        if (i % data == 0 && i != 0)
            //        {
            //            deneme.Add(cell);
            //            cell = toplam[i - 1];
            //        }
            //        else
            //        {
            //            cell += toplam[i];
            //        }
            //    }

            //    return deneme;
            //}
        }
    }
}
