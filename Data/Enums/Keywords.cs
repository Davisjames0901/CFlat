namespace Digman.IO.CFlat.Data.Enums
{
  //This is a list of all keywords and statuses. Other files need to match the int value of these key words so we can do conversions later.
  public enum Keywords
  {
    Namespace = 10,
    Interface = 20,
    Class = 30,
    Enum = 40,
    Method = 50,
    If = 60,
    While = 70,
    For = 80,
    Public = 90,
    Private = 100,
    ClassVariable = 110,
    MethodVariable = 120,
    InterfaceMember = 130,
    None = 140,
    NotValid = 150
  }
}