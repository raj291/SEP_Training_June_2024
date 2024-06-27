namespace ConsoleApp3;

public class GenerateNumbers
{
    
    public int[] GenerateNumber(int length)
    {
        int[] numbers = new int[length];
        for (int i = 0; i < length; i++)
        {
            numbers[i] = i + 1; 
        }
        return numbers;
    }

    public void Reverse(int[] array)
    {
        // Swap elements in the array
        int temp;
        for (int i = 0; i < array.Length / 2; i++)
        {
            temp = array[i];
            array[i] = array[array.Length - i - 1];
            array[array.Length - i - 1] = temp;
        }
    }
    public void PrintNumbers(int[] array)
    {
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine(); 
    }
    public void Main(int args)
    {
        int[] numbers = GenerateNumber(10);
        Reverse(numbers);
        PrintNumbers(numbers);
    }
}