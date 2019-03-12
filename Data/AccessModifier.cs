namespace Digman.IO.CFlat.Data
{
  // this is a list of access modifiers or modifier status
  public enum AccessModifier
  {
    Public,
    Private,


    //These are a bit different they dont represent a modifier they represent the absence of one or the validity of having one
    None,
    NotValid
  }
}