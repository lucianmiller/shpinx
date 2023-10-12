using System.Collections.Generic;

namespace Sphinx.Models
{
  public class Riddle
  {
    public List<string> Answers { get; set; }
    public bool ContinueGame { get; set; }

    public Riddle()
    {
      Answers = new List<string> {"man", "footsteps"};
      ContinueGame = true;
    }

    public string CheckAnswers(string userAnswer, int questionNum)
    {
      if (Answers[questionNum-1].ToLower() == userAnswer)
      {
        return "Correct!";
      }
      else
      {
        ContinueGame = false;
        return "Incorrect! Now I eat you!";
      }
    }
  }
}