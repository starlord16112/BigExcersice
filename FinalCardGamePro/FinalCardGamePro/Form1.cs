using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Windows.Forms.VisualStyles;

namespace FinalCardGamePro
{
    public partial class CardGame : Form
    {

        //khởi tạo mảng 2 chiều gồm các đối tượng card
        Card flipCard;

        int countFlipCard = 0;//xem lật đủ 2 card chưa
        int numberOfCard = 8;//lưu số thẻ chưa lật

        Random random = new Random();
        Card[,] cardlist = new Card[4, 4];
        SoundPlayer sp = new SoundPlayer("Fluffing a Duck - Vanoss Gaming Background Music (HD) (online-audio-converter.com).wav");
        int countdown = 3;





        public CardGame()
        {
            InitializeComponent();



        }
        /*Label ilabel = new Label(); // create a label
Image i = Image.FromFile("image.png"); // read in image
ilabel.Size = new Size(i.Width, i.Height); //set label to correct size
ilabel.Image = i; // put image on label
this.Controls.Add(ilabel); // add label to container (a form, for instance)*/
        /*  private void card1_Click(object sender, EventArgs e)
         *  protected void btn_Click (object sender, EventArgs e){
     Button btn = sender as Button;
     btn.Text = "clicked!";
  }
          {

          }*/

        private void Form1_Load(object sender, EventArgs e)
        {
          /*  while (countdown > 0)
            {
                timer3.Start();
            }*/
           

            



                //  sp.Play();
                //khi form load xong thì random các thẻ 
                //  Random random = new Random();
                int[,] arr = new int[4, 4];
                List<int> mlist = new List<int>(16);
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {

                        while (true)
                        {
                            arr[i, j] = random.Next(maxValue: 8);
                            cardlist[i, j] = new Card(arr[i, j]);
                            mlist.Add(arr[i, j]);
                            int count = 0;
                            foreach (int item in mlist)
                            {
                                if (item == arr[i, j])
                                    count++;
                            }
                            if (count <= 2)
                            {
                                break;
                            }

                        }

                    }
                }
                /*for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(arr[i, j] + "  ");

                    }
                    Console.WriteLine();
                }*/
                int m = 0, n = 0;
                foreach (Label item in tableLayoutPanel1.Controls)

                {
                    item.BackColor = Color.Black;

                    /*  if (cardlist[m, n].Color == "Red")
                               item.BackColor = Color.Red;
                           else if (cardlist[m, n].Color == "Green")
                               item.BackColor = Color.Green;
                           else if (cardlist[m, n].Color == "Blue")
                               item.BackColor = Color.Blue;
                           else if (cardlist[m, n].Color == "Yellow")
                               item.BackColor = Color.Yellow;
                           else if (cardlist[m, n].Color == "DarkViolet")
                               item.BackColor = Color.DarkViolet;
                           else if (cardlist[m, n].Color == "Cyan")
                               item.BackColor = Color.Cyan;
                           else if (cardlist[m, n].Color == "DeepPink")
                               item.BackColor = Color.DeepPink;
                           else 
                               item.BackColor = Color.Gray;*/

                    timer2.Start();







                    n++;
                    if (n == 4)
                    {
                        m++;
                        n = 0;
                        if (m == 4) break;

                    }

                }
            }
        
        Label clicklabel1;
        Label clicklabel2;
        bool kt = true;


        private void lb_click(object sender, EventArgs e)

        {


            if (kt)
           {


                try
                {
                     

                    Label lb = sender as Label;
                    if (clicklabel1 == null)
                    {
                        clicklabel1 = lb;


                    }
                    else if (lb.Text != clicklabel1.Text)

                    {

                        clicklabel2 = lb;
                        kt = false;


                    }
                    string s = cardlist[Convert.ToInt32(lb.Text[0].ToString()), Convert.ToInt32(lb.Text[1].ToString())].Color;

                    lb.BackColor = Color.FromName(s);
                    lb.ForeColor = Color.FromName(s);
                    if (clicklabel1 != null && clicklabel2 != null && clicklabel1.Text != clicklabel2.Text)
                    {
                        timer1.Start();
                    }





                }
                catch (Exception)
                { }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            try
            {
                if (clicklabel1.BackColor == clicklabel2.BackColor && clicklabel1.Text != clicklabel2.Text)
                {
                    clicklabel1.Visible = false;
                    clicklabel2.Visible = false;
                    clicklabel1 = null;
                    clicklabel2 = null;
                }

                else
                {
                    clicklabel1.BackColor = Color.Black;
                    clicklabel2.BackColor = Color.Black;
                    clicklabel1.ForeColor = Color.Black;
                    clicklabel2.ForeColor = Color.Black;
                    clicklabel1 = null;
                    clicklabel2 = null;

                }
                kt = true;
                timer1.Stop();

            }
            catch (Exception)
            {

            }

        }
      
        int time = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(label17.Text);
            int b = Convert.ToInt32(label18.Text);
            b++;
            if(b > 59)
            {
                a++;
                b = 0;
            }    
            if(b < 10)
            {
                label18.Text = "0" + b;

            }  
            else
            {
                label18.Text = "" + b;
            }  
            if(a > 10)
            {
                label17.Text = "" + a;
            }    
          else
            {
                label17.Text = "0" + a;
            }    
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            
              /* timer3.Stop();
            
            MessageBox.Show("" + countdown--);*/
                 }

        /*private void label19_Click(object sender, EventArgs e)
        {

        }*/


    }
}
