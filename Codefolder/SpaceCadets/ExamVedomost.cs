using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SpaceCadets;

public class ExamVedomost
{
    public string? Name;
    public string? Group;
    public string? Discipline;
    public int Mark;
    public List<(string?,string?,string?,int)> Vedomost = new List<(string?, string?, string?,int)> ();
    public void Examfiller(string? name, string? group, string? discipline, int mark)
    {
        ExamVedomost vedomost = new ExamVedomost();
        vedomost.Vedomost.Add((name, group, discipline, mark));
    }
}



