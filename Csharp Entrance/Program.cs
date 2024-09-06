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





