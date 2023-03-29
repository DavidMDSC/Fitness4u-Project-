using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness4u__Project_
{
    public partial class Main_Screen : Form
    {
        public static bool firsttime;
        public static string username;
        public Main_Screen()
        {
            InitializeComponent();
            firsttime = Create_Account_Log_In.firsttime;
            username = Create_Account_Log_In.username;
        }

        private void MainScreenForm_mainmenuIcon_Click(object sender, EventArgs e)
        {
            // DO NOT TOUCH - THIS BUTTON IS NOT MEANT TO FUNCTION AS IT IS THE FORM WE AE ON NOW
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
            this.Show();
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
            this.Show();


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
            this.Show();
        }

        private void MainScreenForm_fitsugIcon_Click(object sender, EventArgs e)
        {
            string filepath = @"C:\Users\David Correia\source\repos\Fitness4u-Project-1\data\" + "\\users\\" + username + ".txt";
            int linenumber = 3; // "firsttime: " will be on the 3rd line of the .txt
            string line = File.ReadLines(filepath).Skip(linenumber - 1).FirstOrDefault(); // set to read the 3rd line from the .txt

            // Message box for testing
            MessageBox.Show(line);

            if (line == "firsttime: true")
            {
                //hide Main_Screen
                this.Hide();
                // create an instance of first_steps_questionaire
                First_steps_questionaire firststepsquestionaire = new First_steps_questionaire();
                // show first_steps_questionaire
                firststepsquestionaire.ShowDialog(); // will halt/freeze the execution of the click event
                // dispose of Main_Screen instance
                firststepsquestionaire = null;

            }
            else
            {
                // hide Main_Screen
                this.Hide();
                // create an instance of Fitness_Suggestion_Page
                Fitness_Suggestion_Page FitnessSuggestionPage = new Fitness_Suggestion_Page();
                // show Fitness_Suggestion_Page
                FitnessSuggestionPage.ShowDialog(); // will halt/freeze the execution of the click event.
                // dispose of Main_Screen instance
                FitnessSuggestionPage = null;
                //show Main_screen again
                this.Show();
            }



            // BROKEN CODE BELOW - RETURNING LOGIC ERROR.

            // using (StreamReader firsttimecheck = new StreamReader(filepath1))
            //{
            //string line = firsttimecheck.ReadLine(); // used to set the while loop
            //while (line != null) // will loop until it has reached the value it is looking for
            //{
            //string[] lineArr = new string[0]; // the lines in the .txt will act as an array
            //lineArr = line.Split(' '); // will only read the text after the space
            //if (lineArr[2] == "true") // is checking to see if the user has accessed the fitness_suggestion_page Form or not before
            //{
            // hide Main_Screen
            //this.Hide();
            // create an instance of first_steps_questionaire
            //First_steps_questionaire firststepsquestionaire = new First_steps_questionaire();
            // show first_steps_questionaire
            //firststepsquestionaire.ShowDialog(); // will halt/freeze the execution of the click event
            // dispose of Main_Screen instance
            //firststepsquestionaire = null;                    

            //}
            //else
            //{
            // hide Main_Screen
            //this.Hide();
            // create an instance of Fitness_Suggestion_Page
            //Fitness_Suggestion_Page FitnessSuggestionPage = new Fitness_Suggestion_Page();
            // show Fitness_Suggestion_Page
            //FitnessSuggestionPage.ShowDialog(); // will halt/freeze the execution of the click event.
            // dispose of Main_Screen instance
            //FitnessSuggestionPage = null;
            // show Main_screen again
            //this.Show();
            //}
            //}
            //}

        }       
    }
}
   
