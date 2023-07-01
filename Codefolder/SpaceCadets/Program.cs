using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SpaceCadets
{
    public class Program
    {
        static void Main(string[] args)
        {
            JSONParser parser = new JSONParser();
            JSONMaker maker = new JSONMaker();
            JSONWriter writer = new JSONWriter();
            Actions actions = new Actions();
            string filepathread = args[0];
            string filepathwrite = args[1];
            var taskdata = parser.JSONParseFilter(filepathread);
            switch(taskdata.TaskName)
            {
                case "GetStudentsWithHighestGPA":
                    {
                        var result = actions.GetStudentsWithHighestGPA(taskdata.Vedomost);
                        break;
                    }
                case "CalculateGPAByDiscipline":
                    {
                        var result = actions.CalculateGPAByDiscipline(taskdata.Vedomost);
                        break;
                    }
                case "GetBestGroupsByDiscipline":
                    {
                        var result = actions.GetBestGroupsByDiscipline(taskdata.Vedomost);
                        break;
                    }
            }    


        }
    }
}
