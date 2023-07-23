using pet_game.Properties;
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
    public partial class FormSelectPlayer : Form
    {
        public FormSelectPlayer()
        {
            InitializeComponent();
        }

        #region objects
        FormMain frmMain;
        #endregion

        #region form loads
        private void FormSelectPlayer_Load(object sender, EventArgs e)
        {
            frmMain = this.Owner as FormMain;
            comboBoxPlayer.DataSource = frmMain.listPlayer;
            comboBoxPlayer.DisplayMember = "Name";
        }
        #endregion

        #region form interaction
        private void pictureBoxPlay_MouseHover(object sender, EventArgs e)
        {
            pictureBoxPlay.BackgroundImage = Resources.Button_Play_Hover;

        }

        private void pictureBoxPlay_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxPlay.BackgroundImage = Resources.Button_Play;
        }

        private void pictureBoxPlay_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxPlayer.SelectedItem != null)
                {
                    frmMain.player = (Player)comboBoxPlayer.SelectedItem;
                    foreach (Pet pet in frmMain.listPet)
                    {
                        if (pet.Owner.Name == frmMain.player.Name)
                        {
                            frmMain.pet = pet;
                        }
                    }
                    FormGame frmGame = new FormGame();
                    frmGame.Owner = this.Owner as FormMain;
                    frmGame.TopLevel = false;
                    frmMain.panelMain.Controls.Add(frmGame);
                    frmGame.BringToFront();
                    frmGame.Show();
                    this.Close();
                }
                else throw new Exception("Please select a player!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabelClickHere_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSelectPet formSelectPet = new FormSelectPet();
            formSelectPet.Owner = this.Owner;
            formSelectPet.TopLevel = false;
            frmMain.panelMain.Controls.Add(formSelectPet);
            formSelectPet.BringToFront();
            formSelectPet.Show();
            this.Close();
        }
        #endregion
    }
}
