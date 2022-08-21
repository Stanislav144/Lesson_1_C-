// Задача 4: Напишите программу, которая принимает на вход три 
// числа и выдаёт максимальное из этих чисел.

    {
            int minNum=0, maxNum=0;
            Console.WriteLine("Введите размерность массива:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            Console.WriteLine("Введите массив:");

            for(int i = 0;i<n;i++)
            {
                Console.WriteLine("Введите {0}-й элемент", i + 1);
                mas[i] = int.Parse(Console.ReadLine());
            }

            var str = string.Join(" ", mas);
            Console.WriteLine(str);
            
            maxNum=mas[0];
            minNum=mas[0];
            for(int i = 0;i<n;i++)
            {
                if(mas[i]>maxNum)
                {
                    maxNum=mas[i];
                }
                
                if(mas[i]<minNum) 
                {
                    minNum=mas[i];
                }   
            } 

            Console.WriteLine("Максимальное число {0}",maxNum);
            Console.WriteLine("Минимальное число {0}",minNum);
    }





