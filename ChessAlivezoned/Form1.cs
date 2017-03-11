using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessAlivezoned
{
    public partial class Form1 : Form
    {
        int turn; //1 for player 1 and 2 for player 2
        int[] score = new int[3]; 

        public Form1()
        {
            InitializeComponent();
            turn = 1;

            score[1] = 0;
            score[2] = 0;

            SwitchTurn();
            Winner();
        }

        private void button_clicked(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            String name = b.Name.ToString();

            switch (name)
            {
                case "b1_1":
                    Check(b);
                    break;
                case "b1_2":
                    Check(b);
                    break;
                case "b1_3":
                    Check(b);
                    break;
                case "b2_1":
                    Check(b);
                    break;
                case "b2_2":
                    Check(b);
                    break;
                case "b2_3":
                    Check(b);
                    break;
                case "b3_1":
                    Check(b);
                    break;
                case "b3_2":
                    Check(b);
                    break;
                case "b3_3":
                    Check(b);
                    break;
            }
        }

        private void SetText(Button b, int sign)
        {
            switch (sign)
            {
                case 0:
                    b.Text = "O";
                    break;
                case 1:
                    b.Text = "X";
                    break;
            }
        }

        private void Check(Button b)
        {
            String t = b.Text.ToString();
            if (t.Equals("O") || t.Equals("X"))
            {
                //MessageBox.Show("Invalid Move");
            }
            else
            {
                switch (turn)
                {
                    case 1:
                        SetText(b, 0);
                        break;
                    case 2:
                        SetText(b, 1);
                        break;
                }
                SwitchTurn();
            }
        }

        // Switches Turns
        private void SwitchTurn()
        {
            int winner = Winner();
            if (turn == 1 && winner == 0)
            {
                turn = 2;
                label_turn.Text = "Player 2's Turn!";
            }
            else if (turn == 2 && winner == 0)
            {
                turn = 1;
                label_turn.Text = "Player 1's Turn!";
            }
            else if (winner == 1)
            {
                switch (turn)
                {
                    case 1:
                        label_turn.Text = "Player 1 Wins!";
                        score[1] = score[1] += 1;
                        label_player1.Text = "Player 1: " + score[1];
                        break;
                    case 2:
                        label_turn.Text = "Player 2 Wins!";
                        score[2] = score[2] += 1;
                        label_player2.Text = "Player 2: " + score[2];
                        break;
                }
            }
        }

        // Determine EndGame
        private int Winner()
        {
            int winner = 0; // 0 = Winner Not Yet Declared

            int[,] board = new int[4, 4];

            board[1, 1] = GetSign(b1_1);
            board[1, 2] = GetSign(b1_2);
            board[1, 3] = GetSign(b1_3);
            board[2, 1] = GetSign(b2_1);
            board[2, 2] = GetSign(b2_2);
            board[2, 3] = GetSign(b2_3);
            board[3, 1] = GetSign(b3_1);
            board[3, 2] = GetSign(b3_2);
            board[3, 3] = GetSign(b3_3);

            for (int i = 1; i <= 3; i++)
            {
                if (board[i, 1] == board[i, 2] && board[i, 2] == board[i, 3] &&
                    board[i, 1] != 3 && board[i, 2] != 3 && board[i, 3] != 3)
                {
                    Who(board[i, 1]); winner = 1;
                }

                if (board[1, i] == board[2, i] && board[2, i] == board[3, i] &&
                    board[1, i] != 3 && board[2, i] != 3 && board[3, i] != 3)
                {
                    Who(board[1, i]); winner = 1;
                }
            }

            if (board[1, 1] == board[2, 2] && board[2, 2] == board[3, 3] &&
                board[1, 1] != 3 && board[2, 2] != 3 && board[3, 3] != 3)
            {
                Who(board[1, 1]); winner = 1;
            }

            if (board[1, 3] == board[2, 2] && board[2, 2] == board[3, 1] &&
                board[1, 3] != 3 && board[2, 2] != 3 && board[3, 1] != 3)
            {
                Who(board[1, 3]); winner = 1;
            }

            return winner;
        }

        // Get Equivalent Int for Sign
        private int GetSign(Button b)
        {
            int finalInt = 3;
            String t = b.Text.ToString();
            if (t.Equals("O"))
            {
                finalInt = 0;
            }
            else if (t.Equals("X"))
            {
                finalInt = 1;
            }
            return finalInt;
        }

        // Which Player Won
        private void Who(int here)
        {
            if (here == 0)
            {
                MessageBox.Show("Player 1 Wins");
            }
            else if (here == 1)
            {
                MessageBox.Show("Player 2 Wins");
            }
               
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            b1_1.Text = "";
            b1_2.Text = "";
            b1_3.Text = "";

            b2_1.Text = "";
            b2_2.Text = "";
            b2_3.Text = "";

            b3_1.Text = "";
            b3_2.Text = "";
            b3_3.Text = "";

        }
    }
}
