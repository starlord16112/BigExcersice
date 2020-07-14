using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalCardGamePro
{
    public partial class Form2 : Form
    {
        
        
        Random random = new Random();
        card1[,] cardlist = new card1[5, 6];
        int[,] arr = new int[5, 6];
        List<int> mlist = new List<int>(30);

        public Form2()
        {
            InitializeComponent();
            /*listLocationImage.Add("G:\visual_studio_2019\\C#\\FinalCardGamePro\\FinalCardGamePro\\bin\\Debug\\batman.png");
            listLocationImage.Add("G:\visual_studio_2019\\C#\\FinalCardGamePro\\FinalCardGamePro\\bin\\Debug\\flash.png");
            listLocationImage.Add("G:\visual_studio_2019\\C#\\FinalCardGamePro\\FinalCardGamePro\\bin\\Debug\\naruto.png");
            listLocationImage.Add("G:\visual_studio_2019\\C#\\FinalCardGamePro\\FinalCardGamePro\\bin\\Debug\\spiderman.png");
            listLocationImage.Add("G:\visual_studio_2019\\C#\\FinalCardGamePro\\FinalCardGamePro\\bin\\Debug\\ironman   .png");
            listLocationImage.Add("G:\visual_studio_2019\\C#\\FinalCardGamePro\\FinalCardGamePro\\bin\\Debug\\magneto.png");
            listLocationImage.Add("G:\visual_studio_2019\\C#\\FinalCardGamePro\\FinalCardGamePro\\bin\\Debug\\cyclop.png");
            listLocationImage.Add("G:\visual_studio_2019\\C#\\FinalCardGamePro\\FinalCardGamePro\\bin\\Debug\\superman.png");
            listLocationImage.Add("G:\visual_studio_2019\\C#\\FinalCardGamePro\\FinalCardGamePro\\bin\\Debug\\9.png");
            listLocationImage.Add("G:\visual_studio_2019\\C#\\FinalCardGamePro\\FinalCardGamePro\\bin\\Debug\\10.png");
            listLocationImage.Add("G:\visual_studio_2019\\C#\\FinalCardGamePro\\FinalCardGamePro\\bin\\Debug\\11.png");
            listLocationImage.Add("G:\visual_studio_2019\\C#\\FinalCardGamePro\\FinalCardGamePro\\bin\\Debug\\12.png");
            listLocationImage.Add("G:\visual_studio_2019\\C#\\FinalCardGamePro\\FinalCardGamePro\\bin\\Debug\\13.png");
            listLocationImage.Add("G:\visual_studio_2019\\C#\\FinalCardGamePro\\FinalCardGamePro\\bin\\Debug\\14.png");
            listLocationImage.Add("G:\visual_studio_2019\\C#\\FinalCardGamePro\\FinalCardGamePro\\bin\\Debug\\15.png");*/

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
               /* item.ImageLocation = cardlist[row,col].path;
                item.SizeMode = PictureBoxSizeMode.StretchImage;*/
              
                col++;
                if (col == 6)
                {
                    row++;
                    col = 0;
                    if (row == 5) break;

                }

            }
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
    }
}
