using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_2___Werknemer.Entities
{
    public class Kader : Werknemer
    {
        public Kader(string firstName, string lastName, char type, decimal wage)
            : base(firstName, lastName, type)
        {
            Wage = wage;
        }

        public decimal Wage { get; set; }

        public override decimal Salary() => Wage;
        public override string Info()
        {
            string naam = $"{FirstName} {LastName}";
            return $"{Type} | {naam,-25} wedde: {Wage:c}";
        }
    }
}
