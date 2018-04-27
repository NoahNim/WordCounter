
using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _sentence;
    private string _findWord;
    private int _count = 0;

    public RepeatCounter(string sentence, string findWord)
    {
      _sentence = sentence;
      _findWord = findWord;
    }

    public string GetSentence()
    {
      return _sentence;
    }
    public string SearchWord()
    {
      return _findWord;
    }

    public int HowManyWords()
    {
      foreach(string word in _sentence.Split())
      {
        if (word == _findWord)
        {
          _count++;
        }
      }
      return _count;
    }

  }
}
