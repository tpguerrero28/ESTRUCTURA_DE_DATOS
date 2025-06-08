using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hola, ESTRUCTURA DE DATOS!");

        // Crear un objeto Circulo con radio 5
        Circulo miCirculo = new Circulo(5);
        Console.WriteLine($"Área del círculo: {miCirculo.CalcularArea()}");
        Console.WriteLine($"Perímetro del círculo: {miCirculo.CalcularPerimetro()}");

        // Crear un objeto Cuadrado con lado 4
        Cuadrado miCuadrado = new Cuadrado(4);
        Console.WriteLine($"Área del cuadrado: {miCuadrado.CalcularArea()}");
        Console.WriteLine($"Perímetro del cuadrado: {miCuadrado.CalcularPerimetro()}");
    }
}

// Clase Circulo que encapsula el valor del radio
public class Circulo
{
    private double radio;

    // Constructor que inicializa el radio
    public Circulo(double radio)
    {
        this.radio = radio;
    }

    // CalcularArea devuelve el área del círculo: π * radio^2
    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    // CalcularPerimetro devuelve el perímetro del círculo: 2 * π * radio
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}

// Clase Cuadrado que encapsula el valor del lado
public class Cuadrado
{
    private double lado;

    // Constructor que inicializa el lado
    public Cuadrado(double lado)
    {
        this.lado = lado;
    }

    // CalcularArea devuelve el área del cuadrado: lado * lado
    public double CalcularArea()
    {
        return lado * lado;
    }

    // CalcularPerimetro devuelve el perímetro del cuadrado: 4 * lado
    public double CalcularPerimetro()
    {
        return 4 * lado;
    }
}
