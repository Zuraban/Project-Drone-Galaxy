using UnityEngine;
//using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText; // Ссылка на текстовое поле, где отображается время таймера
    public TMP_Text gameOverText; // Ссылка на текстовое поле для вывода "Game Over"
    public TMP_Text GateText;
    public float gameTime = 30.0f; // Время игры в секундах
    public float gameOverTime = 20.0f; // Время, после которого будет отображен текст "Game Over"
    private float bestTime = Mathf.Infinity; // Лучшее время
    private float startTime;
    private bool isRunning = false;
    public bool IsRunning() //  проверка статуса таймера
    {
        return isRunning;
    }

    private void Start()
    {
        startTime = Time.time;
        isRunning = true;
    }

    private void Update()
    {
        if (isRunning)
        {
            float currentTime = Time.time - startTime;

            // текущее время  для отображения
            string minutes = Mathf.FloorToInt(currentTime / 60).ToString("00");
            string seconds = Mathf.FloorToInt(currentTime % 60).ToString("00");
            timerText.text = minutes + ":" + seconds;

            // отображения текста "Game Over"
            if (currentTime >= gameTime)
            {
                isRunning = false;
                ShowGameOverText();

                // Сравнение текущего с лучшим временем
                if (currentTime < bestTime)
                {
                    bestTime = currentTime;
                }
            }

            // Если текущее больше или равно времени для отображения "Game Over"
            if (currentTime >= gameOverTime)
            {

                gameOverText.enabled = true; // Отобразить надпись "Game Over"

                
            }

            
        }
    }

    public float GetBestTime()
    {
        return bestTime;
    }

    public void StopTimer()
    {
        isRunning = false;
        if (Time.time - startTime < bestTime)
        {
            bestTime = Time.time - startTime;
        }
    }

    private void ShowGameOverText()
    {
        gameOverText.gameObject.SetActive(true);
        gameOverText.text = "Game Over " ;
    }

    private string FormatTime(float timeInSeconds)
    {
        int minutes = Mathf.FloorToInt(timeInSeconds / 60);
        int seconds = Mathf.FloorToInt(timeInSeconds % 60);
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}

