namespace COSI_Lab3
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.picture = new System.Windows.Forms.PictureBox();
            this.pictureResult = new System.Windows.Forms.PictureBox();
            this.buttonToGray = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonNegative = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImage = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImage = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBarRotate = new System.Windows.Forms.TrackBar();
            this.buttonRotate = new System.Windows.Forms.Button();
            this.labelRotate = new System.Windows.Forms.Label();
            this.blurButton = new System.Windows.Forms.Button();
            this.trackBarBlur = new System.Windows.Forms.TrackBar();
            this.labelBlur = new System.Windows.Forms.Label();
            this.buttonWave = new System.Windows.Forms.Button();
            this.trackBarV4 = new System.Windows.Forms.TrackBar();
            this.trackBarV3 = new System.Windows.Forms.TrackBar();
            this.trackBarV2 = new System.Windows.Forms.TrackBar();
            this.trackBarV1 = new System.Windows.Forms.TrackBar();
            this.buttonGistogramCorrection = new System.Windows.Forms.Button();
            this.buttonReverseGorizontal = new System.Windows.Forms.Button();
            this.buttonReverseVertical = new System.Windows.Forms.Button();
            this.checkBoxEffectTo = new System.Windows.Forms.CheckBox();
            this.chartR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxGistoRMin = new System.Windows.Forms.TextBox();
            this.textBoxGistoRMax = new System.Windows.Forms.TextBox();
            this.textBoxGistoGMin = new System.Windows.Forms.TextBox();
            this.textBoxGistoGMax = new System.Windows.Forms.TextBox();
            this.textBoxGistoBMin = new System.Windows.Forms.TextBox();
            this.textBoxGistoBMax = new System.Windows.Forms.TextBox();
            this.buttonMedianFilter = new System.Windows.Forms.Button();
            this.textBoxMedianFilter = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureResult)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarV4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarV3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartB)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(12, 27);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(455, 272);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // pictureResult
            // 
            this.pictureResult.Location = new System.Drawing.Point(473, 27);
            this.pictureResult.Name = "pictureResult";
            this.pictureResult.Size = new System.Drawing.Size(462, 272);
            this.pictureResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureResult.TabIndex = 1;
            this.pictureResult.TabStop = false;
            // 
            // buttonToGray
            // 
            this.buttonToGray.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonToGray.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonToGray.Location = new System.Drawing.Point(941, 208);
            this.buttonToGray.Name = "buttonToGray";
            this.buttonToGray.Size = new System.Drawing.Size(244, 37);
            this.buttonToGray.TabIndex = 3;
            this.buttonToGray.Text = "Обесцвечивание";
            this.buttonToGray.UseVisualStyleBackColor = false;
            this.buttonToGray.Click += new System.EventHandler(this.buttonToGray_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonNegative
            // 
            this.buttonNegative.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNegative.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonNegative.Location = new System.Drawing.Point(941, 251);
            this.buttonNegative.Name = "buttonNegative";
            this.buttonNegative.Size = new System.Drawing.Size(244, 38);
            this.buttonNegative.TabIndex = 4;
            this.buttonNegative.Text = "Негатив";
            this.buttonNegative.UseVisualStyleBackColor = false;
            this.buttonNegative.Click += new System.EventHandler(this.buttonNegative_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 629);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(923, 16);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Вывод:";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.progressBar1.Location = new System.Drawing.Point(473, 27);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(462, 272);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1197, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImage,
            this.saveImage});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // openImage
            // 
            this.openImage.Name = "openImage";
            this.openImage.Size = new System.Drawing.Size(132, 22);
            this.openImage.Text = "Открыть";
            this.openImage.Click += new System.EventHandler(this.openImage_Click);
            // 
            // saveImage
            // 
            this.saveImage.Name = "saveImage";
            this.saveImage.Size = new System.Drawing.Size(132, 22);
            this.saveImage.Text = "Сохранить";
            this.saveImage.Click += new System.EventHandler(this.saveImage_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem1});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // оПрограммеToolStripMenuItem1
            // 
            this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            this.оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem1.Text = "О программе";
            this.оПрограммеToolStripMenuItem1.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem1_Click);
            // 
            // trackBarRotate
            // 
            this.trackBarRotate.Location = new System.Drawing.Point(941, 27);
            this.trackBarRotate.Maximum = 360;
            this.trackBarRotate.Name = "trackBarRotate";
            this.trackBarRotate.Size = new System.Drawing.Size(149, 45);
            this.trackBarRotate.TabIndex = 9;
            this.trackBarRotate.TickFrequency = 30;
            this.trackBarRotate.Scroll += new System.EventHandler(this.trackBarRotate_Move);
            // 
            // buttonRotate
            // 
            this.buttonRotate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonRotate.Location = new System.Drawing.Point(1115, 27);
            this.buttonRotate.Name = "buttonRotate";
            this.buttonRotate.Size = new System.Drawing.Size(70, 37);
            this.buttonRotate.TabIndex = 10;
            this.buttonRotate.Text = "Повернуть";
            this.buttonRotate.UseVisualStyleBackColor = false;
            this.buttonRotate.Click += new System.EventHandler(this.buttonRotate_Click);
            // 
            // labelRotate
            // 
            this.labelRotate.AutoSize = true;
            this.labelRotate.Location = new System.Drawing.Point(1096, 39);
            this.labelRotate.Name = "labelRotate";
            this.labelRotate.Size = new System.Drawing.Size(13, 13);
            this.labelRotate.TabIndex = 11;
            this.labelRotate.Text = "0";
            // 
            // blurButton
            // 
            this.blurButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.blurButton.Location = new System.Drawing.Point(1115, 70);
            this.blurButton.Name = "blurButton";
            this.blurButton.Size = new System.Drawing.Size(70, 30);
            this.blurButton.TabIndex = 12;
            this.blurButton.Text = "Размытие";
            this.blurButton.UseVisualStyleBackColor = false;
            this.blurButton.Click += new System.EventHandler(this.blurButton_Click);
            // 
            // trackBarBlur
            // 
            this.trackBarBlur.Location = new System.Drawing.Point(941, 70);
            this.trackBarBlur.Maximum = 50;
            this.trackBarBlur.Name = "trackBarBlur";
            this.trackBarBlur.Size = new System.Drawing.Size(149, 45);
            this.trackBarBlur.TabIndex = 10;
            this.trackBarBlur.TickFrequency = 10;
            this.trackBarBlur.ValueChanged += new System.EventHandler(this.trackBarBlur_ValueChanged);
            // 
            // labelBlur
            // 
            this.labelBlur.AutoSize = true;
            this.labelBlur.Location = new System.Drawing.Point(1096, 79);
            this.labelBlur.Name = "labelBlur";
            this.labelBlur.Size = new System.Drawing.Size(13, 13);
            this.labelBlur.TabIndex = 14;
            this.labelBlur.Text = "0";
            // 
            // buttonWave
            // 
            this.buttonWave.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonWave.Location = new System.Drawing.Point(1161, 106);
            this.buttonWave.Name = "buttonWave";
            this.buttonWave.Size = new System.Drawing.Size(24, 96);
            this.buttonWave.TabIndex = 15;
            this.buttonWave.Text = "Волны";
            this.buttonWave.UseVisualStyleBackColor = false;
            this.buttonWave.Click += new System.EventHandler(this.buttonWave_Click);
            // 
            // trackBarV4
            // 
            this.trackBarV4.Location = new System.Drawing.Point(1057, 157);
            this.trackBarV4.Maximum = 50;
            this.trackBarV4.Minimum = 1;
            this.trackBarV4.Name = "trackBarV4";
            this.trackBarV4.Size = new System.Drawing.Size(98, 45);
            this.trackBarV4.TabIndex = 19;
            this.trackBarV4.TickFrequency = 10;
            this.trackBarV4.Value = 1;
            // 
            // trackBarV3
            // 
            this.trackBarV3.Location = new System.Drawing.Point(941, 157);
            this.trackBarV3.Maximum = 50;
            this.trackBarV3.Minimum = 1;
            this.trackBarV3.Name = "trackBarV3";
            this.trackBarV3.Size = new System.Drawing.Size(113, 45);
            this.trackBarV3.TabIndex = 20;
            this.trackBarV3.TickFrequency = 10;
            this.trackBarV3.Value = 1;
            // 
            // trackBarV2
            // 
            this.trackBarV2.Location = new System.Drawing.Point(1057, 106);
            this.trackBarV2.Maximum = 50;
            this.trackBarV2.Minimum = 1;
            this.trackBarV2.Name = "trackBarV2";
            this.trackBarV2.Size = new System.Drawing.Size(98, 45);
            this.trackBarV2.TabIndex = 21;
            this.trackBarV2.TickFrequency = 10;
            this.trackBarV2.Value = 1;
            // 
            // trackBarV1
            // 
            this.trackBarV1.Location = new System.Drawing.Point(941, 106);
            this.trackBarV1.Maximum = 50;
            this.trackBarV1.Minimum = 1;
            this.trackBarV1.Name = "trackBarV1";
            this.trackBarV1.Size = new System.Drawing.Size(110, 45);
            this.trackBarV1.TabIndex = 22;
            this.trackBarV1.TickFrequency = 10;
            this.trackBarV1.Value = 1;
            // 
            // buttonGistogramCorrection
            // 
            this.buttonGistogramCorrection.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonGistogramCorrection.Location = new System.Drawing.Point(940, 344);
            this.buttonGistogramCorrection.Name = "buttonGistogramCorrection";
            this.buttonGistogramCorrection.Size = new System.Drawing.Size(244, 32);
            this.buttonGistogramCorrection.TabIndex = 23;
            this.buttonGistogramCorrection.Text = "Гистограммная коррекция";
            this.buttonGistogramCorrection.UseVisualStyleBackColor = false;
            this.buttonGistogramCorrection.Click += new System.EventHandler(this.buttonGistogramCorrection_Click);
            // 
            // buttonReverseGorizontal
            // 
            this.buttonReverseGorizontal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonReverseGorizontal.Location = new System.Drawing.Point(941, 297);
            this.buttonReverseGorizontal.Name = "buttonReverseGorizontal";
            this.buttonReverseGorizontal.Size = new System.Drawing.Size(123, 41);
            this.buttonReverseGorizontal.TabIndex = 24;
            this.buttonReverseGorizontal.Text = "Отразить по горизонтали";
            this.buttonReverseGorizontal.UseVisualStyleBackColor = false;
            this.buttonReverseGorizontal.Click += new System.EventHandler(this.buttonReverseGorizontal_Click);
            // 
            // buttonReverseVertical
            // 
            this.buttonReverseVertical.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonReverseVertical.Location = new System.Drawing.Point(1070, 297);
            this.buttonReverseVertical.Name = "buttonReverseVertical";
            this.buttonReverseVertical.Size = new System.Drawing.Size(115, 41);
            this.buttonReverseVertical.TabIndex = 25;
            this.buttonReverseVertical.Text = "Отразить по вертикали";
            this.buttonReverseVertical.UseVisualStyleBackColor = false;
            this.buttonReverseVertical.Click += new System.EventHandler(this.buttonReverseVertical_Click);
            // 
            // checkBoxEffectTo
            // 
            this.checkBoxEffectTo.AutoSize = true;
            this.checkBoxEffectTo.Checked = true;
            this.checkBoxEffectTo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEffectTo.Location = new System.Drawing.Point(12, 310);
            this.checkBoxEffectTo.Name = "checkBoxEffectTo";
            this.checkBoxEffectTo.Size = new System.Drawing.Size(218, 17);
            this.checkBoxEffectTo.TabIndex = 26;
            this.checkBoxEffectTo.Text = "Применять все эффекты к оригиналу";
            this.checkBoxEffectTo.UseVisualStyleBackColor = true;
            this.checkBoxEffectTo.CheckedChanged += new System.EventHandler(this.checkBoxEffectTo_CheckedChanged);
            // 
            // chartR
            // 
            this.chartR.BackColor = System.Drawing.Color.LightGray;
            this.chartR.BackSecondaryColor = System.Drawing.Color.White;
            this.chartR.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartR.ChartAreas.Add(chartArea1);
            this.chartR.Location = new System.Drawing.Point(12, 333);
            this.chartR.Name = "chartR";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Red;
            series1.Name = "Red";
            this.chartR.Series.Add(series1);
            this.chartR.Size = new System.Drawing.Size(848, 91);
            this.chartR.TabIndex = 27;
            this.chartR.Text = "chart1";
            // 
            // chartG
            // 
            this.chartG.BackColor = System.Drawing.Color.LightGray;
            this.chartG.BackSecondaryColor = System.Drawing.Color.White;
            this.chartG.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chartG.ChartAreas.Add(chartArea2);
            this.chartG.Location = new System.Drawing.Point(12, 430);
            this.chartG.Name = "chartG";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series2.Name = "Green";
            this.chartG.Series.Add(series2);
            this.chartG.Size = new System.Drawing.Size(848, 91);
            this.chartG.TabIndex = 28;
            this.chartG.Text = "chart1";
            // 
            // chartB
            // 
            this.chartB.BackColor = System.Drawing.Color.LightGray;
            this.chartB.BackSecondaryColor = System.Drawing.Color.White;
            this.chartB.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chartB.ChartAreas.Add(chartArea3);
            this.chartB.Location = new System.Drawing.Point(12, 527);
            this.chartB.Name = "chartB";
            series3.ChartArea = "ChartArea1";
            series3.Name = "Blue";
            this.chartB.Series.Add(series3);
            this.chartB.Size = new System.Drawing.Size(848, 91);
            this.chartB.TabIndex = 29;
            this.chartB.Text = "chart1";
            // 
            // textBoxGistoRMin
            // 
            this.textBoxGistoRMin.Location = new System.Drawing.Point(866, 333);
            this.textBoxGistoRMin.Name = "textBoxGistoRMin";
            this.textBoxGistoRMin.Size = new System.Drawing.Size(68, 20);
            this.textBoxGistoRMin.TabIndex = 34;
            // 
            // textBoxGistoRMax
            // 
            this.textBoxGistoRMax.Location = new System.Drawing.Point(866, 404);
            this.textBoxGistoRMax.Name = "textBoxGistoRMax";
            this.textBoxGistoRMax.Size = new System.Drawing.Size(68, 20);
            this.textBoxGistoRMax.TabIndex = 35;
            // 
            // textBoxGistoGMin
            // 
            this.textBoxGistoGMin.Location = new System.Drawing.Point(866, 430);
            this.textBoxGistoGMin.Name = "textBoxGistoGMin";
            this.textBoxGistoGMin.Size = new System.Drawing.Size(68, 20);
            this.textBoxGistoGMin.TabIndex = 36;
            // 
            // textBoxGistoGMax
            // 
            this.textBoxGistoGMax.Location = new System.Drawing.Point(866, 501);
            this.textBoxGistoGMax.Name = "textBoxGistoGMax";
            this.textBoxGistoGMax.Size = new System.Drawing.Size(68, 20);
            this.textBoxGistoGMax.TabIndex = 37;
            // 
            // textBoxGistoBMin
            // 
            this.textBoxGistoBMin.Location = new System.Drawing.Point(867, 527);
            this.textBoxGistoBMin.Name = "textBoxGistoBMin";
            this.textBoxGistoBMin.Size = new System.Drawing.Size(68, 20);
            this.textBoxGistoBMin.TabIndex = 38;
            // 
            // textBoxGistoBMax
            // 
            this.textBoxGistoBMax.Location = new System.Drawing.Point(867, 598);
            this.textBoxGistoBMax.Name = "textBoxGistoBMax";
            this.textBoxGistoBMax.Size = new System.Drawing.Size(68, 20);
            this.textBoxGistoBMax.TabIndex = 39;
            // 
            // buttonMedianFilter
            // 
            this.buttonMedianFilter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonMedianFilter.Location = new System.Drawing.Point(1028, 382);
            this.buttonMedianFilter.Name = "buttonMedianFilter";
            this.buttonMedianFilter.Size = new System.Drawing.Size(157, 32);
            this.buttonMedianFilter.TabIndex = 40;
            this.buttonMedianFilter.Text = "Медианная фильтрация";
            this.buttonMedianFilter.UseVisualStyleBackColor = false;
            this.buttonMedianFilter.Click += new System.EventHandler(this.buttonMedianFilter_Click);
            // 
            // textBoxMedianFilter
            // 
            this.textBoxMedianFilter.Location = new System.Drawing.Point(941, 389);
            this.textBoxMedianFilter.Name = "textBoxMedianFilter";
            this.textBoxMedianFilter.Size = new System.Drawing.Size(81, 20);
            this.textBoxMedianFilter.TabIndex = 41;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "авпрео",
            "апро",
            "апрол",
            "арпол"});
            this.listBox1.Location = new System.Drawing.Point(989, 430);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(62, 95);
            this.listBox1.TabIndex = 42;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "впро",
            "еенгрод",
            "ыукваролд",
            "вапролд",
            "выапрол"});
            this.comboBox1.Location = new System.Drawing.Point(1057, 444);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 43;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1197, 657);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxMedianFilter);
            this.Controls.Add(this.buttonMedianFilter);
            this.Controls.Add(this.textBoxGistoBMax);
            this.Controls.Add(this.textBoxGistoBMin);
            this.Controls.Add(this.textBoxGistoGMax);
            this.Controls.Add(this.textBoxGistoGMin);
            this.Controls.Add(this.textBoxGistoRMax);
            this.Controls.Add(this.textBoxGistoRMin);
            this.Controls.Add(this.chartB);
            this.Controls.Add(this.chartG);
            this.Controls.Add(this.chartR);
            this.Controls.Add(this.checkBoxEffectTo);
            this.Controls.Add(this.buttonReverseVertical);
            this.Controls.Add(this.buttonReverseGorizontal);
            this.Controls.Add(this.buttonGistogramCorrection);
            this.Controls.Add(this.trackBarV1);
            this.Controls.Add(this.trackBarV2);
            this.Controls.Add(this.trackBarV3);
            this.Controls.Add(this.trackBarV4);
            this.Controls.Add(this.buttonWave);
            this.Controls.Add(this.labelBlur);
            this.Controls.Add(this.trackBarBlur);
            this.Controls.Add(this.blurButton);
            this.Controls.Add(this.labelRotate);
            this.Controls.Add(this.buttonRotate);
            this.Controls.Add(this.trackBarRotate);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonNegative);
            this.Controls.Add(this.buttonToGray);
            this.Controls.Add(this.pictureResult);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(640, 240);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №3";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureResult)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarV4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarV3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.PictureBox pictureResult;
        private System.Windows.Forms.Button buttonToGray;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonNegative;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImage;
        private System.Windows.Forms.ToolStripMenuItem saveImage;
        private System.Windows.Forms.TrackBar trackBarRotate;
        private System.Windows.Forms.Button buttonRotate;
        private System.Windows.Forms.Label labelRotate;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private System.Windows.Forms.Button blurButton;
        private System.Windows.Forms.TrackBar trackBarBlur;
        private System.Windows.Forms.Label labelBlur;
        private System.Windows.Forms.Button buttonWave;
        private System.Windows.Forms.TrackBar trackBarV4;
        private System.Windows.Forms.TrackBar trackBarV3;
        private System.Windows.Forms.TrackBar trackBarV2;
        private System.Windows.Forms.TrackBar trackBarV1;
        private System.Windows.Forms.Button buttonGistogramCorrection;
        private System.Windows.Forms.Button buttonReverseGorizontal;
        private System.Windows.Forms.Button buttonReverseVertical;
        private System.Windows.Forms.CheckBox checkBoxEffectTo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartG;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartB;
        private System.Windows.Forms.TextBox textBoxGistoRMin;
        private System.Windows.Forms.TextBox textBoxGistoRMax;
        private System.Windows.Forms.TextBox textBoxGistoGMin;
        private System.Windows.Forms.TextBox textBoxGistoGMax;
        private System.Windows.Forms.TextBox textBoxGistoBMin;
        private System.Windows.Forms.TextBox textBoxGistoBMax;
        private System.Windows.Forms.Button buttonMedianFilter;
        private System.Windows.Forms.TextBox textBoxMedianFilter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

