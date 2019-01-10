using System;

namespace Module11_TvTablå
{
    public class Time
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }

        public override string ToString()
        {
            return String.Format(
                "{0:00}:{1:00}",
                this.Hours, this.Minutes);
        }
    }
}