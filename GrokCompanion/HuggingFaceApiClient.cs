using RestSharp; 
using Newtonsoft.Json;

namespace GrokCompanion {
    public class HuggingFaceApiClient {
        private readonly RestClient _client;
        private readonly string? _apiKey;

        public HuggingFaceApiClient(string? apiKey)
        {
            _apiKey = apiKey;
            _client = new RestClient("https://api-inference.huggingface.co/models");
        }

        public async Task<string> SendQueryAsync(string query, bool deepSearch = false)
        {
            // Use Mistral-7B-Instruct for conversational tasks
            var request = new RestRequest("mistralai/Mixtral-8x7B-Instruct-v0.1", Method.Post);
            request.AddHeader("Authorization", $"Bearer {_apiKey}");
            request.AddJsonBody(new
            {
                inputs = query,
                parameters = new
                {
                    max_new_tokens = 500,
                    temperature = 0.7,
                    top_p = 0.9
                }
            });

            var response = await _client.ExecuteAsync(request);
            if (!response.IsSuccessful)
            {
                return $"Error: {response.ErrorMessage}";
            }

            dynamic jsonResponse = JsonConvert.DeserializeObject(response.Content);
            return jsonResponse[0].generated_text.ToString();
        }
    }

}