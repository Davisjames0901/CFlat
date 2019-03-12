using System.Collections.Generic;
using Digman.IO.CFlat.Data;

namespace Digman.IO.CFlat.Rules
{
  public static class AccessModifierRules
  {
    // This defines our rules for having access modifers on scope creating tokens
    public static readonly Dictionary<ScopeType, AccessModifier[]> ScopeRuleTree = new Dictionary<ScopeType, AccessModifier[]>
    {
      { ScopeType.Namespace, new [] { AccessModifier.NotValid } },
      { ScopeType.Class, new [] { AccessModifier.Private, AccessModifier.Public, AccessModifier.None }},
      { ScopeType.Interface, new [] { AccessModifier.Private, AccessModifier.Public, AccessModifier.None }},
      { ScopeType.Enum, new [] {AccessModifier.Private, AccessModifier.Public, AccessModifier.None}},
      { ScopeType.For, new [] {AccessModifier.NotValid}},
      { ScopeType.If, new [] {AccessModifier.NotValid}},
      { ScopeType.Method, new [] {AccessModifier.Private, AccessModifier.Public, AccessModifier.None}},
      { ScopeType.While, new [] {AccessModifier.NotValid}}
    };

    // This defines our rules for having access modifiers on members
    public static readonly Dictionary<MemberType, AccessModifier[]> MemberRuleTree = new Dictionary<MemberType, AccessModifier[]>
    {
      
    };
  }
}