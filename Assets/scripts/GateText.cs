using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GateText : MonoBehaviour
{
    private TMP_Text gateText;
    private bool isTextVisible = false;

    private void Start()
    {
        gateText = GetComponent<TMP_Text>();
        HideGateText();
    }

    public void ShowGateText(string textToShow)
    {
        gateText.text = textToShow;
        gateText.enabled = true;
        isTextVisible = true;
    }

    public void HideGateText()
    {
        gateText.enabled = false;
        isTextVisible = false;
    }

    public bool IsTextVisible()
    {
        return isTextVisible;
    }
}
