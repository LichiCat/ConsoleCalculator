using System.Text.Json.Serialization;

class Program
{
    static void Main(string[] args)
    {
        //Материал грифа.
        string grif; 

        //Материал деки гитары.
        string body; 

        //Колисчество ладов.
        int frets;   

        //Вес.
        int weight;
        
        //Стоимость.
        int price;   

        //Переменные для цикла вывода значений.
        int k=1, t;

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

        while (k != 0)
        { 
            t = Convert.ToInt32(Console.ReadLine());

            if (t == 0)
            {   
                // выход из цикла
                k = 0; 
            }

            if (t == 1)
            {

                Console.WriteLine("Материал грифа: " + grif); 
            }

            if (t == 2)
            {
                Console.WriteLine("Материал деки гитары: " + body); 
            }

            if (t == 3)
            {
                Console.WriteLine("Количество ладов гитары: " + frets); 
            }

            if (t == 4)
            {
                Console.WriteLine("Вес гитары: " + weight); 
            }

            if (t == 5)
            {
                Console.WriteLine("Стоимость гитары: " + price); 
            }
        }
    }
}