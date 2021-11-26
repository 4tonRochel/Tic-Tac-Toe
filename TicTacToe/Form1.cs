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
    public partial class Form1 : Form
    {
        Boolean TheWinner;
        int add_one;
  
        void Enabled_False()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
        }

        void score()
        {   //Horizontal line
            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X")
            {
                btn1.BackColor = System.Drawing.Color.CadetBlue;
                btn2.BackColor = System.Drawing.Color.CadetBlue;
                btn3.BackColor = System.Drawing.Color.CadetBlue;
                MessageBox.Show("PlayerX Wins!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add_one = int.Parse(lblScoreX.Text);
                lblScoreX.Text = Convert.ToString(add_one + 1);
                Enabled_False();
            }

            if (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X")
            {
                btn4.BackColor = System.Drawing.Color.CadetBlue;
                btn5.BackColor = System.Drawing.Color.CadetBlue;
                btn6.BackColor = System.Drawing.Color.CadetBlue;
                MessageBox.Show("PlayerX Wins!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add_one = int.Parse(lblScoreX.Text);
                lblScoreX.Text = Convert.ToString(add_one + 1);
                Enabled_False();
            }

            if (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X")
            {
                btn7.BackColor = System.Drawing.Color.CadetBlue;
                btn8.BackColor = System.Drawing.Color.CadetBlue;
                btn9.BackColor = System.Drawing.Color.CadetBlue;
                MessageBox.Show("PlayerX Wins!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add_one = int.Parse(lblScoreX.Text);
                lblScoreX.Text = Convert.ToString(add_one + 1);
                Enabled_False();
            } //End Horizontal Line

            //Vertical
            if (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X")
            {
                btn1.BackColor = System.Drawing.Color.CadetBlue;
                btn4.BackColor = System.Drawing.Color.CadetBlue;
                btn7.BackColor = System.Drawing.Color.CadetBlue;
                MessageBox.Show("PlayerX Wins!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add_one = int.Parse(lblScoreX.Text);
                lblScoreX.Text = Convert.ToString(add_one + 1);
                Enabled_False();
            }

            if (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X")
            {
                btn2.BackColor = System.Drawing.Color.CadetBlue;
                btn5.BackColor = System.Drawing.Color.CadetBlue;
                btn8.BackColor = System.Drawing.Color.CadetBlue;
                MessageBox.Show("PlayerX Wins!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add_one = int.Parse(lblScoreX.Text);
                lblScoreX.Text = Convert.ToString(add_one + 1);
                Enabled_False();
            }

            if (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X")
            {
                btn3.BackColor = System.Drawing.Color.CadetBlue;
                btn6.BackColor = System.Drawing.Color.CadetBlue;
                btn9.BackColor = System.Drawing.Color.CadetBlue;
                MessageBox.Show("PlayerX Wins!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add_one = int.Parse(lblScoreX.Text);
                lblScoreX.Text = Convert.ToString(add_one + 1);
                Enabled_False();
            } //End Vertical Line

            //X Line
            if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X")
            {
                btn1.BackColor = System.Drawing.Color.CadetBlue;
                btn5.BackColor = System.Drawing.Color.CadetBlue;
                btn9.BackColor = System.Drawing.Color.CadetBlue;
                MessageBox.Show("PlayerX Wins!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add_one = int.Parse(lblScoreX.Text);
                lblScoreX.Text = Convert.ToString(add_one + 1);
                Enabled_False();
            }

            if (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X")
            {
                btn3.BackColor = System.Drawing.Color.CadetBlue;
                btn5.BackColor = System.Drawing.Color.CadetBlue;
                btn7.BackColor = System.Drawing.Color.CadetBlue;
                MessageBox.Show("PlayerX Wins!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add_one = int.Parse(lblScoreX.Text);
                lblScoreX.Text = Convert.ToString(add_one + 1);
                Enabled_False();
            } //End X Line

            //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx

            if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O")
            {
                btn1.BackColor = System.Drawing.Color.Peru;
                btn2.BackColor = System.Drawing.Color.Peru;
                btn3.BackColor = System.Drawing.Color.Peru;
                MessageBox.Show("PlayerO Wins!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add_one = int.Parse(lblScoreO.Text);
                lblScoreO.Text = Convert.ToString(add_one + 1);
                Enabled_False();
            }

            if (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O")
            {
                btn4.BackColor = System.Drawing.Color.Peru;
                btn5.BackColor = System.Drawing.Color.Peru;
                btn6.BackColor = System.Drawing.Color.Peru;
                MessageBox.Show("PlayerO Wins!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add_one = int.Parse(lblScoreO.Text);
                lblScoreO.Text = Convert.ToString(add_one + 1);
                Enabled_False();
            }

            if (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O")
            {
                btn7.BackColor = System.Drawing.Color.Peru;
                btn8.BackColor = System.Drawing.Color.Peru;
                btn9.BackColor = System.Drawing.Color.Peru;
                MessageBox.Show("PlayerO Wins!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add_one = int.Parse(lblScoreO.Text);
                lblPlayerO.Text = Convert.ToString(add_one + 1);
                Enabled_False();
            } //End Horizontal Line

            //Vertical
            if (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O")
            {
                btn1.BackColor = System.Drawing.Color.Peru;
                btn4.BackColor = System.Drawing.Color.Peru;
                btn7.BackColor = System.Drawing.Color.Peru;
                MessageBox.Show("PlayerO Wins!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add_one = int.Parse(lblScoreO.Text);
                lblScoreO.Text = Convert.ToString(add_one + 1);
                Enabled_False();
            }

            if (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O")
            {
                btn2.BackColor = System.Drawing.Color.Peru;
                btn5.BackColor = System.Drawing.Color.Peru;
                btn8.BackColor = System.Drawing.Color.Peru;
                MessageBox.Show("PlayerO Wins!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add_one = int.Parse(lblScoreO.Text);
                lblScoreO.Text = Convert.ToString(add_one + 1);
                Enabled_False();
            }

            if (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O")
            {
                btn3.BackColor = System.Drawing.Color.Peru;
                btn6.BackColor = System.Drawing.Color.Peru;
                btn9.BackColor = System.Drawing.Color.Peru;
                MessageBox.Show("PlayerO Wins!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add_one = int.Parse(lblScoreO.Text);
                lblScoreO.Text = Convert.ToString(add_one + 1);
                Enabled_False();
            } //End Vertical Line

            //X Line
            if (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O")
            {
                btn1.BackColor = System.Drawing.Color.Peru;
                btn5.BackColor = System.Drawing.Color.Peru;
                btn9.BackColor = System.Drawing.Color.Peru;
                MessageBox.Show("PlayerO Wins!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add_one = int.Parse(lblScoreO.Text);
                lblScoreO.Text = Convert.ToString(add_one + 1);
                Enabled_False();
            }

            if (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O")
            {
                btn3.BackColor = System.Drawing.Color.Peru;
                btn5.BackColor = System.Drawing.Color.Peru;
                btn7.BackColor = System.Drawing.Color.Peru;
                MessageBox.Show("PlayerO Wins!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add_one = int.Parse(lblScoreO.Text);
                lblScoreO.Text = Convert.ToString(add_one + 1);
                Enabled_False();
            } //End X Line

            

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (TheWinner == false)
            {
                btn1.Text = "X";
                TheWinner = true;
            }
            else
            {
                btn1.Text = "O";
                TheWinner = false;
            }
            score();
            btn1.Enabled = false;

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (TheWinner == false)
            {
                btn2.Text = "X";
                TheWinner = true;
            }
            else
            {
                btn2.Text = "O";
                TheWinner = false;
            }
            score();
            btn2.Enabled = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (TheWinner == false)
            {
                btn3.Text = "X";
                TheWinner = true;
            }
            else
            {
                btn3.Text = "O";
                TheWinner = false;
            }
            score();
            btn3.Enabled = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (TheWinner == false)
            {
                btn4.Text = "X";
                TheWinner = true;
            }
            else
            {
                btn4.Text = "O";
                TheWinner = false;
            }
            score();
            btn4.Enabled = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (TheWinner == false)
            {
                btn5.Text = "X";
                TheWinner = true;
            }
            else
            {
                btn5.Text = "O";
                TheWinner = false;
            }
            score();
            btn5.Enabled = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (TheWinner == false)
            {
                btn6.Text = "X";
                TheWinner = true;
            }
            else
            {
                btn6.Text = "O";
                TheWinner = false;
            }
            score();
            btn6.Enabled = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (TheWinner == false)
            {
                btn7.Text = "X";
                TheWinner = true;
            }
            else
            {
                btn7.Text = "O";
                TheWinner = false;
            }
            score();
            btn7.Enabled = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (TheWinner == false)
            {
                btn8.Text = "X";
                TheWinner = true;
            }
            else
            {
                btn8.Text = "O";
                TheWinner = false;
            }
            score();
            btn8.Enabled = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (TheWinner == false)
            {
                btn9.Text = "X";
                TheWinner = true;
            }
            else
            {
                btn9.Text = "O";
                TheWinner = false;
            }
            score();
            btn9.Enabled = false;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            try
            {
                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn5.Enabled = true;
                btn6.Enabled = true;
                btn7.Enabled = true;
                btn8.Enabled = true;
                btn9.Enabled = true;

                btn1.Text = "";
                btn2.Text = "";
                btn3.Text = "";
                btn4.Text = "";
                btn5.Text = "";
                btn6.Text = "";
                btn7.Text = "";
                btn8.Text = "";
                btn9.Text = "";

                lblScoreX.Text = "0";
                lblScoreO.Text = "0";

                btn1.BackColor = Color.SaddleBrown;
                btn2.BackColor = Color.SaddleBrown;
                btn3.BackColor = Color.SaddleBrown;
                btn4.BackColor = Color.SaddleBrown;
                btn5.BackColor = Color.SaddleBrown;
                btn6.BackColor = Color.SaddleBrown;
                btn7.BackColor = Color.SaddleBrown;
                btn8.BackColor = Color.SaddleBrown;
                btn9.BackColor = Color.SaddleBrown;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try { 
                    btn1.Enabled = true;
                    btn2.Enabled = true;
                    btn3.Enabled = true;
                    btn4.Enabled = true;
                    btn5.Enabled = true;
                    btn6.Enabled = true;
                    btn7.Enabled = true;
                    btn8.Enabled = true;
                    btn9.Enabled = true;

                    btn1.Text = "";
                    btn2.Text = "";
                    btn3.Text = "";
                    btn4.Text = "";
                    btn5.Text = "";
                    btn6.Text = "";
                    btn7.Text = "";
                    btn8.Text = "";
                    btn9.Text = "";

                    btnNewGame.Enabled = true;

                    btn1.BackColor = Color.SaddleBrown;
                    btn2.BackColor = Color.SaddleBrown;
                    btn3.BackColor = Color.SaddleBrown;
                    btn4.BackColor = Color.SaddleBrown;
                    btn5.BackColor = Color.SaddleBrown;
                    btn6.BackColor = Color.SaddleBrown;
                    btn7.BackColor = Color.SaddleBrown;
                    btn8.BackColor = Color.SaddleBrown;
                    btn9.BackColor = Color.SaddleBrown;
                }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
