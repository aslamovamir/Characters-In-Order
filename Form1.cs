using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Submit_BTN_Click(object sender, EventArgs e)
        {
            //let's get the user input into a local variable
            string user_input = Input_TB.Text;
            bool in_order = true;

            //let's loop through the string and see if any two neighboring chars are in order
            for (int i = 1; i < user_input.Length; i++)
            {
                //first check if the char is a letter
                //if not a letter, the output is not in order by default
                if (!Char.IsLetter(user_input[i]) || !Char.IsLetter(user_input[i-1]))
                {
                    MessageBox.Show("Detected a char that is not a letter!");
                    in_order = false;
                    Output_TB.Text = "";
                    break;
                }
                
                if ((int)Char.ToLower(user_input[i-1]) > (int)Char.ToLower(user_input[i]))
                {
                    in_order = false;
                    break;
                }
            }
        
            if (in_order)
            {
                Output_TB.Text = "In order";
            } else
            {
                Output_TB.Text = "Not in order";
            }
        }
    }
}
