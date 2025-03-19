namespace Task_13_03
{

    /// <summary>
    /// класс для описания автомобиля
    /// </summary>
    public class Car
    {
        // поля
        private string number;  // номер автомобиля
        private string brand;   // марка автомобиля
        private string color;   // цвет автомобиля
        private double speed;   // текущая скорость автомобиля

        // свойства
        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public double Speed
        {
            get { return speed; }
            private set { speed = value; } // скорость можно изменять только внутри класса
        }

        // конструкторы

        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Car()
        {
            number = " Неизвестно ";
            brand = " Неизвестно ";
            color = " Неизвестно ";
            speed = 0;
        }

        /// <summary>
        /// кнструктор с номером и маркой
        /// </summary>
        /// <param name="number">Номер автомобиля</param>
        /// <param name="brand">Марка автомобиля</param>
        public Car(string number, string brand)
        {
            this.number = number;
            this.brand = brand;
            this.color = "Неизвестно";
            this.speed = 0;
        }

        /// <summary>
        /// полный конструктор
        /// </summary>
        /// <param name="number">Номер автомобиля</param>
        /// <param name="brand">Марка автомобиля</param>
        /// <param name="color">Цвет автомобиля</param>
        /// <param name="speed">Начальная скорость</param>
        public Car(string number, string brand, string color, double speed)
        {
            this.number = number;
            this.brand = brand;
            this.color = color;
            this.speed = speed;
        }

        // методы

        /// <summary>
        /// метод для увеличения скорости
        /// </summary>
        /// <param name="increase">На сколько увеличить скорость</param>
        public void Drive(double increase)
        {
            if (increase > 0)
            {
                Speed += increase;
                Console.WriteLine($" Автомобиль разогнался. Скорость: {Speed} км/ч ");
            }
            else
            {
                Console.WriteLine(" Увеличение скорости должно быть положительным числом ");
            }
        }

        /// <summary>
        /// вывод информации об автомобиле
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine($" Номер: {Number} ");
            Console.WriteLine($" Марка: {Brand} ");
            Console.WriteLine($" Цвет: {Color} ");
            Console.WriteLine($" Текущая скорость: {Speed} км/ч ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // создание объектов разными способами
            Car car1 = new Car();
            Car car2 = new Car("A123BC", "Toyota");
            Car car3 = new Car("B456DE", "BMW", "Черный", 50);

            // вывод информации об автомобилях
            car1.ShowInfo();
            Console.WriteLine();

            car2.ShowInfo();
            Console.WriteLine();

            car3.ShowInfo();
            Console.WriteLine();

            // управление автомобилем
            car3.Drive(30); // увеличить скорость на 30
        }
    }
}
