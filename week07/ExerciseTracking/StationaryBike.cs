using System;

public class StationaryBike : Exercise
{
    private double _speed;

    public StationaryBike(string date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        return _speed * GetLength() / 60;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}