using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMarvelHeroes.Exceptions;

public class ServiceAuthenticationException : Exception
{
    public string Content { get; }

    public ServiceAuthenticationException()
    {
    }

    public ServiceAuthenticationException(string content)
    {
        Content = content;
    }
}