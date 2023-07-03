

/*
Hello World 
 */
using System.ComponentModel;
using ConsoleApp1;

Console.WriteLine("First C# Code!!!");


/*
String  
 */

string s = "I am first String";
Console.WriteLine(s);
Console.WriteLine("Hello, " + s);



/*
 String interpolation
 */

Console.WriteLine($"Hello {s}");


string firstFriend = "Maria";
string secondFriend = "Sage";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");


//Length Property

Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");


//Trim --- not to display whiteSpace
string greeting = "      Hello World!       ";
Console.WriteLine($"Main String is [{greeting}]");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"Trim Start is [{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"trim End is [{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"Trim is [{trimmedGreeting}]");



// Replace
string sayHello = "Hello World!";
Console.WriteLine($"Defined String is {sayHello}");
sayHello = sayHello.Replace("Hello", "Replaced by hello- Greetings");
Console.WriteLine(sayHello);


//Upper & Lower Case
Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());


// Contains
string songLyrics = "You say goodbye, and I say hello11111111";
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));


string songLyrics1 = "You say goodbye, and I say hello2222222222";
Console.WriteLine(songLyrics1.StartsWith("You"));
Console.WriteLine(songLyrics1.EndsWith("goodbye"));


//Numbers --- Int  Double
int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine(c);


double a1 = 5;
double b1 = 4;
double c1 = 2;
double d1 = (a1 + b1) / c1;
Console.WriteLine(d1);


//Area of Circle
double r = 2.50;
double area = Math.PI * r * r;
Console.WriteLine(area);


/*
 
if else 
 */
int aa = 5;
int bb = 6;
if (aa + bb > 10)
    Console.WriteLine("The answer is greater than 10.");

else
    Console.WriteLine("The answer is not greater than 10.");


/*   while loop
*/

int counter = 0;
while (counter < 10)
{
    Console.WriteLine($"WHILE LOOP counter is {counter}");
    counter++;
}


/*  DO while Loop
 */
int counter1 = 0;
do
{
    Console.WriteLine($"DO WHILE LOOP counter is {counter1}");
    counter1++;
} while (counter1 < 10);


/*  For Loop
 */

for (int counter2 = 0; counter2 < 10; counter2++)
{
    Console.WriteLine($"FOR LOOP {counter2}");
}

for (int row = 1; row < 11; row++)
{
    Console.WriteLine($"The row is {row}");
}


for (char column = 'a'; column < 'k'; column++)
{
    Console.WriteLine($"The column is {column}");
}



for (int row = 1; row < 11; row++)
{
    for (char column = 'a'; column < 'k'; column++)
    {
        Console.WriteLine($"The cell is ({row}, {column})");
    }
}


// Sum of Integers
int sum = 0;
for (int i = 1; i <= 20; i++)
{
    if (i % 3 == 0)
    {
        sum = sum + i;
    }

}
Console.WriteLine(sum);


// lists
var names = new List<string> { "<Nidhi>", "Ana", "Felipe" };
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

Console.WriteLine();
names.Add("Maria");
names.Add("Bill");
names.Remove("Ana");
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

// list index
Console.WriteLine($"My name is {names[0]}.");
Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");


// count 
Console.WriteLine($"The list has {names.Count} people in it");


// sort & search
var index = names.IndexOf("Felipe");
if (index != -1)
{
    Console.WriteLine($"The name {names[index]} is at index {index}");
}
//var notFound = names.IndexOf("Not Found");
else
{
    Console.WriteLine($"When an item is not found, IndexOf returns {{notFound");
}

names.Sort();
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}


// fib series 
var fibonacciNumbers = new List<int> { 1, 1 };

var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

fibonacciNumbers.Add(previous + previous2);

foreach (var item in fibonacciNumbers)
{
    Console.WriteLine(item);
}

var fibonacciNumber = new List<int> { 1, 1 };

while (fibonacciNumber.Count < 20)
{
    var pre = fibonacciNumber[fibonacciNumber.Count - 1];
    var pre2 = fibonacciNumber[fibonacciNumber.Count - 2];

    fibonacciNumber.Add(pre + pre2);
}
foreach (var item in fibonacciNumber)
{
    Console.WriteLine(item);
}


var account = new BankAccount("Nidhi", 1000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");


//linq

int[] num = { 1,2,3, 4,5, 6 };
int ii = 0;
var q = (from n in num select ++ii).ToList();

foreach (var item in q)
{
    Console.WriteLine($"item ={item} , i = {ii}");
}

//Async and Wait


var worker = new Worker();
var data = worker.CollectData(50);

foreach(var item in data)
{
    Console.WriteLine(item);
}

