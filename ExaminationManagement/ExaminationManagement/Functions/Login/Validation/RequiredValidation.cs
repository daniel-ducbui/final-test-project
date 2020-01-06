using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Functions.Validation
{
    class RequiredValidation : BaseValidator
    {
        public RequiredValidation()
        {
            // Error message when user have wrong input
            ErrorMessage = "Required field!";
        }
        public override bool Validate()
        {
            // Your required here
            return ControlToValidate.Text.Length > 0;
        }
    }
}
