using UnityEngine;
using UnityEngine.UI;

public class BestTimeDisplay : MonoBehaviour
{
    public Text bestTimeText;
    private Timer timer;

    [System.Obsolete]
    private void Start()
    {
        bestTimeText.text = "";
        timer = FindObjectOfType<Timer>();
    }

    private void Update()
    {
        if (timer != null && !timer.IsRunning()) 
        {
            float bestTime = timer.GetBestTime();
            bestTimeText.text = "Best Time: " + FormatTime(bestTime);
        }
    }

    private string FormatTime(float timeInSeconds)
    {
        int minutes = Mathf.FloorToInt(timeInSeconds / 60);
        int seconds = Mathf.FloorToInt(timeInSeconds % 60);
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
