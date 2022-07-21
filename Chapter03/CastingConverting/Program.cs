using static System.Console;
int a = 10;
double b = a; // an int can be safely cast into a double
WriteLine("{0} type is {1}", b, b.GetType());
double c = 9.8;
int d = (int)c; // compiler gives an error for this line
WriteLine("{0} type is {1}", d, d.GetType());

long e = 10;
int f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");
e = long.MaxValue;
f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");

double[] doubles = new[]
{ 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };
foreach (double n in doubles)
{
    WriteLine($"ToInt32({n}) is {ToInt32(n)}");
}

object ToInt32(double n)
{
    throw new NotImplementedException();
}

foreach (double n in doubles)
{
    WriteLine(format:
    "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
    arg0: n,
    arg1: Math.Round(value: n, digits: 0,
    mode: MidpointRounding.AwayFromZero));
}