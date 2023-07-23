﻿using pet_game.Properties;
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
        #region global variable
        int gravity = 2;
        int walkCount = 0;
        int directionNum = 0;
        int delayCount = 0;
        int indexImage = 0;
        string activity;
        int detik = 0;
        int batasKiri, batasKanan;
        #endregion

        #region Images
        List<Image> listCatIdle = new List<Image> { Resources.cat_idle_000, Resources.cat_idle_001 };
        List<Image> listCatWalkLeft = new List<Image> { Resources.cat_walkingLeft_000, Resources.cat_walkingLeft_001 };
        List<Image> listCatWalkRight = new List<Image> { Resources.cat_walkingRight_000, Resources.cat_walkingRight_001 };
        List<Image> listCatEat = new List<Image> { Resources.cat_eat_000, Resources.cat_eat_001 };
        List<Image> listCatSleep = new List<Image> { Resources.cat_sleep_000, Resources.cat_sleep_001 };
        List<Image> listCatBath = new List<Image> { Resources.cat_bath_000, Resources.cat_bath_001 };
        List<Image> listCatAfterBath = new List<Image> { Resources.cat_afterBathIdle_000, Resources.cat_afterBathIdle_001 };
        List<Image> listCatVaccine = new List<Image> { Resources.cat_vaccinate_000, Resources.cat_vaccinate_001 };
        List<Image> listCatAfterVaccine = new List<Image> { Resources.cat_afterBathIdle_000, Resources.cat_afterBathIdle_001 };
        List<Image> listFishWalkLeft = new List<Image> { Resources.Fish_MoveL_1, Resources.Fish_MoveL_2, Resources.Fish_MoveL_3 };
        List<Image> listFishWalkRight = new List<Image> { Resources.Fish_MoveR_1, Resources.Fish_MoveR_2, Resources.Fish_MoveR_3 };
        List<Image> listFishEat = new List<Image> { Resources.Fish_Eat_1, Resources.Fish_Eat_2, Resources.Fish_Eat_3, Resources.Fish_Eat_4, Resources.Fish_Eat_5, Resources.Fish_Eat_6 };
        #endregion

        #region objects
        FormMain frmMain;
        #endregion

        #region methods
        public void ProgressBarUpdate()
        {
            progressBarHappy.Value = frmMain.pet.Happiness;
            progressBarHealth.Value = frmMain.pet.Health;
            progressBarEnergy.Value = frmMain.pet.Energy;
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
        public void StartGame()
        {
            frmMain.PlaySound(Resources.PlayStart);
            labelDateTime.Text = DateTime.Now.ToString("dd/MMM/yyyy\nhh:mm:ss");
            labelCoin.Text = frmMain.pet.Owner.Coins.ToString();
            labelPet.Text = frmMain.pet.Name;
            labelPlayer.Text = frmMain.player.Name; 
            panelData.Visible = true;
            panelActivity.Visible = true;

            pictureBoxPet.Image = frmMain.pet.Picture;
            pictureBoxPet.SizeMode = PictureBoxSizeMode.StretchImage;

            if (frmMain.pet is Cat)
            {
                pictureBoxClean.Enabled = false;
                labelSpecialStatus.Visible = true;
                labelSpecialStatus.Text = frmMain.pet.DisplayData();
                pictureBoxSpecial.Visible = true;
                pictureBoxSpecial.BackgroundImage = Resources.Suntik;
                this.BackgroundImage = Resources.Background_cat;
                batasKiri = 0;
                batasKanan = 1350;
                frmMain.MediaPlayer("BGM_1.wav");
            }
            else if (frmMain.pet is Fish)
            {
                pictureBoxSleep.Enabled = false;
                pictureBoxSleep.Visible = false;
                pictureBoxPlay.Enabled = true;
                pictureBoxBath.Enabled = false;
                pictureBoxBath.Visible = false;
                pictureBoxVaccine.Enabled = false;
                pictureBoxVaccine.Visible = false;
                pictureBoxSpecial.Visible = true;
                pictureBoxSpecial.BackgroundImage = Resources.Environment;
                labelSpecialStatus.Visible = true;
                labelSpecialStatus.Text = frmMain.pet.DisplayData();
                pictureBoxPet.Top = 240;
                pictureBoxClean.Top = 110;
                batasKiri = 350;
                batasKanan = 993;
                this.BackgroundImage = Properties.Resources.Background_Ikan;
            }
            else if (frmMain.pet is Chameleon)
            {
                pictureBoxPlay.Enabled = false;
                pictureBoxPlay.Visible = false;
                pictureBoxBath.Enabled = false;
                pictureBoxBath.Visible= false;
                pictureBoxClean.Enabled = false;
                pictureBoxClean.Visible = false;
                pictureBoxVaccine.Enabled = false;
                pictureBoxVaccine.Visible = false;
                this.BackgroundImage = Resources.dawnbackground;
            }
            ProgressBarUpdate();
            timerGame.Start();
        }
        private void Animation(string activity)
        {
            if (frmMain.pet is Cat)
            {
                if (indexImage > 1)
                {
                    indexImage = 0;
                }
            }
            if (activity == "idle")
            {
                if (frmMain.pet is Cat) { pictureBoxPet.Image = listCatIdle[indexImage]; }
                if (frmMain.pet is Fish)
                {
                    if (indexImage > 2)
                    {
                        indexImage = 0;
                    }
                    pictureBoxPet.Image = listFishWalkLeft[indexImage];
                }
                if (frmMain.pet is Chameleon) { pictureBoxPet.Image = listCatIdle[indexImage]; }
            }
            else if (activity == "walkingLeft" || activity == "clean")
            {
                if (frmMain.pet is Cat) { pictureBoxPet.Image = listCatWalkLeft[indexImage]; }
                if (frmMain.pet is Fish)
                {
                    if (indexImage > 2)
                    {
                        indexImage = 0;
                    }
                    pictureBoxPet.Image = listFishWalkLeft[indexImage];
                }
                if (frmMain.pet is Chameleon) { pictureBoxPet.Image = listCatWalkLeft[indexImage]; }
            }
            else if (activity == "walkingRight" || activity == "clean")
            {
                if (frmMain.pet is Cat) { pictureBoxPet.Image = listCatWalkRight[indexImage]; }
                if (frmMain.pet is Fish)
                {
                    if (indexImage > 2)
                    {
                        indexImage = 0;
                    }
                    pictureBoxPet.Image = listFishWalkRight[indexImage];
                }
                if (frmMain.pet is Chameleon) { pictureBoxPet.Image = listCatWalkRight[indexImage]; }
            }
            else if (activity == "eat")
            {
                if (frmMain.pet is Cat) { pictureBoxPet.Image = listCatEat[indexImage]; }
                if (frmMain.pet is Fish)
                {
                    if (indexImage > 5)
                    {
                        indexImage = 0;
                    }
                    pictureBoxPet.Image = listFishEat[indexImage];
                }
                if (frmMain.pet is Chameleon) { pictureBoxPet.Image = listCatEat[indexImage]; }
            }
            else if (activity == "sleep")
            {
                if (frmMain.pet is Cat) { pictureBoxPet.Image = listCatSleep[indexImage]; }
                if (frmMain.pet is Chameleon) { pictureBoxPet.Image = listCatSleep[indexImage]; }
            }
            else if (activity == "bath")
            {
                pictureBoxPet.Image = listCatBath[indexImage];
            }
            else if (activity == "afterBath")
            {
                pictureBoxPet.Image = listCatAfterBath[indexImage];
            }
            else if (activity == "vaccine")
            {
                pictureBoxPet.Image = listCatVaccine[indexImage];
            }
            indexImage++;
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
                if (pictureBoxPet.Left > batasKiri)
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
                if (pictureBoxPet.Left < batasKanan)
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
        #endregion

        #region form load
        private void FormGame_Load(object sender, EventArgs e)
        {
            frmMain = this.Owner as FormMain;
            StartGame();
        }
        #endregion

        #region game timer
        private void timerGame_Tick(object sender, EventArgs e)
        {
            frmMain.pet.ChangeStatus();
            labelHealth.Text = frmMain.pet.Health.ToString();
            ProgressBarUpdate();

            if (frmMain.pet.CheckEnergy() == "Weak" && frmMain.pet.CheckHappy() == "Weak" && frmMain.pet.CheckHealth() == "Weak")
            {
                timerGame.Stop();
                frmMain.PlaySound(Resources.GameOver);
                panelActivity.Visible = false;
                panelData.Visible = false;
                MessageBox.Show("You Lose");
            }
        }
        private void timerPet_Tick(object sender, EventArgs e)
        {
            if (walkCount < 30)
            {
                SmartMove(directionNum);
                walkCount++;
                if (frmMain.pet is Cat)
                {
                    activity = "idle";
                }

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
                    else if (activity == "clean")
                    {
                        pictureBoxSpray.Visible = false;
                    }
                }
            }

        }
        #endregion

        #region Activity Hover
        private void pictureBoxEat_MouseHover(object sender, EventArgs e)
        {
            pictureBoxEat.BackgroundImage = Resources.Icon_Feed_Hover;
        }

        private void pictureBoxEat_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxEat.BackgroundImage = Resources.Icon_Feed;
        }

        private void pictureBoxPlay_MouseHover(object sender, EventArgs e)
        {
            pictureBoxPlay.BackgroundImage = Resources.Icon_Play_hover;
        }

        private void pictureBoxPlay_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxPlay.BackgroundImage = Resources.Icon_Play;
        }

        private void pictureBoxSleep_MouseHover(object sender, EventArgs e)
        {
            pictureBoxSleep.BackgroundImage = Resources.Icon_Sleep_Hover;
        }
        private void pictureBoxSleep_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxSleep.BackgroundImage = Resources.Icon_Sleep;
        }

        private void pictureBoxBath_MouseHover(object sender, EventArgs e)
        {
            pictureBoxBath.BackgroundImage= Resources.Icon_Bath_Hover;
        }

        private void pictureBoxBath_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxBath.BackgroundImage = Resources.Icon_Bath;
        }

        private void pictureBoxVaccine_MouseHover(object sender, EventArgs e)
        {
            pictureBoxVaccine.BackgroundImage = Resources.Icn_Vaccine_Hover;
        }

        private void pictureBoxVaccine_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxVaccine.BackgroundImage = Resources.Icon_Vaccine;
        }

        private void pictureBoxClean_MouseHover(object sender, EventArgs e)
        {
            pictureBoxClean.BackgroundImage = Resources.Icon_Clean_hover;
        }

        private void pictureBoxClean_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxClean.BackgroundImage = Resources.Icon_Clean;
        }
        private void pictureBoxPause_MouseHover(object sender, EventArgs e)
        {
            pictureBoxPause.BackgroundImage = Resources.Button_Pause_Hover;
        }
        private void pictureBoxPause_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxPause.BackgroundImage = Resources.Button_Pause;
        }
        #endregion

        #region Buttons
        private void pictureBoxEat_Click(object sender, EventArgs e)
        {
            frmMain.PlaySound(Resources.Button_Sound1);
            frmMain.pet.Feed();
            ProgressBarUpdate();
            activity = "eat";
            walkCount = 30;
            delayCount = 0;
        }

        private void pictureBoxPlay_Click(object sender, EventArgs e)
        {
            frmMain.PlaySound(Resources.Button_Sound1);
            timerGame.Stop();
            FormSelectToys frmSelectToys = new FormSelectToys();
            frmSelectToys.Owner = this;
            frmSelectToys.TopLevel = false;
            frmMain.panelMain.Controls.Add(frmSelectToys);
            frmSelectToys.BringToFront();
            frmSelectToys.Show();
            walkCount = 30;
            delayCount = 0;
        }

        private void pictureBoxSleep_Click(object sender, EventArgs e)
        {
            frmMain.PlaySound(Resources.Button_Sound1);
            frmMain.pet.Sleep();
            ProgressBarUpdate();
            activity = "sleep";
            walkCount = 30;
            delayCount = 0;
        }

        private void pictureBoxBath_Click(object sender, EventArgs e)
        {
            frmMain.PlaySound(Resources.Button_Sound1);
            ((Cat)frmMain.pet).Bath();
            ProgressBarUpdate();
            activity = "bath";
            walkCount = 30;
            delayCount = 0;
        }

        private void pictureBoxVaccine_Click(object sender, EventArgs e)
        {
            frmMain.PlaySound(Resources.Button_Sound1);
            try
            {
                ((Cat)frmMain.pet).Vaccinate();
                labelSpecialStatus.Text = frmMain.pet.DisplayData();
                activity = "vaccine";
                walkCount = 30;
                delayCount = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBoxClean_Click(object sender, EventArgs e)
        {
            frmMain.PlaySound(Resources.Button_Sound1);
            try
            {
                ((Fish)frmMain.pet).Clean();
                ProgressBarUpdate();
                activity = "clean";
                pictureBoxSpray.Visible = true;
                walkCount = 30;
                delayCount = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBoxPause_Click(object sender, EventArgs e)
        {
            timerGame.Stop();
            timerPet.Stop();
        }
        #endregion
    }
}
