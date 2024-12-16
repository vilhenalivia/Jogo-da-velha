using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_velhaa
{
    public partial class Form1 : Form
    {

        int Xplayer = 0;
        int Oplayer = 0;
        int empatePontos = 0;
        int rodadas = 0;

        bool turno = true;
        bool jogoFinal = false;
        string[] texto = new string[9];

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int buttonIndex = btn.TabIndex;

            if (btn.Text == "" && jogoFinal == false)
            {
                if (turno)
                {
                    btn.Text = "X";
                    texto[buttonIndex] = btn.Text;
                    rodadas++;
                    turno = !turno;
                    Checagem(1);
                }
                else
                {
                    btn.Text = "O";
                    texto[buttonIndex] = btn.Text;
                    rodadas++;
                    turno = !turno;
                    Checagem(2);
                }
            }  

        }

        void Vencedor(int PlayerQueGanhou)
        {
            jogoFinal = true;
            
            if (PlayerQueGanhou == 1)
            {
                Xplayer++;
                lblXpontos.Text = Convert.ToString(Xplayer);
                MessageBox.Show("Jogador X ganhou!");
                turno = true;
            }
            else
            {
                Oplayer++;
                lbl0pontos.Text = Convert.ToString(Oplayer);
                MessageBox.Show("Jogador O ganhou!");
                turno = false;
            }
        }


        void Checagem(int Checagemplayer)
        {
            string suporte = " ";

            if (Checagemplayer == 1)
            {
                suporte = "X";
            }
            else
            {
                suporte = "O";
            }
            
            // Checagem horizontal
            for (int horizontal = 0; horizontal < 8; horizontal += 3 )
            {
                if (suporte == texto[horizontal])
                {
                    if (texto[horizontal] == texto[horizontal + 1 ] && texto[horizontal] == texto[horizontal + 2])
                    {
                        Vencedor(Checagemplayer);
                        return;
                    }
                }
            }

            // Checagem vertical
            for (int vertical = 0; vertical < 3; vertical += 3)
            {
                if (suporte == texto[vertical])
                {
                    if (texto[vertical] == texto[vertical + 3] && texto[vertical] == texto[vertical + 6])
                    {
                        Vencedor(Checagemplayer);
                        return;
                    }
                }
            }

            // Chegagem Diagonal

            if (texto[0] == suporte)
            {

                if (texto[0] == texto[4] && texto[0] == texto[8])
                {
                    Vencedor(Checagemplayer);
                    return;
                }

            }
            if ( texto[2] == suporte)
            {
                if (texto[2] == texto[4] && texto[2] == texto[6])
                {
                    Vencedor(Checagemplayer);
                    return;
                }

            }

            if (rodadas == 9 && jogoFinal == false)
            {
                empatePontos++;
                lblpontos.Text = Convert.ToString(empatePontos);
                MessageBox.Show("Empate!");
                jogoFinal = true;
                return;
            }





        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            btn.Text = "";
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";


            rodadas = 0;
            jogoFinal = false;

            for (int i = 0; i < 9; i++)
            {

                texto[i] = "";
            }
        }
    }
}
