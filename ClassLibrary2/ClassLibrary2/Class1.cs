using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Class1
    {
        public int total(int qmaths, int qdsa, int qoose, int qjava, int qenglish, int qcvt, int qisl, int Mathematics, int DSA, int OOSE, int Java, int English, int CVT, int Islamiat)
        {
            int tl = 0;
            tl = (qmaths * Mathematics) + (qdsa * DSA) + (qoose * OOSE) + (qjava * Java) + (qenglish * English) + (qcvt * CVT) + (qisl * Islamiat);
            return tl;
        }
    }
}
