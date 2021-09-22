using System.Collections.Generic;

namespace PrimeSifting.Models
{
  public class PrimeSifter
  {
    public static List<int> PrimeNumbers(int number)
    {
    List<int> numberList = new List<int>();
    List<int> primeList = new List<int>();
      for (int i = 2; i <= number; i++)
      {
        numberList.Add(i);
      }
      foreach (int num in numberList)
      {
        bool isPrime = true;
        for (int prime = 2; prime < num; prime++)
        {
          if (num % prime == 0)
          {
            isPrime = false;
          }
        }
        if (isPrime) {
        primeList.Add(num);
        }
      }
      return primeList;
    }
  }
}