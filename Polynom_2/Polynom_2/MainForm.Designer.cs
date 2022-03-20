namespace WindowsFormsApp
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rtbResPolynom = new System.Windows.Forms.RichTextBox();
            this.allZeroesFunction = new System.Windows.Forms.Button();
            this.allOnesFunction = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.grbFunction = new System.Windows.Forms.GroupBox();
            this.dgvBulFunction = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countBulChanges = new System.Windows.Forms.NumericUpDown();
            this.grbFunctionOneZero = new System.Windows.Forms.GroupBox();
            this.allQuestionsFunction = new System.Windows.Forms.Button();
            this.grbVector = new System.Windows.Forms.GroupBox();
            this.dgvVector = new System.Windows.Forms.DataGridView();
            this.Clean = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.grbSaveCleanExit = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.довідкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnBuildPolynom = new System.Windows.Forms.Button();
            this.grbVectorOneZero = new System.Windows.Forms.GroupBox();
            this.allQuestionsVector = new System.Windows.Forms.Button();
            this.allOnesVector = new System.Windows.Forms.Button();
            this.allZeroesVector = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelForText = new System.Windows.Forms.Panel();
            this.pnlCountChanges = new System.Windows.Forms.Panel();
            this.grbMinimizationCriterion = new System.Windows.Forms.GroupBox();
            this.radioBtnTheLeastCountChanges = new System.Windows.Forms.RadioButton();
            this.radioBtnTheLeastCountAdditions = new System.Windows.Forms.RadioButton();
            this.radioBtnTheLeastCountOperations = new System.Windows.Forms.RadioButton();
            this.grbFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBulFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countBulChanges)).BeginInit();
            this.grbFunctionOneZero.SuspendLayout();
            this.grbVector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVector)).BeginInit();
            this.grbSaveCleanExit.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grbVectorOneZero.SuspendLayout();
            this.panelForText.SuspendLayout();
            this.pnlCountChanges.SuspendLayout();
            this.grbMinimizationCriterion.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbResPolynom
            // 
            this.rtbResPolynom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbResPolynom.BackColor = System.Drawing.Color.White;
            this.rtbResPolynom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbResPolynom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtbResPolynom.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbResPolynom.ForeColor = System.Drawing.Color.Black;
            this.rtbResPolynom.Location = new System.Drawing.Point(21, 2);
            this.rtbResPolynom.Margin = new System.Windows.Forms.Padding(0);
            this.rtbResPolynom.Name = "rtbResPolynom";
            this.rtbResPolynom.ReadOnly = true;
            this.rtbResPolynom.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbResPolynom.Size = new System.Drawing.Size(428, 132);
            this.rtbResPolynom.TabIndex = 8;
            this.rtbResPolynom.Text = "   ";
            // 
            // allZeroesFunction
            // 
            this.allZeroesFunction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allZeroesFunction.FlatAppearance.BorderSize = 0;
            this.allZeroesFunction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allZeroesFunction.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.allZeroesFunction.ForeColor = System.Drawing.Color.Black;
            this.allZeroesFunction.Location = new System.Drawing.Point(6, 24);
            this.allZeroesFunction.Name = "allZeroesFunction";
            this.allZeroesFunction.Size = new System.Drawing.Size(88, 33);
            this.allZeroesFunction.TabIndex = 9;
            this.allZeroesFunction.Text = "Всюди \'0\'";
            this.allZeroesFunction.UseVisualStyleBackColor = true;
            this.allZeroesFunction.Click += new System.EventHandler(this.AllZeroesFunction_Click);
            this.allZeroesFunction.Paint += new System.Windows.Forms.PaintEventHandler(this.allZeroesFunction_Paint);
            // 
            // allOnesFunction
            // 
            this.allOnesFunction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allOnesFunction.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.allOnesFunction.FlatAppearance.BorderSize = 0;
            this.allOnesFunction.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.allOnesFunction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allOnesFunction.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.allOnesFunction.ForeColor = System.Drawing.Color.Black;
            this.allOnesFunction.Location = new System.Drawing.Point(100, 25);
            this.allOnesFunction.Name = "allOnesFunction";
            this.allOnesFunction.Size = new System.Drawing.Size(79, 32);
            this.allOnesFunction.TabIndex = 10;
            this.allOnesFunction.Text = "Всюди \'1\'";
            this.allOnesFunction.UseVisualStyleBackColor = true;
            this.allOnesFunction.Click += new System.EventHandler(this.AllOnesFunction_Click);
            this.allOnesFunction.Paint += new System.Windows.Forms.PaintEventHandler(this.allOnesFunction_Paint);
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCount.AutoSize = true;
            this.lblCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCount.Font = new System.Drawing.Font("Verdana", 9.67F, System.Drawing.FontStyle.Bold);
            this.lblCount.ForeColor = System.Drawing.Color.Black;
            this.lblCount.Location = new System.Drawing.Point(6, 10);
            this.lblCount.Margin = new System.Windows.Forms.Padding(0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(204, 16);
            this.lblCount.TabIndex = 11;
            this.lblCount.Text = "Кількість булевих змінних";
            // 
            // grbFunction
            // 
            this.grbFunction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbFunction.Controls.Add(this.dgvBulFunction);
            this.grbFunction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbFunction.Font = new System.Drawing.Font("Verdana", 9.67F, System.Drawing.FontStyle.Bold);
            this.grbFunction.ForeColor = System.Drawing.Color.Black;
            this.grbFunction.Location = new System.Drawing.Point(14, 76);
            this.grbFunction.Name = "grbFunction";
            this.grbFunction.Size = new System.Drawing.Size(274, 403);
            this.grbFunction.TabIndex = 13;
            this.grbFunction.TabStop = false;
            this.grbFunction.Text = "Таблиця істинності функції";
            this.grbFunction.Paint += new System.Windows.Forms.PaintEventHandler(this.GRBFunction_Paint);
            // 
            // dgvBulFunction
            // 
            this.dgvBulFunction.AllowUserToAddRows = false;
            this.dgvBulFunction.AllowUserToDeleteRows = false;
            this.dgvBulFunction.AllowUserToResizeColumns = false;
            this.dgvBulFunction.AllowUserToResizeRows = false;
            this.dgvBulFunction.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvBulFunction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBulFunction.ColumnHeadersHeight = 21;
            this.dgvBulFunction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBulFunction.ColumnHeadersVisible = false;
            this.dgvBulFunction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvBulFunction.Location = new System.Drawing.Point(15, 27);
            this.dgvBulFunction.Name = "dgvBulFunction";
            this.dgvBulFunction.ReadOnly = true;
            this.dgvBulFunction.RowHeadersVisible = false;
            this.dgvBulFunction.RowHeadersWidth = 20;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvBulFunction.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvBulFunction.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvBulFunction.RowTemplate.Height = 21;
            this.dgvBulFunction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBulFunction.Size = new System.Drawing.Size(45, 45);
            this.dgvBulFunction.TabIndex = 0;
            this.dgvBulFunction.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVBulFunction_CellClick);
            // 
            // Column1
            // 
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle10;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 5;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 5;
            // 
            // countBulChanges
            // 
            this.countBulChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.countBulChanges.BackColor = System.Drawing.Color.White;
            this.countBulChanges.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countBulChanges.ForeColor = System.Drawing.Color.Black;
            this.countBulChanges.Location = new System.Drawing.Point(224, 8);
            this.countBulChanges.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.countBulChanges.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.countBulChanges.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countBulChanges.Name = "countBulChanges";
            this.countBulChanges.ReadOnly = true;
            this.countBulChanges.Size = new System.Drawing.Size(37, 22);
            this.countBulChanges.TabIndex = 2;
            this.countBulChanges.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countBulChanges.ValueChanged += new System.EventHandler(this.BuildFunctionAndVector_ValueChanged);
            // 
            // grbFunctionOneZero
            // 
            this.grbFunctionOneZero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbFunctionOneZero.Controls.Add(this.allQuestionsFunction);
            this.grbFunctionOneZero.Controls.Add(this.allOnesFunction);
            this.grbFunctionOneZero.Controls.Add(this.allZeroesFunction);
            this.grbFunctionOneZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbFunctionOneZero.Font = new System.Drawing.Font("Verdana", 9.67F, System.Drawing.FontStyle.Bold);
            this.grbFunctionOneZero.ForeColor = System.Drawing.Color.Black;
            this.grbFunctionOneZero.Location = new System.Drawing.Point(14, 485);
            this.grbFunctionOneZero.Name = "grbFunctionOneZero";
            this.grbFunctionOneZero.Size = new System.Drawing.Size(274, 73);
            this.grbFunctionOneZero.TabIndex = 14;
            this.grbFunctionOneZero.TabStop = false;
            this.grbFunctionOneZero.Text = "Швидкий ввід функції";
            this.grbFunctionOneZero.Paint += new System.Windows.Forms.PaintEventHandler(this.GRBFunctionOneZero_Paint);
            // 
            // allQuestionsFunction
            // 
            this.allQuestionsFunction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allQuestionsFunction.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.allQuestionsFunction.FlatAppearance.BorderSize = 0;
            this.allQuestionsFunction.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.allQuestionsFunction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allQuestionsFunction.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.allQuestionsFunction.ForeColor = System.Drawing.Color.Black;
            this.allQuestionsFunction.Location = new System.Drawing.Point(185, 24);
            this.allQuestionsFunction.Name = "allQuestionsFunction";
            this.allQuestionsFunction.Size = new System.Drawing.Size(83, 33);
            this.allQuestionsFunction.TabIndex = 11;
            this.allQuestionsFunction.Text = "Всюди \'?\'";
            this.allQuestionsFunction.UseVisualStyleBackColor = true;
            this.allQuestionsFunction.Click += new System.EventHandler(this.allQuestionsFunction_Click);
            this.allQuestionsFunction.Paint += new System.Windows.Forms.PaintEventHandler(this.allOnesFunction_Paint);
            // 
            // grbVector
            // 
            this.grbVector.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbVector.Controls.Add(this.dgvVector);
            this.grbVector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbVector.Font = new System.Drawing.Font("Verdana", 9.67F, System.Drawing.FontStyle.Bold);
            this.grbVector.ForeColor = System.Drawing.Color.Black;
            this.grbVector.Location = new System.Drawing.Point(302, 33);
            this.grbVector.Margin = new System.Windows.Forms.Padding(0);
            this.grbVector.Name = "grbVector";
            this.grbVector.Padding = new System.Windows.Forms.Padding(0);
            this.grbVector.Size = new System.Drawing.Size(449, 94);
            this.grbVector.TabIndex = 15;
            this.grbVector.TabStop = false;
            this.grbVector.Text = "Вектор поляризації";
            this.grbVector.Paint += new System.Windows.Forms.PaintEventHandler(this.GRBVector_Paint);
            // 
            // dgvVector
            // 
            this.dgvVector.AllowUserToAddRows = false;
            this.dgvVector.AllowUserToDeleteRows = false;
            this.dgvVector.AllowUserToResizeColumns = false;
            this.dgvVector.AllowUserToResizeRows = false;
            this.dgvVector.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVector.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVector.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvVector.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvVector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVector.ColumnHeadersVisible = false;
            this.dgvVector.Location = new System.Drawing.Point(15, 30);
            this.dgvVector.Name = "dgvVector";
            this.dgvVector.ReadOnly = true;
            this.dgvVector.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVector.RowHeadersVisible = false;
            this.dgvVector.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.dgvVector.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvVector.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvVector.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvVector.RowTemplate.Height = 20;
            this.dgvVector.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvVector.Size = new System.Drawing.Size(24, 46);
            this.dgvVector.TabIndex = 0;
            this.dgvVector.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVVector_CellClick);
            // 
            // Clean
            // 
            this.Clean.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Clean.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Clean.FlatAppearance.BorderSize = 0;
            this.Clean.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.Clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clean.Font = new System.Drawing.Font("Verdana", 9.67F, System.Drawing.FontStyle.Bold);
            this.Clean.ForeColor = System.Drawing.Color.Black;
            this.Clean.Location = new System.Drawing.Point(170, 16);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(109, 34);
            this.Clean.TabIndex = 17;
            this.Clean.Text = "Очистка";
            this.Clean.UseVisualStyleBackColor = true;
            this.Clean.Click += new System.EventHandler(this.Clean_Click);
            this.Clean.Paint += new System.Windows.Forms.PaintEventHandler(this.Clean_Paint);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Verdana", 9.67F, System.Drawing.FontStyle.Bold);
            this.Exit.ForeColor = System.Drawing.Color.Black;
            this.Exit.Location = new System.Drawing.Point(310, 16);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(109, 34);
            this.Exit.TabIndex = 18;
            this.Exit.Text = "Вихід";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.Paint += new System.Windows.Forms.PaintEventHandler(this.Exit_Paint);
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Verdana", 9.67F, System.Drawing.FontStyle.Bold);
            this.Save.ForeColor = System.Drawing.Color.Black;
            this.Save.Location = new System.Drawing.Point(30, 16);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(109, 34);
            this.Save.TabIndex = 19;
            this.Save.Text = "Зберегти";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            this.Save.Paint += new System.Windows.Forms.PaintEventHandler(this.Save_Paint);
            // 
            // grbSaveCleanExit
            // 
            this.grbSaveCleanExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbSaveCleanExit.Controls.Add(this.Exit);
            this.grbSaveCleanExit.Controls.Add(this.Save);
            this.grbSaveCleanExit.Controls.Add(this.Clean);
            this.grbSaveCleanExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbSaveCleanExit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.grbSaveCleanExit.Location = new System.Drawing.Point(302, 493);
            this.grbSaveCleanExit.Name = "grbSaveCleanExit";
            this.grbSaveCleanExit.Size = new System.Drawing.Size(449, 65);
            this.grbSaveCleanExit.TabIndex = 20;
            this.grbSaveCleanExit.TabStop = false;
            this.grbSaveCleanExit.Paint += new System.Windows.Forms.PaintEventHandler(this.GRBSaveCleanExit_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.довідкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(766, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зберегтиToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.9F);
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripMenuItem1.Margin = new System.Windows.Forms.Padding(0, 0, 0, -1);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItem1.Text = "Файл";
            this.toolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // зберегтиToolStripMenuItem
            // 
            this.зберегтиToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.зберегтиToolStripMenuItem.CheckOnClick = true;
            this.зберегтиToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.9F);
            this.зберегтиToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.зберегтиToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            this.зберегтиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.зберегтиToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.зберегтиToolStripMenuItem.Text = "Зберегти   ";
            this.зберегтиToolStripMenuItem.Click += new System.EventHandler(this.Save_Click);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.вихідToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.9F);
            this.вихідToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.Exit_Click);
            // 
            // довідкаToolStripMenuItem
            // 
            this.довідкаToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.довідкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutProgramTSMI});
            this.довідкаToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.9F);
            this.довідкаToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.довідкаToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.довідкаToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, -1);
            this.довідкаToolStripMenuItem.Name = "довідкаToolStripMenuItem";
            this.довідкаToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.довідкаToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.довідкаToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
            this.довідкаToolStripMenuItem.Text = "Довідка";
            this.довідкаToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // aboutProgramTSMI
            // 
            this.aboutProgramTSMI.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.aboutProgramTSMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.9F);
            this.aboutProgramTSMI.ForeColor = System.Drawing.Color.Black;
            this.aboutProgramTSMI.ImageTransparentColor = System.Drawing.Color.White;
            this.aboutProgramTSMI.Name = "aboutProgramTSMI";
            this.aboutProgramTSMI.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutProgramTSMI.Size = new System.Drawing.Size(164, 22);
            this.aboutProgramTSMI.Text = "Про програму";
            this.aboutProgramTSMI.Click += new System.EventHandler(this.AboutProgramTSMI_Click);
            // 
            // BtnBuildPolynom
            // 
            this.BtnBuildPolynom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuildPolynom.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBuildPolynom.FlatAppearance.BorderSize = 0;
            this.BtnBuildPolynom.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnBuildPolynom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuildPolynom.Font = new System.Drawing.Font("Verdana", 9.67F, System.Drawing.FontStyle.Bold);
            this.BtnBuildPolynom.ForeColor = System.Drawing.Color.Black;
            this.BtnBuildPolynom.Location = new System.Drawing.Point(302, 308);
            this.BtnBuildPolynom.Name = "BtnBuildPolynom";
            this.BtnBuildPolynom.Padding = new System.Windows.Forms.Padding(3);
            this.BtnBuildPolynom.Size = new System.Drawing.Size(449, 34);
            this.BtnBuildPolynom.TabIndex = 6;
            this.BtnBuildPolynom.Text = "Мінімізувати функцію в класі ППРМ";
            this.BtnBuildPolynom.UseVisualStyleBackColor = true;
            this.BtnBuildPolynom.Click += new System.EventHandler(this.BtnBuildPolynom_Click);
            this.BtnBuildPolynom.Paint += new System.Windows.Forms.PaintEventHandler(this.BtnBuildPolynom_Paint);
            this.BtnBuildPolynom.MouseHover += new System.EventHandler(this.BtnBuildPolynom_MouseHover);
            // 
            // grbVectorOneZero
            // 
            this.grbVectorOneZero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbVectorOneZero.Controls.Add(this.allQuestionsVector);
            this.grbVectorOneZero.Controls.Add(this.allOnesVector);
            this.grbVectorOneZero.Controls.Add(this.allZeroesVector);
            this.grbVectorOneZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbVectorOneZero.Font = new System.Drawing.Font("Verdana", 9.67F, System.Drawing.FontStyle.Bold);
            this.grbVectorOneZero.ForeColor = System.Drawing.Color.Black;
            this.grbVectorOneZero.Location = new System.Drawing.Point(302, 132);
            this.grbVectorOneZero.Name = "grbVectorOneZero";
            this.grbVectorOneZero.Size = new System.Drawing.Size(449, 79);
            this.grbVectorOneZero.TabIndex = 16;
            this.grbVectorOneZero.TabStop = false;
            this.grbVectorOneZero.Text = "Швидкий ввід вектора поляризації";
            this.grbVectorOneZero.Paint += new System.Windows.Forms.PaintEventHandler(this.GRBVectorOneZero_Paint);
            // 
            // allQuestionsVector
            // 
            this.allQuestionsVector.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allQuestionsVector.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.allQuestionsVector.FlatAppearance.BorderSize = 0;
            this.allQuestionsVector.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.allQuestionsVector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allQuestionsVector.Font = new System.Drawing.Font("Verdana", 9.67F, System.Drawing.FontStyle.Bold);
            this.allQuestionsVector.ForeColor = System.Drawing.Color.Black;
            this.allQuestionsVector.Location = new System.Drawing.Point(310, 30);
            this.allQuestionsVector.Name = "allQuestionsVector";
            this.allQuestionsVector.Size = new System.Drawing.Size(117, 35);
            this.allQuestionsVector.TabIndex = 6;
            this.allQuestionsVector.Text = "Всюди \'?\'";
            this.allQuestionsVector.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.allQuestionsVector.UseVisualStyleBackColor = true;
            this.allQuestionsVector.Click += new System.EventHandler(this.AllQuestionsVector_Click);
            this.allQuestionsVector.Paint += new System.Windows.Forms.PaintEventHandler(this.allQuestionsVector_Paint);
            // 
            // allOnesVector
            // 
            this.allOnesVector.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allOnesVector.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.allOnesVector.FlatAppearance.BorderSize = 0;
            this.allOnesVector.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.allOnesVector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allOnesVector.Font = new System.Drawing.Font("Verdana", 9.67F, System.Drawing.FontStyle.Bold);
            this.allOnesVector.ForeColor = System.Drawing.Color.Black;
            this.allOnesVector.Location = new System.Drawing.Point(170, 30);
            this.allOnesVector.Name = "allOnesVector";
            this.allOnesVector.Size = new System.Drawing.Size(117, 35);
            this.allOnesVector.TabIndex = 5;
            this.allOnesVector.Text = "Всюди \'1\'";
            this.allOnesVector.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.allOnesVector.UseVisualStyleBackColor = true;
            this.allOnesVector.Click += new System.EventHandler(this.AllOnesVector_Click);
            this.allOnesVector.Paint += new System.Windows.Forms.PaintEventHandler(this.allOnesVector_Paint);
            // 
            // allZeroesVector
            // 
            this.allZeroesVector.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allZeroesVector.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.allZeroesVector.FlatAppearance.BorderSize = 0;
            this.allZeroesVector.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.allZeroesVector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allZeroesVector.Font = new System.Drawing.Font("Verdana", 9.67F, System.Drawing.FontStyle.Bold);
            this.allZeroesVector.ForeColor = System.Drawing.Color.Black;
            this.allZeroesVector.Location = new System.Drawing.Point(30, 30);
            this.allZeroesVector.Name = "allZeroesVector";
            this.allZeroesVector.Size = new System.Drawing.Size(117, 35);
            this.allZeroesVector.TabIndex = 4;
            this.allZeroesVector.Text = "Всюди \'0\'";
            this.allZeroesVector.UseVisualStyleBackColor = true;
            this.allZeroesVector.Click += new System.EventHandler(this.AllZeroesVector_Click);
            this.allZeroesVector.Paint += new System.Windows.Forms.PaintEventHandler(this.allZeroesVector_Paint);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.OverwritePrompt = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panelForText
            // 
            this.panelForText.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panelForText.AutoScroll = true;
            this.panelForText.AutoScrollMinSize = new System.Drawing.Size(3, 3);
            this.panelForText.AutoSize = true;
            this.panelForText.BackColor = System.Drawing.Color.White;
            this.panelForText.Controls.Add(this.rtbResPolynom);
            this.panelForText.Location = new System.Drawing.Point(302, 345);
            this.panelForText.Name = "panelForText";
            this.panelForText.Size = new System.Drawing.Size(449, 134);
            this.panelForText.TabIndex = 24;
            this.panelForText.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelForText_Paint);
            // 
            // pnlCountChanges
            // 
            this.pnlCountChanges.Controls.Add(this.countBulChanges);
            this.pnlCountChanges.Controls.Add(this.lblCount);
            this.pnlCountChanges.Location = new System.Drawing.Point(14, 33);
            this.pnlCountChanges.Name = "pnlCountChanges";
            this.pnlCountChanges.Size = new System.Drawing.Size(274, 37);
            this.pnlCountChanges.TabIndex = 12;
            this.pnlCountChanges.Paint += new System.Windows.Forms.PaintEventHandler(this.PNLCountChanges_Paint);
            // 
            // grbMinimizationCriterion
            // 
            this.grbMinimizationCriterion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbMinimizationCriterion.Controls.Add(this.radioBtnTheLeastCountChanges);
            this.grbMinimizationCriterion.Controls.Add(this.radioBtnTheLeastCountAdditions);
            this.grbMinimizationCriterion.Controls.Add(this.radioBtnTheLeastCountOperations);
            this.grbMinimizationCriterion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbMinimizationCriterion.Font = new System.Drawing.Font("Verdana", 9.67F, System.Drawing.FontStyle.Bold);
            this.grbMinimizationCriterion.ForeColor = System.Drawing.Color.Black;
            this.grbMinimizationCriterion.Location = new System.Drawing.Point(302, 221);
            this.grbMinimizationCriterion.Name = "grbMinimizationCriterion";
            this.grbMinimizationCriterion.Size = new System.Drawing.Size(449, 84);
            this.grbMinimizationCriterion.TabIndex = 25;
            this.grbMinimizationCriterion.TabStop = false;
            this.grbMinimizationCriterion.Text = "Критерій мінімізації";
            // 
            // radioBtnTheLeastCountChanges
            // 
            this.radioBtnTheLeastCountChanges.AutoSize = true;
            this.radioBtnTheLeastCountChanges.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.radioBtnTheLeastCountChanges.Location = new System.Drawing.Point(6, 62);
            this.radioBtnTheLeastCountChanges.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnTheLeastCountChanges.Name = "radioBtnTheLeastCountChanges";
            this.radioBtnTheLeastCountChanges.Size = new System.Drawing.Size(353, 17);
            this.radioBtnTheLeastCountChanges.TabIndex = 2;
            this.radioBtnTheLeastCountChanges.Text = "найменша кількість входжень змінних в поліном";
            this.radioBtnTheLeastCountChanges.UseVisualStyleBackColor = true;
            this.radioBtnTheLeastCountChanges.Click += new System.EventHandler(this.radioBtnTheLeastCountChanges_Click);
            // 
            // radioBtnTheLeastCountAdditions
            // 
            this.radioBtnTheLeastCountAdditions.AutoSize = true;
            this.radioBtnTheLeastCountAdditions.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.radioBtnTheLeastCountAdditions.Location = new System.Drawing.Point(6, 43);
            this.radioBtnTheLeastCountAdditions.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnTheLeastCountAdditions.Name = "radioBtnTheLeastCountAdditions";
            this.radioBtnTheLeastCountAdditions.Size = new System.Drawing.Size(295, 17);
            this.radioBtnTheLeastCountAdditions.TabIndex = 1;
            this.radioBtnTheLeastCountAdditions.Text = "найменша кількість доданків в поліномі";
            this.radioBtnTheLeastCountAdditions.UseVisualStyleBackColor = true;
            this.radioBtnTheLeastCountAdditions.Click += new System.EventHandler(this.radioBtnTheLeastCountAdditions_Click);
            // 
            // radioBtnTheLeastCountOperations
            // 
            this.radioBtnTheLeastCountOperations.AutoSize = true;
            this.radioBtnTheLeastCountOperations.Checked = true;
            this.radioBtnTheLeastCountOperations.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.radioBtnTheLeastCountOperations.Location = new System.Drawing.Point(6, 22);
            this.radioBtnTheLeastCountOperations.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnTheLeastCountOperations.Name = "radioBtnTheLeastCountOperations";
            this.radioBtnTheLeastCountOperations.Size = new System.Drawing.Size(293, 17);
            this.radioBtnTheLeastCountOperations.TabIndex = 0;
            this.radioBtnTheLeastCountOperations.TabStop = true;
            this.radioBtnTheLeastCountOperations.Text = "найменша кількість операцій в поліномі";
            this.radioBtnTheLeastCountOperations.UseVisualStyleBackColor = true;
            this.radioBtnTheLeastCountOperations.Click += new System.EventHandler(this.radioBtnTheLeastCountOperations_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(766, 571);
            this.Controls.Add(this.grbMinimizationCriterion);
            this.Controls.Add(this.pnlCountChanges);
            this.Controls.Add(this.panelForText);
            this.Controls.Add(this.grbVector);
            this.Controls.Add(this.grbFunctionOneZero);
            this.Controls.Add(this.grbVectorOneZero);
            this.Controls.Add(this.grbSaveCleanExit);
            this.Controls.Add(this.grbFunction);
            this.Controls.Add(this.BtnBuildPolynom);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Різнокритеріальна мінімізація повністю та частково визначених булевих функцій в к" +
    "ласі ППРМ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grbFunction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBulFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countBulChanges)).EndInit();
            this.grbFunctionOneZero.ResumeLayout(false);
            this.grbVector.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVector)).EndInit();
            this.grbSaveCleanExit.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbVectorOneZero.ResumeLayout(false);
            this.panelForText.ResumeLayout(false);
            this.pnlCountChanges.ResumeLayout(false);
            this.pnlCountChanges.PerformLayout();
            this.grbMinimizationCriterion.ResumeLayout(false);
            this.grbMinimizationCriterion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button allZeroesFunction;
        private System.Windows.Forms.Button allOnesFunction;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.GroupBox grbFunction;
        private System.Windows.Forms.GroupBox grbFunctionOneZero;
        private System.Windows.Forms.GroupBox grbVector;
        private System.Windows.Forms.Button Clean;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.GroupBox grbSaveCleanExit;
        private System.Windows.Forms.DataGridView dgvVector;
        private System.Windows.Forms.DataGridView dgvBulFunction;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem зберегтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem довідкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramTSMI;
        private System.Windows.Forms.Button BtnBuildPolynom;
        private System.Windows.Forms.NumericUpDown countBulChanges;
        private System.Windows.Forms.GroupBox grbVectorOneZero;
        private System.Windows.Forms.Button allOnesVector;
        private System.Windows.Forms.Button allZeroesVector;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox rtbResPolynom;
        private System.Windows.Forms.Panel panelForText;
        private System.Windows.Forms.Panel pnlCountChanges;
        private System.Windows.Forms.Button allQuestionsVector;
        private System.Windows.Forms.GroupBox grbMinimizationCriterion;
        private System.Windows.Forms.RadioButton radioBtnTheLeastCountChanges;
        private System.Windows.Forms.RadioButton radioBtnTheLeastCountAdditions;
        private System.Windows.Forms.RadioButton radioBtnTheLeastCountOperations;
        private System.Windows.Forms.Button allQuestionsFunction;
    }
}

