﻿using System;
using System.Collections.Generic;
using System.CommandLine.Invocation;
using System.CommandLine;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.CommandLine.NamingConventionBinder;

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
            Console.WriteLine(taskdata.Data);
            switch (taskdata.TaskName)
            {
                case "GetStudentsWithHighestGPA":
                    {
                        var result = actions.GetStudentsWithHighestGPA(taskdata.Data);
                        Console.WriteLine(result[0]);
                        JObject js = new JObject();
                        js = maker.JSONmaker(result);
                        writer.JSONwriter(js, filepathwrite);
                        break;
                    }
                case "CalculateGPAByDiscipline":
                    {
                        var result = actions.CalculateGPAByDiscipline(taskdata.Data);
                        JObject js = new JObject();
                        js = maker.JSONmaker(result);
                        writer.JSONwriter(js, filepathwrite);
                        break;
                    }
                case "GetBestGroupsByDiscipline":
                    {
                        var result = actions.GetBestGroupsByDiscipline(taskdata.Data);
                        JObject js = new JObject();
                        js = maker.JSONmaker(result);
                        writer.JSONwriter(js, filepathwrite);
                        break;
                    }
            }
        }
    }
}
