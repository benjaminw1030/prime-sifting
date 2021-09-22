using System;
using System.Collections.Generic;
using PrimeSifting.Models;

namespace PrimeSifting
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Input a number to return prime numbers up to number that is input:");
      string inputString = Console.ReadLine();
      int inputNumber = int.Parse(inputString);
      List<int> result = PrimeSifter.PrimeNumbers(inputNumber);
      foreach (int num in result)
      {
      Console.Write(num + " ");
      }
    }
  }
}
