using System.Collections.Generic;
using Digman.IO.CFlat.Data.Enums;
using System.Linq;

namespace Digman.IO.CFlat.Rules
{
    public static class AccessModifierRules
    {
        // This defines our rules for having access modifers on scope creating tokens
        public static readonly Dictionary<Keyword, Keyword[]> Rules =
            new Dictionary<Keyword, Keyword[]>
            {
                {Keyword.Namespace, new[] {Keyword.NotValid}},
                {Keyword.Class, new[] {Keyword.Private, Keyword.Public, Keyword.None}},
                {Keyword.Interface, new[] {Keyword.Private, Keyword.Public, Keyword.None}},
                {Keyword.Enum, new[] {Keyword.Private, Keyword.Public, Keyword.None}},
                {Keyword.ClassVariable, new[] {Keyword.Public, Keyword.Private, Keyword.None}},
                {Keyword.Method, new[] {Keyword.Private, Keyword.Public, Keyword.None}}
            };
    }
}