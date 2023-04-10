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
        
        /////////////////////////////
        // All potential exercises //
        /////////////////////////////

        // Exercise: pushups
        public static int pushupCardio;
        public static int pushupMuscle;
        public static int pushupStrength;

        // Exercise: step-ups
        public static int stepupCardio;
        public static int stepupMuscle;
        public static int stepupStrength;

        // Exercise: squat jumps
        public static int squatjumpCardio;
        public static int squatjumpMuscle;
        public static int squatjumpStrength;

        // Exercise: burpees
        public static int burpeeCardio;
        public static int burpeeMuscle;
        public static int burpeeStrength;

        // Exercise: standing side hops
        public static int sidehopCardio;
        public static int sidehopMuscle;
        public static int sidehopStength;

        // Exercise: pullups
        public static int pullupCardio;
        public static int pullupMuscle;
        public static int pullupStrength;

        // Exercise: squat pulses
        public static int squatpulseCardio;
        public static int squatpulseMuscle;
        public static int squatpulseStrength;

        // Exercise: flutter kicks
        public static int flutterkickCardio;
        public static int flutterkickMuscle;
        public static int flutterkickStrength;

        // Exercise: v-sits
        public static int vsitCardio;
        public static int vsitMuscle;
        public static int vsitStrength;

        // Exercise: kickbacks
        public static int kickbackCardio;
        public static int kickbackMuscle;
        public static int kickbackStrength;

        // Exercise: mountain climbers
        public static int climberCardio;
        public static int climberMuscle;
        public static int climberStrength;

        // Exercise: wallsit
        public static int wallsitCardio;
        public static int wallsitMuscle;
        public static int wallsitStrength;

        // Exercise: sit-up
        public static int situpCardio;
        public static int situpMuscle;
        public static int situpStrength;

        // Exercise: plank
        public static int plankCardio;
        public static int plankMuscle;
        public static int plankStrength;

        // Exercise: bicycle
        public static int bicycleCardio;
        public static int bicycleMuscle;
        public static int bicycleStrength;

        public First_steps_questionaire()
        {
            InitializeComponent();
            // username value grabbed from Create_account_log_in Form
            username = Create_Account_Log_In.username;

            // Carrying over all potential exercises from Fitness_Suggestion_Page.cs

            // Exercise: pushups
            pushupCardio = Fitness_Suggestion_Page.pushupCardio;
            pushupMuscle = Fitness_Suggestion_Page.pushupMuscle;
            pushupStrength = Fitness_Suggestion_Page.pushupStrength;

            // Exercise: step-ups
            stepupCardio = Fitness_Suggestion_Page.stepupCardio;
            stepupMuscle = Fitness_Suggestion_Page.stepupMuscle;
            stepupStrength = Fitness_Suggestion_Page.stepupStrength;

            // Exercise: squat jumps
            squatjumpCardio = Fitness_Suggestion_Page.squatjumpCardio;
            squatjumpMuscle = Fitness_Suggestion_Page.squatjumpMuscle;
            squatjumpStrength = Fitness_Suggestion_Page.squatjumpStrength;

            // Exercise: burpees
            burpeeCardio = Fitness_Suggestion_Page.burpeeCardio;
            burpeeMuscle = Fitness_Suggestion_Page.burpeeMuscle;
            burpeeStrength = Fitness_Suggestion_Page.burpeeStrength;

            // Exercise: standing side hops
            sidehopCardio = Fitness_Suggestion_Page.sidehopCardio;
            sidehopMuscle = Fitness_Suggestion_Page.sidehopMuscle;
            sidehopStength = Fitness_Suggestion_Page.sidehopStength;

            // Exercise: pullups
            pullupCardio = Fitness_Suggestion_Page.pullupCardio;
            pullupMuscle = Fitness_Suggestion_Page.pullupMuscle;
            pullupStrength = Fitness_Suggestion_Page.pullupStrength;

            // Exercise: squat pulses
            squatpulseCardio = Fitness_Suggestion_Page.squatpulseCardio;
            squatpulseMuscle = Fitness_Suggestion_Page.squatpulseMuscle;
            squatpulseStrength = Fitness_Suggestion_Page.squatpulseStrength;

            // Exercise: flutter kicks
            flutterkickCardio = Fitness_Suggestion_Page.flutterkickCardio;
            flutterkickMuscle = Fitness_Suggestion_Page.flutterkickMuscle;
            flutterkickStrength = Fitness_Suggestion_Page.flutterkickStrength;

            // Exercise: v-sits
            vsitCardio = Fitness_Suggestion_Page.vsitCardio;
            vsitMuscle = Fitness_Suggestion_Page.vsitMuscle;
            vsitStrength = Fitness_Suggestion_Page.vsitStrength;

            // Exercise: kickbacks
            kickbackCardio = Fitness_Suggestion_Page.kickbackCardio;
            kickbackMuscle = Fitness_Suggestion_Page.kickbackMuscle;
            kickbackStrength = Fitness_Suggestion_Page.kickbackStrength;

            // Exercise: mountain climbers
            climberCardio = Fitness_Suggestion_Page.climberCardio;
            climberMuscle = Fitness_Suggestion_Page.climberMuscle;
            climberStrength = Fitness_Suggestion_Page.climberStrength;

            // Exercise: wallsit
            wallsitCardio = Fitness_Suggestion_Page.wallsitCardio;
            wallsitMuscle = Fitness_Suggestion_Page.wallsitMuscle;
            wallsitStrength = Fitness_Suggestion_Page.wallsitStrength;

            // Exercise: sit-up
            situpCardio = Fitness_Suggestion_Page.situpCardio;
            situpMuscle = Fitness_Suggestion_Page.situpMuscle;
            situpStrength = Fitness_Suggestion_Page.situpStrength;

            // Exercise: plank
            plankCardio = Fitness_Suggestion_Page.plankCardio;
            plankMuscle = Fitness_Suggestion_Page.plankMuscle;
            plankStrength = Fitness_Suggestion_Page.plankStrength;

            // Exercise: bicycle
            bicycleCardio = Fitness_Suggestion_Page.bicycleCardio;
            bicycleMuscle = Fitness_Suggestion_Page.bicycleMuscle;
            bicycleStrength = Fitness_Suggestion_Page.bicycleStrength;
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
        static public int exerciseDifficulty = 0;

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

        /////////////////////////////////
        // submitBtn event occurs here //
        /////////////////////////////////
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
                    catCardioPref = catCardioPref + 10;
                    break;

                case "a4": // Muscle focus
                    catMusclePref = catMusclePref + 10;
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
                    catStrengthPref = catStrengthPref + 7;
                    catMusclePref = catMusclePref + 5;
                    break;

                case "a3": // Burpees
                    catCardioPref = catCardioPref + 3;
                    break;

                case "a4": // Plank
                    catStrengthPref = catStrengthPref + 4;
                    catMusclePref = catMusclePref + 7;
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

            //try
            //{
            //string filepath1 = @"C:\Users\David Correia\source\repos\Fitness4u-Project-1\data\" + "\\users\\" + username + ".txt";
            //string[] firststepsdata =
            //{
            //"",
            //"",
            //"/////////////////////////",
            //"// First steps answers //",
            //"/////////////////////////",
            //"",
            //"q1answer: " + q1rbtnvalue,
            //"q2answer: " + q2rbtnvalue,
            //"q3answer: " + q3rbtnvalue,
            //"q4answer: " + q4rbtnvalue,
            //};
            //File.WriteAllLines(filepath1, firststepsdata);

            // Pop-up box will show displaying the message below
            //MessageBox.Show("Data stored successfully!", "Success!");
            //}
            //catch
            //{
            //    MessageBox.Show("Error has occured", "Error! - FTQ");       
            //}



            // filepath = the location of the users .txt file
            string filepath1 = @"C:\Users\David Correia\source\repos\Fitness4u-Project-1\data\" + "\\users\\" + username + ".txt";
            MessageBox.Show(filepath1); // to test its working - remove when testing is complete
            try
            {
                //StreamWriter firststepsdata = new StreamWriter(filepath1);
                using (StreamWriter firststepsdata = new StreamWriter(filepath1, true)) // needed it to be true in order to write to text file
                {
                    firststepsdata.WriteLine(""); // creating the heading in the .txt to put all first steps answers
                    firststepsdata.WriteLine(""); // blank writelines used to create paragraphs in .txt file
                    firststepsdata.WriteLine("/////////////////////////");
                    firststepsdata.WriteLine("// First steps answers //");
                    firststepsdata.WriteLine("/////////////////////////");
                    firststepsdata.WriteLine("");
                    firststepsdata.WriteLine("q1answer: " + q1rbtnvalue); // question answers stored in .txt
                    firststepsdata.WriteLine("q2answer: " + q2rbtnvalue);
                    firststepsdata.WriteLine("q3answer: " + q3rbtnvalue);
                    firststepsdata.WriteLine("q4answer: " + q4rbtnvalue);
                }

                // Pop-up box will show displaying the message below
                MessageBox.Show("Data stored successfully!", "Success!");
            }
            catch
            {
                MessageBox.Show("Error has occured", "Error! - FSQ");
            }

            //editing the 3rd line in the users .txt file from "firsttime: true" to "firsttime: false"
            int line_to_edit = 3; // 3rd line is the line we want to edit
            string[] arrLine = File.ReadAllLines(filepath1);
            arrLine[line_to_edit - 1] = "firsttime: false"; // changes 3rd line to "firsttime: false"

            // MessageBox for testing to see if line was replaced
            MessageBox.Show(arrLine[line_to_edit - 1]);










            //////////////////////////////////
            // FITNESS SUGGESTION ALGORITHM //
            //////////////////////////////////

            // ensures the user doesnt break the algorithm by closing the Form halfway through
            MessageBox.Show("Exercises being generated - Don't close the Form", "DONT CLOSE!");

            // mainfocus variable used to determine users primary fitness focus
            int mainfocus; // 1 = Cardio, 2 = Muscle, 3 = Strength.
            // following if statement handles answers to question 2 and 3.
            if (catCardioPref >= catMusclePref && catCardioPref >= catStrengthPref)
            {
                mainfocus = 1;    
            }
            else if (catMusclePref >= catStrengthPref)
            {
                mainfocus = 2;
            }
            else
            {
                mainfocus = 3;
            }

            int cardioRnd_1; // 1st cardio exercise
            int cardioRnd_2; // 2nd cardio exercise
            int cardioRnd_3; // 3rd cardio exercise
            int muscleRnd_1; // 1st muscle exercise
            int muscleRnd_2; // 2nd muscle exercise
            int muscleRnd_3; // 3rd muscle exercise
            int strengthRnd_1; // 1st strength exercise
            int strengthRnd_2; // 2nd strength exercise
            int strengthRnd_3; // 3rd strength exercise
            Random rnd = new Random();

            // CARDIO EXERCISE GENERATOR
            cardioRnd_1 = rnd.Next(1, 5); // will generate a number between 1 and 4
            cardioRnd_2 = rnd.Next(1, 5); // will generate a second number between 1 and 4
            while (cardioRnd_1 == cardioRnd_2) // this is becasue there are 4 cardio focus exercises
            {
                cardioRnd_2 = rnd.Next(1, 5); // will generate a new second number if it is the same as the previous one
            }
            cardioRnd_3 = rnd.Next(1, 5); // will generate a third number between 1 and 4
            while (cardioRnd_3 == cardioRnd_2 || cardioRnd_3 == cardioRnd_1)
            {
                cardioRnd_3 = rnd.Next(1, 5); // will generate a new third number if it is the same as one of the previous two
            }
            
            // MUSCLE EXERCISE GENERATOR
            muscleRnd_1 = rnd.Next(1, 8); // will generate a number between 1 and 7
            muscleRnd_2 = rnd.Next(1, 8); // will generate a second number between 1 and 7
            while (muscleRnd_1 == muscleRnd_2) // this is because there are 7 muscle focus exercises
            {
                muscleRnd_2 = rnd.Next(1, 8); // will generate a new second number if it is the same as the previous one
            }
            muscleRnd_3 = rnd.Next(1, 8); // will generate a third number between 1 and 7
            while (muscleRnd_3 == muscleRnd_2 || muscleRnd_3 == muscleRnd_1) 
            {
                muscleRnd_3 = rnd.Next(1, 8); // will generate a new third number if it is the same as one of the previous two 
            }
                                            
            // STRENGTH EXERCISE GENERATOR
            strengthRnd_1 = rnd.Next(1, 5); // will generate a number between 1 and 4
            strengthRnd_2 = rnd.Next(1, 5); // will generate a second number between 1 and 4
            while (strengthRnd_1 == strengthRnd_2)
            {
                strengthRnd_2 = rnd.Next(1, 5); // will generate a new second number if it is the same as the previous one
            }
            strengthRnd_3 = rnd.Next(1, 5); // will generate a third number between 1 and 4
            while (strengthRnd_3 == strengthRnd_2 || strengthRnd_3 == strengthRnd_1)
            {
                muscleRnd_3 = rnd.Next(1, 5); // will generate a new third number if it is the same as one of the previous two
            }

            switch (mainfocus)
            {
                ///////////////////////////
                // CASE 1 - CARDIO FOCUS //
                ///////////////////////////
                
                case 1: // Cardio focus
                    // 5 Exercises total. We want to give the user:
                    // 3 Cardio exercises
                    // 1 Muscle exercise
                    // 1 Strength exercise
                    
                    // EXERCISE 1
                    switch (cardioRnd_1)
                    {
                        case 1: // Exercise: step-ups
                            StreamWriter case1cardio1 = new StreamWriter(filepath1, true);
                            using (case1cardio1)
                            {
                                case1cardio1.WriteLine("Exercise 1: step-ups");
                            }
                            break;
                        case 2: // Exercise: squat-jumps
                            StreamWriter case1cardio2 = new StreamWriter(filepath1, true);
                            using (case1cardio2)
                            {
                                case1cardio2.WriteLine("Exercise 1: squat-jumps");
                            }
                            break;
                        case 3: // Exercise: burpees
                            StreamWriter case1cardio3 = new StreamWriter(filepath1, true);
                            using (case1cardio3)
                            {
                                case1cardio3.WriteLine("Exercise 1: burpees");
                            }
                            break;
                        case 4: // Exercise: standing side hops
                            StreamWriter case1cardio4 = new StreamWriter(filepath1, true);
                            using (case1cardio4)
                            {
                                case1cardio4.WriteLine("Exercise 1: side-hops");
                            }
                            break;
                    }

                    // EXERCISE 2
                    switch (cardioRnd_2)
                    {
                        case 1: // Exercise: step-ups
                            StreamWriter case1cardio1 = new StreamWriter(filepath1, true);
                            using (case1cardio1)
                            {
                                case1cardio1.WriteLine("Exercise 2: step-ups");
                            }
                            break;
                        case 2: // Exercise: squat-jumps
                            StreamWriter case1cardio2 = new StreamWriter(filepath1, true);
                            using (case1cardio2)
                            {
                                case1cardio2.WriteLine("Exercise 2: squat-jumps");
                            }
                            break;
                        case 3: // Exercise: burpees
                            StreamWriter case1cardio3 = new StreamWriter(filepath1, true);
                            using (case1cardio3)
                            {
                                case1cardio3.WriteLine("Exercise 2: burpees");
                            }
                            break;
                        case 4: // Exercise: standing side hops
                            StreamWriter case1cardio4 = new StreamWriter(filepath1, true);
                            using (case1cardio4)
                            {
                                case1cardio4.WriteLine("Exercise 2: side-hops");
                            }
                            break;
                    }

                    // EXERCISE 3
                    switch (cardioRnd_3)
                    {
                        case 1: // Exercise: step-ups
                            StreamWriter case1cardio1 = new StreamWriter(filepath1, true);
                            using (case1cardio1)
                            {
                                case1cardio1.WriteLine("Exercise 3: step-ups");
                            }
                            break;
                        case 2: // Exercise: squat-jumps
                            StreamWriter case1cardio2 = new StreamWriter(filepath1, true);
                            using (case1cardio2)
                            {
                                case1cardio2.WriteLine("Exercise 3: squat-jumps");
                            }
                            break;
                        case 3: // Exercise: burpees
                            StreamWriter case1cardio3 = new StreamWriter(filepath1, true);
                            using (case1cardio3)
                            {
                                case1cardio3.WriteLine("Exercise 3: burpees");
                            }
                            break;
                        case 4: // Exercise: standing side hops
                            StreamWriter case1cardio4 = new StreamWriter(filepath1, true);
                            using (case1cardio4)
                            {
                                case1cardio4.WriteLine("Exercise 3: side-hops");
                            }
                            break;
                    }

                    // EXERCISE 4
                    switch (muscleRnd_1)
                    {
                        case 1: // Exercise: squat pulses
                            StreamWriter case1muscle1 = new StreamWriter(filepath1, true);
                            using (case1muscle1)
                            {
                                case1muscle1.WriteLine("Exercise 4: squat-pulses");
                            }
                            break;
                        case 2: // Exercise: flutter kicks
                            StreamWriter case1muscle2 = new StreamWriter(filepath1, true);
                            using (case1muscle2)
                            {
                                case1muscle2.WriteLine("Exercise 4: flutter-kicks");
                            }
                            break;
                        case 3: // Exercise: v-sits
                            StreamWriter case1muscle3 = new StreamWriter(filepath1, true);
                            using (case1muscle3)
                            {
                                case1muscle3.WriteLine("Exercise 4: v-sits");
                            }
                            break;
                        case 4: // Exercise: kickbacks
                            StreamWriter case1muscle4 = new StreamWriter(filepath1, true);
                            using (case1muscle4)
                            {
                                case1muscle4.WriteLine("Exercise 4: kickbacks");
                            }
                            break;
                        case 5: // Exercise: mountain climbers
                            StreamWriter case1muscle5 = new StreamWriter(filepath1, true);
                            using (case1muscle5)
                            {
                                case1muscle5.WriteLine("Exercise 4: climbers");
                            }
                            break;
                        case 6: // Exercise: wallsits
                            StreamWriter case1muscle6 = new StreamWriter(filepath1, true);
                            using (case1muscle6)
                            {
                                case1muscle6.WriteLine("Exercise 4: wallsit");
                            }
                            break;
                        case 7: // Exercise: sit-ups
                            StreamWriter case1muscle7 = new StreamWriter(filepath1, true);
                            using (case1muscle7)
                            {
                                case1muscle7.WriteLine("Exercise 4: sit-ups");
                            }
                            break;
                    }

                    // EXERCISE 5
                    switch (strengthRnd_1)
                    {
                        case 1: // Exercise: pushups
                            StreamWriter case1strength1 = new StreamWriter(filepath1, true);
                            using (case1strength1)
                            {
                                case1strength1.WriteLine("Exercise 5: pushups");
                            }
                            break;
                        case 2: // Exercise: pullups
                            StreamWriter case1strength2 = new StreamWriter(filepath1, true);
                            using (case1strength2)
                            {
                                case1strength2.WriteLine("Exercise 5: pullups");
                            }
                            break;
                        case 3: // Exercise: plank
                            StreamWriter case1strength3 = new StreamWriter(filepath1, true);
                            using (case1strength3)
                            {
                                case1strength3.WriteLine("Exercise 5: plank");
                            }
                            break;
                        case 4: // Exercise: bicycle
                            StreamWriter case1strength4 = new StreamWriter(filepath1, true);
                            using (case1strength4)
                            {
                                case1strength4.WriteLine("Exercise 5: bicycle");
                            }
                            break;
                    }
                    break;

                ///////////////////////////
                // CASE 2 - MUSCLE FOCUS //
                ///////////////////////////
                case 2: // Muscle focus
                    // 5 Exercises total:
                    // 3 Muscle
                    // 1 Cardio
                    // 1 Strength

                    // Message boxes for testing purposes
                    MessageBox.Show("muscleRnd_1: " + muscleRnd_1 + ". muscleRnd_2: " + muscleRnd_2 + ". muscleRnd_3: " + muscleRnd_3 +
                        ". cardioRnd_1: " + cardioRnd_1 + ". strengthRnd_1: " + strengthRnd_1);

                    // EXERCISE 1
                    switch (muscleRnd_1)
                    {
                        case 1: // Exercise: squat pulses
                            StreamWriter case2muscle1 = new StreamWriter(filepath1, true);
                            using (case2muscle1)
                            {
                                case2muscle1.WriteLine("Exercise 1: squat-pulses");
                            }
                            break;
                        case 2: // Exercise: flutter kicks
                            StreamWriter case2muscle2 = new StreamWriter(filepath1, true);
                            using (case2muscle2)
                            {
                                case2muscle2.WriteLine("Exercise 1: flutter-kicks");
                            }
                            break;
                        case 3: // Exercise: v-sits
                            StreamWriter case2muscle3 = new StreamWriter(filepath1, true);
                            using (case2muscle3)
                            {
                                case2muscle3.WriteLine("Exercise 1: v-sits");
                            }
                            break;
                        case 4: // Exercise: kickbacks
                            StreamWriter case2muscle4 = new StreamWriter(filepath1, true);
                            using (case2muscle4)
                            {
                                case2muscle4.WriteLine("Exercise 1: kickbacks");
                            }
                            break;
                        case 5: // Exercise: mountain climbers
                            StreamWriter case2muscle5 = new StreamWriter(filepath1, true);
                            using (case2muscle5)
                            {
                                case2muscle5.WriteLine("Exercise 1: climbers");
                            }
                            break;
                        case 6: // Exercise: wallsits
                            StreamWriter case2muscle6 = new StreamWriter(filepath1, true);
                            using (case2muscle6)
                            {
                                case2muscle6.WriteLine("Exercise 1: wallsit");
                            }
                            break;
                        case 7: // Exercise: sit-ups
                            StreamWriter case2muscle7 = new StreamWriter(filepath1, true);
                            using (case2muscle7)
                            {
                                case2muscle7.WriteLine("Exercise 1: sit-ups");
                            }
                            break;
                    }

                    // EXERCISE 2
                    switch (muscleRnd_2)
                    {
                        case 1: // Exercise: squat pulses
                            StreamWriter case2muscle1 = new StreamWriter(filepath1, true);
                            using (case2muscle1)
                            {
                                case2muscle1.WriteLine("Exercise 2: squat-pulses");
                            }
                            break;
                        case 2: // Exercise: flutter kicks
                            StreamWriter case2muscle2 = new StreamWriter(filepath1, true);
                            using (case2muscle2)
                            {
                                case2muscle2.WriteLine("Exercise 2: flutter-kicks");
                            }
                            break;
                        case 3: // Exercise: v-sits
                            StreamWriter case2muscle3 = new StreamWriter(filepath1, true);
                            using (case2muscle3)
                            {
                                case2muscle3.WriteLine("Exercise 2: v-sits");
                            }
                            break;
                        case 4: // Exercise: kickbacks
                            StreamWriter case2muscle4 = new StreamWriter(filepath1, true);
                            using (case2muscle4)
                            {
                                case2muscle4.WriteLine("Exercise 2: kickbacks");
                            }
                            break;
                        case 5: // Exercise: mountain climbers
                            StreamWriter case2muscle5 = new StreamWriter(filepath1, true);
                            using (case2muscle5)
                            {
                                case2muscle5.WriteLine("Exercise 2: climbers");
                            }
                            break;
                        case 6: // Exercise: wallsits
                            StreamWriter case2muscle6 = new StreamWriter(filepath1, true);
                            using (case2muscle6)
                            {
                                case2muscle6.WriteLine("Exercise 2: wallsit");
                            }
                            break;
                        case 7: // Exercise: sit-ups
                            StreamWriter case2muscle7 = new StreamWriter(filepath1, true);
                            using (case2muscle7)
                            {
                                case2muscle7.WriteLine("Exercise 2: sit-ups");
                            }
                            break;
                    }

                    // EXERCISE 3
                    switch (muscleRnd_3)
                    {
                        case 1: // Exercise: squat pulses
                            StreamWriter case2muscle1 = new StreamWriter(filepath1, true);
                            using (case2muscle1)
                            {
                                case2muscle1.WriteLine("Exercise 3: squat-pulses");
                            }
                            break;
                        case 2: // Exercise: flutter kicks
                            StreamWriter case2muscle2 = new StreamWriter(filepath1, true);
                            using (case2muscle2)
                            {
                                case2muscle2.WriteLine("Exercise 3: flutter-kicks");
                            }
                            break;
                        case 3: // Exercise: v-sits
                            StreamWriter case2muscle3 = new StreamWriter(filepath1, true);
                            using (case2muscle3)
                            {
                                case2muscle3.WriteLine("Exercise 3: v-sits");
                            }
                            break;
                        case 4: // Exercise: kickbacks
                            StreamWriter case2muscle4 = new StreamWriter(filepath1, true);
                            using (case2muscle4)
                            {
                                case2muscle4.WriteLine("Exercise 3: kickbacks");
                            }
                            break;
                        case 5: // Exercise: mountain climbers
                            StreamWriter case2muscle5 = new StreamWriter(filepath1, true);
                            using (case2muscle5)
                            {
                                case2muscle5.WriteLine("Exercise 3: climbers");
                            }
                            break;
                        case 6: // Exercise: wallsits
                            StreamWriter case2muscle6 = new StreamWriter(filepath1, true);
                            using (case2muscle6)
                            {
                                case2muscle6.WriteLine("Exercise 3: wallsit");
                            }
                            break;
                        case 7: // Exercise: sit-ups
                            StreamWriter case2muscle7 = new StreamWriter(filepath1, true);
                            using (case2muscle7)
                            {
                                case2muscle7.WriteLine("Exercise 3: sit-ups");
                            }
                            break;
                    }

                    // EXERCISE 4
                    switch (cardioRnd_1)
                    {
                        case 1: // Exercise: step-ups
                            StreamWriter case2cardio1 = new StreamWriter(filepath1, true);
                            using (case2cardio1)
                            {
                                case2cardio1.WriteLine("Exercise 4: step-ups");
                            }
                            break;
                        case 2: // Exercise: squat-jumps
                            StreamWriter case2cardio2 = new StreamWriter(filepath1, true);
                            using (case2cardio2)
                            {
                                case2cardio2.WriteLine("Exercise 4: squat-jumps");
                            }
                            break;
                        case 3: // Exercise: burpees
                            StreamWriter case2cardio3 = new StreamWriter(filepath1, true);
                            using (case2cardio3)
                            {
                                case2cardio3.WriteLine("Exercise 4: burpees");
                            }
                            break;
                        case 4: // Exercise: standing side hops
                            StreamWriter case2cardio4 = new StreamWriter(filepath1, true);
                            using (case2cardio4)
                            {
                                case2cardio4.WriteLine("Exercise 4: side-hops");
                            }
                            break;
                    }

                    // EXERCISE 5
                    switch (strengthRnd_1)
                    {
                        case 1: // Exercise: pushups
                            StreamWriter case2strength1 = new StreamWriter(filepath1, true);
                            using (case2strength1)
                            {
                                case2strength1.WriteLine("Exercise 5: pushups");
                            }
                            break;
                        case 2: // Exercise: pullups
                            StreamWriter case2strength2 = new StreamWriter(filepath1, true);
                            using (case2strength2)
                            {
                                case2strength2.WriteLine("Exercise 5: pullups");
                            }
                            break;
                        case 3: // Exercise: plank
                            StreamWriter case2strength3 = new StreamWriter(filepath1, true);
                            using (case2strength3)
                            {
                                case2strength3.WriteLine("Exercise 5: plank");
                            }
                            break;
                        case 4: // Exercise: bicycle
                            StreamWriter case2strength4 = new StreamWriter(filepath1, true);
                            using (case2strength4)
                            {
                                case2strength4.WriteLine("Exercise 5: bicycle");
                            }
                            break;
                    } 
                    break;

                /////////////////////////////
                // CASE 3 - STRENGTH FOCUS //
                /////////////////////////////
                case 3: // Strength focus
                    // 5 Exercises total:
                    // 3 Strength
                    // 1 Cardio
                    // 1 Muscle

                    // Message boxes for testing purposes
                    MessageBox.Show("strengthRnd_1: " + strengthRnd_1 + ". strengthRnd_2: " + strengthRnd_2 + ". muscleRnd_3: " + strengthRnd_3 +
                        ". cardioRnd_1: " + cardioRnd_1 + ". strengthRnd_1: " + muscleRnd_1);

                    // EXERCISE 1
                    switch (strengthRnd_1)
                    {
                        case 1: // Exercise: pushups
                            StreamWriter case3strength1 = new StreamWriter(filepath1, true);
                            using (case3strength1)
                            {
                                case3strength1.WriteLine("Exercise 1: pushups");
                            }
                            break;
                        case 2: // Exercise: pullups
                            StreamWriter case3strength2 = new StreamWriter(filepath1, true);
                            using (case3strength2)
                            {
                                case3strength2.WriteLine("Exercise 1: pullups");
                            }
                            break;
                        case 3: // Exercise: plank
                            StreamWriter case3strength3 = new StreamWriter(filepath1, true);
                            using (case3strength3)
                            {
                                case3strength3.WriteLine("Exercise 1: plank");
                            }
                            break;
                        case 4: // Exercise: bicycle
                            StreamWriter case3strength4 = new StreamWriter(filepath1, true);
                            using (case3strength4)
                            {
                                case3strength4.WriteLine("Exercise 1: bicycle");
                            }
                            break;
                    }

                    // EXERCISE 2
                    switch (strengthRnd_2)
                    {
                        case 1: // Exercise: pushups
                            StreamWriter case3strength1 = new StreamWriter(filepath1, true);
                            using (case3strength1)
                            {
                                case3strength1.WriteLine("Exercise 2: pushups");
                            }
                            break;
                        case 2: // Exercise: pullups
                            StreamWriter case3strength2 = new StreamWriter(filepath1, true);
                            using (case3strength2)
                            {
                                case3strength2.WriteLine("Exercise 2: pullups");
                            }
                            break;
                        case 3: // Exercise: plank
                            StreamWriter case3strength3 = new StreamWriter(filepath1, true);
                            using (case3strength3)
                            {
                                case3strength3.WriteLine("Exercise 2: plank");
                            }
                            break;
                        case 4: // Exercise: bicycle
                            StreamWriter case3strength4 = new StreamWriter(filepath1, true);
                            using (case3strength4)
                            {
                                case3strength4.WriteLine("Exercise 2: bicycle");
                            }
                            break;
                    }

                    // EXERCISE 3
                    switch (strengthRnd_3)
                    {
                        case 1: // Exercise: pushups
                            StreamWriter case3strength1 = new StreamWriter(filepath1, true);
                            using (case3strength1)
                            {
                                case3strength1.WriteLine("Exercise 3: pushups");
                            }
                            break;
                        case 2: // Exercise: pullups
                            StreamWriter case3strength2 = new StreamWriter(filepath1, true);
                            using (case3strength2)
                            {
                                case3strength2.WriteLine("Exercise 3: pullups");
                            }
                            break;
                        case 3: // Exercise: plank
                            StreamWriter case3strength3 = new StreamWriter(filepath1, true);
                            using (case3strength3)
                            {
                                case3strength3.WriteLine("Exercise 3: plank");
                            }
                            break;
                        case 4: // Exercise: bicycle
                            StreamWriter case3strength4 = new StreamWriter(filepath1, true);
                            using (case3strength4)
                            {
                                case3strength4.WriteLine("Exercise 3: bicycle");
                            }
                            break;
                    }

                    // EXERCISE 4
                    switch (cardioRnd_1)
                    {
                        case 1: // Exercise: step-ups
                            StreamWriter case3cardio1 = new StreamWriter(filepath1, true);
                            using (case3cardio1)
                            {
                                case3cardio1.WriteLine("Exercise 4: step-ups");
                            }
                            break;
                        case 2: // Exercise: squat-jumps
                            StreamWriter case3cardio2 = new StreamWriter(filepath1, true);
                            using (case3cardio2)
                            {
                                case3cardio2.WriteLine("Exercise 4: squat-jumps");
                            }
                            break;
                        case 3: // Exercise: burpees
                            StreamWriter case3cardio3 = new StreamWriter(filepath1, true);
                            using (case3cardio3)
                            {
                                case3cardio3.WriteLine("Exercise 4: burpees");
                            }
                            break;
                        case 4: // Exercise: standing side hops
                            StreamWriter case3cardio4 = new StreamWriter(filepath1, true);
                            using (case3cardio4)
                            {
                                case3cardio4.WriteLine("Exercise 4: side-hops");
                            }
                            break;
                    }

                    // EXERCISE 5
                    switch (muscleRnd_1)
                    {
                        case 1: // Exercise: squat pulses
                            StreamWriter case3muscle1 = new StreamWriter(filepath1, true);
                            using (case3muscle1)
                            {
                                case3muscle1.WriteLine("Exercise 5: squat-pulses");
                            }
                            break;
                        case 2: // Exercise: flutter kicks
                            StreamWriter case3muscle2 = new StreamWriter(filepath1, true);
                            using (case3muscle2)
                            {
                                case3muscle2.WriteLine("Exercise 5: flutter-kicks");
                            }
                            break;
                        case 3: // Exercise: v-sits
                            StreamWriter case3muscle3 = new StreamWriter(filepath1, true);
                            using (case3muscle3)
                            {
                                case3muscle3.WriteLine("Exercise 5: v-sits");
                            }
                            break;
                        case 4: // Exercise: kickbacks
                            StreamWriter case3muscle4 = new StreamWriter(filepath1, true);
                            using (case3muscle4)
                            {
                                case3muscle4.WriteLine("Exercise 5: kickbacks");
                            }
                            break;
                        case 5: // Exercise: mountain climbers
                            StreamWriter case3muscle5 = new StreamWriter(filepath1, true);
                            using (case3muscle5)
                            {
                                case3muscle5.WriteLine("Exercise 5: climbers");
                            }
                            break;
                        case 6: // Exercise: wallsits
                            StreamWriter case3muscle6 = new StreamWriter(filepath1, true);
                            using (case3muscle6)
                            {
                                case3muscle6.WriteLine("Exercise 5: wallsit");
                            }
                            break;
                        case 7: // Exercise: sit-ups
                            StreamWriter case3muscle7 = new StreamWriter(filepath1, true);
                            using (case3muscle7)
                            {
                                case3muscle7.WriteLine("Exercise 5: sit-ups");
                            }
                            break;
                    }
                    break;
            }
        }
    }
}
