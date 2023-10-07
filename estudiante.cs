using System;

public class Estudiante
{
   
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Curso { get; set; }

    
    public Estudiante(string nombre, int edad, string curso)
    {
        
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("¡Hola, mundo!");
    }
}
