using MovieRatingSystem.Services.Contracts;
using MovieRatingSystem.Shared.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace MovieRatingSystem.Services.Implementations
{
    public class ContentDataService : IContentDataService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public ContentDataService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;

            var username = _configuration["API:Username"];
            var password = _configuration["API:Password"];

            string encoded = Convert.ToBase64String(Encoding.UTF8.GetBytes(username + ":" + password));
            _httpClient.DefaultRequestHeaders.Add("Authorization", "Basic " + encoded);
        }

        public async Task<IEnumerable<ContentViewModel>> GetContent(string searchTerm, int type)
        {
            var contentResultsStream = await _httpClient.GetStreamAsync($"api/content?searchTerm={searchTerm}&type={type}");
            var contentResultsList = await JsonSerializer.DeserializeAsync<IEnumerable<ContentViewModel>>(contentResultsStream, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return contentResultsList;
        }

        public async Task<IEnumerable<RatingViewModel>> GetRatings(int type, string user)
        {
            var ratingResultsStream = await _httpClient.GetStreamAsync($"api/ratings?type={type}&user={user}");
            var ratingResultsList = await JsonSerializer.DeserializeAsync<IEnumerable<RatingViewModel>>(ratingResultsStream, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return ratingResultsList;
        }

        public async Task<bool> UpdateRating(RatingViewModel content)
        {
            var serializedBody = JsonSerializer.Serialize(content);
            var requestContent = new StringContent(serializedBody, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PutAsync("api/ratings", requestContent);            
            return response.StatusCode == System.Net.HttpStatusCode.OK;
        }
    }
}
