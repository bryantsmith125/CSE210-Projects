using System;
using System.Collections.Generic;

public class Swimming : Activity
{
    private int _laps;

    public override double GetPace()
    {
        return _minutes / GetDistance();
    }
    public override double GetDistance()
    {
        return _laps * 50 / 1000.0 * 0.62;
    }
    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / _minutes) * 60;
    }
 
}