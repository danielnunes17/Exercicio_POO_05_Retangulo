/*Fazer um programa para ler os valores da largura e altura de um retângulo.
 Em seguida, mostrar na tela o valor de sua área, perímetro e diagonal.
Exemplo:
Entre a largura e altura do retângulo:
3.00
4.00
AREA = 12.00
PERÍMETRO = 14.00
DIAGONAL = 5.00*/

using Exercicio_POO_05_Retangulo;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Retangulo retangulo = new Retangulo();

        Console.WriteLine("Entre com a largura do retângulo: ");
        retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Entre com altura do retângulo: ");
        retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("AREA = " + retangulo.CalcularArea().ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("PERÍMETRO = " + retangulo.CalcularPerimetro().ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("DIAGONAL = " + retangulo.CalcularDiagonal().ToString("F2", CultureInfo.InvariantCulture));
    }
}