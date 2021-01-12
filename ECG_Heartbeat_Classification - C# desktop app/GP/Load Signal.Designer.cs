namespace GP
{
    partial class Load_Signal
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Load_Signal));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.recordNamelbl = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.homebtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DetailFormButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.classifybtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Load_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MinimizeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ExitButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.classesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classesChart)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // recordNamelbl
            // 
            this.recordNamelbl.AutoSize = true;
            this.recordNamelbl.BackColor = System.Drawing.Color.Transparent;
            this.recordNamelbl.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordNamelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(154)))), ((int)(((byte)(118)))));
            this.recordNamelbl.Location = new System.Drawing.Point(321, 8);
            this.recordNamelbl.Name = "recordNamelbl";
            this.recordNamelbl.Size = new System.Drawing.Size(101, 25);
            this.recordNamelbl.TabIndex = 7;
            this.recordNamelbl.Text = "Record: ";
            this.recordNamelbl.Visible = false;
            // 
            // chart1
            // 
            chartArea1.BorderColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 36);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Signal";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(835, 241);
            this.chart1.TabIndex = 42;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Redraw";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.ForeColor = System.Drawing.Color.DarkGreen;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(591, 3);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(154)))), ((int)(((byte)(118)))));
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(97, 37);
            this.bunifuFlatButton1.TabIndex = 43;
            this.bunifuFlatButton1.Text = "Redraw";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(154)))), ((int)(((byte)(118)))));
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Visible = false;
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.homebtn);
            this.panel1.Controls.Add(this.DetailFormButton);
            this.panel1.Controls.Add(this.classifybtn);
            this.panel1.Controls.Add(this.Load_Button);
            this.panel1.Controls.Add(this.bunifuFlatButton1);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.recordNamelbl);
            this.panel1.Location = new System.Drawing.Point(3, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 304);
            this.panel1.TabIndex = 44;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // homebtn
            // 
            this.homebtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(71)))));
            this.homebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.homebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.homebtn.BorderRadius = 7;
            this.homebtn.ButtonText = "Home";
            this.homebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homebtn.DisabledColor = System.Drawing.Color.Gray;
            this.homebtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.homebtn.Iconcolor = System.Drawing.Color.Transparent;
            this.homebtn.Iconimage = global::GP.Properties.Resources.home_web_button_outline;
            this.homebtn.Iconimage_right = null;
            this.homebtn.Iconimage_right_Selected = null;
            this.homebtn.Iconimage_Selected = null;
            this.homebtn.IconMarginLeft = 0;
            this.homebtn.IconMarginRight = 0;
            this.homebtn.IconRightVisible = true;
            this.homebtn.IconRightZoom = 0D;
            this.homebtn.IconVisible = true;
            this.homebtn.IconZoom = 40D;
            this.homebtn.IsTab = false;
            this.homebtn.Location = new System.Drawing.Point(755, 4);
            this.homebtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.homebtn.Name = "homebtn";
            this.homebtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.homebtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.homebtn.OnHoverTextColor = System.Drawing.Color.White;
            this.homebtn.selected = false;
            this.homebtn.Size = new System.Drawing.Size(93, 34);
            this.homebtn.TabIndex = 44;
            this.homebtn.Text = "Home";
            this.homebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.homebtn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(71)))));
            this.homebtn.TextFont = new System.Drawing.Font("Candara", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // DetailFormButton
            // 
            this.DetailFormButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(71)))));
            this.DetailFormButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.DetailFormButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DetailFormButton.BorderRadius = 7;
            this.DetailFormButton.ButtonText = "For More Details";
            this.DetailFormButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DetailFormButton.DisabledColor = System.Drawing.Color.Gray;
            this.DetailFormButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailFormButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DetailFormButton.Iconcolor = System.Drawing.Color.Transparent;
            this.DetailFormButton.Iconimage = global::GP.Properties.Resources.loving;
            this.DetailFormButton.Iconimage_right = null;
            this.DetailFormButton.Iconimage_right_Selected = null;
            this.DetailFormButton.Iconimage_Selected = null;
            this.DetailFormButton.IconMarginLeft = 0;
            this.DetailFormButton.IconMarginRight = 0;
            this.DetailFormButton.IconRightVisible = true;
            this.DetailFormButton.IconRightZoom = 0D;
            this.DetailFormButton.IconVisible = true;
            this.DetailFormButton.IconZoom = 40D;
            this.DetailFormButton.IsTab = false;
            this.DetailFormButton.Location = new System.Drawing.Point(658, 265);
            this.DetailFormButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DetailFormButton.Name = "DetailFormButton";
            this.DetailFormButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.DetailFormButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.DetailFormButton.OnHoverTextColor = System.Drawing.Color.White;
            this.DetailFormButton.selected = false;
            this.DetailFormButton.Size = new System.Drawing.Size(190, 35);
            this.DetailFormButton.TabIndex = 6;
            this.DetailFormButton.Text = "For More Details";
            this.DetailFormButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DetailFormButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(71)))));
            this.DetailFormButton.TextFont = new System.Drawing.Font("Candara", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailFormButton.Visible = false;
            this.DetailFormButton.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // classifybtn
            // 
            this.classifybtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(71)))));
            this.classifybtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.classifybtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.classifybtn.BorderRadius = 7;
            this.classifybtn.ButtonText = "Classify";
            this.classifybtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.classifybtn.DisabledColor = System.Drawing.Color.Gray;
            this.classifybtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classifybtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.classifybtn.Iconcolor = System.Drawing.Color.Transparent;
            this.classifybtn.Iconimage = global::GP.Properties.Resources.deep_learning;
            this.classifybtn.Iconimage_right = null;
            this.classifybtn.Iconimage_right_Selected = null;
            this.classifybtn.Iconimage_Selected = null;
            this.classifybtn.IconMarginLeft = 0;
            this.classifybtn.IconMarginRight = 0;
            this.classifybtn.IconRightVisible = true;
            this.classifybtn.IconRightZoom = 0D;
            this.classifybtn.IconVisible = true;
            this.classifybtn.IconZoom = 40D;
            this.classifybtn.IsTab = false;
            this.classifybtn.Location = new System.Drawing.Point(720, 226);
            this.classifybtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.classifybtn.Name = "classifybtn";
            this.classifybtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.classifybtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.classifybtn.OnHoverTextColor = System.Drawing.Color.White;
            this.classifybtn.selected = false;
            this.classifybtn.Size = new System.Drawing.Size(123, 35);
            this.classifybtn.TabIndex = 7;
            this.classifybtn.Text = "Classify";
            this.classifybtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.classifybtn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(71)))));
            this.classifybtn.TextFont = new System.Drawing.Font("Candara", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classifybtn.Visible = false;
            this.classifybtn.Click += new System.EventHandler(this.classifybtn_Click);
            // 
            // Load_Button
            // 
            this.Load_Button.Activecolor = System.Drawing.Color.Transparent;
            this.Load_Button.BackColor = System.Drawing.Color.Transparent;
            this.Load_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Load_Button.BorderRadius = 0;
            this.Load_Button.ButtonText = "Load Test Signal ";
            this.Load_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Load_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Load_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load_Button.ForeColor = System.Drawing.Color.DarkGreen;
            this.Load_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Load_Button.Iconimage = null;
            this.Load_Button.Iconimage_right = global::GP.Properties.Resources.control;
            this.Load_Button.Iconimage_right_Selected = null;
            this.Load_Button.Iconimage_Selected = null;
            this.Load_Button.IconMarginLeft = 0;
            this.Load_Button.IconMarginRight = 0;
            this.Load_Button.IconRightVisible = true;
            this.Load_Button.IconRightZoom = 0D;
            this.Load_Button.IconVisible = true;
            this.Load_Button.IconZoom = 65D;
            this.Load_Button.IsTab = false;
            this.Load_Button.Location = new System.Drawing.Point(3, 3);
            this.Load_Button.Name = "Load_Button";
            this.Load_Button.Normalcolor = System.Drawing.Color.Transparent;
            this.Load_Button.OnHovercolor = System.Drawing.Color.Transparent;
            this.Load_Button.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(154)))), ((int)(((byte)(118)))));
            this.Load_Button.selected = false;
            this.Load_Button.Size = new System.Drawing.Size(203, 37);
            this.Load_Button.TabIndex = 2;
            this.Load_Button.Text = "Load Test Signal ";
            this.Load_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Load_Button.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(154)))), ((int)(((byte)(118)))));
            this.Load_Button.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load_Button.Click += new System.EventHandler(this.Load_Button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(71)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.MinimizeButton);
            this.panel2.Controls.Add(this.ExitButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(859, 27);
            this.panel2.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 44;
            this.label1.Text = "Test Signal";
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
            this.MinimizeButton.Location = new System.Drawing.Point(784, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Normalcolor = System.Drawing.Color.Transparent;
            this.MinimizeButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.MinimizeButton.OnHoverTextColor = System.Drawing.Color.White;
            this.MinimizeButton.selected = false;
            this.MinimizeButton.Size = new System.Drawing.Size(28, 29);
            this.MinimizeButton.TabIndex = 40;
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
            this.ExitButton.IconZoom = 43D;
            this.ExitButton.IsTab = false;
            this.ExitButton.Location = new System.Drawing.Point(815, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Normalcolor = System.Drawing.Color.Transparent;
            this.ExitButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.ExitButton.OnHoverTextColor = System.Drawing.Color.White;
            this.ExitButton.selected = false;
            this.ExitButton.Size = new System.Drawing.Size(26, 28);
            this.ExitButton.TabIndex = 41;
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Textcolor = System.Drawing.Color.White;
            this.ExitButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel2;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.classesChart);
            this.bunifuGradientPanel1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuGradientPanel1.ForeColor = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(71)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(71)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(71)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(71)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(3, 329);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 11;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(852, 262);
            this.bunifuGradientPanel1.TabIndex = 3;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(285, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "_ _ _ _";
            this.label5.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Number Of Beats :";
            this.label2.Visible = false;
            // 
            // classesChart
            // 
            this.classesChart.BackColor = System.Drawing.Color.Transparent;
            this.classesChart.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.classesChart.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.classesChart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.ScrollBar.BackColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.Black;
            chartArea2.AxisY.InterlacedColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY.ScrollBar.BackColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY.ScrollBar.ButtonColor = System.Drawing.Color.Black;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea2.BorderColor = System.Drawing.Color.Transparent;
            chartArea2.CursorX.LineColor = System.Drawing.Color.Black;
            chartArea2.CursorX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea2.CursorY.LineColor = System.Drawing.Color.Black;
            chartArea2.Name = "ChartArea1";
            this.classesChart.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Name = "Legend1";
            this.classesChart.Legends.Add(legend2);
            this.classesChart.Location = new System.Drawing.Point(7, 21);
            this.classesChart.Name = "classesChart";
            this.classesChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.WhiteSmoke;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Classes";
            series2.ShadowColor = System.Drawing.Color.Navy;
            this.classesChart.Series.Add(series2);
            this.classesChart.Size = new System.Drawing.Size(845, 208);
            this.classesChart.TabIndex = 8;
            this.classesChart.Text = "chart2";
            this.classesChart.Visible = false;
            // 
            // Load_Signal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(859, 595);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Load_Signal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Load_Signal";
            this.Load += new System.EventHandler(this.Load_Signal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classesChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton Load_Button;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton MinimizeButton;
        private Bunifu.Framework.UI.BunifuFlatButton ExitButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton DetailFormButton;
        private System.Windows.Forms.Label recordNamelbl;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton classifybtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart classesChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton homebtn;
    }
}