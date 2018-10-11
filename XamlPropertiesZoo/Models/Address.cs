namespace XamlPropertiesZoo.Models
{
  public class Address
  {
    public string StreetName { get; set; }
    public int StreetNr { get; set; }
    public override string ToString() => $"{StreetName} {StreetNr}";
  }
}