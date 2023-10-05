using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp2
{
  public class Person
  {
    public string LastName { get; set; } = "Undefined";
    public string City { get; set; } = "Undefined";
    public int Age { get; set; } = 0;

    public Person() { }
    public Person(string LastName, string City, int Age)
    {
      this.City = City;
      this.LastName = LastName;
      this.Age = Age;
    }
  }
}
