// See https://aka.ms/new-console-template for more information


class Program
{

    public static void Main(String[] args)
    {
        int[] tab = { 1, 5, 3, 2, 7 };
        Console.WriteLine(count(tab));
    }
    public static int count(int[] tab)
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
    
}