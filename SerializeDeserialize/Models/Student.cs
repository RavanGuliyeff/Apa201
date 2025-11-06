using System.Xml;

namespace SerializeDeserialize.Models;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Group Group { get; set; }
}
