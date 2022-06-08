using UnityEngine;
using System.Linq;
using System;

public class Keyboard : MonoBehaviour
{
    string [] keyboardCode = {"QWERTYUIOP", "ASDFGHJKL", "ZXCVBNM"};
    string [] shuffledKeyboardCode = {"", "", ""};
    string [] keyboardNames = {"KeyboardTop", "KeyboardMiddle", "KeyboardBottom"};
    int [] rowKeyNumbers = {10, 9, 7};

    private void Awake()
    {
        ShuffleKeyCodes();

        for (int i = 0; i < 3; i++)
        {
            string codeForRow = shuffledKeyboardCode[i];
            string keyboardRowID = keyboardNames[i];

            for (int n = 0; n < codeForRow.Length; n++)
            {
                string newButtonText = codeForRow[n].ToString();
                transform.Find(keyboardRowID).GetChild(n).gameObject.GetComponent<Keys>().updateButtonText(newButtonText);
            }
        }
    }

    private void ShuffleKeyCodes()
    {
        for (int i = 0; i < 3; i++)
        {
            string shuffledCode = new (keyboardCode[i].ToCharArray().OrderBy(x=>Guid.NewGuid()).ToArray());
            
            shuffledKeyboardCode[i] = shuffledCode;
        }
    }
}