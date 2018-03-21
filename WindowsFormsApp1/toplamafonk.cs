using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class toplamafonk
    {
        excelClass obj;
        public toplamafonk(excelClass obj)
        {
            this.obj = obj;
        }
         public List<double> wfunc(int data,int count)
        {
            List<double> weight = new List<double>();
            Random rnd = new Random();
            for (int i = 2; i <= count + 1; i++)
            {
                for (int j = 2; j <= data + 1; j++) 
                {   
                    weight.Add(rnd.NextDouble());
                }
            }

            return weight;           
        }
        public List<double> ftop1(int data,int count,int index)
        {
            List<double> weight = wfunc(data, count);
            List<double> hostList = obj.fetch(data, count);
            List<double> toplam = new List<double>();
            if (index==0) //Toplama Fonksiyonu
            {
                double value = 0.0;
                for (int i = 0; i < count * data; i++) 
                {
                    value = hostList[i] * weight[i];
                    toplam.Add(value);
                }

                double cell = 0.0;
                List<double> deneme = new List<double>();
                for (int i = 0; i <= toplam.Count; i++)
                {
                    if (i % data == 0 && i != 0)
                    {
                        deneme.Add(cell);
                        cell = toplam[i - 1];
                    }
                    else
                    {
                        cell += toplam[i];
                    }
                }

                for (int i = 0; i < deneme.Count; i++)
                {
                    obj.print(i + 2, data + 1, deneme[i]);
                }
                return deneme;
            }
            else if (index==1) //Çarpım
            {
               
                double value = 0.0;
                for (int i = 0; i < count * data; i++)
                {
                    value = hostList[i] * weight[i];
                    toplam.Add(value);
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
                for (int i = 0; i < deneme.Count; i++)
                {
                    obj.print(i + 2, data + 1, deneme[i]);
                }
                return deneme;

            }
            else
            {
                double value = 0.0;
                for (int i = 0; i < count * data; i++)
                {
                    value = hostList[i] * weight[i];
                    toplam.Add(value);
                }
                double cell = 0.0,big=0.0;
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
                        cell = toplam[i];
                        if (big<cell)
                        {
                            big = cell;
                        }
                    }

                }
                for (int i = 0; i < deneme.Count; i++)
                {
                    obj.print(i + 2, data + 1, deneme[i]);
                }
                return deneme;
            }

        }

    }

}
