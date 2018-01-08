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
                    
                    picture1.Picture.Image = Properties.Resources.mieszko;
                    picture2.Picture.Image = Properties.Resources.dobrawa;
                    picture3.Picture.Image = Properties.Resources.zolnierz;
                    picture4.Picture.Image = Properties.Resources.zolnierz;
                    picture5.Picture.Image = Properties.Resources.zolnierz;
                    picture6.Picture.Image = Properties.Resources.wojak;
                    picture7.Picture.Image = Properties.Resources.wojak;
                    picture8.Picture.Image = Properties.Resources.pole;
                    picture9.Picture.Image = Properties.Resources.pole;
                    info.Image = Properties.Resources.info1;
                    nazwa.Image = Properties.Resources.nazwa1;

                    picture1.CombatValue = 4;
                    picture2.CombatValue = 3;
                    picture3.CombatValue = 2;
                    picture4.CombatValue = 2;
                    picture5.CombatValue = 1; // tylko ze ja to musze jakos najlepiej wpierdolic teraz do Walka.Zmiana() zeby to sie wtedy odbywalo 
                    picture6.CombatValue = 1; // a najgorsze jest to ze nie potrafie porozumiewac sie miedzy klasami, z klasy do maina wrzuce, ale nie w druga strone 
                    picture7.CombatValue = 1;

                    picture1.Picture.Enabled = true;
                    picture2.Picture.Enabled = true;
                    picture3.Picture.Enabled = true;
                    picture4.Picture.Enabled = true;
                    picture5.Picture.Enabled = true;
                    picture6.Picture.Enabled = true;
                    picture7.Picture.Enabled = true;
                    break;
                case 2:
                    picture1.Picture.Image = Properties.Resources.lokietek;
                    picture2.Picture.Image = Properties.Resources.kazimierz;
                    picture3.Picture.Image = Properties.Resources.rycerz;
                    picture4.Picture.Image = Properties.Resources.zolnierz;
                    picture5.Picture.Image = Properties.Resources.zolnierz;
                    picture6.Picture.Image = Properties.Resources.wojak;
                    picture7.Picture.Image = Properties.Resources.wojak;
                    picture8.Picture.Image = Properties.Resources.pole;
                    picture9.Picture.Image = Properties.Resources.pole;
                    info.Image = Properties.Resources.info2;
                    nazwa.Image = Properties.Resources.nazwa2;

                    picture1.CombatValue = 5;
                    picture2.CombatValue = 4;
                    picture3.CombatValue = 3;
                    picture4.CombatValue = 2;
                    picture5.CombatValue = 2;
                    picture6.CombatValue = 1;
                    picture7.CombatValue = 1;

                    picture1.Picture.Enabled = true;
                    picture2.Picture.Enabled = true;
                    picture3.Picture.Enabled = true;
                    picture4.Picture.Enabled = true;
                    picture5.Picture.Enabled = true;
                    picture6.Picture.Enabled = true;
                    picture7.Picture.Enabled = true;
                    break;
                case 3:
                    picture1.Picture.Image = Properties.Resources.jagiello;
                    picture2.Picture.Image = Properties.Resources.witold;
                    picture3.Picture.Image = Properties.Resources.rycerz;
                    picture4.Picture.Image = Properties.Resources.rycerz;
                    picture5.Picture.Image = Properties.Resources.zolnierz;
                    picture6.Picture.Image = Properties.Resources.wojak;
                    picture7.Picture.Image = Properties.Resources.wojak;
                    picture8.Picture.Image = Properties.Resources.pole;
                    picture9.Picture.Image = Properties.Resources.pole;
                    info.Image = Properties.Resources.info3;
                    nazwa.Image = Properties.Resources.nazwa3;

                    picture1.CombatValue = 5;
                    picture2.CombatValue = 4;
                    picture3.CombatValue = 3;
                    picture4.CombatValue = 3;
                    picture5.CombatValue = 2;
                    picture6.CombatValue = 1;
                    picture7.CombatValue = 1;

                    picture1.Picture.Enabled = true;
                    picture2.Picture.Enabled = true;
                    picture3.Picture.Enabled = true;
                    picture4.Picture.Enabled = true;
                    picture5.Picture.Enabled = true;
                    picture6.Picture.Enabled = true;
                    picture7.Picture.Enabled = true;
                    break;
                case 4:
                    picture1.Picture.Image = Properties.Resources.jagiellonczyk;
                    picture2.Picture.Image = Properties.Resources.dunin;
                    picture3.Picture.Image = Properties.Resources.husarz;
                    picture4.Picture.Image = Properties.Resources.rycerz;
                    picture5.Picture.Image = Properties.Resources.zolnierz;
                    picture6.Picture.Image = Properties.Resources.wojak;
                    picture7.Picture.Image = Properties.Resources.wojak;
                    picture8.Picture.Image = Properties.Resources.pole;
                    picture9.Picture.Image = Properties.Resources.pole;
                    info.Image = Properties.Resources.info4;
                    nazwa.Image = Properties.Resources.nazwa4;

                    picture1.CombatValue = 6;
                    picture2.CombatValue = 5;
                    picture3.CombatValue = 4;
                    picture4.CombatValue = 3;
                    picture5.CombatValue = 2;
                    picture6.CombatValue = 1;
                    picture7.CombatValue = 1;

                    picture1.Picture.Enabled = true;
                    picture2.Picture.Enabled = true;
                    picture3.Picture.Enabled = true;
                    picture4.Picture.Enabled = true;
                    picture5.Picture.Enabled = true;
                    picture6.Picture.Enabled = true;
                    picture7.Picture.Enabled = true;
                    break;
                case 5:
                    picture1.Picture.Image = Properties.Resources.zygmunt;
                    picture2.Picture.Image = Properties.Resources.ostrogski;
                    picture3.Picture.Image = Properties.Resources.husarz;
                    picture4.Picture.Image = Properties.Resources.husarz;
                    picture5.Picture.Image = Properties.Resources.rycerz;
                    picture6.Picture.Image = Properties.Resources.zolnierz;
                    picture7.Picture.Image = Properties.Resources.wojak;
                    picture8.Picture.Image = Properties.Resources.pole;
                    picture9.Picture.Image = Properties.Resources.pole;
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

                    picture1.Picture.Enabled = true;
                    picture2.Picture.Enabled = true;
                    picture3.Picture.Enabled = true;
                    picture4.Picture.Enabled = true;
                    picture5.Picture.Enabled = true;
                    picture6.Picture.Enabled = true;
                    picture7.Picture.Enabled = true;
                    break;
                
                default:
                    break;

            }
            
        }
    }
}
