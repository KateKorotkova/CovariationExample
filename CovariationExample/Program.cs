using System;
using System.Collections.Generic;

namespace CovariationExample
{
    class Program
    {
        public class MagazineManager
        {
            public List<SmartPhone> SmartPhones { get; set; }

            public MagazineManager()
            {
                SmartPhones = new List<SmartPhone>();
            }

            public void CreateSmartPhone(ISmartPhoneCreator<SmartPhone> smartPhoneCreator)
            {
                var phone = smartPhoneCreator.CreateSmartPhone(new UserWishers());
                SmartPhones.Add(phone);
                
                FillDocuments();
                SendRequestToWareHouse();
            }

            public void ShowAllSmartPhones()
            {
                SmartPhones.ForEach(x => Console.WriteLine(x.Name));
            }

            private void SendRequestToWareHouse()
            {

            }

            private void FillDocuments()
            {

            }
        }


        static void Main(string[] args)
        {
            var manager = new MagazineManager();

            var galaxyCreator = new GalaxyCreator();
            var iPhoneCreator = new IPhoneCreator();
            
            manager.CreateSmartPhone(galaxyCreator);
            manager.CreateSmartPhone(iPhoneCreator);
            
            manager.ShowAllSmartPhones();
        }
    }
}
