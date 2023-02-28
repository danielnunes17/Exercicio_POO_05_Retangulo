using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_POO_05_Retangulo
{
    public class Retangulo
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public double CalcularArea() => Largura * Altura;

        public double CalcularPerimetro() => 2 * (Largura + Altura);

        public double CalcularDiagonal() => Math.Sqrt((Largura * Largura) + (Altura * Altura));
    }
}
