internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите целочисленное значение N");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[n, n];
        int str = 0;
        int stolb = 0;
        int diag1 = 0;
        int diag2 = 0;
        for (int i = 0; i < n; i++)
        {

            for (int j = 0; j < n; j++)
            {
                array[i, j] = Convert.ToInt32(Console.ReadLine());
            }


        }

        for (int i = 0; i < n; i++)
        {
            str = 0;
            for (int j = 0; j < n; j++)
            {
                str += array[i, j];
            }
            //Console.WriteLine(str);
        }
        for (int j = 0; j < n; j++)
        {
            stolb = 0;
            for (int i = 0; i < n; i++)
            {
                stolb += array[i, j];
            }
            //Console.WriteLine(stolb);
        }



        for (int i = 0; i < n; i++)
        {

            for (int j = 0; j < n; j++)

            {
                if (i == j)
                {
                    diag1 += array[i, j];

                }
            }

        }
        //Console.WriteLine(diag1);

        for (int i = 0; i < n; i++)
        {

            for (int j = 0; j < n; j++)

            {
                if (i + j == n - 1)
                {
                    diag2 += array[i, j];

                }
            }

        }
        //Console.WriteLine(diag2);

        if ((str == stolb) && (str == diag1) && (diag2 == diag1))
        {
            Console.WriteLine("О май гад... Это же магический квадрат матрицы");

        }
        else
        {
            Console.WriteLine("Сумма СТРОК массива = {0}", str);
            Console.WriteLine("Сумма СТОЛБЦОВ массива = {0}", stolb);
            Console.WriteLine("Сумма ДИАГОНАЛЬ №1 массива = {0}", diag1);
            Console.WriteLine("Сумма ДИАГОНАЛЬ №2 массива = {0}", diag2);
        }
    }

}