using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace pet_game
{
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
        public string Environment { get => environment; set => environment = value; }
        #endregion

        #region methods
        public override string DisplayData()
        {
            return base.DisplayDataPet() + "\nEnvironment : " + this.Environment;
        }

        public override void Feed()
        {
            base.Health += 20;
            base.Energy += 40;
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
        #endregion
    }
}