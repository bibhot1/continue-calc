// See https://aka.ms/new-console-template for more information
//making a calculator



int num1;
int num2;
int result;
string answer;
Console.WriteLine("Welcome to the calculator");

Console.WriteLine("Please enter your first number");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter your second number");
num2 = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Please state the calculation you want to do");
Console.WriteLine("Please press a for Addition, s for Substraction , m for Multiplication and d for Division ");
answer = Console.ReadLine();

if (answer == "a")
{
    result = num1 + num2;
}
else if (answer == "s")
{
    result = num1 - num2;
}
else if (answer == "m")
{
    result = num1 * num2;
}
else 
{
    result = num1 / num2; 
}

Console.WriteLine("The result is" + result);