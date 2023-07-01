namespace SpaceCadets
{   
    public class Actions
    {
        public List<(string?, string?, string?, double)> MaxMiddleMarkStudents(List<(string?, string?, string?, int)> Examvedomost)
        {
            /*
             * Выдать список студентов с максимальным средним баллом (средний балл double до 0,01 сотой)
             */
        }
        public List<(string?, int)> MiddleMarkSubjects(List<(string?, string?, string?, int)> Examvedomost)
        {
            /*
             * Выдать список предметов со средним баллом
             */
        }
        public List<(string, List<string>)> BestMiddleMarkGroups(List<(string?, string?, string?, int)> Examvedomost)
        {
            /*
             * Выдать список лучшая группа-средний балл по предмету
             */
        }
    }
}
