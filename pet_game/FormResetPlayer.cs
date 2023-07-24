using pet_game.Properties;
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
    public partial class FormResetPlayer : Form
    {
        public FormResetPlayer()
        {
            InitializeComponent();
        }

        #region objects
        FormMain frmMain;
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

        #region form load
        private void FormResetPlayer_Load(object sender, EventArgs e)
        {
            frmMain = this.Owner as FormMain;
            comboBoxPlayer.DataSource = frmMain.listPlayer;
            comboBoxPlayer.DisplayMember = "Name";
        }
        #endregion

        #region button click
        private void pictureBoxDelete_Click(object sender, EventArgs e)
        {
            frmMain.PlaySfx(Resources.UseSound);
            try
            {
                if (comboBoxPlayer.SelectedItem != null)
                {
                    Player selectedPlayer = comboBoxPlayer.SelectedItem as Player;
                    Pet selectedPet = null;
                    foreach (Pet pet in frmMain.listPet)
                    {
                        if (pet.Owner.Name == selectedPlayer.Name)
                        {
                            selectedPet = pet;
                        }
                    }
                    frmMain.listPlayer.Remove(selectedPlayer);
                    frmMain.listPet.Remove(selectedPet);
                    SavePetData();
                    SavePlayerData();
                }
                else throw new Exception("Please select a player to delete!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            frmMain.PlaySfx(Resources.Button_Sound1);
            this.Close();
        }
        #endregion

        #region button hover
        private void pictureBoxBack_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxBack.BackgroundImage = Resources.Button_Back1;
        }

        private void pictureBoxBack_MouseHover(object sender, EventArgs e)
        {
            pictureBoxBack.BackgroundImage = Resources.Button_Back2;
        }

        private void pictureBoxDelete_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxDelete.BackgroundImage = Resources.Button_ResetData2;
        }

        private void FormResetPlayer_MouseHover(object sender, EventArgs e)
        {
            pictureBoxDelete.BackgroundImage = Resources.Button_ResetData1;
        }
        #endregion
    }
}
