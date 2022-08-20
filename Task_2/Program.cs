// Задача 2: Напишите программу, которая на вход принимает два 
// числа и выдаёт, какое число большее, а какое меньшее.
   {
 
        int number1, number2;
 
        Console.WriteLine("Введите два числа : ");
 
        number1 = Convert.ToInt32(Console.ReadLine());
 
        number2 = Convert.ToInt32(Console.ReadLine());
 
        if (number1 > number2)
 
        {
 
            Console.WriteLine("{0} наибольшее число", number1);
 
        }
 
        else
 
        {
 
            Console.WriteLine("{0} наибольшее число ", number2);
 
        }
 
        Console.ReadLine();
 
    }
