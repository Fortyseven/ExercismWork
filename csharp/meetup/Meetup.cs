using System;

public enum Schedule
{
    First = 0,
    Second = 1,
    Third = 2,
    Fourth = 3,
    Teenth = -1,
    Last = -2
}

class Meetup
{
    private DateTime _month_start;
    private int _month;

    public Meetup(int month, int year)
    {
        _month_start = new DateTime(year, month, 1);
        _month = month;
    }

    public DateTime Day(DayOfWeek dayOfWeek, Schedule sched_type)
    {
        if (sched_type == Schedule.Teenth) return UseSpecialWeekStarting(dayOfWeek, 13);
        if (sched_type == Schedule.Last) return UseSpecialWeekStarting(dayOfWeek, _month_start.AddMonths(1).AddDays(-7).Day);

        DateTime the_date = _month_start;
        int week_num = 0;
        int c = 0;
        int skip = (int)sched_type; 

        while (the_date.Month == _month) {
            the_date = _month_start.AddDays(c);
            if ((skip == week_num) && (the_date.DayOfWeek == dayOfWeek)) {
                return the_date;
            }
            c++;
            if ((c % 7) == 0) week_num++;
        }

        return the_date;
    }

    private DateTime UseSpecialWeekStarting(DayOfWeek dayOfWeek, int day)
    {
        for (int i = day - 1; i < day + 7; i++) {
            var dt = _month_start.AddDays(i);
            if (dt.DayOfWeek == dayOfWeek) {
                return dt;
            }
        }
        throw new Exception("This should not happen.");
    }
}
