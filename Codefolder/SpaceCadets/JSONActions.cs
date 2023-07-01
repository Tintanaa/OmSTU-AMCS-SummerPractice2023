using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceCadets
{   
    public class JSONParser
    {
        public void JSONParseFilter(string pathtofile)
        {
            using (StreamReader file = File.OpenText(pathtofile))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject o2 = (JObject)JToken.ReadFrom(reader);
            }
            /*
             * Достать все данные (желательно как в питоне список словарей и тдтп
             * Отфильтровать их и занести в ведомость
             * Examfiller
             */
        }
    
    }
    public class JSONMaker
    {
        public JObject JSONmaker(List<(string?, string?, string?, double)> MaxMiddleMarkStudents)
        {

        }

        public JObject JSONmaker(List<(string?, int)> MiddleMarkSubjects)
        {

        }

        public JObject JSONmaker(List<(string, List<string>)> BestMiddleMarkGroups)
        {

        }
    }
    public class JSONWriter
    {
        public void JSONwriter(List<JObject> objlist, string filepath)
        {
            File.WriteAllText(filepath,objlist);
            /*
             * ПОЖАЛУЙСТА СПИСОК JOBJECT по LINQ перебери и занеси по файлам с названием одним и тем же
             */
        }
    }
}
