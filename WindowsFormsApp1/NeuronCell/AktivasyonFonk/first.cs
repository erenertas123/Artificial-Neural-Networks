using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.AktivasyonFonk
{
    class first : IAktif
    {
        public List<double> factive(List<double> aktif)
        {
            List<double> fnet = new List<double>();
            double y = 0.0;
            for (int i = 0; i < aktif.Count; i++)
            {

                y = 1 / (1 + Math.Pow(Math.E, aktif[i]));
                fnet.Add(y);
                y = 0.0;
            }
            return fnet;

        }

    }
}
