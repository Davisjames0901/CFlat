using System.Collections.Generic;
using System.Linq;
using Digman.IO.CFlat.Data.Enums;

namespace Digman.IO.CFlat.Rules
{
    public static class ScopeRules
    {
        //Defines rules for what scopes a keyword can contain
        public static readonly Dictionary<Keyword, Keyword[]> Rules = new Dictionary<Keyword, Keyword[]>
        {
            {Keyword.Namespace, new[] {Keyword.Class, Keyword.Interface, Keyword.Enum}},
            {Keyword.Class, new[] {Keyword.Method}},
            {Keyword.Method, new[] {Keyword.If, Keyword.While, Keyword.For}},
            {Keyword.If, new[] {Keyword.If, Keyword.For, Keyword.While}},
            {Keyword.While, new[] {Keyword.If, Keyword.While, Keyword.For}},
            {Keyword.For, new[] {Keyword.If, Keyword.While, Keyword.For}}
        };
    }
}