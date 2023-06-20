using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pet_game
{
    public class Toy
    {
        #region data members
        private string name;
        private int price;
        private int benefit;
        #endregion

        #region constructor
        public Toy(string name, int price, int benefit)
        {
            this.Name = name;
            this.Price = price;
            this.Benefit = benefit;
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
                else name = "Toy 1";
            }
        }
        public int Price 
        { 
            get => price; 
            set
            {
                if (value > 0)
                {
                    price = value;
                }
                else price = 0;
            }
        }
        public int Benefit 
        { 
            get => benefit; 
            set
            {
                if (value >= 1)
                {
                    benefit = value;
                }
                else benefit = 1;
            }
        }
        #endregion

        #region methods
        public string DisplayData()
        {
            return this.Name + "\n" + this.Price + " coins\n" + this.Benefit + "%";
        }
        #endregion
    }
}