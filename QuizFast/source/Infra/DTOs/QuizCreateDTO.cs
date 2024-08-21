namespace QuizFast.source.Infra.DTOs;

public record QuizCreateDTO(string Title, string Description, List<QuestionCreateDTO> Questions)
{
    public string Title { get; set; } = Title;
    public string Description { get; set; } = Description;
    public List<QuestionCreateDTO> Questions { get; set; } = Questions;
}
