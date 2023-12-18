using System;

namespace Пр_8_ИндивРаб_Старостин
{
    class Transport
    {
        public string Model { get; set; }
        // Переменная, хранящая модель транспорта.
        public int Speed { get; set; }
        // Переменная, хранящая скорость транспорта.
        public double Mass { get; set; }
        // Переменная, хранящая массу транспорта.

        public void Start()
            // Метод, запускающий движение транспорта.
        {
            Console.WriteLine("Транспорт начал движение.");
        }

        public void Stop()
            // Метод, останавливающий транспорт.
        {
            Console.WriteLine("Транспорт остановился.");
        }

        public void ShowInfo()
            // Метод, выводящий информацию о транспорте.
        {
            Console.WriteLine("{0} модель", Model);
            Console.WriteLine("Скорость {0} км/ч ", Speed);
            Console.WriteLine("Масса {0} кг", Mass);
        }
    }

    class Avto : Transport
        // Класс, описывающий автомобиль.
    {
        public Avto(string model, int speed, double mass)
            // Конструктор класса автомобиль.
        {
            Model = model;
            Speed = speed;
            Mass = mass;
        }
    }

    class Moto : Transport
        // Класс, описывающий мотоцикл.
    {
        public Moto(string model, int speed, double mass) 
            // Конструктор класса мотоцикл.
        {
            Model = model;
            Speed = speed;
            Mass = mass;
        }
    }

    class Velo : Transport
        // Класс, описывающий велосипед.
    {
        public Velo(string model, int speed, double mass)
            // Конструктор класса велосипед.
        {
            Model = model;
            Speed = speed;
            Mass = mass;
        }
    }

    class Program
    {
        static void Main()
        {
            Avto legkovoyAvto = new Avto("Легковой автомобиль", 120, 1500); 
            // Создание объекта автомобиль с заданными параметрами.
            Moto motocycle = new Moto("Мотоцикл", 180, 250);
            // Создание объекта мотоцикл с заданными параметрами.
            Velo bicycle = new Velo("Велосипед", 20, 10);
            // Создание объекта велосипед с заданными параметрами.

            Console.WriteLine("Информация об автомобиле:");
            // Вывод информации об автомобиле.
            legkovoyAvto.ShowInfo();
            // Вызов метода ShowInfo() для объекта автомобиль.
            legkovoyAvto.Start();
            // Запуск движения автомобиля.
            legkovoyAvto.Stop();
            // Остановка автомобиля.

            Console.WriteLine("\nИнформация о мотоцикле:");
            // Вывод информации о мотоцикле.
            motocycle.ShowInfo();
            // Вызов метода ShowInfo() для объекта мотоцикл.
            motocycle.Start();
            // Запуск движения мотоцикла.
            motocycle.Stop();
            // Остановка мотоцикла.

            Console.WriteLine("\nИнформация о велосипеде:");
            // Вывод информации о велосипеде.
            bicycle.ShowInfo();
            // Вызов метода ShowInfo() для объекта велосипед.
            bicycle.Start();
            // Запуск движения велосипеда.
            bicycle.Stop();
            // Остановка велосипеда.
        }
    }
}