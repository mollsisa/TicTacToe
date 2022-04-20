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

        private bool verifica(string jogador)
        {
            bool ganha = false;
            //Linhas
            if(button1.Text == jogador && button2.Text == jogador && button3.Text == jogador)
            {
                ganha = true;
            }
            else if (button4.Text == jogador && button5.Text == jogador && button6.Text == jogador)
            {
                ganha = true;
            }
            else if (button7.Text == jogador && button8.Text == jogador && button9.Text == jogador)
            {
                ganha = true;
            }
            //Colunas
            else if (button1.Text == jogador && button4.Text == jogador && button7.Text == jogador)
            {
                ganha = true;
            }
            else if (button2.Text == jogador && button5.Text == jogador && button8.Text == jogador)
            {
                ganha = true;
            }
            else if (button3.Text == jogador && button6.Text == jogador && button9.Text == jogador)
            {
                ganha = true;
            }
            //Diagonais
            else if (button1.Text == jogador && button5.Text == jogador && button9.Text == jogador)
            {
                ganha = true;
            }
            else if (button3.Text == jogador && button5.Text == jogador && button7.Text == jogador)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text == "")
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
    }
}