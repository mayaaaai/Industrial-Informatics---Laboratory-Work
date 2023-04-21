using System;
namespace Ex3;

public class TemperatureTransform {

public static float CelsiusToFahrenheit(float celsius){
    return (celsius * 9/5) + 32;
}
public static float FahrenheitToCelsius(float fahrenheit){
    return (fahrenheit - 32) * 5/9;

}
}

internal class Ex3 : TemperatureTransform{

    public static void Main(){
         int x,y;

        Console.WriteLine("The temperature in Celsius is: ");
         x=Int32.Parse(Console.ReadLine());
        Console.WriteLine("The temperature in Fahrenheit is: ");
         y=Int32.Parse(Console.ReadLine());

        Console.WriteLine("The temperature in Fahrenheit is: " + CelsiusToFahrenheit(x));
        Console.WriteLine("The temperature in Celsius is: " + FahrenheitToCelsius(y));     
    }
}
