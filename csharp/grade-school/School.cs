using System.Collections.Generic;

class School
{
    public Dictionary<int, List<string>> Roster { get; set; }

    public School()
    {
        Roster = new Dictionary<int, List<string>>(0);
    }

    public void Add(string student_name, int grade)
    {
        if (!Roster.ContainsKey(grade)) {
            Roster.Add(grade, new List<string>(0));
        }
        Roster[grade].Add(student_name);
        Roster[grade].Sort();
    }

    public List<string> Grade(int grade)
    {
        if (!Roster.ContainsKey(grade)) {
            return new List<string>(0);
        }

        return Roster[grade];
    }
}
