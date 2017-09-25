using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSport_Loto_Statistika
{
    public class Loto
    {
        private string name;
        private int draw;
        private int numbers;
        private List<Result> drawn;
        public Loto()
        {
            name = "";   drawn = new List<Result>();
        }
        public Loto(string  n, int d, int num)
        {
            name = n; draw = d; numbers = num;
        }
        public int Numbers
        {
            get { return numbers; }
            set { numbers = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Draw
        {
            get { return draw; }
            set { draw = value; }
        }
        public List<Result> Drawn
        {
            get { return drawn; }
            set { drawn = value; }
        }
        public void AddResult (Result Res)
        {
            drawn.Add(Res);
        }
        public bool checkIfDrawn(int number, int inDraw)
        {
            bool flag = false;
            foreach(int n in drawn[inDraw].DrawnNumbers)
            {
                if (n == number)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        public int countLastDraws(int number)
        {
            bool flag = true;
            int i = 0, count = 0;
            while (flag)
            {
                foreach (int n in drawn[i].DrawnNumbers)
                {
                    if (n == number)
                    {
                        flag = true;
                        count++;
                        break;
                    }
                    else flag = false;
                }
                i++;
            }
            return count;
        }
    }
}
