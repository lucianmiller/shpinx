using System;
using Sphinx.Models; 

namespace Sphinx
{
  class Program
  {
    static void Main()
    {
      Riddle riddle = new Riddle();
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~");
      Console.WriteLine("I'm the sphinx. If you answer my riddles, you may pass. If you don't, I will eat you!");
      for (int index = 0; index < riddle.Questions.Count; index++)
      {
        if (riddle.ContinueGame)
        {
          Console.WriteLine(riddle.Questions[index]);
          string userAnswer = Console.ReadLine();
          Console.WriteLine(riddle.CheckAnswers(userAnswer, index));
        }
      }
    }
  }
}