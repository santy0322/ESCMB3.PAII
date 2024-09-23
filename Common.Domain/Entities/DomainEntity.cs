using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain.Entities

{
    public interface IValidate
    {
        bool IsValid();
        IList<ValidationFailure> GetErrors();
    }


    public abstract class DomainEntity<TEntity, TValidator> : IValidate
        where TEntity : DomainEntity<TEntity, TValidator>
        where TValidator : IValidator<TEntity>, new()
    {

        protected TValidator validator;
        protected ValidationResult ValidationResult;

        protected DomainEntity()
        {
            validator = new TValidator();
        }

        protected void Validate()
        {
            ValidationResult = Validator.Validate((TEntity)this);
        }

        public IList<ValidationFailure> GetErrors()
        {
            Validate();
            return ValidationResult.Errors;
        }

        public bool IsValid()
        {
            Validate();
            return ValidationResult.IsValid;
        }
    }
}
