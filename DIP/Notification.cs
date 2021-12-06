namespace DIP
{
    public class Notification
    {
        private IMessenger _messenger;

        public Notification(IMessenger messenger)
        {
            _messenger = messenger;
        }

        public void DoNotify()
        {
            _messenger.SendMessage();
        }
    }
}