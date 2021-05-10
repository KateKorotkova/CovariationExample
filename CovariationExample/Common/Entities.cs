namespace CovariationExample.Common
{
    public class SmartPhone
    {
        public virtual string Name { get; set; } = "Just a SmartPhone";
    }



    public class Galaxy : SmartPhone
    {
        public override string Name { get; set; } = "Galaxy";

        public void CreateGoogleAccount()
        {
        }

        public void CreateVisualPassword()
        {
        }
    }



    public class IPhone : SmartPhone
    {
        public override string Name { get; set; } = "IPhone";

        public void ConnectToAppleId()
        {
        }

        public void TuneFaceId()
        {
        }
    }
}
