using Cooperchip.ITDeveloper.Domain.Entities;
using FluentValidation;

namespace Cooperchip.ITDeveloper.Domain.Mensageria.Validations
{
    public class MuralValidation : AbstractValidator<Mural>
    {
        /// <summary>
        /// TODO: RegulrExpression em Email para data
        /// </summary>
        public MuralValidation()
        {
            RuleFor(x => x.Id).NotNull().WithMessage("O campo '{PropertyName}' é obrigatório!");
            RuleFor(x => x.Data).NotNull().WithMessage("O campo '{PropertyName}' é obrigatório!");

            RuleFor(x => x.Titulo)
                .NotEmpty().WithMessage("O campo '{PropertyName}' é obrigatório!")
                .Length(5, 30).WithMessage("O campo '{PropertyName}' precisa estar entre {MinLength} e {MaxLength} caracteres!");


            RuleFor(x => x.Aviso)
                .NotEmpty().WithMessage("O campo '{PropertyName}' é obrigatório!")
                .Length(5, 135).WithMessage("O campo '{PropertyName}' precisa estar entre {MinLength} e {MaxLength} caracteres!");


            RuleFor(x => x.Autor)
                .NotEmpty().WithMessage("O campo '{PropertyName}' é obrigatório!")
                .Length(2, 28).WithMessage("O campo '{PropertyName}' precisa estar entre {MinLength} e {MaxLength} caracteres!");


            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("O campo '{PropertyName}' é obrigatório!")
                .Length(5, 255).WithMessage("O campo '{PropertyName}' precisa estar entre {MinLength} e {MaxLength} caracteres!");

        }
    }
}
