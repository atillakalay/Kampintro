using System;
using System.Collections.Generic;
using System.Text;

namespace _5.DersOdevi
{
    class GameManager
    {
        public void GameSell(IPerson person,Game game)
        {
            Console.WriteLine(game.GameName +" adlı oyun "+person.FirsName+" kişisine satıldı . "+" TUTAR :"+game.GamePrice);
        }
    }
}
