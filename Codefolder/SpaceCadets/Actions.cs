namespace SpaceCadets
{
    public class Actions
    {
        public List<dynamic> GetStudentsWithHighestGPA(List<Student> vedomost)//Проверить
        {
            double highestGPA = vedomost.Max(s => s.Mark);
            var studentsWithHighestGPA = vedomost
                .Where(s => s.Mark == highestGPA)
                .Select(s => new { Cadet = s.Name, GPA = Math.Round(s.Mark, 2) })
                .Distinct()
                .ToList<dynamic>();
            return studentsWithHighestGPA;
        }
        public List<dynamic> CalculateGPAByDiscipline(List<Student> vedomost)//Дописать
        {
            var averageMarksByDiscipline = vedomost
            .GroupBy(s => s.Discipline)
            .Select(g => new JObject(new JProperty(g.Key, Math.Round(g.Average(s => s.Mark), 2))))
            .ToList<dynamic>();

            return averageMarksByDiscipline;
        }
        public List<dynamic> GetBestGroupsByDiscipline(List<Student> vedomost)
        {
            var groups = vedomost
             .GroupBy(d => new { d.Group, d.Discipline })
             .Select(g => new
             {
                Discipline = g.Key.Discipline,
                Group = g.Key.Group,
                GPA = Math.Round(g.Average(d => d.Mark),2)
             })
            .GroupBy(g => g.Discipline)
            .Select(g => g.OrderByDescending(d => d.GPA).First())
            .ToList();
            return groups.Cast<dynamic>().ToList();
        }
   }
}
