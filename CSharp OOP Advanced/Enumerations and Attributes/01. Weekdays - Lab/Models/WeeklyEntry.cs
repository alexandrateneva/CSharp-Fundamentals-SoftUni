namespace _01.Weekdays___Lab.Models
{
    using System;

    public class WeeklyEntry : IComparable<WeeklyEntry>
    {
        public WeekDay Weekday { get; set; }
        public string Notes { get; set; }

        public WeeklyEntry(WeekDay weekday, string notes)
        {
            this.Weekday = weekday;
            this.Notes = notes;
        }

        public int CompareTo(WeeklyEntry other)
        {
            var dayCompare = this.Weekday.CompareTo(other.Weekday);
            if (dayCompare != 0)
            {
                return dayCompare;
            }
            return this.Notes.CompareTo(other.Notes);
        }

        public override string ToString()
        {
            return $"{this.Weekday} - {this.Notes}";
        }
    }
}
