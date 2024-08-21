namespace QuizFast.source.Domain.Entities;
public class Quiz
{
    public Guid QuizId { get; set; } = Guid.NewGuid();
    public Guid CreatedBy { get; set; } = Guid.NewGuid(); // ! This should be a User ID
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<Question> Questions { get; set; } = new List<Question>();
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

     public void AddQuestion(Question question)
    {
        if (question == null)
            throw new ArgumentNullException(nameof(question));

        Questions.Add(question);
    }

    // Método para remover uma questão
    public bool RemoveQuestion(Question question)
    {
        if (question == null)
            throw new ArgumentNullException(nameof(question));

        return Questions.Remove(question);
    }

    // Método para verificar se o quiz é válido
    public bool IsValid()
    {
        return Questions.Count >= 3;
    }
}
