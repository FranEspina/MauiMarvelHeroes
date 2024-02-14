using MauiMarvelHeroes.Models.MarvelApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMarvelHeroes.Services.MarvelApi
{
    public interface IMarvelApiService
    {
        Task<MarvelResponse<MarvelComic>> GetComicsAsync(uint limit, uint offset);
        Task<MarvelResponse<MarvelCharacter>> GetCharactersAsync(uint limit, uint offset);
        Task<MarvelResponse<MarvelComicSerie>> GetComicSeriesAsync(uint limit, uint offset);
    }
}
