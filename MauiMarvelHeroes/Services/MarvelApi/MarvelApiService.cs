using MauiMarvelHeroes.Helpers;
using MauiMarvelHeroes.Models.MarvelApi;
using MauiMarvelHeroes.Pages;
using MauiMarvelHeroes.Services.Common;
using MauiMarvelHeroes.Services.RequestProvider;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMarvelHeroes.Services.MarvelApi
{
    public class MarvelApiService : IMarvelApiService
    {
        private readonly IRequestProvider _requestProvider;

        public const string MarvelEndPoint = "https://gateway.marvel.com";

        private const string ComicsUrlBase = "v1/public/comics";
        private const string CharactersUrlBase = "v1/public/characters";
        private const string ComicSeriesUrlBase = "v1/public/series";




        public MarvelApiService(IRequestProvider requestProvider)
        {
            _requestProvider = requestProvider;
        }

        public async Task<MarvelResponse<MarvelComic>> GetComicsAsync(uint limit = 10, uint offset = 0)
        {
            var queryParameters = await GetQueryParamsAsync(limit, offset);
            var urlBaseWithParameters = $"{ComicsUrlBase}?{queryParameters}";
            var uri = UriHelper.CombineUri(MarvelEndPoint, urlBaseWithParameters); 
            return await _requestProvider.GetAsync<MarvelResponse<MarvelComic>>(uri);
        }

        public async Task<MarvelResponse<MarvelCharacter>> GetCharactersAsync(uint limit = 10, uint offset = 0)
        {
            var queryParameters = await GetQueryParamsAsync(limit, offset);
            var urlBaseWithParameters = $"{CharactersUrlBase}?{queryParameters}";
            var uri = UriHelper.CombineUri(MarvelEndPoint, urlBaseWithParameters);
            return await _requestProvider.GetAsync<MarvelResponse<MarvelCharacter>>(uri);
        }

        public async Task<MarvelResponse<MarvelComicSerie>> GetComicSeriesAsync(uint limit = 10, uint offset = 0)
        {
            var queryParameters = await GetQueryParamsAsync(limit, offset);
            var urlBaseWithParameters = $"{ComicSeriesUrlBase}?{queryParameters}";
            var uri = UriHelper.CombineUri(MarvelEndPoint, urlBaseWithParameters);
            return await _requestProvider.GetAsync<MarvelResponse<MarvelComicSerie>>(uri);
        }

        private async Task<string> GetQueryParamsAsync(uint limit = 10, uint offset = 0)
        {
            string ts = CommonService.UnixTimeNow().ToString(CultureInfo.InvariantCulture);
            var apiKey = MarvelApiKeys.MarvelPublicKey;
            string unhash = $"{ts}{MarvelApiKeys.MarvelPrivateKey}{apiKey}";
            var hash = CommonService.CalculateMd5Hash(unhash);
            
            var queryParameters = new Dictionary<string, string>();
            queryParameters.Add(nameof(ts).ToLower(), ts);
            queryParameters.Add(nameof(apiKey).ToLower(), apiKey);
            queryParameters.Add(nameof(hash).ToLower(), hash);
            queryParameters.Add(nameof(limit).ToLower(), limit.ToString());
            queryParameters.Add(nameof(offset).ToLower(), offset.ToString());

            var dictFormUrlEncoded = new FormUrlEncodedContent(queryParameters);
            var queryString = await dictFormUrlEncoded.ReadAsStringAsync();

            return queryString;

        }


    }
}
