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
            // hide Main_Screen
            this.Hide();
            // create an instance of Main_Screen
            Main_Screen MainScreen = new Main_Screen();
            // show Main_Screen
            MainScreen.ShowDialog(); // will halt/freeze the execution of the click event.
            // dispose of Main_Screen instance
            MainScreen = null;
            // show Main_screen again
            this.Show();
        }
    }
}
