using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace pet_game
{
    public abstract class Pet
    {
        #region data members
        private string name;
        private int health;
        private int energy;
        private int happiness;
        private Image picture;
        private Player owner;
        private List<Toy> toyList;
        #endregion

        #region constructor
        protected Pet(string name, Image picture, Player owner)
        {
            this.Name = name;
            this.Health = 40;
            this.Energy = 40;
            this.Happiness = 40;
            this.Picture = picture;
            this.Owner = owner;
            this.ToyList = new List<Toy>();
        }
        #endregion

        #region properties
        public string Name 
        { 
            get => name; 
            set
            {
                if (value.Length > 0)
                {
                    name = value;
                }
                else throw new Exception("Pet name cannot be empty!");
            }
        }
        public int Health 
        { 
            get => health;
            set
            {
                if (value >= 10 && value <= 100)
                {
                    health = value;
                }
                else if (value >= 100)
                {
                    health = 100;
                }
                else
                {
                    health = 10;
                }
            }
        }
        public int Energy 
        { 
            get => energy;
            set
            {
                if (value >= 10 && value <= 100)
                {
                    energy = value;
                }
                else if (value >= 100)
                {
                    energy = 100;
                }
                else
                {
                    energy = 10;
                }
            }
        }
        public int Happiness 
        { 
            get => happiness;
            set
            {
                if (value >= 10 && value <= 100)
                {
                    happiness = value;
                }
                else if (value >= 100)
                {
                    happiness = 100;
                }
                else
                {
                    happiness = 10;
                }
            }
        }
        public Image Picture { get => picture; set => picture = value; }
        public Player Owner { get => owner; set => owner = value; }
        public List<Toy> ToyList { get => toyList; set => toyList = value; }
        #endregion

        #region methods
        public abstract string DisplayData();

        protected string DisplayDataPet()
        {
            return this.Name + "\nHealth : " + this.Health + "%   Energy : " + this.Energy + "%   Happiness : " + this.Happiness + "%";
        }

        public abstract void Feed();

        public virtual void Sleep()
        {
            return;
        }
        #endregion
    }
}