using System;
using System.Collections.Generic;
using System.Linq;

namespace Digman.IO.CFlat.Helpers
{
  public static class EnumHelpers
  {
    public static IEnumerable<T> GetValues<T>()
    {
        return Enum.GetValues(typeof(T)).Cast<T>();
    }
  }
}