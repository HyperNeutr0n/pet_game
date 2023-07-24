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
        #region global variable
        public int rangeWalk = 2;
        public int animationDuration = 0;
        public int directionNum = 0;
        public int delayCount = 0;
        public int indexImage = 0;
        public string activity, toy;
        public int mostLeft, mostRight;
        public bool gameRunning = false;
        public int ChamColorIndex = 0;

        FormMain frmMain;
        #endregion

        #region images
        List<Image> listCatIdle = new List<Image> { Resources.cat_idle_000, Resources.cat_idle_001 };
        List<Image> listCatWalkLeft = new List<Image> { Resources.cat_walkingLeft_000, Resources.cat_walkingLeft_001 };
        List<Image> listCatWalkRight = new List<Image> { Resources.cat_walkingRight_000, Resources.cat_walkingRight_001 };
        List<Image> listCatEat = new List<Image> { Resources.cat_eat_000, Resources.cat_eat_001 };
        List<Image> listCatSleep = new List<Image> { Resources.cat_sleep_000, Resources.cat_sleep_001 };
        List<Image> listCatBath = new List<Image> { Resources.cat_bath_000, Resources.cat_bath_001 };
        List<Image> listCatAfterBath = new List<Image> { Resources.cat_afterBathIdle_000, Resources.cat_afterBathIdle_001 };
        List<Image> listCatVaccine = new List<Image> { Resources.cat_vaccinate_000, Resources.cat_vaccinate_001 };
        List<Image> listCatAfterVaccine = new List<Image> { Resources.cat_afterVaccine_000, Resources.cat_afterVaccine_001 };
        List<Image> listFishWalkLeft = new List<Image> { Resources.Fish_MoveL_1, Resources.Fish_MoveL_2, Resources.Fish_MoveL_3 };
        List<Image> listFishWalkRight = new List<Image> { Resources.Fish_MoveR_1, Resources.Fish_MoveR_2, Resources.Fish_MoveR_3 };
        List<Image> listFishEat = new List<Image> { Resources.Fish_Eat_1, Resources.Fish_Eat_2, Resources.Fish_Eat_3, Resources.Fish_Eat_4, Resources.Fish_Eat_5, Resources.Fish_Eat_6 };
        List<Image> listChameleonIdle = new List<Image> { Resources.Chameleon_Default, Resources.Chameleon_Idle, Resources.Chameleon_Color1, Resources.Chameleon_Color2, Resources.Chameleon_Color3, Resources.Chameleon_Color4, Resources.Chameleon_Color5 };
        List<Image> listChameleonWalkRight = new List<Image> { Resources.Chameleon_Default, Resources.ChameleonWalks_kanan };
        List<Image> listChameleonWalkLeft = new List<Image> { Resources.Chameleon_Default__Kiri, Resources.ChameleonWalks___Kiri };
        List<Image> listChameleonEat = new List<Image> { Resources.Chameleon_Feed, Resources.Chameleon_Feed2 };
        List<Image> listChameleonSleep = new List<Image> { Resources.Chameleon_Sleep1, Resources.Chameleon_Sleep2 };
        List<Image> listCatPlayBall = new List<Image> { Resources.Cat_Play_Ball, Resources.Cat_Play_Ball2};
        List<Image> listCatPlayStick = new List<Image> { Resources.Cat_Play_Stick, Resources.Cat_Play_Stick2 };
        List<Image> listCatPlayYarn = new List<Image> { Resources.Cat_Play_Yarn, Resources.Cat_Play_Yarn2 };
        List<Image> listChameleonWalkRight3 = new List<Image> { Resources.Chameleon_Color3, Resources.Chaemeleon_Color3_Walk };
        List<Image> listChameleonWalkLeft3 = new List<Image> { Resources.Chaemeleon_Color3_Kiri, Resources.Chaemeleon_Color3_KiriWalk };
        List<Image> listChameleonWalkRight4 = new List<Image> { Resources.Chameleon_Color4, Resources.Chaemeleon_Color4_Walk };
        List<Image> listChameleonWalkLeft4 = new List<Image> { Resources.Chaemeleon_Color4_Kiri, Resources.Chaemeleon_Color4_KiriWalk };
        List<Image> listChameleonWalkRight5 = new List<Image> { Resources.Chameleon_Color5, Resources.Chaemeleon_Color5_Walk };
        List<Image> listChameleonWalkLeft5 = new List<Image> { Resources.Chaemeleon_Color5_Kiri, Resources.Chaemeleon_Color5_KiriWalk };
        #endregion

        #region serialize
        private void SavePlayerData()
        {
            FileStream playerFile = new FileStream("DataPlayer.vc", FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(playerFile, frmMain.listPlayer);
            playerFile.Close();
        }

        private void SavePetData()
        {
            FileStream petFile = new FileStream("DataPet.vc", FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(petFile, frmMain.listPet);
            petFile.Close();
        }
        #endregion

        #region methods
        public void PanelDataUpdate()
        {
            progressBarHealth.Value = frmMain.pet.Health;
            progressBarHappy.Value = frmMain.pet.Happiness;
            progressBarEnergy.Value = frmMain.pet.Energy;
            labelHealth.Text = frmMain.pet.Health.ToString();
            labelEnergy.Text = frmMain.pet.Energy.ToString();
            labelHappy.Text = frmMain.pet.Happiness.ToString();
            labelCoin.Text = frmMain.player.Coins.ToString();
        }

        public void StartGame()
        {
            frmMain.PlaySfx(Resources.PlayStart);
            labelDateTime.Text = DateTime.Now.ToString("dd/MMM/yyyy\nhh:mm:ss");
            labelCoin.Text = frmMain.pet.Owner.Coins.ToString();
            labelPet.Text = frmMain.pet.Name;
            labelPlayer.Text = frmMain.player.Name;
            labelHealth.Visible = true;
            labelEnergy.Visible = true;
            labelHappy.Visible = true;
            panelData.Visible = true;
            panelActivity.Visible = true;

            pictureBoxPet.Image = frmMain.pet.Picture;
            pictureBoxPet.SizeMode = PictureBoxSizeMode.StretchImage;
            gameRunning = true;
            if (frmMain.pet is Cat)
            {
                pictureBoxClean.Enabled = false;
                labelSpecialStatus.Visible = true;
                labelSpecialStatus.Text = frmMain.pet.DisplayData();
                pictureBoxSpecial.Visible = true;
                pictureBoxSpecial.BackgroundImage = Resources.Suntik;
                this.BackgroundImage = Resources.Background_cat;
                pictureBoxPetIcon.BackgroundImage = Resources.PetIconCat;
                mostLeft = 0;
                mostRight = 1350;
                frmMain.PlayBgm("BGM\\cat.mp3");
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
                pictureBoxPetIcon.BackgroundImage = Resources.PetIconFish;
                pictureBoxPet.Top = 240;
                pictureBoxClean.Top = 110;
                mostLeft = 350;
                mostRight = 993;
                this.BackgroundImage = Properties.Resources.Background_Ikan;
                frmMain.PlayBgm("BGM\\fish.mp3");
            }
            else if (frmMain.pet is Chameleon)
            {
                pictureBoxPlay.Enabled = true;
                pictureBoxPlay.Visible = true;
                pictureBoxBath.Enabled = false;
                pictureBoxBath.Visible = false;
                pictureBoxClean.Enabled = false;
                pictureBoxClean.Visible = false;
                pictureBoxVaccine.Enabled = false;
                pictureBoxVaccine.Visible = false;
                pictureBoxPetIcon.BackgroundImage = Resources.PetIconCham;
                pictureBoxPet.Size = new Size(122, 104);
                pictureBoxPet.Top = 333;
                labelSpecialStatus.Visible = true;
                pictureBoxSpecial.Visible= true;
                pictureBoxSpecial.BackgroundImage = Resources.ColorWheel;
                if (((Chameleon)frmMain.pet).CurrentColor == Color.Green)
                {
                    labelSpecialStatus.Text = "Green";
                }
                else if (((Chameleon)frmMain.pet).CurrentColor == Color.Blue)
                {
                    labelSpecialStatus.Text = "Blue";
                }
                else if (((Chameleon)frmMain.pet).CurrentColor == Color.Yellow)
                {
                    labelSpecialStatus.Text = "Yellow";
                }
                else if (((Chameleon)frmMain.pet).CurrentColor == Color.Red)
                {
                    labelSpecialStatus.Text = "Red";
                }
                pictureBoxColor.Visible = true;
                pictureBoxColor.Top = 270;
                this.BackgroundImage = Resources.Background_Cham;
                mostLeft = 350;
                mostRight = 993;
                frmMain.PlayBgm("BGM\\chameleon.mp3");
            }
            PanelDataUpdate();
            timerGame.Start();
        }

        private void Animation(string activity)
        {
            // pengaturan jumlah frame untuk cat dan chameleon
            // karena jumlah frame cat dan chamelon sama maka bisa dilakukan pengecekan diawal
            if (frmMain.pet is Chameleon && activity == "idle") // pengecualian untuk idle chameleon punya 6 frame
            {
                if (indexImage > 6)
                {
                    indexImage = 0;
                }
            }
            else if (frmMain.pet is Cat || frmMain.pet is Chameleon)
            {
                if (indexImage > 1)
                {
                    indexImage = 0;
                }
            }
            // pengaturan animasi yang digunakan berdasarkan aktivitas
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
                if (frmMain.pet is Chameleon) 
                { 
                    pictureBoxPet.Image = listChameleonIdle[indexImage]; 
                }
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
                if (frmMain.pet is Chameleon)
                {
                    if (((Chameleon)frmMain.pet).CurrentColor == Color.Green)
                    {
                        { pictureBoxPet.Image = listChameleonWalkLeft[indexImage]; }
                    }
                    else if (((Chameleon)frmMain.pet).CurrentColor == Color.Blue)
                    {
                        { pictureBoxPet.Image = listChameleonWalkLeft3[indexImage]; }
                    }
                    else if (((Chameleon)frmMain.pet).CurrentColor == Color.Yellow)
                    {
                        { pictureBoxPet.Image = listChameleonWalkLeft5[indexImage]; }
                    }
                    else if (((Chameleon)frmMain.pet).CurrentColor == Color.Red)
                    {
                        { pictureBoxPet.Image = listChameleonWalkLeft4[indexImage]; }
                    }
                }
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
                if (frmMain.pet is Chameleon)
                {
                    if (((Chameleon)frmMain.pet).CurrentColor == Color.Green)
                    {
                        { pictureBoxPet.Image = listChameleonWalkRight[indexImage]; }
                    }
                    else if (((Chameleon)frmMain.pet).CurrentColor == Color.Blue)
                    {
                        { pictureBoxPet.Image = listChameleonWalkRight3[indexImage]; }
                    }
                    else if (((Chameleon)frmMain.pet).CurrentColor == Color.Yellow)
                    {
                        { pictureBoxPet.Image = listChameleonWalkRight5[indexImage]; }
                    }
                    else if (((Chameleon)frmMain.pet).CurrentColor == Color.Red)
                    {
                        { pictureBoxPet.Image = listChameleonWalkRight4[indexImage]; }
                    }
                }
                
            }
            else if (activity == "eat")
            {
                if (frmMain.pet is Cat) { pictureBoxPet.Image = listCatEat[indexImage]; }
                if (frmMain.pet is Fish)
                {
                    if (indexImage > 5) // limit animasi makan fish tidak lebih dari 6 frame
                    {
                        indexImage = 0;
                    }
                    pictureBoxPet.Image = listFishEat[indexImage];
                }
                if (frmMain.pet is Chameleon) { pictureBoxPet.Image = listChameleonEat[indexImage]; }
            }
            else if (activity == "sleep")
            {
                if (frmMain.pet is Cat) { pictureBoxPet.Image = listCatSleep[indexImage]; }
                if (frmMain.pet is Chameleon) { pictureBoxPet.Image = listChameleonSleep[indexImage]; }
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
            else if(activity == "afterVaccine")
            {
                pictureBoxPet.Image = listCatAfterVaccine[indexImage];
            }
            else if(activity == "play")
            {
                pictureBoxPet.Size = new Size(212, 194);
                if(toy == "Yarn")
                {
                    pictureBoxPet.Image = listCatPlayYarn[indexImage];
                }
                else if (toy == "Ball")
                {
                    pictureBoxPet.Image = listCatPlayBall[indexImage];
                }
                else if (toy == "Stick")
                {
                    pictureBoxPet.Image = listCatPlayStick[indexImage];
                }
            }
            indexImage++;
        }

        public int Direction() // membuat angka random antara 0 atau 1 untuk digunakan sebagai arah
        {
            Random rand = new Random();
            int direction = rand.Next(0, 2);
            return direction;
        }

        public void SmartMove(int directionNum) // pengaturan arah bergerak pet
        {
            if (directionNum == 0)
            {
                if (pictureBoxPet.Left > mostLeft)
                {
                    activity = "walkingLeft";
                    Animation(activity);
                    pictureBoxPet.Left -= rangeWalk;
                }
                else
                {
                    animationDuration = 30;
                }
            }
            else if (directionNum == 1)
            {
                if (pictureBoxPet.Left < mostRight)
                {
                    activity = "walkingRight";
                    Animation(activity);
                    pictureBoxPet.Left += rangeWalk;
                }
                else
                {
                    animationDuration = 30;
                }
            }
        }

        private void CheckFishItem()
        {
            if(frmMain.pet.ToyList != null)
            {
                foreach(Toy t in frmMain.pet.ToyList)
                {
                    if(t.Name == "Water Filter")
                    {
                        pictureBoxwater.Visible = true;
                    }
                    else if(t.Name == "Starfish")
                    {
                        pictureBoxStarfish.Visible = true;
                    }
                    else if(t.Name == "Lamp")
                    {
                        pictureBoxLamp.Visible = true;
                    }
                    else if(t.Name == "Humidifier")
                    {
                        pictureBoxwater.Image = Resources.Humidifier;
                        pictureBoxwater.Visible = true;

                    }
                    else if(t.Name == "Vines")
                    {
                        pictureBoxVines.Visible = true;
                    }
                }
            }
        }
        #endregion

        #region form load and close
        private void FormGame_Load(object sender, EventArgs e)
        {
            frmMain = this.Owner as FormMain;
            StartGame();
        }

        private void FormGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            SavePetData();
            SavePlayerData();
            frmMain.PlayBgm("BGM\\genshin.mp3");
        }
        #endregion

        #region game timer
        private void timerGame_Tick(object sender, EventArgs e)
        {
            frmMain.pet.ChangeStatus();
            PanelDataUpdate();
            if(frmMain.pet is Fish || frmMain.pet is Chameleon)
            {
                CheckFishItem();
            }

            if (frmMain.pet.CheckHealth() == "very-poor" && frmMain.pet.CheckEnergy() == "weak" && frmMain.pet.CheckHappy() == "unhappy")
            {
                timerGame.Stop();
                frmMain.PlaySfx(Resources.GameOver);
                panelActivity.Visible = false;
                panelData.Visible = false;

                frmMain.listPet.Remove(frmMain.pet);
                frmMain.listPlayer.Remove(frmMain.player);
                MessageBox.Show("You Lose");
                this.Close();
            }
        }

        private void timerPet_Tick(object sender, EventArgs e)
        {
            // jika durasi pet berjalan kurang dari 3 detik
            if (animationDuration < 30)
            {
                SmartMove(directionNum);
                animationDuration++;
                if (frmMain.pet is Cat || frmMain.pet is Chameleon)
                {
                    activity = "idle";
                    if(frmMain.pet is Cat)
                    {
                        frmMain.PlaySfx(Resources.Cat_Meow);
                    }
                    else if(frmMain.pet is Chameleon)
                    {
                        frmMain.PlaySfx(Resources.Chameleon_leaf);
                    }
                }
                if (frmMain.pet is Fish)
                {
                    frmMain.PlaySfx(Resources.Fish_Bubble);
                }
            }
            else
            {   // delay 5 detik (idle animation)
                delayCount++;
                Animation(activity);
                if (delayCount > 40)
                {
                    animationDuration = 0;
                    delayCount = 0;
                    directionNum = Direction();
                    if (activity == "bath")
                    {
                        activity = "afterBath";
                        animationDuration = 30;
                    }else if(activity == "vaccine")
                    {
                        activity = "afterVaccine";
                        animationDuration = 30;
                    }
                    else if (activity == "clean")
                    {
                        pictureBoxSpray.Visible = false;
                    }else if(activity == "play")
                    {
                        pictureBoxPet.Size = new Size(172, 154);
                    }
                }
            }

        }
        #endregion

        #region button activity hover
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
        #endregion

        #region button activity click
        private void pictureBoxEat_Click(object sender, EventArgs e)
        {
            frmMain.PlaySfx(Resources.Button_Sound1);
            frmMain.pet.Feed();
            PanelDataUpdate();
            activity = "eat";
            animationDuration = 30;
            delayCount = 0;
        }

        private void pictureBoxPlay_Click(object sender, EventArgs e)
        {
            frmMain.PlaySfx(Resources.Button_Sound1);
            timerGame.Stop();
            timerPet.Stop();
            FormSelectToys frmSelectToys = new FormSelectToys();
            frmSelectToys.Owner = this;
            frmSelectToys.TopLevel = false;
            frmMain.panelMain.Controls.Add(frmSelectToys);
            frmSelectToys.BringToFront();
            frmSelectToys.Show();
            
        }

        private void pictureBoxSleep_Click(object sender, EventArgs e)
        {
            frmMain.PlaySfx(Resources.Button_Sound1);
            frmMain.pet.Sleep();
            PanelDataUpdate();
            activity = "sleep";
            animationDuration = 30;
            delayCount = 0;
        }

        private void pictureBoxBath_Click(object sender, EventArgs e)
        {
            frmMain.PlaySfx(Resources.Button_Sound1);
            ((Cat)frmMain.pet).Bath();
            PanelDataUpdate();
            activity = "bath";
            animationDuration = 30;
            delayCount = 0;
        }

        private void pictureBoxVaccine_Click(object sender, EventArgs e)
        {
            frmMain.PlaySfx(Resources.Button_Sound1);
            try
            {
                ((Cat)frmMain.pet).Vaccinate();
                labelSpecialStatus.Text = frmMain.pet.DisplayData();
                activity = "vaccine";
                animationDuration = 30;
                delayCount = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBoxClean_Click(object sender, EventArgs e)
        {
            frmMain.PlaySfx(Resources.Button_Sound1);
            try
            {
                ((Fish)frmMain.pet).Clean();
                PanelDataUpdate();
                activity = "clean";
                pictureBoxSpray.Visible = true;
                animationDuration = 30;
                delayCount = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region button pause interaction
        private void pictureBoxPause_MouseHover(object sender, EventArgs e)
        {
            pictureBoxPause.BackgroundImage = Resources.Button_Pause_Hover;
        }

        private void pictureBoxPause_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxPause.BackgroundImage = Resources.Button_Pause;
        }

        private void pictureBoxPause_Click(object sender, EventArgs e)
        {
            if (gameRunning == true)
            {
                timerGame.Stop();
                timerPet.Stop();
                gameRunning = false;
                panelPause.Visible = true;
                pictureBoxTransparent.BringToFront();
                pictureBoxTransparent.BackColor = Color.FromArgb(125, Color.Black);
                panelPause.BringToFront();
                PictureBox pictureBoxPauseIcon = new PictureBox();
                pictureBoxPauseIcon.Location = new Point(661, 156);
                pictureBoxPauseIcon.Size = new Size(328, 8);
                pictureBoxPauseIcon.BackgroundImage = Resources.pauseIcon;
                pictureBoxPauseIcon.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBoxPauseIcon.BringToFront();
            }
        }
        #endregion

        #region paused interaction
        private void pictureBoxBGM_MouseHover(object sender, EventArgs e)
        {
            if (frmMain.bgmActive == true)
            {
                pictureBoxBGM.BackgroundImage = Resources.Button_Sound_hover;
            }
            else
            {
                pictureBoxBGM.BackgroundImage = Resources.Button_Mute_hover;
            }
        }

        private void pictureBoxBGM_MouseLeave(object sender, EventArgs e)
        {

            if (frmMain.bgmActive == true)
            {
                pictureBoxBGM.BackgroundImage = Resources.Button_Sound;
            }
            else
            {
                pictureBoxBGM.BackgroundImage = Resources.Button_Mute;
            }
        }

        private void pictureBoxBGM_Click(object sender, EventArgs e)
        {
            frmMain.PlaySfx(Resources.Button_Sound1);
            if (frmMain.bgmActive == true)
            {
                pictureBoxBGM.BackgroundImage = Resources.Button_Mute;
                frmMain.mxp.Ctlcontrols.pause();
                frmMain.bgmActive = false;
            }
            else
            {
                pictureBoxBGM.BackgroundImage = Resources.Button_Sound;
                frmMain.mxp.Ctlcontrols.play();
                frmMain.bgmActive = true;
            }
        }

        private void pictureBoxHome_MouseHover(object sender, EventArgs e)
        {
            pictureBoxHome.BackgroundImage = Resources.Button_Home_Hover;
        }

        private void pictureBoxHome_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxHome.BackgroundImage = Resources.Button_Home;
        }

        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
            frmMain.PlaySfx(Resources.Button_Sound1);
            SavePlayerData();
            SavePetData();
            this.Close();
        }

        private void pictureBoxResume_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxResume.BackgroundImage = Resources.Button_Resum;
        }

        private void pictureBoxResume_MouseHover(object sender, EventArgs e)
        {
            pictureBoxResume.BackgroundImage = Resources.Button_Resume_Hover;
        }


        private void pictureBoxColor_Click(object sender, EventArgs e)
        {
            ChamColorIndex++;
            if (ChamColorIndex == 1)
            {
                ((Chameleon)frmMain.pet).ChangeColor(Color.Blue);
                labelSpecialStatus.Text = "Blue";
            }
            else if (ChamColorIndex == 2)
            {
                ((Chameleon)frmMain.pet).ChangeColor(Color.Yellow);
                labelSpecialStatus.Text = "Yellow";
            }
            else if (ChamColorIndex == 3)
            {
                ((Chameleon)frmMain.pet).ChangeColor(Color.Red);
                labelSpecialStatus.Text = "Red";
            }
            else if (ChamColorIndex > 3)
            {
                ChamColorIndex = 0;
                ((Chameleon)frmMain.pet).ChangeColor(Color.Green);
                labelSpecialStatus.Text = "Green";
            }
        }

        private void pictureBoxResume_Click(object sender, EventArgs e)
        {
            frmMain.PlaySfx(Resources.Button_Sound1);
            gameRunning = true;
            panelPause.Visible = false;
            pictureBoxTransparent.SendToBack();
            pictureBoxTransparent.BackColor = Color.Transparent;
            timerGame.Start();
            timerPet.Start();
        }

        private void pictureBoxTransparent_Click(object sender, EventArgs e)
        {
            pictureBoxResume_Click(sender, e);
        }
        #endregion
    }
}
