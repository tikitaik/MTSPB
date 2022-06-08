using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Typer : MonoBehaviour
{
    public WordBank wordBank = null;
    public Text wordOutput = null;

    private string remainingWord = string.Empty;
    private string currentWord = string.Empty;

    public float letterCorrect;
    public float letterIncorrect;

    public AudioClip keyStroke;
    AudioSource audioSource;
    
    private void Start()
    {
        SetCurrentWord();
        audioSource = GetComponent<AudioSource>();
    }

    private void SetCurrentWord()
    {
        currentWord = wordBank.GetWord();
        SetRemainingWord(currentWord);
    }

    private void SetRemainingWord(string newString)
    {
        remainingWord = newString;
        wordOutput.text = remainingWord;
    }

    private void Update()
    {
        CheckInupt();
    }

    private void CheckInupt()
    {
        if(Input.anyKeyDown)
        {
            audioSource.PlayOneShot(keyStroke, 0.5f);
            string keysPressed = Input.inputString;

            if(keysPressed.Length == 1)
                EnterLetter(keysPressed);
        }
    }

    private void EnterLetter(string typedLetter)
    {
        if(IsCorrectLetter(typedLetter))
        {
            RemoveLetter();
            letterCorrect += 1;

            if(IsWordComplete())
                SetCurrentWord();
        }

        else
        {
            letterIncorrect += 1;
        }
    }

    private bool IsCorrectLetter(string letter)
    {
        return remainingWord.IndexOf(letter) == 0;
    }

    private void RemoveLetter()
    {
        string newString = remainingWord.Remove(0, 1);
        SetRemainingWord(newString);
    }

    private bool IsWordComplete()
    {
        return remainingWord.Length == 0;
    }
}