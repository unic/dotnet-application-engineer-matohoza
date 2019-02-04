using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using assignment.Validators;

namespace assignment.Models
{
    public class DefaultModel
    {
        public string Name { get; set; }

        [BirthDateValidator]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        public string Greeting
        {
            get { return string.IsNullOrEmpty(Name) ? "" : $"Hallo {Name}!"; }
        }
    }
}
