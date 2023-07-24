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
            return this.CurrentColor.ToString();
        }

        public override void Feed()
        {
            base.Health += 30;
            base.Energy += 50;
            base.Owner.Coins += 4000;
        }

        public override void Sleep()
        {
            base.Health += 60;
            base.Energy += 60;
            base.Owner.Coins += 6000;
        }

        public void ChangeColor(Color newColor)
        {
            this.CurrentColor = newColor;
        }

        public override void ChangeStatus()
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