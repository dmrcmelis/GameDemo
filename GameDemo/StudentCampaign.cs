using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class StudentCampaign  : ICampaignManager

    {
        public void Add(Game game)
        {
            Console.WriteLine("Öğrenci indirimi eklendi.");
        }

        public void Del(Game game)
        {
            Console.WriteLine( game.Name + " Öğrenci indirimi silindi.");
        }

    }
}
