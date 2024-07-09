using Business.DTO.Request;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validation
{
    public class AddProductRequestValidator : AbstractValidator<AddProductRequest>
    {
        public AddProductRequestValidator()
        {
            RuleFor(i => i.UnitPrice).GreaterThanOrEqualTo(0);
            RuleFor(i => i.UnitsInStock).GreaterThanOrEqualTo(0);
            RuleFor(i => i.Name).NotEmpty();
        }
    }
}
