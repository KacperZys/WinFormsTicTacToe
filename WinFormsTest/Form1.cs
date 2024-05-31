namespace WinFormsTest
{
    public partial class TicTacToe : Form
    {
        private string player = "X";
        private byte turn = 1;
        char[,] gameBoard = new char[3, 3];

        public TicTacToe()
        {
            InitializeComponent();
            displayPlayer.Text = player;
            displayTurn.Text = turn.ToString();
        }

        private bool CheckForWin()
        {
            int[][] winConditions = new int[8][];
            winConditions[0] = new int[] { 0, 1, 2 };
            winConditions[1] = new int[] { 3, 4, 5 };
            winConditions[2] = new int[] { 6, 7, 8 };
            winConditions[3] = new int[] { 0, 3, 6 };
            winConditions[4] = new int[] { 1, 4, 7 };
            winConditions[5] = new int[] { 2, 5, 8 };
            winConditions[6] = new int[] { 0, 4, 8 };
            winConditions[7] = new int[] { 2, 4, 6 };

            foreach (var condition in winConditions)
            {
                char symbol = gameBoard[condition[0] / 3, condition[0] % 3];
                if (symbol != '\0' &&
                    symbol == gameBoard[condition[1] / 3, condition[1] % 3] &&
                    symbol == gameBoard[condition[2] / 3, condition[2] % 3])
                {
                    return true;
                }
            }

            return false;
        }

        private bool CheckForDraw()
        {
            foreach (var item in gameBoard)
            {
                if (item == '\0') return false;
            }

            return true;
        }

        private void OnButtonClick(Button button)
        {
            button.Text = displayPlayer.Text;
            button.Enabled = false;

            if (CheckForWin())
            {
                MessageBox.Show($"{player} Won!");
                Application.Exit();
            }

            if (CheckForDraw())
            {
                MessageBox.Show("It's a Draw!");
                Application.Exit();
            }

            if (turn % 2 == 0)
            {
                player = "X";
                displayPlayer.Text = player;
            }
            else
            {
                player = "O";
                displayPlayer.Text = player;
            }

            turn++;
            displayTurn.Text = turn.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gameBoard[0, 0] = Convert.ToChar(player);
            OnButtonClick(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gameBoard[0, 1] = Convert.ToChar(player);
            OnButtonClick(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gameBoard[0, 2] = Convert.ToChar(player);
            OnButtonClick(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gameBoard[1, 0] = Convert.ToChar(player);
            OnButtonClick(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gameBoard[1, 1] = Convert.ToChar(player);
            OnButtonClick(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            gameBoard[1, 2] = Convert.ToChar(player);
            OnButtonClick(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            gameBoard[2, 0] = Convert.ToChar(player);
            OnButtonClick(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            gameBoard[2, 1] = Convert.ToChar(player);
            OnButtonClick(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            gameBoard[2, 2] = Convert.ToChar(player);
            OnButtonClick(button9);
        }
    }
}
