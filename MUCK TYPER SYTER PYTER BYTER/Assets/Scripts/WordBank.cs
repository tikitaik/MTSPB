using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordBank : MonoBehaviour
{
    // words per minute counter
    public float wordsCompleted = 0;

    // level contents
    private List<string> originalWords = new List<string>();
    private List<string> workingWords = new List<string>();

    private List<string> levelOne = new List<string>()
    {
        "jeffie ", "dear ", "i ", "need ", "a ", "big ", "boy ", "chunk ", "of ", "your ", "company ", "love ", "zuck"
    };

    // functions 
    private void Awake()
    {
        originalWords.AddRange(levelOne);
        originalWords.Reverse();
        workingWords.AddRange(originalWords);
        ConverToLower(workingWords);
    }

    private void ConverToLower(List<string> list)
    {
        for (int i = 0; i < list.Count; i++)
            list[i] = list[i].ToLower();
    }

    public string GetWord()
    {
        string newWord = string.Empty;
        if(workingWords.Count != 0)
        {
            newWord = workingWords.Last();
            workingWords.Remove(newWord);
            wordsCompleted += 1;
        }

        return newWord;
    }
}
