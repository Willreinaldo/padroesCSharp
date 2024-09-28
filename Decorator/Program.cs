using System;

// Interface base para mensagens
public interface IMessage
{
    void PrintMessage();
}

// Classe concreta que implementa uma mensagem simples
public class SimpleMessage : IMessage
{
    private readonly string _message;

    public SimpleMessage(string message)
    {
        _message = message;
    }

    public void PrintMessage()
    {
        Console.WriteLine(_message);
    }

    public override string ToString() => _message;
}

// Decorator base que implementa a interface de mensagem
public abstract class MessageDecorator : IMessage
{
    protected IMessage _message;

    protected MessageDecorator(IMessage message)
    {
        _message = message;
    }

    public virtual void PrintMessage()
    {
        _message.PrintMessage();
    }
}

// Decorator que adiciona uma customização para Email
public class EmailMessageDecorator : MessageDecorator
{
    public EmailMessageDecorator(IMessage message) : base(message) { }

    public override void PrintMessage()
    {
        PrintHeader("Mensagem para Email:");
        base.PrintMessage();
        Console.ResetColor();
    }

    private void PrintHeader(string header)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(header);
    }
}

// Decorator que adiciona um aviso à mensagem
public class WarningMessageDecorator : MessageDecorator
{
    public WarningMessageDecorator(IMessage message) : base(message) { }

    public override void PrintMessage()
    {
        PrintHeader("⚠️ Aviso:");
        base.PrintMessage();
        Console.ResetColor();
    }

    private void PrintHeader(string header)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(header);
    }
}

// Decorator que adiciona uma moldura à mensagem
public class FramedMessageDecorator : MessageDecorator
{
    public FramedMessageDecorator(IMessage message) : base(message) { }

    public override void PrintMessage()
    {
        PrintFrame();
        base.PrintMessage();
        PrintFrame();
    }

    private void PrintFrame()
    {
        Console.WriteLine(new string('-', 30));
    }
}

// Classe Program
class Program
{
    static void Main(string[] args)
    {
        // Mensagem simples
        IMessage simpleMessage = new SimpleMessage("Olá! Este é um exemplo de mensagem.");
        Console.WriteLine("Mensagem original:");
        simpleMessage.PrintMessage();
        Console.WriteLine();

        // Mensagem customizada para Email
        IMessage emailMessage = new EmailMessageDecorator(simpleMessage);
        Console.WriteLine("Mensagem customizada:");
        emailMessage.PrintMessage();
        Console.WriteLine();

        // Mensagem com aviso
        IMessage warningMessage = new WarningMessageDecorator(simpleMessage);
        Console.WriteLine("Mensagem de aviso:");
        warningMessage.PrintMessage();
        Console.WriteLine();

        // Mensagem com moldura
        IMessage framedMessage = new FramedMessageDecorator(simpleMessage);
        Console.WriteLine("Mensagem com moldura:");
        framedMessage.PrintMessage();
        Console.WriteLine();

        // Combinando decoradores: Moldura + Aviso
        IMessage framedWarningMessage = new FramedMessageDecorator(new WarningMessageDecorator(simpleMessage));
        Console.WriteLine("Mensagem com moldura e aviso:");
        framedWarningMessage.PrintMessage();
        Console.WriteLine();
    }
}
