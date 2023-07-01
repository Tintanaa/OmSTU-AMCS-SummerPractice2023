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
        public TaskData JSONParseFilter(string pathtofile)
        {
            JObject o1 = JObject.Parse(File.ReadAllText(pathtofile));
            TaskData taskdata = JsonConvert.DeserializeObject<TaskData>(Convert.ToString(o1));
            return taskdata;
        }
    }
    public class JSONMaker
    {
        public JObject JSONmaker(List<(string?, string?, string?, double)> MaxMiddleMarkStudents)
        {
            var json = JsonConvert.SerializeObject(MaxMiddleMarkStudents);
            JObject o = JObject.Parse(json);
            return o;
        }

        public JObject JSONmaker(List<(string?, int)> MiddleMarkSubjects)
        {
            var json = JsonConvert.SerializeObject(MiddleMarkSubjects);
            JObject o = JObject.Parse(json);
            return o;
        }

        public JObject JSONmaker(List<(string, List<string>)> BestMiddleMarkGroups)
        {
            var json = JsonConvert.SerializeObject(BestMiddleMarkGroups);
            JObject o = JObject.Parse(json);
            return o;
        }
    }
    public class JSONWriter
    {
        public void JSONwriter(List<JObject> objlist, string filepath)
        {
            foreach(var obj in objlist)
            {
                File.WriteAllText(filepath, obj.ToString());
            }
        }
    }
}
