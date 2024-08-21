namespace QuizFast.source.Domain.Entities;

public class Answer(string text, bool isCorrect)
{
    public Guid AnswerID { get; set; } = new Guid();
    public string Text { get; set; } = text;
    public bool IsCorrect { get; set; } = isCorrect;
}
