using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SpaceCadets;

public class Student
{
    public string? Name { get; set; }
    public string? Group { get; set; }
    public string? Discipline { get; set; }
    public int Mark { get; set; }
}
public class TaskData
{
    public string? TaskName { get; set; }
    public List<Student> Data { get; set; }
}



