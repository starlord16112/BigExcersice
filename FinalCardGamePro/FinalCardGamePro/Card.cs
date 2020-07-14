using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCardGamePro
{
    class Card
    {
        public Card()
        {

        }
        public int indexcolor;
        
        public string Color;
        
        public Card(int i)
        {
            if (i == 0)
            {
                Color = "Red";
            }
            else if (i == 1)
            {
                Color = "Green";
            }
            else if(i == 2)
                Color = "Blue";
            else if (i == 3)
                Color = "Yellow";
            else if (i == 4)
                Color = "DarkViolet";
            else if (i == 5)
                Color = "Cyan";
            else if (i == 6)
                Color = "DeepPink";
            else 
                 Color = "Gray";
                
        }
        
    }
}
