namespace CovariationExample
{

    #region Предметная область

    public class SmartPhone
    {
        public virtual string Name => "Just a SmartPhone";
    }

    public class Galaxy : SmartPhone
    {
        public override string Name => "Galaxy";

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

        public void ConnectToAppleId()
        {

        }

        public void ConnectToiCloud()
        {

        }

        public void TuneFaceId()
        {

        }
    }

    #endregion



    #region Фабрики

    public class UserWishers
    {
       
    }

    public interface ISmartPhoneCreator<out T>
    {
        T CreateSmartPhone(UserWishers userWishers);
    }

    public class GalaxyCreator : ISmartPhoneCreator<Galaxy>
    {
        public Galaxy CreateSmartPhone(UserWishers userWishers)
        {
            var galaxy = new Galaxy();

            galaxy.CreateGoogleAccount();
            galaxy.CreateVisualPassword();
            
            return galaxy;
        }
    }

    public class IPhoneCreator : ISmartPhoneCreator<IPhone>
    {
        public IPhone CreateSmartPhone(UserWishers userWishers)
        {
            var iphone = new IPhone();

            iphone.ConnectToAppleId();
            iphone.ConnectToiCloud();
            iphone.TuneFaceId();

            return iphone;
        }
    }

    #endregion




    public interface ICarDisplayer<in T>
    {
        void Display(T car);
    }



  

    public class CarNameDisplayer
    {
        public void DisplayName(ICarDisplayer<IPhone> carDisplayer)
        {
            //carDisplayer.Display(new IPhone());
            //carDisplayer.Display(new SmartPhone());
        }
    }
}
