using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Historyczne_Bitwy.View
{
    public class LvlChange
    {

        

        public void Change(GameCard picture1, GameCard picture2, GameCard picture3, GameCard picture4,
            GameCard picture5, GameCard picture6, GameCard picture7, GameCard picture8, GameCard picture9, int poziom, PictureBox info, PictureBox nazwa, Button button)
        {
            switch (poziom)
            {
                case 1:
                    picture1.Image = Properties.Resources.mieszko;
                    picture2.Image = Properties.Resources.dobrawa;
                    picture3.Image = Properties.Resources.zolnierz;
                    picture4.Image = Properties.Resources.zolnierz;
                    picture5.Image = Properties.Resources.zolnierz;
                    picture6.Image = Properties.Resources.wojak;
                    picture7.Image = Properties.Resources.wojak;
                    picture8.Image = Properties.Resources.pole;
                    picture9.Image = Properties.Resources.pole;
                    info.Image = Properties.Resources.info1;
                    nazwa.Image = Properties.Resources.nazwa1;

                    picture1.CombatValue = 4;
                    picture2.CombatValue = 3;
                    picture3.CombatValue = 2;
                    picture4.CombatValue = 2;
                    picture5.CombatValue = 1; // tylko ze ja to musze jakos najlepiej wpierdolic teraz do Walka.Zmiana() zeby to sie wtedy odbywalo 
                    picture6.CombatValue = 1; // a najgorsze jest to ze nie potrafie porozumiewac sie miedzy klasami, z klasy do maina wrzuce, ale nie w druga strone 
                    picture7.CombatValue = 1;

                    picture1.Enabled = true;
                    picture2.Enabled = true;
                    picture3.Enabled = true;
                    picture4.Enabled = true;
                    picture5.Enabled = true;
                    picture6.Enabled = true;
                    picture7.Enabled = true;
                    break;
                case 2:
                    picture1.Image = Properties.Resources.lokietek;
                    picture2.Image = Properties.Resources.kazimierz;
                    picture3.Image = Properties.Resources.rycerz;
                    picture4.Image = Properties.Resources.zolnierz;
                    picture5.Image = Properties.Resources.zolnierz;
                    picture6.Image = Properties.Resources.wojak;
                    picture7.Image = Properties.Resources.wojak;
                    picture8.Image = Properties.Resources.pole;
                    picture9.Image = Properties.Resources.pole;
                    info.Image = Properties.Resources.info2;
                    nazwa.Image = Properties.Resources.nazwa2;

                    picture1.CombatValue = 5;
                    picture2.CombatValue = 4;
                    picture3.CombatValue = 3;
                    picture4.CombatValue = 2;
                    picture5.CombatValue = 2;
                    picture6.CombatValue = 1;
                    picture7.CombatValue = 1;

                    picture1.Enabled = true;
                    picture2.Enabled = true;
                    picture3.Enabled = true;
                    picture4.Enabled = true;
                    picture5.Enabled = true;
                    picture6.Enabled = true;
                    picture7.Enabled = true;
                    break;
                case 3:
                    picture1.Image = Properties.Resources.jagiello;
                    picture2.Image = Properties.Resources.witold;
                    picture3.Image = Properties.Resources.rycerz;
                    picture4.Image = Properties.Resources.rycerz;
                    picture5.Image = Properties.Resources.zolnierz;
                    picture6.Image = Properties.Resources.wojak;
                    picture7.Image = Properties.Resources.wojak;
                    picture8.Image = Properties.Resources.pole;
                    picture9.Image = Properties.Resources.pole;
                    info.Image = Properties.Resources.info3;
                    nazwa.Image = Properties.Resources.nazwa3;

                    picture1.CombatValue = 5;
                    picture2.CombatValue = 4;
                    picture3.CombatValue = 3;
                    picture4.CombatValue = 3;
                    picture5.CombatValue = 2;
                    picture6.CombatValue = 1;
                    picture7.CombatValue = 1;

                    picture1.Enabled = true;
                    picture2.Enabled = true;
                    picture3.Enabled = true;
                    picture4.Enabled = true;
                    picture5.Enabled = true;
                    picture6.Enabled = true;
                    picture7.Enabled = true;
                    break;
                case 4:
                    picture1.Image = Properties.Resources.jagiellonczyk;
                    picture2.Image = Properties.Resources.dunin;
                    picture3.Image = Properties.Resources.husarz;
                    picture4.Image = Properties.Resources.rycerz;
                    picture5.Image = Properties.Resources.zolnierz;
                    picture6.Image = Properties.Resources.wojak;
                    picture7.Image = Properties.Resources.wojak;
                    picture8.Image = Properties.Resources.pole;
                    picture9.Image = Properties.Resources.pole;
                    info.Image = Properties.Resources.info4;
                    nazwa.Image = Properties.Resources.nazwa4;

                    picture1.CombatValue = 6;
                    picture2.CombatValue = 5;
                    picture3.CombatValue = 4;
                    picture4.CombatValue = 3;
                    picture5.CombatValue = 2;
                    picture6.CombatValue = 1;
                    picture7.CombatValue = 1;

                    picture1.Enabled = true;
                    picture2.Enabled = true;
                    picture3.Enabled = true;
                    picture4.Enabled = true;
                    picture5.Enabled = true;
                    picture6.Enabled = true;
                    picture7.Enabled = true;
                    break;
                case 5:
                    picture1.Image = Properties.Resources.zygmunt;
                    picture2.Image = Properties.Resources.ostrogski;
                    picture3.Image = Properties.Resources.husarz;
                    picture4.Image = Properties.Resources.husarz;
                    picture5.Image = Properties.Resources.rycerz;
                    picture6.Image = Properties.Resources.zolnierz;
                    picture7.Image = Properties.Resources.wojak;
                    picture8.Image = Properties.Resources.pole;
                    picture9.Image = Properties.Resources.pole;
                    info.Image = Properties.Resources.info5;
                    nazwa.Image = Properties.Resources.nazwa5;
                    button.Image = Properties.Resources.button_koniecgry;

                    picture1.CombatValue = 6;
                    picture2.CombatValue = 5;
                    picture3.CombatValue = 4;
                    picture4.CombatValue = 4;
                    picture5.CombatValue = 3;
                    picture6.CombatValue = 2;
                    picture7.CombatValue = 1;

                    picture1.Enabled = true;
                    picture2.Enabled = true;
                    picture3.Enabled = true;
                    picture4.Enabled = true;
                    picture5.Enabled = true;
                    picture6.Enabled = true;
                    picture7.Enabled = true;
                    break;
                
                default:
                    break;

            }
            
        }
    }
}
