using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_2___Werknemer.Entities
{
    public class Bediende : Werknemer
    {
        public Bediende(string firstName, string lastName, char type, decimal hourlyWage, decimal hoursWorked)
            : base(firstName, lastName, type)
        {
            HourlyWage = hourlyWage;
            HoursWorked = hoursWorked;
        }

        public decimal HourlyWage { get; set; }
        public decimal HoursWorked { get; set; }

        public override decimal Salary() => HourlyWage * HoursWorked;
        public override string Info()
        {
            string naam = $"{FirstName} {LastName}";
            return $"{Type} | {naam,-25} wedde: {HourlyWage:c} x {HoursWorked} = {Salary():c}";
        }
    }
}
