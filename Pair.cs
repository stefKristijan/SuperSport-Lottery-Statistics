using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSport_Loto_Statistika
{
    class Pair
    {
        private int number1;
        private int number2;
        private float counter;
        public Pair()
        {
            number1 = 0; number2 = 0;
            counter = 0;
        }
        public Pair(int n1, int n2)
        {
            number1 = n1; number2 = n2; counter = 1;
        }
        public int Number1
        {
            get { return this.number1; }
            set { this.number1 = value; }
        }
        public int Number2
        {
            get { return this.number2; }
            set { this.number2 = value; }
        }
        public float Counter
        {
            get { return this.counter; }
            set { this.counter = value; }
        }
        public static bool operator == (Pair ca1, Pair ca2)
        {
            if ((ca1.number1 == ca2.number1 || ca1.number1==ca2.number2) && (ca1.number2 == ca2.number2 || ca1.number2 == ca2.number1)) return true;
            else return false;
        }
        public static bool operator != (Pair ca1, Pair ca2)
        {
            if (!((ca1.number1 == ca2.number1 || ca1.number1 == ca2.number2) && (ca1.number2 == ca2.number2 || ca1.number2 == ca2.number1))) return true;
            else return false;
        }
        public static bool operator > (Pair ca1, Pair ca2)
        {
            if (ca1.Counter > ca2.Counter) { return true; }
            else return false;
        }
        public static bool operator < (Pair ca1, Pair ca2)
        {
            if (ca1.Counter < ca2.Counter) return true;
            else return false;
        }

        public int countNotDrawn(Loto l)
        {
            int count = 0, i = 0;
            bool flag1=true, flag2=true;
            do
            {
                foreach (int n in l.Drawn[i].DrawnNumbers)
                {
                    if (n == number1)
                    {
                        flag1 = true;
                        break;
                    }
                    else flag1 = false;
                }
                foreach (int n in l.Drawn[i].DrawnNumbers)
                {
                    if (n == number2)
                    {
                        flag2 = true;
                        break;
                    }
                    else flag2 = false;
                }
                if (!flag1 || !flag2) count++;
                if (flag1 && flag2) break;
                i++; flag1 = true; flag2 = true;
            } while (flag1 && flag2);
            return count;
        }
    }
}
