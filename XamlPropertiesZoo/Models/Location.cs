namespace XamlPropertiesZoo.Models
{
  public class Location
  {
    public string City { get; set; }
    public Address Address { get; set; }

    public override string ToString()=> $"{City} {Address}";

  }
}