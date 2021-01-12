using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Microsoft.Scripting.Hosting;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms.DataVisualization.Charting;
namespace GP
{
    public partial class Load_Signal : Form
    {
        string SignalPathFile = "";
        int counter = 0;
        int signalLength;
        string signalPath = "";
        List<double> signalValues = new List<double>();
        int class_subject = -1;
        public Load_Signal(int class_subject)
        {
            signalLength = 6000;
            counter = 0;
            
            InitializeComponent();

            this.class_subject = class_subject;
            int size = 1500;
            Helper.MakeScrollingChart(chart1, size, -1f, 1f);
            classesChart.ChartAreas[0].AxisY.ScrollBar.Enabled = true;
            // let's zoom to [0,blockSize] (e.g. [0,100])
            classesChart.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            classesChart.ChartAreas[0].AxisX.ScaleView.Zoom(0, 8);
            chart1.Series[0].Color = Color.FromArgb(255, 154, 118);
            timer1.Interval = 1;
            timer1.Tick += Timer1_Tick;

        }

        int SamplePerMS = 100;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (counter >= signalLength)
            {
                timer1.Stop();
                return;
            }

            for (int i = counter; i < counter + SamplePerMS; i++)
            {
                chart1.Series[0].Points.AddY(signalValues[i]);
            }
            counter += SamplePerMS;
            chart1.ChartAreas[0].AxisX.ScaleView.Scroll(ScrollType.Last);
            
        }

        private void Load_Signal_Load(object sender, EventArgs e)
        {
            
        }

        private void Load_Button_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(class_subject.ToString());
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + @"mitdb\";
            open.Filter = "Signal files (*.dat)|*.dat";
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Regex rx = new Regex(@"mitdb\\\d+");
                Match m = rx.Match(open.FileName);
                if (m.Success)
                    SignalPathFile = m.Value;
                else
                    return;
                counter = 0;
                chart1.Series[0].Points.Clear();
                chart1.Annotations.Clear();
                recordNamelbl.Text = "Record: " + SignalPathFile;
                recordNamelbl.Visible = true;
                chart1.Visible = true;
                classesChart.Visible = false;

                using (WaitForm frm = new WaitForm(load_signal_and_draw))
                {
                    frm.ShowDialog(this);
                }
                bunifuFlatButton1.Visible = true;
                classifybtn.Visible = true;
                DetailFormButton.Visible = true;
                signalValues = Helper.LoadSignal("Signal.txt", 0);
                double min = double.MaxValue, max = double.MinValue;
                //min = signalValues.Min();
                //max = signalValues.Max();
                for(int i = 0;i<signalLength;i++)
                {
                    if (signalValues[i] > max)
                        max = signalValues[i];
                    if (signalValues[i] < min)
                        min = signalValues[i];
                }
                float delta = 0.05f;
                min -= delta;
                max += delta;
                chart1.ChartAreas[0].AxisY.Minimum = min;
                chart1.ChartAreas[0].AxisY.Maximum = max;
                
                

                timer1.Start();
                //MessageBox.Show(signalValues.Count.ToString());
            }

            //Draw Signal

        }
        void load_signal_and_draw()
        {
            string python_exe_FileName = AppDomain.CurrentDomain.BaseDirectory + @"dist\Main_Script\Main_Script.exe";
            string pythonInterpreter = @"C:\Users\EngMahmoud\Anaconda3\envs\vision\python.exe";
            string arguments = string.Format("{0} {1} {2}", AppDomain.CurrentDomain.BaseDirectory+@"PythonScripts\Main_Script.py",SignalPathFile,class_subject);
            string python_exe_arguments = string.Format("{0} {1}", SignalPathFile, class_subject);
            Helper.RunPythonScript(python_exe_FileName, python_exe_arguments);
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel3_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void bunifuGradientPanel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuGradientPanel3_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close this window?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
          
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Details_Form DetailForm = new Details_Form(this);
            this.Hide();
            DetailForm.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            counter = 0;
            chart1.Series[0].Points.Clear();

            timer1.Start();

        }

        private void classifybtn_Click(object sender, EventArgs e)
        {
            classesChart.Series[0].Points.Clear();
            /*classesChart.ChartAreas[0].AxisY.ScrollBar.Enabled = true;
            // let's zoom to [0,blockSize] (e.g. [0,100])
            classesChart.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            classesChart.ChartAreas[0].AxisX.ScaleView.Zoom(0, 8);*/
            classesChart.Visible = true;
            label2.Visible = true;
            label5.Visible = true;
            Dictionary<string, int> classes = Helper.GetClassesCount(Helper.LoadClassifications("beats_Classes.txt"));
            int totalBeats = 0;

            Helper.DrawAnnotations(chart1, signalLength);
            foreach (var cls in classes)
            {
                //richTextBox1.AppendText(cls.Key + ": " + cls.Value.ToString() + " beats\n");
                //classificationResultlbl.Text += cls.Key + ": " + cls.Value.ToString() + " beats\n";
                classesChart.Series[0].Points.AddXY(cls.Key, cls.Value);
                totalBeats += cls.Value;

            }
            label5.Text = totalBeats.ToString();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 home = new Form1();
            home.Show();
        }
    }
}
