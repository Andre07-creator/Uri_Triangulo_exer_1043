using System;
using System.Globalization;
namespace Uri_Triangulo_exer_1043
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] triangulo = Console.ReadLine().Split();
            double A = double.Parse(triangulo[0], CultureInfo.InvariantCulture);
            double B = double.Parse(triangulo[1], CultureInfo.InvariantCulture);
            double C = double.Parse(triangulo[2], CultureInfo.InvariantCulture);

            if (A + B > C)
            {
                if (A + C > B)
                {
                    if (B + C > A)
                    {
                        double perimetro = A + B + C;
                        Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
                    }
                    else
                    {
                        double area = ((A + B) / 2) * C;
                        Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
                    }
                }
            }
        }
    }
}
