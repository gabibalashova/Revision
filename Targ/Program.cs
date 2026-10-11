namespace Targ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    List<int> targets1 = new List<int>();
            //    Console.WriteLine("Second list: ");
            //    List<int> targets2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //    int number = int.Parse(Console.ReadLine());

            //    do
            //    {
            //        number = int.Parse(Console.ReadLine());
            //        targets1.Add(number);
            //    } while (number != 0);

            //    //a
            //    FindMaxOffer(targets1);

            //    PrintList(targets1);
            //    Console.WriteLine("Second masiv: ");
            //    Console.WriteLine(string.Join(", ", targets1));
            //}

            //static void FindMaxOffer(List<int> list)
            //{
            //    int max = int.MinValue;
            //    int maxIndex = -1;
            //    for (int i = 0; i < list.Count; i++)
            //    {
            //        if (list[i] > max)
            //        {
            //            max = list[i];
            //            maxIndex = i;
            //        }
            //    }
            //    Console.WriteLine($"Max element: {max}, Index: {maxIndex}");
            //    //for (int i = 0; i < list.Count; i++)
            //    //{
            //    //    Console.WriteLine(list[i]);
            //    //}
            //}

            //static void PrintList(List<int> list)
            //{

            //}

            Console.Write("Candidates: ");
            int n = int.Parse(Console.ReadLine());
            List<int> offers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Candidate offer {i} (in euro): ");
                offers.Add(int.Parse(Console.ReadLine()));
            }

            //a
            int maxOffer = offers[0];
            int winnerNumber = 1;

            for (int i = 1; i < offers.Count; i++)
            {
                if (offers[i] > maxOffer)
                {
                    maxOffer = offers[i];
                    winnerNumber = i + 1;
                }
            }
            Console.WriteLine($"Winner candidates: {winnerNumber}, offer - {maxOffer} euro.");

            //b
            Console.Write("\nEnter number for searching: ");
            int searchNum = int.Parse(Console.ReadLine());

            bool exists = false;
            int countEqual = 0;

            for (int i = 0; i < offers.Count; i++)
            {
                if (offers[i] == searchNum)
                {
                    exists = true;
                    countEqual++;
                }
            }

            if (exists)
            {
                Console.WriteLine($"The number - {searchNum} exists in offers.");
            }
            else
            {
                Console.WriteLine($"The number {searchNum} DOESN't exist in offers");
            }
            Console.WriteLine($"Broi offerti = {searchNum}: {countEqual}");

            //c
            Console.Write("\n Even offers: ");
            bool hasEven = false;

            for (int i = 0; i < offers.Count; i++)
            {
                if (offers[i] % 2 == 0)
                {
                    Console.Write(offers[i]);
                    hasEven = true;
                }
            }

            if (!hasEven)
            {
                Console.Write("Even numbers aren't found.");
            }
            Console.WriteLine();

            //d
            double sum = 0;
            for (int i = 0; i < offers.Count; i++)
            {
                sum += offers[i];
            }
            double average = sum / offers.Count;
            Console.WriteLine($"\nSrednoaritmetichno na offers - {average:F2} euro.");

            //e
            int countAbove500 = 0;
            for (int i = 0; i < offers.Count; i++)
            {
                if (offers[i] > 500)
                {
                    countAbove500++;
                }
            }
            Console.WriteLine($"Offers that are higher than 500 - {countAbove500}");
        }
}
