using System;
using System.Collections.Generic;
using CovariationExample.Common;

namespace CovariationExample
{
    #region Фабрики

    public interface ISmartPhoneCreator<out T>
    {
        T ProcessUserRequest(UserWishers userWishers);
    }


    public class GalaxyCreator : ISmartPhoneCreator<Galaxy>
    {
        public Galaxy ProcessUserRequest(UserWishers userWishers)
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
    }


    public class IPhoneCreator : ISmartPhoneCreator<IPhone>
    {
        public IPhone ProcessUserRequest(UserWishers userWishers)
        {
            var iphone = new IPhone();

            iphone.ConnectToAppleId();
            iphone.TuneFaceId();

            return iphone;
        }
    }

    #endregion


    #region Менеджер (Ковариантность)

    public class MagazineManager
    {
        private List<SmartPhone> SmartPhones { get; }

        public MagazineManager()
        {
            SmartPhones = new List<SmartPhone>();
        }

        public void ProcessSmartPhone(ISmartPhoneCreator<SmartPhone> smartPhoneCreator)
        {
            var phone = smartPhoneCreator.ProcessUserRequest(new UserWishers());
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

    #endregion
}
