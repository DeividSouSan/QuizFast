namespace QuizFast.source.Domain.Entities;

public class Question(string text)
{
    public Guid QuestionID { get; set; } = new Guid();
    public string Text { get; set; } = text;
    public List<Answer> Answers { get; set; } = [];
    public void AddAnswer(Answer answer) => Answers.Add(answer);
    public void RemoveAnswer(int index) => Answers.RemoveAt(index - 1);
    public string GetAnswerText(int index) => Answers[index - 1].Text;
    public int CorrectAnswersCount() => Answers.Count(a => a.IsCorrect);
}
