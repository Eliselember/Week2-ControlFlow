using System;

namespace WhenWereYouBorn
{
    class Program
    {
        static void Main(string[] args)
        {

           

            //programm küsib kasutaja sünniaastat
            //programm arvutab kasutaja vanust
            //programm kuvab kasutaja vanust
            Console.WriteLine("Sisesta oma sünniaasta:");

            //convert string from ReadLine () to int

            int YearOfBirth = Convert.ToInt32(Console.ReadLine());

            int Age = YearOfBirth;

            Console.WriteLine($"Sa oled{Age} vana?");






            
        }
    }
}
