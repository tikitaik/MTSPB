using UnityEngine;
using UnityEngine.UI;

public class Keys : MonoBehaviour
{
    private Text keyButtonText;

    public KeyCode keyButtonCode;

    private Button _button;

    private void Awake()
    {
        _button = GetComponentInChildren<Button>();
    }

    void Update()
    {
        if(Input.GetKeyDown(keyButtonCode))
        {
            FadeToColor(_button.colors.pressedColor);
            // click the button
            _button.onClick.Invoke();
        }
        else if (Input.GetKeyUp(keyButtonCode))
        {
            FadeToColor(_button.colors.normalColor);
        }
    }

    void FadeToColor(Color color)
    {
        Graphic graphic = GetComponent<Graphic>();
        graphic.CrossFadeColor(color, _button.colors.fadeDuration, true, true);
    }

    public void updateButtonText(string _text)
    {
        keyButtonText = GetComponentInChildren<Text>();
        keyButtonText.text = _text;
        keyButtonCode = (KeyCode) System.Enum.Parse(typeof(KeyCode), _text);
    }
}