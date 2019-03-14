using System;
using System.Collections.Generic;
using Digman.IO.CFlat.Data;
using System.Linq;
using Digman.IO.CFlat.Data.Enums;
using Digman.IO.CFlat.Helpers;

namespace Digman.IO.CFlat.Tests
{
  public static class KeywordTest
  {
//    private static readonly List<Type> EnumsToTest = new List<Type>
//    {
//      typeof(AccessModifier),
//      typeof(MemberType),
//      typeof(ScopeType)
//    };
//
//    public static bool TestKeywordContents()
//    {
//      var keywordNames = Enum.GetNames(typeof(Keyword)).ToList();
//      var keywordValues = (int[])Enum.GetValues(typeof(Keyword));
//      var checkedValues = new Dictionary<string, int>();
//      bool issueFound = false;
//      
//      for(var i = 0; i < keywordNames.Count; i++)
//      {
//        checkedValues.Add(keywordNames[i], keywordValues[i]);
//      }
//      
//      foreach (var a in EnumsToTest)
//      {
//        var names = Enum.GetNames(a).ToList();
//        var values = (int[])Enum.GetValues(a);
//        
//        for(var i = 0; i < values.Length; i++)
//        {
//          if (checkedValues.ContainsKey(names[i]))
//          {
//            if (checkedValues[names[i]] != values[i])
//            {
//              ConsoleHelpers.PrintError($"Enum {names[i]} in type {a} should have had a value of {checkedValues[names[i]]} but instead had a value of {values[i]}");
//              issueFound = true;
//            }
//          }
//          else
//          {
//            ConsoleHelpers.PrintError($"Enum {names[i]} in type {a} was not found in {typeof(Keyword)}");
//            issueFound = true;
//          }
//        }
//      }
//
//      if (!issueFound)
//      {
//        ConsoleHelpers.PrintSuccess("Passed keyword validation");
//      }
//      
//      return !issueFound;
//    }
  }
}