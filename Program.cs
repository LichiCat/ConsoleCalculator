using System.Text.Json.Serialization;

class Program
{
    static void Main(string[] args)
    {
        string grif; //переменная для материала грифа 
        string body; //переменная для материал деки гитары
        int frets;   //переменная для колисчества ладов
        int weight;  //переменная для веса
        int price;   //переманная для стоимости 

        int k=1, t;

        Console.WriteLine("Введите материал грифа"); 
        grif = Console.ReadLine();                         //ввод значения для материала грифа 1

        Console.WriteLine("Введите материал деки гитары"); 
        body = Console.ReadLine();                         //ввод значения для материала деки 2

        Console.WriteLine("Введите количество ладов гитары");
        frets = Convert.ToInt32(Console.ReadLine());       //ввод значения для количества ладов 3

        Console.WriteLine("Введите вес гитары в килограммах");
        weight = Convert.ToInt32(Console.ReadLine());      //ввод значения для веса 4

        Console.WriteLine("Введите стоимость гитары");
        price = Convert.ToInt32(Console.ReadLine());       //ввод значения для стоимости 5

        Console.WriteLine("Чтобы вывести конкретные данные о гитаре, воспользуетесь встроенной клавиатурой, \n" +
                "где 1-Материал грифа,  2-Материал деки, 3-Количество ладов, 4-Вес, 5-Стоимость\n" +
                "Для выхода введите значение  0");
        while (k != 0)
        { 
            t = Convert.ToInt32(Console.ReadLine());

            if (t == 0)
            {
                k = 0; // выход из цикла
            }

            if (t == 1)
            {
                Console.WriteLine("Материал грифа: " + grif); // 1
            }

            if (t == 2)
            {
                Console.WriteLine("Материал деки гитары: " + body); // 2
            }

            if (t == 3)
            {
                Console.WriteLine("Количество ладов гитары: " + frets); // 3
            }

            if (t == 4)
            {
                Console.WriteLine("Вес гитары: " + weight); // 4
            }

            if (t == 5)
            {
                Console.WriteLine("Стоимость гитары: " + price); //5
            }
        }
    }
}