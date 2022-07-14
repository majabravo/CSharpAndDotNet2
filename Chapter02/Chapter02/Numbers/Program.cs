﻿// unsigned integer means positive whole number or 0
uint naturalNumber = 23;
// integer means negative or positive whole number or 0
int integerNumber = -23;
// float means single-precision floating point
// F suffix makes it a float literal
float realNumber = 2.3F;
// double means double-precision floating point
double anotherRealNumber = 2.3;
// double literal

Console.WriteLine(naturalNumber);
Console.WriteLine(integerNumber);
Console.WriteLine(anotherRealNumber);
Console.WriteLine(realNumber);


// three variables that store the number 2 million
int decimalNatation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8480;

Console.WriteLine($"{decimalNatation == binaryNotation}");
Console.WriteLine($"{decimalNatation == hexadecimalNotation}");
Console.WriteLine(decimalNatation);
Console.WriteLine(binaryNotation);
Console.WriteLine(hexadecimalNotation);

Console.WriteLine($"int uses {sizeof(int)} bytes" + $"and can store number in the range {int.MinValue:N0} to {int.MaxValue:N0}");

Console.WriteLine($"int uses {sizeof(double)} bytes" + $"and can store number in the range {double.MinValue:N0} to {double.MaxValue:N0}");

Console.WriteLine($"int uses {sizeof(decimal)} bytes" + $"and can store number in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}");
Console.WriteLine("Using doubles:");
double a = 0.1;
double b = 0.2;
if (a + b == 0.3)
{
    Console.WriteLine($"{a} + {b} equals {0.3}");
}
else
{
    Console.WriteLine($"{a} + {b} does NOT equals {0.3}");
}
Console.WriteLine("Using decimal:");
decimal c = 0.1M;
decimal d = 0.2M;
if (c + d == 0.3M)
{
    Console.WriteLine($"{c} + {d} equals {0.3}");
}
else
{
    Console.WriteLine($"{c} + {d} does NOT equals {0.3}");
}
bool isBreak = false;

