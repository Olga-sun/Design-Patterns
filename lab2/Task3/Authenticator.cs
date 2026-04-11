using System;

namespace Task3
{
	// Ключове слово 'sealed' забороняє наслідування цього класу. 
	public sealed class Authenticator
	{
		// Приховане поле, в якому зберігатиметься єдиний екземпляр
		private static Authenticator _instance;

		// Спеціальний об'єкт-заглушка для синхронізації потоків
		private static readonly object _lockObject = new object();

		// Приватний конструктор 
		private Authenticator()
		{
			Console.WriteLine(" ---> [СИСТЕМА] Викликано конструктор Authenticator. Створено новий екземпляр!");
		}

		// Публічна точка доступу до нашого екземпляра
		public static Authenticator Instance
		{
			get
			{
				// Подвійна перевірка блокування (Double-Check Locking)
				if (_instance == null)
				{
					lock (_lockObject)
					{
						if (_instance == null)
						{
							_instance = new Authenticator();
						}
					}
				}
				return _instance;
			}
		}

		// Звичайний метод класу для демонстрації роботи
		public void AuthenticateUser(string username)
		{
			Console.WriteLine($"[Authenticator] Користувач '{username}' успішно пройшов перевірку.");
		}
	}
}