using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pet_game
{
    public partial class FormSelectPlayer : Form
    {
        public FormSelectPlayer()
        {
            InitializeComponent();
        }
        FormGame frmGame;
        private void FormSelectPlayer_Load(object sender, EventArgs e)
        {
            
            frmGame = (FormGame)this.Owner.Owner;
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {/*
            frmGame.myPlayer = new Player(textBoxPlayerName.Text, 100, DateTime.Now);
            if (radioButtonCat.Checked)
            {
                frmGame.myPet = new Cat();
            }
            else if (radioButtonFish.Checked)
            {
                frmGame.myPet = new Fish();
            }
            else if (radioButtonChameleon.Checked)
            {
                frmGame.myPet = new Chameleon();
            }
            frmGame.StartGame();
            this.Close();
            this.Owner.Close();
            */
        }
    }
}
