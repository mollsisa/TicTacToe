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
    public partial class Local : Form
    {
        bool turno = true;
        public Local()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            
            if(btn.Text == "")
            {
                if (turno)
                {
                    string jogador = "X";
                    btn.Text = jogador;
                    turno = !turno;
                    bool ganha = verifica(jogador);
                    mensagem(jogador, ganha);
                }
                else
                {
                    string jogador = "O";
                    btn.Text = jogador;
                    turno = !turno;
                    bool ganha = verifica(jogador);
                    mensagem(jogador, ganha);
                }
            }
        }

        private bool verifica(string jogador)
        {
            bool ganha = false;
            //Linhas
            if(guna2Button1.Text == jogador && guna2Button2.Text == jogador && guna2Button3.Text == jogador)
            {
                ganha = true;
            }
            else if (guna2Button4.Text == jogador && guna2Button5.Text == jogador && guna2Button6.Text == jogador)
            {
                ganha = true;
            }
            else if (guna2Button7.Text == jogador && guna2Button8.Text == jogador && guna2Button9.Text == jogador)
            {
                ganha = true;
            }
            //Colunas
            else if (guna2Button1.Text == jogador && guna2Button4.Text == jogador && guna2Button7.Text == jogador)
            {
                ganha = true;
            }
            else if (guna2Button2.Text == jogador && guna2Button5.Text == jogador && guna2Button8.Text == jogador)
            {
                ganha = true;
            }
            else if (guna2Button3.Text == jogador && guna2Button6.Text == jogador && guna2Button9.Text == jogador)
            {
                ganha = true;
            }
            //Diagonais
            else if (guna2Button1.Text == jogador && guna2Button5.Text == jogador && guna2Button9.Text == jogador)
            {
                ganha = true;
            }
            else if (guna2Button3.Text == jogador && guna2Button5.Text == jogador && guna2Button7.Text == jogador)
            {
                ganha = true;
            }
            return ganha;
        }

        private void mensagem(string jogador, bool ganha) {
            if (ganha)
            {
                MessageBox.Show($"O jogador {jogador} ganhou!");
            }
        }
    }
}