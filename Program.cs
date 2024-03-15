//  который на вход принимает два числа и выводит, какое число большее, а какое меньшее.

// Console.Write("Input firstNumber: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input secondNumber: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if (firstNumber > secondNumber)
// {
//     System.Console.WriteLine("larger number = " + firstNumber + ", smaller number = " + secondNumber);
//  }

//  if (firstNumber == secondNumber)
// {
//     System.Console.WriteLine("numbers are equal");
//  }

// else 

// {
//     System.Console.WriteLine("larger number = " + secondNumber + ", smaller number = " + firstNumber);
//  }

//  который принимает на вход три числа и выдаёт максимальное из этих чисел.

// 
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Input firstNumber: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input secondNumber: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input thirdNumber: ");
        int thirdNumber = Convert.ToInt32(Console.ReadLine());

        int max = firstNumber;

        if (secondNumber > max)
        {
            max = secondNumber;
        }

        if (thirdNumber > max)
         {
            max = thirdNumber;
        }
        System.Console.WriteLine("Max number = " + max);
    }
}

// который на вход принимает число number и выводит, является ли число чётным (делится ли оно на два без остатка)

// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int remdiv = number % 2;

// if(remdiv == 0)
// {
//     Console.WriteLine("even");
// }
// else
// {
//     Console.WriteLine("odd");
// }


// которая на вход принимает число (number), а на выходе выводит все чётные числа от 1 до number (включительно), 
// после каждого числа должен быть знак пробела.

// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int i = 2;

// while(i > 1 && i <= number)
// { 
//  System.Console.Write(i + " ");
//  i = i + 2; //  i += 1
// }
 
//  Вопросы: 1. Почему я не смогла вставить while и if в 4 задаче с нахождением чётного числа из 3 задачи