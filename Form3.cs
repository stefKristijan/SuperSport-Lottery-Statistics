using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperSport_Loto_Statistika
{
    public partial class Form3 : Form
    {
        public Form3(Loto l)
        {
            InitializeComponent();
            mainLoto = l;
        }

        Loto mainLoto;
        List<int> generatedNumbers = new List<int>();
        List<int> mostFrequent = new List<int>();
        List<double> mostFrequentPercent = new List<double>();
        List<Pair> pairs = new List<Pair>();
        List<double> possibility = new List<double>();
        int[] tens = new int[9];
        double[] tensPercent = new double[9];

        private void Form3_Load(object sender, EventArgs e)
        {
            lbName.Text = mainLoto.Name;
        }

        private void setDataGridView(int n)
        {
            dgvGeneratedNum.Columns.Clear();
            dgvGeneratedNum.Rows.Clear();
            dgvGeneratedNum.ColumnCount = n;
            DataGridViewRow row = new DataGridViewRow();
            foreach(int num in generatedNumbers)
            {
                int num1 = 0;
                if (num == 0)
                {
                    num1 = generateMostPossible();
                    row.Cells.Add(new DataGridViewImageCell { Value = new Bitmap(Form1.GetImageByName(num1)) });
                }else
                {
                    row.Cells.Add(new DataGridViewImageCell { Value = new Bitmap(Form1.GetImageByName(num)) });
                }
            }
            dgvGeneratedNum.Rows.Add(row);
        }
        
        private void generate1Number()
        {
            int first = 0;
            if (mainLoto.Drawn.Count > 10) getMostFrequent(10);
            else getMostFrequent(mainLoto.Drawn.Count);
            first =generateMostPossible();
            generatedNumbers.Add(first);
        }

        private void generate10Numbers()
        {
            generate9Numbers();
            int tenth = calculateSecond(generatedNumbers[8]);
            generatedNumbers.Add(tenth);
        }

        private void generate9Numbers()
        {
            generate8Numbers();
            int nineth = calculateFifth();
            generatedNumbers.Add(nineth);
        }

        private void generate8Numbers()
        {
            generate7Numbers();
            int eighth = calculateSecond(generatedNumbers[6]);
            generatedNumbers.Add(eighth);
        }

        private void generate7Numbers()
        {
            generate6Numbers();
            int seventh = calculateThird();
            generatedNumbers.Add(seventh);
        }

        private void generate6Numbers()
        {
            generate5Numbers();
            int sixth = calculateSixth() ;
            generatedNumbers.Add(sixth);
        }

        private void generate5Numbers()
        {
            generate4Numbers();
            calculatePossibility();
            int fifth = calculateFifth();
            generatedNumbers.Add(fifth);
        }

        private void generate4Numbers()
        {
            int fourth = 0;
            generate3Numbers();
            fourth = calculateSecond(generatedNumbers[2]);
            generatedNumbers.Add(fourth);
        }

        private void generate3Numbers()
        {
            int third = 0;
            generate2Numbers();
            getTensPercent();
            tens = getTens(0);
            third = calculateThird();
            generatedNumbers.Add(third); 
        }

        private void generate2Numbers()
        {
            int second = 0; 
            generate1Number();
            second = calculateSecond(generatedNumbers[0]);
            generatedNumbers.Add(second);
        }

        private int calculateSixth()
        {
            int sixth = 0;
            Random rnd = new Random();
            double avg = 0;
            foreach(double pos in possibility)
            {
                avg += pos;
            }
            avg = avg / possibility.Count;
            while (sixth == 0)
            {
                sixth = rnd.Next(1, mainLoto.Numbers);
                if (possibility[sixth - 1] < avg && sixth != 0) sixth = 0;
                foreach (int a in generatedNumbers)
                {
                    if (sixth == a)
                    {
                        sixth = 0;
                        break;
                    }
                }
                if (sixth != 0) break;
            }
            return sixth;
        }

        private int calculateThird()
        {
            int third = 0, count0 = 0, count1=0, i=0, k = 0;
            int[] c0 = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] c1 = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int border = mainLoto.Numbers / 10;
            if (mainLoto.Numbers % 10 == 0) border = mainLoto.Numbers / 10 - 1;
            for (int i1 = 0; i1< border; i1++)
            {
                if (tens[i1] == 0)
                {
                    count0++;
                    c0[i1] = 1;
                }
                else if (tens[i1] == 1)
                {
                    count1++;
                    c1[i1] = 1;
                }
            }
            while (third == 0 && k < 2) //dok se ne nađe third il dok broj brojeva u desetici nije veći od 2
            {
                if (count0 == 0) k++;
                if (count0 >= 1 && k == 0)  // ako postoji 1 ili više desetica koje nisu izvučene u zadnjem kolu, traži se ona s najvećim postotkom izvlačenja u zadnjih 5 kola ii za tu deseticu se računa third
                {
                    for (int j = 0; j < border; j++)
                    {
                        double maxPercent = 0;
                        if (c0[j] == 1)
                        {
                            if (tensPercent[j] > maxPercent)
                            {
                                maxPercent = tensPercent[j]; i = j;
                            }
                        }
                    }
                }
                else if (count1 >= 1 && k == 1)
                {
                    for (int j = 0; j < border; j++)
                    {
                        double maxPercent = 0;
                        if (c1[j] == 1)
                        {
                            if (tensPercent[j] > maxPercent)
                            {
                                maxPercent = tensPercent[j]; i = j;
                            }
                        }
                    }
                }
                foreach (int n in mostFrequent)
                {
                    int m = n / 10;
                    if (n % 10 == 0) m = n / 10 - 1;
                    if (m == i)
                    {
                        third = n;
                        foreach (int a in generatedNumbers)
                        {
                            if (third == a)
                            {
                                third = 0;
                                break;
                            }
                        }
                    }
                    if (third != 0)
                    {
                        break;
                    }
                }
                if (third != 0)
                {
                    break;
                }
                else {
                    k++;
                }
            }
            while (third == 0) //ukoliko ne postoje desetice od kojih je izvučen jedan ili nijedan broj generira se 3. najčešće izvučeni broj
            {
                third = generateMostPossible();
                foreach (int a in generatedNumbers)
                {
                    if (third == a)
                    {
                        third = 0;
                        break;
                    }
                }
            }
            return third;
        }
        
        private int calculateFifth()
        {
            int fifth = 0;
            double max = 0;
            while (fifth == 0)
            {
                for (int i = 0; i < mainLoto.Numbers; i++)
                {
                    if (possibility[i] > max)
                    {
                        max = possibility[i];
                        fifth = i + 1;
                    }
                }
                foreach (int a in generatedNumbers)
                {
                    if (fifth == a)
                    {
                        possibility[fifth - 1] = 0;
                        fifth = 0;
                        max = 0;
                        break;
                    }
                }
            }
            return fifth;
        }

        private void calculatePossibility()
        {
            int[] drawn = calculateDraws(mainLoto.Drawn.Count);
            int[] notDrawn = calculateNotDrawn(mainLoto.Drawn.Count);
            for(int i = 0; i < mainLoto.Numbers; i++)
            {
                double iPossibility=(1.0*drawn[i]/mainLoto.Drawn.Count)+(1.0*notDrawn[i]/mainLoto.Drawn.Count);
                possibility.Add(iPossibility);
            }
        }

        private void getTensPercent()
        {
            int[] tens1 = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int border = mainLoto.Numbers / 10;
            if (mainLoto.Numbers % 10 == 0) border = mainLoto.Numbers / 10 - 1;
            for (int i = 0; i < 5; i++)
            { 
                int[] t = getTens(i);
                for (int j = 0; j <= border; j++)
                {
                    tens1[j] = tens1[j] + t[j];
                }
            }
            for (int i = 0; i <= border; i++)
            {
                tensPercent[i] = 100.0*tens1[i] / 100;
            }
        }

        private int[] getTens(int k)
        {
            int[] tensF = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int border = mainLoto.Numbers / 10;
            if (mainLoto.Numbers % 10 == 0) border = mainLoto.Numbers / 10 - 1;
            for (int i = 0; i <= border; i++) tens[i] = 0;
            foreach(int n in mainLoto.Drawn[k].DrawnNumbers)
            {
                int m = n / 10;
                if (n % 10 == 0) m= n / 10 - 1;
                tensF[m]++;
            }
            return tensF;
        }

        private int calculateSecond(int number)
        {
            int second = 0, percent =30, j = 3;
            if (mainLoto.Drawn.Count > 10)
                getPairList(10);
            else getPairList(mainLoto.Drawn.Count);
            do
            {
                foreach (Pair p in pairs)
                {
                    if (p.Number1 == number || p.Number2 == number)
                    {
                        int sec;
                        if (p.Number2 == number) sec = p.Number1;
                        else sec = p.Number2;
                        if ((p.Counter / 10 * 100.0) >= 50 && p.countNotDrawn(mainLoto) >= 1)
                        {
                            second = sec;
                            foreach (int a in generatedNumbers)
                            {
                                if (second == a)
                                {
                                    second = 0;
                                    break;
                                }
                            }
                        }
                        if ((p.Counter / 10 * 100.0) >= percent && p.countNotDrawn(mainLoto) >= j)
                        {
                            second = sec;
                            foreach (int a in generatedNumbers)
                            {
                                if (second == a)
                                {
                                    second = 0;
                                    break;
                                }
                            }
                        }
                    }
                    if (second != 0) break;
                }
                if (second == 0) { percent -= 10;  j++; }
            } while (second == 0 && percent >= 10);
            if (second == 0)
            {
                foreach (Pair p in pairs)
                {
                   
                    if (p.Number1 == number || p.Number2 == number)
                    {
                        if (p.Number2 == number)
                        {
                            second = p.Number1;
                            foreach (int a in generatedNumbers)
                            {
                                if (second == a)
                                {
                                    second = 0;
                                }
                            }
                            if (second != 0) break;
                        }
                        else {
                            second = p.Number2;
                            foreach (int a in generatedNumbers)
                            {
                                if (second == a)
                                {
                                    second = 0;
                                }
                            }
                            if (second != 0) break;
                        }
                    }
                }
            }
            if (second == 0) second = generateMostPossible();
            return second;
        }

        private int generateMostPossible()
        {
            int num = 0, i = 0, percent = 50, j = 1, k1 = 2, k2 = 4;
            if (mainLoto.Drawn.Count > 10)
            {
                int[] notDrawn = calculateNotDrawn(mainLoto.Drawn.Count);
                while (num == 0 && percent >= 10)
                {
                    if (mostFrequentPercent[i] >= percent && notDrawn[mostFrequent[i] - 1] >= j)
                    {
                        num = mostFrequent[i];
                        foreach (int a in generatedNumbers)
                        {
                            if (num == a)
                            {
                                num = 0; break;
                            }
                        }
                    }
                    else if(mostFrequentPercent[i]>=60 && !mainLoto.checkIfDrawn(mostFrequent[i],1) && mainLoto.checkIfDrawn(mostFrequent[i],0))
                    {
                        num = mostFrequent[i];
                        foreach (int a in generatedNumbers)
                        {
                            if (num == a)
                            {
                                num = 0;
                                break;
                            }
                        }
                    }
                    else if (mostFrequentPercent[i] >= 50 && !mainLoto.checkIfDrawn(mostFrequent[i], 2) && !mainLoto.checkIfDrawn(mostFrequent[i], 1) && mainLoto.checkIfDrawn(mostFrequent[i], 0))
                    {
                        num = mostFrequent[i];
                        foreach (int a in generatedNumbers)
                        {
                            if (num == a)
                            {
                                num = 0;
                                break;
                            }
                        }
                    }
                    else if (percent > 40 && mostFrequentPercent[i] >= percent && mainLoto.countLastDraws(mostFrequent[i]) >= k1 && mainLoto.countLastDraws(mostFrequent[i]) < k2)
                    {
                        num = mostFrequent[i];
                        foreach (int a in generatedNumbers)
                        {
                            if (num == a)
                            {
                                num = 0;
                                break;
                            }
                        }
                    }
                    if( mostFrequentPercent[i]<percent) { percent -= 10; j++; i = 0; k1++; k2++; }
                    else if (i < mostFrequent.Count - 1) i++;
                    else { percent -= 10; j++; i = 0; k1--; k2--; }
                };
            }
            while(num==0)
            {
                foreach(int number in mostFrequent)
                {
                    num = number;
                    foreach (int ab in generatedNumbers)
                    {
                        if (ab == num) { num = 0; break; }
                    }
                }
            }
            return num;
        }

        private void getPairList(int n)
        {
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
                                if (p == pair)
                                {
                                    flag = true;
                                    pair.Counter++;
                                    break;
                                }
                            }
                            if (flag == false) pairs.Add(p);
                        }
                    }
            }
            pairs = (from p in pairs
                     orderby p.Counter descending
                     select p).ToList();
        }

        private void getMostFrequent(float draws)
        {
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

            try
            {
                for (int j = 0; j < mainLoto.Numbers; j++)
                {
                    for (int i = 0; i < 91; i++)
                    {
                        if (countArray[i] > max)
                        {
                            max = countArray[i];
                            imax = i;
                        }
                    }
                    if (imax != 0)
                    {
                        mostFrequent.Add(imax);
                        mostFrequentPercent.Add(max / draws * 100);
                    }
                    countArray[imax] = 0; max = 0; imax = 0;
                }
                
            }
            catch (Exception ex) { }
        }

        private int[] calculateDraws(int draws)
        {
            int[] drawn = new int[mainLoto.Numbers];
            for (int i = 0; i < draws; i++)
            {
                Result r = mainLoto.Drawn[i];
                foreach (int n in r.DrawnNumbers)
                {
                    if (drawn[n - 1] > 0) drawn[n - 1]++;
                    else drawn[n - 1] = 1;
                }
            }
            return drawn;
        }

        private int[] calculateNotDrawn(int draws)
        {
            int[] notDrawn = new int[mainLoto.Numbers];
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
                        if (notDrawn[i - 1] > 0) notDrawn[i - 1]++;
                        else notDrawn[i - 1] = 1;
                    }
                }
                flagFound = false;
            }
            return notDrawn;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generatedNumbers.Clear();
            generate1Number();
            setDataGridView(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            generatedNumbers.Clear();
            generate2Numbers();
            setDataGridView(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            generatedNumbers.Clear();
            generate3Numbers();
            setDataGridView(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            generatedNumbers.Clear();
            generate4Numbers();
            setDataGridView(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            generatedNumbers.Clear();
            generate5Numbers();
            setDataGridView(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            generatedNumbers.Clear();
            generate6Numbers();
            setDataGridView(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            generatedNumbers.Clear();
            generate7Numbers();
            setDataGridView(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            generatedNumbers.Clear();
            generate8Numbers();
            setDataGridView(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            generatedNumbers.Clear();
            generate9Numbers();
            setDataGridView(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            generatedNumbers.Clear();
            generate10Numbers();
            setDataGridView(10);
        }

        private void pbClose_MouseEnter(object sender, EventArgs e)
        {
            pbClose.Image = Properties.Resources.drugiClose;
        }

        private void pbClose_MouseLeave(object sender, EventArgs e)
        {
            pbClose.Image = Properties.Resources.prviClose;
        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);


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

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
