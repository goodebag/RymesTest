using RymesTest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RymesTest.Design
{
    public interface IAnimalCreation
    {
      Animals  CreateAnimal (string AnimalName, string AnimalSound);
    }
}
