namespace Task_14_04
{
 
        
            /// <summary>
            /// класс для представления пользователя
            /// </summary>
    public class User
        {
            // статическое свойство для текущего пользователя
            public static User CurrentUser { get; private set; }

            // свойства пользователя
            public string Name { get; set; }
            public int Age { get; set; }

            /// <summary>
            /// метод для установки текущего пользователя
            /// </summary>
            /// <param name="user">Объект пользователя</param>
            public static void SetCurrentUser(User user)
            {
                CurrentUser = user;
            }

            /// <summary>
            /// метод для отображения информации о пользователе
            /// </summary>
            public void ShowInfo()
            {
                Console.WriteLine($" Имя: {Name}, Возраст: {Age}");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                // создание пользователя
                User user1 = new User { Name = " Лина ", Age = 16 };

                // установка текущего пользователя
                User.SetCurrentUser(user1);

                // вывод информации о текущем пользователе
                Console.WriteLine(" Текущий пользователь: ");
                if (User.CurrentUser != null)
                {
                    User.CurrentUser.ShowInfo();
                }
                else
                {
                    Console.WriteLine(" Текущий пользователь не установлен ");
                }
            }
        }
    }

    

