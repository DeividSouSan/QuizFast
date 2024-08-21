namespace QuizFast.source.Infra.DTOs;

public record QuestionCreateDTO(string Text, List<AnswerCreateDTO> Answers)
{
    public string Text { get; set; } = Text;
    public List<AnswerCreateDTO> Answers { get; set; } = Answers;
}
