namespace CollectionsTypeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CreateArray();
            //ForIteration();
            //ForEachIteration();
            //DynamicArray();
            //DynamicArrayAverage();
            PlayWithDoWhileLoops();
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

        static void DynamicArray()
        {
            Console.Write("please enter array size = ");
            int arraySize = int.Parse(Console.ReadLine()!);
            int[] numbers = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write($"Enter array item({i + 1}) = ");
                numbers[i] = int.Parse(Console.ReadLine()!);
            }
            Console.WriteLine("========================");
            int[] reversedArray = new int[arraySize];
            for (int i = arraySize - 1; i>=0; i--)
            {
                reversedArray[arraySize - i- 1] = numbers[i];
            }

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("========================");
            foreach (var item in reversedArray)
            {
                Console.WriteLine(item);
            }
        }
        static void DynamicArrayAverage()
        {
            Console.Write("please enter array size = ");
            int arraySize = int.Parse(Console.ReadLine()!);
            int[] numbers = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write($"Enter array item({i + 1}) = ");
                numbers[i] = int.Parse(Console.ReadLine()!);
            }
            Console.WriteLine("========================");
            int sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }
            double average = sum / numbers.Length;
            Console.WriteLine($"average of numbers = {average}");
        }

        static void PlayWithDoWhileLoops()
        {
            var x = 2;
            do
            {
                Console.WriteLine(x++);
            } while (x <= 10);
            Console.WriteLine("========================");
            var y = 2;
            while (y <= 10)
            {
                Console.WriteLine(y++);
            }

            while (true)
            {
                Console.Write("enter any word: ");
                var word = Console.ReadLine();
                if (word != "exit")
                {
                    Console.WriteLine(word.ToUpper());
                }else
                {
                    break;
                }
            }
        }
    }
}
