using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pet_game
{
    public class Player
    {
        #region data members
        private string name;
        private int coins;
        private DateTime lastPlay;
        #endregion

        #region constructor
        public Player(string name, int coins, DateTime lastPlay)
        {
            this.Name = name;
            this.Coins = coins;
            this.LastPlay = lastPlay;
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
                else throw new Exception("Player name cannot be empty!");
            }
        }
        public int Coins 
        { 
            get => coins; 
            set
            {
                if (value > 0)
                {
                    coins = value;
                }
                else coins = 0;
            }
        }
        public DateTime LastPlay { get => lastPlay; set => lastPlay = value; }
        #endregion

        #region methods
        public string DisplayData()
        {
            return this.Name + "\nCoins : " + this.Coins;
        }
        #endregion
    }
}