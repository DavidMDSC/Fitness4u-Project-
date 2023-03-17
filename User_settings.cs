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
            // hide Fitness_journal
            this.Hide();
            // create an instance of Exercise_list
            Exercise_list ExerciseList = new Exercise_list();
            // show Exercise_list
            ExerciseList.ShowDialog(); // will halt/freeze the execution of the click event.
            // dispose of Fitness_journal instance
            ExerciseList = null;
            // show Fitness_journal again
            this.Show();
        }

        private void UserSettings_fitsugIcon_Click(object sender, EventArgs e)
        {
            // hide Fitness_journal
            this.Hide();
            // create an instance of Fitness_Suggestion_Page
            Fitness_Suggestion_Page FitnessSuggestionPage = new Fitness_Suggestion_Page();
            // show Fitness_Suggestion_Page
            FitnessSuggestionPage.ShowDialog(); // will halt/freeze the execution of the click event
            // dispose of Fitnss_journal instance
            FitnessSuggestionPage = null;
            // show Fitness_journal again
            this.Show();
        }

        private void UserSettings_mainmenuIcon_Click(object sender, EventArgs e)
        {
            // hide Fitness_journal
            this.Hide();
            // create an instance of Main_Screen
            Main_Screen MainScreen = new Main_Screen();
            // show Main_Screen
            MainScreen.ShowDialog(); // will halt/freeze the execution of the click event.
            // dispose of Fitness_journal instance
            MainScreen = null;
            // show Fitness_journal again
            this.Show();
        }

        private void UserSettings_journalIcon_Click(object sender, EventArgs e)
        {
            // hide Fitness_Suggestion_Page
            this.Hide();
            // create an instance of Fitness_journal
            Fitness_journal FitnessJournal = new Fitness_journal();
            // Show Fitness_journal
            FitnessJournal.ShowDialog(); // will halt/freeze the execution of the click event
            // dispose of Fitness_Suggestion_Page
            FitnessJournal = null;
            // show Fitness_Suggestion_Page again
            this.Show();
        }

        private void UserSettings_userIcon_Click(object sender, EventArgs e)
        {

        }
    }
}
