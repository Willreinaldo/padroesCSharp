using System;
using System.Collections.Generic;

// Flyweight (Círculo)
class Circle
{
    public string Color { get; private set; }
    public int Radius { get; private set; }

    public Circle(string color)
    {
        Color = color;
        Radius = 5; // Tamanho fixo para simplificar o exemplo
    }

    public void Draw(int x, int y)
    {
        Console.WriteLine($"Círculo {Color} desenhado na posição ({x}, {y}) com raio {Radius}");
    }
}

// Flyweight Factory (Fábrica de Círculos)
class CircleFactory
{
    private Dictionary<string, Circle> _circles = new Dictionary<string, Circle>();

    public Circle GetCircle(string color)
    {
        if (!_circles.ContainsKey(color))
        {
            _circles[color] = new Circle(color);
            Console.WriteLine($"Criando um círculo de cor: {color}");
        }
        return _circles[color];
    }
}

// Cliente
class Program
{
    static void Main(string[] args)
    {
        CircleFactory factory = new CircleFactory();

        // Reutilizando círculos da mesma cor
        Circle circle1 = factory.GetCircle("vermelho");
        circle1.Draw(10, 20);

        Circle circle2 = factory.GetCircle("azul");
        circle2.Draw(15, 25);

        Circle circle3 = factory.GetCircle("vermelho");
        circle3.Draw(30, 40);

        Circle circle4 = factory.GetCircle("azul");
        circle4.Draw(50, 60);

        Circle circle5 = factory.GetCircle("verde");
        circle5.Draw(70, 80);
    }
}
