using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Fitness4u__Project_
{
    public partial class First_steps_questionaire : Form
    {
        public string username;

        public First_steps_questionaire()
        {
            InitializeComponent();
            // username value grabbed from Create_account_log_in Form
            username = Create_Account_Log_In.username;
        }

        ///////////////
        // Variables //
        ///////////////

        // q#rbtnvalue - used to get answer value for switch statements e.g. line 7
        private string q1rbtnvalue;
        private string q2rbtnvalue;
        private string q3rbtnvalue;
        private string q4rbtnvalue;

        // The 3 exercise categories
        private int catMusclePref;
        private int catCardioPref;
        private int catStrengthPref;

        // the higher the number, the more challenging exercises will be
        private int exerciseDifficulty = 0;

        // the higher the number, the more often they will recieve exercise suggestions
        private int exerciseRegularity = 0;



        ////////////////////////
        // Question 1 answers //
        ////////////////////////    
        private void q1answer1Rbtn_CheckedChanged(object sender, EventArgs e) // answer 1
        {
            q1rbtnvalue = "a1";
        }

        private void q1answer2Rbtn_CheckedChanged(object sender, EventArgs e) // answer 2
        {
            q1rbtnvalue = "a2";
        }

        private void q1answer3Rbtn_CheckedChanged(object sender, EventArgs e) // answer 3
        {
            q1rbtnvalue = "a3";
        }

        private void q1answer4Rbtn_CheckedChanged(object sender, EventArgs e) // answer 4
        {
            q1rbtnvalue = "a4";
        }

        ////////////////////////
        // Question 2 answers //
        ////////////////////////
        private void q2answer1Rbtn_CheckedChanged(object sender, EventArgs e) // answer 1
        {
            q2rbtnvalue = "a1";
        }

        private void q2answer2Rbtn_CheckedChanged(object sender, EventArgs e) // answer 2
        {
            q2rbtnvalue = "a2";
        }

        private void q2answer3Rbtn_CheckedChanged(object sender, EventArgs e) // answer 3
        {
            q2rbtnvalue = "a3";
        }

        private void q2answer4Rbtn_CheckedChanged(object sender, EventArgs e) // answer 4
        {
            q2rbtnvalue = "a4";
        }

        private void q2answer5Rbtn_CheckedChanged(object sender, EventArgs e) // answer 5
        {
            q2rbtnvalue = "a5";
        }



        ////////////////////////
        // Question 3 answers //
        ////////////////////////
        private void q3answer1Rbtn_CheckedChanged(object sender, EventArgs e) // answer 1
        {
            q3rbtnvalue = "a1";
        }

        private void q3answer2Rbtn_CheckedChanged(object sender, EventArgs e) // answer 2
        {
            q3rbtnvalue = "a2";
        }

        private void q3answer3Rbtn_CheckedChanged(object sender, EventArgs e) // answer 3
        {
            q3rbtnvalue = "a3";
        }

        private void q3answer4Rbtn_CheckedChanged(object sender, EventArgs e) // answer 4
        {
            q3rbtnvalue = "a4";
        }



        ////////////////////////
        // Question 4 answers //
        ////////////////////////
        private void q4answer1Rbtn_CheckedChanged(object sender, EventArgs e)
        {
            q4rbtnvalue = "a1";
        }

        private void q4answer2Rbtn_CheckedChanged(object sender, EventArgs e)
        {
            q4rbtnvalue = "a2";
        }

        private void q4answer3Rbtn_CheckedChanged(object sender, EventArgs e)
        {
            q4rbtnvalue = "a3";
        }

        private void q4answer4Rbtn_CheckedChanged(object sender, EventArgs e)
        {
            q4rbtnvalue = "a4";
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {

            /////////////////////////////////
            // Question 1 Switch statement //
            /////////////////////////////////
            switch (q1rbtnvalue)
            {
                case "a1":
                    // highest difficulty - more challenging exercises
                    exerciseDifficulty = 4;
                    break;

                case "a2":
                    exerciseDifficulty = 3;
                    break;

                case "a3":
                    exerciseDifficulty = 2;
                    break;

                case "a4":
                    // lowest difficuluty - easy and rewarding exercises
                    exerciseDifficulty = 1;
                    break;
            }



            /////////////////////////////////
            // Question 2 Switch statement //
            /////////////////////////////////
            switch (q2rbtnvalue)
            {
                case "a1": // Strength focus
                    catStrengthPref = catStrengthPref + 10;
                    break;

                case "a2": // Weightloss focus
                    // good balance of preferences for weightloss focus
                    catStrengthPref = catStrengthPref + 1;
                    catCardioPref = catCardioPref + 2;
                    catMusclePref = catMusclePref + 2;
                    break;

                case "a3": // Cardio focus
                    catCardioPref = 10;
                    break;

                case "a4": // Muscle focus
                    catMusclePref = 10;
                    break;

                case "a5": // No particular focus
                    // completely even balance of preferences
                    catStrengthPref = catStrengthPref + 2;
                    catCardioPref = catCardioPref + 2;
                    catMusclePref = catMusclePref + 2;
                    break;
            }



            /////////////////////////////////
            // Question 3 Switch statement //
            /////////////////////////////////
            switch (q3rbtnvalue)
            {
                case "a1": // Jogging
                    catCardioPref = catCardioPref + 5;
                    break;

                case "a2": // Pushups
                    catStrengthPref = catStrengthPref + 5;
                    catMusclePref = catMusclePref + 5;
                    break;

                case "a3": // Burpees
                    catCardioPref = catCardioPref + 2;
                    break;

                case "a4": // Plank
                    catStrengthPref = catStrengthPref + 2;
                    catMusclePref = catMusclePref + 2;
                    break;
            }



            /////////////////////////////////
            // Question 4 Switch statement //
            /////////////////////////////////
            switch (q4rbtnvalue)
            {
                case "a1": // Once a day
                    exerciseRegularity = 4;
                    break;

                case "a2": // Every other day
                    exerciseRegularity = 3;
                    break;

                case "a3": // Twice a week
                    exerciseRegularity = 2;
                    break;

                case "a4": // Once a week
                    exerciseRegularity = 1;
                    break;
            }
            
            ////////////////////////
            // Storing the values //
            ////////////////////////
            

            // filepath = the location of the users .txt file
            string filepath = @"C:\Users\David Correia\source\repos\Fitness4u-Project-1\data\" + "\\users\\" + username + ".txt";
            using (StreamWriter firststepsdata = new StreamWriter(filepath))

            using (firststepsdata)
            {

                // creating the heading in the .txt to put all first steps answers
                // blank writelines used to create paragraphs in .txt file
                firststepsdata.WriteLine("");
                firststepsdata.WriteLine("");
                firststepsdata.WriteLine("/////////////////////////");
                firststepsdata.WriteLine("// First steps answers //");
                firststepsdata.WriteLine("/////////////////////////");
                firststepsdata.WriteLine("");

                // question answers stored in .txt
                firststepsdata.WriteLine("q1answer: " + q1rbtnvalue);
                firststepsdata.WriteLine("q2answer: " + q2rbtnvalue);
                firststepsdata.WriteLine("q3answer: " + q3rbtnvalue);
                firststepsdata.WriteLine("q4answer: " + q4rbtnvalue);
            }
        }
    }
}
