using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkSkillBoxCollections
{
    public class Employee
    {
        #region Поля
        static int NumOfEmployees;
        #endregion

        #region Cвойства
        public int ID { get; init; }
        public string Surname { get; set; } = null;
        public string Name { get; set; } = null;
        public byte Age { get; set; } = 0;
        public string DepartmentName { set; get; } = null;
        public decimal Salary { get; set; } = 0;
        public byte Projects { get; set; } = 0;
        #endregion

        #region Конструкторы
        public Employee(string Surname, string Name, byte Age, string DepartmentName, decimal Salary, byte Projects)
        {
            NumOfEmployees++;
            this.ID = NumOfEmployees;
            this.Surname = Surname;
            this.Name = Name;
            this.Age = Age;
            this.DepartmentName = DepartmentName;
            this.Salary = Salary;
            this.Projects = Projects;
        }

        public Employee(string Surname, string Name) : this(Surname, Name, default, default, default, default)
        {
        }

        public Employee()
        {
        }
        #endregion

        #region Поведение-методы

        //Печать сотрудника
      
        #endregion
    }
}
