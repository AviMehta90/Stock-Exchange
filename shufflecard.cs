using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock_exchange
{
    class shufflecard
    {

        public static string[] odeck = { " ","w1", "w2", "w3", "w4", "h1", "h2", "h3", "h4", "h5", "h6", "t1", "t2", "t3", "t4", "t5", "t6", "t7", "t8", "o1", "o2", "o3", "o4", "o5", "o6", "o7", "o8", "r1", "r2", "r3", "r4", "r5", "r6", "r7", "r8", "r9", "r10", "i1", "i2", "i3", "i4", "i5", "i6", "i7", "i8", "i9", "i10", "i11", "i12", "n1", "n2", "n3", "n4", "n5", "n6", "n7", "n8", "n9", "n10", "n11", "n12", "s1", "s2", "s4", "s4", "s5", "s6", "s7", "s8", "s9" };
        public static string[] sdeck = new string[70];
        public int[] checkrndno = new int[70];
        //int cards = 69;
        string cls;
        public  int fortis, hdfc, lnt, ongc, rel, infos, tata, spcrd;
        int n,returvalue;
        int rightc=0, debc=0, ssc=0;
        Random rand = new Random();
        public int randomai()
        {
            
            n = rand.Next(1, 70);
            if (n == 67 && rightc < 6)
            {
                rightc++;
                n = rand.Next(1, 70);
                n = randomai();
            }
            else if(n==66 && debc<3)
            {
                debc++;
                n = rand.Next(1, 70);
                n = randomai();
            }
            else if (n == 68 && ssc < 1)
            {
                ssc++;
                n = rand.Next(1, 70);
                n = randomai();
            }
            else
            {

            }
            Console.WriteLine(n);
            return n;
        }
        public void shuffle()
        {
            {
                int l = 0;
                for (int k = 0; k <= 69; k++)
                {
                    n = randomai();
                    int i = 0;
                    for (int j = 0; j <=69; j++)
                    {

                        if (n == checkrndno[j])
                        {
                            //.show("");if()
                           
                            {
                                k -= 1;
                            }
                           // Console.WriteLine(n);
                            i++;
                        }
                        else
                        {
                            if (j == 69 && i==0)
                            {
                                sdeck[l] = odeck[n];
                                checkrndno[l] = n;
                                k -= 1;
                                i = 0;
                                l++;
                            }
                            if (l == 69)
                            {
                                k = 70;
                            }
                        }

                    }

                    // string temp = odeck[i];

                    // odeck[n] = temp;
                }
            }
            Shufflebutton_Click();

        }
        public int cardid(string crdid, out string clss)
        {
            Char lbl;
            string lblnum;
            fortis = hdfc = lnt = ongc = rel = infos = tata = spcrd = 0;
            lbl=crdid[0];
           
                if (crdid.Length>2)
                {
                    lblnum = crdid[1].ToString() + crdid[2].ToString();
                }
                else
                {
                    lblnum = crdid[1].ToString();
                }
            
       
            if (lbl == 'w')
            {
                if (lblnum == "1")
                {
                    fortis = 10;
                }
                else if (lblnum == "2")
                {
                    fortis = 5;
                }
                else if (lblnum == "3")
                {
                    fortis = -5;
                }
                else if (lblnum == "4")
                {
                    fortis = -10;
                }
                cls = "f";
                returvalue = fortis;
            }
            else if (lbl == 'h')
            {
                if (lblnum == "1")
                {
                    hdfc = 5;
                }
                else if (lblnum == "2")
                {
                    hdfc = 10;
                }
                else if (lblnum == "3")
                {
                    hdfc = 15;
                }
                else if (lblnum == "4")
                {
                    hdfc = -5;
                }
                else if (lblnum == "5")
                {
                    hdfc = -10;
                }
                else if (lblnum == "6")
                {
                    hdfc = -15;
                }
                cls = "h";
                returvalue = hdfc;
            }
            else if (lbl == 't')
            {
                if (lblnum == "1")
                {
                    lnt = 5;
                }
                else if (lblnum == "2")
                {
                    lnt = 10;
                }
                else if (lblnum == "3")
                {
                    lnt = 15;
                }
                else  if (lblnum == "4")
                {
                    lnt = -5;
                }
                else  if (lblnum == "5")
                {
                    lnt = -10;
                }
                else if (lblnum == "6")
                {
                    lnt = -15;
                }
                else  if (lblnum == "7")
                {
                    lnt = 20;
                }
                else if (lblnum == "8")
                {
                    lnt = -20;
                }
                cls = "t";
                returvalue = lnt;
            }
            else if (lbl == 'o')
            {
                if (lblnum == "1")
                {
                    ongc = 5;
                }
                else if (lblnum == "2")
                {
                    ongc = 10;

                }
                else if (lblnum == "3")
                {
                    ongc = 15;
                }
                else   if (lblnum == "4")
                {
                    ongc = 20;
                }
                else  if (lblnum == "5")
                {
                    ongc = -5;
                }
                else  if (lblnum == "6")
                {
                    ongc = -10;
                }
                else  if (lblnum == "7")
                {
                    ongc = -15;
                }
                else  if (lblnum == "8")
                {
                    ongc = -20;
                }
                cls = "o";
                returvalue = ongc;
            }
            else if (lbl == 'r')
            {
                if (lblnum == "1")
                {
                    rel = 5;
                }
                else if (lblnum == "2")
                {
                    rel = 10;
                }
                else if (lblnum == "3")
                {
                    rel = 15;
                }
                else if (lblnum == "4")
                {
                    rel = 20;
                }
                else if (lblnum == "5")
                {
                    rel = 25;
                }
                else if (lblnum == "6")
                {
                    rel = -20;
                }
                else if (lblnum == "7")
                {
                    rel = -25;
                }
                else if (lblnum == "8")
                {
                    rel = -5;
                }
                else if (lblnum == "9")
                {
                    rel = -10;
                }
                else if (lblnum == "10")
                {
                    rel = -15;
                }
                cls = "r";
                returvalue = rel;
            }
            else if (lbl == 'i')
            {
                if (lblnum == "1")
                {
                    infos = 5;
                }
                else if (lblnum == "2")
                {
                    infos = 10;
                }
                else if (lblnum == "3")
                {
                    infos = 15;
                }
                else if (lblnum == "4")
                {
                    infos = 20;
                }
                else if (lblnum == "5")
                {
                    infos = 25;
                }
                else if (lblnum == "6")
                {
                    infos= 30;
                }
                else if (lblnum == "7")
                {
                    infos = -5;
                }
                else if (lblnum == "8")
                {
                    infos = -10;
                }
                else if (lblnum == "9")
                {
                    infos = -15;
                }
                else if (lblnum == "10")
                {
                    infos = -20;
                }
                else if (lblnum == "11")
                {
                    infos = -25;
                }
                else if (lblnum == "12")
                {
                    infos = -30;
                }
                cls = "i";
                returvalue = infos;
            }
            else if (lbl == 'n')
            {
                if (lblnum == "1")
                {
                    tata = 5;
                }
                else if (lblnum == "2")
                {
                    tata = 10;
                }
                else if (lblnum == "3")
                {
                    tata = 15;
                }
                else if (lblnum == "4")
                {
                    tata = 20;
                }
                else if (lblnum == "5")
                {
                    tata = 25;
                }
                else if (lblnum == "6")
                {
                    tata = 30;
                }
                else if (lblnum == "7")
                {
                    tata = -5;
                }
                else if (lblnum == "8")
                {
                    tata = -10;
                }
                else if (lblnum == "9")
                {
                    tata = -15;
                }
                else if (lblnum == "10")
                {
                    tata= -20;
                }
                else if (lblnum == "11")
                {
                    tata = -25;
                }
                else if (lblnum == "12")
                {
                    tata = -30;
                }
                cls = "n";
                returvalue = tata;
            }
            else if (lbl == 's')
            {
                if (lblnum == "1")
                {
                    spcrd = 1;
                }
                else if (lblnum == "2")
                {
                    spcrd = 2;
                }
                else if (lblnum == "3")
                {
                    spcrd = 3;
                }
                else if (lblnum == "4")
                {
                    spcrd = 4;
                }
                else if (lblnum == "5")
                {
                    spcrd = 5;
                }
                else if (lblnum == "6")
                {
                    spcrd = 6;
                }
                else if (lblnum == "7")
                {
                    spcrd = 7;
                }
                else if (lblnum == "8")
                {
                    spcrd = 8;
                }
                else if (lblnum == "9")
                {
                    spcrd = 9;
                }
                cls = "s";
                returvalue = spcrd;
            }
            clss = cls;
            return returvalue;
        }

        public string[] pl1 = new string[8];
        public string[] pl2 = new string[8];
        public string[] pl3 = new string[8];
        public string[] pl4 = new string[8];
        public string[] pl5 = new string[8];
        public string[] pl6 = new string[8];
        public string[] pl7 = new string[8];
        public string[] pl8 = new string[8];
        public void Shufflebutton_Click()
        {
            int i = 0;
            for (int j = 0; j <= 7; j++)
            {

                {

                    {
                        pl1[j] = sdeck[i];
                        pl2[j] = sdeck[i + 1];
                        pl3[j] = sdeck[i + 2];
                        pl4[j] = sdeck[i + 3];
                        pl5[j] = sdeck[i + 4];
                        pl6[j] = sdeck[i + 5];
                        pl7[j] = sdeck[i + 6];
                        pl8[j] = sdeck[i + 7];
                        i += 8;
                    }


                }
            }
        }
    }
}

