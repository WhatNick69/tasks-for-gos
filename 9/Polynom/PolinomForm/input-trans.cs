using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolinomForm
{
    class input_trans
    {
        public double[] StringSplit(string dannye)
        {
            string[] arr = dannye.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            double[] doubarr = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                doubarr[i] = double.Parse(arr[i]);
            }
            return doubarr;
        }
    }
}
