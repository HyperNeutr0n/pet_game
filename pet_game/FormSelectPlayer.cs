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
        FormGame frmGame;
        FormMain frmMain;
        #endregion

        #region form loads
        private void FormSelectPlayer_Load(object sender, EventArgs e)
        {
            frmMain = this.Owner as FormMain;
            frmGame = (FormGame)this.Owner.Owner;
        }
        #endregion

        #region form interaction
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxPlayer.SelectedItem != null)
                {
                    frmMain.player = (Player)comboBoxPlayer.SelectedItem;
                    foreach (Pet pet in frmMain.listPet)
                    {
                        if (pet.Name == frmMain.player.Name)
                        {
                            frmMain.pet = pet;
                        }
                    }
                    frmGame.StartGame();
                    this.Close();
                }
                else throw new Exception("Please select a player!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSelectPet formSelectPet = new FormSelectPet();
            formSelectPet.Owner = this;
            formSelectPet.ShowDialog();
        }
        #endregion
    }
}
