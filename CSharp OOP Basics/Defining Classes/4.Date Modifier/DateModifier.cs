using System;

public class DateModifier
{
    public DateTime startDate;
    public DateTime endDate;

    public DateModifier(DateTime startDate, DateTime endDate)
    {
        this.startDate = startDate;
        this.endDate = endDate;
    }

    public int GetDifference()
    {
        return Math.Abs((int)(this.endDate - this.startDate).TotalDays);
    }
}
