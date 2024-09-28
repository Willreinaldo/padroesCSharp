using System;
using System.Collections.Generic;

// Componente base
abstract class FileSystemComponent
{
    public abstract void Display(int indent);
}

// Folha (Arquivo)
class File : FileSystemComponent
{
    public string Name { get; private set; }

    public File(string name)
    {
        Name = name;
    }

    public override void Display(int indent)
    {
        Console.WriteLine(new string(' ', indent) + "- " + Name);
    }
}

// Composto (Pasta)
class Directory : FileSystemComponent
{
    public string Name { get; private set; }
    private List<FileSystemComponent> _children = new List<FileSystemComponent>();

    public Directory(string name)
    {
        Name = name;
    }

    public void Add(FileSystemComponent component)
    {
        _children.Add(component);
    }

    public void Remove(FileSystemComponent component)
    {
        _children.Remove(component);
    }

    public override void Display(int indent)
    {
        Console.WriteLine(new string(' ', indent) + "+ " + Name);
        foreach (var child in _children)
        {
            child.Display(indent + 2);
        }
    }
}

// Cliente
class Program
{
    static void Main(string[] args)
    {
        // Criando uma estrutura de diretórios
        Directory root = new Directory("Root");

        Directory folder1 = new Directory("Folder1");
        folder1.Add(new File("File1.txt"));
        folder1.Add(new File("File2.txt"));

        Directory folder2 = new Directory("Folder2");
        folder2.Add(new File("File3.txt"));

        root.Add(folder1);
        root.Add(folder2);
        root.Add(new File("File4.txt"));

        // Exibindo a estrutura
        root.Display(0);
    }
}
