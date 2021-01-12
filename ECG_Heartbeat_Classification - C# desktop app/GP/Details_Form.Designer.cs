namespace GP
{
    partial class Details_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.filteredSignalChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.RPeaksChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.beatsflowpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.classificationChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.MinimizeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ExitButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.backbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filteredSignalChart)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RPeaksChart)).BeginInit();
            this.beatsflowpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classificationChart)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.MinimizeButton);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 25);
            this.panel1.TabIndex = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // filteredSignalChart
            // 
            chartArea9.BorderColor = System.Drawing.Color.WhiteSmoke;
            chartArea9.Name = "ChartArea1";
            this.filteredSignalChart.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.filteredSignalChart.Legends.Add(legend9);
            this.filteredSignalChart.Location = new System.Drawing.Point(3, 47);
            this.filteredSignalChart.Name = "filteredSignalChart";
            this.filteredSignalChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(154)))), ((int)(((byte)(118)))));
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.filteredSignalChart.Series.Add(series9);
            this.filteredSignalChart.Size = new System.Drawing.Size(835, 241);
            this.filteredSignalChart.TabIndex = 43;
            this.filteredSignalChart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "1- Filtered and Normalized Signal";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.filteredSignalChart);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.RPeaksChart);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.beatsflowpanel);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.classificationChart);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 29);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(869, 548);
            this.flowLayoutPanel1.TabIndex = 47;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(3, 294);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(846, 5);
            this.panel2.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 25);
            this.label2.TabIndex = 53;
            this.label2.Text = "2- Detected R Peaks";
            // 
            // RPeaksChart
            // 
            chartArea10.BorderColor = System.Drawing.Color.WhiteSmoke;
            chartArea10.Name = "ChartArea1";
            this.RPeaksChart.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.RPeaksChart.Legends.Add(legend10);
            this.RPeaksChart.Location = new System.Drawing.Point(3, 330);
            this.RPeaksChart.Name = "RPeaksChart";
            this.RPeaksChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(154)))), ((int)(((byte)(118)))));
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.RPeaksChart.Series.Add(series10);
            this.RPeaksChart.Size = new System.Drawing.Size(835, 241);
            this.RPeaksChart.TabIndex = 52;
            this.RPeaksChart.Text = "chart2";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Location = new System.Drawing.Point(3, 577);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(846, 5);
            this.panel3.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 585);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 25);
            this.label3.TabIndex = 58;
            this.label3.Text = "3- Segmented Beats";
            // 
            // beatsflowpanel
            // 
            this.beatsflowpanel.AutoScroll = true;
            this.beatsflowpanel.Controls.Add(this.chart3);
            this.beatsflowpanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.beatsflowpanel.Location = new System.Drawing.Point(3, 613);
            this.beatsflowpanel.Name = "beatsflowpanel";
            this.beatsflowpanel.Size = new System.Drawing.Size(840, 213);
            this.beatsflowpanel.TabIndex = 59;
            // 
            // chart3
            // 
            chartArea12.BorderColor = System.Drawing.Color.WhiteSmoke;
            chartArea12.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.chart3.Legends.Add(legend12);
            this.chart3.Location = new System.Drawing.Point(3, 3);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series12.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(154)))), ((int)(((byte)(118)))));
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            this.chart3.Series.Add(series12);
            this.chart3.Size = new System.Drawing.Size(315, 182);
            this.chart3.TabIndex = 5;
            this.chart3.Text = "chart3";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Maroon;
            this.panel4.Location = new System.Drawing.Point(3, 832);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(846, 5);
            this.panel4.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 840);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 25);
            this.label4.TabIndex = 63;
            this.label4.Text = "4- After Classifying each beat";
            // 
            // classificationChart
            // 
            chartArea11.BorderColor = System.Drawing.Color.WhiteSmoke;
            chartArea11.Name = "ChartArea1";
            this.classificationChart.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.classificationChart.Legends.Add(legend11);
            this.classificationChart.Location = new System.Drawing.Point(3, 868);
            this.classificationChart.Name = "classificationChart";
            this.classificationChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series11.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(154)))), ((int)(((byte)(118)))));
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            this.classificationChart.Series.Add(series11);
            this.classificationChart.Size = new System.Drawing.Size(835, 241);
            this.classificationChart.TabIndex = 62;
            this.classificationChart.Text = "chart4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 21);
            this.label5.TabIndex = 45;
            this.label5.Text = "Classification Steps";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Activecolor = System.Drawing.Color.Transparent;
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizeButton.BorderRadius = 0;
            this.MinimizeButton.ButtonText = "";
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.DisabledColor = System.Drawing.Color.Gray;
            this.MinimizeButton.Iconcolor = System.Drawing.Color.Transparent;
            this.MinimizeButton.Iconimage = global::GP.Properties.Resources.minimize;
            this.MinimizeButton.Iconimage_right = null;
            this.MinimizeButton.Iconimage_right_Selected = null;
            this.MinimizeButton.Iconimage_Selected = null;
            this.MinimizeButton.IconMarginLeft = 0;
            this.MinimizeButton.IconMarginRight = 0;
            this.MinimizeButton.IconRightVisible = true;
            this.MinimizeButton.IconRightZoom = 0D;
            this.MinimizeButton.IconVisible = true;
            this.MinimizeButton.IconZoom = 45D;
            this.MinimizeButton.IsTab = false;
            this.MinimizeButton.Location = new System.Drawing.Point(816, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Normalcolor = System.Drawing.Color.Transparent;
            this.MinimizeButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.MinimizeButton.OnHoverTextColor = System.Drawing.Color.White;
            this.MinimizeButton.selected = false;
            this.MinimizeButton.Size = new System.Drawing.Size(31, 25);
            this.MinimizeButton.TabIndex = 9;
            this.MinimizeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MinimizeButton.Textcolor = System.Drawing.Color.White;
            this.MinimizeButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Activecolor = System.Drawing.Color.Transparent;
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitButton.BorderRadius = 0;
            this.ExitButton.ButtonText = "";
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.DisabledColor = System.Drawing.Color.Gray;
            this.ExitButton.Iconcolor = System.Drawing.Color.Transparent;
            this.ExitButton.Iconimage = global::GP.Properties.Resources.cancel_button;
            this.ExitButton.Iconimage_right = null;
            this.ExitButton.Iconimage_right_Selected = null;
            this.ExitButton.Iconimage_Selected = null;
            this.ExitButton.IconMarginLeft = 0;
            this.ExitButton.IconMarginRight = 0;
            this.ExitButton.IconRightVisible = true;
            this.ExitButton.IconRightZoom = 0D;
            this.ExitButton.IconVisible = true;
            this.ExitButton.IconZoom = 40D;
            this.ExitButton.IsTab = false;
            this.ExitButton.Location = new System.Drawing.Point(843, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Normalcolor = System.Drawing.Color.Transparent;
            this.ExitButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.ExitButton.OnHoverTextColor = System.Drawing.Color.White;
            this.ExitButton.selected = false;
            this.ExitButton.Size = new System.Drawing.Size(24, 25);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Textcolor = System.Drawing.Color.White;
            this.ExitButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // backbtn
            // 
            this.backbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(71)))));
            this.backbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.backbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backbtn.BorderRadius = 7;
            this.backbtn.ButtonText = "Back";
            this.backbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backbtn.DisabledColor = System.Drawing.Color.Gray;
            this.backbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.backbtn.Iconimage = global::GP.Properties.Resources.undo;
            this.backbtn.Iconimage_right = null;
            this.backbtn.Iconimage_right_Selected = null;
            this.backbtn.Iconimage_Selected = null;
            this.backbtn.IconMarginLeft = 0;
            this.backbtn.IconMarginRight = 0;
            this.backbtn.IconRightVisible = true;
            this.backbtn.IconRightZoom = 0D;
            this.backbtn.IconVisible = true;
            this.backbtn.IconZoom = 40D;
            this.backbtn.IsTab = false;
            this.backbtn.Location = new System.Drawing.Point(376, 1);
            this.backbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backbtn.Name = "backbtn";
            this.backbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.backbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.backbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.backbtn.selected = false;
            this.backbtn.Size = new System.Drawing.Size(92, 34);
            this.backbtn.TabIndex = 46;
            this.backbtn.Text = "Back";
            this.backbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.backbtn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(71)))));
            this.backbtn.TextFont = new System.Drawing.Font("Candara", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Click += new System.EventHandler(this.classifybtn_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.backbtn);
            this.panel5.Location = new System.Drawing.Point(372, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(472, 38);
            this.panel5.TabIndex = 46;
            // 
            // Details_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(876, 582);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Details_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Details_Form";
            this.Load += new System.EventHandler(this.Details_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filteredSignalChart)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RPeaksChart)).EndInit();
            this.beatsflowpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classificationChart)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton MinimizeButton;
        private Bunifu.Framework.UI.BunifuFlatButton ExitButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart filteredSignalChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart RPeaksChart;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel beatsflowpanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart classificationChart;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton backbtn;
        private System.Windows.Forms.Panel panel5;
    }
}