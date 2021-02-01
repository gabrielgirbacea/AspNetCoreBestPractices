using FluentValidation;
using JurisTempus.Data.Entities;
using JurisTempus.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JurisTempus.Validators
{
  public class CaseViewModelValidator : AbstractValidator<CaseViewModel>
  {
    public CaseViewModelValidator()
    {
      RuleFor(c => c.FileNumber).NotEmpty().MinimumLength(5);
      RuleFor(c => c.Status).IsInEnum().NotEqual(CaseStatus.Invalid);
    }
  }
}
