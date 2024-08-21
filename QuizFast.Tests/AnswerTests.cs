namespace QuizFast.Tests;

using QuizFast.source.Domain.Entities;

[TestClass]
public class AnswerTests
{
    [TestMethod]
    public void CreateAnswerTest()
    {
        // Act
        var answer1 = new Answer("Yes", false);
        var answer2 = new Answer("No", true);
        var answer3 = new Answer("Maybe", false);
        
        // Assert
        Assert.AreEqual("Yes", answer1.Text);
        Assert.AreEqual("No", answer2.Text);
        Assert.AreEqual("Maybe", answer3.Text);

        Assert.IsFalse(answer1.IsCorrect);
        Assert.IsFalse(answer3.IsCorrect);
        
        Assert.IsTrue(answer2.IsCorrect);
    }
}