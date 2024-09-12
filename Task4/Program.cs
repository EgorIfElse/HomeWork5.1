internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = new int[20];
        Random random = new Random();
        int s = 0;
        for (int i = 0; i < 20; i++)
        {
            array[i] = random.Next(-50, 50);
            Console.Write("{0} ", array[i]);

        }
        for (int i = 0; i < 20; i++)
        {
            if (array[i] > 0 && array[i] % 2 != 0)
            {
                s++;
            }
            i++;
        }


        Console.WriteLine();

        Console.WriteLine(s);
    }
}