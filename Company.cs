using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkSkillBoxCollections
{
    public class Company
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
            Departments = departments;
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
            if (this.Departments.Count != 0)
            {
                foreach (var department in this.Departments)
                {
                    if (department.Name == DepartmentName)
                    {
                        department.Employees.Add(new Employee(Surname, Name, Age, DepartmentName, Salary, Projects));
                        break;
                    }
                    else
                    {
                        AddNewDepartment(DepartmentName).Employees.Add(new Employee(Surname, Name, Age, DepartmentName, Salary, Projects));
                        break;
                    }
                }
            }
            else AddNewDepartment(DepartmentName).Employees.Add(new Employee(Surname, Name, Age, DepartmentName, Salary, Projects));
        }
        //Печать таблицы
        //Сортировка таблицы (по 1му, 2м, 3м критериям(для отдела))
        //Удаление сотрудника
        //Удаление департамента
        #endregion
    }
}
