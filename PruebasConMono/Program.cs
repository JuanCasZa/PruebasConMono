// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Mono, muy buñuelo pues !!!");

public class Personas
{
    public String nombre;
    public String cedula;
    public int edad;
    public decimal estatura;
    public decimal peso;

}

public class Entrenadores : Personas
{
    public String titulo;
    public int anhosExperiencia;
}

public class Clientes : Personas
{
    public Membresias membresia;
}

public class Membresias
{
    public DateTime inicioMembresia;
    public DateTime finMembresia;
    public decimal valor;
}
