

namespace WalmartApi.Request
{
    class TaxonomyRequest : IApiRequest
    {

        public string apiKey { get; set; }
        public string GetUrl()
        {
            return string.Format("/v1/taxonomy?apiKey={0}", apiKey);
        }
    }
}
