using System;
using System.Windows.Forms;
using System.Drawing;

namespace stock_exchange
{
    public partial class Form1 : Form
    {
        public Form1(string pl1,string pl2,string pl3,string pl4,string pl5,string pl6,string pl7,string pl8,string numoc,int numbcouplyr)
        {
            plry1 = pl1; plry2 = pl2; plry3 = pl3; plry4 = pl4; plry5 = pl5; plry6 = pl6; plry7 = pl7; plry8 = pl8; nocrd =Convert.ToInt32(numoc); numofplyr = numbcouplyr;
            InitializeComponent();
        }
        string plry1, plry2, plry3, plry4, plry5, plry6, plry7, plry8;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width;
            this.Height = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height;
            loadplayr();
            Random dealrnd = new Random();
            dealer=dealrnd.Next(1,numofplyr);
            ndealer=plid = dealer;
            getdealid();
            getcurnid(dealer);


        }
        ply1 pr1 = new ply1();
        ply2 pr2 = new ply2();
        ply3 pr3 = new ply3();
        ply4 pr4 = new ply4();
        ply5 pr5 = new ply5();
        ply6 pr6 = new ply6();
        ply7 pr7 = new ply7();
        ply8 pr8 = new ply8();
        stock stc = new stock();
      public  int fortis = 25, hdfc = 35, lnt = 45, ongc = 55, rel = 65, infos = 75, tata = 85;
        int plid, nocrd;
        public void getdealid()
        {
            if (dealer == 1)
            {
                lbldeal.Text = plry1;
            }
            else if (dealer == 2)
            {
                lbldeal.Text = plry2;
            }
            else if (dealer == 3)
            {
                lbldeal.Text = plry3;
            }
            else if (dealer == 4)
            {
                lbldeal.Text = plry4;
            }
            else if (dealer == 5)
            {
                lbldeal.Text = plry5;
            }
            else if (dealer == 6)
            {
                lbldeal.Text = plry6;
            }
            else if (dealer == 7)
            {
                lbldeal.Text = plry7;
            }
            else if (dealer == 8)
            {
                lbldeal.Text = plry8;
            }
        }
        public void getcurnid(int dealert)
        {
            if (dealert == 1)
            {
                Curply.Text = plry2;
                ndealer = 2;
            }
           else if (dealert == 2 && numofplyr > 2)
            {
                Curply.Text = plry3;
                ndealer = 3;
            }
           
            else if (dealert == 3 && numofplyr > 3)
            {
                Curply.Text = plry4;
                ndealer = 4;
            }
            
           else if (dealert == 4 && numofplyr>4)
            {
                Curply.Text = plry5;
                ndealer = 5;
            }
             
            else if (dealert == 5 && numofplyr>5)
            {
                Curply.Text = plry6;
                ndealer = 6;
            }
            else  if (dealert == 6 && numofplyr>6)
            {
                Curply.Text = plry7;
                ndealer = 7;
            }
            else if (dealert == 7 && numofplyr>7)
            {
                Curply.Text = plry8;
                ndealer = 8;
            }

            else if (dealert == 8)
            {
                Curply.Text = plry1;
                ndealer = 1;
            }
            else
            {
                Curply.Text = plry1;
                ndealer = 1;

            }
        }
        public Form1()
        {

        }
        public void loadplayr()
        {
            sv1.Text = sv2.Text = sv3.Text = sv4.Text = sv5.Text = sv6.Text = sv7.Text = sv8.Text = "";
            cin1.Text = cin2.Text = cin3.Text = cin4.Text = cin5.Text = cin6.Text = cin7.Text = cin8.Text = "";
            pr1.casih = pr2.casih = pr3.casih = pr4.casih = pr5.casih = pr6.casih = pr7.casih = pr8.casih = 700000;
            if (numofplyr >= 8)
            {
               stpltb8.Text= p8.Text = pr8.pname=plry8;
               pr8.stockv = 0;
               sv8.Text = pr8.stockv.ToString();
               cin8.Text = pr8.casih.ToString();
               Curply.Items.Add(plry8);

            }
             if (numofplyr >= 7)
            {
                stpltb7.Text = p7.Text = plry7;
                pr7.stockv = 0;
                sv7.Text = pr7.stockv.ToString();
                cin7.Text = pr7.casih.ToString();
                Curply.Items.Add(plry7);
            }
             if (numofplyr >= 6)
            {
                stpltb6.Text = p6.Text = plry6;
                pr6.stockv = 0;
                sv6.Text = pr6.stockv.ToString();
                cin6.Text = pr6.casih.ToString();
                Curply.Items.Add(plry6);
            }
             if (numofplyr >= 5)
            {
                stpltb5.Text = p5.Text = plry5;
                pr5.stockv = 0;
                sv5.Text = pr5.stockv.ToString();
                cin5.Text = pr5.casih.ToString();
                Curply.Items.Add(plry5);
            }
             if (numofplyr >= 4)
            {
                stpltb4.Text = p4.Text = plry4;
                pr4.stockv = 0;
                sv4.Text = pr4.stockv.ToString();
                cin4.Text = pr4.casih.ToString();
                Curply.Items.Add(plry4);
            }
             if (numofplyr>= 3)
            {
                stpltb3.Text = p3.Text = plry3;
                pr3.stockv = 0;
                sv3.Text = pr3.stockv.ToString();
                cin3.Text = pr3.casih.ToString();
                Curply.Items.Add(plry3);
            }
             if (numofplyr >= 2)
            {
                stpltb2.Text = p2.Text = plry2;
                pr2.stockv = 0;
                sv2.Text = pr2.stockv.ToString();
                cin2.Text = pr2.casih.ToString();
                 stpltb1.Text = p1.Text = plry1;
                 Curply.Items.Add(plry2);
                 Curply.Items.Add(plry1);
                 pr1.stockv = 0;
                 sv1.Text = pr1.stockv.ToString();
                 cin1.Text = pr1.casih.ToString();
            }
             
            
            
        }
        int numofplyr;
        int sc1, sc2, sc3, sc4, sc5, sc6, sc7, sc8, sc9;
        int newf, newh, newl, newo, newr, newi, newt;
        int shuffle=0;
        shuf ssss = null;
        public void cardshuffle()
        {
            if (shuffle == 0)
            {
                 ssss = new shuf(dealer, plry1, plry2, plry3, plry4, plry5, plry6, plry7, plry8, numofplyr, nocrd);
                 shuffle++;
            }
           
            ssss.ShowDialog();
            
            newf = ssss.fort;
            newh = ssss.hdfc;
            newl = ssss.lnt;
            newo = ssss.ongc;
            newr = ssss.rel;
            newi = ssss.infos;
            newt = ssss.tata;
            sc1 = ssss.sp1;
            sc2 = ssss.sp2;
            sc3 = ssss.sp3;
            sc4 = ssss.sp4;
            sc5= ssss.sp5;
            sc6 = ssss.sp6;
            sc7 = ssss.sp7;
            sc8 = ssss.sp8;
            sc9 = ssss.sp9;
           
            
        }
        private static readonly Random getrandom = new Random();

        public static int GetRandomNumber(int min, int max)
        {
            lock (getrandom) // synchronize
            {
                return getrandom.Next(1, 72);
            }
        }
        int dealer;
        private void button10_Click(object sender, EventArgs e)
        {
            button13.Enabled = false;
            roundpanel.Enabled = true;
            roundcounter = 1;
            //ndealer = dealer;
            plttotco = 1;
            button11.Enabled = true;
            button10.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
       

        int ndealer;
        int roundcounter = 1;
        int plttotco=1;
        private void button11_Click(object sender, EventArgs e)
        {
            if (plttotco <= (3 * numofplyr))
            {

                {
                    getcurnid(ndealer);
                    plttotco++;
                }
            }
            else if  (plttotco > (3 * numofplyr))
            {
                button21.Enabled = true;
                button11.Enabled = false;
                button13.Enabled = false;
            }
            //ndealer += 1;
            if (ndealer > numofplyr)
            {
                ndealer = 1;  
            }            
        }

       
        public int bsscal(string calty,int stocknu,int stockam)
        {
            if (calty == "buy")
            {
                stocknu += stockam;
            }
            else if (calty == "sell")
            {
                if (stockam <= stocknu)
                {
                    stocknu -= stockam;
                }
            }
            else if (calty == "short")
            {
                if (stocknu <= 0)
                {
                    stocknu -= stockam;
                }
            }
            else if (calty == "sbuy")
            {
                if (stocknu < 0)
                {
                    stocknu += stockam;
                }
            }
            return stocknu;
        }
        string calzer0string;
        public string calzer(int calzerval)
        {
            if (calzerval != 0)
            {
                calzer0string = (calzerval / 1000).ToString() + "K";
            }
            else
            {
                calzer0string = "";
            }
            
            return calzer0string;
        }
        Color ceo=Color.White;
        public System.Drawing.Color ceocheck(int ceocheck)
        {
            if (ceocheck >= 100000)
            {
                ceo =Color.Red;
            }
            else if (ceocheck >= 50000)
            {
                ceo = Color.Gold;
            }
            else
            {
                ceo = Color.White;
            }
            return ceo;
        }
        public int cashinhandcals(int stockval, int numofstock,string calty)
        {
            int tempv = 0;
            tempv = stockval * numofstock;
            if (calty == "buy")
            {
                tempv *= 1;
            }
            else if (calty == "sell")
            {
                tempv *= -1;
            }
            else if (calty == "short")
            {
                tempv *= 1;
            }
            else if (calty == "sbuy")
            {

                tempv *= -1;
            }
            return tempv;
        }
        public int cashinhandcal(int stockval,int numofstock,string calty)
        {
            int tempv=0;
            tempv = stockval * numofstock;
            if (calty == "buy")
            {
                tempv *= -1;
            }
            else if (calty == "sell")
            {
                tempv *= 1;
            }
            else if (calty == "short")
            {
                tempv *= -1;
            }
            else if (calty == "sbuy")
            {
                tempv *= 1;
            }
            return tempv;
        }
        int  s12, s13, s14, s15, s16, s17, s22, s23, s24, s25, s26, s27, pr3s1, s32, s33, s34, s35, s36, s37, pr4s1, s42, s43, s44, s45, s46, s47, pr5s1, s52, s53, s54, s55, s56, s57, pr6s1, s62, s63, s64, s65, s66, s67, pr7s1, s72, s73, s74, s75, s76, s77, pr8s1, s82, s83, s84, s85, s86, s87;
      //  bool tra;
        public void calstock(int plyidd,string caltype,string stockid,int numof)
        {
            
            if (plyidd == 1)
            {
               
                {
                    if (stockid == "1")
                    {
                        pr1.s1 = bsscal(caltype, pr1.s1, numof);
                        pr1.casih += cashinhandcal(fortis, numof, caltype);
                        pr1.stockv += cashinhandcals(fortis, numof, caltype);
                    }
                    else if (stockid == "2")
                    {
                        s12 = bsscal(caltype, s12, numof);
                        pr1.casih += cashinhandcal(hdfc, numof, caltype);
                        pr1.stockv += cashinhandcals(hdfc, numof, caltype);
                    }
                    else if (stockid == "3")
                    {
                        s13 = bsscal(caltype, s13, numof);
                        pr1.casih += cashinhandcal(lnt, numof, caltype);
                        pr1.stockv += cashinhandcals(lnt, numof, caltype);
                    }
                    else if (stockid == "4")
                    {
                        s14 = bsscal(caltype, s14, numof);
                        pr2.casih += cashinhandcal(ongc, numof, caltype);
                        pr1.stockv += cashinhandcals(ongc, numof, caltype);
                    }
                    else if (stockid == "5")
                    {
                        s15 = bsscal(caltype, s15, numof);
                        pr1.casih += cashinhandcal(rel, numof, caltype);
                        pr1.stockv += cashinhandcals(rel, numof, caltype);
                    }
                    else if (stockid == "6")
                    {
                        s16 = bsscal(caltype, s16, numof);
                        pr1.casih += cashinhandcal(infos, numof, caltype);
                        pr1.stockv += cashinhandcals(infos, numof, caltype);
                    }
                    else if (stockid == "7")
                    {
                        s17 = bsscal(caltype, s17, numof);
                        pr1.casih += cashinhandcal(tata, numof, caltype);
                        pr1.stockv += cashinhandcals(tata, numof, caltype);
                    }
                    p1s1.Text = calzer(pr1.s1);
                    p1s2.Text = calzer(s12);
                    p1s3.Text = calzer(s13);
                    p1s4.Text = calzer(s14);
                    p1s5.Text = calzer(s15);
                    p1s6.Text = calzer(s16);
                    p1s7.Text = calzer(s17);
                    p1s1c.BackColor = ceocheck(pr1.s1);
                    p1s2c.BackColor = ceocheck(s12);
                    p1s3c.BackColor = ceocheck(s13);
                    p1s4c.BackColor = ceocheck(s14);
                    p1s5c.BackColor = ceocheck(s15);
                    p1s6c.BackColor = ceocheck(s16);
                    p1s7c.BackColor = ceocheck(s17);
                    cin1.Text = pr1.casih.ToString();
                    sv1.Text = pr1.stockv.ToString();
                }
            }
            else if (plyidd == 2)
            {
            {
                if (stockid == "1")
                {
                    pr2.s1 = bsscal(caltype, pr2.s1, numof);
                    pr2.casih += cashinhandcal(fortis, numof, caltype);
                    pr2.stockv += cashinhandcals(fortis, numof, caltype);
                }
                else if (stockid == "2")
                {
                    s22 = bsscal(caltype, s22, numof);
                    pr2.casih += cashinhandcal(hdfc, numof, caltype);
                    pr2.stockv += cashinhandcals(hdfc, numof, caltype);
                }
                else if (stockid == "3")
                {
                    s23 = bsscal(caltype, s23, numof);
                    pr2.casih += cashinhandcal(lnt, numof, caltype);
                    pr2.stockv += cashinhandcals(lnt, numof, caltype);
                }
                else if (stockid == "4")
                {
                    s24 = bsscal(caltype, s24, numof);
                    pr2.casih += cashinhandcal(ongc, numof, caltype);
                    pr2.stockv += cashinhandcals(ongc, numof, caltype);
                }
                else if (stockid == "5")
                {
                    s25 = bsscal(caltype, s25, numof);
                    pr2.casih += cashinhandcal(rel, numof, caltype);
                    pr2.stockv += cashinhandcals(rel, numof, caltype);
                }
                else if (stockid == "6")
                {
                    s26 = bsscal(caltype, s26, numof);
                    pr2.casih += cashinhandcal(infos, numof, caltype);
                    pr2.stockv += cashinhandcals(infos, numof, caltype);
                }
                else if (stockid == "7")
                {
                    s27 = bsscal(caltype, s27, numof);
                    pr2.casih += cashinhandcal(tata, numof, caltype);
                    pr2.stockv += cashinhandcals(tata, numof, caltype);
                }
                p2s1.Text = calzer(pr2.s1);
                p2s1c.BackColor = ceocheck(pr2.s1);
                p2s2.Text = calzer(s22);
                p2s2c.BackColor = ceocheck(s22);
                p2s3.Text = calzer(s23);
                p2s3c.BackColor = ceocheck(s23);
                p2s4.Text = calzer(s24);
                p2s4c.BackColor = ceocheck(s24);
                p2s5.Text = calzer(s25);
                p2s5c.BackColor = ceocheck(s25);
                p2s6.Text = calzer(s26);
                p2s6c.BackColor = ceocheck(s26);
                p2s7.Text = calzer(s27);
                p2s7c.BackColor = ceocheck(s27); cin2.Text = pr2.casih.ToString();
                sv2.Text = pr2.stockv.ToString();
            }
            }else if (plyidd == 3)
            {
                
                {
                    if (stockid == "1")
                    {
                        pr3.s1 = bsscal(caltype, pr3.s1, numof);
                        pr3.casih += cashinhandcal(fortis, numof, caltype);
                        pr3.stockv += cashinhandcals(fortis, numof, caltype);
                    }
                    else if (stockid == "2")
                    {
                        s32 = bsscal(caltype, s32, numof);
                        pr3.casih += cashinhandcal(hdfc, numof, caltype);
                        pr3.stockv += cashinhandcals(hdfc, numof, caltype);
                    }
                    else if (stockid == "3")
                    {
                        s33 = bsscal(caltype, s33, numof);
                        pr3.casih += cashinhandcal(lnt, numof, caltype);
                        pr3.stockv += cashinhandcals(lnt, numof, caltype);
                    }
                    else if (stockid == "4")
                    {
                        s34 = bsscal(caltype, s34, numof);
                        pr3.casih += cashinhandcal(ongc, numof, caltype);
                        pr3.stockv += cashinhandcals(ongc, numof, caltype);
                    }
                    else if (stockid == "5")
                    {
                        s35 = bsscal(caltype, s35, numof);
                        pr3.casih += cashinhandcal(rel, numof, caltype);
                        pr3.stockv += cashinhandcals(rel, numof, caltype);
                    }
                    else if (stockid == "6")
                    {
                        s36 = bsscal(caltype, s36, numof);
                        pr3.casih += cashinhandcal(infos, numof, caltype);
                        pr3.stockv += cashinhandcals(infos, numof, caltype);

                    }
                    else if (stockid == "7")
                    {
                        s37 = bsscal(caltype, s37, numof);
                        pr7.casih += cashinhandcal(tata, numof, caltype);
                        pr7.stockv += cashinhandcals(tata, numof, caltype);
                    }
                    p3s1.Text = calzer(pr3.s1);
                    p3s2.Text = calzer(s32);
                    p3s3.Text = calzer(s33);
                    p3s4.Text = calzer(s34);
                    p3s5.Text = calzer(s35);
                    p3s6.Text = calzer(s36);
                    p3s7.Text = calzer(s37);
                    p3s1c.BackColor = ceocheck(pr3.s1);
                    p3s2c.BackColor = ceocheck(s32);
                    p3s3c.BackColor = ceocheck(s33);
                    p3s4c.BackColor = ceocheck(s34);
                    p3s5c.BackColor = ceocheck(s35);
                    p3s6c.BackColor = ceocheck(s36);
                    p3s7c.BackColor = ceocheck(s37);
                    cin3.Text = pr3.casih.ToString();
                    sv3.Text = pr3.stockv.ToString();
                }
            }else if (plyidd == 4)
            {
               
                {
                    if (stockid == "1")
                    {

                        pr4.s1 = bsscal(caltype, pr4.s1, numof);
                        pr4.casih += cashinhandcal(fortis, numof, caltype);
                        pr4.stockv += cashinhandcals(fortis, numof, caltype);
                    }
                    else if (stockid == "2")
                    {
                        s42 = bsscal(caltype, s42, numof);
                        pr4.casih += cashinhandcal(hdfc, numof, caltype);
                        pr4.stockv += cashinhandcals(hdfc, numof, caltype);
                    }
                    else if (stockid == "3")
                    {
                        s43 = bsscal(caltype, s43, numof);
                        pr4.casih += cashinhandcal(lnt, numof, caltype);
                        pr4.stockv += cashinhandcals(lnt, numof, caltype);
                    }
                    else if (stockid == "4")
                    {
                        s44 = bsscal(caltype, s44, numof);
                        pr4.casih += cashinhandcal(ongc, numof, caltype);
                        pr4.stockv += cashinhandcals(ongc, numof, caltype);
                    }
                    else if (stockid == "5")
                    {
                        s45 = bsscal(caltype, s45, numof);
                        pr4.casih += cashinhandcal(rel, numof, caltype);
                        pr4.stockv += cashinhandcals(rel, numof, caltype);
                    }
                    else if (stockid == "6")
                    {
                        s46 = bsscal(caltype, s46, numof);
                        pr4.casih += cashinhandcal(infos, numof, caltype);
                        pr4.stockv += cashinhandcals(infos, numof, caltype);
                    }
                    else if (stockid == "7")
                    {
                        s47 = bsscal(caltype, s47, numof);
                        pr4.casih += cashinhandcal(infos, numof, caltype);
                        pr4.stockv += cashinhandcals(infos, numof, caltype);
                    }
                    p4s1.Text = calzer(pr4.s1);
                    p4s1c.BackColor = ceocheck(pr4.s1);
                    p4s2.Text = calzer(s42);
                    p4s2c.BackColor = ceocheck(s42);
                    p4s3.Text = calzer(s43);
                    p4s3c.BackColor = ceocheck(s43);
                    p4s4.Text = calzer(s44);
                    p4s4c.BackColor = ceocheck(s44);
                    p4s5.Text = calzer(s45);
                    p4s5c.BackColor = ceocheck(s45);
                    p4s6.Text = calzer(s46);
                    p4s6c.BackColor = ceocheck(s46);
                    p4s7.Text = calzer(s47);
                    p4s7c.BackColor = ceocheck(s47);
                    cin4.Text = pr4.casih.ToString();
                    sv4.Text = pr4.stockv.ToString();
                }
            }else if (plyidd == 5)
            {
               
                {
                    if (stockid == "1")
                    {
                        pr5.s1 = bsscal(caltype, pr5.s1, numof);
                        pr5.casih += cashinhandcal(fortis, numof, caltype);
                        pr5.stockv += cashinhandcals(fortis, numof, caltype);
                    }
                    else if (stockid == "2")
                    {
                        s52 = bsscal(caltype, s52, numof);
                        pr5.casih += cashinhandcal(hdfc, numof, caltype);
                        pr5.stockv += cashinhandcals(hdfc, numof, caltype);
                    }
                    else if (stockid == "3")
                    {
                        s53 = bsscal(caltype, s53, numof);
                        pr5.casih += cashinhandcal(lnt, numof, caltype);
                        pr5.stockv += cashinhandcals(lnt, numof, caltype);
                    }
                    else if (stockid == "4")
                    {
                        s54 = bsscal(caltype, s54, numof);
                        pr5.casih += cashinhandcal(ongc, numof, caltype);
                        pr5.stockv += cashinhandcals(ongc, numof, caltype);
                    }
                    else if (stockid == "5")
                    {
                        s55 = bsscal(caltype, s55, numof);
                        pr5.casih += cashinhandcal(rel, numof, caltype);
                        pr5.stockv += cashinhandcals(rel, numof, caltype);
                    }
                    else if (stockid == "6")
                    {
                        s56 = bsscal(caltype, s56, numof);
                        pr5.casih += cashinhandcal(infos, numof, caltype);
                        pr5.stockv += cashinhandcals(infos, numof, caltype);
                    }
                    else if (stockid == "7")
                    {
                        s57 = bsscal(caltype, s57, numof);
                        pr5.casih += cashinhandcal(tata, numof, caltype);
                        pr5.stockv += cashinhandcals(tata, numof, caltype);
                    }
                    p5s1.Text = calzer(pr5.s1);
                    p5s1c.BackColor = ceocheck(pr5.s1);
                    p5s2.Text = calzer(s52);
                    p5s2c.BackColor = ceocheck(s52);
                    p5s3.Text = calzer(s53);
                    p5s3c.BackColor = ceocheck(s53);
                    p5s4.Text = calzer(s54);
                    p5s4c.BackColor = ceocheck(s54);
                    p5s5.Text = calzer(s55);
                    p5s5c.BackColor = ceocheck(s55);
                    p5s6.Text = calzer(s56);
                    p5s6c.BackColor = ceocheck(s56);
                    p5s7.Text = calzer(s57);
                    p5s7c.BackColor = ceocheck(s57);
                    cin5.Text = pr5.casih.ToString();
                    sv5.Text = pr5.stockv.ToString();
                }
            }else if (plyidd == 6)
            {
                
                {
                    if (stockid == "1")
                    {
                        pr6.s1 = bsscal(caltype, pr6.s1, numof);
                        pr6.casih += cashinhandcal(fortis, numof, caltype);
                        pr6.stockv += cashinhandcals(fortis, numof, caltype);
                    }
                    else if (stockid == "2")
                    {
                        s62 = bsscal(caltype, s62, numof);
                        pr6.casih += cashinhandcal(hdfc, numof, caltype);
                        pr6.stockv += cashinhandcals(hdfc, numof, caltype);
                    }
                    else if (stockid == "3")
                    {
                        s63 = bsscal(caltype, s63, numof);
                        pr6.casih += cashinhandcal(lnt, numof, caltype);
                        pr6.stockv += cashinhandcals(lnt, numof, caltype);
                    }
                    else if (stockid == "4")
                    {
                        s64 = bsscal(caltype, s64, numof);
                        pr6.casih += cashinhandcal(ongc, numof, caltype);
                        pr6.stockv += cashinhandcals(ongc, numof, caltype);
                    }
                    else if (stockid == "5")
                    {
                        s65 = bsscal(caltype, s65, numof);
                        pr6.casih += cashinhandcal(rel, numof, caltype);
                        pr6.stockv += cashinhandcals(rel, numof, caltype);
                    }
                    else if (stockid == "6")
                    {
                        s66 = bsscal(caltype, s66, numof);
                        pr6.casih += cashinhandcal(infos, numof, caltype);
                        pr6.stockv += cashinhandcals(infos, numof, caltype);
                    }
                    else if (stockid == "7")
                    {
                        s67 = bsscal(caltype, s67, numof);
                        pr6.casih += cashinhandcal(tata, numof, caltype);
                        pr6.stockv += cashinhandcals(tata, numof, caltype);
                    }
                    p6s1.Text = calzer(pr6.s1);
                    p6s1c.BackColor = ceocheck(pr6.s1);
                    p6s2.Text = calzer(s62);
                    p6s2c.BackColor = ceocheck(s62);
                    p6s3.Text = calzer(s63);
                    p6s3c.BackColor = ceocheck(s63);
                    p6s4.Text = calzer(s64);
                    p6s4c.BackColor = ceocheck(s64);
                    p6s5.Text = calzer(s65);
                    p6s5c.BackColor = ceocheck(s65);
                    p6s6.Text = calzer(s66);
                    p6s6c.BackColor = ceocheck(s66);
                    p6s7.Text = calzer(s67);
                    p6s7c.BackColor = ceocheck(s67);
                    cin6.Text = pr6.casih.ToString();
                    sv6.Text = pr6.stockv.ToString();
                }
            }else if (plyidd == 7)
            {
               
                {
                    if (stockid == "1")
                    {
                        pr7.s1 = bsscal(caltype, pr7.s1, numof);
                        pr7.casih += cashinhandcal(fortis, numof, caltype);
                        pr7.stockv += cashinhandcals(fortis, numof, caltype);
                    }
                    else if (stockid == "2")
                    {
                        s72 = bsscal(caltype, s72, numof);
                        pr7.casih += cashinhandcal(hdfc, numof, caltype);
                        pr7.stockv += cashinhandcals(hdfc, numof, caltype);
                    }
                    else if (stockid == "3")
                    {
                        s73 = bsscal(caltype, s73, numof);
                        pr7.casih += cashinhandcal(lnt, numof, caltype);
                        pr7.stockv += cashinhandcals(lnt, numof, caltype);
                    }
                    else if (stockid == "4")
                    {
                        s74 = bsscal(caltype, s74, numof);
                        pr7.casih += cashinhandcal(ongc, numof, caltype);
                        pr7.stockv += cashinhandcals(ongc, numof, caltype);
                    }
                    else if (stockid == "5")
                    {
                        s75 = bsscal(caltype, s75, numof);
                        pr7.casih += cashinhandcal(rel, numof, caltype);
                        pr7.stockv += cashinhandcals(rel, numof, caltype);
                    }
                    else if (stockid == "6")
                    {
                        s76 = bsscal(caltype, s76, numof);
                        pr7.casih += cashinhandcal(infos, numof, caltype);
                        pr7.stockv += cashinhandcals(infos, numof, caltype);
                    }
                    else if (stockid == "7")
                    {
                        s77 = bsscal(caltype, s77, numof);
                        pr7.casih += cashinhandcal(tata, numof, caltype);
                        pr7.stockv += cashinhandcals(tata, numof, caltype);
                    }
                    p7s1.Text = calzer(pr7.s1);
                    p7s1c.BackColor = ceocheck(pr7.s1);
                    p7s2.Text = calzer(s72);
                    p7s2c.BackColor = ceocheck(s72);
                    p7s3.Text = calzer(s73);
                    p7s3c.BackColor = ceocheck(s73);
                    p7s4.Text = calzer(s74);
                    p7s4c.BackColor = ceocheck(s74);
                    p7s5.Text = calzer(s75);
                    p7s5c.BackColor = ceocheck(s75);
                    p7s6.Text = calzer(s76);
                    p7s6c.BackColor = ceocheck(s76);
                    p7s7.Text = calzer(s77);
                    p7s7c.BackColor = ceocheck(s77);
                    cin7.Text = pr7.casih.ToString();
                    sv7.Text = pr7.stockv.ToString();
                }
            }else if (plyidd == 8)
            {
                if (stockid == "1")
                {
                  pr8.s1=  bsscal(caltype, pr8.s1, numof);
                  pr8.casih += cashinhandcal(fortis, numof, caltype);
                  pr8.stockv += cashinhandcals(fortis, numof,caltype);
                }
                else if (stockid == "2")
                {
                  s82=  bsscal(caltype, s82, numof);
                  pr8.casih += cashinhandcal(hdfc, numof, caltype);
                  pr8.stockv += cashinhandcals(hdfc, numof, caltype);
                }
                else if (stockid == "3")
                {
                  s83=  bsscal(caltype, s83, numof);
                  pr8.casih += cashinhandcal(lnt, numof, caltype);
                  pr8.stockv += cashinhandcals(lnt, numof, caltype);
                }
                else if (stockid == "4")
                {
                  s84=  bsscal(caltype, s84, numof);
                  pr8.casih += cashinhandcal(ongc, numof, caltype);
                  pr8.stockv += cashinhandcals(ongc, numof, caltype);
                }
                else if (stockid == "5")
                {
                  s85=  bsscal(caltype, s85, numof);
                  pr8.casih += cashinhandcal(rel, numof, caltype);
                  pr8.stockv += cashinhandcals(rel, numof, caltype);
                }
                else if (stockid == "6")
                {
                  s86=  bsscal(caltype, s86, numof);
                  pr8.casih += cashinhandcal(infos, numof, caltype);
                  pr8.stockv += cashinhandcals(infos, numof, caltype);
                }
                else if (stockid == "7")
                {
                  s87=  bsscal(caltype, s87, numof);
                  pr8.casih += cashinhandcal(tata, numof, caltype);
                  pr8.stockv += cashinhandcals(tata, numof, caltype);
                }
                p8s1.Text = calzer(pr8.s1);
                p8s1c.BackColor = ceocheck(pr8.s1);
                p8s2.Text = calzer(s82);
                p8s2c.BackColor = ceocheck(s82);
                p8s3.Text = calzer(s83);
                p8s3c.BackColor = ceocheck(s83);
                p8s4.Text = calzer(s84);
                p8s4c.BackColor = ceocheck(s84);
                p8s5.Text = calzer(s85);
                p8s5c.BackColor = ceocheck(s85);
                p8s6.Text = calzer(s86);
                p8s6c.BackColor = ceocheck(s86);
                p8s7.Text = calzer(s87);
                p8s7c.BackColor = ceocheck(s87);
                cin8.Text = pr8.casih.ToString();
                sv8.Text = pr8.stockv.ToString();
            }

        }
        string stockid;
        private void button8_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(buyytb.Text) > 0)
            {
                int i = (Convert.ToInt32(buyytb.Text) / 1000) * 1000;
                buyytb.Text = i.ToString();
            }
            
            calstock(ndealer, "buy", stockid, Convert.ToInt32(buyytb.Text));
        }

        private void stcmb_Leave(object sender, EventArgs e)
        {
            if (stcmb.Text == "Fortis Healtcare")
            {
                stockid = "1";
            }
            else if (stcmb.Text == "HDFC Bank")
            {
                stockid = "2";
            }
            else if (stcmb.Text == "Larsen && Toubro")
            {
                stockid = "3";
            }
            else if (stcmb.Text == "ONGC Natural Gas Corp.")
            {
                stockid = "4";
            }
            else if (stcmb.Text == "Reliance Industries Ltd.")
            {
                stockid = "5";
            }
            else if (stcmb.Text == "Infosys")
            {
                stockid = "6";
            }
            else if (stcmb.Text == "TATA Groups")
            {
                stockid = "7";
            }

        }
        int arrayi = 0;
        private void button9_Click(object sender, EventArgs e)
        {
            calstock(ndealer, "sell", stockid, Convert.ToInt32(buyytb.Text));
        }

        private void button12_Click(object sender, EventArgs e)
        {
            calstock(ndealer, "short", stockid, Convert.ToInt32(buyytb.Text));

            ssaray[arrayi] = ndealer + stockid;
            arrayi += 1;
        }
        string[] ssaray= new string[24];
        private void button21_Click(object sender, EventArgs e)
        {
            button27.Enabled = true;
            roundpanel.Enabled = false;
            buyytb.Text = "";
            getdealid();
            getcurnid(dealer);
            dealer += 1;
           plid= ndealer = dealer;
            if (dealer > numofplyr)
            {
                dealer = plid;
                ndealer = dealer;
            }
            specialcard();
            if (sc7 == 0)
            {
                button28.Enabled = false;
            }
            else
            {
                button28.Enabled = true;
            }
            if (sc6 == 0)
            {
                button29.Enabled = false;
            }
            else
            {
                button29.Enabled = true;
            }
            shuffle = 0;
        }

        private void buyytb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (stcmb.Text == "Fortis Healtcare")
                {
                    chrgcur.Text = (Convert.ToInt32(buyytb.Text) * fortis).ToString("0,00,000");
                }
                else if (stcmb.Text == "HDFC Bank")
                {
                    chrgcur.Text = (Convert.ToInt32(buyytb.Text) * hdfc).ToString("0,00,000");
                }
                else if (stcmb.Text == "Larsen && Toubro")
                {
                    chrgcur.Text = (Convert.ToInt32(buyytb.Text) * lnt).ToString("0,00,000");
                }
                else if (stcmb.Text == "ONGC Natural Gas Corp.")
                {
                    chrgcur.Text = (Convert.ToInt32(buyytb.Text) * ongc).ToString("0,00,000");
                }
                else if (stcmb.Text == "Reliance Industries Ltd.")
                {
                    chrgcur.Text = (Convert.ToInt32(buyytb.Text) * rel).ToString("0,00,000");
                }
                else if (stcmb.Text == "Infosys")
                {
                    chrgcur.Text = (Convert.ToInt32(buyytb.Text) * infos).ToString("0,00,000");
                }
                else if (stcmb.Text == "TATA Groups")
                {
                    chrgcur.Text = (Convert.ToInt32(buyytb.Text) * tata).ToString("0,00,000");
                }
            }
            catch
            {

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            cardshuffle();
           
            button10.Enabled = true;

        }
        public void raterev(int rateid,int newval,int oldval,string functnm)
        {
            if (rateid == 1)
            {
                ratenm.Text = "Fortis";
                rtval.Text = newval.ToString();
                if (functnm == "sus")
                {
                    cst1.Text = fortis.ToString();
                }
                

            }
            else if (rateid == 2)
            {
                ratenm.Text = "HDFC";
                rtval.Text = newval.ToString();
                if (functnm == "sus")
                {
                    cst2.Text = hdfc.ToString();
                }
                

            }
            else if (rateid == 3)
            {
                ratenm.Text = "L&&T";
                rtval.Text = newval.ToString();
                if (functnm == "sus")
                {
                    cst3.Text = lnt.ToString();
                }
            }
            else if (rateid == 4)
            {
                ratenm.Text = "ONGC";
                rtval.Text = newval.ToString();
                if (functnm == "sus")
                {
                    cst4.Text = ongc.ToString();
                }
            }
            else if (rateid == 5)
            {
                ratenm.Text = "Reliance";
                rtval.Text = newval.ToString();
                if (functnm == "sus")
                {
                    cst5.Text = rel.ToString();
                }
            }
            else if (rateid == 6)
            {
                ratenm.Text = "Infosys";
                rtval.Text = newval.ToString();
                if (functnm == "sus")
                {
                    cst6.Text = infos.ToString();
                }
            }
            else if (rateid == 7)
            {
                ratenm.Text = "TATA";
                rtval.Text = newval.ToString();
                if (functnm == "sus")
                {
                    cst7.Text = tata.ToString();
                }
            }
        }
        int rateids=1;
        private void button27_Click(object sender, EventArgs e)
        {
            rateids = 1;
            if (rateids == 1)
            {
                raterev(rateids, newf, fortis, "");
            }
            button25.Enabled = true;
            button26.Enabled = true;
            //cst2.Text = hdfc.ToString();
            //cst3.Text = lnt.ToString();
            //cst4.Text = ongc.ToString();
            //cst5.Text = rel.ToString();
            //cst6.Text = infos.ToString();
            //cst7.Text = tata.ToString();
        }
        public void pbcheck(int newe,int old,PictureBox pb,Label pbl)
        {
            if (newe < 0)
            {
                pb.Image = stock_exchange.Properties.Resources.rdw;
                pbl.Text = (newe / old * 100).ToString();
                pbl.ForeColor = Color.Red;
            }
            else
            {
                pb.Image = stock_exchange.Properties.Resources.gup;
                pbl.Text = (newe / old * 100).ToString();
                pbl.ForeColor = Color.Green;
            }
        }
        private void button26_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show("Player " + sc5 + " call only ?", "Varification",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (sc5 != 0)
                {

                    if (rateids == 1)
                    {
                        raterev(rateids, newf, fortis, "sus");
                    }
                    else if (rateids == 2)
                    {
                        raterev(rateids, newh, hdfc, "sus");
                    }
                    else if (rateids == 3)
                    {
                        raterev(rateids, newl, lnt, "sus");
                    }
                    else if (rateids == 4)
                    {
                        raterev(rateids, newo, ongc, "sus");
                    }
                    else if (rateids == 5)
                    {
                        raterev(rateids, newr, rel, "sus");
                    }
                    else if (rateids == 6)
                    {
                        raterev(rateids, newi, infos, "sus");
                    }
                    else if (rateids == 7)
                    {
                        raterev(rateids, newt, tata, "sus");
                    }
                    rateids += 1;
                    nxt2();
                    button26.Enabled = false;
                }
                else
                {

                }
            }
            
        }
        double tem1, tem2, tem3, tem4, tem5, tem6, tem7;
        string ss1, ss2, ss3, ss4, ss5, ss6, ss7;
        public void nxt1()
        {
            if (rateids == 1 && ss1!="blk")
            {

                srestockvalueupdate(pr1.s1, fortis,  pr1.stockv,"1");
                srestockvalueupdate(pr2.s1, fortis, pr2.stockv,  "2");
                srestockvalueupdate(pr3.s1, fortis, pr3.stockv,  "3");
                srestockvalueupdate(pr4.s1, fortis, pr4.stockv,  "4");
                srestockvalueupdate(pr5.s1, fortis, pr5.stockv,  "5");
                srestockvalueupdate(pr6.s1, fortis, pr6.stockv,  "6");
                srestockvalueupdate(pr7.s1, fortis, pr7.stockv,  "7");
                srestockvalueupdate(pr8.s1, fortis, pr8.stockv,  "8");
                if (newf < 0)
                {
                    pb1.BackgroundImage = stock_exchange.Properties.Resources.rdw;
                    tem1 = (double)newf / fortis;
                    tem1 *= 100;
                    pb1l.Text = tem1.ToString("0.00");
                    pb1l.ForeColor = Color.Red;
                }
                else if (newf == 0)
                {
                }
                else
                {
                    pb1.BackgroundImage = stock_exchange.Properties.Resources.gup;
                    tem1 = (double)newf / fortis;
                    tem1 *= 100;
                    pb1l.Text = tem1.ToString("0.00");
                    pb1l.ForeColor = Color.Green;
                }
                
                fortis += newf;
                restockvalueupdate(pr1.s1, fortis, sv1, pr1.stockv, "1");
                restockvalueupdate(pr2.s1, fortis, sv2, pr2.stockv, "2");
                restockvalueupdate(pr3.s1, fortis, sv3, pr3.stockv, "3");
                restockvalueupdate(pr4.s1, fortis, sv4, pr4.stockv, "4");
                restockvalueupdate(pr5.s1, fortis, sv5, pr5.stockv, "5");
                restockvalueupdate(pr6.s1, fortis, sv6, pr6.stockv, "6");
                restockvalueupdate(pr7.s1, fortis, sv7, pr7.stockv, "7");
                restockvalueupdate(pr8.s1, fortis, sv8, pr8.stockv, "8");
                if (fortis < 0)
                {
                    ss1 = "blk";
                    fortis = 0;
                    cst1.ForeColor = Color.Red;
                }
                else
                {
                    ss1 = "ac";
                    cst1.ForeColor = Color.Green;
                }
                cst1.Text = fortis.ToString();
            }
            else if (rateids == 2 && ss2 != "blk")
            {

                srestockvalueupdate(s12, hdfc, pr1.stockv, "1");
                srestockvalueupdate(s22, hdfc, pr2.stockv, "2");
                srestockvalueupdate(s32, hdfc, pr3.stockv, "3");
                srestockvalueupdate(s42, hdfc, pr4.stockv, "4");
                srestockvalueupdate(s52, hdfc, pr5.stockv, "5");
                srestockvalueupdate(s62, hdfc, pr6.stockv, "6");
                srestockvalueupdate(s72, hdfc, pr7.stockv, "7");
                srestockvalueupdate(s82, hdfc, pr8.stockv, "8");
                if (newh < 0)
                {
                    pb2.BackgroundImage = stock_exchange.Properties.Resources.rdw;
                    tem2 = (((double)newh / hdfc) * 100);
                    pb2l.Text = tem2.ToString("0.00");
                    pb2l.ForeColor = Color.Red;
                }
                else
                {
                    pb2.BackgroundImage = stock_exchange.Properties.Resources.gup;
                    tem2 = (((double)newh / hdfc) * 100);
                    pb2l.Text = tem2.ToString("0.00");
                    pb2l.ForeColor = Color.Green;
                }

                hdfc += newh;
                restockvalueupdate(s12, hdfc, sv1, pr1.stockv, "1");
                restockvalueupdate(s22, hdfc, sv2, pr2.stockv, "2");
                restockvalueupdate(s32, hdfc, sv3, pr3.stockv, "3");
                restockvalueupdate(s42, hdfc, sv4, pr4.stockv, "4");
                restockvalueupdate(s52, hdfc, sv5, pr5.stockv, "5");
                restockvalueupdate(s62, hdfc, sv6, pr6.stockv, "6");
                restockvalueupdate(s72, hdfc, sv7, pr7.stockv, "7");
                restockvalueupdate(s82, hdfc, sv8, pr8.stockv, "8");
                if (hdfc < 0)
                {
                    ss2 = "blk";
                    hdfc = 0;
                    cst2.ForeColor = Color.Red;
                }
                else
                {
                    ss2 = "ac";
                    cst2.ForeColor = Color.Navy;
                }
                cst2.Text = hdfc.ToString();
            }
            else if (rateids == 3 && ss3 != "blk")
            {

                srestockvalueupdate(s13, lnt, pr1.stockv, "1");
                srestockvalueupdate(s23, lnt, pr2.stockv, "2");
                srestockvalueupdate(s33, lnt, pr3.stockv, "3");
                srestockvalueupdate(s43, lnt, pr4.stockv, "4");
                srestockvalueupdate(s53, lnt, pr5.stockv, "5");
                srestockvalueupdate(s63, lnt, pr6.stockv, "6");
                srestockvalueupdate(s73, lnt, pr7.stockv, "7");
                srestockvalueupdate(s83, lnt, pr8.stockv, "8");
                if (newl < 0)
                {
                    pb3.BackgroundImage = stock_exchange.Properties.Resources.rdw;
                    pb3l.Text = (((double)newl / lnt) * 100).ToString("0.00");
                    pb3l.ForeColor = Color.Red;
                }
                else
                {
                    pb3.BackgroundImage = stock_exchange.Properties.Resources.gup;
                    pb3l.Text = (((double)newl / lnt) * 100).ToString("0.00");
                    pb3l.ForeColor = Color.Green;
                }
                lnt += newl;
                restockvalueupdate(s13, lnt, sv1, pr1.stockv, "1");
                restockvalueupdate(s23, lnt, sv2, pr2.stockv, "2");
                restockvalueupdate(s33, lnt, sv3, pr3.stockv, "3");
                restockvalueupdate(s43, lnt, sv4, pr4.stockv, "4");
                restockvalueupdate(s53, lnt, sv5, pr5.stockv, "5");
                restockvalueupdate(s63, lnt, sv6, pr6.stockv, "6");
                restockvalueupdate(s73, lnt, sv7, pr7.stockv, "7");
                restockvalueupdate(s83, lnt, sv8, pr8.stockv, "8");
                if (lnt < 0)
                {
                    ss3 = "blk";
                    lnt = 0;
                    cst3.ForeColor = Color.Red;
                }
                else
                {
                    ss3 = "ac";
                    cst3.ForeColor = Color.DodgerBlue;
                }
                cst3.Text = lnt.ToString();
            }
            else if (rateids == 4 && ss4 != "blk")
            {

                srestockvalueupdate(s14, ongc, pr1.stockv, "1");
                srestockvalueupdate(s24, ongc, pr2.stockv, "2");
                srestockvalueupdate(s34, ongc, pr3.stockv, "3");
                srestockvalueupdate(s44, ongc, pr4.stockv, "4");
                srestockvalueupdate(s54, ongc, pr5.stockv, "5");
                srestockvalueupdate(s64, ongc, pr6.stockv, "6");
                srestockvalueupdate(s74, ongc, pr7.stockv, "7");
                srestockvalueupdate(s84, ongc, pr8.stockv, "8");
                if (newo < 0)
                {
                    pb4.BackgroundImage = stock_exchange.Properties.Resources.rdw;
                    pb4l.Text = (((double)newo / ongc) * 100).ToString("0.00");
                    pb4l.ForeColor = Color.Red;
                }
                else
                {
                    pb4.BackgroundImage = stock_exchange.Properties.Resources.gup;
                    pb4l.Text = (((double)newo / ongc) * 100).ToString("0.00");
                    pb4l.ForeColor = Color.Green;
                }
                ongc += newo;
                restockvalueupdate(s14, ongc, sv1, pr1.stockv, "1");
                restockvalueupdate(s24, ongc, sv2, pr2.stockv, "2");
                restockvalueupdate(s34, ongc, sv3, pr3.stockv, "3");
                restockvalueupdate(s44, ongc, sv4, pr4.stockv, "4");
                restockvalueupdate(s54, ongc, sv5, pr5.stockv, "5");
                restockvalueupdate(s64, ongc, sv6, pr6.stockv, "6");
                restockvalueupdate(s74, ongc, sv7, pr7.stockv, "7");
                restockvalueupdate(s84, ongc, sv8, pr8.stockv, "8");
                if (ongc < 0)
                {
                    ss4 = "blk";
                    ongc = 0;
                    cst4.ForeColor = Color.Red;
                }
                else
                {
                    ss4 = "ac";
                    cst4.ForeColor = Color.Maroon;
                }
                cst4.Text = ongc.ToString();
            }
            else if (rateids == 5 && ss5 != "blk")
            {

                srestockvalueupdate(s15, rel, pr1.stockv, "1");
                srestockvalueupdate(s25, rel, pr2.stockv, "2");
                srestockvalueupdate(s35, rel, pr3.stockv, "3");
                srestockvalueupdate(s45, rel, pr4.stockv, "4");
                srestockvalueupdate(s55, rel, pr5.stockv, "5");
                srestockvalueupdate(s65, rel, pr6.stockv, "6");
                srestockvalueupdate(s75, rel, pr7.stockv, "7");
                srestockvalueupdate(s85, rel, pr8.stockv, "8");
                if (newr < 0)
                {
                    pb5.BackgroundImage = stock_exchange.Properties.Resources.rdw;
                    pb5l.Text = (((double)newr / rel) * 100).ToString("0.00");
                    pb5l.ForeColor = Color.Red;
                }
                else
                {
                    pb5.BackgroundImage = stock_exchange.Properties.Resources.gup;
                    pb5l.Text = (((double)newr / rel) * 100).ToString("0.00");
                    pb5l.ForeColor = Color.Green;
                }
                rel += newr;
                restockvalueupdate(s15, rel, sv1, pr1.stockv, "1");
                restockvalueupdate(s25, rel, sv2, pr2.stockv, "2");
                restockvalueupdate(s35, rel, sv3, pr3.stockv, "3");
                restockvalueupdate(s45, rel, sv4, pr4.stockv, "4");
                restockvalueupdate(s55, rel, sv5, pr5.stockv, "5");
                restockvalueupdate(s65, rel, sv6, pr6.stockv, "6");
                restockvalueupdate(s75, rel, sv7, pr7.stockv, "7");
                restockvalueupdate(s85, rel, sv8, pr8.stockv, "8");
                if (rel < 0)
                {
                    ss5 = "blk";
                    rel = 0;
                    cst5.ForeColor = Color.Red;
                }
                else
                {
                    ss5 = "ac";
                    cst5.ForeColor = Color.Olive;
                }
                cst5.Text = rel.ToString();
            }
            else if (rateids == 6 && ss6 != "blk")
            {

                srestockvalueupdate(s16, infos, pr1.stockv, "1");
                srestockvalueupdate(s26, infos, pr2.stockv, "2");
                srestockvalueupdate(s36, infos, pr3.stockv, "3");
                srestockvalueupdate(s46, infos, pr4.stockv, "4");
                srestockvalueupdate(s56, infos, pr5.stockv, "5");
                srestockvalueupdate(s66, infos, pr6.stockv, "6");
                srestockvalueupdate(s76, infos, pr7.stockv, "7");
                srestockvalueupdate(s86, infos, pr8.stockv, "8");
                if (newi < 0)
                {
                    pb6.BackgroundImage = stock_exchange.Properties.Resources.rdw;
                    
                    pb6l.Text = (((double)newi / infos) * 100).ToString("0.00");
                    pb6l.ForeColor = Color.Red;
                }
                else
                {
                    pb6.BackgroundImage = stock_exchange.Properties.Resources.gup;
                    pb6l.Text = (((double)newi / infos) * 100).ToString("0.00");
                    pb6l.ForeColor = Color.Green;
                }
                infos += newi;
                restockvalueupdate(s16, infos, sv1, pr1.stockv, "1");
                restockvalueupdate(s26, infos, sv2, pr2.stockv, "2");
                restockvalueupdate(s36, infos, sv3, pr3.stockv, "3");
                restockvalueupdate(s46, infos, sv4, pr4.stockv, "4");
                restockvalueupdate(s56, infos, sv5, pr5.stockv, "5");
                restockvalueupdate(s66, infos, sv6, pr6.stockv, "6");
                restockvalueupdate(s76, infos, sv7, pr7.stockv, "7");
                restockvalueupdate(s86, infos, sv8, pr8.stockv, "8");
                if (infos < 0)
                {
                    ss6 = "blk";
                    infos = 0;
                    cst6.ForeColor = Color.Red;
                }
                else
                {
                    ss6 = "ac";
                    cst6.ForeColor = Color.SkyBlue;
                }
                cst6.Text = infos.ToString();
            }
            else if (rateids == 7 && ss7 != "blk")
            {

                srestockvalueupdate(s17, tata, pr1.stockv, "1");
                srestockvalueupdate(s27, tata, pr2.stockv, "2");
                srestockvalueupdate(s37, tata, pr3.stockv, "3");
                srestockvalueupdate(s47, tata, pr4.stockv, "4");
                srestockvalueupdate(s57, tata, pr5.stockv, "5");
                srestockvalueupdate(s67, tata, pr6.stockv, "6");
                srestockvalueupdate(s77, tata, pr7.stockv, "7");
                srestockvalueupdate(s87, tata, pr8.stockv, "8");
                if (newt < 0)
                {
                    pb7.BackgroundImage = stock_exchange.Properties.Resources.rdw;
                    pb7l.Text = (((double)newt / tata) * 100).ToString("0.00");
                    pb7l.ForeColor = Color.Red;
                }
                else
                {
                    pb7.BackgroundImage = stock_exchange.Properties.Resources.gup;
                    pb7l.Text = (((double)newt / tata) * 100).ToString("0.00");
                    pb7l.ForeColor = Color.Green;
                }
                tata += newt;
                restockvalueupdate(s17, tata, sv1, pr1.stockv, "1");
                restockvalueupdate(s27, tata, sv2, pr2.stockv, "2");
                restockvalueupdate(s37, tata, sv3, pr3.stockv, "3");
                restockvalueupdate(s47, tata, sv4, pr4.stockv, "4");
                restockvalueupdate(s57, tata, sv5, pr5.stockv, "5");
                restockvalueupdate(s67, tata, sv6, pr6.stockv, "6");
                restockvalueupdate(s77, tata, sv7, pr7.stockv, "7");
                restockvalueupdate(s87, tata, sv8, pr8.stockv, "8");
                if (tata < 0)
                {
                    ss7 = "blk";
                    tata = 0;
                    cst7.ForeColor = Color.Red;
                }
                else
                {
                    ss7 = "ac";
                    cst7.ForeColor = Color.SteelBlue;
                }
                cst7.Text = tata.ToString();
            }
        }
        public void nxt2()
        {
            if (rateids == 1)
            {
                raterev(rateids, newf, fortis, "");
            }
            else if (rateids == 2)
            {
                raterev(rateids, newh, hdfc, "");
            }
            else if (rateids == 3)
            {
                raterev(rateids, newl, lnt, "");
            }
            else if (rateids == 4)
            {
                raterev(rateids, newo, ongc, "");
            }
            else if (rateids == 5)
            {
                raterev(rateids, newr, rel, "");
            }
            else if (rateids == 6)
            {
                raterev(rateids, newi, infos, "");
            }
            else if (rateids == 7)
            {
                raterev(rateids, newt, tata, "");
            }
        }
        public void nxtsh()
        {
            nxt1();
            rateids += 1;
            if (rateids > 7)
            {
                rateids = 1;
                button25.Enabled = false;
                button27.Enabled = false;
                button13.Enabled = true;
            }
            nxt2();
        
        }
        public void srestockvalueupdate(int s, int comp, int svti,string plids)
        {
            int tempsv = 0;
            tempsv = s * comp;
            svti -= tempsv;
                if (plids == "1")
                {
                    pr1.stockv = svti;
                }
                else if (plids == "2")
                {
                    pr2.stockv = svti;
                }
                else if (plids == "3")
                {
                    pr3.stockv = svti;
                }
                else if (plids == "4")
                {
                    pr4.stockv = svti;
                }
                else if (plids == "5")
                {
                    pr5.stockv = svti;
                }
                else if (plids == "6")
                {
                    pr6.stockv = svti;
                }
                else if (plids == "7")
                {
                    pr7.stockv = svti;
                }
                else if (plids == "8")
                {
                    pr8.stockv = svti;
                }
            
         //   svt.Text = svti.ToString();

        }
        public void restockvalueupdate(int s,int comp,Label svt,int svti,string plids)
        {
            int tempsv = 0;
            tempsv = s * comp;
            svti+=tempsv;
            svt.Text = svti.ToString();
            if (plids == "1")
            {
                pr1.stockv = svti;
            }
            else if (plids == "2")
            {
                pr2.stockv = svti;
            }
            else if (plids == "3")
            {
                pr3.stockv = svti;
            }
            else if (plids == "4")
            {
                pr4.stockv = svti;
            }
            else if (plids == "5")
            {
                pr5.stockv = svti;
            }
            else if (plids == "6")
            {
                pr6.stockv = svti;
            }
            else if (plids == "7")
            {
                pr7.stockv = svti;
            }
            else if (plids == "8")
            {
                pr8.stockv = svti;
            }
        }
        private void button25_Click(object sender, EventArgs e)
        {
            nxtsh();
        }
        int t10;
        public void specialcard()
        {
            if (sc1 != 0)
            {
                if (sc1 == 1)
                {
                    t10 = pr1.casih * 10/100;
                    t10 /= 1000;
                    t10 *= 1000;
                    pr1.casih -= t10;
                }
                else if (sc1 == 2)
                {
                    t10 = pr2.casih * 10 / 100;
                    t10 /= 1000;
                    t10 *= 1000;
                    pr2.casih -= t10;
                }
                else if (sc1 == 3)
                {
                    t10 = pr3.casih * 10 / 100;
                    t10 /= 1000;
                    t10 *= 1000;
                    pr3.casih -= t10;
                }
                else if (sc1 == 4)
                {
                    t10 = pr4.casih * 10 / 100;
                    t10 /= 1000;
                    t10 *= 1000;
                    pr4.casih -= t10;
                }
                else if (sc1 == 5)
                {
                    t10 = pr5.casih * 10 / 100;
                    t10 /= 1000;
                    t10 *= 1000;
                    pr5.casih -= t10;
                }
                else if (sc1 == 6)
                {
                    t10 = pr6.casih * 10 / 100;
                    t10 /= 1000;
                    t10 *= 1000;
                    pr6.casih -= t10;
                }
                else if (sc1 == 7)
                {
                    t10 = pr7.casih * 10 / 100;
                    t10 /= 1000;
                    t10 *= 1000;
                    pr7.casih -= t10;
                }
                else if (sc1 == 8)
                {
                    t10 = pr8.casih * 10 / 100;
                    t10 /= 1000;
                    t10 *= 1000;
                    pr8.casih -= t10;
                }
            }

            if (sc2 != 0)
            {
                if (sc2 == 1)
                {
                    t10 = pr1.casih * 10 / 100;
                    t10 /= 1000;
                    t10 *= 1000;
                    pr1.casih += t10;
                }
                else if (sc2 == 2)
                {
                    t10 = pr2.casih * 10 / 100;
                    t10 /= 1000;
                    t10 *= 1000;
                    pr2.casih += t10;
                }
                else if (sc2 == 3)
                {
                    t10 = pr3.casih * 10 / 100;
                    t10 /= 1000;
                    t10 *= 1000;
                    pr3.casih += t10;
                }
                else if (sc2 == 4)
                {
                    t10 = pr4.casih * 10 / 100;
                    t10 /= 1000;
                    t10 *= 1000;
                    pr4.casih += t10;
                }
                else if (sc2 == 5)
                {
                    t10 = pr5.casih * 10 / 100;
                    t10 /= 1000;
                    t10 *= 1000;
                    pr5.casih += t10;
                }
                else if (sc2 == 6)
                {
                    t10 = pr6.casih * 10 / 100;
                    t10 /= 1000;
                    t10 *= 1000;
                    pr6.casih += t10;
                }
                else if (sc2 == 7)
                {
                    t10 = pr7.casih * 10 / 100;
                    t10 /= 1000;
                    t10 *= 1000;
                    pr7.casih += t10;
                }
                else if (sc2 == 8)
                {
                    t10 = pr8.casih * 10 / 100;
                    t10 /= 1000;
                    t10 *= 1000;
                    pr8.casih += t10;
                }

            }
            if (sc4 != 0)
            {
                if (sc4 == 1)
                {
                    t10 = pr1.casih * 10 / 100;
                    t10 /= 1000;
                    t10 *= 1000;
                    pr1.casih += t10;
                }
                else if (sc4 == 2)
                {
                    t10 = pr2.casih * 10 / 100;
                    t10 /= 1000;
                    t10 *= 1000;
                    pr2.casih += t10;
                }
                else if (sc4 == 3)
                {
                    t10 = pr3.casih * 10 / 100;
                    t10 /= 1000;
                    t10 *= 1000;
                    pr3.casih += t10;
                }
                else if (sc4 == 4)
                {
                    t10 = pr4.casih * 10 / 100;
                    t10 /= 1000;
                    t10 *= 1000;
                    pr4.casih += t10;
                }
                else if (sc4 == 5)
                {
                    t10 = pr5.casih * 10 / 100;
                    t10 /= 1000;
                    t10 *= 1000;
                    pr5.casih += t10;
                }
                else if (sc4 == 6)
                {
                    t10 = pr6.casih * 10 / 100;
                    t10 /= 1000;
                    t10 *= 1000;
                    pr6.casih += t10;
                }
                else if (sc4 == 7)
                {
                    t10 = pr7.casih * 10 / 100;
                    t10 /= 1000;
                    t10 *= 1000;
                    pr7.casih += t10;
                }
                else if (sc4 == 8)
                {
                    t10 = pr8.casih * 10 / 100;
                    t10 /= 1000;
                    t10 *= 1000;
                    pr8.casih += t10;
                }

            }
            if (sc3 != 0)
            {
                if (sc3 == 1)
                {
                    t10 = pr1.casih * 10 / 100;
                    t10 /= 1000;
                    t10 *= 1000;
                    pr1.casih -= t10;
                }
                else if (sc3 == 2)
                {
                    t10 = pr2.casih * 10 / 100;
                    t10 /= 1000;
                    t10 *= 1000;
                    pr2.casih -= t10;
                }
                else if (sc3 == 3)
                {
                    t10 = pr3.casih * 10 / 100;
                    t10 /= 1000;
                    t10 *= 1000;
                    pr3.casih -= t10;
                }
                else if (sc3 == 4)
                {
                    t10 = pr4.casih * 10 / 100;
                    t10 /= 1000;
                    t10 *= 1000;
                    pr4.casih -= t10;
                }
                else if (sc3 == 5)
                {
                    t10 = pr5.casih * 10 / 100;
                    t10 /= 1000;
                    t10 *= 1000;
                    pr5.casih -= t10;
                }
                else if (sc3 == 6)
                {
                    t10 = pr6.casih * 10 / 100;
                    t10 /= 1000;
                    t10 *= 1000;
                    pr6.casih += t10;
                }
                else if (sc3 == 7)
                {
                    t10 = pr7.casih * 10 / 100;
                    t10 /= 1000;
                    t10 *= 1000;
                    pr7.casih -= t10;
                }
                else if (sc3 == 8)
                {
                    t10 = pr8.casih * 10 / 100;
                    t10 /= 1000;
                    t10 *= 1000;
                    pr8.casih -= t10;
                }

            }
            if (sc8 != 0)
            {
                if (sc8 == 1)
                {
                    t10 = 100000;
                    pr1.casih += t10;
                }
                else if (sc8 == 2)
                {
                    t10 = 100000;
                    pr2.casih -= t10;
                }
                else if (sc8 == 3)
                {
                    t10 = 100000;
                    pr3.casih -= t10;
                }
                else if (sc8 == 4)
                {
                    t10 = 100000;
                    pr4.casih -= t10;
                }
                else if (sc8 == 5)
                {
                    t10 = 100000;
                    pr5.casih -= t10;
                }
                else if (sc8 == 6)
                {
                    t10 = 100000;
                    pr6.casih += t10;
                }
                else if (sc8 == 7)
                {
                    t10 = 100000;
                    pr7.casih -= t10;
                }
                else if (sc8 == 8)
                {
                    t10 = 100000;
                    pr8.casih -= t10;
                }
            }
            if (sc9 != 0)
            {
                if (sc9 == 1)
                {
                    t10 = 100000;
                    pr1.casih += t10;
                }
                else if (sc9 == 2)
                {
                    t10 = 100000;
                    pr2.casih -= t10;
                }
                else if (sc9 == 3)
                {
                    t10 = 100000;
                    pr3.casih -= t10;
                }
                else if (sc9 == 4)
                {
                    t10 = 100000;
                    pr4.casih -= t10;
                }
                else if (sc9 == 5)
                {
                    t10 = 100000;
                    pr5.casih -= t10;
                }
                else if (sc9 == 6)
                {
                    t10 = 100000;
                    pr6.casih += t10;
                }
                else if (sc9 == 7)
                {
                    t10 = 100000;
                    pr7.casih -= t10;
                }
                else if (sc9 == 8)
                {
                    t10 = 100000;
                    pr8.casih -= t10;
                }
            }

        }
        string debss;
        int valofsd;
        private void button28_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("is player "+sc7+" call?","Verification",MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
            {
                Finalfoamcs f = new Finalfoamcs();
                f.ShowDialog();
                debss = f.ss;
                
            }
            if (debss == "ss1")
            {
                ss1 = "ac";
                fortis = 25;
                cst1.Text = fortis.ToString();
                cst1.ForeColor = Color.Green;
            }
            else if (debss == "ss2")
            {
                ss2 = "ac";
                hdfc = 35;
                cst2.Text = hdfc.ToString();
                cst2.ForeColor = Color.Navy;
            }
            else if (debss == "ss3")
            {
                ss3 = "ac";
                lnt = 45;
                cst3.Text = lnt.ToString();
                cst3.ForeColor = Color.DodgerBlue;
            }
            else if (debss == "ss4")
            {
                ss4 = "ac";
                ongc = 55;
                cst4.Text = ongc.ToString();
                cst4.ForeColor = Color.Maroon;
            }
            else if (debss == "ss5")
            {
                ss5 = "ac";
                rel = 65;
                cst5.Text = rel.ToString();
                cst5.ForeColor = Color.Olive;
            }
            else if (debss == "ss6")
            {
                ss6 = "ac";
                infos = 75;
                cst6.Text = infos.ToString();
                cst6.ForeColor = Color.SkyBlue;
            }
            else if (debss == "ss7")
            {
                ss7 = "ac";
                tata = 85;
                cst7.Text = tata.ToString();
                cst7.ForeColor = Color.SteelBlue;
            }
        }
        public void rightiss(int stc,int cain,int comp,int stcid,Label clal,Label sv,Label ps,Panel psc)
        {
            int tempsv = stc / 2;
            tempsv /= 1000;
            tempsv *= 1000;
            if ((tempsv * 10) <= cain)
            {
                stc += tempsv;
                cain -= tempsv * 10;
                stcid += tempsv * comp;
                clal.Text = cain.ToString();
                sv.Text = stcid.ToString();
                ps.Text = calzer(stc);
                psc.ForeColor = ceocheck(stc);
            }
        }
        public void perfsharerigh(int plyidri,string beb)
        {
            if (beb != null)
            {
                if (beb == "ss1")
                {
                    if (plyidri == 1)
                    {
                        rightiss(pr1.s1, pr1.casih, fortis, pr1.stockv, cin1, sv1, p1s1, p1s1c);
                    }
                    else if (plyidri == 2)
                    {
                        rightiss(pr2.s1, pr2.casih, fortis, pr2.stockv, cin2, sv2, p2s1, p2s1c);
                    }
                    else if (plyidri == 3)
                    {
                        rightiss(pr3.s1, pr3.casih, fortis, pr3.stockv, cin3, sv3, p3s1, p3s1c);
                    }
                    else if (plyidri == 4)
                    {
                        rightiss(pr4.s1, pr4.casih, fortis, pr4.stockv, cin4, sv4, p4s1, p4s1c);
                    }
                    else if (plyidri == 5)
                    {
                        rightiss(pr5.s1, pr5.casih, fortis, pr5.stockv, cin5, sv5, p5s1, p5s1c);
                    }
                    else if (plyidri == 6)
                    {
                        rightiss(pr6.s1, pr6.casih, fortis, pr6.stockv, cin6, sv6, p6s1, p6s1c);
                    }
                    else if (plyidri == 7)
                    {
                        rightiss(pr7.s1, pr7.casih, fortis, pr7.stockv, cin7, sv7, p7s1, p7s1c);
                    }
                    else if (plyidri == 8)
                    {
                        rightiss(pr8.s1, pr8.casih, fortis, pr8.stockv, cin8, sv8, p8s1, p8s1c);
                    }
                }
                else if (beb == "ss2")
                {
                    if (plyidri == 1)
                    {
                        rightiss(s12, pr1.casih, hdfc, pr1.stockv, cin1, sv1, p1s2, p1s2c);
                    }
                    else if (plyidri == 2)
                    {
                        rightiss(s22, pr2.casih, hdfc, pr2.stockv, cin2, sv2, p2s2, p2s2c);
                    }
                    else if (plyidri == 3)
                    {
                        rightiss(s32, pr3.casih, hdfc, pr3.stockv, cin3, sv3, p3s2, p3s2c);
                    }
                    else if (plyidri == 4)
                    {
                        rightiss(s42, pr4.casih, hdfc, pr4.stockv, cin4, sv4, p4s2, p4s2c);
                    }
                    else if (plyidri == 5)
                    {
                        rightiss(s52, pr5.casih, hdfc, pr5.stockv, cin5, sv5, p5s2, p5s2c);
                    }
                    else if (plyidri == 6)
                    {
                        rightiss(s62, pr6.casih, hdfc, pr6.stockv, cin6, sv6, p6s2, p6s2c);
                    }
                    else if (plyidri == 7)
                    {
                        rightiss(s72, pr7.casih, hdfc, pr7.stockv, cin7, sv7, p7s2, p7s2c);
                    }
                    else if (plyidri == 8)
                    {
                        rightiss(s82, pr8.casih, hdfc, pr8.stockv, cin8, sv8, p8s2, p8s2c);
                    }
                }
                else if (beb == "ss3")
                {
                    if (plyidri == 1)
                    {
                        rightiss(s13, pr1.casih, lnt, pr1.stockv, cin1, sv1, p1s3, p1s3c);
                    }
                    else if (plyidri == 2)
                    {
                        rightiss(s23, pr2.casih, lnt, pr2.stockv, cin2, sv2, p2s3, p2s3c);
                    }
                    else if (plyidri == 3)
                    {
                        rightiss(s33, pr3.casih, lnt, pr3.stockv, cin3, sv3, p3s3, p3s3c);
                    }
                    else if (plyidri == 4)
                    {
                        rightiss(s43, pr4.casih, lnt, pr4.stockv, cin4, sv4, p4s3, p4s3c);
                    }
                    else if (plyidri == 5)
                    {
                        rightiss(s53, pr5.casih, lnt, pr5.stockv, cin5, sv5, p5s3, p5s3c);
                    }
                    else if (plyidri == 6)
                    {
                        rightiss(s63, pr6.casih, lnt, pr6.stockv, cin6, sv6, p6s3, p6s3c);
                    }
                    else if (plyidri == 7)
                    {
                        rightiss(s73, pr7.casih, lnt, pr7.stockv, cin7, sv7, p7s3, p7s3c);
                    }
                    else if (plyidri == 8)
                    {
                        rightiss(s83, pr8.casih, lnt, pr8.stockv, cin8, sv8, p8s3, p8s3c);
                    }
                }
                else if (beb == "ss4")
                {
                    if (plyidri == 1)
                    {
                        rightiss(s14, pr1.casih, ongc, pr1.stockv, cin1, sv1, p1s4, p1s4c);
                    }
                    else if (plyidri == 2)
                    {
                        rightiss(s24, pr2.casih, ongc, pr2.stockv, cin2, sv2, p2s4, p2s4c);
                    }
                    else if (plyidri == 3)
                    {
                        rightiss(s34, pr3.casih, ongc, pr3.stockv, cin3, sv3, p3s4, p3s4c);
                    }
                    else if (plyidri == 4)
                    {
                        rightiss(s44, pr4.casih, ongc, pr4.stockv, cin4, sv4, p4s4, p4s4c);
                    }
                    else if (plyidri == 5)
                    {
                        rightiss(s54, pr5.casih, ongc, pr5.stockv, cin5, sv5, p5s4, p5s4c);
                    }
                    else if (plyidri == 6)
                    {
                        rightiss(s64, pr6.casih, ongc, pr6.stockv, cin6, sv6, p6s4, p6s4c);
                    }
                    else if (plyidri == 7)
                    {
                        rightiss(s74, pr7.casih, ongc, pr7.stockv, cin7, sv7, p7s4, p7s4c);
                    }
                    else if (plyidri == 8)
                    {
                        rightiss(s84, pr8.casih, ongc, pr8.stockv, cin8, sv8, p8s4, p8s4c);
                    }
                }
                else if (beb == "ss5")
                {
                    if (plyidri == 1)
                    {
                        rightiss(s15, pr1.casih, rel, pr1.stockv, cin1, sv1, p1s5, p1s5c);
                    }
                    else if (plyidri == 2)
                    {
                        rightiss(s25, pr2.casih, rel, pr2.stockv, cin2, sv2, p2s5, p2s5c);
                    }
                    else if (plyidri == 3)
                    {
                        rightiss(s35, pr3.casih, rel, pr3.stockv, cin3, sv3, p3s5, p3s5c);
                    }
                    else if (plyidri == 4)
                    {
                        rightiss(s45, pr4.casih, rel, pr4.stockv, cin4, sv4, p4s5, p4s5c);
                    }
                    else if (plyidri == 5)
                    {
                        rightiss(s55, pr5.casih, rel, pr5.stockv, cin5, sv5, p5s5, p5s5c);
                    }
                    else if (plyidri == 6)
                    {
                        rightiss(s65, pr6.casih, rel, pr6.stockv, cin6, sv6, p6s5, p6s5c);
                    }
                    else if (plyidri == 7)
                    {
                        rightiss(s75, pr7.casih, rel, pr7.stockv, cin7, sv7, p7s5, p7s5c);
                    }
                    else if (plyidri == 8)
                    {
                        rightiss(s85, pr8.casih, rel, pr8.stockv, cin8, sv8, p8s5, p8s5c);
                    }
                }
                else if (beb == "ss6")
                {
                    if (plyidri == 1)
                    {
                        rightiss(s16, pr1.casih, infos, pr1.stockv, cin1, sv1, p1s6, p1s6c);
                    }
                    else if (plyidri == 2)
                    {
                        rightiss(s26, pr2.casih, infos, pr2.stockv, cin2, sv2, p2s6, p2s6c);
                    }
                    else if (plyidri == 3)
                    {
                        rightiss(s36, pr3.casih, infos, pr3.stockv, cin3, sv3, p3s6, p3s6c);
                    }
                    else if (plyidri == 4)
                    {
                        rightiss(s46, pr4.casih, infos, pr4.stockv, cin4, sv4, p4s6, p4s6c);
                    }
                    else if (plyidri == 5)
                    {
                        rightiss(s56, pr5.casih, infos, pr5.stockv, cin5, sv5, p5s6, p5s6c);
                    }
                    else if (plyidri == 6)
                    {
                        rightiss(s66, pr6.casih, infos, pr6.stockv, cin6, sv6, p6s6, p6s6c);
                    }
                    else if (plyidri == 7)
                    {
                        rightiss(s76, pr7.casih, infos, pr7.stockv, cin7, sv7, p7s6, p7s6c);
                    }
                    else if (plyidri == 8)
                    {
                        rightiss(s86, pr8.casih, infos, pr8.stockv, cin8, sv8, p8s6, p8s6c);
                    }
                }
                else if (beb == "ss7")
                {
                    if (plyidri == 1)
                    {
                        rightiss(s17, pr1.casih, tata, pr1.stockv, cin1, sv1, p1s7, p1s7c);
                    }
                    else if (plyidri == 2)
                    {
                        rightiss(s27, pr2.casih, tata, pr2.stockv, cin2, sv2, p2s7, p2s7c);
                    }
                    else if (plyidri == 3)
                    {
                        rightiss(s37, pr3.casih, tata, pr3.stockv, cin3, sv3, p3s7, p3s7c);
                    }
                    else if (plyidri == 4)
                    {
                        rightiss(s47, pr4.casih, tata, pr4.stockv, cin4, sv4, p4s7, p4s7c);
                    }
                    else if (plyidri == 5)
                    {
                        rightiss(s57, pr5.casih, tata, pr5.stockv, cin5, sv5, p5s7, p5s7c);
                    }
                    else if (plyidri == 6)
                    {
                        rightiss(s67, pr6.casih, tata, pr6.stockv, cin6, sv6, p6s7, p6s7c);
                    }
                    else if (plyidri == 7)
                    {
                        rightiss(s77, pr7.casih, tata, pr7.stockv, cin7, sv7, p7s7, p7s7c);
                    }
                    else if (plyidri == 8)
                    {
                        rightiss(s87, pr8.casih, tata, pr8.stockv, cin8, sv8, p8s7, p8s7c);
                    }
                }
            }
        }
        private void button29_Click(object sender, EventArgs e)
        {
           // sc6 = 3;
            if (sc6 != 0)
            {
                Finalfoamcs f = new Finalfoamcs();
                f.ShowDialog();
                f.Text = "RIGHT ISSUE TAB";
                debss = f.ss;
            }
            int temppid = sc6;
            for ( int i = 0; i < numofplyr; i++)
            {
               
                perfsharerigh(temppid, debss);
                if (temppid <= numofplyr)
                {
                    temppid += 1;
                }
                else
                {
                    temppid = 1;
                }

            
            }
        }

        private void Curply_Leave(object sender, EventArgs e)
        {
            if (Curply.Text == plry1)
            {
                ndealer = 1;
            }
            else if (Curply.Text == plry2)
            {
                ndealer = 2;
            }
           else  if (Curply.Text == plry3)
            {
                ndealer = 3;
            }
           else  if (Curply.Text == plry4)
            {
                ndealer = 4;
            }
           else  if (Curply.Text == plry5)
            {
                ndealer = 5;
            }
            else if (Curply.Text == plry6)
            {
                ndealer = 6;
            }
            else if (Curply.Text == plry7)
            {
                ndealer = 7;
            }
            else if (Curply.Text == plry8)
            {
                ndealer = 8;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void shortbuy(String[] ssale)
        {
            string psid;
            Char pid;
            Char sid;
            psid = ssale[0];
            pid = psid[0];
            sid = psid[1];

        }
        
        private void button24_Click(object sender, EventArgs e)
        {
            calstock(ndealer, "sbuy", stockid, Convert.ToInt32(buyytb.Text));
        }

        private void stcmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
}

}