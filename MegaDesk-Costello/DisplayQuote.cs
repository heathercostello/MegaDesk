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
    public partial class DisplayQuote : Form
    {
        public DisplayQuote()
        {
            InitializeComponent();
            //label1.Text = value;

        }

        public void setNameLabelDisplayText(String value)
        {
            NameLabelDisplay.Text = value;
        }

        public void setWidthLabelDisplayText(String value)
        {
            WidthLabelDisplay.Text = value;
        }

        public void setDepthLabelDisplayText(String value)
        {
            DepthLabelDisplay.Text = value;
        }

        public void setDrawerLabelDisplayText(String value)
        {
            DrawerLabelDisplay.Text = value;
        }

        public void setMaterialLabelDisplayText(String value)
        {
            MaterialLabelDisplay.Text = value;
        }

        public void setOrderTypeLabelDisplayText(String value)
        {
            OrderTypeLabelDisplay.Text = value;
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
