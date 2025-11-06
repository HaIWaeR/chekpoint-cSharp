namespace SampleCodeforFheJob
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            Random rn = new();
            for (int i = 0; i < 1000; i++)
            {
                users.Add(new User()
                {
                    Name = "user" + i,
                    Password = Guid.NewGuid().ToString(),
                    Age = rn.Next(10, 100),
                    CreatedAt = DateTime.Now.AddDays(Math.Pow(-1, rn.Next(1, 5)) * rn.Next(10, 1000))
                });
            }

            //LINQ

            //IEnumerable<User> filteredUsers = users.Where(x => x.CreatedAt > DateTime.Now)
            //                                     .Where(x => x.Age < 30);

            //foreach (User user in filteredUsers)
            //{
            //    Console.WriteLine(user);
            //}

            //Console.WriteLine(filteredUsers.Count());

            //Dictionary<string, User> sortedUsers = users.ToDictionary(user => user.Password, user => user);
            //foreach (KeyValuePair<string,User> user in sortedUsers)
            //{
            //    Console.WriteLine(user.Key + " " + user.Value);
            //}

            List<ShortUser> names = users.Select(user =>
                                            new ShortUser()
                                            {
                                                Name = user.Name,
                                                Age = user.Age,
                                                Id = Guid.NewGuid()
                                            }).ToList();

            List<int> ints = new List<int>();

            ints.Distinct();

            foreach (ShortUser user in names)
            {
                Console.WriteLine(user);
            }
        }

        public static ShortUser GetShourtUser(User user)
        {
            return new ShortUser()
            {
                Name = user.Name,
                Age = user.Age,
                Id = Guid.NewGuid()
            };
        }
    }

    public class ShortUser
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"ID {Id}; Имя {Name}; Возраст {Age};";
        }
    }


    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public DateTime CreatedAt { get; set; }

        public override string ToString()
        {
            return $"Имя {Name}; Возраст {Age}; Зарегистрирован {CreatedAt.ToString("ВВ.MM.yy")}";
        }
    }
}


/*
а) Сгенерировать список из 1000 чисел в диапазоне (-100, 10000)
    1) Вывести все четные числа.
    2) Вывести все положительные числа, отсортированные по убыванию
    3) Вывести квадраты каждого четного и кубы каждого нечетного числа
    4) Вывести квадраты каждого четного числа, большего, чем 15, и меньшего, чем 600, отсортированного по возрастанию, без дублей.

б) Есть список из 
 
 
 
 
 
 
 */
