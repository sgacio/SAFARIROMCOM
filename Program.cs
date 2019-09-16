﻿using System;
using System.Linq;

namespace SAFARIROMCOM
{
  class Program
  {

    // static void SeedData()
    // {
    //   var db = new SafariContext();
    //   var favoriteTrip = new Safari
    //   {
    //     species = "lion",
    //     NumberOfTimesSeen = 3,
    //     LocationLastSeen = "jungle"
    //   };
    //   var favoriteTrip1 = new Safari
    //   {
    //     species = "tiger",
    //     NumberOfTimesSeen = 2,
    //     LocationLastSeen = "jungle"
    //   };
    //   var favoriteTrip2 = new Safari
    //   {
    //     species = "bear",
    //     NumberOfTimesSeen = 2,
    //     LocationLastSeen = "forest"
    //   };
    //   var favoriteTrip3 = new Safari
    //   {
    //     species = "Mark Dewey",
    //     NumberOfTimesSeen = 2,
    //     LocationLastSeen = "under water but above ground"
    //   };
    //   var favoriteTrip4 = new Safari
    //   {
    //     species = "Albert Strange",
    //     NumberOfTimesSeen = 2,
    //     LocationLastSeen = "Dessert"
    //   };
    //   db.Trip.Add(favoriteTrip);
    //   db.Trip.Add(favoriteTrip1);
    //   db.Trip.Add(favoriteTrip2);
    //   db.Trip.Add(favoriteTrip3);
    //   db.Trip.Add(favoriteTrip4);
    //   db.SaveChanges();
    // }

    static void animalsSeen()
    {
      var db = new SafariContext();
      var whichAnimals = db.Trip.Select(timeOut => timeOut.species);
      //   Console.WriteLine($"{whichAnimals}");    
      foreach (var animal in whichAnimals)
      {
        Console.WriteLine(animal);
      }
      Console.WriteLine("its the animals");
    }

    static void whereISeeYou()
    {
      var db = new SafariContext();
      var whereAt = db.Trip.Where(where => where.LocationLastSeen == "jungle");
      foreach (var animal in whereAt)
      {
        Console.WriteLine(animal.species);
      }
    }

    static void animalsSeenUpdate()
    {
      var db = new SafariContext();
      var updateTheseKids = db.Trip.FirstOrDefault(vacation => vacation.species == "Albert Strange");
      if (updateTheseKids != null)
      {
        updateTheseKids.NumberOfTimesSeen = 7;
        updateTheseKids.LocationLastSeen = "Gym";
        db.SaveChanges();
      }

      //   var alberts = db.Trip.Where(tr => tr.species == "Albert Strange");
      //   foreach (var albert in alberts)
      //   {
      //     albert.LocationLastSeen = "dessert";
      //   }
      db.SaveChanges();
    }

    static void MarkDoesntLikeTheDessert()
    {
      var db = new SafariContext();
      var deleteTheDessert = db.Trip.Where(area => area.LocationLastSeen == "")
    }

    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      //   SeedData();
      animalsSeen();
      animalsSeenUpdate();
      whereISeeYou();
    }
  }
}
