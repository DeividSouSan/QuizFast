namespace QuizFast;

public record AnswerCreateDTO(string Text, bool IsCorrect)
{
    public string Text { get; set; } = Text;
    public bool IsCorrect { get; set; } = IsCorrect;
}
