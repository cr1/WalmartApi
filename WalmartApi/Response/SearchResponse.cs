using System;
using System.Collections.Generic;


namespace WalmartApi.Response
{

    public class SearchResponse
    {
        public string query { get; set; }
        public string sort { get; set; }
        public string format { get; set; }
        public string responseGroup { get; set; }
        public int totalResults { get; set; }
        public int start { get; set; }
        public int numItems { get; set; }
        public ItemResponse[] items { get; set; }
    }

}
