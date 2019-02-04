using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assignment.Models
{
    public class DefaultModel
    {
        public string Name { get; set; }

        public string Greeting
        {
            get { return string.IsNullOrEmpty(Name) ? "" : $"Hallo {Name}!"; }
        }
    }
}
