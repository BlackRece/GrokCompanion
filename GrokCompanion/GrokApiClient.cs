using Newtonsoft.Json;

using RestSharp;

namespace GrokCompanion;

public class GrokApiClient {
    private readonly string _apiKey;
    private readonly RestClient _client;

    public GrokApiClient(string apiKey)
    {
        _apiKey = apiKey;
        _client = new RestClient("https://api.x.ai/v1");
    }

    public async Task<string> SendQueryAsync(string query, bool deepSearch = false)
    {
        var request = new RestRequest("grok/query", Method.Post);
        request.AddHeader("Authorization", $"Bearer {_apiKey}");
        request.AddJsonBody(new
        {
            query,
            deepSearch
        });

        var response = await _client.ExecuteAsync(request);
        if (!response.IsSuccessful)
        {
            return $"Error: {response.ErrorMessage}";
        }

        dynamic jsonResponse = JsonConvert.DeserializeObject(response.Content);
        return jsonResponse.response;
    }
}
