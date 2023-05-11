namespace US_5A_Net
{
    partial class AirportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AirportForm));
            this.mainMenuMS = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Correction = new System.Windows.Forms.ToolStripMenuItem();
            this.AddMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DeliteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsTS = new System.Windows.Forms.ToolStrip();
            this.AddTool = new System.Windows.Forms.ToolStripButton();
            this.ChangeTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.DeliteTool = new System.Windows.Forms.ToolStripButton();
            this.FlightsDGV = new System.Windows.Forms.DataGridView();
            this.numFlightColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countPasColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price4PasColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countCrewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price4CrewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procDopColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoSS = new System.Windows.Forms.StatusStrip();
            this.CountFlightsTSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.CountPasTSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.CountCrewTSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.SumTSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb9 = new System.Windows.Forms.RadioButton();
            this.rb8 = new System.Windows.Forms.RadioButton();
            this.rb7 = new System.Windows.Forms.RadioButton();
            this.rb6 = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.sortBtn = new System.Windows.Forms.Button();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.filter_txt = new System.Windows.Forms.TextBox();
            this.more_radio = new System.Windows.Forms.RadioButton();
            this.less_radio = new System.Windows.Forms.RadioButton();
            this.expBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mainMenuMS.SuspendLayout();
            this.toolsTS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FlightsDGV)).BeginInit();
            this.infoSS.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuMS
            // 
            this.mainMenuMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Correction,
            this.About,
            this.выходToolStripMenuItem});
            this.mainMenuMS.Location = new System.Drawing.Point(0, 0);
            this.mainMenuMS.Name = "mainMenuMS";
            this.mainMenuMS.Size = new System.Drawing.Size(1377, 24);
            this.mainMenuMS.TabIndex = 0;
            this.mainMenuMS.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.экспортToolStripMenuItem});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(48, 20);
            this.File.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // экспортToolStripMenuItem
            // 
            this.экспортToolStripMenuItem.Name = "экспортToolStripMenuItem";
            this.экспортToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.экспортToolStripMenuItem.Text = "Экспорт";
            this.экспортToolStripMenuItem.Click += new System.EventHandler(this.экспортToolStripMenuItem_Click);
            // 
            // Correction
            // 
            this.Correction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMenu,
            this.ChangeMenu,
            this.toolStripSeparator1,
            this.DeliteMenu});
            this.Correction.Name = "Correction";
            this.Correction.Size = new System.Drawing.Size(59, 20);
            this.Correction.Text = "Правка";
            // 
            // AddMenu
            // 
            this.AddMenu.Name = "AddMenu";
            this.AddMenu.Size = new System.Drawing.Size(128, 22);
            this.AddMenu.Text = "Добавить";
            this.AddMenu.Click += new System.EventHandler(this.AddTool_Click);
            // 
            // ChangeMenu
            // 
            this.ChangeMenu.Enabled = false;
            this.ChangeMenu.Name = "ChangeMenu";
            this.ChangeMenu.Size = new System.Drawing.Size(128, 22);
            this.ChangeMenu.Text = "Изменить";
            this.ChangeMenu.Click += new System.EventHandler(this.ChangeTool_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(125, 6);
            // 
            // DeliteMenu
            // 
            this.DeliteMenu.Enabled = false;
            this.DeliteMenu.Name = "DeliteMenu";
            this.DeliteMenu.Size = new System.Drawing.Size(128, 22);
            this.DeliteMenu.Text = "Удалить";
            this.DeliteMenu.Click += new System.EventHandler(this.DeleteTool_Click);
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(94, 20);
            this.About.Text = "О программе";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // toolsTS
            // 
            this.toolsTS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddTool,
            this.ChangeTool,
            this.toolStripSeparator2,
            this.DeliteTool});
            this.toolsTS.Location = new System.Drawing.Point(0, 24);
            this.toolsTS.Name = "toolsTS";
            this.toolsTS.Size = new System.Drawing.Size(1377, 25);
            this.toolsTS.TabIndex = 1;
            this.toolsTS.Text = "toolStrip1";
            // 
            // AddTool
            // 
            this.AddTool.Image = global::US_5A_Net.Properties.Resources.AddTour;
            this.AddTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddTool.Name = "AddTool";
            this.AddTool.Size = new System.Drawing.Size(79, 22);
            this.AddTool.Text = "Добавить";
            this.AddTool.Click += new System.EventHandler(this.AddTool_Click);
            // 
            // ChangeTool
            // 
            this.ChangeTool.Enabled = false;
            this.ChangeTool.Image = global::US_5A_Net.Properties.Resources.EditTour_transformed;
            this.ChangeTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChangeTool.Name = "ChangeTool";
            this.ChangeTool.Size = new System.Drawing.Size(81, 22);
            this.ChangeTool.Text = "Изменить";
            this.ChangeTool.Click += new System.EventHandler(this.ChangeTool_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // DeliteTool
            // 
            this.DeliteTool.Enabled = false;
            this.DeliteTool.Image = global::US_5A_Net.Properties.Resources.pngwing_com;
            this.DeliteTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeliteTool.Name = "DeliteTool";
            this.DeliteTool.Size = new System.Drawing.Size(71, 22);
            this.DeliteTool.Text = "Удалить";
            this.DeliteTool.Click += new System.EventHandler(this.DeleteTool_Click);
            // 
            // FlightsDGV
            // 
            this.FlightsDGV.AllowUserToAddRows = false;
            this.FlightsDGV.AllowUserToDeleteRows = false;
            this.FlightsDGV.AllowUserToResizeColumns = false;
            this.FlightsDGV.AllowUserToResizeRows = false;
            this.FlightsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FlightsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numFlightColumn,
            this.typeColumn,
            this.etaColumn,
            this.countPasColumn,
            this.price4PasColumn,
            this.countCrewColumn,
            this.price4CrewColumn,
            this.procDopColumn,
            this.sumColumn});
            this.FlightsDGV.Location = new System.Drawing.Point(0, 49);
            this.FlightsDGV.MultiSelect = false;
            this.FlightsDGV.Name = "FlightsDGV";
            this.FlightsDGV.ReadOnly = true;
            dataGridViewCellStyle9.NullValue = "fgn";
            this.FlightsDGV.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.FlightsDGV.Size = new System.Drawing.Size(880, 456);
            this.FlightsDGV.TabIndex = 2;
            this.FlightsDGV.SelectionChanged += new System.EventHandler(this.FlightsDGV_SelectionChanged);
            // 
            // numFlightColumn
            // 
            this.numFlightColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numFlightColumn.DataPropertyName = "numFlight";
            dataGridViewCellStyle1.Format = "####";
            dataGridViewCellStyle1.NullValue = null;
            this.numFlightColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.numFlightColumn.HeaderText = "Номер рейса";
            this.numFlightColumn.Name = "numFlightColumn";
            this.numFlightColumn.ReadOnly = true;
            // 
            // typeColumn
            // 
            this.typeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeColumn.DataPropertyName = "Type";
            this.typeColumn.HeaderText = "Тип самолёта";
            this.typeColumn.Name = "typeColumn";
            this.typeColumn.ReadOnly = true;
            // 
            // etaColumn
            // 
            this.etaColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.etaColumn.DataPropertyName = "ETA";
            dataGridViewCellStyle2.Format = "g";
            dataGridViewCellStyle2.NullValue = null;
            this.etaColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.etaColumn.HeaderText = "Время прибытия";
            this.etaColumn.Name = "etaColumn";
            this.etaColumn.ReadOnly = true;
            // 
            // countPasColumn
            // 
            this.countPasColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.countPasColumn.DataPropertyName = "CountPas";
            dataGridViewCellStyle3.Format = "N0";
            this.countPasColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.countPasColumn.HeaderText = "Кол-во пассажиров";
            this.countPasColumn.Name = "countPasColumn";
            this.countPasColumn.ReadOnly = true;
            // 
            // price4PasColumn
            // 
            this.price4PasColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price4PasColumn.DataPropertyName = "PricePas";
            dataGridViewCellStyle4.Format = "C2";
            this.price4PasColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.price4PasColumn.HeaderText = "Сбор на пассажира";
            this.price4PasColumn.Name = "price4PasColumn";
            this.price4PasColumn.ReadOnly = true;
            // 
            // countCrewColumn
            // 
            this.countCrewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.countCrewColumn.DataPropertyName = "CountCrew";
            dataGridViewCellStyle5.Format = "N0";
            this.countCrewColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.countCrewColumn.HeaderText = "Кол-во экипажа";
            this.countCrewColumn.Name = "countCrewColumn";
            this.countCrewColumn.ReadOnly = true;
            // 
            // price4CrewColumn
            // 
            this.price4CrewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price4CrewColumn.DataPropertyName = "PriceCrew";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.price4CrewColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.price4CrewColumn.HeaderText = "Сбор на экипаж";
            this.price4CrewColumn.Name = "price4CrewColumn";
            this.price4CrewColumn.ReadOnly = true;
            // 
            // procDopColumn
            // 
            this.procDopColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.procDopColumn.DataPropertyName = "ProcDop";
            dataGridViewCellStyle7.Format = "N2";
            this.procDopColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.procDopColumn.HeaderText = "Процент надбавки";
            this.procDopColumn.Name = "procDopColumn";
            this.procDopColumn.ReadOnly = true;
            // 
            // sumColumn
            // 
            this.sumColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sumColumn.DataPropertyName = "Sum";
            dataGridViewCellStyle8.Format = "C2";
            this.sumColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.sumColumn.HeaderText = "Выручка";
            this.sumColumn.Name = "sumColumn";
            this.sumColumn.ReadOnly = true;
            // 
            // infoSS
            // 
            this.infoSS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CountFlightsTSSL,
            this.CountPasTSSL,
            this.CountCrewTSSL,
            this.SumTSSL});
            this.infoSS.Location = new System.Drawing.Point(0, 505);
            this.infoSS.Name = "infoSS";
            this.infoSS.Size = new System.Drawing.Size(1377, 22);
            this.infoSS.TabIndex = 3;
            this.infoSS.Text = "statusStrip1";
            // 
            // CountFlightsTSSL
            // 
            this.CountFlightsTSSL.Name = "CountFlightsTSSL";
            this.CountFlightsTSSL.Size = new System.Drawing.Size(97, 17);
            this.CountFlightsTSSL.Text = "Кол-во рейсов 0";
            // 
            // CountPasTSSL
            // 
            this.CountPasTSSL.Name = "CountPasTSSL";
            this.CountPasTSSL.Size = new System.Drawing.Size(117, 17);
            this.CountPasTSSL.Text = "Всего пассажиров 0";
            // 
            // CountCrewTSSL
            // 
            this.CountCrewTSSL.Name = "CountCrewTSSL";
            this.CountCrewTSSL.Size = new System.Drawing.Size(97, 17);
            this.CountCrewTSSL.Text = "Всего экипажа 0";
            // 
            // SumTSSL
            // 
            this.SumTSSL.Name = "SumTSSL";
            this.SumTSSL.Size = new System.Drawing.Size(105, 17);
            this.SumTSSL.Text = "Общая выручка 0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb9);
            this.groupBox1.Controls.Add(this.rb8);
            this.groupBox1.Controls.Add(this.rb7);
            this.groupBox1.Controls.Add(this.rb6);
            this.groupBox1.Controls.Add(this.rb5);
            this.groupBox1.Controls.Add(this.sortBtn);
            this.groupBox1.Controls.Add(this.rb4);
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Controls.Add(this.rb3);
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(907, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 314);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировать по:";
            // 
            // rb9
            // 
            this.rb9.AutoSize = true;
            this.rb9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb9.Location = new System.Drawing.Point(274, 213);
            this.rb9.Name = "rb9";
            this.rb9.Size = new System.Drawing.Size(109, 28);
            this.rb9.TabIndex = 53;
            this.rb9.TabStop = true;
            this.rb9.Text = "выручке";
            this.rb9.UseVisualStyleBackColor = true;
            // 
            // rb8
            // 
            this.rb8.AutoSize = true;
            this.rb8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb8.Location = new System.Drawing.Point(232, 126);
            this.rb8.Name = "rb8";
            this.rb8.Size = new System.Drawing.Size(220, 28);
            this.rb8.TabIndex = 52;
            this.rb8.TabStop = true;
            this.rb8.Text = "проценту надбавки";
            this.rb8.UseVisualStyleBackColor = true;
            // 
            // rb7
            // 
            this.rb7.AutoSize = true;
            this.rb7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb7.Location = new System.Drawing.Point(232, 39);
            this.rb7.Name = "rb7";
            this.rb7.Size = new System.Drawing.Size(190, 28);
            this.rb7.TabIndex = 51;
            this.rb7.TabStop = true;
            this.rb7.Text = "сбору за экипаж";
            this.rb7.UseVisualStyleBackColor = true;
            // 
            // rb6
            // 
            this.rb6.AutoSize = true;
            this.rb6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb6.Location = new System.Drawing.Point(26, 271);
            this.rb6.Name = "rb6";
            this.rb6.Size = new System.Drawing.Size(208, 28);
            this.rb6.TabIndex = 50;
            this.rb6.TabStop = true;
            this.rb6.Text = "по кол-ву экипажа";
            this.rb6.UseVisualStyleBackColor = true;
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb5.Location = new System.Drawing.Point(26, 223);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(225, 28);
            this.rb5.TabIndex = 49;
            this.rb5.TabStop = true;
            this.rb5.Text = "сбору за пассажира";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // sortBtn
            // 
            this.sortBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortBtn.Location = new System.Drawing.Point(252, 257);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(206, 57);
            this.sortBtn.TabIndex = 44;
            this.sortBtn.Text = "Сортировка";
            this.sortBtn.UseVisualStyleBackColor = false;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb4.Location = new System.Drawing.Point(26, 177);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(245, 28);
            this.rb4.TabIndex = 48;
            this.rb4.TabStop = true;
            this.rb4.Text = "по кол-ву пассажиров";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb2.Location = new System.Drawing.Point(26, 79);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(216, 28);
            this.rb2.TabIndex = 47;
            this.rb2.TabStop = true;
            this.rb2.Text = "времени прибытия";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb3.Location = new System.Drawing.Point(26, 126);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(172, 28);
            this.rb3.TabIndex = 46;
            this.rb3.TabStop = true;
            this.rb3.Text = "типу самолёта";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb1.Location = new System.Drawing.Point(26, 39);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(134, 28);
            this.rb1.TabIndex = 45;
            this.rb1.TabStop = true;
            this.rb1.Text = "коду учёта";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(918, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 24);
            this.label3.TabIndex = 51;
            this.label3.Text = "Фильтр по цене";
            // 
            // filter_txt
            // 
            this.filter_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filter_txt.Location = new System.Drawing.Point(1104, 373);
            this.filter_txt.Name = "filter_txt";
            this.filter_txt.Size = new System.Drawing.Size(99, 29);
            this.filter_txt.TabIndex = 52;
            this.filter_txt.TextChanged += new System.EventHandler(this.filter_txt_TextChanged);
            // 
            // more_radio
            // 
            this.more_radio.AutoSize = true;
            this.more_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.more_radio.Location = new System.Drawing.Point(1235, 353);
            this.more_radio.Name = "more_radio";
            this.more_radio.Size = new System.Drawing.Size(98, 28);
            this.more_radio.TabIndex = 53;
            this.more_radio.TabStop = true;
            this.more_radio.Text = "Больше";
            this.more_radio.UseVisualStyleBackColor = true;
            this.more_radio.CheckedChanged += new System.EventHandler(this.more_radio_CheckedChanged);
            // 
            // less_radio
            // 
            this.less_radio.AutoSize = true;
            this.less_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.less_radio.Location = new System.Drawing.Point(1235, 387);
            this.less_radio.Name = "less_radio";
            this.less_radio.Size = new System.Drawing.Size(102, 28);
            this.less_radio.TabIndex = 54;
            this.less_radio.TabStop = true;
            this.less_radio.Text = "Меньше";
            this.less_radio.UseVisualStyleBackColor = true;
            this.less_radio.CheckedChanged += new System.EventHandler(this.less_radio_CheckedChanged);
            // 
            // expBtn
            // 
            this.expBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.expBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expBtn.Location = new System.Drawing.Point(1018, 431);
            this.expBtn.Name = "expBtn";
            this.expBtn.Size = new System.Drawing.Size(216, 62);
            this.expBtn.TabIndex = 55;
            this.expBtn.Text = "Экспорт";
            this.expBtn.UseVisualStyleBackColor = false;
            this.expBtn.Click += new System.EventHandler(this.expBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AirportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 527);
            this.Controls.Add(this.expBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.filter_txt);
            this.Controls.Add(this.more_radio);
            this.Controls.Add(this.less_radio);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.infoSS);
            this.Controls.Add(this.FlightsDGV);
            this.Controls.Add(this.toolsTS);
            this.Controls.Add(this.mainMenuMS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuMS;
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "AirportForm";
            this.Text = "Аэропорт";
            this.mainMenuMS.ResumeLayout(false);
            this.mainMenuMS.PerformLayout();
            this.toolsTS.ResumeLayout(false);
            this.toolsTS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FlightsDGV)).EndInit();
            this.infoSS.ResumeLayout(false);
            this.infoSS.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuMS;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem Correction;
        private System.Windows.Forms.ToolStripMenuItem AddMenu;
        private System.Windows.Forms.ToolStripMenuItem ChangeMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem DeliteMenu;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ToolStrip toolsTS;
        private System.Windows.Forms.ToolStripButton AddTool;
        private System.Windows.Forms.ToolStripButton ChangeTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton DeliteTool;
        private System.Windows.Forms.DataGridView FlightsDGV;
        private System.Windows.Forms.StatusStrip infoSS;
        private System.Windows.Forms.ToolStripStatusLabel CountFlightsTSSL;
        private System.Windows.Forms.ToolStripStatusLabel SumTSSL;
        private System.Windows.Forms.ToolStripStatusLabel CountPasTSSL;
        private System.Windows.Forms.ToolStripStatusLabel CountCrewTSSL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox filter_txt;
        private System.Windows.Forms.RadioButton more_radio;
        private System.Windows.Forms.RadioButton less_radio;
        private System.Windows.Forms.Button expBtn;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn numFlightColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countPasColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn price4PasColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countCrewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn price4CrewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procDopColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumColumn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton rb9;
        private System.Windows.Forms.RadioButton rb8;
        private System.Windows.Forms.RadioButton rb7;
        private System.Windows.Forms.RadioButton rb6;
    }
}

