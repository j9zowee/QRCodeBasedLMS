using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QRCodeBasedLMS
{
    class clsReturn
    {
        private string bookTitle;
        public string BookTitle
        {
            get { return bookTitle; }
            set { bookTitle = value; }
        }
        private DateTime dueDate;
        public DateTime DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }
        private int noOfDaysUnreturned;
        public int NoOfDaysUnreturned
        {
            get { return noOfDaysUnreturned; }
            set { noOfDaysUnreturned = value; }
        }
        private double penaltyFee;
        public double PenaltyFee
        {
            get { return penaltyFee; }
            set { penaltyFee = value; }
        }
        

        public double ComputeTotalPenalty(double[] penaltyfee)
        {
            double[] fees = new double[] { penaltyFee };
            double sum = 0;
            for (int i = 0; i < fees.Length; i++)
            {
                sum += fees[i];
            }
            return sum;

        }
    }
}
