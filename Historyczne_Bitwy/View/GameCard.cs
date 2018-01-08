using System.Windows.Forms;

namespace Historyczne_Bitwy.View
{
    public class GameCard
    {

        public GameCard() {
            Picture = new CardGraphics(this);
        }
        public int CombatValue { get; set; } 

        public CardGraphics Picture { get; private set; }
    }

    public class CardGraphics : PictureBox {
        public CardGraphics(GameCard owner) {
            Owner = owner;
        }
        public GameCard Owner { get; }
    }
}
