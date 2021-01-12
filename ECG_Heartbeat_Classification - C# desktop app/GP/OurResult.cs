using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
using Bunifu.Framework.UI;
namespace GP
{
    public partial class OurResult : Form
    {
        public class Excel
        {
            string Path = "";
            _Application Excel_App = new _Excel.Application();
            Worksheet Ws;
            public Workbook Wb;

            public Excel (string path , int Sheet)
            {
                this.Path = path;
                Wb = Excel_App.Workbooks.Open(path);
                Ws = Wb.Worksheets[Sheet];

            }
            public string Read_Cell (int i , int j)
            {
                i++;
                j++;
                if (Ws.Cells[i, j].value2 != null)
                    return Ws.Cells[i, j].value2.ToString();
                else
                    return "Dont Contain Values";
            }
        }
        public void Read_Excel(string Path , int NumberOFTrail , int NumberOfStages = 16)
        {
            Excel excel_File = new Excel(Path, 1);
            string Cell_value = "";
            string Circle_Name = "bunifuCircleProgressbar";
            string Label_Name = "Class_";
            if (NumberOfStages == 16)
            {
                for (int j = 0; j < 18; j++)
                {
                    Cell_value = excel_File.Read_Cell(j, NumberOFTrail);
                    double d = Convert.ToDouble(Cell_value);
                    if (j < 16)
                    {
                        Bunifu.Framework.UI.BunifuCircleProgressbar Circle = (BunifuCircleProgressbar)this.Controls[Circle_Name + j];
                        Circle.Value = Convert.ToInt32(d);
                    }
                    this.Controls[Label_Name + (j + 1)].Text = string.Format("{0:0.00}", d) + "%";
                }
            }
            
            else
            {
                First_Stage_Label.Visible = true;
                Cat1.Visible = true;
                Cat2.Visible = true;
                Cat3.Visible = true;
                Cat4.Visible = true;
                Cat5.Visible = true;
                Cat6.Visible = true;
                Cat7.Visible = true;
                label21.Visible = true;
                label22.Visible = true;
                label23.Visible = true;
                label24.Visible = true;
                label25.Visible = true;
                label26.Visible = true;
                label18.Visible = true;

                for (int j = 0; j < 18; j++)
                {
                    Cell_value = excel_File.Read_Cell(j, (NumberOFTrail*2)+1);
                    double d = Convert.ToDouble(Cell_value);
                    if(j < 16)
                    {
                        Bunifu.Framework.UI.BunifuCircleProgressbar Circle = (BunifuCircleProgressbar)this.Controls[Circle_Name + j];
                        Circle.Value = Convert.ToInt32(d);
                    } 
                    this.Controls[Label_Name + (j + 1)].Text = string.Format("{0:0.00}", d)+ "%";
                }
                string Cat_Label = "Cat";
                for (int k = 0; k<7; k++)
                {
                    Cell_value = excel_File.Read_Cell(k , NumberOFTrail*2);
                    double d = Convert.ToDouble(Cell_value);
                    string l = Cat_Label + (k + 1).ToString();
                    //MessageBox.Show(l);
                    this.Controls[l].Text = string.Format("{0:0.00}", d) + "%";
                }
               
            }
            excel_File.Wb.Close();
            // bunifuCircleProgressbar10.Value =Convert.ToInt32(excel_File.Read_Cell(1, 0));
        }
       //_____________________________________________________________________________________________________-
        public OurResult()
        {
            InitializeComponent();
        }
      
        private void OurResult_Load(object sender, EventArgs e)
        {
            
        }

        private void circleprogressBar1_Load(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           // Read_Excel(@"D:\MY COLLEGE\last year\GP\System\GP\CNN_OneStage.xlsx"); 
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
      
        }
        public void View_FirstStage_Date(String Path)
        {
           
        }
        public void View_TwoStages_Date (String Path)
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
                Environment.Exit(0);    
            }
        }

        private void Inc_Button_Click(object sender, EventArgs e)
        {

        }

        private void Stages_Dropdown_onItemSelected(object sender, EventArgs e)
        {

        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 home = new Form1();
            home.Show();
        }

        private void Class_R_Click(object sender, EventArgs e)
        {

        }

        private void Cat_3_Click(object sender, EventArgs e)
        {

        }

        private void Cat_5_Click(object sender, EventArgs e)
        {

        }

        private void Class_7_Click(object sender, EventArgs e)
        {

        }

        private void Cat5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string directory = AppDomain.CurrentDomain.BaseDirectory;


            if (Stages_Dropdown.selectedIndex == -1 || Model_Dropdown.selectedIndex == -1)
            {
                MessageBox.Show("Incomplete Data !!");
                return;
            }
            if (Model_Dropdown.selectedValue.ToString() == "CNN Model")
            {
             
                   if (Stages_Dropdown.selectedValue.ToString() == "Single Stage")
                {
                    if (Trail_Dropdown.selectedIndex == -1)
                    {
                        MessageBox.Show("Incomplete Data !!");
                        return;
                    }
                    Read_Excel(directory+@"CNN_OneStage.xlsx", Trail_Dropdown.selectedIndex);
                }
                else if (Stages_Dropdown.selectedValue.ToString() == "Two Stages")
                {
                    /*Trail_Dropdown.ResetText();
                    Trail_Dropdown.Enabled = false;*/
                    Read_Excel(directory+@"CNN_TwoStages.xlsx", Trail_Dropdown.selectedIndex, 5);
                }
                else if (Stages_Dropdown.selectedValue.ToString() == "Two Stage Data Augmentation")
                {
                    /*Trail_Dropdown.ResetText();
                    Trail_Dropdown.Enabled = false;*/
                    Read_Excel(directory + @"Augmantation_Data", Trail_Dropdown.selectedIndex, 5);
                }

            }
            else if (Model_Dropdown.selectedValue.ToString() == "Inception Model")
            {
                if (Stages_Dropdown.selectedValue.ToString() == "Single Stage")
                {
                    if (Trail_Dropdown.selectedIndex == -1)
                    {
                        MessageBox.Show("Incomplete Data !!");
                        return;
                    }
                    Read_Excel(directory+@"Inc_OneStage.xlsx", Trail_Dropdown.selectedIndex);
                }
                else if (Stages_Dropdown.selectedValue.ToString() == "Two Stages")
                {
                    /*Trail_Dropdown.ResetText();
                    Trail_Dropdown.Enabled = false;*/
                    Read_Excel(directory+@"Inc_TwoStages.xlsx", Trail_Dropdown.selectedIndex, 5);
                }
            }

            
        }
    }
}
