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
        public Create_Account_Log_In()
        {
            InitializeComponent();
        }

        private void createaccountBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = @"C:\Users\David Correia\source\repos\Fitness4u-Project-1\data\" + "\\users\\" + createaccountUsernameTxt.Text + ".txt";
                StreamWriter createaccount = new StreamWriter(filePath);

                using (createaccount)
                {
                    createaccount.WriteLine("Username: " + createaccountUsernameTxt.Text);
                    createaccount.WriteLine("Password: " + createaccountPasswordTxt.Text);
                }

                MessageBox.Show("Account created successfully!","Operation successful!");

            }
            catch (Exception)
            {
                MessageBox.Show("An error has occured! - This may be due to either the filepath in program.cs being incorrect or" +
                    " because an account with this username and password already exists.", "Error!");
            }
        }
    }
}
