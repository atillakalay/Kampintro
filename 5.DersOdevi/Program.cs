using System;

namespace _5.DersOdevi
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Id = 1;
            player.FirsName = "Atilla";
            player.LastName = "Kalay";
            player.BirthDate = "26.07.1999";
            player.TcNumber = "12345678989";

            PlayerManager playerManager = new PlayerManager();
            playerManager.Check(player);

            Game game = new Game();
            game.Id = 1;
            game.GameName = "GTA5";
            game.GamePrice = 165;

            GameManager gameManager = new GameManager();
            CampaignManager campaignManager = new CampaignManager();
            gameManager.GameSell(player,game);

            Campaign campaign = new Campaign() {CampaignName="2021",DiscountedPrice=60,Game=game,Id=2  };


            campaignManager.AddCampaign(campaign);
        }
    }
}
