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
        ToplamaFonk.first ilk;
        ToplamaFonk.second second;
        ToplamaFonk.third third;
        ToplamaFonk.weight wei=new ToplamaFonk.weight();
        public toplamafonk(excelClass obj)
        {
            this.obj = obj; 
        }
         
        public List<double> ftop1(int data,int count,int index)
        {

            double[] weight = wei.wfunc(data,count);
            List<double> hostList = obj.fetch(data, count);
            List<double> toplam = new List<double>();
            List<double> deneme = new List<double>();
            second = new ToplamaFonk.second(weight,hostList);
            ilk = new ToplamaFonk.first(weight, hostList);
            third = new ToplamaFonk.third(weight,hostList);
            if (index==0) //AgırlıkFonksiyonu
            {
                
               deneme = ilk.top(data,count);
                for (int i = 0; i < deneme.Count; i++)
                {
                    obj.print(i + 2, data + 1, deneme[i]);
                }
                return deneme;
            }
            else if (index==1) //Çarpım
            {
                deneme = second.top(data,count);
                for (int i = 0; i < deneme.Count; i++)
                {
                    obj.print(i + 2, data + 1, deneme[i]);
                }
                return deneme;
            }
            else//Maksimum
            {
                deneme = third.top(data,count);
                for (int i = 0; i < deneme.Count; i++)
                {
                    obj.print(i + 2, data + 1, deneme[i]);
                }
                return deneme;
            }

        }

    }

}
