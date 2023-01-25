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

        Console.WriteLine("Введите материал грифа"); 
        grif = Console.ReadLine();                         //ввод значения для материала грифа

        Console.WriteLine("Введите материал деки гитары"); 
        body = Console.ReadLine();                         //ввод значения для материала деки

        Console.WriteLine("Введите количество ладов гитары");
        frets = Convert.ToInt32(Console.ReadLine());       //ввод значения для количества ладов

        Console.WriteLine("Введите вес гитары в килограммах");
        weight = Convert.ToInt32(Console.ReadLine());      //ввод значения для веса

        Console.WriteLine("Введите стоимость гитары");
        price = Convert.ToInt32(Console.ReadLine());       //ввод значения для стоимости


        Console.WriteLine("Материал грифа: " + grif);     //вывод всех значений
        Console.WriteLine("Материал деки: " + body);
        Console.WriteLine("Количество ладов: " + frets);
        Console.WriteLine("Вес гитары: " + weight);
        Console.WriteLine("Стоимость гитары: " + price);

    }
}