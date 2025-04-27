using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_2___Werknemer.Entities
{
    public class Commissie : Werknemer
    {
        private decimal _comm;

        public decimal Wage { get; set; }
        public decimal CommissionPercentage { get; set; }
        public decimal Turnover { get; set; }

        public Commissie(string firstName, string lastName, char type, decimal wage, decimal percentage, decimal turnover)
            : base(firstName, lastName, type)
        {
            Turnover = turnover;
            CommissionPercentage = percentage;
            _comm = turnover * percentage / 100;
            Wage = wage;
        }

        public override decimal Salary() => Wage + _comm;
        public override string Info()
        {
            string naam = $"{FirstName} {LastName}";
            return $"{Type} | {naam,-15} wedde (incl. comm.): {Salary:c} + {_comm:c} = {Salary():c}";
        }
    }
}
