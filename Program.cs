namespace triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos construir um triangulo?");
            Triangulo triangulo = new Triangulo();
            Console.WriteLine("Insira o valor do primeiro lado");
            triangulo.ladox = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o valor do segundo lado");
            triangulo.ladoy = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o valor do terceiro lado");
            triangulo.ladoz = Convert.ToDouble(Console.ReadLine());

            if (triangulo.TrianguloValido())
            {
                if (triangulo.Equilatero())
                {
                    Console.WriteLine("O triângulo é equilátero.");
                }
                else if (triangulo.Isosceles())
                {
                    Console.WriteLine("O triângulo é isósceles.");
                }
                else if (triangulo.Escaleno())
                {
                    Console.WriteLine("O triângulo é escaleno.");
                }
            }
            else
            {
                Console.WriteLine("Os valores inseridos não formam um triângulo.");
            }
        }
    }
}