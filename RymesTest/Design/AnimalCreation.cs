using RymesTest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RymesTest.Design
{
    class AnimalCreation : IAnimalCreation
    {
        public Animals CreateAnimal(string AnimalName, string AnimalSound)
        {
            return new Animals() { Name = AnimalName, Sound = AnimalSound };
        }
    }
}
