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
    public partial class Main_Screen : Form
    {
        public Main_Screen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtmNavBarLine_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Journallicon_Click(object sender, EventArgs e)
        {

        }

        private void currentfitptsLblVar_Click(object sender, EventArgs e)
        {

        }

        private void dayLbl_Click(object sender, EventArgs e)
        {

        }

        private void fitsuggLine4Picbox_Click(object sender, EventArgs e)
        {

        }

        private void journalText2Lbl_Click(object sender, EventArgs e)
        {

        }

        private void yourprogresssatLbl_Click(object sender, EventArgs e)
        {

        }

        private void journalIconPicBox_Click(object sender, EventArgs e)
        {

        }

        private void fitsuggText1Lbl_Click(object sender, EventArgs e)
        {

        }

        private void MainScreenForm_fitsugIcon_Click(object sender, EventArgs e)
        {
            Fitness_Suggestion_Page icon2 = new Fitness_Suggestion_Page(); // Creates a new object called "Btn2" 
            icon2.Show(); // Opens icon2 - the variable for the "Fitness_Suggestion_Page"

            Main_Screen currentpage = new Main_Screen(); // Creates a new object called "currentpage"
            currentpage.Hide(); // Closes the current page
        }
    }
}
