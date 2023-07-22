using pet_game.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
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
        int gravity = 2;
        int walkCount = 0;
        int directionNum = 0;
        int delayCount = 0;
        int indexImage = 0;
        string activity;
        #region CatImages
        List<Image> listCatIdle = new List<Image> { Resources.cat_idle_000, Resources.cat_idle_001 };
        List<Image> listCatWalkLeft = new List<Image> { Resources.cat_walkingLeft_000, Resources.cat_walkingLeft_001 };
        List<Image> listCatWalkRight = new List<Image> { Resources.cat_walkingRight_000, Resources.cat_walkingRight_001 };
        List<Image> listCatEat = new List<Image> { Resources.cat_eat_000, Resources.cat_eat_001 };
        List<Image> listCatSleep = new List<Image> { Resources.cat_sleep_000, Resources.cat_sleep_001 };
        List<Image> listCatBath = new List<Image> { Resources.cat_bath_000, Resources.cat_bath_001 };
        List<Image> listCatAfterBath = new List<Image> { Resources.cat_afterBathIdle_000, Resources.cat_afterBathIdle_001 };
        #endregion
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
            activity = "eat";
            walkCount = 30;
        }

        private void buttonSleep_Click(object sender, EventArgs e)
        {
            frmMain.pet.Sleep();
            ProgressBarUpdate();
            activity = "sleep";
            walkCount = 30;
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
            walkCount = 30;
        }

        private void buttonBath_Click(object sender, EventArgs e)
        {
            ((Cat)frmMain.pet).Bath();
            ProgressBarUpdate();
            activity = "bath";
            walkCount = 30;
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

        private void button1_Click(object sender, EventArgs e)
        {
            //SavePlayerData();
            //SavePetData();
            this.Close();
        }
        private void SavePlayerData()
        {
            FileStream playerFile = new FileStream("DataPlater.vc", FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(playerFile, frmMain.listPlayer);
        }
        private void SavePetData()
        {
            FileStream petFile = new FileStream("DataPlater.vc", FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(petFile, frmMain.listPlayer);
        }
        private void panelData_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        private void Animation(string activity)
        {
            if (indexImage > 1)
            {
                indexImage = 0;
            }
            if (activity == "idle")
            {
                if (frmMain.pet is Cat) { pictureBoxPet.Image = listCatIdle[indexImage]; }
                if (frmMain.pet is Fish) { pictureBoxPet.Image = listCatIdle[indexImage]; }
                if (frmMain.pet is Chameleon) { pictureBoxPet.Image = listCatIdle[indexImage]; }
            }
            else if (activity == "walkingLeft")
            {
                if (frmMain.pet is Cat) { pictureBoxPet.Image = listCatWalkLeft[indexImage]; }
                if (frmMain.pet is Fish) { pictureBoxPet.Image = listCatWalkLeft[indexImage]; }
                if (frmMain.pet is Chameleon) { pictureBoxPet.Image = listCatWalkLeft[indexImage]; }
            }
            else if (activity == "walkingRight")
            {
                if (frmMain.pet is Cat) { pictureBoxPet.Image = listCatWalkRight[indexImage]; }
                if (frmMain.pet is Fish) { pictureBoxPet.Image = listCatWalkRight[indexImage]; }
                if (frmMain.pet is Chameleon) { pictureBoxPet.Image = listCatWalkRight[indexImage]; }
            }
            else if(activity == "eat")
            {
                if (frmMain.pet is Cat) { pictureBoxPet.Image = listCatEat[indexImage]; }
                if (frmMain.pet is Fish) { pictureBoxPet.Image = listCatEat[indexImage]; }
                if (frmMain.pet is Chameleon) { pictureBoxPet.Image = listCatEat[indexImage]; }
            }
            else if (activity == "sleep")
            {
                if (frmMain.pet is Cat) { pictureBoxPet.Image = listCatSleep[indexImage]; }
                if (frmMain.pet is Chameleon) { pictureBoxPet.Image = listCatSleep[indexImage]; }
            }
            else if (activity == "bath")
            {
                if (frmMain.pet is Cat) { pictureBoxPet.Image = listCatBath[indexImage]; }
            }
            else if (activity == "afterBath")
            {
                if (frmMain.pet is Cat) { pictureBoxPet.Image = listCatAfterBath[indexImage]; }
            }
            indexImage++;
        }
        private void timerPet_Tick(object sender, EventArgs e)
        {
            if (walkCount < 30)
            {
                activity = "idle";
                SmartMove(directionNum);
                walkCount++;
            }
            else
            {// delay 5 detik (idle animation)
                delayCount++;
                Animation(activity);
                if (delayCount > 50)
                {
                    walkCount = 0;
                    delayCount = 0;
                    directionNum = Direction();
                    if (activity == "bath")
                    {
                        activity = "afterBath";
                        walkCount = 30;
                    }
                }
            }
           
        }
        public int Direction()
        {
            Random rand = new Random();
            int direction = rand.Next(0, 2);
            return direction;
        }
        public void SmartMove(int directionNum)
        {
            if (directionNum == 0)
            {
                if (pictureBoxPet.Left > 0)
                {
                    activity = "walkingLeft";
                    Animation(activity);
                    pictureBoxPet.Left -= gravity;
                }
                else
                {
                    walkCount = 30;
                }
            }
            else if (directionNum == 1)
            {
                if (pictureBoxPet.Left < 1350)
                {
                    activity = "walkingRight";
                    Animation(activity);
                    pictureBoxPet.Left += gravity;
                }
                else
                {
                    walkCount = 30;
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
