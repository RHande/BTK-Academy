// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices.JavaScript;

Console.WriteLine("Hello, World!");


int myNum = 5;               // Integer (whole number)
double myDoubleNum = 5.99D;  // Floating point number  
char myLetter = 'D';         // Character
bool myBool = true;          // Boolean
string myText = "Hello";     // String

//We can change the value of the variable

myNum = 20;
myDoubleNum = 20.99D;
myLetter = 'M';
myBool = false;
myText = "World";

Console.WriteLine(myNum);
Console.WriteLine(myDoubleNum);
Console.WriteLine(myLetter);
Console.WriteLine(myBool);
Console.WriteLine(myText);

//We can also declare multiple variables in one line

int x = 5, y = 6, z = 50;
Console.WriteLine(x + y + z);

//We can also declare variables without assigning a value to them

int myNum1;
myNum1 = 15;
Console.WriteLine(myNum1);

//We can also declare constants

const int myNum2 = 15;
Console.WriteLine(myNum2);

//We can also use the var keyword to declare variables

var myNum3 = 15;
Console.WriteLine(myNum3);

//We can also use the dynamic keyword to declare variables

dynamic myNum4 = 15;
Console.WriteLine(myNum4);

//We can also use the object keyword to declare variables

object myNum5 = 15;
Console.WriteLine(myNum5);

//We can also use the byte keyword to declare variables

byte myNum6 = 15;
Console.WriteLine(myNum6);

//We can also use the sbyte keyword to declare variables

sbyte myNum7 = 15;
Console.WriteLine(myNum7);

//We can also use the short keyword to declare variables

short myNum8 = 15;
Console.WriteLine(myNum8);

//We can also use the ushort keyword to declare variables

ushort myNum9 = 15;
Console.WriteLine(myNum9);

//We can also change the data type but we have to carefull that the value of the variable is not lost
//Also the data type should be compatible with the value of the variable

int myNum10 = 15;
double myDoubleNum1 = myNum10; // Automatic casting: int to double
Console.WriteLine(myDoubleNum1);

double myDoubleNum2 = 15.45D;
int myNum11 = (int)myDoubleNum2; // Manual casting: double to int
Console.WriteLine(myNum11);//Shows 15


//Nullable types

int? myNum12 = null;
double? myDoubleNum3 = 5.99D;
char? myLetter1 = 'D';
bool? myBool1 = true;
string myText1 = null;

Console.WriteLine(myNum12);
Console.WriteLine(myDoubleNum3);
Console.WriteLine(myLetter1);
Console.WriteLine(myBool1);
Console.WriteLine(myText1);

//We can also use the ?? operator to assign a default value to a nullable type

int? myNum13 = null;
int myNum14 = myNum13 ?? 100;
Console.WriteLine(myNum14); //Shows 100


//We can also use the is operator to check the type of a variable

int myNum15 = 15;
Console.WriteLine(myNum15 is int); //Shows True


//We can also use hasvalue property to check if a nullable type has a value

int? maas = 10;

if (maas.HasValue)//We can also use if (maas != null) instead of if (maas.HasValue)
{//We can not use HasValue property with non-nullable types so we only use it with 'int?' type. '?' is used to make the type nullable
    Console.WriteLine("Maas degeri: " + maas.Value);
}
else
{
    Console.WriteLine("Maas degeri: null");
}

int? maas1 = null; //It is same as int? maas1 = default;
Console.WriteLine(maas1.HasValue);//Shows False
Console.WriteLine(maas1.GetValueOrDefault());//Shows 0. Because the default value of int is 0


//String Methods

string myString = "Hello World";
Console.WriteLine(myString.ToUpper()); // Outputs "HELLO WORLD"

string myString1 = "Hello";
string myString2 = "World";
Console.WriteLine(string.Concat(myString1, myString2)); // Outputs "HelloWorld"

int characterCount = myString.Length;
Console.WriteLine(characterCount); // Outputs 11

string lower =myString.ToLower();
Console.WriteLine(lower); // Outputs "hello world"

string message = "    I'm learning C#    ";
string trim = message.Trim();//Or we can use string trim = message.TrimStart(); or string trim = message.TrimEnd();
Console.WriteLine(trim); // Outputs "I'm learning C#

Console.WriteLine(message.Substring(6)); // Outputs "learning C#"
Console.WriteLine(message.Substring(6, 8)); // Outputs "learning"
Console.WriteLine(message.IndexOf("C#")); // Outputs 13
Console.WriteLine(message.IndexOf("C#", 10)); // Outputs 13 If the search string is not found, the IndexOf method returns -1
Console.WriteLine(message.LastIndexOf("C#")); // Outputs 13
Console.WriteLine(message.Split(" ")[1]); // Outputs "I'm"
Console.WriteLine(message.Replace("C#", "C-Sharp")); // Outputs "I'm learning C-Sharp"
Console.WriteLine(message.Split(" "));//Outputs System.String[]
Console.WriteLine(message.Split(" ")[2]); // Outputs "C#"
Console.WriteLine(message.Remove(6)); // Outputs "I'm le"
Console.WriteLine(message.StartsWith("I")); // Outputs True
Console.WriteLine(message.Contains("C#")); // Outputs True
Console.WriteLine(message.EndsWith("C#")); // Outputs True
Console.WriteLine(message.Insert(6, "not ")); // Outputs "I'm not learning C#"
Console.WriteLine(message.PadLeft(25)); // Outputs "    I'm learning C#    "
Console.WriteLine(message.PadRight(25)); // Outputs "    I'm learning C#    "
Console.WriteLine(message.PadLeft(25, '*')); // Outputs "****I'm learning C#    "
Console.WriteLine(message.PadRight(25, '*')); // Outputs "    I'm learning C#****"
Console.WriteLine(message.Length); // Outputs 22
Console.WriteLine(message.Trim().Length); // Outputs 17
Console.WriteLine(message.Trim().ToUpper()); // Outputs "I'M LEARNING C#"
Console.WriteLine(message.Trim().ToLower()); // Outputs "i'm learning c#"
Console.WriteLine(message.Trim().Substring(6)); // Outputs "learning C#" This is same as message.Substring(6);


//Date Time

DateTime myDateTime = DateTime.Now;
Console.WriteLine(myDateTime);//Outputs the current date and time

Console.WriteLine(myDateTime.Date);//Outputs the current date
Console.WriteLine(myDateTime.Day);//Outputs the current day
Console.WriteLine(myDateTime.Month);//Outputs the current month
Console.WriteLine(myDateTime.Year);//Outputs the current year
Console.WriteLine(myDateTime.Hour);//Outputs the current hour
Console.WriteLine(myDateTime.Minute);//Outputs the current minute
Console.WriteLine(myDateTime.Second);//Outputs the current second
Console.WriteLine(myDateTime.Millisecond);//Outputs the current millisecond
Console.WriteLine(myDateTime.DayOfWeek);//Outputs the current day of the week
Console.WriteLine(myDateTime.DayOfYear);//Outputs the current day of the year

DateTime myDateTime1 = new DateTime(2021, 12, 31); //We can also use DateTime myDateTime1 = new DateTime(2021, 12, 31, 0, 0, 0); to set the time
Console.WriteLine(myDateTime1);//Outputs 31.12.2021 00:00:00    

DateTime myDateTime2 = myDateTime1.AddYears(3);
Console.WriteLine(myDateTime2.Year);//Outputs 2024
DateTime myDateTime3 = myDateTime1.AddMonths(3);
Console.WriteLine(myDateTime3.Month);//Outputs 3


TimeSpan distance = myDateTime - myDateTime1;
Console.WriteLine(distance);//Outputs the difference between myDateTime and myDateTime1 > 981.00:16:00.0000000 means 981 days 16 hours
Console.WriteLine(distance.Days);//Outputs the difference between the days of myDateTime and myDateTime1 > 981
Console.WriteLine(distance.Hours);//Outputs the difference between the hours of myDateTime and myDateTime1 > 16
Console.WriteLine(distance.TotalDays);//Outputs the difference between the total days of myDateTime and myDateTime1 > 981.66666666666663
Console.WriteLine(distance.TotalHours);//Outputs the difference between the total hours of myDateTime and myDateTime1 > 23560

int yearDifference = myDateTime.Year - myDateTime1.Year;
Console.WriteLine(yearDifference);//Outputs the difference between the years of myDateTime and myDateTime1 > 1

/*
int dif = myDateTime - myDateTime1;
Console.WriteLine(dif);//We can not use the - operator with DateTime type. We can only use it with TimeSpan type
*/

//Arrays

int[] myArray = { 1, 2, 3, 4, 5 };
Console.WriteLine(myArray[0]); // Outputs 1
Console.WriteLine(myArray[1]); // Outputs 2

int[] myArray1 = new int[5];
myArray1[0] = 1;
myArray1[1] = 2;
myArray1[2] = 3;
myArray1[3] = 4;
myArray1[4] = 5;
Console.WriteLine(myArray1[0]); // Outputs 1
Console.WriteLine(myArray1[1]); // Outputs 2

int[] myArray2 = new int[5] { 1, 2, 3, 4, 5 };
Console.WriteLine(myArray2[0]); // Outputs 1
Console.WriteLine(myArray2[1]); // Outputs 2


int[] myArray3 = new int[] { 1, 2, 3, 4, 5 };
Console.WriteLine(myArray3[0]); // Outputs 1
Console.WriteLine(myArray3[1]); // Outputs 2

//We can also use the foreach loop to iterate over an array

int[] myArray4 = { 1, 2, 3, 4, 5 };
foreach (int number in myArray4)
{
    Console.WriteLine(number);
}

//We can also use the Length property to get the length of an array

int[] myArray5 = { 1, 2, 3, 4, 5 };
Console.WriteLine(myArray5.Length); // Outputs 5

//We can also use the Rank property to get the rank of an array

int[] myArray6 = { 1, 2, 3, 4, 5 };
Console.WriteLine(myArray6.Rank); // Outputs 1

//We can also use the GetLength method to get the length of a specific dimension of an array

int[,] myArray7 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
Console.WriteLine(myArray7.GetLength(0)); // Outputs 2
Console.WriteLine(myArray7.GetLength(1)); // Outputs 3

//We use all of example for string methods with arrays


//Array Methods

string[] cities = { "Ankara", "Istanbul", "Izmir", "Bursa", "Antalya" };
cities.SetValue("Sakarya", 0);
Console.WriteLine(cities[0]); // Outputs "Sakarya"
Console.WriteLine(cities.GetValue(0)); // Outputs "Sakarya"
Console.WriteLine(cities.GetValue(1)); // Outputs "Istanbul"

Array.Sort(cities);//Sorts the array in alphabetical order. This is same for int and it is used to sort the array in ascending order
foreach (string city in cities)
{
    Console.WriteLine(city);
}//outputs Antalya Bursa Istanbul Izmir Sakarya

Array.Reverse(cities);//Reverses the array. This is same for int and it is used to reverse the array in descending order
foreach (string city in cities)
{
    Console.WriteLine(city);
}//outputs Sakarya Izmir Istanbul Bursa Antalya


//Array Slicing

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] numbers1 = new int[5];
Array.Copy(numbers, 0, numbers1, 0, 5);
foreach (int number in numbers1)
{
    Console.WriteLine(number);
}//outputs 1 2 3 4 5

int[] numbers2 = numbers[0..3];
foreach (int number in numbers2)
{
    Console.WriteLine(number);
}//outputs 1 2 3

foreach (int a in numbers[..3])
{
    Console.WriteLine(a);
}//outputs 1 2 3


foreach (int b in numbers[7..])
{
    Console.WriteLine(b);
}//outputs 8 9 10


foreach (int c in numbers[2..^3])
{
    Console.WriteLine(c);
}//outputs 3 4 5 6 7


//Multidimensional Arrays

int[,] myArray8 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
Console.WriteLine(myArray8[0, 0]); // Outputs 1
Console.WriteLine(myArray8[1,0]);//Outputs 4

string[] students = new[] { "Ali", "Ahmet", "Canan" };
int[,] nots = new int[3, 3];

//Ali
nots[0, 0] = 50;
nots[0, 1] = 60;
nots[0, 2] = 70;


//Ahmet
nots[1, 0] = 60;
nots[1, 1] = 80;
nots[1, 2] = 90;

//Canan
nots[2, 0] = 50;
nots[2, 1] = 70;
nots[2, 2] = 30;

int ortAli = (nots[0,0] + nots[0,1] + nots[0,2])/3;
int ortAhmet = (nots[1,0] + nots[1,1] + nots[1,2])/3;
int ortCanan = (nots[2,0] + nots[2,1] + nots[2,2])/3;

Console.WriteLine($"{students[0]} isimli öğrencinin not ortalaması: {ortAli}");
Console.WriteLine($"{students[1]} isimli öğrencinin not ortalaması: {ortAhmet}");
Console.WriteLine($"{students[2]} isimli öğrencinin not ortalaması: {ortCanan}");


//Random Numbers

Random random = new Random();
int randomNumber = random.Next();
Console.WriteLine(randomNumber);//Outputs a random number > 0-2147483647

int randomNumber1 = random.Next(100);
Console.WriteLine(randomNumber1);//Outputs a random number > 0-99

string[] takimlar = { "Galatasaray", "Fenerbahce", "Besiktas", "Trabzonspor", "Basaksehir" };
int rand = random.Next(takimlar.Length);
Console.WriteLine(takimlar[rand]);//Outputs a random team name
//Random numbers are used in games, simulations, cryptography, and more.


//Switch Case

int day = DateTime.Now.DayOfWeek == 0 ? 7 : (int)DateTime.Now.DayOfWeek;
switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Invalid day");
        break;
}


int mounth = DateTime.Now.Month;

switch (mounth)
{
    case 1:
        Console.WriteLine("January");
        break;
    case 2:
        Console.WriteLine("February");
        break;
    case 3:
        Console.WriteLine("March");
        break;
    case 4:
        Console.WriteLine("April");
        break;
    case 5:
        Console.WriteLine("May");
        break;
    case 6:
        Console.WriteLine("June");
        break;
    case 7:
        Console.WriteLine("July");
        break;
    case 8:
        Console.WriteLine("August");
        break;
    case 9:
        Console.WriteLine("September");
        break;
    case 10:
        Console.WriteLine("October");
        break;
    case 11:
        Console.WriteLine("November");
        break;
    case 12:
        Console.WriteLine("December");
        break;
    default:
        Console.WriteLine("Invalid mounth");
        break;
}

string result;
int sayi = 10;
result = (sayi %2 ==0) ?
          (sayi>0) ? "Positive and Even": "Negative and Even":
          (sayi>0) ? "Positive and Odd": "Negative and Odd";
Console.WriteLine(result);
//We use the ternary operator much more simple situations. If the situation is more complex, we use the if-else statement.




