﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMarvelHeroes.Services.MarvelApi
{
    public interface IMarvelApiService
    {
        Task GetComicsAsync(uint limit, uint offset);
    }
}
