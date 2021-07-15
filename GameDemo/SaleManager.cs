using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class SaleManager
    {
        public void Sold(Game game,Gamer gamer )
        {

            Console.WriteLine(game.Name +  " is sold by " + gamer.Name);

        }
        public void Add(ICampaignManager campaignManager)
        {
            Console.WriteLine("Öğrenci indirimi eklendi");
        }
    }
}
