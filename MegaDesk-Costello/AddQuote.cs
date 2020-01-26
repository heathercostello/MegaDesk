using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Costello
{
    public partial class AddQuote : Form
    {
        private string myVal;

        public string MyVal
        {
            get { return myVal; }
            set { myVal = value; }
        }

        public double Depth { get; private set; }

        public double MINWIDTH = 24;
        public double MAXWIDTH = 96;
        public double MINDEPTH = 12;
        public double MAXDEPTH = 48;
        public AddQuote()
        {
            InitializeComponent();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SubmitOrder_Click(object sender, EventArgs e)
        {
            //How to pass objects between two forms
            DisplayQuote form = new DisplayQuote();
            form.setNameLabelDisplayText(NameTextBox.Text);
            form.setWidthLabelDisplayText(WidthTextBox.Text);
            form.setDepthLabelDisplayText(DepthTextBox.Text);
            form.setDrawerLabelDisplayText(DrawerDropDown.Text);
            form.setMaterialLabelDisplayText(MaterialTypeDropDown.Text);
            form.setOrderTypeLabelDisplayText(OrderProcessingDropdown.Text);
            form.Show();
            Close();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            Focus();
        }

        private void WidthTextBox_Validating(object sender, CancelEventArgs e)
        {
            string alph = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            if (WidthTextBox.Text.Contains(alph))
            {
                MessageBox.Show("This Field can only contain numbers");
            }

            if (Width < Desk.MINWIDTH | Width > Desk.MAXWIDTH)
            {
                MessageBox.Show("The Width Minimum is 24 inches and the maximum is 96 inches.");
            }
        }

        private void DepthTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void DepthTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (Depth < Desk.MINDEPTH | Depth > Desk.MAXDEPTH)
            {
                MessageBox.Show("Depth is not correct. It must be at least 12 inches and at most 48 inches.");

            }
        }
        // Boolean flag used to determine when a character other than a number is entered.
        private bool nonNumberEntered = false;

        // Handle the KeyDown event to determine the type of character entered into the control.
        private void DepthTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Initialize the flag to false.
            nonNumberEntered = false;

            // Determine whether the keystroke is a number from the top of the keyboard.
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace.
                    if (e.KeyCode != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed.
                        // Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = true;
                    }
                }
            }
            //If shift key was pressed, it's not a number.
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        // This event occurs after the KeyDown event and can be used to prevent
        // characters from entering the control.
        private void DepthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event.
            if (nonNumberEntered == true)
          {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }



