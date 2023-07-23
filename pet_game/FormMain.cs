using pet_game.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
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
        public List<Player> listPlayer = new List<Player>();
        public List<Pet> listPet = new List<Pet>();

        SoundPlayer sfx;
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        #endregion

        #region sound and bgm
        public void PlaySfx(UnmanagedMemoryStream suara)
        {
            sfx = new SoundPlayer(suara);
            sfx.Play();
        }

        public void PlayBgm(string url)
        {
            mxp.URL = url;
            mxp.settings.playCount = 999;
            mxp.Visible = false;
            mxp.Ctlcontrols.play();
        }
        #endregion

        #region serialize
        private void LoadPlayerData()
        {
            if (File.Exists("DataPlayer.vc"))
            {
                FileStream stream = new FileStream("DataPlayer.vc", FileMode.Open, FileAccess.Read);
                BinaryFormatter format = new BinaryFormatter();
                listPlayer = (List<Player>)format.Deserialize(stream);
                stream.Close();
            }
        }

        private void LoadPetData()
        {
            if (File.Exists("DataPet.vc"))
            {
                FileStream stream = new FileStream("DataPet.vc", FileMode.Open, FileAccess.Read);
                BinaryFormatter format = new BinaryFormatter();
                listPet = (List<Pet>)format.Deserialize(stream);
                stream.Close();
            }
        }
        #endregion

        #region form load
        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadPlayerData();
            LoadPetData();
            PlaySfx(Resources.GameStart);
            PlayBgm("genshinOST.mp3");
        }
        #endregion

        #region button hover
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
        
        #region button click
        private void pictureBoxNew_Click(object sender, EventArgs e)
        {
            PlaySfx(Resources.Button_Sound1);
            FormSelectPet formSelectPet = new FormSelectPet();
            formSelectPet.Owner = this;
            formSelectPet.TopLevel = false;
            panelMain.Controls.Add(formSelectPet);
            formSelectPet.BringToFront();
            formSelectPet.Show();
        }

        private void pictureBoxLoad_Click(object sender, EventArgs e)
        {
            PlaySfx(Resources.Button_Sound1);
            FormSelectPlayer formSelectPlayer = new FormSelectPlayer();
            formSelectPlayer.Owner = this;
            formSelectPlayer.TopLevel = false;
            panelMain.Controls.Add(formSelectPlayer);
            formSelectPlayer.BringToFront();
            formSelectPlayer.Show();
        }

        private void pictureBoxReset_Click(object sender, EventArgs e)
        {
            sfx = new SoundPlayer(Resources.PlayStart);
            sfx.PlayLooping();
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            PlaySfx(Resources.Button_Sound1);
            Application.Exit();
        }
        #endregion
    }
}
