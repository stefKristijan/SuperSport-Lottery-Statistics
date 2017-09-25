namespace SuperSport_Loto_Statistika
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.dgvStats = new System.Windows.Forms.DataGridView();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvLottery = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbAll = new System.Windows.Forms.Label();
            this.lbCurrent = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pbRefresh = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPairs = new System.Windows.Forms.Button();
            this.btnTens = new System.Windows.Forms.Button();
            this.btnDraws = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dgvMostFrequent = new System.Windows.Forms.DataGridView();
            this.dgvPairs = new System.Windows.Forms.DataGridView();
            this.drawn_notDrawn1 = new SuperSport_Loto_Statistika.Drawn_notDrawn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLottery)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostFrequent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPairs)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(-12, -7);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(96, 65);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Visible = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 1, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(850, 455);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCalculate.FlatAppearance.BorderSize = 0;
            this.btnCalculate.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCalculate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCalculate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(140, 0);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(140, 32);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Statistika po broju";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // dgvStats
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvStats.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStats.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStats.BackgroundColor = System.Drawing.Color.White;
            this.dgvStats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStats.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStats.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 2, 2, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStats.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStats.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStats.GridColor = System.Drawing.Color.White;
            this.dgvStats.Location = new System.Drawing.Point(0, 0);
            this.dgvStats.Name = "dgvStats";
            this.dgvStats.RowHeadersVisible = false;
            this.dgvStats.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStats.RowTemplate.ReadOnly = true;
            this.dgvStats.Size = new System.Drawing.Size(850, 455);
            this.dgvStats.TabIndex = 10;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGenerate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGenerate.FlatAppearance.BorderSize = 2;
            this.btnGenerate.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnGenerate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(700, 0);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(150, 32);
            this.btnGenerate.TabIndex = 17;
            this.btnGenerate.Text = "Generiraj brojeve";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvLottery);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 555);
            this.panel1.TabIndex = 18;
            // 
            // dgvLottery
            // 
            this.dgvLottery.AllowUserToAddRows = false;
            this.dgvLottery.AllowUserToDeleteRows = false;
            this.dgvLottery.AllowUserToResizeColumns = false;
            this.dgvLottery.AllowUserToResizeRows = false;
            this.dgvLottery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLottery.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dgvLottery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLottery.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLottery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLottery.ColumnHeadersVisible = false;
            this.dgvLottery.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2, 1, 0, 1);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(215)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLottery.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLottery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLottery.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLottery.Location = new System.Drawing.Point(0, 100);
            this.dgvLottery.MultiSelect = false;
            this.dgvLottery.Name = "dgvLottery";
            this.dgvLottery.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLottery.RowHeadersVisible = false;
            this.dgvLottery.RowHeadersWidth = 170;
            this.dgvLottery.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLottery.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvLottery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvLottery.Size = new System.Drawing.Size(177, 455);
            this.dgvLottery.TabIndex = 3;
            this.dgvLottery.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLottery_CellClick);
            this.dgvLottery.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLottery_CellMouseEnter);
            this.dgvLottery.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLottery_CellMouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.webBrowser1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 100);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // lbAll
            // 
            this.lbAll.AutoSize = true;
            this.lbAll.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAll.ForeColor = System.Drawing.Color.White;
            this.lbAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbAll.Location = new System.Drawing.Point(830, 18);
            this.lbAll.Name = "lbAll";
            this.lbAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbAll.Size = new System.Drawing.Size(14, 14);
            this.lbAll.TabIndex = 20;
            this.lbAll.Text = "0";
            this.lbAll.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbAll.Visible = false;
            // 
            // lbCurrent
            // 
            this.lbCurrent.AutoSize = true;
            this.lbCurrent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrent.ForeColor = System.Drawing.Color.White;
            this.lbCurrent.Location = new System.Drawing.Point(352, 18);
            this.lbCurrent.Name = "lbCurrent";
            this.lbCurrent.Size = new System.Drawing.Size(14, 14);
            this.lbCurrent.TabIndex = 22;
            this.lbCurrent.Text = "0";
            this.lbCurrent.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(426, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 14);
            this.label2.TabIndex = 19;
            this.label2.Text = " 1";
            this.label2.Visible = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.trackBar1.Location = new System.Drawing.Point(420, 0);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(430, 35);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 1;
            this.trackBar1.Visible = false;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(295, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 14);
            this.label1.TabIndex = 21;
            this.label1.Text = "Broj prikazanih kola:";
            this.label1.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.pbRefresh);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.pbClose);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(177, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(850, 33);
            this.panel5.TabIndex = 19;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(685, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Osvježi rezultate";
            this.label5.Visible = false;
            // 
            // pbRefresh
            // 
            this.pbRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbRefresh.Image = global::SuperSport_Loto_Statistika.Properties.Resources.prviRefresh;
            this.pbRefresh.Location = new System.Drawing.Point(764, 0);
            this.pbRefresh.Name = "pbRefresh";
            this.pbRefresh.Size = new System.Drawing.Size(43, 33);
            this.pbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRefresh.TabIndex = 23;
            this.pbRefresh.TabStop = false;
            this.pbRefresh.Click += new System.EventHandler(this.pbRefresh_Click);
            this.pbRefresh.MouseEnter += new System.EventHandler(this.pbRefresh_MouseEnter);
            this.pbRefresh.MouseLeave += new System.EventHandler(this.pbRefresh_MouseLeave);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(295, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "SuperSport Loto Statistika";
            // 
            // pbClose
            // 
            this.pbClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(807, 0);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(43, 33);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 0;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            this.pbClose.MouseEnter += new System.EventHandler(this.pbClose_MouseEnter);
            this.pbClose.MouseLeave += new System.EventHandler(this.pbClose_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(801, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Zatvori";
            this.label4.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.panel6.Controls.Add(this.lbAll);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.lbName);
            this.panel6.Controls.Add(this.lbCurrent);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.trackBar1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(177, 33);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(850, 35);
            this.panel6.TabIndex = 20;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseDown);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(0, 0);
            this.lbName.MaximumSize = new System.Drawing.Size(290, 30);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 18);
            this.lbName.TabIndex = 22;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(6)))), ((int)(((byte)(7)))));
            this.panel7.Controls.Add(this.btnGenerate);
            this.panel7.Controls.Add(this.button1);
            this.panel7.Controls.Add(this.btnPairs);
            this.panel7.Controls.Add(this.btnTens);
            this.panel7.Controls.Add(this.btnCalculate);
            this.panel7.Controls.Add(this.btnDraws);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(177, 68);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(850, 32);
            this.panel7.TabIndex = 21;
            this.panel7.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(560, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 32);
            this.button1.TabIndex = 21;
            this.button1.Text = "Postotak izvlačenja";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPairs
            // 
            this.btnPairs.BackColor = System.Drawing.Color.Transparent;
            this.btnPairs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPairs.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPairs.FlatAppearance.BorderSize = 0;
            this.btnPairs.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnPairs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPairs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnPairs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPairs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPairs.ForeColor = System.Drawing.Color.White;
            this.btnPairs.Location = new System.Drawing.Point(420, 0);
            this.btnPairs.Name = "btnPairs";
            this.btnPairs.Size = new System.Drawing.Size(140, 32);
            this.btnPairs.TabIndex = 20;
            this.btnPairs.Text = "Izračunaj parove";
            this.btnPairs.UseVisualStyleBackColor = false;
            this.btnPairs.Click += new System.EventHandler(this.btnPairs_Click);
            // 
            // btnTens
            // 
            this.btnTens.BackColor = System.Drawing.Color.Transparent;
            this.btnTens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTens.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTens.FlatAppearance.BorderSize = 0;
            this.btnTens.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnTens.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTens.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnTens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTens.ForeColor = System.Drawing.Color.White;
            this.btnTens.Location = new System.Drawing.Point(280, 0);
            this.btnTens.Name = "btnTens";
            this.btnTens.Size = new System.Drawing.Size(140, 32);
            this.btnTens.TabIndex = 18;
            this.btnTens.Text = "Statistika desetica";
            this.btnTens.UseVisualStyleBackColor = false;
            this.btnTens.Click += new System.EventHandler(this.btnTens_Click);
            // 
            // btnDraws
            // 
            this.btnDraws.BackColor = System.Drawing.Color.Transparent;
            this.btnDraws.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDraws.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDraws.FlatAppearance.BorderSize = 0;
            this.btnDraws.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnDraws.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDraws.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDraws.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDraws.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDraws.ForeColor = System.Drawing.Color.White;
            this.btnDraws.Location = new System.Drawing.Point(0, 0);
            this.btnDraws.Name = "btnDraws";
            this.btnDraws.Size = new System.Drawing.Size(140, 32);
            this.btnDraws.TabIndex = 19;
            this.btnDraws.Text = "Pregled izvlačenja";
            this.btnDraws.UseVisualStyleBackColor = false;
            this.btnDraws.Click += new System.EventHandler(this.btnDraws_Click_1);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dgvMostFrequent);
            this.panel8.Controls.Add(this.dgvPairs);
            this.panel8.Controls.Add(this.drawn_notDrawn1);
            this.panel8.Controls.Add(this.dataGridView1);
            this.panel8.Controls.Add(this.dgvStats);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(177, 100);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(850, 455);
            this.panel8.TabIndex = 22;
            // 
            // dgvMostFrequent
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvMostFrequent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMostFrequent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMostFrequent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMostFrequent.BackgroundColor = System.Drawing.Color.White;
            this.dgvMostFrequent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMostFrequent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMostFrequent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostFrequent.ColumnHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(1, 5, 1, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMostFrequent.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMostFrequent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMostFrequent.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMostFrequent.GridColor = System.Drawing.Color.White;
            this.dgvMostFrequent.Location = new System.Drawing.Point(0, 0);
            this.dgvMostFrequent.Name = "dgvMostFrequent";
            this.dgvMostFrequent.RowHeadersVisible = false;
            this.dgvMostFrequent.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMostFrequent.RowTemplate.ReadOnly = true;
            this.dgvMostFrequent.Size = new System.Drawing.Size(850, 455);
            this.dgvMostFrequent.TabIndex = 468;
            this.dgvMostFrequent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostFrequent_CellContentClick);
            // 
            // dgvPairs
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvPairs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPairs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPairs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPairs.BackgroundColor = System.Drawing.Color.White;
            this.dgvPairs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPairs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPairs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPairs.ColumnHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(2, 2, 2, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPairs.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPairs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPairs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPairs.GridColor = System.Drawing.Color.White;
            this.dgvPairs.Location = new System.Drawing.Point(0, 0);
            this.dgvPairs.Name = "dgvPairs";
            this.dgvPairs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPairs.RowHeadersVisible = false;
            this.dgvPairs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPairs.RowTemplate.ReadOnly = true;
            this.dgvPairs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPairs.Size = new System.Drawing.Size(850, 455);
            this.dgvPairs.TabIndex = 466;
            this.dgvPairs.Visible = false;
            // 
            // drawn_notDrawn1
            // 
            this.drawn_notDrawn1.BackColor = System.Drawing.Color.White;
            this.drawn_notDrawn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawn_notDrawn1.Location = new System.Drawing.Point(0, 0);
            this.drawn_notDrawn1.Name = "drawn_notDrawn1";
            this.drawn_notDrawn1.Size = new System.Drawing.Size(850, 455);
            this.drawn_notDrawn1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(1027, 555);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SuperSport Loto Statistika";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLottery)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostFrequent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPairs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DataGridView dgvStats;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvLottery;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lbAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCurrent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnPairs;
        private System.Windows.Forms.Button btnDraws;
        private System.Windows.Forms.Button btnTens;
        private Drawn_notDrawn drawn_notDrawn1;
        private System.Windows.Forms.DataGridView dgvPairs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvMostFrequent;
        private System.Windows.Forms.PictureBox pbRefresh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

