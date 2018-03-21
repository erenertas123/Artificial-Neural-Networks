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
        AktivasyonFonk.first first;
        AktivasyonFonk.second second;
        AktivasyonFonk.third third;
        public activation(toplamafonk obj,excelClass excel)
        {
            this.obj = obj;
            this.excel = excel;
        }
        
        public void activated(int data,int count,int index,int deger)
        {
            
            List<double> aktif = obj.ftop1(data,count,index);
            List<double> fnet = new List<double>();
            first = new AktivasyonFonk.first();
            second = new AktivasyonFonk.second();
            third = new AktivasyonFonk.third();
            double y = 0.0;
            if (deger==0)//Sigmoid
            {
                fnet=first.factive(aktif);
                for (int i = 0; i <fnet.Count; i++)
                {
                    excel.print(i + 2, data + 2, fnet[i]);
                }
             
            }
            else if (deger==1)//Hiperbolik tanjant
            {
                fnet = second.factive(aktif);
                for (int i = 0; i < fnet.Count; i++)
                {
                    excel.print(i + 2, data + 2, fnet[i]);
                }

            }
            else//Step by Step
            {
                fnet = third.factive(aktif);
                for (int i = 0; i < fnet.Count; i++)
                {
                    excel.print(i + 2, data + 2, fnet[i]);
                }
            }
            

        }

       
    }
}
