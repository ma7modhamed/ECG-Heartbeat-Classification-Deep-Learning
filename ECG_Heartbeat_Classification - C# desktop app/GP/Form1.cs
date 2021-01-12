using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bunifuFlatButton2.IconZoom = 100;
            ResultsButtons.IconZoom = 100;
            //ExitButton.IconZoom = 320;
            bunifuFlatButton6.IconZoom = 90;
            MinimizeButton.IconZoom = 50;
 

        }

        private void ExitButton(object sender, EventArgs e)
        {
           
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close this window?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                // Do something  
            }
        }

        private void SubjectCheckbox_OnChange(object sender, EventArgs e)
        {
            if (ClassCheckbox.Checked)
            {
                ClassCheckbox.Checked = false;
            }
        }

        private void ObjectCheckbox_OnChange(object sender, EventArgs e)
        {
            if (SubjectCheckbox.Checked)
            {
                SubjectCheckbox.Checked = false;
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            OurResult ResultsForm = new OurResult();
            ResultsForm.Show();
            this.Hide();
            
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            int class_subject = -1;
            if (ClassCheckbox.Checked)
                class_subject = 0;
            else if (SubjectCheckbox.Checked)
                class_subject = 1;
            else
            {
                MessageBox.Show("Select Class Oriented or Subject Oriented First !");
                return;
            }
            Load_Signal LoadForm = new Load_Signal(class_subject);
            LoadForm.Show();
            this.Hide();
            
        }
    }
}
