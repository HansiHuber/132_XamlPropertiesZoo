using System.Collections.Generic;
using System.Linq;

namespace XamlPropertiesZoo.Models
{
  public class Zoo
  {
    public Location Location { get; set; }
    public List<Animal> Animals { get; set; } = new List<Animal>();
    public override string ToString()=> $"Zoo {Location} mit Tieren: {string.Join("; ", Animals)}";
  }

}
