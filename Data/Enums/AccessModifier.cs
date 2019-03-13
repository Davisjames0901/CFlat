namespace Digman.IO.CFlat.Data.Enums
{
  // this is a list of access modifiers or modifier status
  public enum AccessModifier
  {
    Public = 90,
    Private = 100,


    //These are a bit different they dont represent a modifier they represent the absence of one or the validity of having one
    None = 140,
    NotValid = 150
  }
}