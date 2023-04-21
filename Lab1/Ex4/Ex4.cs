using System;

namespace Ex4;

public class IdealParams{
    public static double IdealWeightMale(double height, double age){
        return (height - 100) - (height - 150) / 4 + (age-20) / 4;
    }
    public static double IdealWeightFemale(double height, double age){
        return (height - 100) - (height - 150) / 2.5 + (age-20) / 6;
    }
    public static double Afisare(double result){
        Console.WriteLine("The result is: " + result);
        return result;
    }
}
internal class Ex4 : IdealParams {

    public static void Main(){
        
        double age,height;

        Console.WriteLine("The age is: ");
        age=Int32.Parse(Console.ReadLine());
        Console.WriteLine("The height is: ");
        height=Int32.Parse(Console.ReadLine());
        
        Console.WriteLine("Ideal weight for a female with the given age and height is:");
        Afisare(IdealWeightFemale(height,age));
        Console.WriteLine("Ideal weight for a male with the given age and height is:");
        Afisare(IdealWeightMale(height,age));


    }
}