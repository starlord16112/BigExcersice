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
using System.Data.SqlClient;

namespace FinalCardGamePro
{
    public partial class CardGame : Form
    {

        //khởi tạo mảng 2 chiều gồm các đối tượng card
      //  Card flipCard;

        int countFlipCard = 0;//xem lật đủ 2 card chưa
        int numberOfCard = 8;//lưu số thẻ chưa lật
        string timePlay;
        Random random = new Random();
        Card[,] cardlist = new Card[4, 4];
        SoundPlayer sp = new SoundPlayer("mix_1m20s (audio-joiner.com).wav");
        SoundPlayer sp1 = new SoundPlayer("mix_1m52s (audio-joiner.com).wav");
       
        string name;//lưu tên người chơi
        bool playmusic;
        string option;

        SqlConnection conn = new SqlConnection("Data Source = DESKTOP-NGS7NIL;Initial Catalog = FlipCardGame;User ID=sa;Password=123456");


        public CardGame()
        {
            InitializeComponent();



        }
        public CardGame(string name,bool playmusic,string option)
        {
            InitializeComponent();
            this.name = name;
            this.playmusic = playmusic;
            this.option = option;



        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
           
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

            int m = 0, n = 0;
            foreach (Label item in tableLayoutPanel1.Controls)

            {
                item.BackColor = Color.Black;
                n++;
                if (n == 4)
                {
                    m++;
                    n = 0;
                    if (m == 4) break;

                }

            }
       
            
            timer2.Start();
           
            

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
                    numberOfCard--;
                    if(numberOfCard == 0)
                    {
                        timer2.Stop();
                        if (MessageBox.Show("Finish! You win\nYour time: "+ label17.Text + "m" + label18.Text + "s", "System", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand("insert into Easy values(@name,@time,@timeint)",conn);
                            cmd.Parameters.Add("@name", this.name);
                            cmd.Parameters.Add("@time", label17.Text + "m" + label18.Text + "s");
                            cmd.Parameters.Add("@timeint", Convert.ToInt32(label17.Text) * 60 + Convert.ToInt32(label18.Text));
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            

                        }    

                    }   
                     
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
         /*   if(numberOfCard == 0)
            {
                this.Close();
            }    
                this.Enabled = false;
                timer2.Stop();
                if (MessageBox.Show("Are you sure?...", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.Close();

                }
                timer2.Start();
                this.Enabled = true;*/
            
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (playmusic == true)
            {
                playmusic = false;
                
                sp1.Stop();

            }
            else
            {
                playmusic = true;
                sp.PlayLooping();
            }
        }

        private void CardGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer2.Stop();
            this.Enabled = false;

            DialogResult dialogResult = MessageBox.Show("Exit game", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult != DialogResult.Yes)
            {
                e.Cancel = true;
                timer2.Start();
                this.Enabled = true;
            }
        }



        /*private void label19_Click(object sender, EventArgs e)
        {

        }*/


    }
}
