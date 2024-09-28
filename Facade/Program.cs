using System;
using System.IO;

// Classe para gerenciar operações de arquivos
public class FileManager
{
    public void CreateFile(string fileName, string content)
    {
        File.WriteAllText(fileName, content);
        Console.WriteLine($"Arquivo '{fileName}' criado com sucesso!");
    }

    public void ReadFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            string content = File.ReadAllText(fileName);
            Console.WriteLine($"Conteúdo do arquivo '{fileName}':\n{content}");
        }
        else
        {
            Console.WriteLine($"Arquivo '{fileName}' não encontrado.");
        }
    }

    public void DeleteFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            File.Delete(fileName);
            Console.WriteLine($"Arquivo '{fileName}' deletado com sucesso!");
        }
        else
        {
            Console.WriteLine($"Arquivo '{fileName}' não encontrado.");
        }
    }
}

// Classe Facade
public class FileFacade
{
    private readonly FileManager _fileManager;

    public FileFacade()
    {
        _fileManager = new FileManager();
    }

    public void ExecuteFileOperations(string fileName, string content)
    {
        _fileManager.CreateFile(fileName, content); // Cria o arquivo
        _fileManager.ReadFile(fileName);            // Lê o arquivo
        _fileManager.DeleteFile(fileName);          // Deleta o arquivo
    }
        public void ExecuteOnlyCreateAndRead(string fileName, string content)
    {
        _fileManager.CreateFile(fileName, content); // Cria o arquivo
        _fileManager.ReadFile(fileName);            // Lê o arquivo
    }
}

// Classe Program
class Program
{
    static void Main(string[] args)
    {
        FileFacade fileFacade = new FileFacade();
        Console.WriteLine("Executando operações de arquivo através da Facade:");
        fileFacade.ExecuteFileOperations("exemplo.txt", "Olá! Este é um arquivo de exemplo. 1,2,3 testando!");

        fileFacade.ExecuteOnlyCreateAndRead("exemplo.txt", "Olá! Este é um arquivo de exemplo. ESTE ARQUIVO NÃO SERÁ DELETADO!");

    }
}
