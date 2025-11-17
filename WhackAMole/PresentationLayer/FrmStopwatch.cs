
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms; 
using WhackAMole.Models;
using WhackAMole.BusinessLogicLayer;

namespace WhackAMole.PresentationLayer
{
    public partial class FrmStopwatch : Form
    {
        // Tracks how long the stopwatch has been running.
        private TimeSpan timeElapsed = TimeSpan.Zero;
        // Used for the Whack-A-Mole game to generate random positions and colors.
        private Random random = new Random();
        // Game model and logic for N-layer architecture.
        private GameModel gameModel = new GameModel();
        private GameLogic gameLogic = new GameLogic();

        public FrmStopwatch()
        {
            InitializeComponent();
            // Optional: Start timer enabled if you want it running on load
            // tmrStopwatch.Enabled = true;
        }

        /// <summary>
        /// Starts the timer when the Start button is clicked.
        /// </summary>
        private void BtnStartClickEH(object sender, EventArgs e)
        {
            tmrStopwatch.Start(); // start timer
        }

        /// <summary>
        /// Stops the timer when the Stop button is clicked.
        /// </summary>
        private void BtnStopClickEH(object sender, EventArgs e)
        {
            tmrStopwatch.Stop(); // stop timer
            btnTarget.Visible = false; // Hide target on stop for game consistency.
            btnDecoy.Visible = false; // Hide decoy.
        }

        
        /// Resets the timer and label when the Reset button is clicked
        private void BtnResetClickEH(object sender, EventArgs e)
        {
            tmrStopwatch.Stop(); // stop timer
            timeElapsed = TimeSpan.Zero; // reset time
            lblTimeElapsed.Text = "00:00"; // reset label
            btnTarget.Visible = false; // Reset game elements.
            btnDecoy.Visible = false;
            gameModel = new GameModel(); // Reset game model.
            lblScore.Text = "Score: 0";
            lblMiss.Text = "Misses: 0";
        }

       
        /// Handles timer tick: updates elapsed time and relocates target every 3 seconds.
        private void TmrStopwatchTickEH(object sender, EventArgs e)
        {
            // Add one interval to elapsed time.
            timeElapsed = timeElapsed.Add(TimeSpan.FromMilliseconds(tmrStopwatch.Interval));
            // Show minutes and seconds.
            lblTimeElapsed.Text = timeElapsed.ToString(@"mm\:ss");

            gameLogic.UpdateLevel(timeElapsed, gameModel);
            if (gameLogic.CheckEndGame(timeElapsed, gameModel))
            {
                tmrStopwatch.Stop();
                MessageBox.Show($"Game Over! Score: {gameModel.Score}, Misses: {gameModel.Misses}");
                return;
            }

            // Adjust difficulty by level.
            if (gameModel.Level == 2) tmrStopwatch.Interval = 500; // Faster.
            if (gameModel.Level == 3)
            {
                tmrStopwatch.Interval = 300;
                btnTarget.Size = new Size(50, 25); // Smaller target.
            }

            // Relocate target and decoy every 3 sec (or faster per level).
            if (timeElapsed.Seconds % 3 == 0)
            {
                // Random position for target (avoid edges and bottom buttons).
                btnTarget.Top = random.Next(50, this.ClientSize.Height - btnTarget.Height - 50);
                btnTarget.Left = random.Next(0, this.ClientSize.Width - btnTarget.Width);
                // Random color.
                btnTarget.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                btnTarget.Visible = true;

                // Decoy similar:
                btnDecoy.Top = random.Next(50, this.ClientSize.Height - btnDecoy.Height - 50);
                btnDecoy.Left = random.Next(0, this.ClientSize.Width - btnDecoy.Width);
                btnDecoy.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                btnDecoy.Visible = true;
            }

            lblScore.Text = $"Score: {gameModel.Score}";
            lblMiss.Text = $"Misses: {gameModel.Misses}";

            // End of method.
        }

        /// Hides the target button when clicked and updates score.
        private void BtnTargetClickEH(object sender, EventArgs e)
        {
            btnTarget.Visible = false;
            gameLogic.UpdateScore(gameModel, 1); // +1 score.
        }

        /// Penalty for clicking decoy.
        private void BtnDecoyClickEH(object sender, EventArgs e)
        {
            btnDecoy.Visible = false;
            gameLogic.UpdateScore(gameModel, -5); // -5 score.
        }

     
        /// Penalty for clicking form (miss).
        private void FrmStopwatchClickEH(object sender, EventArgs e)
        {
            gameLogic.UpdateMisses(gameModel);
        }

        /// Repositions controls on form resize.
        private void FrmStopwatchResizeEH(object sender, EventArgs e)
        {
            // Reposition buttons to bottom.
            btnStart.Top = this.ClientSize.Height - 50;
            btnStop.Top = this.ClientSize.Height - 50;
            btnReset.Top = this.ClientSize.Height - 50;
            // Adjust if target visible (prevent off-screen).
            if (btnTarget.Visible)
            {
                btnTarget.Top = Math.Min(btnTarget.Top, this.ClientSize.Height - btnTarget.Height - 50);
                btnTarget.Left = Math.Min(btnTarget.Left, this.ClientSize.Width - btnTarget.Width);
            }
            // Same for decoy.
            if (btnDecoy.Visible)
            {
                btnDecoy.Top = Math.Min(btnDecoy.Top, this.ClientSize.Height - btnDecoy.Height - 50);
                btnDecoy.Left = Math.Min(btnDecoy.Left, this.ClientSize.Width - btnDecoy.Width);
            }
        }
    }
}