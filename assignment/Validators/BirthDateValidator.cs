using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assignment.Validators
{
    public class BirthDateValidator : DateRangeValidator
    {
        public override DateTime? Maximum => DateTime.Now;

        public override DateTime? Minimum => null;
    }
}
