using System;

public abstract class Exercise
{
    private string _date;
    private int _length;

    public Exercise(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public string GetDate()
    {
        return _date;
    }

    public int GetLength()
    {
        return _length;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_length}): \nDistance: {GetDistance():0.0} km,\n Speed: {GetSpeed():.0.0} kph, \nPace: {GetPace():0.0} min per km";
    }
}