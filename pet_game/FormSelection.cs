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
    public partial class FormSelection : Form
    {
        FormGame gameform;
        Toy selectToy;
        public FormSelection()
        {
            InitializeComponent();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            gameform.pet.Play(selectToy);
            gameform.labelPetData.Text = gameform.pet.DisplayData();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShop shop = new FormShop();
            shop.Owner = this;
            shop.ShowDialog();
        }

        private void FormSelection_Load(object sender, EventArgs e)
        {
            gameform = (FormGame)this.Owner;
            comboBoxToys.DataSource = gameform.pet.ToyList;
            comboBoxToys.DisplayMember = "Name";
        }

        private void comboBoxToys_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxToys.SelectedIndex != -1)
            {
                selectToy = (Toy)comboBoxToys.SelectedItem;
                pictureBox1.Image = selectToy.Picture;
                labelData.Text = selectToy.DisplayData();
            }
        }
    }
}
