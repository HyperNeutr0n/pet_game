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
        #endregion

        #region form loads
        private void FormSelectPlayer_Load(object sender, EventArgs e)
        {
            
            frmGame = (FormGame)this.Owner.Owner;
        }
        #endregion

        #region form interaction
        private void buttonPlay_Click(object sender, EventArgs e)
        {

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
