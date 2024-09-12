internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = new int[7];
        int s = 0;
        int k = 0;
        Console.WriteLine("Введите числа");
        for (int i = 0; i < 7; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
            s += array[i];
            k++;
        }

        Console.WriteLine("Среднее арифметическое = {0}", (double)s / k);
    }
}