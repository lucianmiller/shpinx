using System;
using Sphinx.Models; 

namespace Sphinx
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~");
      Console.WriteLine("I'm the sphinx. If you answer my riddles, you may pass. If you don't, I will eat you!");
      Console.WriteLine("First Riddle: What has one voice but goes on four legs in the morning, two in the afternoon, and three in the evening?");
      string userAnswer1 = Console.ReadLine();
      Riddle riddle = new Riddle(userAnswer1);
      Console.WriteLine(riddle.CheckAnswers());
    }
  }
}