using Digman.IO.CFlat.Data;
using Digman.IO.CFlat.Data.Enums;

namespace Digman.IO.CFlat.Types
{
  public interface IMember
  {
    string Name { get; set; }
    TypeReference ReturnType { get; set; }
    Keyword MemberType { get; set; }
    Keyword AccessModifer { get; set; }
  }
}