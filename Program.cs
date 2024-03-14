// See https://aka.ms/new-console-template for more information

/* String variables */

string firstName = "Szabolcs";
string lastName = "Hlatky";
string name = firstName + " " + lastName; // string concatenation
string email = "szabolcshlatky";

Console.WriteLine(name);
Console.WriteLine($"{email}@gmail.com"); // string interpolation

/* Properties */

Console.WriteLine($"The length number of the name is {name.Length}");

/* Methods */

string tweetToTrim = "   Twitter   ";
Console.WriteLine(tweetToTrim.TrimStart());
Console.WriteLine(tweetToTrim.TrimEnd());
Console.WriteLine(tweetToTrim.Trim());

Console.WriteLine(tweetToTrim.Replace("Twitter", "X"));

Console.WriteLine(firstName.ToUpper());
Console.WriteLine(lastName.ToLower());

Console.WriteLine(email.Contains(".hu"));
Console.WriteLine(email.StartsWith("szabolcs"));
Console.WriteLine(email.EndsWith("hlatky"));
