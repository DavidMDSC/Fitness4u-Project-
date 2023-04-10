using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Fitness4u__Project_
{
    public partial class Fitness_Suggestion_Page : Form
    {
        public static string username;
        public static int exerciseDifficulty;
        public Fitness_Suggestion_Page()
        {
            InitializeComponent();
            username = Create_Account_Log_In.username;
            exerciseDifficulty = First_steps_questionaire.exerciseDifficulty;
        }

        /////////////////////////////
        // All potential exercises //
        /////////////////////////////
        public const string exercise1 = "Exercise 1: ";
        public const string exercise2 = "Exercise 2: ";
        public const string exercise3 = "Exercise 3: ";
        public const string exercise4 = "Exercise 4: ";
        public const string exercise5 = "Exercise 5: ";

        public static int exerciseNum;

        // all values range from 1-10

        // Exercise: pushups - Strength focus
        public static int pushupCardio = 2;
        public static int pushupMuscle = 6;
        public static int pushupStrength = 7;
        public const string exercise1_pushups = exercise1 + "pushups";
        public const string exercise2_pushups = exercise2 + "pushups";
        public const string exercise3_pushups = exercise3 + "pushups";
        public const string exercise4_pushups = exercise4 + "pushups";
        public const string exercise5_pushups = exercise5 + "pushups";

        // Exercise: step-ups - Cardio focus
        public static int stepupCardio = 5;
        public static int stepupMuscle = 2;
        public static int stepupStrength = 1;
        public const string exercise1_stepups = exercise1 + "step-ups";
        public const string exercise2_stepups = exercise2 + "step-ups";
        public const string exercise3_stepups = exercise3 + "step-ups";
        public const string exercise4_stepups = exercise4 + "step-ups";
        public const string exercise5_stepups = exercise5 + "step-ups";

        // Exercise: squat jumps - Cardio focus
        public static int squatjumpCardio = 6;
        public static int squatjumpMuscle = 3;
        public static int squatjumpStrength = 3;
        public const string exercise1_squatjumps = exercise1 + "squat-jumps";
        public const string exercise2_squatjumps = exercise2 + "squat-jumps";
        public const string exercise3_squatjumps = exercise3 + "squat-jumps";
        public const string exercise4_squatjumps = exercise4 + "squat-jumps";
        public const string exercise5_squatjumps = exercise5 + "squat-jumps";

        // Exercise: burpees - Cardio focus
        public static int burpeeCardio = 8;
        public static int burpeeMuscle = 5;
        public static int burpeeStrength = 3;
        public const string exercise1_burpees = exercise1 + "burpees";
        public const string exercise2_burpees = exercise2 + "burpees";
        public const string exercise3_burpees = exercise3 + "burpees";
        public const string exercise4_burpees = exercise4 + "burpees";
        public const string exercise5_burpees = exercise5 + "burpees";

        // Exercise: standing side hops - Cardio focus
        public static int sidehopCardio = 7;
        public static int sidehopMuscle = 2;
        public static int sidehopStength = 2;
        public const string exercise1_sidehops = exercise1 + "side-hops";
        public const string exercise2_sidehops = exercise2 + "side-hops";
        public const string exercise3_sidehops = exercise3 + "side-hops";
        public const string exercise4_sidehops = exercise4 + "side-hops";
        public const string exercise5_sidehops = exercise5 + "side-hops";

        // Exercise: pullups - Strength focus
        public static int pullupCardio = 2;
        public static int pullupMuscle = 7;
        public static int pullupStrength = 8;
        public const string exercise1_pullups = exercise1 + "pullups";
        public const string exercise2_pullups = exercise2 + "pullups";
        public const string exercise3_pullups = exercise3 + "pullups";
        public const string exercise4_pullups = exercise4 + "pullups";
        public const string exercise5_pullups = exercise5 + "pullups";

        // Exercise: squat pulses - Muscle focus
        public static int squatpulseCardio = 4;
        public static int squatpulseMuscle = 6;
        public static int squatpulseStrength = 5;
        public const string exercise1_squatpulses = exercise1 + "squat-pulses";
        public const string exercise2_squatpulses = exercise2 + "squat-pulses";
        public const string exercise3_squatpulses = exercise3 + "squat-pulses";
        public const string exercise4_squatpulses = exercise4 + "squat-pulses";
        public const string exercise5_squatpulses = exercise5 + "squat-pulses";

        // Exercise: flutter kicks - Muscle focus
        public static int flutterkickCardio = 2;
        public static int flutterkickMuscle = 7;
        public static int flutterkickStrength = 4;
        public const string exercise1_flutterkicks = exercise1 + "flutter-kicks";
        public const string exercise2_flutterkicks = exercise2 + "flutter-kicks";
        public const string exercise3_flutterkicks = exercise3 + "flutter-kicks";
        public const string exercise4_flutterkicks = exercise4 + "flutter-kicks";
        public const string exercise5_flutterkicks = exercise5 + "flutter-kicks";

        // Exercise: v-sits - Muscle focus
        public static int vsitCardio = 3;
        public static int vsitMuscle = 7;
        public static int vsitStrength = 5;
        public const string exercise1_vsits = exercise1 + "v-sits";
        public const string exercise2_vsits = exercise2 + "v-sits";
        public const string exercise3_vsits = exercise3 + "v-sits";
        public const string exercise4_vsits = exercise4 + "v-sits";
        public const string exercise5_vsits = exercise5 + "v-sits";

        // Exercise: kickbacks - Muscle focus
        public static int kickbackCardio = 3;
        public static int kickbackMuscle = 6;
        public static int kickbackStrength = 2;
        public const string exercise1_kickbacks = exercise1 + "kickbacks";
        public const string exercise2_kickbacks = exercise2 + "kickbacks";
        public const string exercise3_kickbacks = exercise3 + "kickbacks";
        public const string exercise4_kickbacks = exercise4 + "kickbacks";
        public const string exercise5_kickbacks = exercise5 + "kickbacks";

        // Exercise: mountain climbers - Muscle focus
        public static int climberCardio = 5;
        public static int climberMuscle = 7;
        public static int climberStrength = 3;
        public const string exercise1_climbers = exercise1 + "climbers";
        public const string exercise2_climbers = exercise2 + "climbers";
        public const string exercise3_climbers = exercise3 + "climbers";
        public const string exercise4_climbers = exercise4 + "climbers";
        public const string exercise5_climbers = exercise5 + "climbers";

        // Exercise: wallsit - Muscle focus
        public static int wallsitCardio = 1;
        public static int wallsitMuscle = 8;
        public static int wallsitStrength = 4;
        public const string exercise1_wallsit = exercise1 + "wallsit";
        public const string exercise2_wallsit = exercise2 + "wallsit";
        public const string exercise3_wallsit = exercise3 + "wallsit";
        public const string exercise4_wallsit = exercise4 + "wallsit";
        public const string exercise5_wallsit = exercise5 + "wallsit";

        // Exercise: sit-up - Muscle focus
        public static int situpCardio = 2;
        public static int situpMuscle = 7;
        public static int situpStrength = 4;
        public const string exercise1_situps = exercise1 + "sit-ups";
        public const string exercise2_situps = exercise2 + "sit-ups";
        public const string exercise3_situps = exercise3 + "sit-ups";
        public const string exercise4_situps = exercise4 + "sit-ups";
        public const string exercise5_situps = exercise5 + "sit-ups";

        // Exercise: plank - Strength focus
        public static int plankCardio = 1;
        public static int plankMuscle = 4;
        public static int plankStrength = 6;
        public const string exercise1_plank = exercise1 + "plank";
        public const string exercise2_plank = exercise2 + "plank";
        public const string exercise3_plank = exercise3 + "plank";
        public const string exercise4_plank = exercise4 + "plank";
        public const string exercise5_plank = exercise5 + "plank";

        // Exercise: bicycle - Strength focus
        public static int bicycleCardio = 4;
        public static int bicycleMuscle = 6;
        public static int bicycleStrength = 4;
        public const string exercise1_bicycle = exercise1 + "bicycle";
        public const string exercise2_bicycle = exercise2 + "bicycle";
        public const string exercise3_bicycle = exercise3 + "bicycle";
        public const string exercise4_bicycle = exercise4 + "bicycle";
        public const string exercise5_bicycle = exercise5 + "bicycle";


        private void Fitness_Suggestion_Page_Load(object sender, EventArgs e)
        {
            ///////////////////////////
            // FIRST STEPS EXERCISES //
            ///////////////////////////
            string filepath = @"C:\Users\David Correia\source\repos\Fitness4u-Project-1\data\" + "\\users\\" + username + ".txt";
            
            int exercise1_linenumber = 14; // line 14 is where exercise 1 is shown
            string exercise1_line = File.ReadLines(filepath).Skip(exercise1_linenumber - 1).FirstOrDefault(); // reads line 14 of .txt

            int exercise2_linenumber = 15; // line 15 is where exercise 2 is shown
            string exercise2_line = File.ReadLines(filepath).Skip(exercise2_linenumber - 1).FirstOrDefault(); // reads line 15 of .txt

            int exercise3_linenumber = 16; // line 16 is where exercise 3 is shown
            string exercise3_line = File.ReadLines(filepath).Skip(exercise3_linenumber - 1).FirstOrDefault(); // reads line 16 of .txt

            int exercise4_linenumber = 17; // line 17 is where exercise 4 is shown
            string exercise4_line = File.ReadLines(filepath).Skip(exercise4_linenumber - 1).FirstOrDefault(); // reads line 17 of .txt

            int exercise5_linenumber = 18; // line 18 is where exercise 5 is shown
            string exercise5_line = File.ReadLines(filepath).Skip(exercise5_linenumber - 1).FirstOrDefault(); // reads line 18 of .txt

            // EXERCISE 1 //
            switch (exercise1_line)
            {
                case exercise1_pushups:
                    exercise1LblVar.Text = "pushups"; // Displays "pushups"
                    // Displays the icon of pushups being done
                    exercise1imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_pushups.png");
                    int setortime = setsrepstime(exercise1_line, exerciseDifficulty);
                    exercise1setsLblVar.Text = setortime + " pushups";
                    break;
                case exercise1_stepups:
                    exercise1LblVar.Text = "step-ups"; // Displays "step-ups"
                    // Displays the icon of step-ups being done
                    exercise1imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_stepup.jpg");
                    break;
                case exercise1_squatjumps:
                    exercise1LblVar.Text = "squat-jumps"; // Displays "squat-jumps"
                    // Displays the icon of step-ups being done
                    exercise1imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_squatall.jpg");
                    break;
                case exercise1_burpees:
                    exercise1LblVar.Text = "burpees"; // Displays "burpees"
                    // Displays the icon of step-ups being done
                    exercise1imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_burpee.jpg");
                    break;
                case exercise1_sidehops:
                    exercise1LblVar.Text = "side-hops"; // Displays "side-hops"
                    // Displays the icon of step-ups being done
                    exercise1imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_sidehops.jpg");
                    break;
                case exercise1_pullups:
                    exercise1LblVar.Text = "pullups"; // Displays "pullups"
                    // Displays the icon of step-ups being done
                    exercise1imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_pullup.png");
                    break;
                case exercise1_squatpulses:
                    exercise1LblVar.Text = "squat-pulses"; // Displays "squat-pulses"
                    // Displays the icon of step-ups being done
                    exercise1imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_squatall.jpg");
                    break;
                case exercise1_flutterkicks:
                    exercise1LblVar.Text = "flutter-kicks"; // Displays "flutter-kicks"
                    // Displays the icon of step-ups being done
                    exercise1imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_flutterkick.png");
                    break;
                case exercise1_vsits:
                    exercise1LblVar.Text = "v-sits"; // Displays "v-sits"
                    // Displays the icon of step-ups being done
                    exercise1imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_vsit.jpg");
                    break;
                case exercise1_kickbacks:
                    exercise1LblVar.Text = "kickbacks"; // Displays "kickbacks"
                    // Displays the icon of step-ups being done
                    exercise1imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_kickbacks.jpg");
                    break;
                case exercise1_climbers:
                    exercise1LblVar.Text = "climbers"; // Displays "climbers"
                    // Displays the icon of step-ups being done
                    exercise1imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_climbers.png");
                    break;
                case exercise1_wallsit:
                    exercise1LblVar.Text = "wallsit"; // Displays "wallsit"
                    // Displays the icon of step-ups being done
                    exercise1imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_wallsit.png");
                    break;
                case exercise1_situps:
                    exercise1LblVar.Text = "situps"; // Displays "situps"
                    // Displays the icon of step-ups being done
                    exercise1imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_situps.jpg");
                    break;
                case exercise1_plank:
                    exercise1LblVar.Text = "plank"; // Displays "plank"
                    // Displays the icon of step-ups being done
                    exercise1imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_plank.png");
                    break;
                case exercise1_bicycle:
                    exercise1LblVar.Text = "bicycle"; // Displays "bicycle"
                    // Displays the icon of step-ups being done
                    exercise1imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_bicycle.jpg");
                    break;
            }

            // EXERCISE 2 //
            switch (exercise2_line)
            {
                case exercise2_pushups:
                    exercise2LblVar.Text = "pushups"; // Displays "pushups"
                    // Displays the icon of pushups being done
                    exercise2imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_pushups.png");
                    break;
                case exercise2_stepups:
                    exercise2LblVar.Text = "step-ups"; // Displays "step-ups"
                    // Displays the icon of step-ups being done
                    exercise2imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_stepup.jpg");
                    break;
                case exercise2_squatjumps:
                    exercise2LblVar.Text = "squat-jumps"; // Displays "squat-jumps"
                    // Displays the icon of step-ups being done
                    exercise2imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_squatall.jpg");
                    break;
                case exercise2_burpees:
                    exercise2LblVar.Text = "burpees"; // Displays "burpees"
                    // Displays the icon of step-ups being done
                    exercise2imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_burpee.jpg");
                    break;
                case exercise2_sidehops:
                    exercise2LblVar.Text = "side-hops"; // Displays "side-hops"
                    // Displays the icon of step-ups being done
                    exercise2imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_sidehops.jpg");
                    break;
                case exercise2_pullups:
                    exercise2LblVar.Text = "pullups"; // Displays "pullups"
                    // Displays the icon of step-ups being done
                    exercise2imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_pullup.png");
                    break;
                case exercise2_squatpulses:
                    exercise2LblVar.Text = "squat-pulses"; // Displays "squat-pulses"
                    // Displays the icon of step-ups being done
                    exercise2imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_squatall.jpg");
                    break;
                case exercise2_flutterkicks:
                    exercise2LblVar.Text = "flutter-kicks"; // Displays "flutter-kicks"
                    // Displays the icon of step-ups being done
                    exercise2imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_flutterkick.png");
                    break;
                case exercise2_vsits:
                    exercise2LblVar.Text = "v-sits"; // Displays "v-sits"
                    // Displays the icon of step-ups being done
                    exercise2imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_vsit.jpg");
                    break;
                case exercise2_kickbacks:
                    exercise2LblVar.Text = "kickbacks"; // Displays "kickbacks"
                    // Displays the icon of step-ups being done
                    exercise2imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_kickbacks.jpg");
                    break;
                case exercise2_climbers:
                    exercise2LblVar.Text = "climbers"; // Displays "climbers"
                    // Displays the icon of step-ups being done
                    exercise2imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_climbers.png");
                    break;
                case exercise2_wallsit:
                    exercise2LblVar.Text = "wallsit"; // Displays "wallsit"
                    // Displays the icon of step-ups being done
                    exercise2imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_wallsit.png");
                    break;
                case exercise2_situps:
                    exercise2LblVar.Text = "situps"; // Displays "situps"
                    // Displays the icon of step-ups being done
                    exercise2imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_situps.jpg");
                    break;
                case exercise2_plank:
                    exercise2LblVar.Text = "plank"; // Displays "plank"
                    // Displays the icon of step-ups being done
                    exercise2imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_plank.png");
                    break;
                case exercise2_bicycle:
                    exercise2LblVar.Text = "bicycle"; // Displays "bicycle"
                    // Displays the icon of step-ups being done
                    exercise2imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_bicycle.jpg");
                    break;
            }

            // EXERCISE 3 //
            switch (exercise3_line)
            {
                case exercise3_pushups:
                    exercise3LblVar.Text = "pushups"; // Displays "pushups"
                    // Displays the icon of pushups being done
                    exercise3imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_pushups.png");
                    break;
                case exercise3_stepups:
                    exercise3LblVar.Text = "step-ups"; // Displays "step-ups"
                    // Displays the icon of step-ups being done
                    exercise3imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_stepup.jpg");
                    break;
                case exercise3_squatjumps:
                    exercise3LblVar.Text = "squat-jumps"; // Displays "squat-jumps"
                    // Displays the icon of step-ups being done
                    exercise3imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_squatall.jpg");
                    break;
                case exercise3_burpees:
                    exercise3LblVar.Text = "burpees"; // Displays "burpees"
                    // Displays the icon of step-ups being done
                    exercise3imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_burpee.jpg");
                    break;
                case exercise3_sidehops:
                    exercise3LblVar.Text = "side-hops"; // Displays "side-hops"
                    // Displays the icon of step-ups being done
                    exercise3imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_sidehops.jpg");
                    break;
                case exercise3_pullups:
                    exercise3LblVar.Text = "pullups"; // Displays "pullups"
                    // Displays the icon of step-ups being done
                    exercise3imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_pullup.png");
                    break;
                case exercise3_squatpulses:
                    exercise3LblVar.Text = "squat-pulses"; // Displays "squat-pulses"
                    // Displays the icon of step-ups being done
                    exercise3imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_squatall.jpg");
                    break;
                case exercise3_flutterkicks:
                    exercise3LblVar.Text = "flutter-kicks"; // Displays "flutter-kicks"
                    // Displays the icon of step-ups being done
                    exercise3imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_flutterkick.png");
                    break;
                case exercise3_vsits:
                    exercise3LblVar.Text = "v-sits"; // Displays "v-sits"
                    // Displays the icon of step-ups being done
                    exercise3imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_vsit.jpg");
                    break;
                case exercise3_kickbacks:
                    exercise3LblVar.Text = "kickbacks"; // Displays "kickbacks"
                    // Displays the icon of step-ups being done
                    exercise3imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_kickbacks.jpg");
                    break;
                case exercise3_climbers:
                    exercise3LblVar.Text = "climbers"; // Displays "climbers"
                    // Displays the icon of step-ups being done
                    exercise3imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_climbers.png");
                    break;
                case exercise3_wallsit:
                    exercise3LblVar.Text = "wallsit"; // Displays "wallsit"
                    // Displays the icon of step-ups being done
                    exercise3imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_wallsit.png");
                    break;
                case exercise3_situps:
                    exercise3LblVar.Text = "situps"; // Displays "situps"
                    // Displays the icon of step-ups being done
                    exercise3imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_situps.jpg");
                    break;
                case exercise3_plank:
                    exercise3LblVar.Text = "plank"; // Displays "plank"
                    // Displays the icon of step-ups being done
                    exercise3imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_plank.png");
                    break;
                case exercise3_bicycle:
                    exercise3LblVar.Text = "bicycle"; // Displays "bicycle"
                    // Displays the icon of step-ups being done
                    exercise3imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_bicycle.jpg");
                    break;
            }

            // EXERCISE 4 //
            switch (exercise4_line)
            {
                case exercise4_pushups:
                    exercise4LblVar.Text = "pushups"; // Displays "pushups"
                    // Displays the icon of pushups being done
                    exercise4imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_pushups.png");
                    break;
                case exercise4_stepups:
                    exercise4LblVar.Text = "step-ups"; // Displays "step-ups"
                    // Displays the icon of step-ups being done
                    exercise4imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_stepup.jpg");
                    break;
                case exercise4_squatjumps:
                    exercise4LblVar.Text = "squat-jumps"; // Displays "squat-jumps"
                    // Displays the icon of step-ups being done
                    exercise4imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_squatall.jpg");
                    break;
                case exercise4_burpees:
                    exercise4LblVar.Text = "burpees"; // Displays "burpees"
                    // Displays the icon of step-ups being done
                    exercise4imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_burpee.jpg");
                    break;
                case exercise4_sidehops:
                    exercise4LblVar.Text = "side-hops"; // Displays "side-hops"
                    // Displays the icon of step-ups being done
                    exercise4imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_sidehops.jpg");
                    break;
                case exercise4_pullups:
                    exercise4LblVar.Text = "pullups"; // Displays "pullups"
                    // Displays the icon of step-ups being done
                    exercise4imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_pullup.png");
                    break;
                case exercise4_squatpulses:
                    exercise4LblVar.Text = "squat-pulses"; // Displays "squat-pulses"
                    // Displays the icon of step-ups being done
                    exercise4imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_squatall.jpg");
                    break;
                case exercise4_flutterkicks:
                    exercise4LblVar.Text = "flutter-kicks"; // Displays "flutter-kicks"
                    // Displays the icon of step-ups being done
                    exercise4imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_flutterkick.png");
                    break;
                case exercise4_vsits:
                    exercise4LblVar.Text = "v-sits"; // Displays "v-sits"
                    // Displays the icon of step-ups being done
                    exercise4imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_vsit.jpg");
                    break;
                case exercise4_kickbacks:
                    exercise4LblVar.Text = "kickbacks"; // Displays "kickbacks"
                    // Displays the icon of step-ups being done
                    exercise4imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_kickbacks.jpg");
                    break;
                case exercise4_climbers:
                    exercise4LblVar.Text = "climbers"; // Displays "climbers"
                    // Displays the icon of step-ups being done
                    exercise4imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_climbers.png");
                    break;
                case exercise4_wallsit:
                    exercise4LblVar.Text = "wallsit"; // Displays "wallsit"
                    // Displays the icon of step-ups being done
                    exercise4imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_wallsit.png");
                    break;
                case exercise4_situps:
                    exercise4LblVar.Text = "situps"; // Displays "situps"
                    // Displays the icon of step-ups being done
                    exercise4imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_situps.jpg");
                    break;
                case exercise4_plank:
                    exercise4LblVar.Text = "plank"; // Displays "plank"
                    // Displays the icon of step-ups being done
                    exercise4imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_plank.png");
                    break;
                case exercise4_bicycle:
                    exercise4LblVar.Text = "bicycle"; // Displays "bicycle"
                    // Displays the icon of step-ups being done
                    exercise4imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_bicycle.jpg");
                    break;
            }

            // EXERCISE 5 //
            switch (exercise5_line)
            {
                case exercise5_pushups:
                    exercise5LblVar.Text = "pushups"; // Displays "pushups"
                    // Displays the icon of pushups being done
                    exercise5imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_pushups.png");
                    break;
                case exercise5_stepups:
                    exercise5LblVar.Text = "step-ups"; // Displays "step-ups"
                    // Displays the icon of step-ups being done
                    exercise5imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_stepup.jpg");
                    break;
                case exercise5_squatjumps:
                    exercise5LblVar.Text = "squat-jumps"; // Displays "squat-jumps"
                    // Displays the icon of step-ups being done
                    exercise5imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_squatall.jpg");
                    break;
                case exercise5_burpees:
                    exercise5LblVar.Text = "burpees"; // Displays "burpees"
                    // Displays the icon of step-ups being done
                    exercise5imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_burpee.jpg");
                    break;
                case exercise5_sidehops:
                    exercise5LblVar.Text = "side-hops"; // Displays "side-hops"
                    // Displays the icon of step-ups being done
                    exercise5imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_sidehops.jpg");
                    break;
                case exercise5_pullups:
                    exercise5LblVar.Text = "pullups"; // Displays "pullups"
                    // Displays the icon of step-ups being done
                    exercise5imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_pullup.png");
                    break;
                case exercise5_squatpulses:
                    exercise5LblVar.Text = "squat-pulses"; // Displays "squat-pulses"
                    // Displays the icon of step-ups being done
                    exercise5imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_squatall.jpg");
                    break;
                case exercise5_flutterkicks:
                    exercise5LblVar.Text = "flutter-kicks"; // Displays "flutter-kicks"
                    // Displays the icon of step-ups being done
                    exercise5imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_flutterkick.png");
                    break;
                case exercise5_vsits:
                    exercise5LblVar.Text = "v-sits"; // Displays "v-sits"
                    // Displays the icon of step-ups being done
                    exercise5imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_vsit.jpg");
                    break;
                case exercise5_kickbacks:
                    exercise5LblVar.Text = "kickbacks"; // Displays "kickbacks"
                    // Displays the icon of step-ups being done
                    exercise5imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_kickbacks.jpg");
                    break;
                case exercise5_climbers:
                    exercise5LblVar.Text = "climbers"; // Displays "climbers"
                    // Displays the icon of step-ups being done
                    exercise5imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_climbers.png");
                    break;
                case exercise5_wallsit:
                    exercise5LblVar.Text = "wallsit"; // Displays "wallsit"
                    // Displays the icon of step-ups being done
                    exercise5imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_wallsit.png");
                    break;
                case exercise5_situps:
                    exercise5LblVar.Text = "situps"; // Displays "situps"
                    // Displays the icon of step-ups being done
                    exercise5imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_situps.jpg");
                    break;
                case exercise5_plank:
                    exercise5LblVar.Text = "plank"; // Displays "plank"
                    // Displays the icon of step-ups being done
                    exercise5imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_plank.png");
                    break;
                case exercise5_bicycle:
                    exercise5LblVar.Text = "bicycle"; // Displays "bicycle"
                    // Displays the icon of step-ups being done
                    exercise5imgPicBoxVar.Image = Image.FromFile(@"C:\Users\David Correia\source\repos\Fitness4u-Project-1\Resources\exercise_bicycle.jpg");
                    break;
            }
        }
        /////////////////////////////////////
        // EXERCISE SETS/REPS/TIME DECIDER //
        /////////////////////////////////////
        static int setsrepstime(string exercise1_line, int exerciseDifficulty)
        {
            int reps;
            int time; // in seconds

            switch (exercise1_line) // all code paths must return a value
            {
                case exercise1_pushups:
                    switch (exerciseDifficulty)
                    {
                        case 4:
                            reps = 30;
                            return reps;
                            break;
                        case 3:
                            reps = 20;
                            return reps;
                            break;
                        case 2:
                            reps = 15;
                            return reps;
                            break;
                        case 1:
                            reps = 10;
                            return reps;
                            break;
                    }
                    break;
                case exercise1_stepups:
                    switch (exerciseDifficulty)
                    {
                        case 4:
                            reps = 80;
                            break;
                        case 3:
                            reps = 60;
                            break;
                        case 2:
                            reps = 40;
                            break;
                        case 1:
                            reps = 20;
                            break;
                    }
                    break;
                case exercise1_squatjumps:
                    switch (exerciseDifficulty)
                    {
                        case 4:
                            reps = 30;
                            break;
                        case 3:
                            reps = 20;
                            break;
                        case 2:
                            reps = 15;
                            break;
                        case 1:
                            reps = 10;
                            break;
                    }
                    break;
                case exercise1_burpees:
                    switch (exerciseDifficulty)
                    {
                        case 4:
                            reps = 20;
                            break;
                        case 3:
                            reps = 15;
                            break;
                        case 2:
                            reps = 10;
                            break;
                        case 1:
                            reps = 7;
                            break;
                    }
                    break;
                case exercise1_sidehops:
                    switch (exerciseDifficulty)
                    {
                        case 4:
                            reps = 40;
                            break;
                        case 3:
                            reps = 30;
                            break;
                        case 2:
                            reps = 25;
                            break;
                        case 1:
                            reps = 15;
                            break;
                    }
                    break;
                case exercise1_pullups:
                    switch (exerciseDifficulty)
                    {
                        case 4:
                            reps = 10;
                            break;
                        case 3:
                            reps = 7;
                            break;
                        case 2:
                            reps = 3;
                            break;
                        case 1:
                            reps = 1;
                            break;
                    }
                    break;
                case exercise1_squatpulses:
                    switch (exerciseDifficulty)
                    {
                        case 4:
                            reps = 25;
                            break;
                        case 3:
                            reps = 20;
                            break;
                        case 2:
                            reps = 15;
                            break;
                        case 1:
                            reps = 10;
                            break;
                    }
                    break;
                case exercise1_flutterkicks:
                    switch (exerciseDifficulty)
                    {
                        case 4:
                            reps = 25;
                            break;
                        case 3:
                            reps = 20;
                            break;
                        case 2:
                            reps = 15;
                            break;
                        case 1:
                            reps = 10;
                            break;
                    }
                    break;
                case exercise1_vsits:
                    switch (exerciseDifficulty)
                    {
                        case 4:
                            reps = 20;
                            break;
                        case 3:
                            reps = 15;
                            break;
                        case 2:
                            reps = 10;
                            break;
                        case 1:
                            reps = 6;
                            break;
                    }
                    break;
                case exercise1_kickbacks:
                    switch (exerciseDifficulty)
                    {
                        case 4:
                            reps = 20;
                            break;
                        case 3:
                            reps = 15;
                            break;
                        case 2:
                            reps = 10;
                            break;
                        case 1:
                            reps = 5;
                            break;
                    }
                    break;
                case exercise1_climbers:
                    switch (exerciseDifficulty)
                    {
                        case 4:
                            reps = 20;
                            break;
                        case 3:
                            reps = 15;
                            break;
                        case 2:
                            reps = 10;
                            break;
                        case 1:
                            reps = 6;
                            break;
                    }
                    break;
                case exercise1_wallsit:
                    switch (exerciseDifficulty)
                    {
                        case 4:
                            time = 300;
                            break;
                        case 3:
                            time = 240;
                            break;
                        case 2:
                            time = 180;
                            break;
                        case 1:
                            time = 120;
                            break;
                    }
                    break;
                case exercise1_situps:
                    switch (exerciseDifficulty)
                    {
                        case 4:
                            reps = 20;
                            break;
                        case 3:
                            reps = 15;
                            break;
                        case 2:
                            reps = 10;
                            break;
                        case 1:
                            reps = 6;
                            break;
                    }
                    break;
                case exercise1_plank:
                    switch (exerciseDifficulty)
                    {
                        case 4:
                            time = 360;
                            break;
                        case 3:
                            time = 240;
                            break;
                        case 2:
                            time = 150;
                            break;
                        case 1:
                            time = 60;
                            break;
                    }
                    break;
                case exercise1_bicycle:
                    switch (exerciseDifficulty)
                    {
                        case 4:
                            time = 300;
                            break;
                        case 3:
                            time = 240;
                            break;
                        case 2:
                            time = 180;
                            break;
                        case 1:
                            time = 120;
                            break;
                    }
                    break;
            }
            return reps;
            
            
            // if exercise is in time, return time. if exercise is in reps, return reps
        }
    }
}