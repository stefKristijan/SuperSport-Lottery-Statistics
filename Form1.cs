using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperSport_Loto_Statistika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Loto> AllLotoResults = new List<Loto>();

        Size oldSize;

        private bool flagBDraws = false, flagBCalculate = false, flagBTens = false, flagBPairs = false, flagButton1 = false;

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (CheckForInternetConnection())
            {
                webBrowser1.Navigate("https://www.supersport.hr/rezultati/loto");
                //this.Height = 43;
                //this.Width = 43;
                this.CenterToScreen();
            }
            else { MessageBox.Show("Potrebna Vam je internet veza kako bi mogli koristiti aplikaciju!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            setLotoResults(webBrowser1);
            //comboBox1.SelectedIndex = 0;
            //setWindow();
            //this.MinimumSize = new Size(622, 200);
        }

        private void setLotoResults(WebBrowser wb)
        {
            List<string> AllLotoNames = new List<string>();
            List<int> AllNumbers = new List<int>();
            var parentEls = webBrowser1.Document.GetElementsByTagName("tr");
            foreach (HtmlElement parent in parentEls)
            {
                MessageBox.Show(parent.InnerHtml);
                var els = parent.GetElementsByTagName("td");
                foreach (HtmlElement el in els)
                {
                    if (el.GetAttribute("className") == "loto-rezultati-naziv")
                    {
                        AllLotoNames.Add(el.InnerText);
                        MessageBox.Show(el.InnerText);
                    }
                }
                var NumEls = parent.GetElementsByTagName("div");
                
                foreach (HtmlElement el in NumEls)
                {
                    if (el.GetAttribute("className") == "loto-rezultati-broj")
                    {
                        int number = Convert.ToInt32(el.InnerText);
                        AllNumbers.Add(number);
                        MessageBox.Show(el.InnerText);
                    }
                }
            }
            int drawNumbers = 0;
            int[] lotteryLook = { 20, 90, 10, 20, 5, 41, 6, 44, 5, 90, 7, 45, 6, 45, 20, 70, 6, 45, 6, 49, 7, 49, 5, 41, 5, 32, 6, 42, 6, 44, 5, 50, 20, 70, 5, 36, 20, 70, 5, 49, 12, 24, 20, 80, 6, 49, 6, 52, 6, 47, 6, 90, 20, 62, 20, 62, 20, 62, 6, 40, 5, 36, 7, 42, 5, 90, 6, 49, 5, 39, 6, 47, 6, 49, 20, 80, 6, 59, 6, 49, 20, 70, 6, 49, 6, 48, 5, 30, 6, 49, 20, 80, 6, 49, 6, 49, 5, 35, 7, 39, 6, 49, 6, 42, 5, 35, 12, 24, 6, 54, 6, 59, 5, 75, 6, 49, 10, 20, 5, 31 };
            List<int> change = new List<int>();
            for (int i = 0; i < AllLotoNames.Count; i++)
            {
                string loto = AllLotoNames[i];
                if (loto != null)
                {
                    Loto l = new Loto();
                    l.Name = loto;
                    l.Draw = lotteryLook[drawNumbers++];
                    l.Numbers = lotteryLook[drawNumbers++];
                    AllLotoResults.Add(l);
                    change.Add(i);
                }
                if (AllLotoNames.Count - 1 == i) change.Add(i);
            }
            int j = 0, cursor = 0, k = 0, next = 0;
            List<int> draw = new List<int>();
            foreach (Loto l in AllLotoResults)
            {
                int numbersInLoto = (change[j + 1] - change[j]) * l.Draw;
                for (int i = cursor; i <= numbersInLoto + k; i++)
                {
                    if (next / l.Draw == 1 && next != 0)
                    {
                        Result r = new Result();
                        foreach (int number in draw)
                        {
                            r.AddNum(number);
                        }
                        draw.Clear();
                        draw.Add(AllNumbers[i]);
                        l.AddResult(r);
                        next = 1;
                    }
                    else
                    {
                        draw.Add(AllNumbers[i]);
                        next++;
                    }
                    cursor = i;
                }
                k = k + numbersInLoto;
                j++; cursor++; next = 1;
            }
            dgvLottery.ColumnCount = 1;
            foreach (Loto l in AllLotoResults)
            {
                dgvLottery.Rows.Add(l.Name);
            }
            dgvLottery.ClearSelection();
            AllLotoNames.Clear();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (flagBCalculate) drawn_notDrawn1.BringToFront();
            else {
                statsForNum();
                drawn_notDrawn1.BringToFront();
            }
                flagBDraws = true;
            btnDraws.BackColor = Color.Transparent;
            btnTens.BackColor = Color.Transparent;
            btnCalculate.BackColor = Color.Red;
        
            btnPairs.BackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
            
          
        }
        
       


        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(AllLotoResults[dgvLottery.CurrentCell.RowIndex]);
            f3.ShowDialog();
        }
       
        private void btnDraws_Click_1(object sender, EventArgs e)
        {
            if (flagBDraws) dataGridView1.BringToFront();
            else {
                setDraws();
                dataGridView1.BringToFront();
            }
            flagBDraws = true;
            btnDraws.BackColor = Color.Red;
            btnCalculate.BackColor = Color.Transparent;
            btnPairs.BackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
            btnTens.BackColor = Color.Transparent;
            dataGridView1.ClearSelection();

        }

        private void btnTens_Click(object sender, EventArgs e)
        {
            if (flagBTens) dgvStats.BringToFront();
            else
            {
                setTableStats();
                dgvStats.BringToFront();
            }
                flagBTens = true;
            btnTens.BackColor = Color.Red;
            btnDraws.BackColor = Color.Transparent;
            btnCalculate.BackColor = Color.Transparent;
            btnPairs.BackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
            dgvStats.ClearSelection();
        }
        //button za generiranje 12 najčešće izvučenih
        private void button1_Click(object sender, EventArgs e)
        {
            if (flagButton1) dgvMostFrequent.BringToFront();
            else {
                setMostFrequent();
                dgvMostFrequent.BringToFront();
            }
            flagButton1 = true;
            btnTens.BackColor = Color.Transparent;
            btnDraws.BackColor = Color.Transparent;
            btnCalculate.BackColor = Color.Transparent;
            btnPairs.BackColor = Color.Transparent;
            button1.BackColor = Color.Red;
            dgvMostFrequent.ClearSelection();
        }
        private void pbClose_MouseEnter(object sender, EventArgs e)
        {
            pbClose.Image = Properties.Resources.drugiClose;
            label4.Visible = true;
            label4.BringToFront();
        }

        private void statsForNum()
        {
            int i = 1;
            setWindow();
            foreach (Control c in drawn_notDrawn1.Controls)
            {
                if (c is PictureBox)
                {
                    PictureBox pb = c as PictureBox;
                    pb.Image = new Bitmap(GetImageByName(i++));
                    pb.BackColor = Color.White;
                }
            }
            calculateDraws();
            calculateNotDrawn();
        }

        private void setDraws()
        {
            int index = dgvLottery.CurrentCell.RowIndex;
            dataGridView1.Columns.Clear();
            dataGridView1.ColumnCount = AllLotoResults[index].Draw;
            for (int i = 0; i < trackBar1.Value; i++)
            {
                Result r = AllLotoResults[index].Drawn[i];
                var row = new DataGridViewRow();
                foreach (int n in r.DrawnNumbers)
                {
                    row.Cells.Add(new DataGridViewImageCell { Value = new Bitmap(GetImageByName(n)) });
                }
                try
                {
                    dataGridView1.Rows.Add(row);
                }
                catch (Exception ex)
                {
                    dataGridView1.ColumnCount = 20;
                    dataGridView1.Rows.Add(row);
                }
            }
        }

        private void set2MostFrequent(int columns)
        {
            int index = dgvLottery.CurrentCell.RowIndex;
            Loto l = AllLotoResults[index];
            float draws = trackBar1.Value;
            int draw = l.Draw;
            int[] countArray = new int[l.Numbers];
            for (int i = 0; i < l.Numbers; i++) { countArray[i] = 0; }
            for (int i = 0; i < draws; i++)
            {
                foreach (int n in l.Drawn[i].DrawnNumbers)
                {
                    countArray[n - 1]++;
                }
            }
            int max = 0, imax = 0;
            for (int k = 0; k < 10 ; k++)
            {
                var row = new DataGridViewRow();
                var row2 = new DataGridViewRow();
                for (int j = 0; j < columns; j++)
                {
                    for (int i = 10 * j; i < 10 * (j + 1); i++)
                    {
                        if (i >= l.Numbers) break;
                        if (countArray[i] > max)
                        {
                            max = countArray[i];
                            imax = i;
                        }
                    }
                    if(max!=0) row.Cells.Add(new DataGridViewImageCell { Value = new Bitmap(GetImageByName(imax + 1)) });
                    else
                    {
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = "" });
                    }
                    if ( max!=0) row2.Cells.Add(new DataGridViewTextBoxCell { Value = (max / draws * 100).ToString() + "%" });
                    else
                    {
                        row2.Cells.Add(new DataGridViewTextBoxCell { Value = "" });
                    }
                    countArray[imax] = 0; max = 0; imax = 0;
                }
                dgvStats.Rows.Add(row);
                dgvStats.Rows.Add(row2);
            }
            dgvStats.Width = dgvStats.Columns[0].Width * columns + 5;
            dataGridView1.Location = new Point(dgvStats.Width + 10, 34);
        }
        
        private void setTableStats()
        {
            int index = dgvLottery.CurrentCell.RowIndex;
            int draws = trackBar1.Value;
            float[] range = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int draw = AllLotoResults[index].Draw;
            int numbers = draw * draws; //koliko ukupno brojeva ima
            for (int i = 0; i < draws; i++)
            {
                foreach (int n in AllLotoResults[index].Drawn[i].DrawnNumbers)
                {
                    if (n <= 10) { range[0]++; }
                    if (n > 10 && n <= 20) { range[1]++; }
                    if (n > 20 && n <= 30) { range[2]++; }
                    if (n > 30 && n <= 40) { range[3]++; }
                    if (n > 40 && n <= 50) { range[4]++; }
                    if (n > 50 && n <= 60) { range[5]++; }
                    if (n > 60 && n <= 70) { range[6]++; }
                    if (n > 70 && n <= 80) { range[7]++; }
                    if (n > 80 && n <= 90) { range[8]++; }
                }
            }
            dgvStats.Columns.Clear();
            int columns= (AllLotoResults[index].Numbers / 10);
            if (AllLotoResults[index].Numbers % 10 != 0) columns++;
            dgvStats.ColumnCount = columns;
            var firstRow = new DataGridViewRow();
            ArrayList row = new ArrayList();
            for (int i = 0; i < columns; i++)
            {
                if (i == 0) firstRow.Cells.Add(new DataGridViewImageCell { Value = Properties.Resources._1_10 });
                if (i == 1) firstRow.Cells.Add(new DataGridViewImageCell { Value = Properties.Resources._11_20 });
                if (i == 2) firstRow.Cells.Add(new DataGridViewImageCell { Value = Properties.Resources._21_30 });
                if (i == 3) firstRow.Cells.Add(new DataGridViewImageCell { Value = Properties.Resources._31_40 });
                if (i == 4) firstRow.Cells.Add(new DataGridViewImageCell { Value = Properties.Resources._41_50 });
                if (i == 5) firstRow.Cells.Add(new DataGridViewImageCell { Value = Properties.Resources._51_60 });
                if (i == 6) firstRow.Cells.Add(new DataGridViewImageCell { Value = Properties.Resources._61_70 });
                if (i == 7) firstRow.Cells.Add(new DataGridViewImageCell { Value = Properties.Resources._71_80 });
                if (i == 8) firstRow.Cells.Add(new DataGridViewImageCell { Value = Properties.Resources._81_90 });
                range[i] = range[i] / numbers * 100;
                row.Add(range[i].ToString() + "%");
            }
            dgvStats.Rows.Add(firstRow);
            dgvStats.Rows.Add(row.ToArray());
            set2MostFrequent(columns);
        }

        private void setWindow()
        {
            int i = 0;
            Loto mainLoto = AllLotoResults[dgvLottery.CurrentCell.RowIndex];

            foreach (Control c in drawn_notDrawn1.Controls)
            {
                if (i >= mainLoto.Numbers * 2)
                {
                    if (c is Label) c.Visible = false;
                }
                i++;
            }
            i = 0;
            foreach (Control c in drawn_notDrawn1.Controls)
            {
                if (c is PictureBox)
                {
                    if (i >= mainLoto.Numbers) c.Visible = false;
                    i++;
                }
            }
            if (mainLoto.Numbers % 10 == 0) { drawn_notDrawn1.Size = new Size(550, mainLoto.Numbers / 10 * 50 + 20); }
            else { drawn_notDrawn1.Size = new Size(550, (1 + mainLoto.Numbers / 10) * 50 + 20); }
        }

        private void calculateDraws()
        {
            foreach (Control c in drawn_notDrawn1.Controls)
            {
                if (c is Label) c.Text = "0";
            }
            Loto mainLoto = AllLotoResults[dgvLottery.CurrentCell.RowIndex];
            int draws = trackBar1.Value;
            for (int i = 0; i < draws; i++)
            {
                Result r = mainLoto.Drawn[i];
                foreach (int n in r.DrawnNumbers)
                {
                    Control c = drawn_notDrawn1.Controls[(n - 1) * 2];
                    if (c is Label) c.Text = (Convert.ToInt32(c.Text) + 1).ToString();
                }
            }
        }

        private void calculateNotDrawn()
        {
            Loto mainLoto = AllLotoResults[dgvLottery.CurrentCell.RowIndex];
            int draws = trackBar1.Value;
            bool flagFound = false;
            for (int i = 1; i <= mainLoto.Numbers; i++)
            {
                for (int j = 0; j < draws; j++)
                {
                    Result r = mainLoto.Drawn[j];
                    foreach (int n in r.DrawnNumbers)
                    {
                        if (n == i)
                        {
                            flagFound = true;
                            break;
                        }
                    }
                    if (flagFound) break;
                    else
                    {
                        Control c = drawn_notDrawn1.Controls[(i - 1) * 2 + 1];
                        if (c is Label) c.Text = (Convert.ToInt32(c.Text) + 1).ToString();
                    }
                }
                flagFound = false;
            }
        }

        private void setCommonArrays()
        {
            dgvPairs.Columns.Clear();
            List<Pair> pairs = new List<Pair>();
            //foreach (Result r in AllLotoResults[comboBox1.SelectedIndex].Drawn
            Loto mainLoto = AllLotoResults[dgvLottery.CurrentCell.RowIndex];
            int n = trackBar1.Value;
            for (int k = 0; k < n; k++)
            {
                Result r = mainLoto.Drawn[k];
                for (int i = 0; i < r.DrawnNumbers.Count - 1; i++)
                    for (int j = i + 1; j < r.DrawnNumbers.Count; j++)
                    {
                        if (i == 0)
                        {
                            Pair p = new Pair(r.DrawnNumbers[i], r.DrawnNumbers[j]);
                            pairs.Add(p);
                        }
                        else {
                            Pair p = new Pair(r.DrawnNumbers[i], r.DrawnNumbers[j]);
                            bool flag = false;
                            foreach (Pair pair in pairs)
                            {
                                if (p.Number1 == pair.Number1 && p.Number2 == pair.Number2)
                                {
                                    pair.Counter++;
                                    flag = true;
                                }
                            }
                            if (flag == false) pairs.Add(p);
                        }
                    }
            }
            pairs = (from p in pairs
                     orderby p.Counter descending
                     select p).ToList();
            foreach (Pair p in pairs)
            {
                dgvPairs.ColumnCount = 3;
                var row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewImageCell { Value = new Bitmap(Form1.GetImageByName(p.Number1)) });
                row.Cells.Add(new DataGridViewImageCell { Value = new Bitmap(Form1.GetImageByName(p.Number2)) });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = (p.Counter / n * 100).ToString() + "%" });
                dgvPairs.Rows.Add(row);
            }
            dgvPairs.Visible = true;
        }

        private void setMostFrequent()
        {
            float draws = trackBar1.Value;
            Loto mainLoto = AllLotoResults[dgvLottery.CurrentCell.RowIndex];
            int draw = mainLoto.Draw;
            int[] countArray = new int[91];
            for (int i = 0; i < 91; i++) { countArray[i] = 0; }
            for (int i = 0; i < draws; i++)
            {
                foreach (int n in mainLoto.Drawn[i].DrawnNumbers)
                {
                    countArray[n]++;
                }
            }
            int max = 0, imax = 0;
            var row = new DataGridViewRow();
            ArrayList row2 = new ArrayList();
            
            dgvMostFrequent.Columns.Clear();
            dgvMostFrequent.ColumnCount = 12;
            try
            {
                for (int j = 0; j<12 ; j++)
                {
                    for (int i = 0; i < 91; i++)
                    {
                        if (countArray[i] > max)
                        {
                            max = countArray[i];
                            imax = i;
                        }
                    }
                    row.Cells.Add(new DataGridViewImageCell { Value = new Bitmap(GetImageByName(imax)) });
                    row2.Add((max / draws * 100).ToString() + "%");
                    countArray[imax] = 0; max = 0; imax = 0;
                    
                }
            }
            catch (Exception ex) { }
            dgvMostFrequent.Rows.Add(row);
            dgvMostFrequent.Rows.Add(row2.ToArray());
            //dgvMostFrequent.Width = dgvMostFrequent.Columns[0].Width * Convert.ToInt32(cbMostFrequent.SelectedItem)+10;
        }

        public static Bitmap GetImageByName(int n)
        {

            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            string resourceName = asm.GetName().Name + ".Properties.Resources";
            var rm = new System.Resources.ResourceManager(resourceName, asm);
            return (Bitmap)rm.GetObject("_" + n.ToString());

        }
        
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lbCurrent.Text = trackBar1.Value.ToString();
            dataGridView1.BringToFront();
            dataGridView1.Columns.Clear();
            btnTens.BackColor = Color.Transparent;
            btnDraws.BackColor = Color.Transparent;
            btnCalculate.BackColor = Color.Transparent;
            btnPairs.BackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
            flagBDraws = false;
            flagBCalculate = false;
            flagBPairs = false;
            flagBTens = false;
            flagButton1 = false;
        }

        
        private void dgvLottery_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvLottery.CurrentCell.RowIndex;
            //label1.Text += "(ukupno: " + AllLotoResults[index].Drawn.Count.ToString() + " kola)";
            trackBar1.Maximum = AllLotoResults[index].Drawn.Count;
            if (AllLotoResults[index].Drawn.Count >= 20) trackBar1.Value = 20;
            else trackBar1.Value = AllLotoResults[index].Drawn.Count;
            setDraws();
            lbName.Text = AllLotoResults[index].Name;
            if (AllLotoResults[index].Drawn.Count >= 100) lbAll.Location = new Point(825, 18);
            lbAll.Text = AllLotoResults[index].Drawn.Count.ToString();
            lbCurrent.Text = trackBar1.Value.ToString();
            dataGridView1.BringToFront();
            label1.Visible = true;
            label2.Visible = true;
            trackBar1.Visible = true;
            lbAll.Visible = true;
            lbCurrent.Visible = true;
            panel7.Visible = true;
            btnDraws.BackColor = Color.Red;
            btnTens.BackColor = Color.Transparent;
            btnCalculate.BackColor = Color.Transparent;
            btnPairs.BackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
            dataGridView1.ClearSelection();
            flagBDraws = true;
            flagBCalculate = false;
            flagBPairs = false;
            flagBTens = false;
            flagButton1 = false;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            pbClose.Image = Properties.Resources.drugiClose;
            Application.Exit();
        }

       
        private void pbClose_MouseLeave(object sender, EventArgs e)
        {
            pbClose.Image = Properties.Resources.prviClose;
            label4.Visible = false;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (oldSize.Height != this.Height)
            {
                if (oldSize.Height > this.Height)
                {
                    dgvStats.Height -= oldSize.Height - this.Height;
                    dataGridView1.Height -= oldSize.Height - this.Height;
                }
                else
                {
                    dgvStats.Height += this.Height - oldSize.Height;
                    dataGridView1.Height += this.Height - oldSize.Height;
                }
                btnCalculate.Location = new Point(7, dgvStats.Height +  20);
               
                btnGenerate.Location = new Point(this.Width / 2 - btnGenerate.Width / 2, this.Height - btnGenerate.Height - 40);
                oldSize.Height = this.Height;
               /* if (oldSize.Width > this.Width)
                {

                    dgvStats.Width -= oldSize.Width - this.Width;
                    dataGridView1.Width -= oldSize.Width - this.Width);
                    dataGridView1.Location = new Point(dgvStats.Width + 10, 34);
                }
                else
                {
                    dgvStats.Width += this.Width - oldSize.Width;
                    dataGridView1.Width += this.Width - oldSize.Width;
                    dataGridView1.Location = new Point(dgvStats.Width + 10, 34);
                }
                oldSize.Width = this.Width;*/
            }
            
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            dgvStats.Width = this.Width / 2-15;
            if(dgvStats.Width>= dgvStats.Columns[0].Width * dgvStats.Columns.Count +5)
            {
                dgvStats.Width = dgvStats.Columns[0].Width * dgvStats.Columns.Count+5;
                dataGridView1.Width = this.Width - dgvStats.Width - 25;
            }
            else dataGridView1.Width = this.Width / 2-15;
            dataGridView1.Location = new Point(dgvStats.Width + 10, 34);
          
            btnGenerate.Location = new Point(this.Width / 2 - btnGenerate.Width / 2, this.Height - btnGenerate.Height - 40);
        }

        private void btnPairs_Click(object sender, EventArgs e)
        {
            if (flagBPairs) dgvPairs.BringToFront();
            else {
                setCommonArrays();
                dgvPairs.BringToFront();
            }
                flagBPairs = true;
            btnTens.BackColor = Color.Transparent;
            btnDraws.BackColor = Color.Transparent;
            btnCalculate.BackColor = Color.Transparent;
            btnPairs.BackColor = Color.Red;
            button1.BackColor = Color.Transparent;
            dgvPairs.ClearSelection();
        }



        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void dgvMostFrequent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void pbRefresh_MouseEnter(object sender, EventArgs e)
        {
            pbRefresh.Image = Properties.Resources.drugiRefresh;
            label5.Visible = true;
        }

        private void pbRefresh_MouseLeave(object sender, EventArgs e)
        {
            pbRefresh.Image = Properties.Resources.prviRefresh;
            label5.Visible = false;
        }

        private void dgvLottery_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            dgvLottery.Rows[index].Cells[0].Style.BackColor = Color.FromArgb(212, 215, 219);
        }

        private void dgvLottery_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            dgvLottery.Rows[index].Cells[0].Style.BackColor = Color.FromArgb(238,238,238);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

      

        /* private void setDataGridCellColors()
     {
         foreach (DataGridViewRow row in dataGridView1.Rows)
             foreach (DataGridViewCell cell in row.Cells)
             {
                 int n = Convert.ToInt32(cell.Value);
                 if (n > 0 && n <= 10) cell.Style.BackColor = Color.Yellow;
                 if (n > 10 && n <= 20)
                 {
                     cell.Style.BackColor = Color.Blue;
                     cell.Style.ForeColor = Color.White;
                 }
                 if (n > 20 && n <= 30)
                 {
                     cell.Style.BackColor = Color.Red;
                     cell.Style.ForeColor = Color.White;
                 }
                 if (n > 30 && n <= 40) cell.Style.BackColor = Color.LightGreen;
                 if (n > 40 && n <= 50)
                 {
                     cell.Style.BackColor = Color.Black;
                     cell.Style.ForeColor = Color.White;
                 }
                 if (n > 50 && n <= 60)
                 {
                     cell.Style.BackColor = Color.Purple;
                     cell.Style.ForeColor = Color.White;
                 }
                 if (n > 70 && n <= 80)
                 {
                     cell.Style.BackColor = Color.Chocolate;
                     cell.Style.ForeColor = Color.White;
                 }
                 if (n > 80 && n <= 90)
                 {
                     cell.Style.BackColor = Color.DarkGreen;
                     cell.Style.ForeColor = Color.White;
                 }
             }
     }
     */

        /* private void setDataGrid2CellColor()
     {
         int i = 0;
         foreach (DataGridViewRow row in dgvStats.Rows)
             foreach (DataGridViewCell cell in row.Cells)
             {
                 if (i == 0) { cell.Style.BackColor = Color.Yellow; i++; }
                 else if (i == 1)
                 {
                     cell.Style.BackColor = Color.Blue;
                     cell.Style.ForeColor = Color.White; i++;
                 }
                 else if (i == 2)
                 {
                     cell.Style.BackColor = Color.Red;
                     cell.Style.ForeColor = Color.White; i++;
                 }
                 else if (i == 3) { cell.Style.BackColor = Color.LightGreen; i++; }
                 else if (i == 4)
                 {
                     cell.Style.BackColor = Color.Black;
                     cell.Style.ForeColor = Color.White; i++;
                 }
                 else if (i == 5)
                 {
                     cell.Style.BackColor = Color.Purple;
                     cell.Style.ForeColor = Color.White; i++;
                 }
                 else if (i == 6) i++;
                 else if (i == 7)
                 {
                     cell.Style.BackColor = Color.Chocolate;
                     cell.Style.ForeColor = Color.White; i++;
                 }
                 else if (i == 8)
                 {
                     cell.Style.BackColor = Color.DarkGreen;
                     cell.Style.ForeColor = Color.White; i = 0;
                 }
             }
     }*/

        /*  private void setWindow()
          {
              pictureBox1.Visible = false;
              pictureBox1.Image = null;
              dataGridView1.Width = dataGridView1.Columns[1].Width * AllLotoResults[dgvLottery.CurrentCell.RowIndex].Draw +20;
              this.Width = dgvStats.Width + dataGridView1.Width + 35;
              //this.Height = dgvStats.Height + tbDraws.Height + btnCalculate.Height + 20;
              this.FormBorderStyle = FormBorderStyle.Sizable;
              this.Icon = Properties.Resources.icon;
              this.Location = new Point(0, 0);
              this.Height = Screen.FromControl(this).Bounds.Height - 40;
              dgvStats.Height = this.Height - 140;
              dataGridView1.Height = dgvStats.Height;
              btnCalculate.Location = new Point(7,dgvStats.Height+30);
              btnRefresh.Location = new Point(this.Width - 110, dgvStats.Height +  35);
              btnGenerate.Location = new Point(this.Width / 2 - btnGenerate.Width / 2, this.Height - btnGenerate.Height - 40);
              oldSize.Height = this.Height;
              oldSize.Width = this.Width;
          */

    }
}
