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

        #endregion

        #region Cвойства
        public string Surname { get; set; }
        public string Name { get; set; }
        public byte Age { get; set; }
        public Department Department { get; set; }
        public byte ID { get; init; }
        public decimal Salary { get; set; }
        public byte Projects { get; set; }
        #endregion

        #region Конструкторы
        public Employee(string Surname, string Name, byte Age, Department Department, byte ID, decimal Salary, byte Projects)
        {
            this.Surname = Surname;
            this.Name = Name;
            this.Age = Age;

            if (this.Department.Name.Contains(Department.Name))
                this.Department.Name = Department.Name;
            else
                Department dep = new Department(Department.Name, DateTime.Now, Employees);

            this.ID = ID;
            this.Salary = Salary;
            this.Projects = Projects;
        }

        public Employee()
        {
        }
        #endregion

        #region Поведение-методы
        //Печать сотрудника
        //Добавление сотрудника
        //Удаление сотрудника
        #endregion
    }
}
