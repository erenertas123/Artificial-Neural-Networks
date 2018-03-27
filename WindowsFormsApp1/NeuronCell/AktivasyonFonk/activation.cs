using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.AktivasyonFonk
{
    class activation
    {
        ToplamaFonk.toplamafonk obj;
        ToplamaFonk.weight wei;
        excelClass excel;
        AktivasyonFonk.first first;
        AktivasyonFonk.second second;
        AktivasyonFonk.third third;
        int sayac = 0;
        public activation(ToplamaFonk.toplamafonk obj,excelClass excel)
        {
            this.obj = obj;
            this.excel = excel;
        }      
        public void activated(int data,int count,int index,int deger,int neuron)
        {
            double[] wlist = new double[count];
            wei = new ToplamaFonk.weight();
            wlist = wei.wfunc(data,count);
            List<double> aktif = obj.ftop1(data,count,index,wlist,neuron);
            List<double> fnet = new List<double>();
            first = new AktivasyonFonk.first();
            second = new AktivasyonFonk.second();
            third = new AktivasyonFonk.third();
            if (deger==0)//Sigmoid
            {
                fnet=first.factive(aktif);
                for (int i = 0; i <fnet.Count; i++)
                {
                    excel.print((i + 2 + sayac), data + 2, fnet[i]);
                }
                sayac = sayac + count;
            }
            else if (deger==1)//Hiperbolik tanjant
            {
                fnet = second.factive(aktif);
                for (int i = 0; i < fnet.Count; i++)
                {
                    excel.print((i + 2 + sayac), data + 2, fnet[i]);
                }
                sayac = sayac + count;
            }
            else//Step by Step
            {
                fnet = third.factive(aktif);
                for (int i = 0; i < fnet.Count; i++)
                {
                    excel.print((i + 2 + sayac), data + 2, fnet[i]);
                }
                sayac = sayac + count;
            }
            

        }

       
    }
}
