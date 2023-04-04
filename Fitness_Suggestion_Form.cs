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
        /////////////////////////////
        // All potential exercises //
        /////////////////////////////

        // all values range from 1-10

        // Exercise: pushups
        int pushupCardio = 2;
        int pushupMuscle = 6;
        int pushupStrength = 7;

        // Exercise: step-ups
        int stepupCardio = 5;
        int stepupMuscle = 2;
        int stepupStrength = 1;

        // Exercise: squat jumps
        int squatjumpCardio = 6;
        int squatjumpMuscle = 3;
        int squatjumpStrength = 3;

        // Exercise: burpees
        int burpeeCardio = 8;
        int burpeeMuscle = 5;
        int burpeeStrength = 3;

        // Exercise: standing side hops
        int sidehopCardio = 7;
        int sidehopMuscle = 2;
        int sidehopStength = 2;

        // Exercise: pullups
        int pullupCardio = 2;
        int pullupMuscle = 7;
        int pullupStrength = 8;

        // Exercise: squat pulses
        int squatpulseCardio = 4;
        int squatpulseMuscle = 6;
        int squatpulseStrength = 5;

        // Exercise: flutter kicks
        int flutterkickCardio = 2;
        int flutterkickMuscle = 7;
        int flutterkickStrength = 4;

        // Exercise: v-sits
        int vsitCardio = 3;
        int vsitMuscle = 7;
        int vsitStrength = 5;

        // Exercise: kickbacks
        int kickbackCardio = 3;
        int kickbackMuscle = 6;
        int kickbackStrength = 2;

        // Exercise: mountain climbers
        int climberCardio = 5;
        int climberMuscle = 7;
        int climberStrength = 3;

        // Exercise: wallsit
        int wallsitCardio = 1;
        int wallsitMuscle = 8;
        int wallsitStrength = 4;

        // Exercise: sit-up
        int situpCardio = 2;
        int situpMuscle = 7;
        int situpStrength = 4;

        // Exercise: plank
        int plankCardio = 1;
        int plankMuscle = 7;
        int plankStrength = 6;

        // Exercise: bicycle
        int bicycleCardio = 4;
        int bicycleMuscle = 6;
        int bicycleStrength = 4;
    }
}