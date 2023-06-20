using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace pet_game
{
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
        #endregion
    }
}