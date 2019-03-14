using System;
using System.Collections.Generic;
using System.Linq;
using Digman.IO.CFlat.Data;

namespace Digman.IO.CFlat.Helpers
{
  public static class EnumHelpers
  {
    public static IEnumerable<T> GetValidValues<T>()
    {
        return Enum.GetValues(typeof(T)).Cast<T>().Where(x=> !Constants.ValuesToIgnore.Contains(x.ToString()));
    }
  }
}