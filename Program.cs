using System;

class Program
{
    static void Main(string[] args)
    {       
        string grif;      
        string body;        
        int frets;          
        int weight;            
        int price;       
       
        Console.WriteLine("Введите материал грифа"); 
        grif = Console.ReadLine();

        Console.WriteLine("Введите материал деки гитары"); 
        body = Console.ReadLine();                         

        Console.WriteLine("Введите количество ладов гитары");
        frets = Convert.ToInt32(Console.ReadLine());       

        Console.WriteLine("Введите вес гитары в килограммах");
        weight = Convert.ToInt32(Console.ReadLine());      

        Console.WriteLine("Введите стоимость гитары");
        price = Convert.ToInt32(Console.ReadLine());       

        Console.WriteLine("Чтобы вывести конкретные данные о гитаре, воспользуетесь встроенной клавиатурой, \n" +
                "где 1-Материал грифа,  2-Материал деки, 3-Количество ладов, 4-Вес, 5-Стоимость\n" +
                "Для выхода введите значение  0");

        //Переменная для выбора.
        int choice=2222;

        while (choice != 0)
        {
            choice = Convert.ToInt32(Console.ReadLine());

            // выход из цикла
            if (choice == 0)
            {
                choice = 0; 
            }

            else if (choice == 1)
            {
                Console.WriteLine("Материал грифа: " + grif); 
            }

            else if (choice == 2)
            {
                Console.WriteLine("Материал деки гитары: " + body); 
            }

            else if (choice == 3)
            {
                Console.WriteLine("Количество ладов гитары: " + frets); 
            }

            else if (choice == 4)
            {
                Console.WriteLine("Вес гитары: " + weight); 
            }

            else if (choice == 5)
            {
                Console.WriteLine("Стоимость гитары: " + price); 
            }
        }
    }
}
