namespace CoreBackpack
{
    public class AppSettings
    {
        public SendGridSettings SendGrid { get; set; }
        public GoogleCloudMessaging GoogleCloudMessaging { get; set; }
        public StripeKey Stripe { get; set; }
    }

    public class GoogleCloudMessaging
    {
        public string SenderId { get; set; }
        public string ServerKey { get; set; }
    }

    public class StripeKey
    {
        public string publishableKey { get; set; }
        public string secretKey { get; set; }
    }

    public class SendGridSettings
    {
        public string APIKey { get; set; }
        public string FromEmail { get; set; }
        public string FromName { get; set; }
        public bool IsDebugEnabed { get; set; }
    }
}