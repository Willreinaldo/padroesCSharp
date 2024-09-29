using System;

// Interface do serviço real
public interface IUserService
{
    void DisplayUserInfo(string userId);
}

// Classe real que implementa o serviço
public class RealUserService : IUserService
{
    public void DisplayUserInfo(string userId)
    {
        Console.WriteLine($"Acesso ADMIN: Exibindo informações do usuário: {userId}");
        // Simulação de uma operação que acessa um banco de dados ou serviço
    }
}

// Proxy que controla o acesso ao serviço real
public class UserServiceProxy : IUserService
{
    private readonly RealUserService _realUserService;
    private readonly string _currentUserRole;

    public UserServiceProxy(string currentUserRole)
    {
        _realUserService = new RealUserService();
        _currentUserRole = currentUserRole;
    }

    public void DisplayUserInfo(string userId)
    {
        if (HasAccess())
        {
            _realUserService.DisplayUserInfo(userId);
        }
        else
        {
            Console.WriteLine("Acesso negado: Você não tem permissão para visualizar as informações do usuário.");
        }
    }

    private bool HasAccess()
    {
        // Simulação de controle de acesso baseado na função do usuário
        return _currentUserRole == "Admin";
    }
}

// Classe Cliente
class Program
{
    static void Main(string[] args)
    {
        // Simulação de um usuário admin
        IUserService adminService = new UserServiceProxy("Admin");
        adminService.DisplayUserInfo("123");

        // Simulação de um usuário comum
        IUserService userService = new UserServiceProxy("User");
        userService.DisplayUserInfo("456");
    }
}
