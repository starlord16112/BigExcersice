using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCardGamePro
{
    class card1
    {
        public string path;
        public int pathRandom;
        public card1()
        {

        }
        public card1(int i)
        {
            pathRandom = i;

            if (i == 0)
            { 
                path = "G:\\visual_studio_2019\\C#\\FinalCardGamePro\\FinalCardGamePro\\bin\\Debug\\poseidon.png";

            }    
            else if (i == 1)

            {


                path = "G:\\visual_studio_2019\\C#\\FinalCardGamePro\\FinalCardGamePro\\bin\\Debug\\10.png";

                }
            else if (i == 2)
            {


                path = "G:\\visual_studio_2019\\C#\\FinalCardGamePro\\FinalCardGamePro\\bin\\Debug\\wonder.png";

            }
            else if (i == 3)
            {
                path = "G:\\visual_studio_2019\\C#\\FinalCardGamePro\\FinalCardGamePro\\bin\\Debug\\12.png";

            }
            else if (i == 4)
            {
                path = "G:\\visual_studio_2019\\C#\\FinalCardGamePro\\FinalCardGamePro\\bin\\Debug\\13.png";

            }
            else if (i == 5)
            {
                path = "G:\\visual_studio_2019\\C#\\FinalCardGamePro\\FinalCardGamePro\\bin\\Debug\\14.png";

            }
            else if (i == 6)
            {
                path = "G:\\visual_studio_2019\\C#\\FinalCardGamePro\\FinalCardGamePro\\bin\\Debug\\15.png";

            }
            else if (i == 7)
            {
                path = "G:\\visual_studio_2019\\C#\\FinalCardGamePro\\FinalCardGamePro\\bin\\Debug\\batman.png";

            }
            else if (i == 8)
            {
                path = "G:\\visual_studio_2019\\C#\\FinalCardGamePro\\FinalCardGamePro\\bin\\Debug\\superman.png";

            }

            else if (i == 9)
            {
                path = "G:\\visual_studio_2019\\C#\\FinalCardGamePro\\FinalCardGamePro\\bin\\Debug\\magneto.png";

            }
            else if (i == 10)
            {
                path = "G:\\visual_studio_2019\\C#\\FinalCardGamePro\\FinalCardGamePro\\bin\\Debug\\flash.png";

            }
            else if (i == 11)
            {
                path = "G:\\visual_studio_2019\\C#\\FinalCardGamePro\\FinalCardGamePro\\bin\\Debug\\naruto.png";

            }
            else if (i == 12)
            {
                path = "G:\\visual_studio_2019\\C#\\FinalCardGamePro\\FinalCardGamePro\\bin\\Debug\\cyclop.png";

            }
            else if (i == 13)
            {
                path = "G:\\visual_studio_2019\\C#\\FinalCardGamePro\\FinalCardGamePro\\bin\\Debug\\ironman.png";

            }
            else 
            {
                path = "G:\\visual_studio_2019\\C#\\FinalCardGamePro\\FinalCardGamePro\\bin\\Debug\\spiderman.png";

            }



        }
    }
}
