using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizFast.source.Infra.DTOs;

namespace MyApp.Namespace
{
    [Route("api/create-quiz")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        [HttpPost]
        public ActionResult CreateQuiz([FromBody] QuizCreateDTO quiz)
        {
            Console.WriteLine($"Title: {quiz.Title}, Description: {quiz.Description}");
            foreach (var question in quiz.Questions)
            {
                Console.WriteLine($"Question: {question.Text}");
                foreach (var answer in question.Answers)
                {
                    Console.WriteLine($"Answer: {answer.Text}, IsCorrect: {answer.IsCorrect}");
                }
            }
            
            return Ok();
        }
    }
}
