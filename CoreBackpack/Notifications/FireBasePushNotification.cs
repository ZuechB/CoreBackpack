using CoreBackpack.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace CoreBackpack.Notifications
{
    public class FireBasePushNotification
    {
        public static async Task<HttpResponseMessage> Send(PushNotification notification)
        {
            var http = new HttpClient();
            http.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", "key=" + notification.AuthorizeKey);
            var result = await http.PostAsJsonAsync("https://fcm.googleapis.com/fcm/send", new FireBaseNotification()
            {
                data = new PushNotificationData()
                {
                    title = notification.Title,
                    body = notification.Body,
                    icon = notification.Icon,
                    tag = notification.Url
                },
                to = notification.DeviceToken
            });

            return result;
        }
    }
}