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
    public partial class Fitness_Suggestion_Page : Form
    {
        public Fitness_Suggestion_Page()
        {
            InitializeComponent();
        }

        private void Fitness_Suggestion_Page_Load(object sender, EventArgs e)
        {

        }

        private void exercise4imgPicBoxVar_Click(object sender, EventArgs e)
        {

        }

        private void FitnessSuggestionPage_mainmenuIcon_Click(object sender, EventArgs e)
        {
            // hide Fitness_Suggestion_Page
            this.Hide();
            // create an instance of Main_Screen
            Main_Screen MainScreen = new Main_Screen();
            // show Main_Screen
            MainScreen.ShowDialog(); // will halt/freeze the execution of the click event.
            // dispose of Fitness_Suggestion_Page instance
            MainScreen = null;
            // show Fitness_Suggestion_Page again
            this.Show();
        }

        private void FitnessSuggestionPage_exerciselistIcon_Click(object sender, EventArgs e)
        {
            // hide Fitness_Suggestion_Page
            this.Hide();
            // create an instance of Exercise_list
            Exercise_list ExerciseList = new Exercise_list();
            // show Exercise_list
            ExerciseList.ShowDialog(); // will halt/freeze the execution of the click event.
            // dispose of Fitness_Suggestion_Page instance
            ExerciseList = null;
            // show Fitness_Suggestion_Page again
            this.Show();
        }

        private void FitnessSuggestionPage_fitsugIcon_Click(object sender, EventArgs e)
        {
            // DO NOT TOUCH - THIS BUTTON IS NOT MEANT TO FUNCTION AS IT THE FORM WE ARE ON NOW
        }

        private void FitnessSuggestionPage_journalIcon_Click(object sender, EventArgs e)
        {
            // hide Fitness_Suggestion_Page
            this.Hide();
            // create an instance of Fitness_journal
            Fitness_journal FitnessJournal = new Fitness_journal();
            // Show Fitness_journal
            FitnessJournal.ShowDialog(); // will halt/freeze the execution of the click event
            // dispose of Fitness_Suggestion_Page instance
            FitnessJournal = null;
            // show Fitness_Suggestion_Page again
            this.Show();
        }

        private void FitnessSuggestionPage_userIcon_Click(object sender, EventArgs e)
        {
            // hide Fitness_Suggestion_Page
            this.Hide();
            // create an instance of User_settings
            User_settings UserSettings = new User_settings();
            // show User_settings
            UserSettings.ShowDialog(); // will halt/freeze the execution of the click event.
            // dispose of Fitness_Suggestion_Page instance
            UserSettings = null;
            // show Fitness_Suggestion_Page again
            this.Show();
        }
    }
}