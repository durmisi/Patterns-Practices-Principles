namespace Patterns_Practices_Principles.Principles.SOLID.Dependency_inversion_principle
{
    //This principle tells you not to write any tightly coupled code because that is a nightmare to maintain when the application is growing bigger and bigger.
    //If a class depends on another class, then we need to change one class if something changes in that dependent class.
    //We should always try to write loosely coupled class.

    //Suppose there is one notification system after saving some details into database.

    //public class Email
    //{
    //    public void SendEmail()
    //    {
    //        // code to send mail
    //    }
    //}

    //public class Notification
    //{
    //    private Email _email;
    //    public Notification()
    //    {
    //        _email = new Email();
    //    }

    //    public void PromotionalNotification()
    //    {
    //        _email.SendEmail();
    //    }
    //}

    //Now Notification class totally depends on Email class, because it only sends one type of notification.
    //If we want to introduce any other like SMS then? We need to change the notification system also.
    //And this is called tightly coupled.What can we do to make it loosely coupled?
    //Ok, check the following implementation.

    public interface IMessenger
    {
        void SendMessage();
    }

    public class Email : IMessenger
    {
        public void SendMessage()
        {
            // code to send email
        }
    }

    public class SMS : IMessenger
    {
        public void SendMessage()
        {
            // code to send SMS
        }
    }

    //public class Notification
    //{
    //    private IMessenger _iMessenger;
    //    public Notification()
    //    {
    //        _iMessenger = new Email();
    //    }
    //    public void DoNotify()
    //    {
    //        _iMessenger.SendMessage();
    //    }
    //}

    //Still Notification class depends on Email class.
    //Now, we can use dependency injection so that we can make it loosely coupled.
    //There are 3 types to DI, Constructor injection, Property injection and method injection.

    // Constructor Injection
    public class Notification
    {
        private IMessenger _iMessenger;

        public Notification(IMessenger pMessenger)
        {
            _iMessenger = pMessenger;
        }

        public void DoNotify()
        {
            _iMessenger.SendMessage();
        }
    }

    //  Property Injection
    //public class Notification
    //{
    //    private IMessenger _iMessenger;
    //    public Notification()
    //    {
    //    }
    //    public IMessenger MessageService
    //    {
    //        private get;
    //        set
    //        {
    //            _iMessenger = value;
    //        }
    //    }

    //    public void DoNotify()
    //    {
    //        _iMessenger.SendMessage();
    //    }
    //}

    //Method Injection
    //public class Notification
    //{
    //    public void DoNotify(IMessenger pMessenger)
    //    {
    //        pMessenger.SendMessage();
    //    }
    //}
}