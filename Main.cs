using System;
using System.Timers;

public class Program {

  public static int Score;
  public static bool isPlaying = false;
  public static float Elapsed = 0f;
  public static Timer timer;
  public static string[] Line1 = new string[] { "⬛", "⬛", "⬛", "⬛", "⬛", "⬜", "⬜", "⬜", "⬛", };
  public static string[] Line2 = new string[] { "⬛", "⬛", "⬛", "⬛", "⬛", "⬛", "⬛", "⬜", "⬛", };
  public static string[] Line3 = new string[] { "⬛", "⬛", "⬛", "⬛", "⬛", "⬛", "⬛", "⬛", "⬛", };
  public static string[] Line4 = new string[] { "⬛", "⬛", "⬛", "⬛", "⬛", "⬛", "⬛", "⬛", "⬛", };
  public static string[] Line5 = new string[] { "⬛", "⬛", "⬛", "⬛", "⬛", "⬛", "⬛", "⬛", "⬛", };
  public static string[] Line6 = new string[] { "⬛", "⬛", "⬛", "⬛", "⬛", "⬛", "⬛", "⬛", "⬛", };
  public static string[] Line7 = new string[] { "⬛", "⬛", "⬛", "⬛", "⬛", "⬛", "⬛", "⬛", "⬛", };
  public static string[] Line8 = new string[] { "⬛", "⬛", "⬛", "⬛", "⬛", "⬛", "⬛", "⬛", "⬛", };
  public static string[] Line9 = new string[] { "⬛", "⬛", "⬛", "⬛", "⬛", "⬛", "⬛", "⬛", "⬛", };
  public static int[,] data = new int[9,9];
  public static bool[] dontMoveData = new bool[10];
  
  public static void Main(string[] args) {
    dontMoveData[9] = true;
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
    if (!dontMoveData[9])
    {
      Line9 = Line8;
    }
    if (!dontMoveData[8])
    {
      Line8 = Line7;
    }
    if (!dontMoveData[7])
    {
      Line7 = Line6;
    }
    if (!dontMoveData[6])
    {
      Line6 = Line5;
    }
    if (!dontMoveData[5])
    {
      Line5 = Line4;
    }
    if (!dontMoveData[4])
    {
      Line4 = Line3;
    }
    if (!dontMoveData[3])
    {
      Line3 = Line2;
    }
    if (!dontMoveData[2])
    {
      Line2 = Line1;
    }
    Line1 = new string[] { "⬛", "⬛", "⬛", "⬛", "⬛", "⬛", "⬛", "⬛", "⬛", };
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
    if (!dontMoveData[1])
    {
      for (int i = 0; i < 9; i++)
      {
      string currentText = Line1[i];
      Console.Write(currentText);
      if (currentText == "⬛")
      {
        data[i, 0] = 0;
      }
      else
      {
        data[i, 0] = 1;
      }
      }
    }
    Console.WriteLine("");
    if (!dontMoveData[2])
    {
    for (int i = 0; i < 9; i++)
    {
      string currentText = Line2[i];
      Console.Write(currentText);
      if (currentText == "⬛")
      {
        data[i, 1] = 0;
      }
      else
      {
        data[i, 1] = 1;
      }
    }
    }
    Console.WriteLine("");
    if (!dontMoveData[3])
    {
    for (int i = 0; i < 9; i++)
    {
      string currentText = Line3[i];
      Console.Write(currentText);
      if (currentText == "⬛")
      {
        data[i, 2] = 0;
      }
      else
      {
        data[i, 2] = 1;
      }
    }
    }
    Console.WriteLine("");
    if (!dontMoveData[4])
    {
    for (int i = 0; i < 9; i++)
    {
      string currentText = Line4[i];
      Console.Write(currentText);
      if (currentText == "⬛")
      {
        data[i, 3] = 0;
      }
      else
      {
        data[i, 3] = 1;
      }
    }
    }
    Console.WriteLine("");
    if (!dontMoveData[5])
    {
    for (int i = 0; i < 9; i++)
    {
      string currentText = Line5[i];
      Console.Write(currentText);
      if (currentText == "⬛")
      {
        data[i, 4] = 0;
      }
      else
      {
        data[i, 4] = 1;
      }
    }
    }
    Console.WriteLine("");
    if (!dontMoveData[6])
    {
    for (int i = 0; i < 9; i++)
    {
      string currentText = Line6[i];
      Console.Write(currentText);
      if (currentText == "⬛")
      {
        data[i, 5] = 0;
      }
      else
      {
        data[i, 5] = 1;
      }
    }
    }
    Console.WriteLine("");
    if (!dontMoveData[7])
    {
    for (int i = 0; i < 9; i++)
    {
       string currentText = Line7[i];
      Console.Write(currentText);
      if (currentText == "⬛")
      {
        data[i, 6] = 0;
      }
      else
      {
        data[i, 6] = 1;
      }
    }
    }
    Console.WriteLine("");
    if (!dontMoveData[8])
    {
    for (int i = 0; i < 9; i++)
    {
      string currentText = Line8[i];
      Console.Write(currentText);
      if (currentText == "⬛")
      {
        data[i, 7] = 0;
      }
      else
      {
        data[i, 7] = 1;
      }
    }
    }
    Console.WriteLine("");
    if (!dontMoveData[9])
    {
    for (int i = 0; i < 9; i++)
    {
      string currentText = Line9[i];
      Console.Write(currentText);
      if (currentText == "⬛")
      {
        data[i, 8] = 0;
      }
      else
      {
        data[i, 8] = 1;
      }
    }
    }
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    for (int i = 0; i < data.GetLength(0); i++)
        {
            for (int j = 0; j < data.GetLength(1); j++) {
                Console.Write("{0} ", data[j, i]);
            }
            Console.WriteLine();
        }
}
}