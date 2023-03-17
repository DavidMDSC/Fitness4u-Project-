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
    public partial class Fitness_journal : Form
    {
        public Fitness_journal()
        {
            InitializeComponent();
        }

        private void Fitness_journal_Load(object sender, EventArgs e)
        {

        }

        private void yourprogressgraphXPicbox_Click(object sender, EventArgs e)
        {

        }

        private void FitnessJournal_exerciselistIcon_Click(object sender, EventArgs e)
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

        private void FitnessJournal_fitsugIcon_Click(object sender, EventArgs e)
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

        private void FitnessJournal_mainmenuIcon_Click(object sender, EventArgs e)
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

        private void FitnessJournal_journalIcon_Click(object sender, EventArgs e)
        {

        }

        private void FitnessJournal_userIcon_Click(object sender, EventArgs e)
        {
            // hide Fitness_journal
            this.Hide();
            // create an instance of User_settings
            User_settings UserSettings = new User_settings();
            // show User_settings
            UserSettings.ShowDialog(); // will halt/freeze the execution of the click event.
            // dispose of Fitness_journal instance
            UserSettings = null;
            // show Fitness_journal again
            this.Show();
        }
    }
}
