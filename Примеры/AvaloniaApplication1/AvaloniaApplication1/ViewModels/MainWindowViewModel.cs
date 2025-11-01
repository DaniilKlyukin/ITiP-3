using ReactiveUI;
using System.Reactive;
using System.Reactive.Linq;

namespace AvaloniaApplication1.ViewModels;

public class MainWindowViewModel : ReactiveObject
{
    private string _message = "Добро пожаловать в Avalonia + ReactiveUI!";
    private int _count;

    public MainWindowViewModel()
    {
        // Создаем вычисляемое свойство, которое реагирует на изменения Count
        this.WhenAnyValue(x => x.Count)
            .Select(count => $"Количество нажатий: {count}")
            .ToProperty(this, x => x.DisplayCount, out _displayCount);

        // Инициализация команд
        IncrementCommand = ReactiveCommand.Create(IncrementCount);

        // Команда сброса активна только когда счетчик > 0
        ResetCommand = ReactiveCommand.Create(ResetCount,
            this.WhenAnyValue(x => x.Count).Select(count => count > 0));
    }

    // Reactive свойства
    public string Message
    {
        get => _message;
        set => this.RaiseAndSetIfChanged(ref _message, value);
    }

    public int Count
    {
        get => _count;
        set => this.RaiseAndSetIfChanged(ref _count, value);
    }

    // Вычисляемое свойство через Observable
    private readonly ObservableAsPropertyHelper<string> _displayCount;
    public string DisplayCount => _displayCount?.Value ?? "Количество нажатий: 0";

    // Команды
    public ReactiveCommand<Unit, Unit> IncrementCommand { get; }
    public ReactiveCommand<Unit, Unit> ResetCommand { get; }

    private void IncrementCount()
    {
        Count++;

        if (Count % 10 == 0)
        {
            Message = $"Отлично! Вы достигли {Count} нажатий! 🎉";
        }
    }

    private void ResetCount()
    {
        Count = 0;
        Message = "Счетчик сброшен! Давайте начнем снова.";
    }
}