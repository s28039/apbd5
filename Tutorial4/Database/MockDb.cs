﻿using Tutorial4.Models;
namespace Tutorial4.Database;
public class MockDb
{
    public List<Animal> Animals { get; set; } = new List<Animal>
    {
        new Animal { Id = 1, FirstName = "Kamil", Category = "Lion", Weight = 80.5, FurColor = "Blue" },
        new Animal { Id = 2, FirstName = "Witkowski", Category = "Dog", Weight = 70.2, FurColor = "Red" }
    };
    
    // Pobranie wszystkich zwierząt
    public IEnumerable<Animal> GetAll()
    {
        return Animals;
    }

    // Pobranie zwierzęcia po Id
    public Animal GetAnimalById(int id)
    {
        return Animals.FirstOrDefault(a => a.Id == id);
    }

    // Dodanie nowego zwierzęcia
    public void AddAnimal(Animal animal)
    {
        // Ustalenie nowego Id dla zwierzęcia
        int newId = Animals.Count > 0 ? Animals.Max(a => a.Id) + 1 : 1;
        animal.Id = newId;
        Animals.Add(animal);
    }

    // Aktualizacja istniejącego zwierzęcia
    public void UpdateAnimal(int id, Animal animal)
    {
        var existingAnimal = Animals.FirstOrDefault(a => a.Id == id);
        if (existingAnimal != null)
        {
            existingAnimal.FirstName = animal.FirstName;
            existingAnimal.Category = animal.Category;
            existingAnimal.Weight = animal.Weight;
            existingAnimal.FurColor = animal.FurColor;
        }
    }
    // Usunięcie zwierzęcia po Id
    public void DeleteAnimal(int id)
    {
        var animalToRemove = Animals.FirstOrDefault(a => a.Id == id);
        if (animalToRemove != null)
        {
            Animals.Remove(animalToRemove);
        }
    }
}