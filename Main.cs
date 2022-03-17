//Going to recode the whole thing so that the grid is made from data[,] instead of strings of lines.

using System;
using System.Timers;

public class Program {

  public static int Score;
  public static bool isPlaying = false;
  public static float Elapsed = 0f;
  public static Timer timer;
  public static int[,] data = new int[9,9];
  public static bool[] dontMoveData = new bool[10];
  public static int lastMovedTest = 9;
  
  public static void Main(string[] args) {
    dontMoveData[9] = true;
    data[4,0] = 1;
    data[5,0] = 1;
    data[6,0] = 1;
    data[6,1] = 1;
    SetTimer();
    Console.WriteLine("Hello world");
    Console.WriteLine("This is a version of Tetris made by me, QwertyHJKL1234, at school.");
    Console.WriteLine("Press the esc key to clear the game, press the down arrow to start.");
    ReWriteAllLines();
    while (true)
    {
       var ch = Console.ReadKey(false).Key;
       switch(ch)
       {
         case ConsoleKey.Escape:
           isPlaying = false;
           Console.Clear();
          break;
         case ConsoleKey.LeftArrow:
           MoveLeft();
          break;
         case ConsoleKey.RightArrow:
           MoveRight();
          break;
         case ConsoleKey.DownArrow:
           isPlaying = true;
           break;
       }
      if (!isPlaying)
      {
        timer.Enabled = false;
      }
      else
      {
        timer.Enabled = true;
      }
    }
  }
    private static void SetTimer()
    {
        // Create a timer with a two second interval.
        timer = new System.Timers.Timer(1000);
        // Hook up the Elapsed event for the timer. 
        timer.Elapsed += OnTimedEvent;
        timer.AutoReset = true;
        timer.Enabled = true;
    }
    private static void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
      MoveAllDown();
    }
  public static void MoveAllDown()
  {
    if (!isPlaying)
    {
      return;
    }
    int[,] yes = data;
    Array.Copy(yes, 0, data, lastMovedTest, (data.GetLength(0) * data.GetLength(1) - data.GetLength(1)-1));
    lastMovedTest += 9;
    ReWriteAllLines();
  }
  public static void MoveLeft()
  {
    if (!isPlaying)
    {
      return;
    }
  }
  public static void MoveRight()
  {
    if (!isPlaying)
    {
      return;
    }
  }
  public static void ReWriteAllLines()
  {
    Console.Clear();
    Console.WriteLine("TETRIS BY QWERTYHJKL1234");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("Game:");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("Score: " + Score);
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    for (int i = 0; i < data.GetLength(0); i++)
      {
        for (int j = 0; j < data.GetLength(1); j++)
        {
          if (data[j, i] == 1)
          {
            Console.Write("🟥");
          }
          else if (data[j, i] == 0)
          {
            Console.Write("⬛");
          }
          else if (data[j, i] == 2)
          {
            Console.Write("⬜");
          }
        }
        Console.WriteLine();
      }
  }
}