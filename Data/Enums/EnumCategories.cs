using System.Collections.Generic;

namespace Digman.IO.CFlat.Data.Enums
{
  // this is a list of access modifiers or modifier status
  public static class EnumCategories
  {
    public static IEnumerable<Keyword> AccessModifiers = new List<Keyword>
    {
      Keyword.Public,
      Keyword.Private,
    };
    
    public static IEnumerable<Keyword> Scopes = new List<Keyword>
    {
      Keyword.Namespace,
      Keyword.Interface,
      Keyword.Class,
      Keyword.Enum,
      Keyword.Method,
      Keyword.If,
      Keyword.While,
      Keyword.For,
    };
    
    public static IEnumerable<Keyword> Members = new List<Keyword>
    {
      Keyword.ClassVariable,
      Keyword.MethodVariable,
      Keyword.Method,
      Keyword.InterfaceMember,
    };
  }
}