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


namespace FinalCardGamePro
{
    public partial class welcome : Form
    {
        public bool playMusic;//biến kiểm tra để tắt hoặc bật âm thanh
        //khởi tạo đối tượng để sử dụng âm thanh
       
        SoundPlayer sp1 = new SoundPlayer("mix_05s (audio-joiner.com).wav");
        public SoundPlayer sp2 = new SoundPlayer("Fluffing a Duck - Vanoss Gaming Background Music (HD) (online-audio-converter.com).wav");
        
         

        public welcome()
        {
            InitializeComponent();
        }

        private void welcome_Load(object sender, EventArgs e)
        {
            //auto play music
            try
            {
                sp1.Play();
            }
            catch(Exception)
            {

            }
            playMusic = true;


           
        }



        

        private void button_speak_Click(object sender, EventArgs e)
        {//bắt event nút speak
            sp1.Play();
            playMusic = true;

        }

        private void bt_mute_Click(object sender, EventArgs e)
        {//bắt event nút mute
            sp1.Stop();
            playMusic = false;
        }
        
        private void bt_go_Click(object sender, EventArgs e)
        {
            //bắt event nút go(hiển thị ra form điền thông tin trước khi bắt đầu
            this.Hide();
            sp1.Stop();
            start st = new start(playMusic);//truyền biến để check bật âm thanh
            st.ShowDialog();
            this.Show();


            
        }

        private void welcome_FormClosing(object sender, FormClosingEventArgs e)
        {
            //khi người dùng thoát thì sẽ hiển thị ra thông báo
            DialogResult dialogResult = MessageBox.Show("Exit game", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult != DialogResult.Yes)
            {
                e.Cancel = true;
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //event button exit
            Application.Exit();
        }

        private void bt_top_Click(object sender, EventArgs e)
        {
            this.Hide();
            TopPlayer t = new TopPlayer();
            t.ShowDialog();
            this.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            about ab = new about();
            ab.ShowDialog();
            this.Show();
        }

        /*private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }*/
    }
}
