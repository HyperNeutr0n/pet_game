using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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
        FormMain frmMain;
        int detik = 0;
        #endregion

        #region methods
        public void ProgressBarUpdate()
        {
            progressBarHappy.Value = frmMain.pet.Happiness;
            progressBarHealth.Value = frmMain.pet.Health;
            progressBarEnergy.Value = frmMain.pet.Energy;
        }

        public void StartGame()
        {
            
            labelDateTime.Text = DateTime.Now.ToString("dd/MMM/yyyy\nhh:mm:ss");
            labelTitle.Visible = false;
            labelCoin.Text = frmMain.pet.Owner.Coins.ToString();
            labelPet.Text = frmMain.pet.Name;
            labelPlayer.Text = frmMain.player.Name; 
            panelData.Visible = true;
            panelActivity.Visible = true;

            pictureBoxPet.Image = frmMain.pet.Picture;
            pictureBoxPet.SizeMode = PictureBoxSizeMode.StretchImage;

            if (frmMain.pet is Cat)
            {
                buttonClean.Enabled = false;
                labelVaccine.Visible = true;
                labelVaccine.Text = frmMain.pet.DisplayData();
                pictureBoxVac.Visible = true;
            }
            else if (frmMain.pet is Fish)
            {
                buttonSleep.Enabled = false;
                buttonPlay.Enabled = true;
                buttonBath.Enabled = false;
                buttonVaccinate.Enabled = false;
                this.BackgroundImage = Properties.Resources.shop;
            }
            else if (frmMain.pet is Chameleon)
            {
                buttonPlay.Enabled = false;
                buttonBath.Enabled = false;
                buttonClean.Enabled = false;
                buttonVaccinate.Enabled = false;
            }
            ProgressBarUpdate();
            timerGame.Start();
        }

        private void ChangeActivity(string activity)
        {
            if (frmMain.pet is Cat)
            {
                if (activity == "Feed")
                {
                    pictureBoxPet.Image = Properties.Resources.cat_feed;
                }
                else if (activity == "-")
                {
                    pictureBoxPet.Image = Properties.Resources.cat_happy;
                }
            }
            timerImage.Start();
        }
        #endregion

        #region form load
        private void FormGame_Load(object sender, EventArgs e)
        {
            frmMain = this.Owner as FormMain;
            StartGame();
            // if (File.Exists("DataPlayer.vc"))
            // {
            //  FileStream stream = new FileStream("DataPlater.vc", FileMode.Open, FileAccess.REad);
            // BinaryFormatter format = new BinaryFormatter();
            // listPlayer = (List<Player>) format.Deserialize(stream);
            // stream.Close();
            //  }

            //  if (File.Exists("DataPet.vc"))
            //  {
            // FileStream stream = new FileStream("DataPet.vc", FileMode.Open, FileAccess.REad);
            // BinaryFormatter format = new BinaryFormatter();
            // listPet = (List<Pet>)format.Deserialize(stream);
            // stream.Close();
            //}
        }
        #endregion

        #region game timer
        private void timerImage_Tick(object sender, EventArgs e)
        {
            detik++;
            if (detik == 3)
            {
                timerImage.Stop();
                ChangeActivity("-");
            }
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            frmMain.pet.ChangeStatus();
            labelHealth.Text = frmMain.pet.Health.ToString();
            ProgressBarUpdate();

            if (frmMain.pet.CheckEnergy() == "Weak" && frmMain.pet.CheckHappy() == "Weak" && frmMain.pet.CheckHealth() == "Weak")
            {
                timerGame.Stop();
                panelActivity.Visible = false;
                panelData.Visible = false;
                MessageBox.Show("You Lose");
            }
        }
        #endregion

        #region pet interaction buttons
        private void buttonFeed_Click(object sender, EventArgs e)
        {
            frmMain.pet.Feed();
            ProgressBarUpdate();
        }

        private void buttonSleep_Click(object sender, EventArgs e)
        {
            frmMain.pet.Sleep();
            ProgressBarUpdate();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            timerGame.Stop();
            FormSelectToys frmSelectToys = new FormSelectToys();
            frmSelectToys.Owner = this;
            frmSelectToys.TopLevel = false;
            frmMain.panelMain.Controls.Add(frmSelectToys);
            frmSelectToys.BringToFront();
            frmSelectToys.Show();
        }

        private void buttonBath_Click(object sender, EventArgs e)
        {
            ((Cat)frmMain.pet).Bath();
            ProgressBarUpdate();
        }

        private void buttonVaccinate_Click(object sender, EventArgs e)
        {
            try
            {
                ((Cat)frmMain.pet).Vaccinate();
                labelVaccine.Text = frmMain.pet.DisplayData();
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
                ((Fish)frmMain.pet).Clean();
                ProgressBarUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
