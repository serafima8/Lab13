using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Film> films = new List<Film>();

            Console.WriteLine("Введите информацию о фильме.");

            while (true)
            {
                Console.Write("Название: ");
                string title = Console.ReadLine();
                if (title.ToLower() == "выход")
                    break;

                Console.Write("Режиссер: ");
                string director = Console.ReadLine();

                Console.WriteLine("Введите актеров (через запятую): ");
                string actorsInput = Console.ReadLine();
                List<string> actors = new List<string>(actorsInput.Split(','));

                Film film = new Film(title, director, actors);
                films.Add(film);
            }

            Console.WriteLine("Выбирайте критерии сортировки: название, режиссер, актеры");
            string sortBy = Console.ReadLine().ToLower();

            switch (sortBy)
            {
                case "название":
                    films.Sort((x, y) => string.Compare(x.Title, y.Title));
                    break;
                case "режиссер:":
                    films.Sort((x, y) => string.Compare(x.Director, y.Director));
                    break;
                case "актеры":
                    films.Sort((x, y) => string.Compare(string.Join(", ", x.Actors), string.Join(", ", y.Actors)));
                    break;
                default:
                    Console.WriteLine("Неверные критерии сортировки.");
                    return;
            }

            Console.WriteLine("Отортированный фильм: ");
            foreach (var film in films)
            {
                Console.WriteLine(film);
            }
            Console.ReadKey();
        }
    }
}
