using System;

namespace Ex2;

public class Operations{

    public static float Add(float a, float b){
        return a + b;
    }

    public static float Sub(float a, float b){
        return a - b;
    }

    public static float Mult(float a, float b){
        return a * b;
    }

    public static float Div(float a, float b){
        return a / b;
    }

    public static float Afisare(float result){
        Console.WriteLine("The result is: " + result);
        return result;
    }
}

internal class Ex2 : Operations
{
    public static void Main()
    {
        float x, y;
        Console.WriteLine("The first number is: ");
        x=Int32.Parse(Console.ReadLine());
        Console.WriteLine("The second number is: ");
        y=Int32.Parse(Console.ReadLine());

        Afisare(Add(x,y));
        Afisare(Sub(x,y));
        Afisare(Mult(x,y));
        Afisare(Div(x,y));
        

    }
}


