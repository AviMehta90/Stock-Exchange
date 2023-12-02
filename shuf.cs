using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Resources;

namespace stock_exchange
{
    public partial class shuf : Form
    {
        public shuf(int id, string pp1, string pp2, string pp3, string pp4, string pp5, string pp6, string pp7, string pp8,int nop ,int noc)
        {
            InitializeComponent();
            plid = id;
            p1 = pp1; p2 = pp2; p3 = pp3; p4 = pp4; p5 = pp5; p6 = pp6; p7 = pp7; p8 = pp8;
            numop = nop;
            numoc = noc;
            shuffl = 0;
        }
        string p1, p2, p3, p4, p5, p6, p7, p8;
        int shuffl;
        private void label7_Click(object sender, EventArgs e)
        {

        }
       public int i,plid=0;
       int tempva,numop,numoc;
       string cardtemp;
        public void getcrd(int pl)
        {
            
            if (pl == 1)
            {
                plyrchange(1);
                if(DIENS==true)
                {
                    crd1.BackgroundImage = Image.FromFile(@".\Resources\"+scrd.pl1[i].ToString() + ".jpg");
                    crd2.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl1[i+1].ToString() + ".jpg");
                    crd3.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl1[i+2].ToString() + ".jpg");
                    crd4.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl1[i+3].ToString() + ".jpg");
                    crd5.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl1[i+4].ToString() + ".jpg");
                    crd6.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl1[i+5].ToString() + ".jpg");
                    crd7.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl1[i+6].ToString() + ".jpg");
                    crd8.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl1[i+7].ToString() + ".jpg");
                    fort1 = hdfc1 = lnt1 = ongc1 = rel1 = infos1 = tata1 = 0;
                    for (int ik = 0; ik < numoc; ik++)
                    {
                        
                        tempva = 0;
                        tempva = scrd.cardid(scrd.pl1[ik].ToString(), out cardtemp);
                        if (cardtemp == "f")
                        {
                            fort1 += tempva;
                        }
                        else if (cardtemp == "h")
                        {
                            hdfc1 += tempva;
                        }
                        else if (cardtemp == "t")
                        {
                            lnt1 += tempva;
                        }
                        else if (cardtemp == "o")
                        {
                            ongc1 += tempva;
                        }
                        else if (cardtemp == "r")
                        {
                            rel1 += tempva;
                        }
                        else if (cardtemp == "i")
                        {
                            infos1 += tempva;
                        }
                        else if (cardtemp == "n")
                        {
                            tata1 += tempva;
                        }
                        else if (cardtemp == "s")
                        {
                            spcrdplynm(tempva.ToString(), 1);
                        }
                    }
                   fh.Text = fort1.ToString();
                   hb.Text = hdfc1.ToString();
                   lt.Text = lnt1.ToString();
                   og.Text = ongc1.ToString();
                   rl.Text = rel1.ToString();
                   ifn.Text = infos1.ToString();
                   tt.Text = tata1.ToString();
                  



                }
            }
           else if (pl == 2)
            {
                plyrchange(2);
                if (DIENS == true)
                {
                    crd1.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl2[i].ToString() + ".jpg");
                    crd2.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl2[i + 1].ToString() + ".jpg");
                    crd3.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl2[i + 2].ToString() + ".jpg");
                    crd4.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl2[i + 3].ToString() + ".jpg");
                    crd5.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl2[i + 4].ToString() + ".jpg");
                    crd6.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl2[i + 5].ToString() + ".jpg");
                    crd7.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl2[i + 6].ToString() + ".jpg");
                    crd8.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl2[i + 7].ToString() + ".jpg");
                    fort2 = hdfc2 = lnt2 = ongc2 = rel2 = infos2 = tata2 = 0;
                    for (int ik = 0; ik <numoc; ik++)
                    {
                        tempva = 0;
                        tempva = scrd.cardid(scrd.pl2[ik].ToString(), out cardtemp);
                        if (cardtemp == "f")
                        {
                            fort2 += tempva;
                        }
                        else if (cardtemp == "h")
                        {
                            hdfc2 += tempva;
                        }
                        else if (cardtemp == "t")
                        {
                            lnt2 += tempva;
                        }
                        else if (cardtemp == "o")
                        {
                            ongc2 += tempva;
                        }
                        else if (cardtemp == "r")
                        {
                            rel2 += tempva;
                        }
                        else if (cardtemp == "i")
                        {
                            infos2 += tempva;
                        }
                        else if (cardtemp == "n")
                        {
                            tata2 += tempva;
                        }
                        else if (cardtemp == "s")
                        {
                            spcrdplynm(tempva.ToString(), 2);
                        }
                    }
                    fh.Text = fort2.ToString();
                    hb.Text = hdfc2.ToString();
                    lt.Text = lnt2.ToString();
                    og.Text = ongc2.ToString();
                    rl.Text = rel2.ToString();
                    ifn.Text = infos2.ToString();
                    tt.Text = tata2.ToString();
                    // fh.Text = fort1.ToString();
                }
            }
           else if (pl == 3)
            {
                plyrchange(3);
                if (DIENS == true)
                {
                    crd1.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl3[i].ToString() + ".jpg");
                    crd2.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl3[i + 1].ToString() + ".jpg");
                    crd3.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl3[i + 2].ToString() + ".jpg");
                    crd4.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl3[i + 3].ToString() + ".jpg");
                    crd5.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl3[i + 4].ToString() + ".jpg");
                    crd6.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl3[i + 5].ToString() + ".jpg");
                    crd7.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl3[i + 6].ToString() + ".jpg");
                    crd8.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl3[i + 7].ToString() + ".jpg");
                    fort3 = hdfc3 = lnt3 = ongc3 = rel3 = infos3 = tata3 = 0;
                    for (int ik = 0; ik <numoc; ik++)
                    {
                        tempva = 0;
                        tempva = scrd.cardid(scrd.pl3[ik].ToString(), out cardtemp);
                        if (cardtemp == "f")
                        {
                            fort3 += tempva;
                        }
                        else if (cardtemp == "h")
                        {
                            hdfc3 += tempva;
                        }
                        else if (cardtemp == "t")
                        {
                            lnt3 += tempva;
                        }
                        else if (cardtemp == "o")
                        {
                            ongc3 += tempva;
                        }
                        else if (cardtemp == "r")
                        {
                            rel3 += tempva;
                        }
                        else if (cardtemp == "i")
                        {
                            infos3 += tempva;
                        }
                        else if (cardtemp == "n")
                        {
                            tata3 += tempva;
                        }
                        else if (cardtemp == "s")
                        {
                            spcrdplynm(tempva.ToString(), 3);
                        }
                    }
                    fh.Text = fort3.ToString();
                    hb.Text = hdfc3.ToString();
                    lt.Text = lnt3.ToString();
                    og.Text = ongc3.ToString();
                    rl.Text = rel3.ToString();
                    ifn.Text = infos3.ToString();
                    tt.Text = tata3.ToString();
                    // fh.Text = fort1.ToString();
                }
            }
          else  if (pl == 4)
            {
                plyrchange(4);
                if (DIENS == true)
                {
                    crd1.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl4[i].ToString() + ".jpg");
                    crd2.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl4[i + 1].ToString() + ".jpg");
                    crd3.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl4[i + 2].ToString() + ".jpg");
                    crd4.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl4[i + 3].ToString() + ".jpg");
                    crd5.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl4[i + 4].ToString() + ".jpg");
                    crd6.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl4[i + 5].ToString() + ".jpg");
                    crd7.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl4[i + 6].ToString() + ".jpg");
                    crd8.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl4[i + 7].ToString() + ".jpg");
                    fort4 = hdfc4 = lnt4 = ongc4 = rel4 = infos4 = tata4 = 0;
                    for (int ik = 0; ik <numoc; ik++)
                    {
                        tempva = 0;
                        tempva = scrd.cardid(scrd.pl4[ik].ToString(), out cardtemp);
                        if (cardtemp == "f")
                        {
                            fort4 += tempva;
                        }
                        else if (cardtemp == "h")
                        {
                            hdfc4 += tempva;
                        }
                        else if (cardtemp == "t")
                        {
                            lnt4 += tempva;
                        }
                        else if (cardtemp == "o")
                        {
                            ongc4 += tempva;
                        }
                        else if (cardtemp == "r")
                        {
                            rel4 += tempva;
                        }
                        else if (cardtemp == "i")
                        {
                            infos4 += tempva;
                        }
                        else if (cardtemp == "n")
                        {
                            tata4 += tempva;
                        }
                        else if (cardtemp == "s")
                        {
                            spcrdplynm(tempva.ToString(), 4);
                        }
                    }
                    fh.Text = fort4.ToString();
                    hb.Text = hdfc4.ToString();
                    lt.Text = lnt4.ToString();
                    og.Text = ongc4.ToString();
                    rl.Text = rel4.ToString();
                    ifn.Text = infos4.ToString();
                    tt.Text = tata4.ToString();
                    // fh.Text = fort1.ToString();
                }
            }
            else  if (pl == 5)
            {
                plyrchange(5);
                if (DIENS == true)
                {
                    crd1.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl5[i].ToString() + ".jpg");
                    crd2.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl5[i + 1].ToString() + ".jpg");
                    crd3.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl5[i + 2].ToString() + ".jpg");
                    crd4.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl5[i + 3].ToString() + ".jpg");
                    crd5.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl5[i + 4].ToString() + ".jpg");
                    crd6.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl5[i + 5].ToString() + ".jpg");
                    crd7.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl5[i + 6].ToString() + ".jpg");
                    crd8.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl5[i + 7].ToString() + ".jpg");
                    fort5 = hdfc5 = lnt5 = ongc5 = rel5 = infos5 = tata5 = 0;
                    for (int ik = 0; ik <numoc; ik++)
                    {
                        tempva = 0;
                        tempva = scrd.cardid(scrd.pl5[ik].ToString(), out cardtemp);
                        if (cardtemp == "f")
                        {
                            fort5 += tempva;
                        }
                        else if (cardtemp == "h")
                        {
                            hdfc5 += tempva;
                        }
                        else if (cardtemp == "t")
                        {
                            lnt5 += tempva;
                        }
                        else if (cardtemp == "o")
                        {
                            ongc5 += tempva;
                        }
                        else if (cardtemp == "r")
                        {
                            rel5 += tempva;
                        }
                        else if (cardtemp == "i")
                        {
                            infos5 += tempva;
                        }
                        else if (cardtemp == "n")
                        {
                            tata5 += tempva;
                        }
                        else if (cardtemp == "s")
                        {
                            spcrdplynm(tempva.ToString(), 5);
                        }
                    }
                    fh.Text = fort5.ToString();
                    hb.Text = hdfc5.ToString();
                    lt.Text = lnt5.ToString();
                    og.Text = ongc5.ToString();
                    rl.Text = rel5.ToString();
                    ifn.Text = infos5.ToString();
                    tt.Text = tata5.ToString();
                    // fh.Text = fort1.ToString();
                }
            }
          else  if (pl == 6)
            {
                plyrchange(6);
                if (DIENS == true)
                {
                    crd1.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl6[i].ToString() + ".jpg");
                    crd2.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl6[i + 1].ToString() + ".jpg");
                    crd3.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl6[i + 2].ToString() + ".jpg");
                    crd4.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl6[i + 3].ToString() + ".jpg");
                    crd5.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl6[i + 4].ToString() + ".jpg");
                    crd6.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl6[i + 5].ToString() + ".jpg");
                    crd7.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl6[i + 6].ToString() + ".jpg");
                    crd8.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl6[i + 7].ToString() + ".jpg");
                    fort6 = hdfc6 = lnt6 = ongc6 = rel6 = infos6 = tata6 = 0;
                    for (int ik = 0; ik <numoc; ik++)
                    {
                        tempva = 0;
                        tempva = scrd.cardid(scrd.pl6[ik].ToString(), out cardtemp);
                        if (cardtemp == "f")
                        {
                            fort6 += tempva;
                        }
                        else if (cardtemp == "h")
                        {
                            hdfc6 += tempva;
                        }
                        else if (cardtemp == "t")
                        {
                            lnt6 += tempva;
                        }
                        else if (cardtemp == "o")
                        {
                            ongc6 += tempva;
                        }
                        else if (cardtemp == "r")
                        {
                            rel6 += tempva;
                        }
                        else if (cardtemp == "i")
                        {
                            infos6 += tempva;
                        }
                        else if (cardtemp == "n")
                        {
                            tata6 += tempva;
                        }
                        else if (cardtemp == "s")
                        {
                            spcrdplynm(tempva.ToString(), 6);
                        }
                    }
                    fh.Text = fort6.ToString();
                    hb.Text = hdfc6.ToString();
                    lt.Text = lnt6.ToString();
                    og.Text = ongc6.ToString();
                    rl.Text = rel6.ToString();
                    ifn.Text = infos6.ToString();
                    tt.Text = tata6.ToString();
                    // fh.Text = fort1.ToString();
                }
            }
          else  if (pl == 7)
            {
                plyrchange(7);
                if (DIENS == true)
                {
                    crd1.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl7[i].ToString() + ".jpg");
                    crd2.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl7[i + 1].ToString() + ".jpg");
                    crd3.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl7[i + 2].ToString() + ".jpg");
                    crd4.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl7[i + 3].ToString() + ".jpg");
                    crd5.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl7[i + 4].ToString() + ".jpg");
                    crd6.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl7[i + 5].ToString() + ".jpg");
                    crd7.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl7[i + 6].ToString() + ".jpg");
                    crd8.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl1[i + 7].ToString() + ".jpg");
                    fort7 = hdfc7 = lnt7 = ongc7 = rel7 = infos7 = tata7 = 0;
                    for (int ik = 0; ik <numoc; ik++)
                    {
                        tempva = 0;
                        tempva = scrd.cardid(scrd.pl7[ik].ToString(), out cardtemp);
                        if (cardtemp == "f")
                        {
                            fort7 += tempva;
                        }
                        else if (cardtemp == "h")
                        {
                            hdfc7 += tempva;
                        }
                        else if (cardtemp == "t")
                        {
                            lnt7 += tempva;
                        }
                        else if (cardtemp == "o")
                        {
                            ongc7 += tempva;
                        }
                        else if (cardtemp == "r")
                        {
                            rel7 += tempva;
                        }
                        else if (cardtemp == "i")
                        {
                            infos7 += tempva;
                        }
                        else if (cardtemp == "n")
                        {
                            tata7 += tempva;
                        }
                        else if (cardtemp == "s")
                        {
                            spcrdplynm(tempva.ToString(), 7);
                        }
                    }
                    fh.Text = fort7.ToString();
                    hb.Text = hdfc7.ToString();
                    lt.Text = lnt7.ToString();
                    og.Text = ongc7.ToString();
                    rl.Text = rel7.ToString();
                    ifn.Text = infos7.ToString();
                    tt.Text = tata7.ToString();
                    // fh.Text = fort1.ToString();
                }
            }
          else  if (pl == 8)
            {
                plyrchange(8);
                if (DIENS == true)
                {
                    crd1.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl8[i].ToString() + ".jpg");
                    crd2.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl8[i + 1].ToString() + ".jpg");
                    crd3.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl8[i + 2].ToString() + ".jpg");
                    crd4.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl8[i + 3].ToString() + ".jpg");
                    crd5.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl8[i + 4].ToString() + ".jpg");
                    crd6.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl8[i + 5].ToString() + ".jpg");
                    crd7.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl8[i + 6].ToString() + ".jpg");
                    crd8.BackgroundImage = Image.FromFile(@".\Resources\" + scrd.pl8[i + 7].ToString() + ".jpg");
                    fort8 = hdfc8 = lnt8 = ongc8 = rel8 = infos8 = tata8 = 0;
                    for (int ik = 0; ik <numoc; ik++)
                    {
                        tempva = 0;
                        tempva = scrd.cardid(scrd.pl8[ik].ToString(), out cardtemp);
                        if (cardtemp == "f")
                        {
                            fort8 += tempva;
                        }
                        else if (cardtemp == "h")
                        {
                            hdfc8 += tempva;
                        }
                        else if (cardtemp == "t")
                        {
                            lnt8 += tempva;
                        }
                        else if (cardtemp == "o")
                        {
                            ongc8 += tempva;
                        }
                        else if (cardtemp == "r")
                        {
                            rel8 += tempva;
                        }
                        else if (cardtemp == "i")
                        {
                            infos8 += tempva;
                        }
                        else if (cardtemp == "n")
                        {
                            tata8 += tempva;
                        }
                        else if (cardtemp == "s")
                        {
                            spcrdplynm(tempva.ToString(), 8);
                        }
                    }
                    fh.Text = fort8.ToString();
                    hb.Text = hdfc8.ToString();
                    lt.Text = lnt8.ToString();
                    og.Text = ongc8.ToString();
                    rl.Text = rel8.ToString();
                    ifn.Text = infos8.ToString();
                    tt.Text = tata8.ToString();
                    // fh.Text = fort1.ToString();
                }
            }
            fort = fort1 + fort2 + fort3 + fort4 + fort5 + fort6 + fort7 + fort8;
            hdfc = hdfc1 + hdfc2 + hdfc3 + hdfc4 + hdfc5 + hdfc6 + hdfc7 + hdfc8;
            lnt = lnt1 + lnt2 + lnt3 + lnt4 + lnt5 + lnt6 + lnt7 + lnt8;
            ongc = ongc1 + ongc2 + ongc3 + ongc4 + ongc5 + ongc6 + ongc7 + ongc8;
            rel = rel1 + rel2 + rel3 + rel4 + rel5 + rel6 + rel7 + rel8;
            infos = infos1 + infos2 + infos3 + infos4 + infos5 + infos6 + infos7 + infos8;
            tata = tata1 + tata2 + tata3 + tata4 + tata5 + tata6 + tata7 + tata8;
        }
        shufflecard scrd = new shufflecard();
        private void shuf_Load(object sender, EventArgs e)
        {
            if (shuffl == 0)
            {
                scrd.shuffle();
                shuffl++;
            }
            getcrd(plid);
            plyrnamenext();
        }
        public void plyrnamenext()
        {
            if (numoc == 6)
            {
                crd7.Visible = false;
                crd8.Visible = false;
             }
            else if (numoc == 7)
            {
                crd8.Visible = false;
            }
        }
        int fort1, fort2, fort3, fort4, fort5, fort6, fort7, fort8;
        int hdfc1, hdfc2, hdfc3, hdfc4, hdfc5, hdfc6, hdfc7, hdfc8;
        int lnt1, lnt2, lnt3, lnt4, lnt5, lnt6, lnt7, lnt8;
        int ongc1, ongc2, ongc3, ongc4, ongc5, ongc6, ongc7, ongc8;
        int rel1, rel2, rel3, rel4, rel5, rel6, rel7, rel8;
        int infos1, infos2, infos3, infos4, infos5, infos6, infos7, infos8;
        int tata1, tata2, tata3, tata4, tata5, tata6, tata7, tata8;
     public int sp1, sp2, sp3, sp4, sp5, sp6, sp7, sp8, sp9;
      public  int fort, hdfc, lnt, ongc, rel, infos, tata;
        private void button1_Click(object sender, EventArgs e)
        {
            plid += 1;
            if (plid > numop)
            {
                plid = 1;
            }
            getcrd(plid);
           
        }
        bool DIENS;
        public bool plyrchange(int plyrid)
        {
            fh.Text = hb.Text = lt.Text= og.Text = rl.Text = ifn.Text = tt.Text="0";
            crd1.BackgroundImage = crd2.BackgroundImage = crd3.BackgroundImage = crd4.BackgroundImage = crd5.BackgroundImage = crd6.BackgroundImage = crd7.BackgroundImage = crd8.BackgroundImage = null;
            if (plyrid == 1)
            {
                DialogResult result = MessageBox.Show("Is " + p1 + " on the screen", "Verrification", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    plid = plyrid;
                    DIENS = true;
                    lblnxt.Text = p2;
                    plycur.Text = p1;
                    lblpre.Text = p8;
                }
                else
                {
                    DIENS = false;
                    lblnxt.Text = p2;
                    plycur.Text = p1;
                    lblpre.Text = p8;
                }
               

            }
            else if (plyrid == 2)
            {
                DialogResult result = MessageBox.Show("Is " + p2 + " on the screen", "Verrification", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    plid = plyrid;
                    DIENS = true;
                    lblnxt.Text = p3;
                    plycur.Text = p2;
                    lblpre.Text = p1;
                }
                else
                {
                    DIENS = false;
                    lblnxt.Text = p3;
                    plycur.Text = p2;
                    lblpre.Text = p1;
                }

            }else if (plyrid == 3)
            {
                DialogResult result = MessageBox.Show("Is " + p3 + " on the screen", "Verrification", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    plid = plyrid;
                    DIENS = true;
                   // lblnxt.Text = p4;
                   // lblpre.Text = p2;
                }
                else
                {
                    DIENS = false;
                }
                lblnxt.Text = p4;
                plycur.Text = p3;
                lblpre.Text = p2;

            }else if (plyrid == 4)
            {
                DialogResult result = MessageBox.Show("Is " + p4 + " on the screen", "Verrification", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    plid = plyrid;
                    DIENS = true;
                }
                else
                {
                    DIENS = false;
                }
                lblnxt.Text = p6;
                plycur.Text = p4;
                lblpre.Text = p3;

            } else if (plyrid == 5)
            {
                DialogResult result = MessageBox.Show("Is " + p5 + " on the screen", "Verrification", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    plid = plyrid;
                    DIENS = true;
                }
                else
                {
                    DIENS = false;
                }
                lblnxt.Text = p6;
                plycur.Text = p5;
                lblpre.Text = p4;

            }else if (plyrid == 6)
            {
                DialogResult result = MessageBox.Show("Is " + p6 + " on the screen", "Verrification", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    plid = plyrid;
                    DIENS = true;
                }
                else
                {
                    DIENS = false;
                }
                lblnxt.Text = p7; plycur.Text = p6;
                lblpre.Text = p5;

            }else if (plyrid == 7)
            {
                DialogResult result = MessageBox.Show("Is " + p7 + " on the screen", "Verrification", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    plid = plyrid;
                    DIENS = true;
                }
                else
                {
                    DIENS = false;
                }
                lblnxt.Text = p8; plycur.Text = p7;
                lblpre.Text = p6;
            }else if (plyrid == 8)
            {
                DialogResult result = MessageBox.Show("Is " + p8 + " on the screen", "Verrification", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    plid = plyrid;
                    DIENS = true;
                }
                else
                {
                    DIENS = false;
                }
                lblnxt.Text = p1; plycur.Text = p8;
                lblpre.Text = p7;
            }
            return DIENS;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            plid -= 1;
            if (plid < 1)
            {
                plid = numop;
            }
            getcrd(plid);
        }
        public void spcrdplynm(string crdnum,int plids )
        {
            if (crdnum == "1")
            {
                sp1 = plid;
            }
            else if (crdnum == "2")
            {
                sp2 = plid;
            }
            else if (crdnum == "3")
            {
                sp3 = plid;
            }
            else if (crdnum == "4")
            {
                sp4 = plid;
            }
            else if (crdnum == "5")
            {
                sp5 = plid;
            }
            else if (crdnum == "6")
            {
                sp6 = plid;
            }
            else if (crdnum == "7")
            {
                sp7 = plid;
            }
            else if (crdnum == "8")
            {
                sp8 = plid;
            }
            else if (crdnum == "9")
            {
                sp9 = plid;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            getcrd(plid);
        }
    }
}
