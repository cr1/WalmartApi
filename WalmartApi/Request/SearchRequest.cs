

namespace WalmartApi.Request
{
    public class SearchRequest : IApiRequest
    {
        public SearchRequest()
        {
            format = "json";
            responseGroup = "full";
        }
        public string apiKey { get; set; }
        public string lsPublisherId { get; set; }
        public string query { get; set; }
        public long? categoryId { get; set; }
        public int? start { get; set; }
        public string sort { get; set; }
        public string order { get; set; }
        public string format { get; set; }
        public string responseGroup { get; set; }
        public string GetUrl()
        {
            return "/v1/search?" + Helpers.GetQueryString(this);
        }

    }
}
