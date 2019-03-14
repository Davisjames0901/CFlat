using Digman.IO.CFlat.Data;
using Digman.IO.CFlat.Data.Enums;

namespace Digman.IO.CFlat.SyntaxAnalyzers
{
  public interface IValidator
  {
    bool Validate(Keyword parent, Keyword target);
  }
}