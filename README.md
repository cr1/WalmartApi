# C# Newegg API
This API was built to pull product information from Walmart's Open API. Requires a valid apiKey added to the app.config file
Documentation is available at [Walmart Labs](https://developer.walmartlabs.com/docs/read/Home).

## Currently supported:
- Product Search
- Product Lookup
- Taxonomy
- Data Feeds & Special Feeds (Item feeds require elevated privelages)


###
### Example

            string apiKey = ConfigurationManager.AppSettings["apiKey"];
            Console.WriteLine("Enter your search query");
            
            var search = new SearchRequest() {apiKey = apiKey};
            search.query = Console.ReadLine();
            
            var searchResponse = ApiCall.Send<SearchResponse>(search);