using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace pet_game
{
    [Serializable]
    public class Cat : Pet
    {
        #region data members
        private bool vaccinationStatus;
        #endregion

        #region constructor
        public Cat(string name, Image picture, Player owner) : base(name, picture, owner)
        {
            this.VaccinationStatus = false;
        }
        #endregion

        #region properties
        public bool VaccinationStatus { get => vaccinationStatus; set => vaccinationStatus = value; }
        #endregion

        #region methods
        public override string DisplayData()
        {
            string status = "No";
            if (VaccinationStatus)
            {
                status = "Yes";
            }
            return base.DisplayDataPet() + "\nVaccination Status : " + status;
        }

        public override void Feed()
        {
            base.Health += 30;
            base.Energy += 50;
        }

        public override void Sleep()
        {
            base.Health += 20;
            base.Energy += 70;
        }

        public override void Play(Toy toy)
        {
            if(toy != null)
            {
                base.Happiness += toy.Benefit;
            }
        
        }

        public void Bath()
        {
            base.Health += 30;
        }

        public void Vaccinate()
        {
            if (base.Owner.Coins >= 1000 && this.VaccinationStatus == false)
            {
                this.VaccinationStatus = true;
                base.Owner.Coins -= 1000;
                base.Health += 40;
                base.Happiness -= 10;
            }
            else if (this.VaccinationStatus == true)
            {
                throw new Exception("Your cat has already vaccinated");
            }
            else if (base.Owner.Coins < 1000)
            {
                throw new Exception("Not enough coin");
            }
        }
        #endregion
    }
}