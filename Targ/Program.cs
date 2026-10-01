namespace Targ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets1 = new List<int>();
            Console.WriteLine("Second list: ");
            List<int> targets2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int number = int.Parse(Console.ReadLine());

            do
            {
                number = int.Parse(Console.ReadLine());
                targets1.Add(number);
            } while (number != 0);

            //a
            FindMaxOffer(targets1);

            PrintList(targets1);
            Console.WriteLine("Second masiv: ");
            Console.WriteLine(string.Join(", ", targets1));
        }

        static void FindMaxOffer(List<int> list)
        {
            int max = int.MinValue;
            int maxIndex = -1;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > max)
                {
                    max = list[i];
                    maxIndex = i;
                }
            }
            Console.WriteLine($"Max element: {max}, Index: {maxIndex}");
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
        }

        static void PrintList(List<int> list)
        {

        }
    }
}
