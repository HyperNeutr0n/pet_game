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
    public partial class FormShop : Form
    {
        public FormShop()
        {
            InitializeComponent();
        }

        #region objects
        FormGame frmGame;
        FormMain frmMain;

        public BindingList<Toy> listToy = new BindingList<Toy>();
        Toy toy1, toy2, toy3;
        int index = 0;
        #endregion

        #region methods
        private void CreateToys()
        {
            toy1 = new Toy("Ball", 500, 10, Properties.Resources.cat_toys_ball);
            listToy.Add(toy1);

            toy2 = new Toy("Yarn", 500, 10, Properties.Resources.cat_toys_yarn);
            listToy.Add(toy2);

            toy3 = new Toy("Stick", 500, 10, Properties.Resources.cat_toys_stick);
            listToy.Add(toy3);
        }
        #endregion

        #region form load
        private void FormShop_Load(object sender, EventArgs e)
        {
            frmGame = this.Owner.Owner as FormGame;
            frmMain = this.Owner.Owner.Owner as FormMain;

            CreateToys();
            pictureBoxToys.BackgroundImage = listToy[index].Picture;
            labelData.Text = listToy[index].DisplayData();
        }
        #endregion

        #region form interaction
        private void buttonBuy_Click(object sender, EventArgs e)
        {
            try
            {
                frmMain.pet.Buy(listToy[index]);
                listToy.Remove(listToy[index]);
                frmGame.labelCoin.Text = frmMain.player.Coins.ToString();
                MessageBox.Show("Terbeli");

                this.Close();
            }
            catch(Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBoxBuy_MouseHover(object sender, EventArgs e)
        {
            pictureBoxBuy.BackgroundImage = Resources.Button_Buy_Hover;
        }

        private void pictureBoxBuy_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxBuy.BackgroundImage = Resources.Button_Buy;
        }

        private void pictureBoxRight_MouseHover(object sender, EventArgs e)
        {
            pictureBoxRight.BackgroundImage = Resources.Button_Right_Hover;
        }

        private void pictureBoxRight_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxRight.BackgroundImage = Resources.Button_Right;
        }

        private void pictureBoxLeft_MouseHover(object sender, EventArgs e)
        {
            pictureBoxLeft.BackgroundImage = Resources.Button_Left_Hover;
        }

        private void pictureBoxLeft_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxLeft.BackgroundImage = Resources.Button_Left;
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            index -= 1;
            if (index > -1)
            {
                pictureBoxToys.BackgroundImage = listToy[index].Picture;
                labelData.Text = listToy[index].DisplayData();
            }
            else
            {
                index = listToy.Count - 1;
                pictureBoxToys.BackgroundImage = listToy[index].Picture;
                labelData.Text = listToy[index].DisplayData();
            }
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            index += 1;
            if (index > (listToy.Count - 1))
            {
                index = 0;
                pictureBoxToys.BackgroundImage = listToy[index].Picture;
                labelData.Text = listToy[index].DisplayData();
            }
            else
            {
                pictureBoxToys.BackgroundImage = listToy[index].Picture;
                labelData.Text = listToy[index].DisplayData();
            }
        }
        #endregion
    }
}
