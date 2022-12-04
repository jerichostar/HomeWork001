/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

*/

Console.WriteLine("Введите первоое число:");
string numberOneStr = Console.ReadLine();

Console.WriteLine("Введите второе число:");
string numberTwoStr = Console.ReadLine();

Console.WriteLine("Введите третье число:");
string numberThreeStr = Console.ReadLine();

int numberOne = Convert.ToInt32(numberOneStr);
int numberTwo = Convert.ToInt32(numberTwoStr);
int numberThree = Convert.ToInt32(numberThreeStr);

if (numberOne > numberTwo && numberOne > numberThree)
{
    Console.Write(numberOne);
}
else if (numberTwo > numberOne && numberTwo > numberThree)
{
    Console.Write(numberTwo);
}
else if (numberThree > numberOne && numberThree > numberTwo)
{
    Console.Write(numberThree);
}
