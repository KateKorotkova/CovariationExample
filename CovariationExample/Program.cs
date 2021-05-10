using CovariationExample.Simple;
using Galaxy = CovariationExample.Common.Galaxy;
using SmartPhone = CovariationExample.Common.SmartPhone;

namespace CovariationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Пример без вариантности

            var managerInitial = new MagazineManagerSimple();
            
            managerInitial.ProcessSmartPhone(new Simple.Galaxy());
            managerInitial.ProcessSmartPhone(new Simple.IPhone());
            
            managerInitial.ShowAllSmartPhones();

            #endregion


            #region Ковариантность

            var manager = new MagazineManager();

            var galaxyCreator = new GalaxyCreator();
            var iPhoneCreator = new IPhoneCreator();

            manager.ProcessSmartPhone(galaxyCreator);
            manager.ProcessSmartPhone(iPhoneCreator);
            
            manager.ShowAllSmartPhones();


            //грубо предыдущие строчки:
            ISmartPhoneCreator<SmartPhone> galaxyCreator2 = new GalaxyCreator();
            ISmartPhoneCreator<SmartPhone> iPhoneCreator2 = new IPhoneCreator();
            manager.ProcessSmartPhone(galaxyCreator2);
            manager.ProcessSmartPhone(iPhoneCreator2);

            #endregion


            #region Контравариантность

            var galaxyDisplayer = new GalaxyDisplayer();
            var smartPhoneDisplayer = new BaseSmartPhoneDisplayer();

            var displayerManager = new DisplayerManager();
            displayerManager.DisplayName(galaxyDisplayer);
            displayerManager.DisplayName(smartPhoneDisplayer);


            //грубо предыдущие строчки:
            ISmartPhoneDisplayer<Galaxy> galaxyDisplayer2 = new GalaxyDisplayer();
            ISmartPhoneDisplayer<Galaxy> smartPhoneDisplayer2 = new BaseSmartPhoneDisplayer();
            displayerManager.DisplayName(galaxyDisplayer2);
            displayerManager.DisplayName(smartPhoneDisplayer2);

            #endregion
        }
    }
}
