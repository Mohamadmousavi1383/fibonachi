//mohammad mousavi fibonachy
using Microsoft.VisualBasic;

class program
{
    static void Main(string[] args)
    {
        int a = 0; int b = 1; int c;
        Console.WriteLine("yak dune adad bego:");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write($"{a}\t{b}\t");
        for( int i = 2 ; i <= n ; i++ )
        {
            c = a + b;
            Console.Write($"{c}\t");
            a = b;
            b = c;   
            
        }
    }
}