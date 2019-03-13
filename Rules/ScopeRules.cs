using System.Collections.Generic;
using System.Linq;
using Digman.IO.CFlat.Data.Enums;

namespace Digman.IO.CFlat.Rules
{
    public static class ScopeRules
    {
        //Defines rules for what scopes a keyword can contain
        public static readonly Dictionary<Keywords, ScopeType[]> Rules = new Dictionary<Keywords, ScopeType[]>
        {
            {Keywords.Namespace, new[] {ScopeType.Class, ScopeType.Interface, ScopeType.Enum}},
            {Keywords.Class, new[] {ScopeType.Method}},
            {Keywords.Method, new[] {ScopeType.If, ScopeType.While, ScopeType.For}},
            {Keywords.If, new[] {ScopeType.If, ScopeType.For, ScopeType.While}},
            {Keywords.While, new[] {ScopeType.If, ScopeType.While, ScopeType.For}},
            {Keywords.For, new[] {ScopeType.If, ScopeType.While, ScopeType.For}}
        };
    }
}