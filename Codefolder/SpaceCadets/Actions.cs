using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SpaceCadets
{
    public class Actions
    {
        public List<object> GetStudentsWithHighestGPA(List<Student> vedomost)//Проверить
        {
            var studentDisciplines = vedomost
                .GroupBy(s => s.Name)
                .Select(g => new
                {
                    Name = g.Key,
                    Disciplines = g.GroupBy(s => s.Discipline)
                        .Select(d => new
                        {
                            Discipline = d.Key,
                            MiddleMark = d.Average(s => s.Mark)
                        })
                        .ToList()
                })
                .ToList();
            List<object> result = new List<object>();
            foreach (var student in studentDisciplines)
            {
                foreach (var discipline in student.Disciplines)
                {
                    result.Add(new
                    {
                        Name = student.Name,
                        Discipline = discipline.Discipline,
                        MiddleMark = discipline.MiddleMark
                    });
                }
            }
            return result;
        }
        public List<(string?, int)> CalculateGPAByDiscipline(List<Student> vedomost)//Дописать
       {
            var disciplines = vedomost.GroupBy(d => d.Discipline);
            foreach (var discipline in disciplines)
            {
                Console.WriteLine("Discipline: " + discipline.Key);
                Console.WriteLine("Middle Mark: " + discipline.Average(d => d.Mark));
                Console.WriteLine();
            }
            //Допиши линк
            return;
        }
       public List<(string group, string discipline, double bestMiddlemark)> GetBestGroupsByDiscipline(List<Student> vedomost)
       {
            var groups = vedomost
             .GroupBy(d => new { d.Group, d.Discipline})
             .Select(g => new
             {
                 group = g.Key.Group,
                 discipline = g.Key.Discipline,
                 middlemark = g.Average(d => d.Mark)
             })
             .ToList();
            //Допиши линк для того чтобы только лучшие выводились
            return groups.Select(g => (g.group, g.discipline, g.middlemark)).ToList();
        }
   }
}
