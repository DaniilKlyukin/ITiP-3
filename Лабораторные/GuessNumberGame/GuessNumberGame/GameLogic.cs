namespace GuessNumberGame;

public partial class GameLogic
{
    private int _secretNumber;
    private int _attempts;
    private readonly int _minValue;
    private readonly int _maxValue;
    private readonly List<int> _guessHistory;

    public int Attempts => _attempts;
    public IReadOnlyList<int> GuessHistory => _guessHistory.AsReadOnly();
    public int MinValue => _minValue;
    public int MaxValue => _maxValue;

    public GameLogic(int min = 1, int max = 100)
    {
        _minValue = min;
        _maxValue = max;
        _guessHistory = new List<int>();
        ResetGame();
    }

    public void ResetGame()
    {
        var random = new Random();
        _secretNumber = random.Next(_minValue, _maxValue + 1);
        _attempts = 0;
        _guessHistory.Clear();
    }

    public GuessResult MakeGuess(int number)
    {
        if (number < _minValue || number > _maxValue)
            throw new ArgumentOutOfRangeException(nameof(number),
                $"Число должно быть между {_minValue} и {_maxValue}");

        _attempts++;
        _guessHistory.Add(number);

        if (number == _secretNumber)
            return GuessResult.Correct;

        return number < _secretNumber ? GuessResult.TooLow : GuessResult.TooHigh;
    }
}