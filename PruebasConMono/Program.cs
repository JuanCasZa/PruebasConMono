// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Mono, muy buñuelo pues !!!");
Console.WriteLine("buñuelo ud apá!!!");
bool continuar = true;

while (continuar)
{
    Console.WriteLine("Calculadora simple");
    Console.Write("Ingrese el primer número: ");
    double num1;
    while (!double.TryParse(Console.ReadLine(), out num1))
    {
        Console.Write("Por favor, ingrese un número válido: ");
    }

    Console.Write("Ingrese el segundo número: ");
    double num2;
    while (!double.TryParse(Console.ReadLine(), out num2))
    {
        Console.Write("Por favor, ingrese un número válido: ");
    }

    Console.WriteLine("Seleccione la operación (+, -, *, /): ");
    string operacion = Console.ReadLine();

    double resultado = 0;
    bool operacionValida = true;

    switch (operacion)
    {
        case "+":
            resultado = num1 + num2;
            break;
        case "-":
            resultado = num1 - num2;
            break;
        case "*":
            resultado = num1 * num2;
            break;
        case "/":
            if (num2 != 0)
                resultado = num1 / num2;
            else
            {
                Console.WriteLine("No se puede dividir por cero.");
                operacionValida = false;
            }
            break;
        default:
            Console.WriteLine("Operación no válida.");
            operacionValida = false;
            break;
    }

    if (operacionValida)
        Console.WriteLine($"El resultado es: {resultado}");

    Console.Write("¿Desea realizar otra operación? (si/no): ");
    string respuesta = Console.ReadLine();
    if (respuesta.ToLower() != "si")
        continuar = false;
        
}


public class Personas {
/*
⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜
⬜⬜⬜⬜⬛⬜⬜⬜⬛⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬛⬜⬜⬜⬛
⬜⬜⬜⬜⬛⬜⬜⬜⬛⬜⬛⬜⬜⬜⬛⬜⬜⬜⬛⬜⬛⬜⬜⬜⬛
⬜⬜⬜⬜⬛⬜⬜⬜⬛⬜⬜⬛⬜⬛⬜⬛⬜⬛⬜⬜⬛⬜⬜⬜⬛
⬜⬜⬜⬜⬜⬛⬛⬛⬜⬜⬜⬜⬛⬜⬜⬜⬛⬜⬜⬜⬜⬛⬛⬛⬜
⬜⬜⬜⬜⬜⬜⬜⬜🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨⬜⬜⬜⬜⬜⬜⬜
⬜⬜⬜⬜⬜⬜🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨⬜⬜⬜⬜⬜
⬜⬜⬜⬜⬜🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨⬜⬜⬜
⬜⬜⬜⬜🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨⬜⬜⬜
⬜⬜⬜⬜🟨🟨🟨🟨⬛⬛⬛⬛⬛🟨🟨🟨🟨🟨🟨🟨🟨🟨🟨⬜⬜
⬜⬜⬜🟨🟨🟨🟨⬛⬛🌫️🌫️🌫️🌫️⬛🟨🟨🟨🟨⬛⬛⬛⬛🟨⬜⬜
⬜⬜🟨🟨🟨🟨⬛⬛⬛⬛🌫️🌫️🌫️⬛⬛🟨⬛⬛🌫️🌫️🌫️🌫️⬛🟨⬜
⬜⬜🟨🟨🟨⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛🌫️🌫️⬜⬛🟨⬜
⬜⬜🟨🟨🟨⬛⬛⬛⬛⬛⬛⬛⬛⬛🟨⬛⬛⬛⬛⬛⬛⬛⬛⬛⬜
⬜⬜🟨🟨🟨⬛⬛⬛⬛⬛⬛⬛⬛⬛🟨⬛⬛⬛⬛⬛⬛⬛⬛⬛⬜
⬜⬜🟧🟧🟧⬛⬛⬛⬛⬛⬛⬛⬛🟨🟨⬛⬛⬛⬛⬛⬛⬛⬛⬜⬜
⬜⬜🟧🟧🟧🟧🟧⬛⬛⬛⬛🟨🟨🟨🟨🟨⬛⬛⬛⬛⬛⬛⬛⬜⬜
⬜⬜🟧🟧🟧🟧🟧🟧🟧🟨🟨🟨⬛⬛⬛🟨🟧⬛⬛⬛⬛⬛⬜⬜⬜
⬜⬜⬜🟧🟧🟧🟧🟧🟧🟧🟨🟨🟨🟨🟨🟧🟧🟧🟧🟧🟧🟧⬜⬜⬜
⬜⬜⬜🟧🟧🟧🟧🟧🟧🟧🟧🟨🟨🟨🟨🟧🟧🟧🟧🟧🟧🟧⬜⬜⬜
⬜⬜⬜⬜🟧🟧🟧🟧🟧🟧🟧🟨🟨🟨🟨🟧🟧🟧🟧🟧🟧⬜⬜⬜⬜
⬜⬜⬜⬜⬜🟧🟧🟧🟧🟧🟧🟨🟨🟨🟨🟧🟧🟧🟧🟧⬜⬜⬜⬜⬜
⬜⬜⬜⬜⬜⬜🟧🟧🟧🟧🟧🟨🟨🟨🟨🟧🟧🟧🟧⬜⬜⬜⬜⬜⬜
⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜
⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜
*/
}