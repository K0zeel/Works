using LabWorkLibrary;

namespace LabWork23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int weight = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());

            Maths maths = new Maths();
            Console.WriteLine(Maths.GetSum(a, b));
            Console.WriteLine(Maths.GetDif(a, b));
            Console.WriteLine(Maths.GetMultiply(a, b));
            Console.WriteLine(Maths.GetDiv(a, b));
            Console.WriteLine(Maths.GetRectangleArea(weight, height));
            Console.WriteLine(Maths.BINARY_FACTOR);
        }
    }
}
