using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace pet_game
{
    public class Fish : Pet
    {
        private string environment;

        public Fish(string name, Image picture, Player owner, string environment) : base(name, picture, owner)
        {
            this.Environment = environment;
        }

        public string Environment { get => environment; set => environment = value; }

        public override string DisplayData()
        {
            return base.DisplayDataPet() + "\nEnvironment : " + this.Environment;
        }
    }
}