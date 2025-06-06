﻿using Clean.Architecture.Application.Users.Command;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Application.Users.Valodattions
{
    public class CreateUserValidator : AbstractValidator<AddUserCommand>
    
    {
        public CreateUserValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage(" نام نمیتواند خالی باشد")
             .MinimumLength(3).WithMessage("حداقل ۳ کاراکتر");

            RuleFor(x => x.Family)
                .NotEmpty().WithMessage("ایمیل الزامی است")
                .EmailAddress().WithMessage("ایمیل نامعتبر است");

        }
    }
}
