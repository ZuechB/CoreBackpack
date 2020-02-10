
namespace CoreBackpack.Models
{
    public class PushNotification
    {
        public string DeviceToken { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }

        public string AuthorizeKey { get; set; }
    }

    public class PushNotificationData
    {
        public string title { get; set; }
        public string body { get; set; }
        public string icon { get; set; }
        public string tag { get; set; }
    }

    public class FireBaseNotification
    {
        public PushNotificationData data { get; set; }
        public string to { get; set; }
    }
}
