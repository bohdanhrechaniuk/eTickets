﻿using eTickets.Data.ViewModels;
using FluentValidation;
using System.Text.RegularExpressions;

namespace eTickets.Data.Validation
{
    public class PasswordValidator1 : AbstractValidator<RegisterVM>
    {
        public PasswordValidator1()
        {
            RuleFor(x => x.Password)
    .Length(5, 15)
    .Must(HasValidPassword);
        }
        private bool HasValidPassword(string pw)
        {
            var lowercase = new Regex("[a-z]+");
            var uppercase = new Regex("[A-Z]+");
            var digit = new Regex("(\\d)+");
            var symbol = new Regex("(\\W)+");

            return (lowercase.IsMatch(pw) && uppercase.IsMatch(pw) && digit.IsMatch(pw) && symbol.IsMatch(pw));
        }
    }
}
