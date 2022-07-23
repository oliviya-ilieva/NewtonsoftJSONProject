using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Newtonsoft.JSON
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var jsonText = File.ReadAllText(@"C:\Users\PC\OneDrive\Desktop\newtonsoft\input.txt");
            var movieStars = JsonConvert.DeserializeObject<IList<MovieStar>>(jsonText);

            foreach (var movieStar in movieStars)
            {
                Console.WriteLine("{0} {1}", movieStar.Name, movieStar.Surname);
                Console.WriteLine(movieStar.Sex);
                Console.WriteLine(movieStar.Nationality);

                // We use method to get the age of the user. Can be implemented in another way.
                int age = new DateTime(DateTime.Now.Subtract(movieStar.DateOfBirth).Ticks).Year - 1;
                Console.WriteLine(age + " years old");
                Console.WriteLine();


            }
             }
    }
}
