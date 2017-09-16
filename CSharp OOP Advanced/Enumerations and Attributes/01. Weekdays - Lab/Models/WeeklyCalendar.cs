namespace _01.Weekdays___Lab.Models
{
    using System;
    using System.Collections.Generic;

    public class WeeklyCalendar
    {
        public readonly List<WeeklyEntry> WeeklySchedule;

        public WeeklyCalendar()
        {
            this.WeeklySchedule = new List<WeeklyEntry>();
        }

        public void AddEntry(string weekday, string notes)
        {
            var dayAtWeek = (WeekDay)Enum.Parse(typeof(WeekDay), weekday);
            var weekEntry = new WeeklyEntry(dayAtWeek, notes);
            this.WeeklySchedule.Add(weekEntry);
        }
    }
}