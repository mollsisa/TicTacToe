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
        private void desativa()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text == "")
            {
                btn.Enabled = false;
                if (turno)
                {
                    string jogador = "X";
                    btn.Text = jogador;
                    turno = !turno;
                    bool ganha = verifica(jogador);
                    if (verifica(jogador))
                    {
                        MessageBox.Show($"O jogador {jogador} ganhou!");
                        desativa();
                    }
                }
                else
                {
                    string jogador = "O";
                    btn.Text = jogador;
                    turno = !turno;
                    if (verifica(jogador))
                    {
                        MessageBox.Show($"O jogador {jogador} ganhou!");
                        desativa();
                    }
                }
            }
        }

    }
}