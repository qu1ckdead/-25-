using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR17
{
    public enum EmploymentStatus
    {
        Active,
        OnLeave,
        Terminated
    }

    public class Employee
    {
        public string Name { get; set; }
        public DateTime? HireDate { get; set; }
        public EmploymentStatus Status { get; set; }

        public int GetYearsWorked()
        {
            if (!HireDate.HasValue)
                return -1;

            var today = DateTime.Today;
            var years = today.Year - HireDate.Value.Year;

            if (HireDate.Value.Date > today.AddYears(-years))
                years--;

            return years;
        }

        public override string ToString()
        {
            string hireInfo = HireDate.HasValue
                ? $"Принят: {HireDate.Value:dd.MM.yyyy}, стаж: {GetYearsWorked()} лет"
                : "стаж: не указан";

            return $"{Name}, статус: {Status}, {hireInfo}";
        }
    }
}
