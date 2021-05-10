using System;
using CovariationExample.Common;

namespace CovariationExample
{
    public interface ISmartPhoneDisplayer<in T>
    {
        void Display(T smartPhone);
    }



    public class GalaxyDisplayer : ISmartPhoneDisplayer<Galaxy>
    {
        public void Display(Galaxy smartPhone)
        {
            Console.WriteLine($"This is Galaxy with name '{smartPhone.Name}'");
        }
    }

    public class BaseSmartPhoneDisplayer : ISmartPhoneDisplayer<SmartPhone>
    {
        public void Display(SmartPhone smartPhone)
        {
            Console.WriteLine($"This is Base smart phone with name '{smartPhone.Name}'");
        }
    }



    public class DisplayerManager
    {
        public void DisplayName(ISmartPhoneDisplayer<Galaxy> displayer)
        {
            displayer.Display(new Galaxy { Name = "New name" });
        }
    }
}
