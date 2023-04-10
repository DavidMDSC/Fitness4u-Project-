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


namespace Fitness4u__Project_
{
    public partial class Create_Account_Log_In : Form
    {
        // stores the users username
        public static string username;
        // boolean value used to represent if the user
        // has accessed the fitness_suggestion_page Form before
        public static bool firsttime;

        public Create_Account_Log_In()
        {
            InitializeComponent();
        }

        private void createaccountBtn_Click(object sender, EventArgs e) // click event to create an account
        {
            try
            {
                // the location of where the .txt file will be written to - the file name will be called the users Username.
                string filePath = @"C:\Users\David Correia\source\repos\Fitness4u-Project-1\data\" + "\\users\\" + createaccountUsernameTxt.Text + ".txt";
                StreamWriter createaccount = new StreamWriter(filePath);

                using (createaccount)
                {
                    createaccount.WriteLine("Username: " + createaccountUsernameTxt.Text); // will save the Username on a new line
                    createaccount.WriteLine("Password: " + createaccountPasswordTxt.Text); // will save the Password on a new line
                    createaccount.WriteLine("firsttime: true"); // true as user is yet to access fitness_suggestion_page
                }

                createaccount.Close();

                MessageBox.Show("Account created successfully!", "Operation successful!"); // Pop-up box will show up with this message if the operation is successful

                // true as user is yet to access fitness_suggestion_page
                firsttime = true;

            }
            catch (Exception)
            {
                // Pop-up box will show up displaying the message below if the account was not created - most likely due to the one reasons stated below
                MessageBox.Show("An error has occured! - This may be due to either the filepath in program.cs being incorrect or" +
                    " because an account with this username and password already exists.", "Error!");
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string filepath = @"C:\Users\David Correia\source\repos\Fitness4u-Project-1\data\" + "\\users\\" + loginUsernameTxt.Text + ".txt";
            // Stores username
            try
            {
                username = loginUsernameTxt.Text;
                int linenumber = 2;
                string line = File.ReadLines(filepath).Skip(linenumber - 1).FirstOrDefault();
                MessageBox.Show(line); // test
                MessageBox.Show("Password: " + loginPasswordTxt.Text); // test 2
                // if both message boxes show the same thing, we can insure the password is correct
                if (line == "Password: " + loginPasswordTxt.Text)
                {

                    // Displays this message if the user has typed in the correct username and password!
                    MessageBox.Show("Login successful!", "Operation successful!");

                    //ACTUAL LOG IN OCCURS HERE

                    // hide Create_Account_Log_In Form
                    this.Hide();
                    // create an instance of Main_Screen
                    Main_Screen MainScreen = new Main_Screen();
                    // show Main_Screen
                    MainScreen.ShowDialog(); // will halt/freeze the execution of the click event.
                    // dispose of Create_Account_Log_In instance
                    MainScreen = null;
                    this.Dispose();

                    // ACTUAL LOGIN ENDS HERE
                }
                else
                {
                    // Displays this message if the password is incorrect
                    MessageBox.Show("Incorrect password!", "Error!");
                }
            }


            //StreamReader login = new StreamReader(filepath);
            //using (login)
            //{
            //string line = login.ReadLine(); // used to set the while loop
            //while (line != null) // will loop until it has a password string
            //{
            //    string[] lineArr = new string[0]; // the lines in the .txt will act as an array
            //    lineArr = line.Split(' '); // will only read the text after the space
            //    if (lineArr[1] == loginPasswordTxt.Text) // is comparing the stored password to the password the user has entered
            //    {
            //        // Displays this message if the user has typed in the correct username and password!
            //        MessageBox.Show("Login successful!", "Operation successful!");
            //        
            //        //ACTUAL LOG IN OCCURS HERE
            //
            //        // hide Create_Account_Log_In Form
            //        this.Hide();
            //        // create an instance of Main_Screen
            //        Main_Screen MainScreen = new Main_Screen();
            //        // show Main_Screen
            //        MainScreen.ShowDialog(); // will halt/freeze the execution of the click event.
            //        // dispose of Create_Account_Log_In instance
            //        MainScreen = null;
            //        this.Dispose();
            //
            //        // ACTUAL LOGIN ENDS HERE
            //    }
            //    else
            //    {
            //        // Displays this message if the password is incorrect
            //        MessageBox.Show("Incorrect password!", "Error!");
            //    }
            //    line = login.ReadLine();
            //}
            //}
            //login.Close();
            //}
            catch (Exception)
            {
                // Displays this message if the username is incorrect
                MessageBox.Show("Incorrect username", "Error!");
            }
        }
    }
}