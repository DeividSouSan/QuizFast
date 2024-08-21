namespace QuizFast.Tests;
using QuizFast.source.Domain.Entities;

[TestClass]
public class QuestionTest
{
    [TestMethod]
    public void CreateQuestionTest()
    {
        var question = new Question("What is the capital of France?");

        question.AddAnswer(new Answer("Paris", false));
        question.AddAnswer(new Answer("São Paulo", true));
        question.AddAnswer(new Answer("New York", false));
        question.AddAnswer(new Answer("Barcelona", false));

        Assert.AreEqual("What is the capital of France?", question.Text);
        Assert.AreEqual(4, question.Answers.Count);
        Assert.AreEqual(1, question.CorrectAnswersCount());
    }

    public void RemoveAnswer()
    {
        var question = new Question("What is the capital of France?");

        question.AddAnswer(new Answer("Paris", false));
        question.AddAnswer(new Answer("São Paulo", true));
        question.AddAnswer(new Answer("New York", false));
        question.AddAnswer(new Answer("Barcelona", false));

        question.RemoveAnswer(3);

        Assert.AreEqual("What is the capital of France?", question.Text);
        Assert.AreEqual(3, question.Answers.Count);
        Assert.AreNotEqual("New York", question.GetAnswerText(3));
        Assert.AreEqual(1, question.CorrectAnswersCount());
    }
}