class Lab1Ex1
{
    static void Main()
    {
      Console.WriteLine("Enter the number of Fibonacci numbers to be printed: ");
       int n=Int32.Parse(Console.ReadLine());
       int [] f = new int[n];
      
       f[0]=0;
       f[1]=1; 

       for(int i = 2;  i < n ; i++)
       {
          f[i] = f[i-1] + f[i-2];
         
       }

       foreach(int i in f)
       {
          Console.WriteLine(i);
       }

}
}