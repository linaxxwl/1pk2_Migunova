namespace Task_13_02
{
        
          namespace PetClassExample
    {
        /// <summary>
        /// класс для описания питомца
        /// </summary>
        public class Pet
        {
            // Поля
            private string nickname;  // кличка питомца
            private string type;      // вид животного
            private int age;          // возраст
            private double weight;    // вес
            private bool isHealthy;   // состояние здоровья (здоров/нездоров)

            // свойства
            public string Nickname
            {
                get { return nickname; }
                set { nickname = value; }
            }

            public string Type
            {
                get { return type; }
                set { type = value; }
            }

            public int Age
            {
                get { return age; }
                set { age = value; }
            }

            public double Weight
            {
                get { return weight; }
                set { weight = value; }
            }

            public bool IsHealthy
            {
                get { return isHealthy; }
                set { isHealthy = value; }
            }

            // методы

            /// <summary>
            /// вывод информации о питомце
            /// </summary>
            public void ShowInfo()
            {
                string healthStatus = isHealthy ? " Здоров " : " Нездоров ";
                Console.WriteLine($" Кличка: {nickname} ");
                Console.WriteLine($" Вид: {type} ");
                Console.WriteLine($" Возраст: {age} лет ");
                Console.WriteLine($" Вес: {weight} кг ");
                Console.WriteLine($" Состояние здоровья: {healthStatus} ");
            }

            /// <summary>
            /// изменение веса питомца
            /// </summary>
            /// <param name="newWeight">новый вес</param>
            public void ChangeWeight(double newWeight)
            {
                weight = newWeight;
            }

            /// <summary>
            /// изменение состояния здоровья питомца
            /// </summary>
            /// <param name="newHealthStatus">новое состояние здоровья</param>
            public void ChangeHealthStatus(bool newHealthStatus)
            {
                isHealthy = newHealthStatus;
            }

            // конструкторы

            public Pet()
            {
                nickname = "неизвестно";
                type = "неизвестно";
                age = 0;
                weight = 0.0;
                isHealthy = true;
            }

            /// <summary>
            /// конструктор с кличкой и видом питомца
            /// </summary>
            /// <param name="nickname">Кличка</param>
            /// <param name="type">Вид</param>
            public Pet(string nickname, string type)
            {
                this.nickname = nickname;
                this.type = type;
                age = 0;
                weight = 0.0;
                isHealthy = true;
            }

            /// <summary>
            /// конструктор с кличкой, видом и возрастом
            /// </summary>
            /// <param name="nickname">Кличка</param>
            /// <param name="type">Вид</param>
            /// <param name="age">Возраст</param>
            public Pet(string nickname, string type, int age)
            {
                this.nickname = nickname;
                this.type = type;
                this.age = age;
                weight = 0.0;
                isHealthy = true;
            }

            /// <summary>
            /// конструктор с кличкой, видом, возрастом, весом и состоянием здоровья
            /// </summary>
            /// <param name="nickname">Кличка</param>
            /// <param name="type">Вид</param>
            /// <param name="age">Возраст</param>
            /// <param name="weight">Вес</param>
            /// <param name="isHealthy">Состояние здоровья</param>
            public Pet(string nickname, string type, int age, double weight, bool isHealthy)
            {
                this.nickname = nickname;
                this.type = type;
                this.age = age;
                this.weight = weight;
                this.isHealthy = isHealthy;
            }
        }

        // пример использования
        class Program
        {
            static void Main(string[] args)
            {
                // создание объектов разными способами
                Pet pet1 = new Pet();
                Pet pet2 = new Pet("Барсик", "Кот");
                Pet pet3 = new Pet("Рекс", "Собака", 5);
                Pet pet4 = new Pet("Пушистик", "Кролик", 2, 3.5, false);

                // вывод информации
                pet1.ShowInfo();
                Console.WriteLine();

                pet2.ShowInfo();
                Console.WriteLine();

                pet3.ShowInfo();
                Console.WriteLine();

                pet4.ShowInfo();
                Console.WriteLine();

                // изменение данных
                pet4.ChangeWeight(4.0);
                pet4.ChangeHealthStatus(true);

                // повторный вывод информации
                pet4.ShowInfo();
            }
        }
    }

}
    

