namespace Methods;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter an integer number between 5 and 15: ");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput >= 5 && userInput <= 15)
            {
                int[] array = RandomArray(userInput);
                Console.WriteLine("The elements of the array are: " + string.Join(" ", array));
                int sum = SumArray(array);
                Console.WriteLine("The sum is: " + sum);
            }
            else
            {
                Console.WriteLine("Invalid input! Number must be between 5 and 15.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input! Please enter a valid integer number.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid input! Number is too large or too small.");
        }

        Console.ReadLine();
    }

    static int[] RandomArray(int length)
    {
        Random random = new Random();
        int[] array = new int[length];

        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next(10, 51);
        }

        return array;
    }

    static int SumArray(int[] array)
    {
        int sum = 0;

        foreach (int num in array)
        {
            sum += num;
        }

        return sum;
    }
}



