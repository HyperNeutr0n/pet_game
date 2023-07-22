﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace pet_game
{
    [Serializable]
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
            this.Health = 100;
            this.Energy = 100;
            this.Happiness = 100;
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

        public virtual void Play(Toy toy)
        {

        }

        public void Buy(Toy newToy)
        {
            if (this.Owner.Coins >= newToy.Price)
            {
                bool sudahpunya = false;
                foreach (Toy toy in ToyList)
                {
                    if (toy.Name == newToy.Name) 
                    sudahpunya = true;
                    break;
                }
                if (sudahpunya == false)
                {
                    this.toyList.Add(newToy);
                    this.Owner.Coins -= newToy.Price;
                }
                else
                {
                    throw new Exception("Barang sudah ada");
                }
            }
            else
            {
                throw new Exception("Koin tidak cukup");
            }
        }

        public string CheckHealth()
        {
            string condition = "";
            if(this.Health >= 10 && this.Health <= 50)
            {
                condition = "Weak";
            }
            else if (this.Health >= 51 && this.Health <= 75)
            {
                condition = "Moderate";
            }
            else 
            {
                condition = "Strong";
            }
            return condition;
        }

        public string CheckEnergy()
        {
            string condition = "";
            if (this.Energy >= 10 && this.Energy <= 50)
            {
                condition = "Weak";
            }
            else if (this.Energy >= 51 && this.Energy <= 75)
            {
                condition = "Moderate";
            }
            else
            {
                condition = "Strong";
            }
            return condition;
        }

        public string CheckHappy()
        {
            string condition = "";
            if (this.Happiness >= 10 && this.Happiness <= 50)
            {
                condition = "Weak";
            }
            else if (this.Happiness >= 51 && this.Happiness <= 75)
            {
                condition = "Moderate";
            }
            else
            {
                condition = "Strong";
            }
            return condition;
        }
        #endregion

        public abstract void ChangeStatus();
    }
}