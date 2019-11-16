using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExaminationManagement.Functions.Validation
{
    class RegexValidator : BaseValidator
    {
        //private string pattern;
        //public string Pattern
        //{
        //    get { return pattern; }
        //    set { pattern = value; }
        //}

        public override bool Validate()
        {
            if (ControlToValidate.Text.Trim().Length == 0)
                return true;
            Regex regex = new Regex(Pattern);
            return regex.IsMatch(ControlToValidate.Text);
        }
    }
}
