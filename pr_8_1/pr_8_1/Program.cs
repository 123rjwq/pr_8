using System;

namespace pr_8_1
{
    class Program
    {
        class Computer
        {
            private string modelName;
            // Модель компьютера
            private int ramSize;
            // Размер оперативной памяти

            public string ModelName
            {
                get { return modelName; }
                set { modelName = (value != "") ? value : "noName"; }
            }

            public int RamSize
            {
                get { return ramSize; }
                set { ramSize = (value < 500) ? 640 : value; }
            }

            public Computer() { }

            public Computer(string modelName, int ramSize)
            {
                this.ModelName = modelName;
                this.RamSize = ramSize;
            }

            public virtual void Start()
            {
                Console.WriteLine("{0} работает, память = {1}", ModelName, RamSize);
            }

            public virtual void End()
            {
                Console.WriteLine("{0} выключается", ModelName);
            }
        }

        class Notebook : Computer
        {
            private int batteryTime;
            // Время работы от батареи

            public int BatteryTime
            {
                get { return batteryTime; }
                set { batteryTime = (value < 10) ? 15 : value; }
            }

            public Notebook() { }

            public Notebook(string modelName, int ramSize, int batteryTime) : base(modelName, ramSize)
            {
                this.BatteryTime = batteryTime;
            }

            public override void End()
            {
                Console.WriteLine("{0} выключается, заряд {1} мин", ModelName, BatteryTime);
            }
        }

        class Netbook : Notebook
        {
            private int weight;
            // Вес нетбука

            public int Weight
            {
                get { return weight; }
                set { weight = (value < 30) ? 10 : value; }
            }

            public Netbook(string modelName, int ramSize, int batteryTime, int weight) : base(modelName, ramSize, batteryTime)
            {
                this.Weight = weight;
            }

            // Переопределенный метод Start с модификатором override
            public override void Start()
            {
                Console.WriteLine("{0} весит {1} кг", ModelName, Weight);
            }
        }

        static void Main(string[] args)
        {
            Notebook nb = new Notebook("Asus", 1024, 120);
            nb.Start();
            // Запускаем ноутбук
            nb.End();
            // Выключаем ноутбук

            Computer comp2 = new Notebook("Dell", 4096, 30);
            comp2.Start();
            // Запускаем компьютер
            comp2.End();
            // Выключаем компьютер

            Netbook netb1 = new Netbook("HP", 4096, 120, 20);
            netb1.Start();
            // Запускаем нетбук
            netb1.End();
            // Выключаем нетбук

            Console.ReadKey();
        }
    }
}



