using pet_game.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pet_game
{
    public partial class FormSelectPet : Form
    {
        public FormSelectPet()
        {
            InitializeComponent();
        }

        #region objects
        FormMain frmMain;

        List<Image> selectImage = new List<Image>() { Properties.Resources.cat_happy, Properties.Resources.fish_happy, Properties.Resources.chameleon_happy };

        int index = 0;
        #endregion

        #region methods
        private void CheckFish()
        {
            if (index == 1)
            {
                labelEnvirontment.Visible = true;
                comboBoxEnvironment.Visible = true;
            }
            else
            {
                labelEnvirontment.Visible = false;
                comboBoxEnvironment.Visible = false;
            }
        }
        #endregion

        #region form load
        private void FormSelectPet_Load(object sender, EventArgs e)
        {
            /*frmGame = this.Owner.Owner as FormGame;*/
            frmMain = this.Owner as FormMain;
            pictureBoxSelection.BackgroundImage = selectImage[index];
            CheckFish();
        }
        #endregion

        #region button interaction
        private void buttonL_Click(object sender, EventArgs e)
        {
            index -= 1;
            if (index > -1)
            {
                pictureBoxSelection.BackgroundImage = selectImage[index];
                CheckFish();
            }
            else
            {
                index = selectImage.Count - 1;
                pictureBoxSelection.BackgroundImage = selectImage[index];
                CheckFish();
            }
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            index += 1;
            if (index > 2)
            {
                index = 0;
                pictureBoxSelection.BackgroundImage = selectImage[index];
                CheckFish();
            }
            else
            {
                pictureBoxSelection.BackgroundImage = selectImage[index];
                CheckFish();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region play button
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            try
            {
                frmMain.player = new Player(textBoxPlayerName.Text, 1000, DateTime.Now);

                if (index == 0)
                {
                    frmMain.pet = new Cat(textBoxPetName.Text, pictureBoxSelection.BackgroundImage, frmMain.player);
                }
                else if (index == 1)
                {
                    frmMain.pet = new Fish(textBoxPetName.Text, pictureBoxSelection.BackgroundImage, frmMain.player, comboBoxEnvironment.Text);
                }
                else if (index == 2)
                {
                    frmMain.pet = new Chameleon(textBoxPetName.Text, pictureBoxSelection.BackgroundImage, frmMain.player, Color.Green);
                }

                frmMain.listPlayer.Add(frmMain.player);
                frmMain.listPet.Add(frmMain.pet);
                FormGame frmGame = new FormGame();
                frmGame.Owner = this.Owner as FormMain;
                frmGame.TopLevel = false;
                frmMain.panelMain.Controls.Add(frmGame);
                frmGame.BringToFront();
                frmGame.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
