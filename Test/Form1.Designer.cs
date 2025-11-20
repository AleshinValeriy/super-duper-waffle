namespace Course_Work_Aleshin_24VP2_01
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ResultGraphics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ControlPanelLabel = new System.Windows.Forms.Label();
            this.ResultsLabel = new System.Windows.Forms.Label();
            this.Sort_btn = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ListSize = new System.Windows.Forms.NumericUpDown();
            this.PartlyOrderedListPercent = new System.Windows.Forms.NumericUpDown();
            this.UnorderedListCheck = new System.Windows.Forms.RadioButton();
            this.OrderedListCheck = new System.Windows.Forms.RadioButton();
            this.r_OrderedListCheck = new System.Windows.Forms.RadioButton();
            this.PartlyOrderedListCheck = new System.Windows.Forms.RadioButton();
            this.NumberOfElementsLabel = new System.Windows.Forms.Label();
            this.OrderTypeLabel = new System.Windows.Forms.Label();
            this.OrderPercentLabel = new System.Windows.Forms.Label();
            this.ErrorTextFieldLabel = new System.Windows.Forms.Label();
            this.ResultTable = new System.Windows.Forms.DataGridView();
            this.SortType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column60 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column70 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column80 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column90 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column100 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorPanel = new System.Windows.Forms.Panel();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.RadioBtnGroup = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ResultGraphics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartlyOrderedListPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultTable)).BeginInit();
            this.ErrorPanel.SuspendLayout();
            this.RadioBtnGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultGraphics
            // 
            this.ResultGraphics.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.ResultGraphics.BorderlineColor = System.Drawing.Color.SteelBlue;
            this.ResultGraphics.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.ResultGraphics.BorderSkin.PageColor = System.Drawing.Color.Violet;
            chartArea1.AxisX.Maximum = 1D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.ResultGraphics.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ResultGraphics.Legends.Add(legend1);
            this.ResultGraphics.Location = new System.Drawing.Point(372, 82);
            this.ResultGraphics.Name = "ResultGraphics";
            this.ResultGraphics.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Сортировка Шелла";
            series2.BorderWidth = 4;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Пирамидальная сортировка";
            series3.BorderWidth = 4;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Сортировка подсчётом";
            this.ResultGraphics.Series.Add(series1);
            this.ResultGraphics.Series.Add(series2);
            this.ResultGraphics.Series.Add(series3);
            this.ResultGraphics.Size = new System.Drawing.Size(700, 369);
            this.ResultGraphics.TabIndex = 0;
            this.ResultGraphics.Text = "ResultGraphics";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(370, -61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 739);
            this.panel1.TabIndex = 2;
            // 
            // ControlPanelLabel
            // 
            this.ControlPanelLabel.AutoSize = true;
            this.ControlPanelLabel.BackColor = System.Drawing.Color.Transparent;
            this.ControlPanelLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.ControlPanelLabel.ForeColor = System.Drawing.Color.White;
            this.ControlPanelLabel.Location = new System.Drawing.Point(27, 26);
            this.ControlPanelLabel.Name = "ControlPanelLabel";
            this.ControlPanelLabel.Size = new System.Drawing.Size(280, 40);
            this.ControlPanelLabel.TabIndex = 3;
            this.ControlPanelLabel.Text = "Панель управления";
            // 
            // ResultsLabel
            // 
            this.ResultsLabel.AutoSize = true;
            this.ResultsLabel.BackColor = System.Drawing.Color.Transparent;
            this.ResultsLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.ResultsLabel.ForeColor = System.Drawing.Color.White;
            this.ResultsLabel.Location = new System.Drawing.Point(513, 26);
            this.ResultsLabel.Name = "ResultsLabel";
            this.ResultsLabel.Size = new System.Drawing.Size(435, 40);
            this.ResultsLabel.TabIndex = 4;
            this.ResultsLabel.Text = "Результаты работы программы";
            // 
            // Sort_btn
            // 
            this.Sort_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(47)))), ((int)(((byte)(202)))));
            this.Sort_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.Sort_btn.ForeColor = System.Drawing.Color.White;
            this.Sort_btn.Location = new System.Drawing.Point(3, 560);
            this.Sort_btn.Name = "Sort_btn";
            this.Sort_btn.Size = new System.Drawing.Size(209, 42);
            this.Sort_btn.TabIndex = 5;
            this.Sort_btn.Text = "СОРТИРОВАТЬ";
            this.Sort_btn.UseVisualStyleBackColor = false;
            this.Sort_btn.Click += new System.EventHandler(this.Sort_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(218, 560);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(144, 42);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "ВЫХОД";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(47)))), ((int)(((byte)(202)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(23, 572);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // ListSize
            // 
            this.ListSize.Location = new System.Drawing.Point(23, 127);
            this.ListSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ListSize.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.ListSize.Name = "ListSize";
            this.ListSize.Size = new System.Drawing.Size(136, 20);
            this.ListSize.TabIndex = 8;
            this.ListSize.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // PartlyOrderedListPercent
            // 
            this.PartlyOrderedListPercent.Location = new System.Drawing.Point(23, 370);
            this.PartlyOrderedListPercent.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.PartlyOrderedListPercent.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.PartlyOrderedListPercent.Name = "PartlyOrderedListPercent";
            this.PartlyOrderedListPercent.Size = new System.Drawing.Size(51, 20);
            this.PartlyOrderedListPercent.TabIndex = 8;
            this.PartlyOrderedListPercent.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // UnorderedListCheck
            // 
            this.UnorderedListCheck.AutoSize = true;
            this.UnorderedListCheck.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnorderedListCheck.ForeColor = System.Drawing.Color.White;
            this.UnorderedListCheck.Location = new System.Drawing.Point(14, 0);
            this.UnorderedListCheck.Name = "UnorderedListCheck";
            this.UnorderedListCheck.Size = new System.Drawing.Size(191, 17);
            this.UnorderedListCheck.TabIndex = 9;
            this.UnorderedListCheck.TabStop = true;
            this.UnorderedListCheck.Text = "НЕУПОРЯДОЧЕННЫЙ СПИСОК";
            this.UnorderedListCheck.UseVisualStyleBackColor = true;
            // 
            // OrderedListCheck
            // 
            this.OrderedListCheck.AutoSize = true;
            this.OrderedListCheck.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderedListCheck.ForeColor = System.Drawing.Color.White;
            this.OrderedListCheck.Location = new System.Drawing.Point(14, 21);
            this.OrderedListCheck.Name = "OrderedListCheck";
            this.OrderedListCheck.Size = new System.Drawing.Size(177, 17);
            this.OrderedListCheck.TabIndex = 9;
            this.OrderedListCheck.TabStop = true;
            this.OrderedListCheck.Text = "УПОРЯДОЧЕННЫЙ СПИСОК";
            this.OrderedListCheck.UseVisualStyleBackColor = true;
            // 
            // r_OrderedListCheck
            // 
            this.r_OrderedListCheck.AutoSize = true;
            this.r_OrderedListCheck.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_OrderedListCheck.ForeColor = System.Drawing.Color.White;
            this.r_OrderedListCheck.Location = new System.Drawing.Point(14, 42);
            this.r_OrderedListCheck.Name = "r_OrderedListCheck";
            this.r_OrderedListCheck.Size = new System.Drawing.Size(306, 17);
            this.r_OrderedListCheck.TabIndex = 9;
            this.r_OrderedListCheck.TabStop = true;
            this.r_OrderedListCheck.Text = "УПОРЯДОЧЕННЫЙ В ОБРАТНОМ ПОРЯДКЕ СПИСОК";
            this.r_OrderedListCheck.UseVisualStyleBackColor = true;
            // 
            // PartlyOrderedListCheck
            // 
            this.PartlyOrderedListCheck.AutoSize = true;
            this.PartlyOrderedListCheck.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartlyOrderedListCheck.ForeColor = System.Drawing.Color.White;
            this.PartlyOrderedListCheck.Location = new System.Drawing.Point(14, 63);
            this.PartlyOrderedListCheck.Name = "PartlyOrderedListCheck";
            this.PartlyOrderedListCheck.Size = new System.Drawing.Size(242, 17);
            this.PartlyOrderedListCheck.TabIndex = 9;
            this.PartlyOrderedListCheck.TabStop = true;
            this.PartlyOrderedListCheck.Text = "ЧАСТИЧНО УПОРЯДОЧЕННЫЙ СПИСОК";
            this.PartlyOrderedListCheck.UseVisualStyleBackColor = true;
            this.PartlyOrderedListCheck.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // NumberOfElementsLabel
            // 
            this.NumberOfElementsLabel.AutoSize = true;
            this.NumberOfElementsLabel.BackColor = System.Drawing.Color.Transparent;
            this.NumberOfElementsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.NumberOfElementsLabel.ForeColor = System.Drawing.Color.White;
            this.NumberOfElementsLabel.Location = new System.Drawing.Point(7, 96);
            this.NumberOfElementsLabel.Name = "NumberOfElementsLabel";
            this.NumberOfElementsLabel.Size = new System.Drawing.Size(227, 25);
            this.NumberOfElementsLabel.TabIndex = 3;
            this.NumberOfElementsLabel.Text = "Число элементов списка";
            // 
            // OrderTypeLabel
            // 
            this.OrderTypeLabel.AutoSize = true;
            this.OrderTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.OrderTypeLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.OrderTypeLabel.ForeColor = System.Drawing.Color.White;
            this.OrderTypeLabel.Location = new System.Drawing.Point(7, 181);
            this.OrderTypeLabel.Name = "OrderTypeLabel";
            this.OrderTypeLabel.Size = new System.Drawing.Size(204, 25);
            this.OrderTypeLabel.TabIndex = 3;
            this.OrderTypeLabel.Text = "Тип упорядоченности";
            // 
            // OrderPercentLabel
            // 
            this.OrderPercentLabel.AutoSize = true;
            this.OrderPercentLabel.BackColor = System.Drawing.Color.Transparent;
            this.OrderPercentLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.OrderPercentLabel.ForeColor = System.Drawing.Color.White;
            this.OrderPercentLabel.Location = new System.Drawing.Point(7, 344);
            this.OrderPercentLabel.Name = "OrderPercentLabel";
            this.OrderPercentLabel.Size = new System.Drawing.Size(248, 25);
            this.OrderPercentLabel.TabIndex = 3;
            this.OrderPercentLabel.Text = "Процент упорядоченности";
            // 
            // ErrorTextFieldLabel
            // 
            this.ErrorTextFieldLabel.AutoSize = true;
            this.ErrorTextFieldLabel.BackColor = System.Drawing.Color.Transparent;
            this.ErrorTextFieldLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.ErrorTextFieldLabel.ForeColor = System.Drawing.Color.White;
            this.ErrorTextFieldLabel.Location = new System.Drawing.Point(7, 411);
            this.ErrorTextFieldLabel.Name = "ErrorTextFieldLabel";
            this.ErrorTextFieldLabel.Size = new System.Drawing.Size(234, 25);
            this.ErrorTextFieldLabel.TabIndex = 3;
            this.ErrorTextFieldLabel.Text = "Поле для вывода ошибок";
            // 
            // ResultTable
            // 
            this.ResultTable.AllowUserToAddRows = false;
            this.ResultTable.AllowUserToDeleteRows = false;
            this.ResultTable.AllowUserToResizeColumns = false;
            this.ResultTable.AllowUserToResizeRows = false;
            this.ResultTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SortType,
            this.Column10,
            this.Column20,
            this.Column30,
            this.Column40,
            this.Column50,
            this.Column60,
            this.Column70,
            this.Column80,
            this.Column90,
            this.Column100});
            this.ResultTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ResultTable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ResultTable.Location = new System.Drawing.Point(372, 450);
            this.ResultTable.Name = "ResultTable";
            this.ResultTable.ReadOnly = true;
            this.ResultTable.RowHeadersVisible = false;
            this.ResultTable.RowTemplate.Height = 46;
            this.ResultTable.Size = new System.Drawing.Size(700, 164);
            this.ResultTable.TabIndex = 10;
            // 
            // SortType
            // 
            this.SortType.HeaderText = "Тип Сортировки";
            this.SortType.Name = "SortType";
            this.SortType.ReadOnly = true;
            this.SortType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SortType.Width = 146;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "10%";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column10.Width = 55;
            // 
            // Column20
            // 
            this.Column20.HeaderText = "20%";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            this.Column20.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column20.Width = 55;
            // 
            // Column30
            // 
            this.Column30.HeaderText = "30%";
            this.Column30.Name = "Column30";
            this.Column30.ReadOnly = true;
            this.Column30.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column30.Width = 55;
            // 
            // Column40
            // 
            this.Column40.HeaderText = "40%";
            this.Column40.Name = "Column40";
            this.Column40.ReadOnly = true;
            this.Column40.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column40.Width = 55;
            // 
            // Column50
            // 
            this.Column50.HeaderText = "50%";
            this.Column50.Name = "Column50";
            this.Column50.ReadOnly = true;
            this.Column50.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column50.Width = 55;
            // 
            // Column60
            // 
            this.Column60.HeaderText = "60%";
            this.Column60.Name = "Column60";
            this.Column60.ReadOnly = true;
            this.Column60.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column60.Width = 55;
            // 
            // Column70
            // 
            this.Column70.HeaderText = "70%";
            this.Column70.Name = "Column70";
            this.Column70.ReadOnly = true;
            this.Column70.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column70.Width = 55;
            // 
            // Column80
            // 
            this.Column80.HeaderText = "80%";
            this.Column80.Name = "Column80";
            this.Column80.ReadOnly = true;
            this.Column80.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column80.Width = 55;
            // 
            // Column90
            // 
            this.Column90.HeaderText = "90%";
            this.Column90.Name = "Column90";
            this.Column90.ReadOnly = true;
            this.Column90.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column90.Width = 55;
            // 
            // Column100
            // 
            this.Column100.HeaderText = "100%";
            this.Column100.Name = "Column100";
            this.Column100.ReadOnly = true;
            this.Column100.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column100.Width = 55;
            // 
            // ErrorPanel
            // 
            this.ErrorPanel.AutoScroll = true;
            this.ErrorPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ErrorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ErrorPanel.Controls.Add(this.ErrorLabel);
            this.ErrorPanel.Location = new System.Drawing.Point(9, 435);
            this.ErrorPanel.Name = "ErrorPanel";
            this.ErrorPanel.Size = new System.Drawing.Size(352, 112);
            this.ErrorPanel.TabIndex = 11;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ErrorLabel.ForeColor = System.Drawing.Color.White;
            this.ErrorLabel.Location = new System.Drawing.Point(11, 15);
            this.ErrorLabel.MaximumSize = new System.Drawing.Size(340, 0);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(269, 17);
            this.ErrorLabel.TabIndex = 0;
            this.ErrorLabel.Text = "Здесь будет писаться какая-то ошибка";
            // 
            // RadioBtnGroup
            // 
            this.RadioBtnGroup.Controls.Add(this.PartlyOrderedListCheck);
            this.RadioBtnGroup.Controls.Add(this.r_OrderedListCheck);
            this.RadioBtnGroup.Controls.Add(this.OrderedListCheck);
            this.RadioBtnGroup.Controls.Add(this.UnorderedListCheck);
            this.RadioBtnGroup.Location = new System.Drawing.Point(9, 209);
            this.RadioBtnGroup.Name = "RadioBtnGroup";
            this.RadioBtnGroup.Size = new System.Drawing.Size(329, 99);
            this.RadioBtnGroup.TabIndex = 12;
            this.RadioBtnGroup.TabStop = false;
            this.RadioBtnGroup.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1069, 607);
            this.Controls.Add(this.RadioBtnGroup);
            this.Controls.Add(this.ErrorPanel);
            this.Controls.Add(this.ResultTable);
            this.Controls.Add(this.PartlyOrderedListPercent);
            this.Controls.Add(this.ListSize);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Sort_btn);
            this.Controls.Add(this.ResultsLabel);
            this.Controls.Add(this.ErrorTextFieldLabel);
            this.Controls.Add(this.OrderPercentLabel);
            this.Controls.Add(this.OrderTypeLabel);
            this.Controls.Add(this.NumberOfElementsLabel);
            this.Controls.Add(this.ControlPanelLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ResultGraphics);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Course Work Aleshin Valeriy 24VP2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResultGraphics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartlyOrderedListPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultTable)).EndInit();
            this.ErrorPanel.ResumeLayout(false);
            this.ErrorPanel.PerformLayout();
            this.RadioBtnGroup.ResumeLayout(false);
            this.RadioBtnGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ResultGraphics;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ControlPanelLabel;
        private System.Windows.Forms.Label ResultsLabel;
        private System.Windows.Forms.Button Sort_btn;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown ListSize;
        private System.Windows.Forms.NumericUpDown PartlyOrderedListPercent;
        private System.Windows.Forms.RadioButton UnorderedListCheck;
        private System.Windows.Forms.RadioButton OrderedListCheck;
        private System.Windows.Forms.RadioButton r_OrderedListCheck;
        private System.Windows.Forms.RadioButton PartlyOrderedListCheck;
        private System.Windows.Forms.Label NumberOfElementsLabel;
        private System.Windows.Forms.Label OrderTypeLabel;
        private System.Windows.Forms.Label OrderPercentLabel;
        private System.Windows.Forms.Label ErrorTextFieldLabel;
        private System.Windows.Forms.DataGridView ResultTable;
        private System.Windows.Forms.Panel ErrorPanel;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn SortType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column30;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column40;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column50;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column60;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column70;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column80;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column90;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column100;
        private System.Windows.Forms.GroupBox RadioBtnGroup;
    }
}

