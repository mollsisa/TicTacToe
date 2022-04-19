using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        //Sign up
        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        //Sign in
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txbEmail.Text == "adm" && txbSenha.Text == "adm")
            {
                this.Close();
                Game game = new Game();
                game.Show();
            }
            else
            {
                MessageBox.Show("Imvalido!");
            }
        }
    }
}
