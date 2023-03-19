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
    public partial class Exercise_list : Form
    {
        public Exercise_list()
        {
            InitializeComponent();
        } 

        private void Exercise_list_Load(object sender, EventArgs e)
        {
         
        }

        private void ExerciseList_exerciselistIcon_Click(object sender, EventArgs e)
        {
            // DO NOT TOUCH - THIS BUTTON IS NOT MEANT TO FUNCTION AS IT THE FORM WE ARE ON NOW
        }

        private void ExerciseList_fitsugIcon_Click(object sender, EventArgs e)
        {
            // hide Exercise_list
            this.Hide();
            // create an instance of Fitness_Suggestion_Page
            Fitness_Suggestion_Page FitnessSuggestionPage = new Fitness_Suggestion_Page();
            // show Fitness_Suggestion_Page
            FitnessSuggestionPage.ShowDialog(); // will halt/freeze the execution of the click event.
            // dispose of Exercise_list instance
            FitnessSuggestionPage = null;
            // show Exercise_list again
            //this.Show();
        }

        private void ExerciseList_mainmenuIcon_Click(object sender, EventArgs e)
        {
            // hide Exercise_list
            this.Hide();
            // create an instance of Main_Screen
            Main_Screen MainScreen = new Main_Screen();
            // show Main_Screen
            MainScreen.ShowDialog(); // will halt/freeze the execution of the click event.
            // dispose of Exercise_list instance
            MainScreen = null;
            // show Exercise_list again
            //this.Show();
        }

        private void ExerciseList_journalIcon_Click(object sender, EventArgs e)
        {
            // hide Exercise_list
            this.Hide();
            // create an instance of Fitness_journal
            Fitness_journal FitnessJournal = new Fitness_journal();
            // show Fitness_journal
            FitnessJournal.ShowDialog(); // will halt/freeze the execution of the click event.
            // dispose of Exercise_list instance
            FitnessJournal = null;
            // show Exercise_list again
            //this.Show();
        }

        private void ExerciseList_userIcon_Click(object sender, EventArgs e)
        {
            // hide Exercise_list
            this.Hide();
            // create an instance of User_settings
            User_settings UserSettings = new User_settings();
            // show User_settings
            UserSettings.ShowDialog(); // will halt/freeze the execution of the click event.
            // dispose of Exercise_list instance
            UserSettings = null;
            // show Exercise_list again
            this.Show();
        }
    }
}
