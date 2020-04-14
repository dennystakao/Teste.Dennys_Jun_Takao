using FluentValidation;
using System;
using Teste.Dennys_Jun_Takao.Domain.Entities;

namespace Teste.Dennys_Jun_Takao.Service.Validators
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(c => c)
                    .NotNull()
                    .OnAnyFailure(x =>
                    {
                        throw new ArgumentNullException("Objeto não encontrado.");
                    });

            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Nessesário informar Nome.")
                .NotNull().WithMessage("Nessesário informar Nome.");

            RuleFor(c => c.SobreNome)
                .NotEmpty().WithMessage("Nessesário informar SobreNome.")
                .NotNull().WithMessage("Nessesário informar SobreNome.");

        }
    }
}
