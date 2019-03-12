namespace Digman.IO.CFlat.Types
{
  public interface IMethod : IMember
  {
    string Body { get; set; }

    TypeReference[] Parameters { get; set; }
  }
}