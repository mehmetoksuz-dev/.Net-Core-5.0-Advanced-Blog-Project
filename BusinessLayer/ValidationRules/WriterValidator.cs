using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Writer name can not be empty.");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("E-mail can not be empty.");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Password can not be empty.")
                .Matches(@"[A-Z]+").WithMessage("Your password must contain at least one uppercase letter.")
                .Matches(@"[a-z]+").WithMessage("Your password must contain at least one lowercase letter.")
                .Matches(@"[0-9]+").WithMessage("Your password must contain at least one number.");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Min length 2.");
            RuleFor(x => x.WriterName).MaximumLength(5).WithMessage("Max length 50.");
        }
    }
}
