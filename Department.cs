using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkSkillBoxCollections
{
    public class Department
    {
        #region Поля
        private int? employeesCount;
        #endregion

        #region Поля-свойства
        public string Name { get; set; }
        public DateTime CreationDate { get; init; }
        public List<Employee> Employees { get; set; }
        public int EmployeesCount
            {
            get { return Employees.Count; }
            init { employeesCount = value; }
            }
        #endregion

        #region Конструкторы
        public Department()
        {
        }
        public Department(string Name, DateTime CreationDate, List<Employee> Employees, int? EmployeesCount)
        {
            this.Name = Name;
            this.CreationDate = CreationDate;
            this.Employees = Employees;
            this.employeesCount = EmployeesCount;
        }

        public Department(string Nickname) : this (Nickname, DateTime.Now, new List<Employee>(), null)
        { 
        }
        #endregion

        #region Поведение-методы
        //Сортировка сотрудников по дву полям (возраст=>оплата труда)
        #endregion
    }
}
