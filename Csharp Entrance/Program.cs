// See https://aka.ms/new-console-template for more information

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




