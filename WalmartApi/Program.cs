using System;
using System.Configuration;
using WalmartApi.Request;
using WalmartApi.Response;

namespace WalmartApi
{
    class Program
    {
        static void Main(string[] args)
        {
            string apiKey = ConfigurationManager.AppSettings["apiKey"];
            Console.WriteLine("Enter your search query");
            
            var search = new SearchRequest() {apiKey = apiKey};
            search.query = Console.ReadLine();
            
            var searchResponse = ApiCall.Send<SearchResponse>(search);

           // var item1 = response.items[0];
            //var itemRequest = new ItemRequest() {apiKey = search.apiKey, itemId = item1.itemId};
            //var response2 = ApiCall.Send<ItemResponse>(itemRequest);

            var feedRequest = new FeedRequest()
                {
                    apiKey = apiKey,
                    feed = FeedType.bestsellers
                };
            var feedResponse = ApiCall.Send<FeedResponse>(feedRequest);

            Console.ReadLine();
        }
    }
}
