using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.ToplamaFonk
{
    class weight
    {
          public double[] wfunc(int data, int count)
        {
            double[] weight=new double[count];
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                weight[i] = rnd.NextDouble();
            }
            return weight;
        }
    }
}
