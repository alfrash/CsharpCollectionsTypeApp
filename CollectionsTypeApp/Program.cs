namespace CollectionsTypeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateArray();
            ForIteration();
            ForEachIteration();
        }

        static void CreateArray()
        {
            int[] videos = { 1, 3, 8, 6, 2, 5, 7, 9, 4 };
            Console.WriteLine(videos[3]);
            Array.Sort(videos);
            int[] videos2 = new int[9];
            Array.Copy(videos, videos2, videos.Length);
            Console.WriteLine(videos2[5]);
            videos2[5] = 50;
            Console.WriteLine(videos2[5]);
        }

        static void ForIteration()
        {
            int x = 50;
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(x);
                x += 5;
            }
            Console.WriteLine("======================");
            int[] numbers = {100, 200, 300, 400, 500, 600};
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        static void ForEachIteration()
        {
            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            foreach (var item in numbers)
            {
                
                Console.WriteLine($"Ascii code for {item} is = {(int)item}");
                int num = int.Parse(item.ToString());
                Console.WriteLine(num);
                int num2 = item - '0';
                Console.WriteLine(num2);
            }
        }
    }
}
