using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkSkillBoxCollections
{
    class Company
    {
        #region Поля
        #endregion

        #region Поля-свойства
        public string Name { get; set; }
        public List<Department> Departments { get; set; }
        #endregion

        #region Конструкторы
        public Company(string Name, List<Department> departments)
        {
            this.Name = Name;
            this.Departments = departments;
        }

        public Company(string Name) : this (Name, new List<Department>())
        {
        }

        
        #endregion

        #region Поведение-методы
        public Department AddNewDepartment(string Name)
        {
            Department NewDep = new Department(Name);
            this.Departments.Add(NewDep);
            return NewDep;
        }

        public void AddNewEmployee(string Surname, string Name, byte Age, string DepartmentName, decimal Salary, byte Projects)
        {
            bool depFinded = false;
            if (this.Departments.Count != 0)
            {
                foreach (var department in this.Departments)
                {
                    if (department.Name == DepartmentName)
                    {
                        department.Employees.Add(new Employee(Surname, Name, Age, DepartmentName, Salary, Projects));
                        depFinded = true;
                        break;
                    }
                }
                if (!depFinded)
                {
                        AddNewDepartment(DepartmentName).Employees.Add(new Employee(Surname, Name, Age, DepartmentName, Salary, Projects));
                }
            }
            else AddNewDepartment(DepartmentName).Employees.Add(new Employee(Surname, Name, Age, DepartmentName, Salary, Projects));
        }
        //Печать таблицы
        //Удаление сотрудника
        //Удаление департамента
        #endregion
    }
}
