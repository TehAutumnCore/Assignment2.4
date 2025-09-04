namespace Assignment2._4
{
    internal class Program
    {
        public class ArraySum
        {
            public static int Sum()
            {
                Console.Write("Input the number of elements to be stored in the array:");
                if (!int.TryParse(Console.ReadLine(), out int numOfElementsInput) || numOfElementsInput <= 0)
                {
                    Console.WriteLine($"Input {numOfElementsInput} elements in the array: ");
                    return 0;
                }
                int[] array = new int[numOfElementsInput];
                int sum = 0;
                for (int i = 0; i < numOfElementsInput; i++)
                {
                    Console.Write($"element - {i} : ");
                    while(!int.TryParse(Console.ReadLine(), out array[i]))
                    {
                        Console.WriteLine("Invalid input. Please enter an integer.");
                    }
                    sum += array[i];
                }
                Console.WriteLine($"Sum of all elements stored in the array is: {sum}");
                return sum;
            }
        }
        
        public class LargestOfThreeNums
        {
            public static int FindLargest()
            {
                int first, second, third;

                Console.Write("Input the 1st number: ");
                while(!int.TryParse(Console.ReadLine(), out first))
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                    Console.Write("Input the 1st number: ");
                }

                Console.Write("Input the 2nd number: ");
                while (!int.TryParse(Console.ReadLine(), out second))
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                    Console.Write("Input the 2nd number: ");
                }

                Console.Write("Input the 3rd number: ");
                while (!int.TryParse(Console.ReadLine(), out third))
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                    Console.Write("Input the 3rd number: ");
                }
                int largest = first;
                string solution="1st";

                if (second > largest) 
                {
                    largest = second;
                    solution = "2nd";
                }

                if (third > largest)
                {
                    largest = third;
                    solution = "3rd";
                }

                Console.WriteLine($"The {solution} is the greatest among three");
                return largest;
            }
        }

        public class WhichQuadrant
        {
            public static string Solution()
            {
                Console.Write("Input the value of x coordinate: ");
                if (!int.TryParse(Console.ReadLine(), out int x))
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                    return "";
                }

                Console.Write("Input the value of y coordinate: ");
                if (!int.TryParse(Console.ReadLine(), out int y))
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                    return "";
                }

                string quadrant = "";
                if (x == 0 && y == 0) 
                {
                    quadrant = "Origin";
                    Console.WriteLine($"The coordinate point ({x},{y}) lies on the {quadrant}");
                    return quadrant;
                }
                if (x > 0 && y > 0) quadrant = "First";
                if (x < 0 && y > 0) quadrant = "Second";
                if (x < 0 && y < 0) quadrant = "Third";
                if (x > 0 && y < 0) quadrant = "Fourth";

                Console.WriteLine($"The coordinate point ({x},{y}) lies in the {quadrant} quadrant");
                return quadrant;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //ArraySum.Sum();
            //LargestOfThreeNums.FindLargest();
            //WhichQuadrant.Solution();
        }
    }
}
