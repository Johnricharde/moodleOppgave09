using System.Threading.Channels;

namespace moodleOppgave09
{
    internal class Program
    {
        static void Main(string[] args)
        {

            static string checkWhatDay()
            {
                int input = askForUserInput();
                switch (input)
                {
                    case 1:
                        return "monday";
                    case 2:
                        return "tuesday";
                    case 3:
                        return "wednesday";
                    case 4:
                        return "thursday";
                    case 5:
                        return "friday";
                    case 6:
                        return "saturday";
                    case 7:
                        return "sunday";
                    default:
                        return checkWhatDay();
                }
            }



            static int askForUserInput()
            {
                Console.WriteLine("What day of the week is it?\n 1 = Monday\n 2 = Tuesday\n 3 = Wednesday\n 4 = Thursday\n 5 = Friday\n 6 = Saturday\n 7 = Sunday");
                return Convert.ToInt32(Console.ReadLine());
            }



            Console.WriteLine($"Today is {checkWhatDay()}");
        }
    }
}