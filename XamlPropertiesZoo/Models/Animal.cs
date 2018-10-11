using System.Collections.Generic;
using System.Linq;

namespace XamlPropertiesZoo.Models
{
  public class Animal
  {
    public string Name { get; set; }
    public string Species { get; set; }
    public List<int> Ages { get; set; } = new List<int>();

    public override string ToString()
    {
      string sAges = string.Join(",", Ages.Select(x => $"{x}"));
      return $"{Species} {Name} [{sAges}]";
    }
  }
}