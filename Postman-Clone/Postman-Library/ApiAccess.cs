using System.Text.Json;

namespace Postman_Library
{
    public class ApiAccess : IApiAccess
    {
        private readonly HttpClient _httpClient = new();

        public async Task<string> CallApiAsync(string url, bool formatOutput = true, HttpAction action = HttpAction.GET)
        {
            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                if (formatOutput)
                {
                    var jsonElement = JsonSerializer.Deserialize<JsonElement>(jsonResponse);
                    string json = JsonSerializer.Serialize(jsonElement, new JsonSerializerOptions { WriteIndented = true });

                    return json;

                }
                return jsonResponse;
            }

            else
            {
                return $"Hata: {response.StatusCode}";
            }
        }

        public bool IsValidUrl(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                return false;
            }

            bool output = Uri.TryCreate(url, UriKind.Absolute, out Uri uriOutput)
                &&
                (uriOutput.Scheme == Uri.UriSchemeHttps);

            return output;
        }

    }
}
