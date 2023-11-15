using UnityEngine;
//using UnityEngine.UI;
using TMPro;

public class GameOverText : MonoBehaviour
{
    private TMP_Text gameOverText;

    private void Start()
    {
        gameOverText = GetComponent<TMP_Text>();
        HideGameOverText();
    }

    public void ShowGameOverText()
    {
        gameOverText.enabled = true;
    }

    public void HideGameOverText()
    {
        gameOverText.enabled = false;
    }
}
