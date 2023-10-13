using System.Collections.Generic;

namespace Sphinx.Models
{
  public class Riddle
  {
    public List<string> Answers { get; set; }
    public List<string> Questions { get; set; }
    public bool ContinueGame { get; set; }

    public Riddle()
    {
      Answers = new List<string> {"man", "footsteps", "sponge"};
      Questions = new List<string> {
        "First Riddle: What has one voice but goes on four legs in the morning, two in the afternoon, and three in the evening?",
        "Second Riddle: The more you take, the more you leave behind. What am I?",
        "Third Riddle: What is full of holes but still holds water?"
      };
      ContinueGame = true;
    }

    public string CheckAnswers(string userAnswer, int questionNum)
    {
      if (Answers[questionNum].ToLower() == userAnswer)
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