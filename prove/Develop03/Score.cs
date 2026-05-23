public class Score
{
    private int _points;

    public Score()
    {
        _points = 0;
    }

    public void AddPoints(int points)
    {
        _points += points;
    }

    public int GetScore()
    {
        return _points;
    }
}
