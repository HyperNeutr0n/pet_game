using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace pet_game
{
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
        #endregion
    }
}