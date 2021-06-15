﻿using FluentValidation;

namespace FluentPOS.Modules.Catalog.Core.Features.Brands.Commands.Validators
{
    public class RegisterBrandCommandValidator : AbstractValidator<RegisterBrandCommand>
    {
        public RegisterBrandCommandValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("The {PropertyName} property cannot be empty.")
                .Length(2, 150).WithMessage("The {PropertyName} property must have between 2 and 150 characters.");
            RuleFor(c => c.Detail)
               .NotEmpty().WithMessage("The {PropertyName} property cannot be empty.")
               .Length(2, 150).WithMessage("The {PropertyName} property must have between 2 and 150 characters.");
        }
    }
}