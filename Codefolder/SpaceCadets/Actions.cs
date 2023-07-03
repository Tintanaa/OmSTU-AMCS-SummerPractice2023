namespace SpaceCadets
{
    public class Actions
    {
        public List<dynamic> GetStudentsWithHighestGPA(List<Student> vedomost)//Проверить
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
                            MiddleMark = Math.Round(d.Average(s => s.Mark),2)
                        })
                        .ToList()
                })
                .ToList();
            List<object> result = new List<object>();
            var highestGPA = studentDisciplines.Max(s => s.Disciplines.Max(d => d.MiddleMark));
            var studentsWithHighestGPA = studentDisciplines
                .Where(s => s.Disciplines.Any(d => d.MiddleMark == highestGPA))
                .Select(s => new { s.Name, Disciplines = s.Disciplines })
                .ToList();
            return studentsWithHighestGPA.Cast<dynamic>().ToList();
        }

        public List<dynamic> CalculateGPAByDiscipline(List<Student> vedomost)//Дописать
        {
            var disciplines = vedomost
                .GroupBy(d => new { d.Discipline })
                .Select(g => new
                {
                    Discipline = g.Key.Discipline,
                    MiddleMark = Math.Round(g.Average(s => s.Mark),2)
                })
                .ToList();
            //Допиши линк
            return disciplines.Cast<dynamic>().ToList();
        }
        public List<dynamic> GetBestGroupsByDiscipline(List<Student> vedomost)
        {
            var groups = vedomost
             .GroupBy(d => new { d.Group, d.Discipline })
             .Select(g => new
             {
                Group = g.Key.Group,
                Discipline = g.Key.Discipline,
                BestMiddleMark = Math.Round(g.Average(d => d.Mark),2)
             })
            .GroupBy(g => g.Discipline)
            .Select(g => g.OrderByDescending(d => d.BestMiddleMark).First())
            .ToList();
            return groups.Cast<dynamic>().ToList();
        }
   }
}
