using System.Collections.Generic;
using Digman.IO.CFlat.Data;

namespace Digman.IO.CFlat.Rules
{
  public static class ScopeRules
  {
    public static readonly Dictionary<ScopeType, ScopeType[]> RuleTree = new Dictionary<ScopeType, ScopeType[]>
    {
      { ScopeType.Namespace, new [] { ScopeType.Class, ScopeType.Interface, ScopeType.Enum }}
    };
  }
}