using LoginPage;
using System;
using System.Windows.Forms;
using System.Media;
namespace AmiggasRenting
{
    public partial class LoadingScreen : Form
    {
        private System.Windows.Forms.Timer loadingTimer; // Use System.Windows.Forms.Timer
        private SoundPlayer soundPlayer; // SoundPlayer object for playing the sound
        public LoadingScreen()
        {
            InitializeComponent();

            // Initialize the Timer
            loadingTimer = new System.Windows.Forms.Timer
            {
                Interval = 500 // Timer ticks every 100 milliseconds
            };
            loadingTimer.Tick += LoadingTimer_Tick; // Attach the Tick event
            soundPlayer = new SoundPlayer("loadingScreen.wav");
            soundPlayer.Play();



        }


        private void LoadingTimer_Tick(object sender, EventArgs e)
        {
            // Check if progress bar value is less than the maximum
            if (pbarLoading.Value < pbarLoading.Maximum)
            {
               
                pbarLoading.Value += 5; // Increment progress bar by 5%
            }
            else
            {
                // Stop the timer when the progress reaches 100%
                soundPlayer.Stop();// Stop the sound
                loadingTimer.Stop();

                // Open the LoginPageForm
                LoginPageForm loginPage = new LoginPageForm();
                loginPage.Show();

                // Close the current form
                this.Hide();
            }
        }

        private void pbarLoading_Click(object sender, EventArgs e)
        {
            // Optional event handler for progress bar clicks
        }

        private void LoadingScreen_Load_1(object sender, EventArgs e)
        {
            // Set initial progress bar value to 0
            pbarLoading.Value = 0;

            // Start the Timer when the form loads
            loadingTimer.Start();
        }

        private void LoadingScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit(); // Exit the application when the form is closed
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
