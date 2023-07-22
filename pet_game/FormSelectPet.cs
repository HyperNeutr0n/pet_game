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
        List<Image> selectImage = new List<Image>() { Properties.Resources.cat_happy, Properties.Resources.fish_happy, Properties.Resources.chameleon_happy };
        int index = 0;
        public FormSelectPet()
        {
            InitializeComponent();
        }

        #region objects
        FormGame frmGame;
        #endregion

        #region form load
        private void FormSelectPet_Load(object sender, EventArgs e)
        {
            frmGame = this.Owner.Owner as FormGame;
            pictureBoxSeelection.BackgroundImage = selectImage[index];
            CheckFish();
           
        }
        #endregion

        #region Button change
        private void buttonL_Click(object sender, EventArgs e)
        {
            index -= 1;
            if (index > -1)
            {
                pictureBoxSeelection.BackgroundImage = selectImage[index];
                CheckFish();
            }
            else
            {
                index = selectImage.Count - 1;
                pictureBoxSeelection.BackgroundImage = selectImage[index];
                CheckFish();
            }
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            index += 1;
            if (index > 2)
            {
                index = 0;
                pictureBoxSeelection.BackgroundImage = selectImage[index];
                CheckFish();
            }
            else
            {
                pictureBoxSeelection.BackgroundImage = selectImage[index];
                CheckFish();
            }
        }

        #endregion

        #region play button
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            try
            {
                frmGame.player = new Player(textBoxPlayerName.Text, 1000, DateTime.Now);

                if (index == 0)
                {
                    frmGame.pet = new Cat(textBoxPetName.Text, pictureBoxSeelection.BackgroundImage, frmGame.player);
                }
                else if (index == 1)
                {
                    frmGame.pet = new Fish(textBoxPetName.Text, pictureBoxSeelection.BackgroundImage, frmGame.player, comboBoxEnvironment.Text);
                }
                else if (index == 2)
                {
                    frmGame.pet = new Chameleon(textBoxPetName.Text, pictureBoxSeelection.BackgroundImage, frmGame.player, Color.Green);
                }
                frmGame.listPlayer.Add(frmGame.player);
                frmGame.listPet.Add(frmGame.pet);
                frmGame.StartGame();
                this.Close();
                this.Owner.Close();

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

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
    }
}
