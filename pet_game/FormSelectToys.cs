using pet_game.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pet_game
{
    public partial class FormSelectToys : Form
    {
        
        public FormSelectToys()
        {
            InitializeComponent();
        }

        #region objects
        FormMain frmMain;
        FormGame frmGame;
        Toy selectToy;
        #endregion

        #region form load
        private void FormSelection_Load(object sender, EventArgs e)
        {
            frmGame = this.Owner as FormGame;
            frmMain = this.Owner.Owner as FormMain;
            comboBoxToys.DataSource = frmMain.pet.ToyList;
            comboBoxToys.DisplayMember = "Name";

            if(frmMain.pet is Chameleon || frmMain.pet is Fish)
            {
                labelToys.Text = "Decoration List";
                pictureBoxUse.Visible= false;
            }
        }
        #endregion

        #region form interaction

        private void pictureBoxUse_MouseHover(object sender, EventArgs e)
        {
            pictureBoxUse.BackgroundImage = Resources.Button_Use_Hover;
        }

        private void pictureBoxUse_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxUse.BackgroundImage = Resources.Button_Use;
        }

        private void pictureBoxUse_Click(object sender, EventArgs e)
        {
            frmMain.PlaySfx(Resources.UseSound);
            try
            {
                if (comboBoxToys.SelectedItem != null)
                {
                    if (frmMain.pet is Cat)
                    {
                        frmMain.pet.Play(selectToy);
                        frmGame.timerGame.Start();
                        frmGame.timerPet.Start();
                        frmGame.toy = comboBoxToys.Text;
                        frmGame.activity = "play";
                        frmGame.animationDuration = 30;
                        frmGame.delayCount = 0;
                        //frmGame.activity
                    }
                    this.Close();
                }
                else throw new Exception("Please select a toy!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShop shop = new FormShop();
            shop.Owner = this;
            shop.ShowDialog();
         
        }

        private void comboBoxToys_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxToys.SelectedIndex > -1)
            {
                selectToy = (Toy)comboBoxToys.SelectedItem;
                pictureBoxToy.Image = selectToy.Picture;
                labelData.Text = selectToy.DisplayData();
                if(comboBoxToys.Text == "Ball")
                {
                    pictureBoxToy.BackgroundImage = Resources.cat_toys_ball;
                }else if (comboBoxToys.Text == "Yarn")
                {
                    pictureBoxToy.BackgroundImage = Resources.cat_toys_yarn;
                }else if (comboBoxToys.Text == "Stick")
                {
                    pictureBoxToy.BackgroundImage = Resources.cat_toys_stick;
                }
            }
        }

        public void linkLabelBuy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShop frmShop = new FormShop();
            frmShop.Owner = this;
            frmShop.TopLevel = false;
            frmMain.panelMain.Controls.Add(frmShop);
            frmShop.BringToFront();
            frmShop.Show();
        }
        #endregion

        #region form close
        private void FormSelectToys_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmGame.PanelDataUpdate();
            frmGame.timerGame.Start();
            frmGame.timerPet.Start();
        }


        #endregion

        #region button interaction
        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            frmMain.PlaySfx(Resources.Button_Sound1);
            this.Close();
        }

        private void pictureBoxBack_MouseHover(object sender, EventArgs e)
        {
            pictureBoxBack.BackgroundImage = Resources.Button_Back2;
        }

        private void pictureBoxBack_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxBack.BackgroundImage = Resources.Button_Back1;
        }
        #endregion
    }
}
