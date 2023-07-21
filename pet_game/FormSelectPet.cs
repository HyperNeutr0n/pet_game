using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        FormGame frmGame;
        #endregion

        #region form load
        private void FormSelectPet_Load(object sender, EventArgs e)
        {
            radioButtonCat.Checked = true;
            frmGame = this.Owner.Owner as FormGame;
        }
        #endregion

        #region radio button interaction
        private void radioButtonCat_CheckedChanged(object sender, EventArgs e)
        {
            labelEnvirontment.Visible = false;
            comboBoxEnvironment.Visible = false;

        }

        private void radioButtonFish_CheckedChanged(object sender, EventArgs e)
        {
            labelEnvirontment.Visible = true;
            comboBoxEnvironment.Visible = true;
        }

        private void radioButtonChameleon_CheckedChanged(object sender, EventArgs e)
        {
            labelEnvirontment.Visible = false;
            comboBoxEnvironment.Visible = false;
        }
        #endregion

        #region play button
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            try
            {
                frmGame.player = new Player(textBoxPlayerName.Text, 1000, DateTime.Now);

                if (radioButtonCat.Checked)
                {
                    frmGame.pet = new Cat(textBoxPetName.Text, radioButtonCat.BackgroundImage, frmGame.player);
                }
                else if (radioButtonFish.Checked)
                {
                    frmGame.pet = new Fish(textBoxPetName.Text, radioButtonFish.BackgroundImage, frmGame.player, comboBoxEnvironment.Text);
                }
                else if (radioButtonChameleon.Checked)
                {
                    frmGame.pet = new Chameleon(textBoxPetName.Text, radioButtonChameleon.BackgroundImage, frmGame.player, Color.Green);
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
    }
}
