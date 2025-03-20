using System;
using Microsoft.AspNetCore.Components;

public class QuizState : ComponentBase
{
    public int SelectedAnswer { get; set; } = -1; // Default to -1 (no selection)

    public event Action OnChange;

    public void SetAnswer(int answer)
    {
        SelectedAnswer = answer;
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}
