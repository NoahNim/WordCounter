using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTests
  {
    [TestMethod]
    public void ThisGetsWord()
    {
      RepeatCounter userSentence = new RepeatCounter("the dog is red", "dog");
      Assert.AreEqual("the dog is red", userSentence.GetSentence());
    }
    [TestMethod]
    public void ThisSearchesWord()
    {
      RepeatCounter userSentence = new RepeatCounter("the dog is red", "dog");
      Assert.AreEqual("dog", userSentence.SearchWord());
    }
    [TestMethod]
    public void ThisCountsWord()
    {
      RepeatCounter userSentence = new RepeatCounter("the dog is red", "dog");
      Assert.AreEqual(1, userSentence.HowManyWords());
    }
    [TestMethod]
    public void ThisCountsMultipleWords()
    {
      RepeatCounter userSentence = new RepeatCounter("the dog is red, the dog is green, the dog is pink, the dog is black", "dog");
      Assert.AreEqual(4, userSentence.HowManyWords());
    }
    [TestMethod]
    public void ThisCountsUpperWords()
    {
      RepeatCounter userSentence = new RepeatCounter("The Dog is red, the Dog is green, the Dog is pink, the Dog is black", "dog");
      Assert.AreEqual(4, userSentence.HowManyWordsFix());
    }
  }
}
