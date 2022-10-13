using Cooperchip.ITDeveloper.Domain.Entities;
using FluentValidation;
using FluentValidation.Results;

namespace Cooperchip.ITDeveloper.Domain.Mensageria.Notifications
{
    public abstract class BaseService
    {
        private readonly INotificador _notificador;

        protected BaseService(INotificador notification)
        {
            _notificador=notification;
        }


        protected void Notificar(ValidationResult validationResult)
        {
            foreach (var erro in validationResult.Errors)
            {
                Notificar(erro.ErrorMessage);
            }
        }

        protected void Notificar(string mensagem)
        {
            _notificador.Handle(new Notificacao(mensagem));
        }

        protected bool ExecutarValidacao<Tval, T>(Tval validacao, T entidade) where Tval : AbstractValidator<T> where T : EntityBase
        {
            var validator = validacao.Validate(entidade);
            if (validator.IsValid) return true;

            Notificar(validator);
            return false;
        }
    }
}
