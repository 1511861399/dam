using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.tk.dam.Entity
{
    public class Yh
    {
        public int Xh { get; set; }
        public string Xm { get; set; }
        public string Dlm { get; set; }
        public string Xb { get; set; }
        public string Bm { get; set; }
        public string Zw { get; set; }
        public string Yhdj { get; set; }
        public string Qz { get; set; }
        public string Qx { get; set; }
        public string Bz { get; set; }
    }

    class YhComparer : IComparer<Yh>
    {
        public int Compare(Yh yh1, Yh yh2)
        {
            return yh1.Xh - yh2.Xh;
        }
    }
}
