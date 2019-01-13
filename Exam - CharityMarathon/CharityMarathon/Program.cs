using System;
using System.Numerics;

namespace CharityMarathon
{
    class Program
    {
        static void Main(string[] args)
        {
            uint lenghtInDays = uint.Parse(Console.ReadLine());
            uint participants = uint.Parse(Console.ReadLine());
            uint laps = uint.Parse(Console.ReadLine());
            uint lenghtOfTrack = uint.Parse(Console.ReadLine());
            uint capacityOfTrack = uint.Parse(Console.ReadLine());
            decimal moneyPerKilometer = decimal.Parse(Console.ReadLine());
            uint maxRunners = lenghtInDays * capacityOfTrack;
            if (maxRunners < participants)
            {
                participants = maxRunners;
            }

            uint totalKilometers = (uint)(participants * laps * lenghtOfTrack)/1000;
            decimal moneyRaised = (decimal)(totalKilometers) * moneyPerKilometer;
            if (moneyRaised < 0)
            {
                Console.WriteLine("Error!");
            }
            Console.WriteLine($"Money raised: {moneyRaised:f2}");
        }
    }
}
