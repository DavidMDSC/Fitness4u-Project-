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
    public partial class User_settings : Form
    {
        public User_settings()
        {
            InitializeComponent();
        }

        private void UserSettings_exerciselistIcon_Click(object sender, EventArgs e)
        {
            // hide User_settings
            this.Hide();
            // create an instance of Exercise_list
            Exercise_list ExerciseList = new Exercise_list();
            // show Exercise_list
            ExerciseList.ShowDialog(); // will halt/freeze the execution of the click event.
            // dispose of User_settings instance
            ExerciseList = null;
            // show User_settings again
            this.Show();
        }

        private void UserSettings_fitsugIcon_Click(object sender, EventArgs e)
        {
            // hide User_settings
            this.Hide();
            // create an instance of Fitness_Suggestion_Page
            Fitness_Suggestion_Page FitnessSuggestionPage = new Fitness_Suggestion_Page();
            // show Fitness_Suggestion_Page
            FitnessSuggestionPage.ShowDialog(); // will halt/freeze the execution of the click event
            // dispose of User_settings instance
            FitnessSuggestionPage = null;
            // show User_settings again
            this.Show();
        }

        private void UserSettings_mainmenuIcon_Click(object sender, EventArgs e)
        {
            // hide User_settings
            this.Hide();
            // create an instance of Main_Screen
            Main_Screen MainScreen = new Main_Screen();
            // show Main_Screen
            MainScreen.ShowDialog(); // will halt/freeze the execution of the click event.
            // dispose of User_settings instance
            MainScreen = null;
            // show User_settings again
            this.Show();
        }

        private void UserSettings_journalIcon_Click(object sender, EventArgs e)
        {
            // hide User_settings
            this.Hide();
            // create an instance of Fitness_journal
            Fitness_journal FitnessJournal = new Fitness_journal();
            // Show Fitness_journal
            FitnessJournal.ShowDialog(); // will halt/freeze the execution of the click event
            // dispose of User_settings
            FitnessJournal = null;
            // show User_settings again
            this.Show();
        }

        private void UserSettings_userIcon_Click(object sender, EventArgs e)
        {
            // DO NOT TOUCH - THIS BUTTON IS NOT MEANT TO FUNCTION AS IT THE FORM WE ARE ON NOW
        }
    }
}
