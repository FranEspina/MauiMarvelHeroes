using MauiMarvelHeroes.Exceptions;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;

namespace MauiMarvelHeroes.Services.RequestProvider
{
    public class RequestProvider : IRequestProvider
    {
        private readonly Lazy<HttpClient> _httpClient =
            new(() =>
                {
                    var httpClient = new HttpClient();
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    return httpClient;
                },
                LazyThreadSafetyMode.ExecutionAndPublication);

        public async Task<TResult> GetAsync<TResult>(string uri, string token = "")
        {
            HttpClient httpClient = GetOrCreateHttpClient(token);
            HttpResponseMessage response = await httpClient.GetAsync(uri).ConfigureAwait(false);

            await RequestProvider.HandleResponse(response).ConfigureAwait(false);

            TResult result = await response.Content.ReadFromJsonAsync<TResult>();

            return result;
        }

        private HttpClient GetOrCreateHttpClient(string token = "")
        {
            var httpClient = _httpClient.Value;

            httpClient.DefaultRequestHeaders.Authorization =
                !string.IsNullOrEmpty(token)
                    ? new AuthenticationHeaderValue("Bearer", token)
                    : null;

            return httpClient;
        }

        private static async Task HandleResponse(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                if (response.StatusCode == HttpStatusCode.Forbidden ||
                        response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    throw new ServiceAuthenticationException(content);
                }

                throw new HttpRequestExceptionEx(response.StatusCode, content);
            }
        }
    }
}
