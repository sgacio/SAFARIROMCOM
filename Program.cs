using System;

namespace SAFARIROMCOM
{
  class Program
  {

    static void SeedData()
    {
      var db = new SafariContext();
      var favoriteTrip = new Safari
      {
        species = "lion",
        NumberOfTimesSeen = 3,
        LocationLastSeen = "jungle"
      };
      db.Trip.Add(favoriteTrip);
      db.SaveChanges();
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      SeedData();
    }
  }
}
