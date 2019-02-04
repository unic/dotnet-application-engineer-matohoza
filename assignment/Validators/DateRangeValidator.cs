using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace assignment.Validators
{
    public abstract class DateRangeValidator : ValidationAttribute
    {
        public abstract DateTime? Minimum { get; }

        public abstract DateTime? Maximum { get; }

        public override bool IsValid(object value)
        {
            if (!(value is DateTime))
            {
                throw new InvalidOperationException("Do not use me on other than DateTime");
            }

            var val = (DateTime)value;

            if (Minimum.HasValue && val < Minimum)
            {
                return false;
            }

            if (Maximum.HasValue && val > Maximum)
            {
                return false;
            }

            return true;
        }
    }
}
