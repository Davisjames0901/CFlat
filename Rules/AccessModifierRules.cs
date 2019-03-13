using System.Collections.Generic;
using Digman.IO.CFlat.Data.Enums;
using System.Linq;

namespace Digman.IO.CFlat.Rules
{
    public static class AccessModifierRules
    {
        // This defines our rules for having access modifers on scope creating tokens
        public static readonly Dictionary<Keywords, AccessModifier[]> Rules =
            new Dictionary<Keywords, AccessModifier[]>
            {
                {Keywords.Namespace, new[] {AccessModifier.NotValid}},
                {Keywords.Class, new[] {AccessModifier.Private, AccessModifier.Public, AccessModifier.None}},
                {Keywords.Interface, new[] {AccessModifier.Private, AccessModifier.Public, AccessModifier.None}},
                {Keywords.Enum, new[] {AccessModifier.Private, AccessModifier.Public, AccessModifier.None}},
                {Keywords.ClassVariable, new[] {AccessModifier.Public, AccessModifier.Private, AccessModifier.None}},
                {Keywords.Method, new[] {AccessModifier.Private, AccessModifier.Public, AccessModifier.None}},
                {Keywords.For, new[] {AccessModifier.NotValid}},
                {Keywords.If, new[] {AccessModifier.NotValid}},
                {Keywords.While, new[] {AccessModifier.NotValid}},
                {Keywords.InterfaceMember, new[] {AccessModifier.NotValid}},
                {Keywords.MethodVariable, new[] {AccessModifier.NotValid}},
                {Keywords.Public, new[] {AccessModifier.NotValid}},
                {Keywords.Private, new[] {AccessModifier.NotValid}}
                
            };
    }
}