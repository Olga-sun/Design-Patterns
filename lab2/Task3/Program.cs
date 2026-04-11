using System;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== Старт тестування патерну Одинак (Singleton) ===\n");

            // Створюємо масив завдань (потоків), щоб імітувати одночасний доступ
            Task[] threads = new Task[5];

            for (int i = 0; i < 5; i++)
            {
                int threadId = i + 1;

                // Запускаємо паралельний потік
                threads[i] = Task.Run(() =>
                {
                    // Отримуємо доступ до нашого Одинака
                    Authenticator auth = Authenticator.Instance;

                    auth.AuthenticateUser($"User_{threadId}");
                    Console.WriteLine($"Потік {threadId} отримав екземпляр з HashCode: {auth.GetHashCode()}");
                });
            }

            // Чекаємо, поки всі паралельні потоки завершать свою роботу
            Task.WaitAll(threads);

            Console.WriteLine("\n=== Перевірка у головному потоці ===");
            Authenticator auth1 = Authenticator.Instance;
            Authenticator auth2 = Authenticator.Instance;

            // Перевіряємо, чи це дійсно один і той самий об'єкт у пам'яті
            if (ReferenceEquals(auth1, auth2))
            {
                Console.WriteLine("РЕЗУЛЬТАТ: Змінні auth1 та auth2 повністю ідентичні.");
                Console.WriteLine("Патерн працює бездоганно: існує лише один екземпляр класу Authenticator!");
            }

            Console.ReadLine();
        }
    }
}