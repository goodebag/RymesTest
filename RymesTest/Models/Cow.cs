using System;
using System.Collections.Generic;
using System.Text;

namespace RymesTest.Models
{
   public class cow:Animals
    {
        public cow()
        {
            this.Name = "Cow";
            this.Sound = "Moo";
        }
    }
    public class ducks : Animals
    {
        public ducks()
        {
            this.Name = "ducks";
            this.Sound = "quack";
        }
    }
    public class cat : Animals
    {
        public cat()
        {
            this.Name = "cat";
            this.Sound = "meow";
        }
    }
    public class goat : Animals
    {
        public goat()
        {
            this.Name = "goat";
            this.Sound = "bleat";
        }
    }
    public class dog : Animals
    {
        public dog()
        {
            this.Name = "dog";
            this.Sound = "bark";
        }
    }
}
