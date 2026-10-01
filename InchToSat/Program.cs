namespace InchToSat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inches = ");
            var inches = double.Parse(Console.ReadLine());
            var centemeters = inches * 2.54;
            Console.WriteLine($"Centemeters = {centemeters}");
        }
    }
}
