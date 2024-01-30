using System;

public class Complex
{
    public double Real { get; set; }
    public double Imaginary { get; set; }

    public Complex(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    // Overloading the + operator to add two Complex numbers
    public static Complex operator +(Complex c1, Complex c2)
    {
        return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
    }

    // Overloading the * operator to multiply two Complex numbers
    public static Complex operator *(Complex c1, Complex c2)
    {
        double realPart = c1.Real * c2.Real - c1.Imaginary * c2.Imaginary;
        double imaginaryPart = c1.Real * c2.Imaginary + c1.Imaginary * c2.Real;
        return new Complex(realPart, imaginaryPart);
    }

    // Overriding ToString() method for better string representation
    public override string ToString()
    {
        return $"{Real} + {Imaginary}i";
    }
}

class Program
{
    static void Main()
    {
        Complex c1 = new Complex(2, 3);
        Complex c2 = new Complex(4, 5);

        Complex additionResult = c1 + c2;
        Complex multiplicationResult = c1 * c2;

        Console.WriteLine("Addition result: " + additionResult); // Output: 6 + 8i
        Console.WriteLine("Multiplication result: " + multiplicationResult); // Output: -7 + 22i
    }
}
