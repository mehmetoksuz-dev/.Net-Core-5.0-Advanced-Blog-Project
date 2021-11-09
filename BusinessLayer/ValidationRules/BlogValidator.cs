using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog title can not be empty!");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog content can not be empty!");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog image can not be empty!");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("The blog title must be less than 150 characters!");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("The blog title must be more than 5 characters!");
        }
    }
}
