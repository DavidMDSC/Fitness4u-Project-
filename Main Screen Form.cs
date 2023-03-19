using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness4u__Project_
{
    public partial class Main_Screen : Form
    {
        public Main_Screen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtmNavBarLine_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Journallicon_Click(object sender, EventArgs e)
        {

        }

        private void currentfitptsLblVar_Click(object sender, EventArgs e)
        {

        }

        private void dayLbl_Click(object sender, EventArgs e)
        {

        }

        private void fitsuggLine4Picbox_Click(object sender, EventArgs e)
        {

        }

        private void journalText2Lbl_Click(object sender, EventArgs e)
        {

        }

        private void yourprogresssatLbl_Click(object sender, EventArgs e)
        {

        }

        private void journalIconPicBox_Click(object sender, EventArgs e)
        {

        }

        private void fitsuggText1Lbl_Click(object sender, EventArgs e)
        {

        }

        private void MainScreenForm_fitsugIcon_Click(object sender, EventArgs e)
        {
            // hide Main_Screen
            this.Hide();
            // create an instance of Fitness_Suggestion_Page
            Fitness_Suggestion_Page FitnessSuggestionPage = new Fitness_Suggestion_Page();
            // show Fitness_Suggestion_Page
            FitnessSuggestionPage.ShowDialog(); // will halt/freeze the execution of the click event.
            // dispose of Main_Screen instance
            FitnessSuggestionPage = null;
            // show Main_screen again
            //this.Show();
        }

        private void MainScreenForm_mainmenuIcon_Click(object sender, EventArgs e)
        {
            // DO NOT TOUCH - THIS BUTTON IS NOT MEANT TO FUNCTION AS IT IS THE FORM WE AE ON NOW
        }

        private void MainScreenForm_exerciselistIcon_Click(object sender, EventArgs e)
        {
            // hide Main_Screen
            this.Hide();
            // create an instance of Exercise_list
            Exercise_list ExerciseList = new Exercise_list();
            // show Exercise_list
            ExerciseList.ShowDialog(); // will halt/freeze the execution of the click event.
            // dispose of Main_Screen instance
            ExerciseList = null;
            // show Main_screen again
            //this.Show();
        }

        private void MainScreenForm_journalIcon_Click(object sender, EventArgs e)
        {
            // hide Main_Screen
            this.Hide();
            // create an instance of Fitness_journal
            Fitness_journal FitnessJournal = new Fitness_journal();
            // show Fitness_journal
            FitnessJournal.ShowDialog(); // will halt/freeze the execution of the click event.
            // dispose of Main_Screen instance
            FitnessJournal = null;
            // show Main_screen again
            //this.Show();
        }

        private void MainScreenForm_userIcon_Click(object sender, EventArgs e)
        {
            // hide Main_Screen
            this.Hide();
            // create an instance of User_settings
            User_settings UserSettings = new User_settings();
            // show User_settings
            UserSettings.ShowDialog(); // will halt/freeze the execution of the click event.
            // dispose of Main_Screen instance
            UserSettings = null;
            // show Main_screen again
            //this.Show();
        }
    }
}
