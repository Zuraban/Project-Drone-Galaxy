using UnityEngine;
using TMPro;

public class BlinkingText : MonoBehaviour
{
    public float blinkInterval = 0.5f; 
    private TextMeshProUGUI textComponent;
    private bool isTextVisible = true;

    private void Start()
    {
        textComponent = GetComponent<TextMeshProUGUI>();

        
        StartCoroutine(BlinkText());
    }

    private System.Collections.IEnumerator BlinkText()
    {
        while (true)
        {
            
            isTextVisible = !isTextVisible;

            
            textComponent.enabled = isTextVisible;

            
            yield return new WaitForSeconds(blinkInterval);
        }
    }
}
