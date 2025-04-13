using System;

public class ChecklistGoal : Goal
{
    private int amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        amountCompleted++;
        if (amountCompleted == _target)
        {

        }
    }

    public override bool isComplete()
    {
        if (amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    public override string GetDetailedString()
    {
        return $"[{(isComplete() ? "X" : " ")}] {GetName()} ({GetDescription()}) -- Completed {amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{GetName()},{GetDescription()},{GetPoints()},{_target},{_bonus},{amountCompleted}";
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public void LoadAmountCompleted(int amount)
    {
        amountCompleted = amount;
    }
}