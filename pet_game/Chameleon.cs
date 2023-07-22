using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace pet_game
{
    [Serializable]
    public class Chameleon : Pet
    {
        #region data members
        private Color currentColor;
        #endregion

        #region constructor
        public Chameleon(string name, Image picture, Player owner, Color currentColor) : base(name, picture, owner)
        {
            this.CurrentColor = currentColor;
        }
        #endregion

        #region prooperties
        public Color CurrentColor { get => currentColor; set => currentColor = value; }
        #endregion

        #region methods
        public override string DisplayData()
        {
            return base.DisplayDataPet() + "\nCurrent Color : " + this.CurrentColor.ToString();
        }

        public override void Feed()
        {
            base.Health += 30;
            base.Energy += 50;
        }

        public override void Sleep()
        {
            base.Health += 60;
            base.Energy += 60;

        }

        public void ChangeColor(Color newColor)
        {
            this.CurrentColor = newColor;
        }

        public override void ChangeStatus()
        {
            base.Happiness -= 5;
            base.Health -= 5;
            base.Energy -= 5;
        }
        #endregion
    }
}