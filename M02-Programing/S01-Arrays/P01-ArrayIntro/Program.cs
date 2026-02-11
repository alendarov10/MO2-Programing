public class Program
{
    public static void Main()
    {
        double day1 = 12;
        double day2 = 12.3;
        double day3 = 8;

        double[] t = new double[3];

        for (int i = 0; i < t.Length; i++)
        {
            Console.WriteLine($"t[{i}]= ");
            t[i] = double.Parse(Console.ReadLine());
        }

        for (int i = 0; i < t.Length; i++)
        {
            Console.WriteLine($"t[{i}] = {t[i]}");
        }

    }
}

