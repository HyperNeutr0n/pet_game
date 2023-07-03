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

        #region objects
        public Pet pet;
        public Player player;
        #endregion

        #region methods
        public void StartGame()
        {
            labelPlayerData.Text = player.DisplayData();
            labelPetData.Text = pet.DisplayData();
            labelDateTime.Text = DateTime.Now.ToString("dd/MMM/yyyy\nhh:mm:ss");
            labelTitle.Visible = false;

            panelData.Visible = true;
            panelActivity.Visible = true;

            pictureBoxPet.Image = pet.Picture;
            pictureBoxPet.SizeMode = PictureBoxSizeMode.StretchImage;

            if (pet is Cat)
            {
                buttonClean.Enabled = false;
            }
            else if (pet is Fish)
            {
                buttonSleep.Enabled = false;
                buttonPlay.Enabled = false;
                buttonBath.Enabled = false;
                buttonVaccinate.Enabled = false;
            }
            else if (pet is Chameleon)
            {
                buttonPlay.Enabled = false;
                buttonBath.Enabled = false;
                buttonClean.Enabled = false;
                buttonVaccinate.Enabled = false;
            }
        }
        #endregion

        #region form load
        private void FormGame_Load(object sender, EventArgs e)
        {
            panelData.Visible = false;
            panelActivity.Visible = false;
        }
        #endregion

        #region strip menu interaction
        private void playGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSelectPlayer formSelectPlayer = new FormSelectPlayer();
            formSelectPlayer.Owner = this;
            formSelectPlayer.ShowDialog();
        }
        

        private void resetGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changePetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region pet interaction buttons
        private void buttonFeed_Click(object sender, EventArgs e)
        {
            pet.Feed();

            labelPetData.Text = pet.DisplayData();
        }
        
        private void buttonSleep_Click(object sender, EventArgs e)
        {
            pet.Sleep();

            labelPetData.Text = pet.DisplayData();
        }
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            ((Cat)pet).Play();

            labelPetData.Text = pet.DisplayData();
        }

        private void buttonBath_Click(object sender, EventArgs e)
        {
            ((Cat)pet).Bath();

            labelPetData.Text = pet.DisplayData();
        }

        private void buttonVaccinate_Click(object sender, EventArgs e)
        {
            try
            {
                ((Cat)pet).Vaccinate();

                labelPetData.Text = pet.DisplayData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            try
            {
                ((Fish)pet).Clean();

                labelPetData.Text = pet.DisplayData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
