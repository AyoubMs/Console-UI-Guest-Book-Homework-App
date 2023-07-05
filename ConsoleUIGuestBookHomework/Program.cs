

using ConsoleUIGuestBookHomework;
using GuestBookLibrary;

List<GuestModel> guests = new List<GuestModel>();

GuestModelUtils.GetGuestsInfo(guests);

GuestModelUtils.PrintGuests(guests);

Console.ReadLine();