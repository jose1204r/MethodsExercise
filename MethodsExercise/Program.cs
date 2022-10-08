using System.Drawing;

namespace MethodsExercise
{
    internal class Program
    {
        // five methods


        public static int sumNumber (int a, int b)
        {
            var anwserNubers = a + b;
            return anwserNubers;
        }

        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }

        public static int subtractMethod(int a1, int b2) {

            return a1 - b2;


        }
        public static int divideMethod(int c, int d) {

            return c / d;


        }


        public static int modulosMethod(int e, int f) {

            return e % f;


        }




        static void Main(string[] args)


        {

         // five mothods called

            var sumresult = sumNumber(4, 10);
            var resultMultipy = Multiply(10, 20, 100);
            var subtResult = subtractMethod(57, 68);
            var divResult = divideMethod(20,10);
            var modResult = modulosMethod(30, 50);

          
            // --------Excercie 1---------------------------------

          Console.WriteLine("Hello! - What is your name ? ");
            var userName = Console.ReadLine();

            Console.WriteLine($"hi {userName}- What is your favorite color ?");
            var userFavoritecolor = Console.ReadLine();

            Console.WriteLine($"Nice color {userName} and - What is your favorite animal ? ");
            var userFavoriteanimal = Console.ReadLine();

            Console.WriteLine($" great! {userName} I love animals - What is your favorite band ?");
            var userFavoriteband = Console.ReadLine();

            Console.WriteLine($"Thanks {userName} here is your profile !");
            Console.WriteLine("*******************************************");

            Console.WriteLine($" Name :{userName}");

            Console.WriteLine($" Color :{userFavoritecolor}");

            Console.WriteLine($" Favorite Animal : {userFavoriteanimal}");

            Console.WriteLine($"Favorite Band : {userFavoriteband}");
            

           



        }
    }
}