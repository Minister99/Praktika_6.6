using System;
using System.IO;

namespace Praktika_6._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LaunchingProgram();
        }

        static void LaunchingProgram()
        {
            while (true)
            {
                Console.WriteLine("Выберите действие");
                Console.WriteLine("1 - просмотр базы даных");
                Console.WriteLine("2 - добавления данных сотрудника");
                Console.WriteLine("0 - Закрыть програму");

                string selectAction = Console.ReadLine();
                switch (selectAction)
                {
                    case "0":
                        Console.WriteLine("База данных закрыта");
                        return;
                    case "1":
                        DataOutput();
                        break;
                    case "2":
                        DataInput();
                        break;
                    default:
                        Console.WriteLine("Вы ввели невеное значение");
                        break;
                }

            }
        }

        static void DataInput()
        {
            int id = 1;

            Console.WriteLine("Введите даные сотрудника");

            string dataTime = DateTime.Now.ToString();
            Console.WriteLine($"Время добавления записи: {dataTime}");

            Console.WriteLine("Ф.И.О");
            string fulName = Console.ReadLine();

            Console.WriteLine("Возраст");
            string age = Console.ReadLine();

            Console.WriteLine("Рост");
            string height = Console.ReadLine();

            Console.WriteLine("Дата рождения формат (дд.мм.гггг)");
            string dateBirth = Console.ReadLine();

            Console.WriteLine("Место рождения");
            string placeBirth = Console.ReadLine();

            string record = $"#{id}#{dataTime}#{fulName}#{age}#{height}#{dateBirth}#{placeBirth}";
            
            using (StreamWriter streamWriter = new StreamWriter("dataInput.txt", true))
            {
                streamWriter.WriteLine(record);
            }
            Console.WriteLine("Данные сотрудника успешно добавлены");
            
            id++;
        }

        static void DataOutput()
        {
            if(File.Exists("dataInput.txt"))
            {
                string[] lins = File.ReadAllLines("dataInput.txt");

                foreach (string line in lins) 
                {
                    Console.WriteLine($"{line.Replace("#","\t" )}");
                }
            }

            else 
            {
                Console.WriteLine("Файл не найдет");
            }
        }


    }
}
