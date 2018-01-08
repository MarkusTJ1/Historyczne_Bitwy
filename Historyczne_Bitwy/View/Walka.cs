using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Historyczne_Bitwy.View
{
    public class Walka
    {
        public GameCard FightWinner;
        public GameCard FightLoser;
        public void Zmiana(GameCard nowy, GameCard stary)
        {
            nowy.Image = stary.Image;
            stary.Enabled = false;
            stary.Image = Properties.Resources.substytut;
           
        } 
    }
}
