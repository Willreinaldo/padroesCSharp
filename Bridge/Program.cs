using System;

// Implementação da interface de plataforma
interface IPlatform
{
    void ShowDialog(string message);
    void ShowWarning(string message);
    void ShowError(string message);
}

// Implementação da plataforma Windows
class WindowsPlatform : IPlatform
{
    public void ShowDialog(string message)
    {
        Console.WriteLine($"[Windows] Diálogo: {message}");
    }

    public void ShowWarning(string message)
    {
        Console.WriteLine($"[Windows] Aviso: {message}");
    }

    public void ShowError(string message)
    {
        Console.WriteLine($"[Windows] Erro: {message}");
    }
}

// Implementação da plataforma Linux
class LinuxPlatform : IPlatform
{
    public void ShowDialog(string message)
    {
        Console.WriteLine($"[Linux] Diálogo: {message}");
    }

    public void ShowWarning(string message)
    {
        Console.WriteLine($"[Linux] Aviso: {message}");
    }

    public void ShowError(string message)
    {
        Console.WriteLine($"[Linux] Erro: {message}");
    }
}

// Implementação da plataforma Mac
class MacPlatform : IPlatform
{
    public void ShowDialog(string message)
    {
        Console.WriteLine($"[Mac] Diálogo: {message}");
    }

    public void ShowWarning(string message)
    {
        Console.WriteLine($"[Mac] Aviso: {message}");
    }

    public void ShowError(string message)
    {
        Console.WriteLine($"[Mac] Erro: {message}");
    }
}

// Abstração
abstract class Window
{
    protected IPlatform _platform;

    protected Window(IPlatform platform)
    {
        _platform = platform;
    }

    public abstract void Show(string message);
}

// Janela de Diálogo
class DialogWindow : Window
{
    public DialogWindow(IPlatform platform) : base(platform) { }

    public override void Show(string message)
    {
        _platform.ShowDialog(message);
    }
}

// Janela de Aviso
class WarningWindow : Window
{
    public WarningWindow(IPlatform platform) : base(platform) { }

    public override void Show(string message)
    {
        _platform.ShowWarning(message);
    }
}

// Janela de Erro
class ErrorWindow : Window
{
    public ErrorWindow(IPlatform platform) : base(platform) { }

    public override void Show(string message)
    {
        _platform.ShowError(message);
    }
}

// Cliente
class Program
{
    static void Main(string[] args)
    {
        // Simulação de uso nas diferentes plataformas
        IPlatform windows = new WindowsPlatform();
        IPlatform linux = new LinuxPlatform();
        IPlatform mac = new MacPlatform();

        // Janela de Diálogo
        Window dialogWin = new DialogWindow(windows);
        dialogWin.Show("Este é um diálogo no Windows.");

        Window dialogLin = new DialogWindow(linux);
        dialogLin.Show("Este é um diálogo no Linux.");

        Window dialogMac = new DialogWindow(mac);
        dialogMac.Show("Este é um diálogo no Mac.");

        // Janela de Aviso
        Window warningWin = new WarningWindow(windows);
        warningWin.Show("Este é um aviso no Windows.");

        Window warningLin = new WarningWindow(linux);
        warningLin.Show("Este é um aviso no Linux.");

        Window warningMac = new WarningWindow(mac);
        warningMac.Show("Este é um aviso no Mac.");

        // Janela de Erro
        Window errorWin = new ErrorWindow(windows);
        errorWin.Show("Este é um erro no Windows.");

        Window errorLin = new ErrorWindow(linux);
        errorLin.Show("Este é um erro no Linux.");

        Window errorMac = new ErrorWindow(mac);
        errorMac.Show("Este é um erro no Mac.");
    }
}
