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
    public partial class Details_Form : Form
    {
        List<double> filteredSignal;
        List<double> signal;
        Load_Signal test_form;
        public Details_Form(Load_Signal f)
        {
            InitializeComponent();
            filteredSignal = new List<double>();
            signal = new List<double>();
            fill_form();
            test_form = f;
        }

        private void Details_Form_Load(object sender, EventArgs e)
        {
            //fill_form();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            string message = "   Do you want to close this window?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void fill_form()
        {
            int signalLength = 6000;//filteredSignal.Count;
            filteredSignal = Helper.LoadSignal("Filtered_Signal.txt", 0);
            signal = Helper.LoadSignal("Signal.txt", 0);
            Helper.DrawSignal(filteredSignalChart, filteredSignal, signalLength);
            // R Peaks chart
            Helper.DrawSignal(RPeaksChart, filteredSignal, signalLength);
            Helper.DrawAnnotations(RPeaksChart, signalLength, false);
            // draw beats
            Helper.DrawBeats(beatsflowpanel, 10, 0);

            Helper.DrawSignal(classificationChart, filteredSignal, signalLength);
            Helper.DrawAnnotations(classificationChart, signalLength, true);


        }

        private void classifybtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            test_form.Show();
        }
    }
}
