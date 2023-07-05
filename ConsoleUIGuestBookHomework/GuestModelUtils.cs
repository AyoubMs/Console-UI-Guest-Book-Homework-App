using GuestBookLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUIGuestBookHomework
{
    internal static class GuestModelUtils
    {
        internal static string GetInfoFromConsole(string message)
        {
            string output;
            bool isValid;
            do
            {
                Console.Write(message);
                output = Console.ReadLine();
                isValid = double.TryParse(output, out double dumb);

                if (isValid)
                {
                    Console.WriteLine("That's an invalid name");
                }

            } while (isValid);
            return output;
        }

        internal static int GetNumericalInfoFromConsole(string message)
        {
            bool isValid;
            int output;
            do
            {
                Console.Write(message);
                string outputText = Console.ReadLine();
                isValid = int.TryParse(outputText, out output);

                if (!isValid)
                {
                    Console.WriteLine("That's an invalid age.");
                }

            } while (!isValid);
            return isValid ? output : 0;
        }

        internal static void GetGuestsInfo(List<GuestModel> guests)
        {
            string moreGuestsComing = "";

            do
            {
                GuestModel guest = new GuestModel();

                guest.FirstName = GuestModelUtils.GetInfoFromConsole("What is your first name: ");

                guest.LastName = GuestModelUtils.GetInfoFromConsole("What is your last name: ");

                guest.MessageToHost = GuestModelUtils.GetInfoFromConsole("What message would you like to tell your host: ");

                guest.Age = GuestModelUtils.GetNumericalInfoFromConsole("How old are you: ");

                moreGuestsComing = GuestModelUtils.GetInfoFromConsole("Are more guests coming (yes/no): ");

                guests.Add(guest);

                Console.Clear();

            } while (moreGuestsComing.ToLower() == "yes");
        }

        internal static void PrintGuests(List<GuestModel> guests)
        {
            foreach (GuestModel guest in guests)
            {
                Console.WriteLine($"{guest.FirstName} {guest.LastName}, {guest.Age} years old says: {guest.MessageToHost}");
            }
        }
    }


}
