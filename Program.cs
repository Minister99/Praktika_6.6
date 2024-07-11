using System;
using System.IO;

namespace Praktika_6._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LaunchingApplication();
        }

        static void LaunchingApplication()
        {
            while (true) 
            {
                Console.WriteLine("Выберите команду");
                Console.WriteLine("0 - закрыть програму");
                Console.WriteLine("1 - запись данных");
                Console.WriteLine("2 - показать информацию о работниках");
                string teamSelection = Console.ReadLine();

                switch (teamSelection) 
                {
                    case "0":
                        Console.WriteLine("Програма закрыта");
                        return;
                    case "1":
                        DataInput();
                        break;
                    case "2":
                        case "3":
                        DataOutput();
                        break;
                    default:
                        Console.WriteLine("Не верно выбрана команда");
                        break;
                }
            }
        }

        static void DataInput() 
        {
            Console.WriteLine("Введите данные работника");

            Console.WriteLine("Присвойте сотрутнику ID");
            string id = Console.ReadLine();

            string dataTime = DateTime.Now.ToString();
            Console.WriteLine($"Дата и время добавления данных: {dataTime}");

            Console.WriteLine("Ф.И.О");
            string fulName = Console.ReadLine();

            Console.WriteLine("Возраст");
            string age = Console.ReadLine();

            Console.WriteLine("Рост");
            string height = Console.ReadLine();

            Console.WriteLine("Дата рождения формат: (дд.мм.гггг)");
            string dateBirth = Console.ReadLine();

            Console.WriteLine("Место рождения");
            string placeBirth = Console.ReadLine();

            string record = $"#{id}#{dataTime}#{fulName}#{age}#{height}#{dateBirth}#{placeBirth}";

            using (StreamWriter streamWriter = new StreamWriter("data.txt", true))
            {
                streamWriter.WriteLine(record);
            }
        }

        static void DataOutput()
        {
            Console.WriteLine("");
            string[] lines = File.ReadAllLines("data.txt");

            foreach (string line in lines) 
            {
                Console.WriteLine(line.Replace("#", "  "));
            }
        }
    }
}
