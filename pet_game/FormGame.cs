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
    public partial class FormGame : Form
    {
        public FormGame()
        {
            InitializeComponent();
        }
        public Pet myPet;
        public Player myPlayer;
        private void playGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSelectPlayer formSelectPlayer = new FormSelectPlayer();
            formSelectPlayer.Owner = this;
            formSelectPlayer.ShowDialog();

        }
        public void StartGame()
        {
            labelPlayerData.Text = myPlayer.DisplayData();
            labelPetData.Text = myPet.DisplayData();
            labelDateTime.Text = DateTime.Now.ToString();
            panelData.Visible = true;
            panelActivity.Visible = true;
            labelTitle.Visible = false;
            pictureBoxPet.Image = myPet.Picture;
            pictureBoxPet.SizeMode = PictureBoxSizeMode.StretchImage;
            if(myPet is Cat)
            {
                buttonClean.Enabled = true;
            }else if(myPet is Fish)
            {
                buttonPlay.Enabled = false;
                buttonBath.Enabled = false;
                buttonClean.Enabled = false;
                buttonVaccinate.Enabled = false;
            }else if(myPet is Chameleon)
            {
                buttonPlay.Enabled = false;
                buttonBath.Enabled = false;
                buttonClean.Enabled = false;
                buttonVaccinate.Enabled = false;
            }
        }
        private void FormGame_Load(object sender, EventArgs e)
        {
            panelData.Visible = false;
            panelActivity.Visible = false;
        }

        private void resetGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changePetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxPet_Click(object sender, EventArgs e)
        {

        }
    }
}
