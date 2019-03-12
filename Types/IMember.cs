using Digman.IO.CFlat.Data;

namespace Digman.IO.CFlat.Types
{
  public interface IMember
  {
    string Name { get; set; }
    TypeReference ReturnType { get; set; }
    MemberType MemberType { get; set; }
    AccessModifier AccessModifer { get; set; }
  }
}