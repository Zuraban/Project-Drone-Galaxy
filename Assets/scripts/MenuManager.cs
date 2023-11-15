using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public Text bestTimeText;
    private Timer timer;

    private void Start()
    {
        timer = FindObjectOfType<Timer>();

        if (timer != null)
        {
            float bestTime = timer.GetBestTime();
            bestTimeText.text = "Best Time: " + FormatTime(bestTime);
        }
    }

    public void StartGame()
    {
        
    }

    public void LoadLevel(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    private string FormatTime(float timeInSeconds)
    {
        int minutes = Mathf.FloorToInt(timeInSeconds / 60);
        int seconds = Mathf.FloorToInt(timeInSeconds % 60);
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene(0); 
        }
    }
}
