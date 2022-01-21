/*string firstFriend = "Maria";
string secondFriend = "Sage";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");//String literal

Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");//Using string interpolation and a string property in this example.(The string property is "Length" after the dot-"."-in front of string variable that is hold a collection of characters. )
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");*/

/*string greeting = "      Hello World!       ";//Orginal message
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");//Displays orginal message with the TrimStart() being implemented in string literal.

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");*/
//The code above; TimStart(), TrimEnd(), and Trim() are method used for this string literal.

string sayHello = "Hello World!";
Console.WriteLine(sayHello);

sayHello = sayHello.Replace("Hello", "I Hate You");
Console.WriteLine(sayHello);

Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());

Console.WriteLine(sayHello);//While the string goes through the two methods, ToUpper() & ToLower, the string variable-"sayHello"-does not change from the point you assigned it to a new string literal.