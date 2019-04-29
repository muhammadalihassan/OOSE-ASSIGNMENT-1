using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public bool compare(int[] a, int[] b)
        {
            bool flag = true;
            int max = 0;
            if (a.Length >= b.Length)
                max = a.Length;
            else
                max = b.Length;
            for (int i = 0; i < max; i++)
            {
                if (a.Length > b.Length)
                    flag = false;
                else if (a.Length < b.Length)
                    flag = false;
                else if (a.Length == b.Length)
                {
                    for (int j = 0; j < a.Length; j++)
                    {
                        if (a[j] == b[j])
                        {

                        }
                        else
                            flag = false;
                    }
                }
                else
                    flag = false;
            }
            return flag;
        }
    }
}
