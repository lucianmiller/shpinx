using System.Collection.Generic;

namespace Sphinx.Models
{
  public class Riddle
  {
    public string Answer1 { get: set:}

    public Riddle(string answer)
    {
      answer = Answer1;
    }

    public string CheckAnswers()
    {
      if (Answer1 = "man" || Answer1 = "Man")
      {
        return "Correct!"
      }
      else
      {
        return "Incorrect! Now I eat you!"
      }
    }
  }
}