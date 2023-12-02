using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock_exchange
{
    class stock
    {
        public int fortis, hdfc, lnt, ongc, rel, infos, tata;
        public int f=1, h=2,l=3, o=4, r=5, i=6, t=7;
        public int sid;
        public string stocknm; 
        public int stid(int cid)
        {
            if (cid==1)
            {
                sid = 1;
            }
            else if (cid == 2)
            {
                sid = 2;
            }
            else if (cid==3)
            {
                sid = 3;
            }
            else if (cid == 4)
            {
                sid = 4;
            }
            else if (cid == 5)
            {
                sid = 5;
            }
            else if (cid == 6)
            {
                sid = 6;
            }
            else if (cid == 7)
            {
                sid = 7;
            }
            return sid;
        }
        public string stidva(int cid)
        {
            if (cid == 1)
            {
                stocknm = "f";
            }
            else if (cid == 2)
            {
                stocknm = "h";
            }
            else if (cid == 3)
            {
                stocknm = "l";
            }
            else if (cid == 4)
            {
                stocknm = "o";
            }
            else if (cid == 5)
            {
                stocknm = "r";
            }
            else if (cid == 6)
            {
                stocknm = "i";
            }
            else if (cid == 7)
            {
                stocknm = "t";
            }
            return stocknm;
        }
    }
}
