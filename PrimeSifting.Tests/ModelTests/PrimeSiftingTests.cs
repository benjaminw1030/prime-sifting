using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PrimeSifting.Models;
using System;

namespace PrimeSifting.Tests
{
  [TestClass]
  public class PrimeSifting
  {
    [TestMethod]
    public void PrimeNumbers_ReturnsAList_List()
    {
      List<int> primeNumbers = new List<int> { 2, 3, 5, 7, 11, 1 };
      List<int> primeResult = PrimeSifter.PrimeNumbers(100);
      foreach (int num in primeResult)
      {
      Console.Write(num + " ");
      }
      CollectionAssert.AreEqual(primeNumbers, primeResult);
    }
  }
}