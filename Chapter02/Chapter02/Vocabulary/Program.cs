// See https://aka.ms/new-console-template for more information
//#error version

Console.WriteLine("Hello, World!");
//For text, a single letter, such as an A, is stored as a char type.
char letter = 'A';
char digit = '1';
char symbol = '$';
char userChoice = Console.ReadKey().KeyChar;
Console.WriteLine($"{nameof(letter)}:{letter} \r\n" + $"{nameof(digit)}:{digit} \r\n" + $"{nameof(symbol)}:{symbol}" + $"{nameof(userChoice)}:{userChoice}");
//For text, multiple letters, such as Bob, are stored as a string type and are assigned using double quotes around the literal value

string firstName = "Bob";
string lastName = "Smith";
string phoneNumber = "(215) 555-4256";
Console.WriteLine($"{nameof(firstName)} : {firstName}");