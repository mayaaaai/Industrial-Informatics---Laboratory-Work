using System;
namespace Ex5;




class Ex5{

    public static void Main(){

        int n;
        Console.WriteLine("The number of elements is: ");
        n=Int32.Parse(Console.ReadLine());
        int[] a = new int[n];

        float sum=0;
        double prod=1;

        for ( int i=0; i<n; i++){
            Console.WriteLine("The element is: ");
            a[i]=Int32.Parse(Console.ReadLine());

            sum += a[i];
            prod *= a[i];
        }

        Console.WriteLine("The arithmetic mean is: ");
         sum /= n;
        Console.WriteLine(sum);
        Console.WriteLine("The geometric mean is: ");
         prod=Math.Sqrt(prod);
        Console.WriteLine(prod);

      

    }
}
