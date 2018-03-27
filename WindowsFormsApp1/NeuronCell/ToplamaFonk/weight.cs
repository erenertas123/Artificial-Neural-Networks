using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.ToplamaFonk
{
    class weight
    {
        public double[] wfunc(int data, int count)
        {//Her veri seti için tek weight dizisi oluşturmalı.Hatalı buraya dön <<<<<<-------->>>>>>
           double[] weight=new double[count];
                Random rnd = new Random();
                for (int i = 0; i < count; i++)
                {   
                      weight[i] = rnd.NextDouble();
                }
            //for (int i = 0; i < weight.Length; i++)
            //{
            //    MessageBox.Show(weight[i].ToString());
            //}
            return weight;     
        }
    }
}
