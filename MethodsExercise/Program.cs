using System.Drawing;

namespace MethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)


        {
            

          Console.WriteLine("Hello! - What is your name ? ");
            var userName = Console.ReadLine();

            Console.WriteLine($"hi {userName}- What is your favorite color ?");
            var userFavoritecolor = Console.ReadLine();

            Console.WriteLine($"Nice color {userName} and - What is your favorite animal ? ");
            var userFavoriteanimal = Console.ReadLine();

            Console.WriteLine($" great! {userName} I love animals - What is your favorite band ?");
            var userFavoriteband = Console.ReadLine();




        }
    }
}