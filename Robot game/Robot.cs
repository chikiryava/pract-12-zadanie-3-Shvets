using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robot_game
{
    internal class Robot
    {
        private int hp;

        public bool SetHp(string userhp,string robotnumber)
        {

            if (!int.TryParse(userhp, out var num))
            {
                MessageBox.Show($"Вы ввели не число в графе здоровье у робота номер {robotnumber}");
                return false;
            }
            else
            {
                int health = int.Parse(userhp);
                if (health <= 0)
                {
                    MessageBox.Show($"Здоровье не может быть меньше нуля у робота номер {robotnumber}");
                    return false;
                }
                else
                {
                    hp = health;
                    return true;

                }

            }                              
        }

        public string NewHp()
        {
            int newhealth = hp / 2;
            return newhealth.ToString();
        }
    }
}
