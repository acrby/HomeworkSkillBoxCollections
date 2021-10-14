using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkSkillBoxCollections
{
    public abstract class Department
    {
        #region Поля

        #endregion

        #region Поля-свойства
        public abstract string Name { get; set; }
        public abstract DateTime CreationDate { get; init; }
        public abstract List<Employee> Employees { get; set; }

        //Кол-во сотрудников (int) усложненне поле. Обявлять через private и при get выводить всех сотрудников.
        #endregion

        #region Конструкторы
        public Department(string Name, DateTime CreationDate, List<Employee> Employees)
        {
            this.Name = Name;
            this.CreationDate = CreationDate;
            this.Employees = Employees;
        }

        public Department()
        { 
        }
        #endregion

        #region Поведение-методы
        //Добавление департамента
        //Удаление департамента
        #endregion
    }
}
