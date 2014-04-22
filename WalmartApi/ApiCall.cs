using Newtonsoft.Json;
using WalmartApi.Request;

namespace WalmartApi
{
    public class ApiCall
    {
        public const string RootUrl = "http://api.walmartlabs.com/";
        public static T Send<T>(IApiRequest request)
        {
            using (var client = new GZipWebClient())
            {
                client.BaseAddress = RootUrl;
                var url = request.GetUrl();
                var jsonResponse = client.DownloadString(url);
                var dto = JsonConvert.DeserializeObject<T>(jsonResponse);
                return dto;
            }
        }

    }
}
