using System;

class Empleado
{
    // Propiedades
    public string Nombre { get; set; }
    public double Salario { get; set; }

    // Constructor
    public Empleado(string nombre)
    {
        Nombre = nombre;
        Salario = 0; // Inicializamos el salario en 0
    }

    // Método para agregar el salario manualmente
    public void AgregarSalarioManualmente()
    {
        Console.Write($"Introduce el salario de {Nombre}: ");
        Salario = Convert.ToDouble(Console.ReadLine());
    }

    // Método para calcular el salario anual manualmente
    public double CalcularSalarioAnualManual()
    {
        return Salario * 12;
    }
}

class Program
{
    static void Main()
    {
        // Crear objetos Empleado
        Empleado empleado1 = new Empleado("Juan");
        Empleado empleado2 = new Empleado("María");

        // Agregar salarios manualmente
        empleado1.AgregarSalarioManualmente();
        empleado2.AgregarSalarioManualmente();

        // Calcular el salario anual manualmente
        double salarioAnualManualEmpleado1 = empleado1.CalcularSalarioAnualManual();
        double salarioAnualManualEmpleado2 = empleado2.CalcularSalarioAnualManual();

        Console.WriteLine($"El salario anual de {empleado1.Nombre} es: {salarioAnualManualEmpleado1:C}");
        Console.WriteLine($"El salario anual de {empleado2.Nombre} es: {salarioAnualManualEmpleado2:C}");
    }
}
