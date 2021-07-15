using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class HolidayCampaign : ICampaignManager
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name + " Tatil indirimi uygulandı.");  
        }

        public void Del(Game game)
        {
            Console.WriteLine(game.Name + " Tatil indirimi silindi.");
        }
    }
}
