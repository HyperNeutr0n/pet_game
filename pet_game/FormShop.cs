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
        FormGame gameform;
        public List<Toy> listToy = new List<Toy>();
        Toy toy1, toy2, toy3;
        int index = 0;

        private void FormShop_Load(object sender, EventArgs e)
        {
            gameform = (FormGame)this.Owner.Owner;
            CreateToys();
            pictureBox1.BackgroundImage = listToy[index].Picture;
            labelData.Text = listToy[index].DisplayData();
        
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            try
            {
                gameform.pet.Buy(listToy[index]);
                listToy.Remove(listToy[index]);
                gameform.labelCoin.Text = gameform.player.Coins.ToString();
                MessageBox.Show("Beli");
                gameform.timerGame.Start();
             
                this.Close();
                this.Owner.Close();
            }
            catch(Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                index += 1;
                if (index > (listToy.Count - 1))
                {
                    index = 0;
                    pictureBox1.BackgroundImage = listToy[index].Picture;
                    labelData.Text = listToy[index].DisplayData();


                }
                else
                {
                    pictureBox1.BackgroundImage = listToy[index].Picture;
                    labelData.Text = listToy[index].DisplayData();
                }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
                index -= 1;
                if (index > -1)
                {
                    pictureBox1.BackgroundImage = listToy[index].Picture;
                    labelData.Text = listToy[index].DisplayData();
                }
                else
                {
                    index = listToy.Count - 1;
                    pictureBox1.BackgroundImage = listToy[index].Picture;
                    labelData.Text = listToy[index].DisplayData();
                }
          
        }

        public FormShop()
        {
            InitializeComponent();
        }

        private void CreateToys()
        {
            toy1 = new Toy("Ball", 500, 10, Properties.Resources.cat_toys_ball);
            listToy.Add(toy1);

            toy2 = new Toy("Yarn", 500, 10, Properties.Resources.cat_toys_yarn);
            listToy.Add(toy2);

            toy3 = new Toy("Stick", 500, 10, Properties.Resources.cat_toys_stick);
            listToy.Add(toy3);
        }
    }
}
