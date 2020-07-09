using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame
{
    public partial class CardGame : Form
    {
        //khởi tạo mảng 2 chiều gồm các đối tượng card

        Random random = new Random();
        Card[,] cardlist = new Card[4, 4];
        
     

        
        public CardGame()
        {
            InitializeComponent();
           
        }

        private void card1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //khi form load xong thì random các thẻ 
            Random random = new Random();
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
            foreach(Label item in tableLayoutPanel1.Controls)
            {
                item.BackColor = Color.Pink;
              /*  if (cardlist[m, n].Color == "Red")
                    item.BackColor = Color.Red;
                else if (cardlist[m, n].Color == "Green")
                    item.BackColor = Color.Green;
                else if (cardlist[m, n].Color == "Blue")
                    item.BackColor = Color.Blue;
                else if (cardlist[m, n].Color == "Navy")
                    item.BackColor = Color.Navy;
                else if (cardlist[m, n].Color == "DarkViolet")
                    item.BackColor = Color.DarkViolet;
                else if (cardlist[m, n].Color == "Cyan")
                    item.BackColor = Color.Cyan;
                else if (cardlist[m, n].Color == "DeepPink")
                    item.BackColor = Color.DeepPink;
                else 
                    item.BackColor = Color.Gray;*/



                n++;
                if (n == 4)
                {
                    m++;
                    n = 0;
                    if (m == 4) break;

                }

            }    
        }
    }
}
