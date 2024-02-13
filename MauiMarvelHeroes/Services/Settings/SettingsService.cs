using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMarvelHeroes.Services.Settings
{
    public class SettingsService : ISettingsService
    {
        public bool SkipIntro { get; set; }
    }
}
