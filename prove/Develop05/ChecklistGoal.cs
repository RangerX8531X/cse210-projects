public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points,
        int targetCount, int bonus)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
        _currentCount = 0;
    }

    public override int RecordEvent()
    {
        _currentCount++;

        if (_currentCount >= _targetCount)
        {
            return GetPoints() + _bonus;
        }

        return GetPoints();
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    public override string GetStatus()
    {
    int totalBars = 10;

    double percent = (double)_currentCount / _targetCount;
    int filledBars = (int)(percent * totalBars);

    string bar = new string('#', filledBars) +
                 new string('-', totalBars - filledBars);

    return $"[{(IsComplete() ? "X" : " ")}] {GetName()} " +
           $"[{bar}] {_currentCount}/{_targetCount}";
    }

    public override string GetSaveString()
    {
        return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_currentCount}|{_targetCount}|{_bonus}";
    }
}