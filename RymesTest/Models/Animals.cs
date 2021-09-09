using System;
using System.Collections.Generic;
using System.Text;

namespace RymesTest.Models
{
    public class Animals
    {
        public string Name { get; set; }
        public string Sound { get; set; }
        public Animals()
        {

        }
        public Animals(string name, string sound)
        {
            this.Name = name;
            this.Sound = sound;
        }
        public string MakeSound()
        {
            return Sound;
        }
    }
}
