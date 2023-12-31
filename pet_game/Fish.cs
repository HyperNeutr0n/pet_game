﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace pet_game
{
    [Serializable]
    public class Fish : Pet
    {
        #region data members
        private string environment;
        #endregion

        #region constructor
        public Fish(string name, Image picture, Player owner, string environment) : base(name, picture, owner)
        {
            this.Environment = environment;
        }
        #endregion

        #region properties
        public string Environment 
        { 
            get => environment; 
            set
            {
                if (value == "River" || value == "Sea" || value == "Pond")
                {
                    environment = value;
                }
                else throw new Exception("Please select an environment for your fish!");
            }
        }
        #endregion

        #region methods
        public override string DisplayData()
        {
            return this.Environment;
        }

        public override void Feed()
        {
            base.Health += 20;
            base.Energy += 40;
            base.Owner.Coins += 3000;
        }

        public void Clean()
        {
            if (this.Owner.Coins >= 500)
            {
                base.Health += 60;
                base.Happiness += 50;
                this.Owner.Coins -= 500;
            }
            else
            {
                throw new Exception("Not enough coins to clean the pool!");
            }
        }

        public override void ChangeStatus() // semakin sedikit dekorasi semakin cepat status fish turun
        {
            base.Happiness -= (5 - CheckTotalDecoration());
            base.Health -= (5 - CheckTotalDecoration());
            base.Energy -= (5 - CheckTotalDecoration());
        }

        public override int CheckTotalDecoration() // kalkukasi jumlah dekorasi
        {
            if (base.ToyList.Count > -1)
            {
                if (base.ToyList.Count < 5)
                {
                    return base.ToyList.Count;
                }
                else
                {
                    return 4;
                }
            }
            else
            {
                return 0;
            }
        }
        #endregion
    }
}