using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Algolia.Search.Clients;
using Algolia.Search.Models.Search;


namespace algolia_search.Services
{
    public class AlgoliaServices
    {
        private SearchClient client;
        private SearchIndex index;

        public AlgoliaServices()
        {
            client = new SearchClient("YourApplicationID", "YourAdminAPIKey");
            index = client.InitIndex("your_index");
        }

        public async Task<SearchResponse<dynamic>> Search(string query)
        {
            Query algoliaQuery = new Query(query); // Create a Query object with the provided query string
            return await index.SearchAsync<dynamic>(algoliaQuery); // Pass the Query object to the SearchAsync method
        }
    }
}