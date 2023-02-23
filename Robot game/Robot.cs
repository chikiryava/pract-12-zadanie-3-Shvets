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
        
        public string[] HealOtherRobots(string donor,string robot,string anotherrobot,int buttonnumber)
        {
            string[] myarray = new string[3];
            if (int.TryParse(donor, out var n) && int.TryParse(anotherrobot, out var r) && int.TryParse(robot, out var c))
            {
                double donorhp = double.Parse(donor);
                double robothp = double.Parse(robot);
                double anotherrobothp = double.Parse(anotherrobot);
                if (buttonnumber == 1)
                {
                    donor = (donorhp / 2).ToString();
                    robot = (robothp + 30).ToString();
                    anotherrobot = (anotherrobothp + 30).ToString();
                    myarray[0] = donor;
                    myarray[1] = robot;
                    myarray[2] = anotherrobot;
                    return myarray;

                }
                else
                {
                    donor = (donorhp *0.7).ToString();
                    robot = (robothp + 20).ToString();
                    anotherrobot = (anotherrobothp + 20).ToString();
                    myarray[0] = donor;
                    myarray[1] = robot;
                    myarray[2] = anotherrobot;
                    return myarray;
                }
            }
            else
            {
                MessageBox.Show("Вы ввели не число в графе здоровья у робота");
                return myarray;
            }

        }
    }
}
