// See https://aka.ms/new-console-template for more information


class Program
{

    public static void Main(String[] args)
    {
        int[] tab = { 1, 5, 3, 2, 7 };
        Console.WriteLine(CountAVG(tab));
        Console.WriteLine(CountMAX(tab));
    }
    public static int CountAVG(int[] tab)
    {
        int avg;
        int sum = 0;
        foreach (int tmp in tab)
        {
            sum += tmp;
        }
        
        avg = sum / tab.Length;

        return avg;
    }
    
    public static int CountMAX(int[] tab)
    {
        int max = 0;
        foreach (int tmp in tab)
        {
            if (max < tmp)
                max = tmp;
        }

        return max;
    }
    
}