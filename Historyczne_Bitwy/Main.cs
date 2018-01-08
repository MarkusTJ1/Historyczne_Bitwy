using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Historyczne_Bitwy.Properties;
using Historyczne_Bitwy.View;

namespace Historyczne_Bitwy
{
    public partial class Main : Form
    {
        int counter;
        int _currentLevel = 1;

        public Main()
        {
            PrepareLevels();
            InitializeComponent();
            Gra.Hide();
            Poziomy.Hide();
            Pomoc.Hide();
            Menu.Show();
        }

        private void PrepareLevels()
        {
            Levels = new List<IList<Enemy>>
            {
                new List<Enemy>
                {
                    Enemy.ritter1,
                    Enemy.ritter1,
                    Enemy.ritter2,
                    Enemy.ritter2,
                    Enemy.ritter2,
                    Enemy.ritter1,
                    Enemy.hodo
                },
                new List<Enemy>
                {
                    Enemy.ritter1,
                    Enemy.ritter1,
                    Enemy.ritter2,
                    Enemy.ritter2,
                    Enemy.ritter3,
                    Enemy.ritter3,
                    Enemy.altenburg
                },
                new List<Enemy>
                {
                    Enemy.ritter1,
                    Enemy.ritter1,
                    Enemy.ritter2,
                    Enemy.ritter3,
                    Enemy.ritter3,
                    Enemy.ritter3,
                    Enemy.ulrich
                },
                new List<Enemy>
                {
                    Enemy.ritter1,
                    Enemy.ritter1,
                    Enemy.ritter2,
                    Enemy.ritter3,
                    Enemy.ritter4,
                    Enemy.ritter4,
                    Enemy.eryk2
                },
                new List<Enemy>
                {
                    Enemy.ritter1,
                    Enemy.ritter2,
                    Enemy.ritter3,
                    Enemy.ritter4,
                    Enemy.ritter4,
                    Enemy.ritter4,
                    Enemy.iwan
                }
            };
        }


        private void Menu_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Pomoc_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Gra_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Poziomy_Paint(object sender, PaintEventArgs e)
        {
        }

        private void MiniMenu_Paint(object sender, PaintEventArgs e)
        {
        }


        private void bstart_Click(object sender, EventArgs e)
        {
            _currentLevel = 1;
            Menu.Hide();
            Poziomy.Hide();
            Pomoc.Hide();
            Gra.Show();
            Informacje.Hide();
            NextLvl.Hide();
            TryAgain.Hide(); // czekaj nie tu
        }

        private void bpoziom_Click(object sender, EventArgs e)
        {
            Menu.Hide();
            Pomoc.Hide();
            Gra.Hide();
            Poziomy.Show();
        }

        private void bpomoc_Click(object sender, EventArgs e)
        {
            Menu.Hide();
            Gra.Hide();
            Poziomy.Hide();
            Pomoc.Show();
        }

        private void bquiz_Click(object sender, EventArgs e)
        {
        }

        private void bwyjscie_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void bcedynia_Click(object sender, EventArgs e)
        {
            var levelChange = new LvlChange();
            Menu.Hide();
            Poziomy.Hide();
            Pomoc.Hide();
            _currentLevel = 1;
            levelChange.Change(karta1, karta2, karta3, karta4, karta5, karta6, karta7, kartag, kartap, _currentLevel,
                Informacje, Nazwa, NextLvl);
            Gra.Show();
            Informacje.Hide();
            NextLvl.Hide();
            TryAgain.Hide();
            counter = 0;
        } // Robert czy masz na mysli zeby po prostu toReturn zmienic na kartap? zeby pobierala dane? 

        private void bplowce_Click(object sender, EventArgs e)
        {
            var levelChange = new LvlChange();
            Menu.Hide();
            Poziomy.Hide();
            Pomoc.Hide();
            _currentLevel = 2;
            levelChange.Change(karta1, karta2, karta3, karta4, karta5, karta6, karta7, kartag, kartap, _currentLevel,
                Informacje, Nazwa, NextLvl);
            Gra.Show();
            Informacje.Hide();
            NextLvl.Hide();
            TryAgain.Hide();
            counter = 0;
        }

        private void bgrunwald_Click(object sender, EventArgs e)
        {
            var levelChange = new LvlChange();
            Menu.Hide();
            Poziomy.Hide();
            Pomoc.Hide();
            _currentLevel = 3;
            levelChange.Change(karta1, karta2, karta3, karta4, karta5, karta6, karta7, kartag, kartap, _currentLevel,
                Informacje, Nazwa, NextLvl);
            Gra.Show();
            Informacje.Hide();
            NextLvl.Hide();
            TryAgain.Hide();
            counter = 0;
        }

        private void bswiecino_Click(object sender, EventArgs e)
        {
            var levelChange = new LvlChange();
            Menu.Hide();
            Poziomy.Hide();
            Pomoc.Hide();
            _currentLevel = 4;
            levelChange.Change(karta1, karta2, karta3, karta4, karta5, karta6, karta7, kartag, kartap, _currentLevel,
                Informacje, Nazwa, NextLvl);
            Gra.Show();
            Informacje.Hide();
            NextLvl.Hide();
            TryAgain.Hide();
            counter = 0;
        }

        private void borsza_Click(object sender, EventArgs e)
        {
            var levelChange = new LvlChange();
            Menu.Hide();
            Poziomy.Hide();
            Pomoc.Hide();
            _currentLevel = 5;
            levelChange.Change(karta1, karta2, karta3, karta4, karta5, karta6, karta7, kartag, kartap, _currentLevel,
                Informacje, Nazwa, NextLvl);
            Gra.Show();
            Informacje.Hide();
            NextLvl.Hide();
            TryAgain.Hide();
            counter = 0;
        }


        private void bcofnij_Click(object sender, EventArgs e)
        {
            Gra.Hide();
            Poziomy.Hide();
            Pomoc.Hide();
            Menu.Show();
        }


        private void karta_Click(object sender, EventArgs e)
        {
            var card = sender as GameCard;

            var walka = new Walka();
            var levelChange = new LvlChange(); // dobra, zjebalem ogolnie nie wiedzac jak to zrobic
            // bo tam gdzie mam buttony to rzeczywiscie karty zbieraja z picture z klasy LvlChange
            // ale tutaj tego nie mam, znaczy wiem ze to nie ma prawa dzialac, ale nie wiem jak to mozna zrobic zeby dzialalo 
            PrepareEnemyCardToFight(kartap); // to ja dodalem, ale nie dzialalo, wiec do wyebania jednak
                                             // nie, jednak nie wiem jak to zrobic 
                                             // co zrobic konkretnie opisz
                                             // zeby karta w mainie to bylo to samo co picture w lvlchange, bo wtedy by sie parametry zgadzaly
                                             // chyba ze na razie na sztywno w designerze ustawic te, na razie na sztywno, a przy kazdej zmianie levela beda sie, chodzi mi o pozycje startowa nazwijmy to
                                             //no to i tak wychodzi na to samo przeciez
            //i nie rozwiazuje problemu
            // Ludi pyta "jak tam Robert sprawko"
            // bo mnie tu obserwuje dwie strony na ile? tez masz czas do polnocy?
            walka.Zmiana(kartag, card); 
            counter++;
            var graczScore= 0;
      
            if (kartag.CombatValue >= kartap.CombatValue)
            {
                graczScore++;
            }

            if (graczScore >= 3 && counter == 7)//widzisz? hmm chyba nie nie tutuaj tylko czy w ogole. Pokaz w kodzie co myslisz ze powinno sie dziac
            {
                TryAgain.Hide();
                NextLvl.Show();
            }
            else if (graczScore < 3 && counter == 7)
            {
                NextLvl.Hide();
                TryAgain.Show();
            }



        }

        

        public IList<IList<Enemy>> Levels;


        private GameCard CreateEnemy(Enemy enemy)
        {
            var enemyPictures = new Dictionary<Enemy, Image>
            {
                {Enemy.ritter1, Resources.ritter1},
                {Enemy.ritter2, Resources.ritter2},
                {Enemy.ritter3, Resources.ritter3},
                {Enemy.ritter4, Resources.ritter4},
                {Enemy.hodo, Resources.hodo},
                {Enemy.altenburg, Resources.altenburg},
                {Enemy.ulrich, Resources.ulrich},
                {Enemy.eryk2, Resources.eryk2},
                {Enemy.iwan, Resources.iwan}
            };
            var enemyValues = new Dictionary<Enemy, int>
            {
                {Enemy.ritter1, 1},
                {Enemy.ritter2, 2},
                {Enemy.ritter3, 3},
                {Enemy.ritter4, 4},
                {Enemy.hodo, 4},
                {Enemy.altenburg, 5},
                {Enemy.ulrich, 5},
                {Enemy.eryk2, 6},
                {Enemy.iwan, 6}
            }; 
            var toReturn = new GameCard
            {
                Image = enemyPictures[enemy],
                CombatValue = enemyValues[enemy],
                Location = new Point(322, 428),
                Size = new Size(100, 140),
                Name = enemy.ToString()
            };


            return toReturn;
        }

        private void PrepareEnemyCardToFight(GameCard karta)
        {
            var rand = 7;
            var generator = new Random();
            var picked = generator.Next() % rand;
            var createdEnemy = CreateEnemy(Levels[_currentLevel][picked]); // jakis switch potrzebny? poco czy w liscie to idzie numerycznie? tzn pierwsza pozycja to 1, druwa 2 itp? bo teoretycznie powinno juz dzialac
            kartap.CombatValue = createdEnemy.CombatValue;
            kartap.Image = createdEnemy.Image;
            
        } // najs :D a teraz wystarczy ze sie odwolam czekaj gdzie ro bylo 

        private void MiniInfo_Click(object sender, EventArgs e)
        {
            Informacje.Show();
        }


        private void MiniReset_Click(object sender, EventArgs e)
        {
            var levelChange = new LvlChange();
            levelChange.Change(karta1, karta2, karta3, karta4, karta5, karta6, karta7, kartag, kartap, _currentLevel,
                Informacje, Nazwa, NextLvl);
            counter = 0;
            TryAgain.Hide();
            Gra.Refresh();
        }

        private void MiniWyjscie_Click(object sender, EventArgs e)
        {
            Gra.Hide();
            Menu.Show();
        }

        private void Informacje_Click(object sender, EventArgs e)
        {
            Informacje.Hide();
        }

        private void NextLvl_Click(object sender, EventArgs e)
        {
            var levelChange = new LvlChange();

            if (_currentLevel < 5)
            {
                _currentLevel++;
                levelChange.Change(karta1, karta2, karta3, karta4, karta5, karta6, karta7, kartag, kartap, _currentLevel,
                    Informacje, Nazwa, NextLvl);
                counter = 0;
                NextLvl.Hide();
            }
            else if (_currentLevel == 5)
            {
                Gra.Hide();
                Menu.Show();
                counter = 0;
            }
        }

        
    }

    public enum Enemy
    {
        ritter1,
        ritter2,
        ritter3,
        ritter4,
        hodo,
        altenburg,
        ulrich,
        eryk2,
        iwan
    }
}