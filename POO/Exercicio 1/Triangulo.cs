using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_1
{
    public class Triangulo
    {
        public double A;
        public double B;
        public double C;
        public double P;

        public string QualTriangulo()
        {
            string result = "";
            if (A + B >= C && C + B >= A && C + A >= B)
            {
                result += "\nTriângulo: ";
                double area = Area();
                if (A == B && B == C)
                {
                    result += "Equilátero\t";
                }
                else if (A == B || B == C || C == A)
                {
                    result += "Isósceles\t";
                }
                else
                {
                    result += "Escaleno\t";
                }
                result += $"Área: {area:F2}\n";
            }
            else
            {
                result += "\nAs medidas usadas não formam um triângulo.\n";
            }
            return result;
        }
        public double Area()
        {
            P = (A + B + C) / 2.0;
            return Math.Sqrt(P * (P - A) * (P - B) * (P - C));
        }
    }
}