using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabysitterKata
{
    class Program
    {
        static void Main(string[] args)
        {
            BabysittingJob babySittingJob = new BabysittingJob();
            ConsoleKeyInfo userInput;

            do
            {
                int start;
                string startTime = "";

                while (!int.TryParse(startTime, out start))
                {
                    Console.Write("Please enter the start time:");
                    startTime = Console.ReadLine();
                }

                babySittingJob.StartTime = start;

                int end;
                string endTime = "";

                while (!int.TryParse(endTime, out end))
                {
                    Console.Write("Please enter the end time:");
                    endTime = Console.ReadLine();
                }

                babySittingJob.EndTime = end;

                int bed;
                string bedTime = "";

                while (!int.TryParse(bedTime, out bed))
                {
                    Console.Write("Please enter the bed time (enter for none):");
                    bedTime = Console.ReadLine();

                    if (bedTime == "")
                        break;
                }

                if (bedTime != "")
                    babySittingJob.BedTime = bed;

                Console.WriteLine("The amount due to the babysitter is {0:C}", babySittingJob.CalculatePay());
                do
                {
                    Console.WriteLine("Would you like to calculate again? (y/n)");
                    userInput = Console.ReadKey();
                    Console.Clear();

                } while (userInput.KeyChar.ToString().ToLower() != "n"
                    && userInput.KeyChar.ToString().ToLower() != "y");

            } while (userInput.KeyChar.ToString().ToLower() != "n");
        }
    }
}
