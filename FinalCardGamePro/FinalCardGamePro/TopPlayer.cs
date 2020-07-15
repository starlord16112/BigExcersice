using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalCardGamePro
{
    public partial class TopPlayer : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = DESKTOP-NGS7NIL;Initial Catalog = FlipCardGame;User ID=sa;Password=123456");
        public TopPlayer()
        {
            InitializeComponent();
        }

        private void TopPlayer_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("select NickName,Time from Easy order by timeInt asc", conn);
            DataTable dataTable1 = new DataTable();
            sda1.Fill(dataTable1);
            dataGridView1.DataSource = dataTable1;

            SqlDataAdapter sda2 = new SqlDataAdapter("select NickName,Time from Normal order by timeInt asc", conn);
            DataTable dataTable2 = new DataTable();
            sda2.Fill(dataTable2);
            dataGridView2.DataSource = dataTable2;

            conn.Close();
        }
    }
}
