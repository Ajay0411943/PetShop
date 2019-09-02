using PetShop.Core.Entity;
using System;
using System.Collections.Generic;

namespace PetShopApp.Infrastructure.Data
{
    public static class FakeDB
    {

        private static List<Pet> allPets = new List<Pet>();
        static int id = 1;
        public static List<Pet> InitData()
        {
            var pet1 = new Pet()
            {
                Id = id++, Name = "Maroon", PreviousOwner = "Ajay", Type = "Dog", Price = 10000000000000000000,
                SoldDate = DateTime.Now, Birthdate = DateTime.Now,
                Color = "White and grey"
            };
            allPets.Add(pet1);

            var pet2 = new Pet()
            {
                Id = id++,
                Name = "Bruno", PreviousOwner = "Mars", Type = "Dog", Price = 24000,
                SoldDate = DateTime.Now, Birthdate = DateTime.Now,
                Color = "Hybrid"
            };
            allPets.Add(pet2);

            var pet3 = new Pet()
            {
                Id = id++,
                Name = "SnoopDog", PreviousOwner = "Nobody", Type = "Goat", Price = 50,
                SoldDate = DateTime.Now, Birthdate = DateTime.Now,
                Color = "Black"
            };
            allPets.Add(pet3);

            var pet4 = new Pet()
            {
                Id = id++,
                Name = "Max", PreviousOwner = "Anonymous", Type = "Cat", Price = 100,
                SoldDate = DateTime.Now, Birthdate = DateTime.Now,
                Color = "Orange"
            };

            allPets.Add(pet4);
            var pet5 = new Pet()
            {
                Id = id++,
                Name = "Pumpkin", PreviousOwner = "Julie", Type = "Frog", Price = 2000,
                SoldDate = DateTime.Now, Birthdate = DateTime.Now,
                Color = "white"
            };

            allPets.Add(pet5);
            var pet6 = new Pet()
            {
                Id = id++,
                Name = "Kelly", PreviousOwner = "Nelly", Type = "Cat", Price = 450,
                SoldDate = DateTime.Now, Birthdate = DateTime.Now,
                Color = "Hazel"
            };

            allPets.Add(pet6);

            return allPets;
        }

        public static int getID()
        {
            return id;
        }
    }
}
