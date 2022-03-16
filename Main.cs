using System;
using System.Timers;

public class Program {

  public static int Score;
  public static bool isPlaying = false;
  public static float Elapsed = 0f;
  public static Timer timer;
  public static string[] Line1 = new string[] { "⬜", "⬜", "", "", "", "", "", "", "", };
  public static string[] Line2 = new string[] { "", "", "", "", "", "", "", "", "", };
  public static string[] Line3 = new string[] { "", "", "", "", "", "", "", "", "", };
  public static string[] Line4 = new string[] { "", "", "", "", "", "", "", "", "", };
  public static string[] Line5 = new string[] { "", "", "", "", "", "", "", "", "", };
  public static string[] Line6 = new string[] { "", "", "", "", "", "", "", "", "", };
  public static string[] Line7 = new string[] { "", "", "", "", "", "", "", "", "", };
  public static string[] Line8 = new string[] { "", "", "", "", "", "", "", "", "", };
  public static string[] Line9 = new string[] { "", "", "", "", "", "", "", "", "", };
  public static string[] Line10 = new string[] { "", "", "", "", "", "", "", "", "", };
  public static void Main(string[] args) {
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
    Line10 = Line9;
    Line9 = Line8;
    Line8 = Line7;
    Line7 = Line6;
    Line6 = Line5;
    Line5 = Line4;
    Line4 = Line3;
    Line3 = Line2;
    Line2 = Line1;
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
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("Score: " + Score);
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    for (int i = 0; i < 9; i++)
    {
      Console.Write(Line1[i]);
    }
    Console.WriteLine("");
    for (int i = 0; i < 9; i++)
    {
      Console.Write(Line2[i]);
    }
    Console.WriteLine("");
    for (int i = 0; i < 9; i++)
    {
      Console.Write(Line3[i]);
    }
    Console.WriteLine("");
    for (int i = 0; i < 9; i++)
    {
      Console.Write(Line4[i]);
    }
    Console.WriteLine("");
    for (int i = 0; i < 9; i++)
    {
      Console.Write(Line5[i]);
    }
    Console.WriteLine("");
    for (int i = 0; i < 9; i++)
    {
      Console.Write(Line6[i]);
    }
    Console.WriteLine("");
    for (int i = 0; i < 9; i++)
    {
      Console.Write(Line7[i]);
    }
    Console.WriteLine("");
    for (int i = 0; i < 9; i++)
    {
      Console.Write(Line8[i]);
    }
    Console.WriteLine("");
    for (int i = 0; i < 9; i++)
    {
      Console.Write(Line9[i]);
    }
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
  }
}