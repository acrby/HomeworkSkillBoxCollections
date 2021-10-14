using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using Newtonsoft.Json;


namespace HomeworkSkillBoxCollections
{
    class Program
    {
        static void SerializeJSON (string path, Employee employee)
        {
            string json = JsonConvert.SerializeObject(employee);
            File.WriteAllText(path, json);
        }

        static void DeserializeJSON (string path)
        {
        
        }
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            SerializeJSON("_test.json", employee);
            Console.WriteLine("Hello World!");
        }
    }
}
