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
        public Pet pet;
        public Player player;

        public List<Player> listPlayer = new List<Player>();
        public List<Pet> listPet = new List<Pet>();
        int detik = 0;
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
            timerGame.Start();
        }
        #endregion

        #region form load
        private void FormGame_Load(object sender, EventArgs e)
        {
            panelData.Visible = false;
            panelActivity.Visible = false;

           // if (File.Exists("DataPlater.vc"))
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
            FormSelection selection= new FormSelection();
            selection.Owner= this;
            selection.ShowDialog();
            

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

        private void ChangeActivity(string activity)
        {
            if(pet is Cat)
            {
                if(activity == "Feed")
                {
                    pictureBoxPet.Image = Properties.Resources.cat_feed;
                }
                else if( activity == "-")
                {
                    pictureBoxPet.Image = Properties.Resources.cat_happy;
                }
            }
            timerImage.Start();

        }


        #endregion

        private void timerImage_Tick(object sender, EventArgs e)
        {
            detik++;
            if(detik == 3)
            {
                timerImage.Stop();
                ChangeActivity("-");
            }
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            pet.Happiness -= 10;
            pet.Energy-= 10;
            pet.Health-= 10;

            labelPetData.Text = pet.DisplayData();
            
            if(pet.CheckEnergy() == "Weak" && pet.CheckHappy()== "Weak" && pet.CheckHealth()== "Weak")
            {
                timerGame.Stop();
                panelActivity.Visible= false;
                panelData.Visible= false;
                MessageBox.Show("You Lose");
            }
        }

        private void SaveFilePlayer(string filename)
        {
            FileStream stream = new FileStream(filename, FileMode.Create, FileAccess.Write);
            BinaryFormatter format = new BinaryFormatter();
            format.Serialize(stream, listPlayer);
            stream.Close();
        }

        private void SaveFilePet(string filename)
        {
            FileStream stream = new FileStream(filename, FileMode.Create, FileAccess.Write);
            BinaryFormatter format = new BinaryFormatter();
            format.Serialize(stream, listPet);
            stream.Close();
        }
        private void FormGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            //SaveFilePlayer("DataPlater.vc");
            //SaveFilePet("DataPet.vc");
        }
    }
}
