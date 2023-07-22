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
        #endregion

        #region serialize
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
        }
    }
}
