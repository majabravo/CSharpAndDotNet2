﻿using static System.Console;

int a = 5;
int b = a++;

WriteLine($"a is {a},b is {b}");

int c = 5;
int d = ++c;

WriteLine($"c is {c},d is {d}");

int e = 11;
int f = 3;
WriteLine($"e is {e},f is {f}");
WriteLine($"e + f = {e + f}");
WriteLine($"e - f = {e - f}");
WriteLine($"e / f = {e / f}");
WriteLine($"e * f = {e * f}");
WriteLine($"e % f = {e % f}");

double g = 11;
WriteLine($"g is {g:N1}, f is {f}");
WriteLine($"g / f = {g / f}");

int p = 6;
p += 3; // equivalent to p = p + 3;
p -= 3; // equivalent to p = p - 3;
p *= 3; // equivalent to p = p * 3;
p /= 3; // equivalent to p = p / 3;




