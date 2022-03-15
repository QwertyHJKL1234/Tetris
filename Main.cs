using System;
using System.IO;

public class Program {

  public static int Score;
  public static bool isPlaying = false;
  public static string[] Line1 = new string[] { "", "", "", "", "", "", "", "", "", };
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
          return;
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
      
    }
  }
  public static void MoveAllDown()
  {
    if (!isPlaying)
    {
      return;
    }
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
    Console.WriteLine("Score: " + Score);
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine(Line1[0]);
    for (int i = 1; i < 9; i++)
    {
      Console.Write(Line1[i]);
    }
    Console.WriteLine(Line2[0]);
    for (int i = 1; i < 9; i++)
    {
      Console.Write(Line2[i]);
    }
    Console.WriteLine(Line3[0]);
    for (int i = 1; i < 9; i++)
    {
      Console.Write(Line3[i]);
    }Console.WriteLine(Line4[0]);
    for (int i = 1; i < 9; i++)
    {
      Console.Write(Line4[i]);
    }
    Console.WriteLine(Line5[0]);
    for (int i = 1; i < 9; i++)
    {
      Console.Write(Line5[i]);
    }
    Console.WriteLine(Line6[0]);
    for (int i = 1; i < 9; i++)
    {
      Console.Write(Line6[i]);
    }
    Console.WriteLine(Line7[0]);
    for (int i = 1; i < 9; i++)
    {
      Console.Write(Line7[i]);
    }
    Console.WriteLine(Line8[0]);
    for (int i = 1; i < 9; i++)
    {
      Console.Write(Line8[i]);
    }
    Console.WriteLine(Line9[0]);
    for (int i = 1; i < 9; i++)
    {
      Console.Write(Line9[i]);
    }
  }
}