using GeminiSharp.Api;
using GeminiSharp.Client;
using GeminiSharp.Model;

namespace CarDealership.Utils
{
    public class GeminiClient : IDisposable
    {
        private const string ApiBasePath = "https://generativelanguage.googleapis.com";
        private const string Model = "gemini-2.0-flash";
        private const string KeyName = "x-goog-api-key";
        private const string PreRequest = "Дай відповідь на запит загальним обсягом не більше 250 символів.";

        private readonly HttpClient _httpClient;
        private readonly GeminiApi _geminiApi;
        private readonly Configuration _configuration;

        public GeminiClient()
        {
            _configuration = new Configuration
            {
                BasePath = ApiBasePath
            };

            _configuration.ApiKey.Add(KeyName, ConfigurationUtil.GeminiApiKey);

            _httpClient = new HttpClient();

            _geminiApi = new GeminiApi(_httpClient, _configuration);
        }

        public string SendRequest(string question)
        {
            var generateContentRequest = new GenerateContentRequest
            {
                Contents =
                [
                    new RequestContent()
                    {
                        Parts =
                        [
                            new RequestContentPart
                            {
                                Text = $"{PreRequest} {question}"
                            }
                        ]
                    }
                ]
            };

            try
            {
                GenerateContentResponse result = _geminiApi.GenerateContent(Model, generateContentRequest);
                return result.Candidates[0].Content.Parts[0].Text;
            }
            catch
            {
                return "Щось пішло не так, спробуйте ще раз.";
            }
        }

        public void Dispose()
        {
            _httpClient.Dispose();
            _geminiApi.Dispose();
        }
    }
}
