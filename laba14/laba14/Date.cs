using System;

namespace laba5
{
    [Serializable]
    public class Dates
    {
        public int Date
        {
            get;
            set;
        }
        public Dates(int date)
        {
            Date = date;
        }
    }
}
