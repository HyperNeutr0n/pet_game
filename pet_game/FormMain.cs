using pet_game.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pet_game
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        #region objects
        public Pet pet;
        public Player player;
        SoundPlayer sfx;

        public List<Player> listPlayer = new List<Player>();
        public List<Pet> listPet = new List<Pet>();
        #endregion

        #region button interactions
        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            FormSelectPet formSelectPet = new FormSelectPet();
            formSelectPet.Owner = this;
            formSelectPet.TopLevel = false;
            panelMain.Controls.Add(formSelectPet);
            formSelectPet.BringToFront();
            formSelectPet.Show();
        }

        private void buttonContinueGame_Click(object sender, EventArgs e)
        {
            /*FormSelectPlayer formSelectPlayer = new FormSelectPlayer();
            formSelectPlayer.Owner = this;
            formSelectPlayer.TopLevel = false;
            panelMain.Controls.Add(formSelectPlayer);
            formSelectPlayer.BringToFront();
            formSelectPlayer.Show();*/
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {/*
            if (File.Exists("DataPlayer.vc"))
            {
            FileStream stream = new FileStream("DataPlater.vc", FileMode.Open, FileAccess.Read);
            BinaryFormatter format = new BinaryFormatter();
            listPlayer = (List<Player>) format.Deserialize(stream);
            stream.Close();
            }

            if (File.Exists("DataPet.vc"))
            {
            FileStream stream = new FileStream("DataPet.vc", FileMode.Open, FileAccess.Read);
            BinaryFormatter format = new BinaryFormatter();
            listPet = (List<Pet>)format.Deserialize(stream);
            stream.Close();
            }
            */
            PlaySound(Resources.GameStart);
        }

        #region Hover button
        private void pictureBoxNew_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxNew.BackgroundImage = Properties.Resources.Button_NewGame;
        }

        private void pictureBoxLoad_MouseHover(object sender, EventArgs e)
        {
            pictureBoxLoad.BackgroundImage = Resources.Button_Load_Hover;
        }

        private void pictureBoxLoad_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxLoad.BackgroundImage = Resources.Button_Load;
        }

        private void pictureBoxReset_MouseHover(object sender, EventArgs e)
        {
            pictureBoxReset.BackgroundImage = Resources.Button_Reset_Hover;
        }

        private void pictureBoxReset_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxReset.BackgroundImage = Resources.Button_Reset;
        }

        private void pictureBoxExit_MouseHover(object sender, EventArgs e)
        {
            pictureBoxExit.BackgroundImage = Resources.Button_Exit_Hover;
        }

        private void pictureBoxExit_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxExit.BackgroundImage = Resources.Button_Exits;
        }

        private void pictureBoxNew_MouseHover(object sender, EventArgs e)
        {
            pictureBoxNew.BackgroundImage = Properties.Resources.Button_NewGame_Hover;
        }
        #endregion

        public void PlaySound(UnmanagedMemoryStream suara)
        {
            sfx = new SoundPlayer(suara);
            sfx.Play();
        }
    }
}
