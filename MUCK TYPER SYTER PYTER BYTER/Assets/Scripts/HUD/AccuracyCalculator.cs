using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccuracyCalculator : MonoBehaviour
{
    public Text accuracyMetric;

    private float letterRight;
    private float letterWrong;
    private float accuracyDone;

    private void Awake()
    {
        letterRight = 0;
        letterWrong = 0;
        accuracyDone = 0;
    }

    private void Update()
    {
        accCalculator();
    }

    private void accCalculator()
    {
        letterRight = GameObject.Find("Typer").GetComponent<Typer>().letterCorrect;
        letterWrong = GameObject.Find("Typer").GetComponent<Typer>().letterIncorrect;

        if (letterRight != 0 || letterWrong != 0)
            accuracyDone = (letterRight / (letterRight + letterWrong) * 100);
        else
            accuracyDone = 0;

        accuracyMetric.text = "Acc: " + accuracyDone.ToString("000") + "%";
    }
}
