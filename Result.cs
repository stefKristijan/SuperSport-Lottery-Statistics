using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSport_Loto_Statistika
{
    public class Result
    {
        private List<int> drawnNumbers;

        public Result(List<int> res) { drawnNumbers = res;}

        public Result() { drawnNumbers = new List<int>(); }

        public void AddNum (int num) { drawnNumbers.Add(num); }
        
        public List<int> DrawnNumbers
        {
            get { return drawnNumbers; }
            set { drawnNumbers = value; }
        }
        public string ResToString()
        {
            string result = "";
            foreach(int i in drawnNumbers)
            {
                result = result + i.ToString() + " ";
            }
            return result;
        }
        
    }
}
