using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Data.SqlClient;

namespace FinalCardGamePro
{
    public partial class Form2 : Form
    {

        int countFlipCard = 0;//xem lật đủ 2 card chưa
        int numberOfCard = 15;//lưu số thẻ chưa lật
        string timePlay;
        Random random = new Random();
       
        SoundPlayer sp = new SoundPlayer("mix_1m20s (audio-joiner.com).wav");
        SoundPlayer sp1 = new SoundPlayer("mix_1m52s (audio-joiner.com).wav");

        string name;//lưu tên người chơi
        bool playmusic;
        string option;

        SqlConnection conn = new SqlConnection("Data Source = DESKTOP-NGS7NIL;Initial Catalog = FlipCardGame;User ID=sa;Password=123456");



       
        card1[,] cardlist = new card1[5, 6];
        int[,] arr = new int[5, 6];
        List<int> mlist = new List<int>(30);

        public Form2()
        {
            InitializeComponent();
         }
        public Form2(string name, bool playmusic, string option)
        {
            InitializeComponent();
            this.name = name;
            this.playmusic = playmusic;
            this.option = option;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {

                    while (true)
                    {
                        arr[i, j] = random.Next(maxValue: 15);
                        cardlist[i, j] = new card1(arr[i, j]);
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

            int row = 0, col = 0;

            foreach (PictureBox item in tableLayoutPanel1.Controls)
            {
                item.BackColor = Color.DarkTurquoise;
                item.BorderStyle = BorderStyle.FixedSingle;
                /*item.ImageLocation = cardlist[row,col].path;
                item.SizeMode = PictureBoxSizeMode.StretchImage;*/
              
                col++;
                if (col == 6)
                {
                    row++;
                    col = 0;
                    if (row == 5) break;

                }

            }
            timer2.Start();
        }
        PictureBox pb1;
        PictureBox pb2;
        bool click = true;
        private void picturebox_click(object sender, EventArgs e)
        {
            if (click)
            {
                try
                {



                    PictureBox pb = sender as PictureBox;
                   /* pb.ImageLocation = cardlist[Convert.ToInt32(pb.Name[10].ToString()), Convert.ToInt32(pb.Name[11].ToString())].path;
                    pb.BackColor = Color.Transparent;//bỏ set màu nền
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;//set ảnh full picture box;*/
                    if (pb1 == null)
                    {
                       pb1 = pb;


                    }
                    else if (pb.Name != pb1.Name)

                    {

                        pb2 = pb;
                        click = false;


                    }
                    pb.ImageLocation = cardlist[Convert.ToInt32(pb.Name[10].ToString()), Convert.ToInt32(pb.Name[11].ToString())].path;
                    pb.BackColor = Color.Transparent;//bỏ set màu nền
                    pb.SizeMode = PictureBoxSizeMode.Zoom;//set ảnh full picture box;*/
                    if (pb1 != null && pb2 != null && pb1.Name != pb2.Name)
                    {
                        timer1.Start();
                    }

                }
                catch (Exception)
                {

                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (pb1.ImageLocation == pb2.ImageLocation && pb1.Name != pb2.Name)
                {
                    pb1.Visible = false;
                    pb2.Visible = false;
                    numberOfCard--;
                    if (numberOfCard == 0)
                    {
                        timer2.Stop();
                        if (MessageBox.Show("Finish! You win\nYour time: " + label17.Text + "m" + label18.Text + "s", "System", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand("insert into Normal values(@name,@time,@timeint)", conn);
                            cmd.Parameters.Add("@name", this.name);
                            cmd.Parameters.Add("@time", label17.Text + "m" + label18.Text + "s");
                            cmd.Parameters.Add("@timeint", Convert.ToInt32(label17.Text) * 60 + Convert.ToInt32(label18.Text));
                            cmd.ExecuteNonQuery();
                            conn.Close();


                        }

                    }
                    pb1 = null;
                    pb2 = null;
                }

                else
                {
                    pb1.BackColor = Color.DarkTurquoise;
                    pb1.ImageLocation = null;
                    pb2.BackColor = Color.DarkTurquoise;
                    pb2.ImageLocation = null;
                    /*clicklabel1.ForeColor = Color.Black;
                    clicklabel2.ForeColor = Color.Black;*/
                    pb1   = null;
                    pb2 = null;

                }
                click = true;
                timer1.Stop();

            }
            catch (Exception)
            {

            }
        }

      
      

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Enabled = false;
            timer2.Stop();
            DialogResult dialogResult = MessageBox.Show("Close this  game", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult != DialogResult.Yes)
            {
                timer2.Start();
                e.Cancel = true;
                this.Enabled = true;
            }
        }

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
            if(b< 10)
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
           /* if (numberOfCard == 0)
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
    }
}
