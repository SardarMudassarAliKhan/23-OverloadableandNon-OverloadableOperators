In C#, not all operators can be overloaded. Some operators are overloadable, meaning you can define custom behavior for them in your classes, while others are non-overloadable, meaning their behavior cannot be modified.

Here's a list of overloadable operators in C#:

1. Unary operators:
   - `+` (unary plus)
   - `-` (unary minus)
   - `!` (logical negation)
   - `~` (bitwise complement)
   - `++` (increment)
   - `--` (decrement)
   - `true` (true operator)
   - `false` (false operator)

2. Binary operators:
   - `+` (addition)
   - `-` (subtraction)
   - `*` (multiplication)
   - `/` (division)
   - `%` (modulus)
   - `&` (bitwise AND)
   - `|` (bitwise OR)
   - `^` (bitwise XOR)
   - `<<` (left shift)
   - `>>` (right shift)
   - `==` (equality)
   - `!=` (inequality)
   - `<` (less than)
   - `>` (greater than)
   - `<=` (less than or equal to)
   - `>=` (greater than or equal to)

3. Other operators:
   - `[]` (indexer access)
   - `()` (invocation)
   - `+=` (addition assignment)
   - `-=` (subtraction assignment)
   - `*=` (multiplication assignment)
   - `/=` (division assignment)
   - `%=` (modulus assignment)
   - `&=` (bitwise AND assignment)
   - `|=` (bitwise OR assignment)
   - `^=` (bitwise XOR assignment)
   - `<<=` (left shift assignment)
   - `>>=` (right shift assignment)

Non-overloadable operators in C# include:

- `.` (member access)
- `?:` (conditional)
- `->` (pointer member access)
- `new` (object creation)
- `sizeof` (size of)
- `typeof` (type of)
- `is` (type test)
- `as` (type cast)
- `checked` and `unchecked` (checked and unchecked contexts)
- `++` and `--` (post-increment and post-decrement) when used in an expression
- `&&` and `||` (conditional logical AND and conditional logical OR)
- `?:` (null-coalescing operator)
- `::` (namespace alias qualifier)
- `=>` (lambda operator)
- `,` (comma)

Understanding which operators can be overloaded and which cannot is essential for designing classes with custom behavior that aligns with C#'s language conventions.


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
