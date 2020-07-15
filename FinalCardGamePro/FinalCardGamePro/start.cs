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
using System.Windows.Forms.VisualStyles;

namespace FinalCardGamePro
{
    public partial class start : Form
    {
         SoundPlayer sp2 = new SoundPlayer("Fluffing a Duck - Vanoss Gaming Background Music (HD) (online-audio-converter.com).wav");
        SoundPlayer sp1 = new SoundPlayer("mix_1m52s (audio-joiner.com).wav");

        public bool playmusic;//biến bật tắt âm
        public start()
        {
            InitializeComponent();
        }

        public start(bool playmusic)
        {
            InitializeComponent();
            this.playmusic = playmusic;

        }
        private void bt_cance_Click(object sender, EventArgs e)
        {
            this.Close();
            sp2.Stop();
        }

        private void start_Load(object sender, EventArgs e)
        {

            if (this.playmusic == true)
            {
                sp2.Play();
            }
            comboBox1.SelectedIndex = 0;// set default value
         
       }

       
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter  your nickname .....")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                
                textBox1.Text = "Enter  your nickname .....";
                textBox1.ForeColor = Color.Silver;
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox1.Text == "Enter  your nickname ....." || textBox1.Text.Length > 16)
            {
                DialogResult dialogResult = MessageBox.Show("Nickname không được để trống và nhỏ hơn 16 kí tự", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }   
            else
            {

                //nếu nhập đúng rồi thì hỏi sẵn sàng chưa
                if (MessageBox.Show("Are you ready?...", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if(playmusic == true)
                    {
                        sp1.PlayLooping();
                    }    
                    if (comboBox1.SelectedIndex == 0)
                    {
                        CardGame g1 = new CardGame(textBox1.Text, playmusic, comboBox1.Text);
                        this.Hide();

                        g1.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        Form2 g2 = new Form2(textBox1.Text, playmusic, comboBox1.Text);
                        this.Hide();
                        g2.ShowDialog();
                        this.Show();

                    }
                }                
            }    
        }
    }
}
