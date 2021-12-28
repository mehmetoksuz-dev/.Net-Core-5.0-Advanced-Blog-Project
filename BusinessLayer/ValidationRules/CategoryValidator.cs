﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Category name can not be empty!");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Category description name can not be empty!");
            RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("Category name can not be more than 50 chars!");
            RuleFor(x => x.CategoryName).MinimumLength(2).WithMessage("Category name can not be less than 2 chars!");

        }
    }
}
