using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRoullete_Manav
{
    public class AllFunctionClass
    {
        public int bulletManav;
        public int[] gunManav = new int[6] { 0, 1, 2, 3, 4, 5 };
        public int shootAwayChancesManav = 2;
        public int pointManav = 0;
        public bool dieManav = false;


        //load function will load the bullet in gun
        public void Load()
        {
            bulletManav = 0;
        }

        //spin function used to spin chambers
        public int Spin()
        {
            Random rand = new Random();  // Random  is used to make bullet in a random position not in a static position
            bulletManav = rand.Next(0, 6);
            return bulletManav;
        }



        public void ShootAtHead()
        {

            if (bulletManav == 5)
            {
                dieManav = true;
                MessageBox.Show("You Are Dead And You Lost the game");
                pointManav = pointManav - 10; // Game Points will be deducted whenever person will die
            }


            else
            {
                MessageBox.Show("Lucky you, you can keep playing!");
                bulletManav++;
            }


        }

        public void ShootAway()
        {
            if (bulletManav == 5)
            {
                MessageBox.Show("You Survived and You Won The Game");
                pointManav = pointManav + 10; // Game Points will be added whenever person will survive
            }
            else
            {
                if (shootAwayChancesManav == 1)
                {
                    dieManav = true;
                    MessageBox.Show("You lost all the chances and you will definitely die");
                    pointManav = pointManav - 5;
                }
                else
                {
                    dieManav = false;
                    MessageBox.Show("You missed one of your chances");
                    bulletManav++;
                    shootAwayChancesManav--;
                }
            }

        }
    }
}
