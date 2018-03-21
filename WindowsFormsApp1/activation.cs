using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class activation
    {
        toplamafonk obj;
        excelClass excel;
        public activation(toplamafonk obj,excelClass excel)
        {
            this.obj = obj;
            this.excel = excel;
        }
        
        public void activated(int data,int count,int index,int deger)
        {
            
            List<double> aktif = obj.ftop1(data,count,index);
            List<double> fnet = new List<double>();
            double y = 0.0;
            if (deger==0)//Sigmoid
            {
                for (int i = 0; i < aktif.Count; i++)
                {

                    y = 1 / (1+Math.Pow(Math.E, aktif[i]));
                    fnet.Add(y);
                    y = 0.0;
                }
                for (int i = 0; i <fnet.Count; i++)
                {
                    excel.print(i + 2, data + 2, fnet[i]);
                }
             
            }
            else if (deger==1)//Hiperbolik tanjant
            {
                for (int i = 0; i < aktif.Count; i++)
                {                  
                    y = (1 - Math.Pow(Math.E, (-2*aktif[i]))) / (1 + Math.Pow(Math.E, (2*aktif[i])));
                    fnet.Add(y);
                    y = 0.0;
                }
                for (int i = 0; i < fnet.Count; i++)
                {
                    excel.print(i + 2, data + 2, fnet[i]);
                }

            }
            else//Step by Step
            {
                for (int i = 0; i < aktif.Count; i++)
                {
                    if (aktif[i]>=0)
                    {
                        y = 1;
                    }
                    else
                    {
                        y = 0;
                    }
                    fnet.Add(y);
                    y = 0.0;
                }
                for (int i = 0; i < fnet.Count; i++)
                {
                    excel.print(i + 2, data + 2, fnet[i]);
                }
            }
            

        }

       
    }
}
