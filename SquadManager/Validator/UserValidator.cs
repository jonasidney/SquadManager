using FluentValidation;
using SquadManager.Models;

namespace SquadManager.Validator
{
    public class UserValidator : AbstractValidator<UserViewModel>
    {
        public UserValidator()
        {
            RuleFor(user => user.Email).NotNull().WithMessage("Campo e-mail nao pode ser vazio");
            RuleFor(user => user.Email).EmailAddress().WithMessage("Digite um e-mail valido");
            RuleFor(user => user.Password).NotNull().WithMessage("Campo senha nao pode ser vazio");
        }
    }
}
