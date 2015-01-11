using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace End_People
{
    class Class1
    {
        public string FirstName { get; set; }
        public string Mail      { get; set; }
        public string Number    { get; set; }
        public string Color     { get; set; }
        public string WebLink   { get; set;}

        public Class1() { }

        public Class1(string F, string eM, string N, string W, string c) 
        {
            FirstName = F;  /* 名字 */
            Mail = eM;      /* Mail */
            Number = N;     /* 電話 */
            WebLink = W;    /* WebLink */
            Color = c;      /* 顏色 */
        }
    }
}
