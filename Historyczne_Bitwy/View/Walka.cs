namespace Historyczne_Bitwy.View
{
    public class Walka
    {
        public GameCard FightWinner;
        public GameCard FightLoser;
        public void Zmiana(GameCard nowy, GameCard stary)
        {
            nowy.Picture.Image = stary.Picture.Image;
            stary.Picture.Enabled = false;
            stary.Picture.Image = Properties.Resources.substytut;
           
        } 
    }
}
