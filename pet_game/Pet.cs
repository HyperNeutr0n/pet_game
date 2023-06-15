using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace pet_game
{
    public class Pet
    {
        private string name;
        private int health;
        private int energy;
        private int happiness;
        private Image picture;

        public Player Player
        {
            get => default;
            set
            {
            }
        }
    }
}