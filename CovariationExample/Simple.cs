using System;
using System.Collections.Generic;
using CovariationExample.Common;

namespace CovariationExample.Simple
{
    public class SmartPhone
    {
        public virtual string Name => "Just a SmartPhone";

        public virtual SmartPhone ProcessUserRequest(UserWishers userWishers)
        {
            return null;
        }
    }



    public class Galaxy : SmartPhone
    {
        public override string Name => "Galaxy";

        public override SmartPhone ProcessUserRequest(UserWishers userWishers)
        {
            var galaxy = new Galaxy();

            if (userWishers.CreateAccount)
            {
                galaxy.CreateGoogleAccount();
            }

            if (userWishers.InitPassword)
            {
                galaxy.CreateVisualPassword();
            }

            return galaxy;
        }

        public void CreateGoogleAccount()
        {

        }

        public void CreateVisualPassword()
        {

        }
    }



    public class IPhone : SmartPhone
    {
        public override string Name => "IPhone";

        public override SmartPhone ProcessUserRequest(UserWishers userWishers)
        {
            var iphone = new IPhone();

            iphone.ConnectToAppleId();
            iphone.TuneFaceId();

            return iphone;
        }

        public void ConnectToAppleId()
        {

        }

        public void TuneFaceId()
        {

        }
    }



    public class MagazineManagerSimple
    {
        private List<SmartPhone> SmartPhones { get; }

        public MagazineManagerSimple()
        {
            SmartPhones = new List<SmartPhone>();
        }

        public void ProcessSmartPhone(SmartPhone smartPhone)
        {
            var phone = smartPhone.ProcessUserRequest(new UserWishers());
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
}
