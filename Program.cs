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
        static void SerializeJSON (string path, Company company)
        {
            var serializerSettings = new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.None };
            string json = JsonConvert.SerializeObject(company, Formatting.Indented, serializerSettings);
            File.WriteAllText(path, json);
        }

        static void DeserializeJSON (string path)
        {
       /*     json = File.ReadAllText();
            Department = JsonConvert.DeserializeObject<Department>(json);*/
        }
        static void Main(string[] args)
        {
            Company company = new Company("Oasis", new List<Department>());
            company.AddNewEmployee("Denis", "BA", 23, "JUNIOR_DEP", 500, 1);
            company.AddNewEmployee("Serg", "Ivanov", 21, "MIDDLE_DEP", 3000, 3);
            company.AddNewEmployee("Vlad", "Petrov", 30, "JUNIOR_DEP", 3000, 3);
            company.AddNewEmployee("Vladik", "Petrovick", 32, "MIDDLE_DEP", 3000, 3);
            SerializeJSON("_test.json", company);
            Console.WriteLine("Hello World!");
        }
    }
}
