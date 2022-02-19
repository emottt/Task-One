using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Movie_Star
{
    class Program
    {
        static void Main(string[] args)
        {
            var results = movieStar();
            if(results != null)
            {
                for (int i = 0; i < results.Count; i++)
                {
                    var birthday = results[i].dateOfBirth;

                    var age = DateTime.Today.Year - birthday.Year;

                    if(birthday.Date > DateTime.Today.AddYears(-age))
                    {
                        age--;
                    }
                    Console.WriteLine($"{results[i].Name} {results[i].SurName}\n" +
                        $"{results[i].Sex}\n" +
                        $"{results[i].Nationality}\n" +
                        $"{age} years old\n");
                }
            }
        }

        static List<MovieStar> movieStar()
        {
            string fileName = @"G:\download\Test\Task One\JSON\movieStar.json";

            if (File.Exists(fileName))
            {
                var movieStar = JsonConvert.DeserializeObject<List<MovieStar>>(File.ReadAllText(fileName));

                return movieStar;
            }

            return null;
        } 
    }
}
