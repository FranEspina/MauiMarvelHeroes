using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMarvelHeroes.Helpers;

public static class DesignHelper
{
#if WINDOWS
    public static int SpanColumns = 3;
#else
    public static int SpanColumns = 1;
#endif
}
