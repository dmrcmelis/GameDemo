using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.TcNo = "483456780";
            gamer1.Name = "Melis";
            gamer1.Surname = "Demircioğlu";
            gamer1.Age = 23;

            Gamer gamer2 = new Gamer();
            gamer2.TcNo = "45673489";
            gamer2.Name = "Mert";
            gamer2.Surname = "Demircioğlu";
            gamer2.Age = 30;

            Game game1 = new Game();
            game1.Name = "Car Game";
            Game game2 = new Game();
            game2.Name = "War Game";



         
            

            SaleManager saleManager = new SaleManager();
            saleManager.Sold(game1,gamer2);

            ICampaignManager studentCampaign = new StudentCampaign();

            saleManager.Add(studentCampaign);

            studentCampaign.Del(game2);

            ICampaignManager holidayCampaign=new HolidayCampaign();

            holidayCampaign.Add(game1);





        }
    }
}
