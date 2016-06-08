using System;

public class Robot
{
    public string Name { get; private set; }
    private Random _rand;

    public Robot()
    {
        _rand = new Random(Guid.NewGuid().GetHashCode());
        Reset();
    }

    internal void Reset()
    {
        GenerateNewName();
    }

    private void GenerateNewName()
    {
        Name = String.Format("{0}{1}{2}{3}{4}",
                GetRandLetter(),
                GetRandLetter(),
                _rand.Next(0, 10),
                _rand.Next(0, 10),
                _rand.Next(0, 10)
            );
    }

    private char GetRandLetter()
    {
        return (char)('A' + _rand.Next(0, 26));
    }
}