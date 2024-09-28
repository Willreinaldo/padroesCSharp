using System;
using System.Text.RegularExpressions;

// Interface esperada pelo cliente
public interface IEmailValidator
{
    bool IsValidEmail(string email);
}

// Interface da classe legada
public interface ILegacyValidator
{
    bool Validate(string email);
}

// Classe legada que implementa a interface legada
public class LegacyEmailValidator : ILegacyValidator
{
    public bool Validate(string email)
    {
        //Regex para validação
        return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
    }
}

// Adapter que converte ILegacyValidator em IEmailValidator
public class EmailValidatorAdapter : IEmailValidator
{
    private readonly ILegacyValidator _legacyValidator;

    public EmailValidatorAdapter(ILegacyValidator legacyValidator)
    {
        _legacyValidator = legacyValidator;
    }

    public bool IsValidEmail(string email)
    {
        return _legacyValidator.Validate(email);
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Cliente espera um IEmailValidator
        IEmailValidator emailValidator = new EmailValidatorAdapter(new LegacyEmailValidator());

        // Testando o validador
        string email1 = "teste@exemplo.com";
        string email2 = "email-invalido";

        Console.WriteLine($"Validando '{email1}': {emailValidator.IsValidEmail(email1)}"); // True
        Console.WriteLine($"Validando '{email2}': {emailValidator.IsValidEmail(email2)}"); // False
    }
}